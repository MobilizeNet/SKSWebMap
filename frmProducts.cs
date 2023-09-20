using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmProducts
      : Mobilize.Web.Form
   {

      public frmProducts()
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

      private void frmProducts_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender )
         {
            Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (Mobilize.Web.Form)eventSender;
         }
      }

      [Intercepted]
      private bool NewMode { get; set; } = false;

      [Intercepted]
      private bool EditMode { get; set; } = false;

      [Intercepted]
      private bool CancellingMode { get; set; } = false;

      [Intercepted]
      public string CurrentProductID { get; set; } = "";

      //SKS Demo TODO: Go the the designer and change the data binding of _txtField_4 like this:
      //_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C2");
      private void cmbCategory_SelectedIndexChanged(Object eventSender, EventArgs eventArgs)
      {
         if ( cmbCategory.Items.Count == 0 || cmbCategory.SelectedIndex == -1 )
         {
            return ;
         }
         txtCategory.Text = cmbCategory.GetItemData(cmbCategory.SelectedIndex).ToString();
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
         CurrentProductID = Convert.ToString(dcProducts.Recordset["ProductId"]);
      }

      private void txtCategory_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         if ( cmbCategory.Items.Count == 0 )
         {
            modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( String.IsNullOrEmpty(txtCategory.Text) )
         {
            cmbCategory.SelectedIndex = -1;
            return ;
         }
         int Index = -1;
         int tempForEndVar = cmbCategory.Items.Count;
         for ( modMain.i = 0; modMain.i <= tempForEndVar; modMain.i++ )
         {
            if ( cmbCategory.GetItemData(modMain.i) == StringsHelper.ToDoubleSafe(txtCategory.Text) )
            {
               Index = modMain.i;
               break;
            }
         }
         cmbCategory.SelectedIndex = modMain.i;
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
      private void Form_Load()
      {
         txtCategory.Height = 0;
         txtCategory.Width = 0;
         dcProducts.ConnectionString = modMain.ConnectionString;
         NewMode = false;
         EditMode = false;
         CancellingMode = false;
         if ( cmbCategory.Items.Count == 0 )
         {
            modFunctions.LoadCombo("Categories", cmbCategory, "CategoryName", "CategoryID");
         }
      }

      private void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Mobilize.Web.ToolStripItem Button = (Mobilize.Web.ToolStripItem)eventSender;
         object x = null;
         //SKS Demo TODO: dcProducts.SetFocus()
         switch ( Button.Text )
         {
            case "Add":
               //Add new record 
               NewMode = true;
               dcProducts.Recordset.AddNew();
               dcProducts.Recordset["UnitsInStock"] = 0;
               dcProducts.Recordset["UnitsOnOrder"] = 0;
               dcProducts.Recordset["Discontinued"] = 0;
               break;
            case "Edit":
               //Edit mode 
               EditMode = true;
               //dcProducts.Recordset.EditMode = 
               break;
            case "Save":
               //Save data 
               dcProducts.Recordset.Update();
               dcProducts.Recordset.Requery(); // SQLite ODBC driver needs to requery the info 

               EditMode = false;
               NewMode = false;
               break;
            case "Delete":
               //Delete record 
               if ( Mobilize.Web.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes )
               {
                  dcProducts.Recordset.Delete();
                  dcProducts.Recordset.Requery();
               }
               break;
            case "Search":
               //Search for records 
               modFunctions.SearchShow("Products", "ProductName", "product");
               break;
            case "Cancel":
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcProducts.Recordset.CancelUpdate();
               dcProducts.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
      }

   //Private Sub txtField_KeyPress(Index As Integer, KeyAscii As Integer)
   //If Index = 0 Then
   //    KeyAscii = Asc(UCase(Chr(KeyAscii)))
   //ElseIf Index = 4 Or Index = 5 Then
   //    Select Case KeyAscii
   //        Case vbKey0 To vbKey9
   //        Case vbKeyBack, vbKeyClear, vbKeyDelete
   //        Case vbKeyLeft, vbKeyRight, vbKeyUp, vbKeyDown, vbKeyTab
   //        Case Else
   //            KeyAscii = 0
   //            Beep
   //    End Select
   //End If
   //End Sub
   }

}