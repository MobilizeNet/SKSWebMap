using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;

namespace SKS
{
	internal partial class frmActionOrderRequest
		: System.Windows.Forms.Form
	{

		public frmActionOrderRequest()
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


		private void frmActionOrderRequest_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		private double currentSubTotal = 0;
		private double currentTotal = 0;
		private double currentTax = 0;
		private double currentFreightCharge = 0;
		private double currentTotalTax = 0;

		public int Action = 0;

		public int OrderId = 0;

		private void cmdApprove_Click(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				if (txtStatus.Text.ToUpper() == "APPROVED")
				{
					modMain.LogStatus("Order is already approved, not need to be approved again", this);
					return;
				}

				if (txtStatus.Text.ToUpper() == "CANCELLED")
				{
					modMain.LogStatus("Order was already cancelled by " + txtChangedBy.Text + " on " + txtChanged.Text + ", it cannot be approved", this);
					return;
				}

				// UPDATE
				modConnection.ExecuteSql("Update OrderRequests Set Status = 'APPROVED', ChangedBy = '" + modMain.UserId + "', ChangedDate = '" + DateTimeHelper.ToString(DateTime.Today) + "'" + 
				                         " Where OrderId = " + OrderId.ToString());

				LoadData();
				MessageBox.Show("The order was successfully approved", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
				this.Close();
			}
			catch (System.Exception excep)
			{
				//UPGRADE_WARNING: (2081) Err.Number has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2081
				MessageBox.Show("An error has occurred adding the data. Error: (" + Information.Err().Number.ToString() + ") " + excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
		{
			try
			{
				if (txtStatus.Text.ToUpper() == "CANCELLED")
				{
					modMain.LogStatus("Order was already cancelled, not need to be cancelled again", this);
					return;
				}
				if (txtStatus.Text.ToUpper() == "APPROVED")
				{
					modMain.LogStatus("Order was already approved by " + txtChangedBy.Text + " on " + txtChanged.Text + ", it cannot be cancelled", this);
					return;
				}


				if (MessageBox.Show("Do you want to cancel the order request?", "Confirm cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
				{
					return;
				}

				// UPDATE
				modConnection.ExecuteSql("Update OrderRequests Set Status = 'CANCELLED', ChangedBy = '" + modMain.UserId + "', ChangedDate = '" + DateTimeHelper.ToString(DateTime.Today) + "'" + 
				                         " Where OrderId = " + OrderId.ToString());

				LoadData();
				MessageBox.Show("The order was successfully cancelled", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()));
				this.Close();
			}
			catch (System.Exception excep)
			{
				//UPGRADE_WARNING: (2081) Err.Number has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2081
				MessageBox.Show("An error has occurred adding the data. Error: (" + Information.Err().Number.ToString() + ") " + excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		//UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
		private void Form_Load()
		{
			// LoadData
			if (Action != 0)
			{

				switch((Action))
				{
					case 1 : 
						// cmdApprove_Click 
						break;
					case 2 : 
						// cmdCancel_Click 
						break;
				}
			}
		}

		public void LoadData()
		{
			currentSubTotal = 0;
			currentTotalTax = 0;
			modConnection.ExecuteSql("Select o.OrderDate, u.Fullname, o.Status, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName as Contact, o.ChangedDate, o.ChangedBy, o.FreightCharge, o.SalesTaxRate, o.RequiredByDate, o.PromisedByDate, o.Notes " + 
			                         "From OrderRequests as o, Users as u, Customers as c " + 
			                         "Where o.OrderID = " + OrderId.ToString() + " And u.Username = o.EmployeeId And c.CustomerId = o.CustomerId");
			if (modConnection.rs.EOF)
			{
				modMain.LogStatus("The order with the ID '" + OrderId.ToString() + "' does not exist", this);
				return;
			}
			txtOrderID.Text = OrderId.ToString();
			txtReceived.Text = Convert.ToString(modConnection.rs["OrderDate"]);
			txtReceivedBy.Text = Convert.ToString(modConnection.rs["Fullname"]);
			//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://docs.mobilize.net/vbuc/ewis#1049
			if (!System.DBNull.Value.Equals(modConnection.rs["Notes"]))
			{
				txtNotes.Text = Convert.ToString(modConnection.rs["Notes"]);
			}
			txtFreightCharge.Text = Convert.ToString(modConnection.rs["FreightCharge"]);
			currentFreightCharge = Convert.ToDouble(modConnection.rs["FreightCharge"]);
			txtSalesTax.Text = Convert.ToString(modConnection.rs["SalesTaxRate"]);
			currentTax = Convert.ToDouble(modConnection.rs["SalesTaxRate"]);
			txtCustomerCompany.Text = Convert.ToString(modConnection.rs["CompanyName"]);
			txtCustomerContact.Text = Convert.ToString(modConnection.rs["Contact"]);
			txtStatus.Text = Convert.ToString(modConnection.rs["Status"]);
			txtRequiredBy.Text = Convert.ToString(modConnection.rs["RequiredByDate"]);
			txtPromisedBy.Text = Convert.ToString(modConnection.rs["PromisedByDate"]);
			//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://docs.mobilize.net/vbuc/ewis#1049
			if (!System.DBNull.Value.Equals(modConnection.rs["ChangedDate"]))
			{
				txtChanged.Text = Convert.ToString(modConnection.rs["ChangedDate"]);
			}
			//UPGRADE_WARNING: (1049) Use of Null/IsNull() detected. More Information: https://docs.mobilize.net/vbuc/ewis#1049
			if (!System.DBNull.Value.Equals(modConnection.rs["ChangedBy"]))
			{
				txtChangedBy.Text = Convert.ToString(modConnection.rs["ChangedBy"]);
			}

			bool isRequested = txtStatus.Text == "REQUESTED";
			lblChanged.Visible = !isRequested;
			lblChangedBy.Visible = !isRequested;
			txtChanged.Visible = !isRequested;
			txtChangedBy.Visible = !isRequested;
			cmdApprove.Enabled = true; // Requested
			cmdCancel.Enabled = true; // Requested

			if (txtStatus.Text == "APPROVED")
			{
				lblChanged.Text = "Approved Date:";
				lblChangedBy.Text = "Approved By:";
			}
			else
			{
				lblChanged.Text = "Cancelled Date:";
				lblChangedBy.Text = "Cancelled By:";
			}
			LoadDetails();
			DisplayTotals();
		}

		private void DisplayTotals()
		{
			currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax;
			txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00");
			txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00");
			txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00");
		}


		private void AddToTotals(double current)
		{
			currentSubTotal += current;
			currentTotalTax = currentSubTotal * currentTax;
			currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax;
			txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00");
			txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00");
			txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00");
		}


		private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
		}

		private void LoadDetails()
		{

			modConnection.ExecuteSql("Select d.Quantity, p.ProductID, p.ProductName, d.UnitPrice, d.SalePrice, p.UnitsInStock, p.UnitsOnOrder, cast(p.QuantityPerUnit as text) + p.Unit, d.LineTotal From Products as p, OrderRequestDetails as d " + "Where d.OrderID = " + OrderId.ToString() + " And d.ProductId = p.ProductId");

			int lng = 0;
			int intLoopCount = 0;
			int i = 0;
			fgDetails.RowsCount = 0;
			fgDetails.ColumnsCount = 9;
			fgDetails.FixedColumns = 0;
			fgDetails.AddItem("Quantity" + "\t" + "Code" + "\t" + "Product" + "\t" + "UnitPrice" + "\t" + "Price" + "\t" + "Existence" + "\t" + "Ordered" + "\t" + "Quantity per unit" + "\t" + "Line Total");
			fgDetails.RowsCount = modConnection.rs.RecordCount + 1;
			if (fgDetails.RowsCount == 1)
			{
				fgDetails.FixedRows = 0;
			}
			else
			{
				fgDetails.FixedRows = 1;
			}
			i = 1;
			while (!modConnection.rs.EOF)
			{
				int tempForEndVar = modConnection.rs.FieldsMetadata.Count;
				for (int j = 1; j <= tempForEndVar; j++)
				{
					//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
					if (!(modConnection.rs.GetField(i) is null))
					{
						fgDetails[i, j - 1].Value = Convert.ToString(modConnection.rs[j - 1]);
					}
				}
				AddToTotals(Convert.ToDouble(modConnection.rs["LineTotal"]));
				modConnection.rs.MoveNext();
				i++;
			}

		}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}