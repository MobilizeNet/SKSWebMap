using System;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmRequestApproval
      : Mobilize.Web.Form
   {

      public frmRequestApproval()
      : base()
      {
         if ( m_vb6FormDefInstance is null )
         {
            if ( m_InitializingDefInstance )
            {
               m_vb6FormDefInstance = this;
            }
            else
            {
               try
               {
                  //For the start-up form, the first instance created is the default instance.
                  if ( !(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType() )
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

      private void frmRequestApproval_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender )
         {
            Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (Mobilize.Web.Form)eventSender;
         }
      }

      [Intercepted]
      private string Id { get; set; } = "";

      private void cmbStatus_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchRequest();
      }

      private void cmdApprove_Click(Object eventSender, EventArgs eventArgs)
      {
         LoadActionOrderRequest(1);
      }

      private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
      {
         LoadActionOrderRequest(2);
      }

      private void cmdInfo_Click(Object eventSender, EventArgs eventArgs)
      {
         LoadActionOrderRequest();
      }

      private void LoadActionOrderRequest(int Action = 0)
      {
         int OrderId = 0;
         if ( fgOrders.CurrentRowIndex > 0 )
         {
            OrderId = Convert.ToInt32(Double.Parse(Convert.ToString(fgOrders[fgOrders.CurrentRowIndex, 1].Value)));
            frmActionOrderRequest.DefInstance.OrderId = OrderId;
            frmActionOrderRequest.DefInstance.Action = Action;
            frmActionOrderRequest.DefInstance.LoadData();
            frmActionOrderRequest.DefInstance.Show();
         }
      }

      private void dtFrom_ValueChanged(Object eventSender, EventArgs eventArgs)
      {
         chkFrom.CheckState = Mobilize.Web.CheckState.Checked;
         DoSearchRequest();
      }

      private void dtTo_ValueChanged(Object eventSender, EventArgs eventArgs)
      {
         chkTo.CheckState = Mobilize.Web.CheckState.Checked;
         DoSearchRequest();
      }

      private void fgOrders_DoubleClick(Object eventSender, EventArgs eventArgs)
      {
         cmdInfo_Click(cmdInfo, new EventArgs());
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
      private void Form_Load()
      {
         InitGrid();
      }

      private void txtOrderID_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchRequest();
      }

      private void txtProductID_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchRequest();
      }

      private void txtCompanyName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchRequest();
      }

      private void txtContactLastName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchRequest();
      }

      private void txtContactName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchRequest();
      }

      //UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
      //private void txtName_Change()
      //{
      //DoSearchRequest();
      //}
      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

      private void cmdCustomers_Click(Object eventSender, EventArgs eventArgs)
      {
         frmCustomers.DefInstance.ShowDialog();
         txtCompanyName.Text = "";
         txtContactLastName.Text = "";
         txtContactName.Text = "";
         DoSearchRequest(Convert.ToInt32(Double.Parse(frmCustomers.DefInstance.CurrentCustomerID)));
         frmCustomers.DefInstance.Close();
      }

      private void DoSearchRequest(int Id = -1)
      {
         string filter = "";
         if ( Id != -1 )
         {
            filter = "o.CustomerID = " + Id.ToString();
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtCompanyName.Text) )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = "c.CompanyName LIKE '%" + txtCompanyName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtContactName.Text) )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "c.ContactFirstName LIKE '%" + txtContactName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtContactLastName.Text) )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "c.ContactLastName LIKE '%" + txtContactLastName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtOrderID.Text) )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.OrderID = " + txtOrderID.Text;
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtProductID.Text) )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "d.ProductID LIKE '%" + txtProductID.Text + "%'";
         }
         if ( chkFrom.CheckState == Mobilize.Web.CheckState.Checked )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            //UPGRADE_WARNING: (1068) dtFrom.value of type Variant is being forced to DateTime. More Information: https://docs.mobilize.net/vbuc/ewis#1068
            filter = filter + "o.OrderDate >= '" + Convert.ToDateTime(dtFrom.GetValue()).ToString("MM/dd/yyyy") + "'";
         }
         if ( chkTo.CheckState == Mobilize.Web.CheckState.Checked )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            //UPGRADE_WARNING: (1068) dtTo.value of type Variant is being forced to DateTime. More Information: https://docs.mobilize.net/vbuc/ewis#1068
            filter = filter + "o.OrderDate <= '" + Convert.ToDateTime(dtTo.GetValue()).ToString("MM/dd/yyyy") + "'";
         }
         if ( cmbStatus.SelectedIndex != -1 && cmbStatus.Text != "All" )
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.Status = UPPER('" + cmbStatus.Text + "')";
         }
         string where = " Where o.OrderID = d.OrderID And c.CustomerID = o.CustomerID And u.Username = o.EmployeeId ";
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(filter) )
         {
            filter = where + " AND " + filter;
         }
         else
         {
            filter = where;
         }
         string sql = "Select o.OrderDate, o.OrderID, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName as ContactName, u.Fullname as [Received by], Sum(d.LineTotal) as Price, o.Status " + "From OrderRequests as o, OrderRequestDetails as d, Customers as c, Users as u " + filter + " Group by o.orderDate, o.OrderID, c.CompanyName, c.ContactFirstName + ' ' + c.ContactLastName, u.Fullname, o.Status ";
         modConnection.ExecuteSql(sql);
         modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         int i = 0;
         fgOrders.RowsCount = modConnection.rs.RecordCount + 1;
         if ( fgOrders.RowsCount == 1 )
         {
            fgOrders.FixedRows = 0;
         }
         else
         {
            fgOrders.FixedRows = 1;
         }
         i = 1;
         while ( !modConnection.rs.EOF )
         {
            int tempForEndVar = modConnection.rs.FieldsMetadata.Count - 1;
            for ( int j = 0; j <= tempForEndVar; j++ )
            {
               if ( modConnection.rs.GetField(j) != null )
               {
                  fgOrders.SetCellValue(j, i, Convert.ToString(modConnection.rs[j]));
               }
            }
            modConnection.rs.MoveNext();
            i++;
         }
      }

      private void InitGrid()
      {
         fgOrders.RowsCount = 0;
         fgOrders.ColumnsCount = 7;
         fgOrders.FixedColumns = 0;
         fgOrders.AddItem("Date" + "\t" + "Order" + "\t" + "Customer" + "\t" + "Contact" + "\t" + "Received by" + "\t" + "Price" + "\t" + "Status");
         fgOrders.RowsCount = 1;
         fgOrders.FixedRows = 0;
         fgOrders.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.FullRowSelect;
      }

      //'''''''''''''''''''''''''''''
      //''UNUSED CODE Start
      //UPGRADE_NOTE: (7001) The following declaration (MakeTextBoxVisible) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
      //private void MakeTextBoxVisible(TextBox txtBox, UpgradeHelpers.DataGridViewFlex grid)
      //{
      //txtBox.Text = Convert.ToString(grid[grid.CurrentRowIndex, grid.CurrentColumnIndex].Value);
      //txtBox.SetBounds(grid.CellLeft / 15 + grid.Left, grid.CellTop / 15 + grid.Top, grid.CellWidth / 15, grid.CellHeight / 15);
      //txtBox.Visible = true;
      //Application.DoEvents();
      //txtBox.Focus();
      //}
      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}