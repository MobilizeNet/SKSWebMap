namespace SKS
{
    using System;
    using Mobilize.Web.Extensions;
    using Mobilize.WebMap.Common.Attributes;
    using UpgradeHelpers.DB.ADO;

    [Observable]
    internal partial class frmReceptionApproval
      : Mobilize.Web.Form
   {

    public frmReceptionApproval()
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
                    // For the start-up form, the first instance created is the default instance.
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

         // This call is required by the Windows Form Designer.
        InitializeComponent();
        ReLoadForm(false);
      }

    private void frmReceptionApproval_Activated(object eventSender, EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
         {
            Stub._UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (Mobilize.Web.Form) eventSender;
         }
      }

    [Intercepted]
    private string Id { get; set; } = "";

    private void cmbStatus_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
      {
        DoSearchReception();
      }

    private void cmdApprove_Click(object eventSender, EventArgs eventArgs)
      {
        LoadActionOrderReception(1);
      }

    private void cmdCancel_Click(object eventSender, EventArgs eventArgs)
      {
        LoadActionOrderReception(2);
      }

    private void cmdInfo_Click(object eventSender, EventArgs eventArgs)
      {
        LoadActionOrderReception();
      }

    private void LoadActionOrderReception(int Action = 0)
      {
        int OrderId = 0;
        if (fgOrders.CurrentRowIndex > 0)
        {
            OrderId = Convert.ToInt32(double.Parse(Convert.ToString(fgOrders[fgOrders.CurrentRowIndex, 1].Value)));
            frmActionOrderReception.DefInstance.OrderId = OrderId;
            frmActionOrderReception.DefInstance.Action = Action;
            frmActionOrderReception.DefInstance.LoadData();
            frmActionOrderReception.DefInstance.Show(); // vbModal
        }
      }

    private void dtFrom_ValueChanged(object eventSender, EventArgs eventArgs)
      {
        chkFrom.CheckState = Mobilize.Web.CheckState.Checked;
        DoSearchReception();
      }

    private void dtTo_ValueChanged(object eventSender, EventArgs eventArgs)
      {
         chkTo.CheckState = Mobilize.Web.CheckState.Checked;
         DoSearchReception();
      }

    private void fgOrders_DoubleClick(object eventSender, EventArgs eventArgs)
      {
         cmdInfo_Click(cmdInfo, new EventArgs());
      }

      // UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
    private void Form_Load()
      {
         InitGrid();
      }

    private void txtOrderID_TextChanged(object eventSender, EventArgs eventArgs)
      {
         DoSearchReception();
      }

    private void txtProductID_TextChanged(object eventSender, EventArgs eventArgs)
      {
         DoSearchReception();
      }

    private void txtProviderName_TextChanged(object eventSender, EventArgs eventArgs)
      {
         DoSearchReception();
      }

    private void txtContactLastName_TextChanged(object eventSender, EventArgs eventArgs)
      {
         DoSearchReception();
      }

    private void txtContactName_TextChanged(object eventSender, EventArgs eventArgs)
      {
         DoSearchReception();
      }

      // UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      // private void txtName_Change()
      // {
        // DoSearchReception();
      // }

    private void cmdClose_Click(object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

    private void cmdProviders_Click(object eventSender, EventArgs eventArgs)
      {
         frmProviders.DefInstance.Show(); // vbModal
         txtProviderName.Text = "";
         txtContactLastName.Text = "";
         txtContactName.Text = "";
         DoSearchReception(frmProviders.DefInstance.CurrentProviderID);
      }

    private void DoSearchReception(int Id = -1)
      {
         string filter = "";
         if (Id != -1)
         {
            filter = "o.ProviderID = " + Id.ToString();
         }

         // UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!string.IsNullOrEmpty(txtProviderName.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = "p.ProviderName LIKE '%" + txtProviderName.Text + "%'";
         }

         // UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!string.IsNullOrEmpty(txtContactName.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "p.ContactFirstName LIKE '%" + txtContactName.Text + "%'";
         }

         // UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!string.IsNullOrEmpty(txtContactLastName.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "p.ContactLastName LIKE '%" + txtContactLastName.Text + "%'";
         }

         // UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!string.IsNullOrEmpty(txtOrderID.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.OrderID = " + txtOrderID.Text;
         }

         // UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!string.IsNullOrEmpty(txtProductID.Text))
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "d.ProductID LIKE '%" + txtProductID.Text + "%'";
         }

         if (chkFrom.CheckState == Mobilize.Web.CheckState.Checked)
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            // UPGRADE_WARNING: (1068) dtFrom.value of type Variant is being forced to DateTime. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
            filter = filter + "o.OrderDate >= #" + Convert.ToDateTime(dtFrom.GetValue()).ToString("MM/dd/yyyy") + "#";
         }

         if (chkTo.CheckState == Mobilize.Web.CheckState.Checked)
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            // UPGRADE_WARNING: (1068) dtTo.value of type Variant is being forced to DateTime. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1068
            filter = filter + "o.OrderDate <= #" + Convert.ToDateTime(dtTo.GetValue()).ToString("MM/dd/yyyy") + "#";
         }

         if (cmbStatus.SelectedIndex != -1 && cmbStatus.Text != "All")
         {
            modFunctions.AppendAND(Mobilize.Web.ReferenceExtensions.Ref(() => filter));
            filter = filter + "o.Status = '" + cmbStatus.Text + "'";
         }

         string where = " Where o.OrderID = d.OrderID And p.ProviderID = o.ProviderID And u.Username = o.ReceivedBy ";
         // UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
         if (!string.IsNullOrEmpty(filter))
         {
            filter = where + " AND " + filter;
         }
         else
         {
            filter = where;
         }

         string sql = "Select o.OrderDate, o.OrderID, p.ProviderName, p.ContactFirstName + ' ' + p.ContactLastName as ContactName, u.Fullname as [Received by], Sum(d.LineTotal) as Price, o.Status " +
                      "From OrderReceptions as o, OrderReceptionDetails as d, Providers as p, Users as u " +
                      filter + " Group by o.orderDate, o.OrderID, p.ProviderName, p.ContactFirstName + ' ' + p.ContactLastName, u.Fullname, o.Status ";
         modConnection.ExecuteSql(sql);
         modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         int i = 0;
         fgOrders.RowsCount = modConnection.rs.RecordCount + 1;
         if (fgOrders.RowsCount == 1)
         {
            fgOrders.FixedRows = 0;
         }
         else
         {
            fgOrders.FixedRows = 1;
         }

         i = 1;
         while (!modConnection.rs.EOF)
         {
            int tempForEndVar = modConnection.rs.FieldsMetadata.Count - 1;
            for (int j = 0; j <= tempForEndVar; j++)
            {
                if (!(modConnection.rs.GetField(j) is null))
                {
                    fgOrders.SetCellValue( j, i, Convert.ToString(modConnection.rs[j]));
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
         fgOrders.AddItem("Date" + "\t" + "Order" + "\t" + "Supplier" + "\t" + "Contact" + "\t" + "Received by" + "\t" + "Price" + "\t" + "Status");
         fgOrders.RowsCount = 1;
         fgOrders.FixedRows = 0;
         fgOrders.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.FullRowSelect;
      }

      // UPGRADE_NOTE: (7001) The following declaration (MakeTextBoxVisible) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
      // private void MakeTextBoxVisible(TextBox txtBox, UpgradeHelpers.DataGridViewFlex grid)
      // {
        // txtBox.Text = Convert.ToString(grid[grid.CurrentRowIndex, grid.CurrentColumnIndex].Value);
        // txtBox.SetBounds(grid.CellLeft / 15 + grid.Left, grid.CellTop / 15 + grid.Top, grid.CellWidth / 15, grid.CellHeight / 15);
        // txtBox.Visible = true;
        // Application.DoEvents();
        // txtBox.Focus();
      // }
    private void Form_Closed(object eventSender, EventArgs eventArgs)
      {
      }

   }
}