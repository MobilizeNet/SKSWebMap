using System;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmProviders
      : Mobilize.Web.Form
   {

      public frmProviders()
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

      private void frmProviders_Activated(System.Object eventSender, System.EventArgs eventArgs)
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
      public int CurrentProviderID { get; set; } = 0;

      //Private Sub adcProviders_MoveComplete(ByVal adReason As ADODB.EventReasonEnum, ByVal pError As ADODB.Error, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //NewMode = False
      //EditMode = False
      //CancellingMode = False
      //End Sub
      //Private Sub dcProviders_WillMove(ByVal adReason As ADODB.EventReasonEnum, adStatus As ADODB.EventStatusEnum, ByVal pRecordset As ADODB.Recordset)
      //CancellingMode = True
      //End Sub
      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
      private void Form_Load()
      {
         dcProviders.ConnectionString = modMain.ConnectionString;
         NewMode = false;
         EditMode = false;
         CancellingMode = false;
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
         CurrentProviderID = Convert.ToInt32(dcProviders.Recordset["ProviderId"]);
      }

      private void Toolbar1_ButtonClick(Object eventSender, EventArgs eventArgs)
      {
         Mobilize.Web.ToolStripItem Button = (Mobilize.Web.ToolStripItem)eventSender;
         object x = null;
         //SKS Demo TODO: dcProviders.SetFocus()
         switch ( Button.Text )
         {
            case "Add":
               //Add new record 
               NewMode = true;
               dcProviders.Recordset.AddNew();
               break;
            case "Edit":
               //Edit mode 
               EditMode = true;
               break;
            case "Save":
               Save();
               break;
            case "Delete":
               //Delete record 
               if ( Mobilize.Web.MessageBox.Show("Are you sure you want to delete this record?", "Delete record", Mobilize.Web.MessageBoxButtons.YesNo, Mobilize.Web.MessageBoxIcon.Question) == Mobilize.Web.DialogResult.Yes )
               {
                  dcProviders.Recordset.Delete();
                  dcProviders.Recordset.Requery();
               }
               break;
            case "Search":
               //Search for records 
               modFunctions.SearchShow("Providers", "ProviderName", "Provider");
               break;
            case "Cancel":
               CancellingMode = true;
               //Cancel edited changes 
               EditMode = false;
               NewMode = false;
               dcProviders.Recordset.CancelUpdate();
               dcProviders.Recordset.Requery();
               CancellingMode = false;
               this.Close();
               break;
         }
      }

      private void Save()
      {
         //Save data
         if ( modFunctions.TextBoxEmpty(txtField[0]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[1]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[2]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[4]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[5]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[6]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[7]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[7]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[10]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[11]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[12]) )
         {
            return ;
         }
         if ( modFunctions.TextBoxEmpty(txtField[14]) )
         {
            return ;
         }
         dcProviders.Recordset.Update();
         dcProviders.Recordset.Requery();
         EditMode = false;
         NewMode = false;
      }

      private void txtField_TextChanged(Object eventSender, EventArgs eventArgs)
      {
         if ( !CancellingMode )
         {
            EditMode = true;
         }
      }

   //Used in search form
   //Public Sub SearchCriteria(field As String, value As String)
   //ExecuteSql "Select * from Providers where " & field & " LIKE '" & value & "%'"
   //If rs.RecordCount = 0 Then
   //    MsgBox "There are no records with the selected criteria", vbInformation, "Search"
   //Else
   //    LogStatus "There are " & rs.RecordCount & " that meet with the selected criteria"
   //    Set dcProviders.Recordset = rs
   //End If
   //End Sub
   }

}