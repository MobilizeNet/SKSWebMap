using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui;

namespace SKS
{
	internal partial class frmSearch
		: System.Windows.Forms.Form
	{

		public frmSearch()
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
		}


		private void frmSearch_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}
		string SearchTable = "";
		private void cboSrchBy_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
		{
			lblSrchBy.Text = cboSrchBy.Text;
		}

		private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
		}


		public void Search(string Table, string fieldToSearch, string itemToSearch)
		{
			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
			if (!String.IsNullOrEmpty(itemToSearch))
			{
				Label20.Text = "Search for a " + itemToSearch;
			}
			SearchTable = Table;
			modConnection.ExecuteSql("Select * from " + Table + " limit 1;");
			int tempForEndVar = (modConnection.rs.FieldsMetadata.Count - 1);
			for (modMain.i = 0; modMain.i <= tempForEndVar; modMain.i++)
			{
				cboSrchBy.AddItem(modConnection.rs.GetField(modMain.i).FieldMetadata.ColumnName);
			}
			cboSrchBy.Text = fieldToSearch;
		}

		private void cmdSearch_Click(Object eventSender, EventArgs eventArgs)
		{
			if (txtSrchStr.Text.Substring(Math.Max(txtSrchStr.Text.Length - 1, 0)) == "'")
			{
				txtSrchStr.Text = "";
			}
			string txtToSearch = "";

			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
			if (!String.IsNullOrEmpty(txtSrchStr.Text.Trim()))
			{
				txtToSearch = txtSrchStr.Text;
			}
			else
			{
				txtToSearch = "%";
			}
			if (SearchTable == "Customers")
			{
				SearchCriteriaCustomers(lblSrchBy.Text, txtToSearch);
			}
			else if (SearchTable == "Products")
			{ 
				SearchCriteriaProducts(lblSrchBy.Text, txtToSearch);
			}
			else if (SearchTable == "Providers")
			{ 
				SearchCriteriaProviders(lblSrchBy.Text, txtToSearch);
			}
		}

		//''
		public void SearchCriteriaCustomers(string field, string value)
		{
			modConnection.ExecuteSql("Select * from Customers where " + field + " LIKE '" + value + "%'");
			if (modConnection.rs.RecordCount == 0)
			{
				MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " that meet with the selected criteria");
				frmCustomers.DefInstance.dcCustomers.Recordset = modConnection.rs;
			}
		}

		public void SearchCriteriaProducts(string field, string value)
		{
			modConnection.ExecuteSql("Select * from Products where " + field + " LIKE '" + value + "%'");
			if (modConnection.rs.RecordCount == 0)
			{
				MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				frmProducts.DefInstance.dcProducts.Recordset = modConnection.rs;
			}
		}

		public void SearchCriteriaProviders(string field, string value)
		{
			modConnection.ExecuteSql("Select * from Providers where " + field + " LIKE '" + value + "%'");
			if (modConnection.rs.RecordCount == 0)
			{
				MessageBox.Show("There are no records with the selected criteria", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " that meet with the selected criteria");
				frmProviders.DefInstance.dcProviders.Recordset = modConnection.rs;
			}
		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}