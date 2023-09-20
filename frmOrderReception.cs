using Microsoft.VisualBasic;
using System;
using System.Media;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmOrderReception
      : Mobilize.Web.Form
   {

      public frmOrderReception()
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

      private void frmOrderReception_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender )
         {
            Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (Mobilize.Web.Form)eventSender;
         }
      }

      [Intercepted]
      private string currentProviderName { get; set; } = "";

      [Intercepted]
      private int currentIdProvider { get; set; } = 0;

      [Intercepted]
      private string currentContactName { get; set; } = "";

      [Intercepted]
      private bool editingData { get; set; } = false;

      [Intercepted]
      private double currentSubTotal { get; set; } = 0;

      [Intercepted]
      private double currentTotal { get; set; } = 0;

      [Intercepted]
      private double currentTax { get; set; } = 0;

      [Intercepted]
      private double currentFreightCharge { get; set; } = 0;

      [Intercepted]
      private double currentTotalTax { get; set; } = 0;

      private void cmdAddProducts_Click(Object eventSender, EventArgs eventArgs)
      {
         frmAddProductTo.DefInstance.Id = currentIdProvider;
         frmAddProductTo.DefInstance.ObjectReferred = "Provider " + txtProviderCompany.Text + "|" + txtProviderContact.Text;
         frmAddProductTo.DefInstance.Table = "ProductsByProvider";
         frmAddProductTo.DefInstance.ColumnName = "ProviderId";
         frmAddProductTo.DefInstance.LoadData();
         frmAddProductTo.DefInstance.ShowDialog();
         if ( frmAddProductTo.DefInstance.SavedChanges )
         {
            LoadProductsById();
         }
      }

      //UPGRADE_NOTE: (7001) The following declaration (txtName_Change) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
      //private void txtName_Change()
      //{
      //DoSearchProvider();
      //}
      private void DoSearchProvider(int Id = 0)
      {
         string filter = "";
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !Id.Equals(0) )
         {
            filter = "ProviderID = " + Id.ToString();
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtProviderName.Text) )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(filter) )
            {
               filter = filter + " AND ";
            }
            filter = "ProviderName LIKE '%" + txtProviderName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtContactName.Text) )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(filter) )
            {
               filter = filter + " AND ";
            }
            filter = filter + "ContactFirstName LIKE '%" + txtContactName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtContactLastName.Text) )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(filter) )
            {
               filter = filter + " AND ";
            }
            filter = filter + "ContactLastName LIKE '%" + txtContactLastName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(filter) )
         {
            filter = "Where " + filter;
         }
         modConnection.ExecuteSql("Select ProviderID, ProviderName, ContactFirstName, ContactLastName, City, StateOrProvince, 'Country/Region' From Providers " + filter);
         lvProviders.Items.Clear();
         Mobilize.Web.ListViewItem x = null;
         if ( modConnection.rs.RecordCount == 0 )
         {
            modMain.LogStatus("There are no records with the selected criteria", this);
         }
         else
         {
            while ( !modConnection.rs.EOF )
            {
               x = lvProviders.Items.Add(Convert.ToString(modConnection.rs[0]));
               int tempForEndVar = (modConnection.rs.FieldsMetadata.Count - 1);
               for ( modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++ )
               {
                  //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
                  if ( !(modConnection.rs.GetField(modMain.i) is null) )
                  {
                     Mobilize.Web.ListView.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
                  }
               }
               modConnection.rs.MoveNext();
            }
            if ( lvProviders.Items.Count == 1 )
            {
               lvProviders.Items[lvProviders.Items[0].Index].Selected = true;
            }
         }
      }

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

      private void cmdProviders_Click(Object eventSender, EventArgs eventArgs)
      {
         frmProviders.DefInstance.ShowDialog();
         txtProviderName.Text = "";
         txtContactLastName.Text = "";
         txtContactName.Text = "";
         DoSearchProvider(frmProviders.DefInstance.CurrentProviderID);
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
         int newOrderId = 0;
         try
         {
            modConnection.ExecuteSql("Select * from OrderReceptions");
            modConnection.rs.AddNew();
            modConnection.rs["ProviderId"] = currentIdProvider;
            modConnection.rs["ReceivedBy"] = modMain.UserId;
            modConnection.rs["OrderDate"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["Notes"] = txtNotes.Text;
            modConnection.rs["FreightCharge"] = currentFreightCharge;
            modConnection.rs["SalesTaxRate"] = currentTax * 0.01d;
            modConnection.rs["Status"] = "RECEIVED";
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid() ");
            newOrderId = Convert.ToInt32(modConnection.rs[0]);
            int tempForEndVar = fgProducts.RowsCount - 1;
            for ( modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++ )
            {
               if ( Convert.ToString(fgProducts[modMain.i, 0].Value) != "0" )
               {
                  modConnection.ExecuteSql("Insert into OrderReceptionDetails (OrderID, ProductID, DateSold, Quantity, UnitPrice, SalePrice, SalesTax, LineTotal) Values (" + newOrderId.ToString() + ", '" + Convert.ToString(fgProducts[modMain.i, 1].Value) + "', '" + DateTime.Today.ToString("MM/dd/yyyy") + "'," + Convert.ToString(fgProducts[modMain.i, 0].Value) + "," + Convert.ToString(fgProducts[modMain.i, 3].Value) + "," + Convert.ToString(fgProducts[modMain.i, 4].Value) + "," + (currentTax * 0.01d).ToString() + "," + Convert.ToString(fgProducts[modMain.i, 4].Value) + ")");
               //UnitsInTransit
               //ExecuteSql "Update Products Set UnitsOnOrder = UnitsOnOrder + " & fgProducts.TextMatrix(i, 0) & _
               //        '" Where ProductId = '" & fgProducts.TextMatrix(i, 1) & "'"
               }
            }
            editingData = false;
            if ( Mobilize.Web.MessageBox.Show("Order reception added successfully" + Environment.NewLine + "Would you like to add a new order reception?", "New data", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes )
            {
               ClearFields();
            }
            else
            {
               this.Close();
            }
         }
         catch( System.Exception excep )
         {
            Mobilize.Web.MessageBox.Show("An error has occurred adding the data. Error: (" + Mobilize.Web.Information.Err().Number.ToString() + ") " + excep.Message, "Error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
         }
      }

      private void MakeTextBoxVisible(Mobilize.Web.TextBox txtBox, Mobilize.Web.VBUC.FlexGrid grid)
      {
         txtBox.Text = Convert.ToString(grid[grid.CurrentRowIndex, grid.CurrentColumnIndex].Value);
         //txtBox.Move .CellLeft + .Left, .CellTop + .Top, .CellWidth, .CellHeight
         txtBox.Visible = true;
         txtBox.Enabled = true;
         //DoEvents
         txtBox.Focus();
         modFunctions.SelectAll(txtBox);
      }

      private void fgProducts_Click(Object eventSender, EventArgs eventArgs)
      {
         if ( fgProducts.CurrentColumnIndex != 0 )
         {
            return ;
         }
         MakeTextBoxVisible(txtEntry, fgProducts);
      }

      //UPGRADE_WARNING: (2050) MSFlexGridLib.MSFlexGrid Event fgProducts.EnterCell was not upgraded. More Information: https://docs.mobilize.net/vbuc/ewis#2050
      private void fgProducts_EnterCell()
      {
         SaveEdits();
      }

      private void fgProducts_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
         int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
         try
         {
            if ( fgProducts.CurrentColumnIndex != 0 )
            {
               if ( KeyAscii == 0 )
               {
                  eventArgs.Handled = true;
               }
               return ;
            }
            if ( KeyAscii == 46 || KeyAscii >= 48 && KeyAscii <= 57 )
            {
               //Case 45, 46, 47, 48 To 59, 65 To 90, 97 To 122
               MakeTextBoxVisible(txtEntry, fgProducts);
               txtEntry.Text = Strings.Chr(KeyAscii).ToString();
               txtEntry.SelectionStart = 1;
            }
            else
            {
            }
         }
         finally
         {
            if ( KeyAscii == 0 )
            {
               eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
         }
      }

      private void txtEntry_KeyDown(Object eventSender, Mobilize.Web.KeyEventArgs eventArgs)
      {
         int KeyCode = (int)eventArgs.KeyCode;
         int Shift = ((int)eventArgs.KeyData) / 65536;
         try
         {
            Mobilize.Web.TextBox tempRefParam = txtEntry;
            EditKeyCode(fgProducts, Mobilize.Web.ReferenceExtensions.Ref(() => tempRefParam), KeyCode, Shift);
            txtEntry = tempRefParam;
         }
         finally
         {
            eventArgs.Handled = KeyCode == 0;
         }
      }

      private void EditKeyCode(Mobilize.Web.VBUC.FlexGrid grid, dynamic txtBox, int KeyCode, int Shift)
      {
         switch ( KeyCode )
         {
            case 27: //ESC 

               txtBox.RefValue.Text = "";
               txtBox.RefValue.Visible = false;
               grid.Focus();
               break;
            case 13: //Return 

               grid.Focus();
               break;
            case 37: //Left Arrow 

               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if ( grid.CurrentColumnIndex > grid.FixedColumns )
               {
                  (grid.CurrentColumnIndex)--;
               }
               break;
            case 38: //Up Arrow 

               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if ( grid.CurrentRowIndex > grid.FixedRows )
               {
                  (grid.CurrentRowIndex)--;
               }
               break;
            case 39: //Right Arrow 

               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if ( grid.CurrentColumnIndex < grid.ColumnsCount - 1 )
               {
                  (grid.CurrentColumnIndex)++;
               }
               break;
            case 40: //Down Arrow 

               grid.Focus();
               Stub._System.Windows.Forms.Application.DoEvents();
               if ( grid.CurrentRowIndex < grid.RowsCount - 1 )
               {
                  (grid.CurrentRowIndex)++;
               }
               break;
         }
      }

      private void txtEntry_Leave(Object eventSender, EventArgs eventArgs)
      {
         SaveEdits();
      }

      private void fgProducts_CellLeave(Object eventSender, EventArgs eventArgs)
      {
         SaveEdits();
      }

      private void txtEntry_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
         int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
         try
         {
            //dot and Numbers
            if ( KeyAscii == 46 || KeyAscii >= 48 && KeyAscii <= 57 )
            {
            //Alphanumeric
            //Case 45, 46, 47, 48 To 59, 65 To 90, 97 To 122
            }
            else
            {
               KeyAscii = 0;
            }
         }
         finally
         {
            if ( KeyAscii == 0 )
            {
               eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
         }
      }

      private void SaveEdits()
      {
         if ( !txtEntry.Visible || !modFunctions.ValidateTextBoxDouble(txtEntry, this) || !modFunctions.ValidateTextDouble(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 3].Value), this) || !modFunctions.ValidateTextDouble(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 4].Value), this) )
         {
            return ;
         }
         double previousLinePrice = modFunctions.DoubleValue(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 4].Value));
         fgProducts.SetCellValue(fgProducts.CurrentColumnIndex, fgProducts.CurrentRowIndex, txtEntry.Text);
         double lineQuantity = modFunctions.DoubleValue(txtEntry.Text);
         double lineUnitPrice = modFunctions.DoubleValue(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 3].Value));
         previousLinePrice = modFunctions.DoubleValue(Convert.ToString(fgProducts[fgProducts.CurrentRowIndex, 4].Value));
         double linePrice = lineQuantity * lineUnitPrice;
         fgProducts.SetCellValue(4, fgProducts.CurrentRowIndex, linePrice.ToString());
         ReCalculateTotals(previousLinePrice, linePrice);
         txtEntry.Visible = false;
         editingData = true;
      }

      private void ReCalculateTotals(double previous, double current)
      {
         currentSubTotal = currentSubTotal - previous + current;
         currentTotalTax = currentSubTotal * currentTax * 0.01d;
         currentTotal = currentFreightCharge + currentSubTotal + currentTotalTax;
         txtSubTotal.Text = StringsHelper.Format(currentSubTotal, "#,##0.00");
         txtTotalTax.Text = StringsHelper.Format(currentTotalTax, "#,##0.00");
         txtTotal.Text = StringsHelper.Format(currentTotal, "#,##0.00");
      }

      private void Form_FormClosing(Object eventSender, Mobilize.Web.FormClosingEventArgs eventArgs)
      {
         int Cancel = (eventArgs.Cancel) ? 1 : 0;
         int UnloadMode = (int)eventArgs.CloseReason;
         try
         {
            Mobilize.Web.DialogResult res = (Mobilize.Web.DialogResult)0;
            if ( editingData )
            {
               res = Mobilize.Web.MessageBox.Show("Do you want to save the edited data?", "Save data", Mobilize.Web.MessageBoxButtons.YesNoCancel, Mobilize.Web.MessageBoxIcon.Question);
               if ( res == Mobilize.Web.DialogResult.Yes )
               {
                  cmdSave_Click(cmdSave, new EventArgs());
               }
               else if ( res != Mobilize.Web.DialogResult.No )
               {
                  Cancel = -1;
               }
            }
         }
         finally
         {
            eventArgs.Cancel = Cancel != 0;
         }
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
      private void Form_Load()
      {
         editingData = false;
         ClearFields();
      }

      private void lvProviders_ItemClick(Mobilize.Web.ListViewItem Item)
      {
         RetrieveDataProvider();
      }

      private void RetrieveDataProvider()
      {
         if ( editingData )
         {
            if ( Mobilize.Web.MessageBox.Show("Do you want to cancel previous edited data?", "Data edition", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) != Mobilize.Web.DialogResult.Yes )
            {
               return ;
            }
         }
         Mobilize.Web.ListViewItem withVar = null;
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !(lvProviders.FocusedItem is null) )
         {
            withVar = lvProviders.FocusedItem;
            currentIdProvider = Convert.ToInt32(Double.Parse(lvProviders.FocusedItem.Text));
            currentProviderName = Mobilize.Web.ListView.GetListViewSubItem(withVar, 1).Text;
            currentContactName = Mobilize.Web.ListView.GetListViewSubItem(withVar, 2).Text + " " + Mobilize.Web.ListView.GetListViewSubItem(withVar, 3).Text;
            txtProviderCompany.Text = currentProviderName;
            txtProviderContact.Text = currentContactName;
            editingData = false;
         }
         LoadProductsById();
         cmdSave.Enabled = true;
         cmdAddProducts.Enabled = true;
      }

      private void LoadProductsById()
      {
         string Table = "ProductsByProvider";
         string ColumnName = "ProviderId";
         int Id = currentIdProvider;
         modConnection.ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.QuantityPerUnit, p.Unit from Products as p, " + Table + " as pb Where pb." + ColumnName + " = " + Id.ToString() + " And pb.ProductId = p.ProductId");
         //lvProducts.ListItems.Clear
         //If rs.RecordCount > 0 Then
         //    With rs
         //        While Not .EOF
         //            Set x = lvProducts.ListItems.Add(, , 0)
         //            For i = 1 To 5
         //                If Not IsEmpty(.Fields(i - 1)) Then
         //                    x.SubItems(i) = .Fields(i - 1)
         //                End If
         //            Next i
         //            x.SubItems(6) = .Fields(5) & .Fields(6)
         //            .MoveNext
         //        Wend
         //    End With
         //End If
         int lng = 0;
         int intLoopCount = 0;
         const int SCROOL_WIDTH = 320;
         int i = 0;
         fgProducts.ColumnsCount = 8;
         fgProducts.FixedColumns = 0;
         fgProducts.RowsCount = 0;
         fgProducts.AddItem("Quantity" + "\t" + "Code" + "\t" + "Product" + "\t" + "UnitPrice" + "\t" + "Price" + "\t" + "Existence" + "\t" + "Ordered" + "\t" + "Quantity per unit");
         fgProducts.RowsCount = modConnection.rs.RecordCount + 1;
         if ( fgProducts.RowsCount == 1 )
         {
            fgProducts.FixedRows = 0;
         }
         else
         {
            fgProducts.FixedRows = 1;
         }
         i = 1;
         while ( !modConnection.rs.EOF )
         {
            fgProducts.SetCellValue(0, i, "0");
            for ( int j = 1; j <= 6; j++ )
            {
               if ( j == 4 )
               {
                  fgProducts.SetCellValue(j, i, "0");
               }
               else if ( j < 4 )
               {
                  fgProducts.SetCellValue(j, i, Convert.ToString(modConnection.rs[j - 1]));
               }
               else
               {
                  fgProducts.SetCellValue(j, i, Convert.ToString(modConnection.rs[j - 2]));
               }
            }
            fgProducts.SetCellValue(7, i, Convert.ToString(modConnection.rs[5]) + Convert.ToString(modConnection.rs[6]));
            modConnection.rs.MoveNext();
            i++;
         }
      }

      //UPGRADE_NOTE: (7001) The following declaration (lvProducts_ItemCheck) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
      //private void lvProducts_ItemCheck(ListViewItem Item)
      //{
      //if (Item.Checked)
      //{
      //Item.Text = "1";
      //}
      //else
      //{
      //Item.Text = "0";
      //}
      //}
      private void txtProviderName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchProvider();
      }

      private void txtNotes_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         editingData = true;
      }

      private void txtContactName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchProvider();
      }

      private void ClearFields()
      {
         fgProducts.RowsCount = 0;
         fgProducts.ColumnsCount = 0;
         currentSubTotal = 0;
         currentTotal = 0;
         currentTax = 0;
         currentTotalTax = 0;
         currentFreightCharge = 0;
         txtSubTotal.Text = "";
         txtTotal.Text = "";
         txtTotalTax.Text = "";
         txtSalesTax.Text = "";
         txtFreightCharge.Text = "";
         txtProviderName.Text = "";
         txtContactLastName.Text = "";
         txtContactName.Text = "";
         txtProviderContact.Text = "";
         txtProviderCompany.Text = "";
         cmdSave.Enabled = false;
         cmdAddProducts.Enabled = false;
         txtNotes.Text = "";
         //txtProviderName.SetFocus
         ReCalculateTotals(0, 0);
         editingData = false;
      }

      private void txtFreightCharge_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         currentFreightCharge = modFunctions.DoubleValue(txtFreightCharge.Text);
         ReCalculateTotals(0, 0);
         editingData = true;
      }

      private void txtFreightCharge_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
         int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
         try
         {
            if ( KeyAscii >= ((int)Mobilize.Web.Keys.D0) && KeyAscii <= ((int)Mobilize.Web.Keys.D9) )
            {
            }
            else if ( KeyAscii == ((int)Mobilize.Web.Keys.Back) || KeyAscii == ((int)Mobilize.Web.Keys.Clear) || KeyAscii == ((int)Mobilize.Web.Keys.Delete) )
            {
            }
            else if ( KeyAscii == ((int)Mobilize.Web.Keys.Left) || KeyAscii == ((int)Mobilize.Web.Keys.Right) || KeyAscii == ((int)Mobilize.Web.Keys.Up) || KeyAscii == ((int)Mobilize.Web.Keys.Down) || KeyAscii == ((int)Mobilize.Web.Keys.Tab) )
            {
            }
            else
            {
               KeyAscii = 0;
               Stub._System.Media.SystemSounds.Beep.Play();
            }
         }
         finally
         {
            if ( KeyAscii == 0 )
            {
               eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
         }
      }

      private void txtContactLastName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         editingData = true;
      }

      private void txtSalesTax_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         currentTax = modFunctions.DoubleValue(txtSalesTax.Text);
         ReCalculateTotals(0, 0);
         editingData = true;
      }

      private void txtSalesTax_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
      {
         int KeyAscii = Convert.ToInt32(eventArgs.KeyChar);
         try
         {
            if ( KeyAscii >= ((int)Mobilize.Web.Keys.D0) && KeyAscii <= ((int)Mobilize.Web.Keys.D9) )
            {
            }
            else if ( KeyAscii == ((int)Mobilize.Web.Keys.Back) || KeyAscii == ((int)Mobilize.Web.Keys.Clear) || KeyAscii == ((int)Mobilize.Web.Keys.Delete) )
            {
            }
            else if ( KeyAscii == ((int)Mobilize.Web.Keys.Left) || KeyAscii == ((int)Mobilize.Web.Keys.Right) || KeyAscii == ((int)Mobilize.Web.Keys.Up) || KeyAscii == ((int)Mobilize.Web.Keys.Down) || KeyAscii == ((int)Mobilize.Web.Keys.Tab) )
            {
            }
            else
            {
               KeyAscii = 0;
               Stub._System.Media.SystemSounds.Beep.Play();
            }
         }
         finally
         {
            if ( KeyAscii == 0 )
            {
               eventArgs.Handled = true;
            }
            eventArgs.KeyChar = Convert.ToChar(KeyAscii);
         }
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}