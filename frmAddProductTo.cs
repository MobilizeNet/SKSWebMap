using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmAddProductTo
      : Mobilize.Web.Form
   {

      public frmAddProductTo()
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
      }

      private void frmAddProductTo_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender )
         {
            Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (Mobilize.Web.Form)eventSender;
         }
      }

      [Intercepted]
      public int Id { get; set; } = 0;

      [Intercepted]
      public string ObjectReferred { get; set; } = "";

      [Intercepted]
      public string Table { get; set; } = "";

      [Intercepted]
      public string ColumnName { get; set; } = "";

      [Intercepted]
      public bool SavedChanges { get; set; } = false;

      [Intercepted]
      private OrderedDictionary productsStored { get; set; } = null;

      [Intercepted]
      private OrderedDictionary productsToDelete { get; set; } = null;

      [Intercepted]
      private OrderedDictionary productsToAdd { get; set; } = null;

      [Intercepted]
      private bool editingData { get; set; } = false;

      [Intercepted]
      private string currentIdProduct { get; set; } = "";

      [Intercepted]
      private bool codeGeneratedChange { get; set; } = false;

      private void chkAll_CheckStateChanged(Object eventSender, EventArgs eventArgs)
      {
         bool check = chkAll.CheckState == Mobilize.Web.CheckState.Checked;
         int tempForEndVar = lvProductsBy.Items.Count;
         for ( modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++ )
         {
            lvProductsBy.Items[modMain.i - 1].Checked = check;
         }
      }

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

      private void cmdRemove_Click(Object eventSender, EventArgs eventArgs)
      {
         string productIdToDelete = "";
         for ( modMain.i = lvProductsBy.Items.Count; modMain.i >= 1; modMain.i-- )
         {
            if ( lvProductsBy.Items[modMain.i - 1].Checked )
            {
               productIdToDelete = lvProductsBy.Items[modMain.i - 1].Text;
               if ( modFunctions.Exists(productsStored, productIdToDelete) )
               {
                  if ( modFunctions.Exists(productsToAdd, productIdToDelete) )
                  {
                     productsToDelete.Remove(productIdToDelete);
                  }
                  else
                  {
                     modFunctions.AddToCollection(productsToDelete, productIdToDelete);
                  }
               }
               else
               {
                  if ( modFunctions.Exists(productsToAdd, currentIdProduct) )
                  {
                     productsToAdd.Remove(currentIdProduct);
                  }
               }
               lvProductsBy.Items.RemoveAt(modMain.i - 1);
               editingData = true;
            }
         }
      }

      private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
      {
         if ( productsToAdd.Count == 0 && productsToDelete.Count == 0 )
         {
            editingData = true;
            Mobilize.Web.MessageBox.Show("No data to be saved", "No data modified", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
            this.Close();
            return ;
         }
         SavedChanges = true;
         string productCode = "";
         foreach ( string productCodeIterator in productsToAdd.Values )
         {
            productCode = productCodeIterator;
            modConnection.ExecuteSql("Insert into " + Table + "(" + ColumnName + ", ProductID) Values (" + Id.ToString() + ", '" + productCode + "')");
            productCode = default(string);
         }
         foreach ( string productCodeIterator2 in productsToDelete.Values )
         {
            productCode = productCodeIterator2;
            modConnection.ExecuteSql("Delete from " + Table + " Where " + ColumnName + " = " + Id.ToString() + " And ProductID = '" + productCode + "'");
            productCode = default(string);
         }
         editingData = false;
         Mobilize.Web.MessageBox.Show("Data was succesfully saved", "New data", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Information);
         this.Close();
         return ;
         Mobilize.Web.MessageBox.Show("An error has occurred adding the data. Error: (" + Mobilize.Web.Information.Err().Number.ToString() + ") " + Mobilize.Web.Information.Err().Description, "Error", Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Error);
      }

      public void LoadData()
      {
         editingData = false;
         editingData = false;
         codeGeneratedChange = false;
         this.Text = "Add product(s) to " + ObjectReferred;
         lblProductsRelated.Text = "Products related to " + ObjectReferred;
         productsStored = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
         productsToDelete = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
         productsToAdd = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
         LoadProductsById();
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

      private void lvProducts_ItemClick(Mobilize.Web.ListViewItem Item)
      {
         AddProductToSet();
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
            AddProductToSet();
         }
      }

      private void txtName_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         DoSearchProduct();
      }

      private void LoadProductsById()
      {
         string productCode = "";
         modConnection.ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, p.Unit from Products as p, " + Table + " as pb Where pb." + ColumnName + " = " + Id.ToString() + " And pb.ProductId = p.ProductId");
         modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         Mobilize.Web.ListViewItem x = null;
         if ( modConnection.rs.RecordCount > 0 )
         {
            while ( !modConnection.rs.EOF )
            {
               //productCode = CStr(rs.Fields(0).value)
               productCode = Convert.ToString(modConnection.rs[0]);
               modFunctions.AddToCollection(productsStored, productCode);
               x = lvProductsBy.Items.Add(productCode);
               for ( modMain.i = 1; modMain.i <= 2; modMain.i++ )
               {
                  //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
                  if ( !(modConnection.rs.GetField(modMain.i) is null) )
                  {
                     Mobilize.Web.ListView.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
                  }
               }
               Mobilize.Web.ListView.GetListViewSubItem(x, 3).Text = Convert.ToString(modConnection.rs[3]) + Convert.ToString(modConnection.rs[4]);
               modConnection.rs.MoveNext();
            }
         }
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
         modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
         Mobilize.Web.ListViewItem x = null;
         if ( modConnection.rs.RecordCount > 0 )
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
            }
         }
      }

      private void AddProductToSet()
      {
         Mobilize.Web.ListViewItem y = null;
         int i = 0;
         bool found = false;
         Mobilize.Web.ListViewItem x = null;
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !(lvProducts.FocusedItem is null) )
         {
            y = lvProducts.FocusedItem;
            currentIdProduct = lvProducts.FocusedItem.Text;
            found = false;
            int tempForEndVar = lvProductsBy.Items.Count;
            for ( i = 1; i <= tempForEndVar; i++ )
            {
               if ( lvProductsBy.Items[i - 1].Text == currentIdProduct )
               {
                  lvProductsBy.Items[lvProductsBy.Items[i - 1].Index].Selected = true;
                  found = true;
                  break;
               }
               else if ( String.CompareOrdinal(lvProductsBy.Items[i - 1].Text, currentIdProduct) > 0 )
               {
                  break;
               }
            }
            if ( !found )
            {
               editingData = true;
               if ( !modFunctions.Exists(productsStored, currentIdProduct) )
               {
                  if ( modFunctions.Exists(productsToDelete, currentIdProduct) )
                  {
                     productsToDelete.Remove(currentIdProduct);
                  }
                  else
                  {
                     modFunctions.AddToCollection(productsToAdd, currentIdProduct);
                  }
               }
               else
               {
                  if ( modFunctions.Exists(productsToDelete, currentIdProduct) )
                  {
                     productsToDelete.Remove(currentIdProduct);
                  }
               }
               x = lvProductsBy.Items.Insert(i - 1, currentIdProduct);
               Mobilize.Web.ListView.GetListViewSubItem(x, 1).Text = Mobilize.Web.ListView.GetListViewSubItem(y, 1).Text;
               Mobilize.Web.ListView.GetListViewSubItem(x, 2).Text = Mobilize.Web.ListView.GetListViewSubItem(y, 2).Text;
               Mobilize.Web.ListView.GetListViewSubItem(x, 3).Text = Mobilize.Web.ListView.GetListViewSubItem(y, 5).Text + Mobilize.Web.ListView.GetListViewSubItem(y, 6).Text;
            }
         }
      }

      //UPGRADE_NOTE: (7001) The following declaration (ClearFields) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
      //private void ClearFields()
      //{
      //codeGeneratedChange = true;
      //txtCode.Text = "";
      //txtName.Text = "";
      //lvProducts.Items.Clear();
      //lvProductsBy.Items.Clear();
      //txtCode.Focus();
      //editingData = false;
      //codeGeneratedChange = false;
      //}
      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}