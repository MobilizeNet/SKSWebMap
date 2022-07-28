using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;

namespace SKS
{
	internal partial class frmCustomers
		: System.Windows.Forms.Form
	{

		public frmCustomers()
			: base()
		{
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
			ReLoadForm(false);
		}


		private void frmCustomers_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		private bool NewMode = false;
		private bool EditMode = false;
		private bool CancellingMode = false;
		public string CurrentCustomerID = "";



		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
			CurrentCustomerID = Convert.ToString(dcCustomers.Recordset["CustomerId"]);
		}


		//Private Sub dcCustomers_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
		//NewMode = False
		//EditMode = False
		//CancellingMode = False
		//End Sub

		//Private Sub dcCustomers_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
		//CancellingMode = True
		//End Sub

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
		private void Form_Load()
		{
			InitForm();
		}

		public void InitForm()
		{
			dcCustomers.ConnectionString = modMain.ConnectionString;
			NewMode = false;
			EditMode = false;
			CancellingMode = false;
		}

		private void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
		{
			ToolStripItem Button = (ToolStripItem) eventSender;
			object x = null;
			int newCustomerId = 0;
			switch(Button.Text)
			{
				case "Add" : 
					//Add new record 
					NewMode = true; 
					dcCustomers.Recordset.AddNew(); 
					break;
				case "Edit" : 
					//Edit mode 
					EditMode = true; 
					break;
				case "Save" : 
					//Save data 
					dcCustomers.Recordset.Update(); 
					dcCustomers.Recordset.Requery();  // SQLite ODBC driver needs to requery the info 
					EditMode = false; 
					NewMode = false; 
					break;
				case "Delete" : 
					//Delete record 
					if (MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
					{
						dcCustomers.Recordset.Delete();
						dcCustomers.Recordset.Requery();
					} 
					break;
				case "Search" : 
					//Search for records 
					modFunctions.SearchShow("Customers", "CompanyName", "customer"); 
					break;
				case "Cancel" : 
					CancellingMode = true; 
					//Cancel edited changes 
					EditMode = false; 
					NewMode = false; 
					dcCustomers.Recordset.CancelUpdate(); 
					dcCustomers.Recordset.Requery(); 
					CancellingMode = false; 
					this.Close(); 
					break;
			}
		}

		private void txtField_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			if (!CancellingMode)
			{
				EditMode = true;
			}
		}

		//Used already in frmSearch
		public void SearchCriteriaProducts(string field, string value)
		{
			modConnection.ExecuteSql("Select * from Customers where " + field + " LIKE '" + value + "%'");
			if (modConnection.rs.RecordCount == 0)
			{
				MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " that meet with the selected criteria");
				dcCustomers.Recordset = modConnection.rs;
			}
		}
	}
}