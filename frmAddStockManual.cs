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
   internal partial class frmAddStockManual
      : Mobilize.Web.Form
   {

      public frmAddStockManual()
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

      private void frmAddStockManual_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender )
         {
            Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (Mobilize.Web.Form)eventSender;
         }
      }

      [Intercepted]
      private bool editingData { get; set; } = false;

      [Intercepted]
      private string currentIdProduct { get; set; } = "";

      [Intercepted]
      private string currentQuantityPerUnit { get; set; } = "";

      [Intercepted]
      private string currentUnit { get; set; } = "";

      [Intercepted]
      private string currentProductName { get; set; } = "";

      [Intercepted]
      private double currentPriceReference { get; set; } = 0;

      [Intercepted]
      private bool codeGeneratedChange { get; set; } = false;

      [Intercepted]
      private double quantity { get; set; } = 0;

      [Intercepted]
      private double stockPrice { get; set; } = 0;

      [Intercepted]
      private double unitPrice { get; set; } = 0;

      private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

      private void cmdProducts_Click(Object eventSender, EventArgs eventArgs)
      {
         frmProducts.DefInstance.ShowDialog();
         txtCode.Text = frmProducts.DefInstance.CurrentProductID;
         txtName.Text = "";
         DoSearchProduct();
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
         int newStockId = 0;
         int newManualLogId = 0;
         int newStockLogId = 0;
         editingData = false;
         try
         {
            modConnection.ExecuteSql("Select * from Stocks");
            modConnection.rs.AddNew();
            modConnection.rs["ProductID"] = currentIdProduct;
            modConnection.rs["Stock"] = txtValues[0].Text;
            modConnection.rs["InitialStock"] = txtValues[0].Text;
            modConnection.rs["DateStarted"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["DateModified"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["User"] = modMain.UserId;
            modConnection.rs["UnitPrice"] = txtValues[2].Text;
            modConnection.rs["StockPrice"] = txtValues[1].Text;
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid()");
            newStockId = Convert.ToInt32(modConnection.rs[0]);
            modConnection.ExecuteSql("Select * from ManualStocks");
            modConnection.rs.AddNew();
            modConnection.rs["StockID"] = newStockId;
            modConnection.rs["Quantity"] = txtValues[0].Text;
            modConnection.rs["Price"] = txtValues[1].Text;
            modConnection.rs["User"] = modMain.UserId;
            modConnection.rs["Date"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["Action"] = "ADD";
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid()");
            newManualLogId = Convert.ToInt32(modConnection.rs[0]);
            modConnection.ExecuteSql("Select * from StockLog");
            modConnection.rs.AddNew();
            modConnection.rs["User"] = modMain.UserId;
            modConnection.rs["Date"] = DateTimeHelper.ToString(DateTime.Today);
            modConnection.rs["Quantity"] = txtValues[0].Text;
            modConnection.rs["StockPrice"] = txtValues[1].Text;
            modConnection.rs["ProductID"] = currentIdProduct;
            modConnection.rs["StockID"] = newStockId;
            modConnection.rs["DocType"] = "MANUAL";
            modConnection.rs["DocID"] = newManualLogId;
            modConnection.rs.Update();
            modConnection.ExecuteSql("SELECT last_insert_rowid()");
            newStockLogId = Convert.ToInt32(modConnection.rs[0]);
            modConnection.ExecuteSql("Update Products Set UnitsInStock = UnitsInStock + " + txtValues[0].Text + " Where ProductId = '& currentIdProduct &'");
            if ( Mobilize.Web.MessageBox.Show("Data added successfully" + Environment.NewLine + "Would you like to add a new stock manually?", "New data", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes )
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

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
      private void Form_Load()
      {
         editingData = false;
         codeGeneratedChange = false;
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

      private void lvProducts_Click(Object eventSender, EventArgs eventArgs)
      {
         RetrieveDataProduct();
      }

      private void lvProducts_ItemClick(Mobilize.Web.ListViewItem Item)
      {
         RetrieveDataProduct();
      }

      private void txtCode_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchProduct();
      }

      //Private Sub txtCode_KeyPress(KeyAscii As Integer)
      //KeyAscii = UpCase(KeyAscii)
      //End Sub
      private void txtCode_Leave(Object eventSender, EventArgs eventArgs)
      {
         if ( lvProducts.Items.Count == 1 )
         {
            RetrieveDataProduct();
         }
      }

      private void txtName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchProduct();
      }

      private void DoSearchProduct()
      {
         string filter = "";
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtCode.Text) )
         {
            filter = "ProductId LIKE '%" + txtCode.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(txtName.Text) )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(filter) )
            {
               filter = filter + " AND ";
            }
            filter = filter + "ProductName LIKE '%" + txtName.Text + "%'";
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(filter) )
         {
            filter = "Where " + filter;
         }
         modConnection.ExecuteSql("Select ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, QuantityPerUnit, Unit from Products " + filter);
         lvProducts.Items.Clear();
         Mobilize.Web.ListViewItem x = null;
         if ( modConnection.rs.RecordCount == 0 )
         {
            modMain.LogStatus("There are no records with the selected criteria", this);
         }
         else
         {
            while ( !modConnection.rs.EOF )
            {
               x = lvProducts.Items.Add(Convert.ToString(modConnection.rs[0]));
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
            if ( lvProducts.Items.Count == 1 )
            {
               lvProducts.Items[lvProducts.Items[0].Index].Selected = true;
            //RetrieveDataProduct
            }
         }
      }

      private void RetrieveDataProduct()
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
         if ( !(lvProducts.FocusedItem is null) )
         {
            withVar = lvProducts.FocusedItem;
            currentIdProduct = lvProducts.FocusedItem.Text;
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(Mobilize.Web.ListView.GetListViewSubItem(withVar, 5).Text) )
            {
               currentQuantityPerUnit = Mobilize.Web.ListView.GetListViewSubItem(withVar, 5).Text;
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(Mobilize.Web.ListView.GetListViewSubItem(withVar, 6).Text) )
            {
               currentUnit = Mobilize.Web.ListView.GetListViewSubItem(withVar, 6).Text;
            }
            currentProductName = Mobilize.Web.ListView.GetListViewSubItem(withVar, 1).Text;
            currentPriceReference = Double.Parse(Mobilize.Web.ListView.GetListViewSubItem(withVar, 2).Text);
            txtProductName.Text = currentProductName;
            txtQuantityPerUnit.Text = currentQuantityPerUnit;
            txtUnit.Text = currentUnit;
            txtValues[0].ReadOnly = false;
            txtValues[1].ReadOnly = false;
            txtValues[2].ReadOnly = false;
            txtValues[0].Text = "1";
            txtValues[1].Text = currentPriceReference.ToString();
            txtValues[2].Text = currentPriceReference.ToString();
            txtValues[0].Focus();
            modFunctions.SelectAll(txtValues[0]);
            editingData = false;
         }
      }

      private void txtName_Leave(Object eventSender, EventArgs eventArgs)
      {
         if ( lvProducts.Items.Count == 1 )
         {
            RetrieveDataProduct();
         }
      }

      private void txtValues_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         int Index = Array.IndexOf(this.txtValues, eventSender);
         if ( !codeGeneratedChange )
         {
            editingData = true;
            codeGeneratedChange = true;
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(txtValues[0].Text) )
            {
               quantity = Double.Parse(txtValues[0].Text);
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(txtValues[1].Text) )
            {
               stockPrice = Double.Parse(txtValues[1].Text);
            }
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(txtValues[2].Text) )
            {
               unitPrice = Double.Parse(txtValues[2].Text);
            }
            switch ( Index )
            {
               case 0:
               case 2:
                  txtValues[1].Text = (unitPrice * quantity).ToString();
                  break;
               case 1:
                  txtValues[2].Text = (stockPrice / quantity).ToString();
                  break;
            }
            lblNewQuantity.Text = StringsHelper.Format(quantity * Double.Parse(currentQuantityPerUnit), "##,###.00") + currentUnit;
            codeGeneratedChange = false;
         }
      }

      private void txtValues_Enter(Object eventSender, EventArgs eventArgs)
      {
         int Index = Array.IndexOf(this.txtValues, eventSender);
         modFunctions.SelectAll(txtValues[Index]);
      }

      private void txtValues_KeyPress(Object eventSender, Mobilize.Web.KeyPressEventArgs eventArgs)
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

      private void ClearFields()
      {
         codeGeneratedChange = true;
         txtValues[0].ReadOnly = true;
         txtValues[1].ReadOnly = true;
         txtValues[2].ReadOnly = true;
         txtValues[0].Text = "";
         txtValues[1].Text = "";
         txtValues[2].Text = "";
         txtCode.Text = "";
         txtName.Text = "";
         txtUnit.Text = "";
         txtProductName.Text = "";
         txtQuantityPerUnit.Text = "";
         lvProducts.Items.Clear();
         txtCode.Focus();
         editingData = false;
         codeGeneratedChange = false;
         lblNewQuantity.Text = "";
         modMain.ClearLogStatus(this);
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}