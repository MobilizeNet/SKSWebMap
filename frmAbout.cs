using System;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmAbout
      : Mobilize.Web.Form
   {

      public frmAbout()
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

      private void frmAbout_Activated(System.Object eventSender, System.EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm != eventSender )
         {
            Stub._UpgradeHelpers.Gui.Utils.ActivateHelper.myActiveForm = (Mobilize.Web.Form)eventSender;
         }
      }

      // Reg Key Security Options...
      const int READ_CONTROL = 0x20000;
      const int KEY_QUERY_VALUE = 0x1;
      const int KEY_SET_VALUE = 0x2;
      const int KEY_CREATE_SUB_KEY = 0x4;
      const int KEY_ENUMERATE_SUB_KEYS = 0x8;
      const int KEY_NOTIFY = 0x10;
      const int KEY_CREATE_LINK = 0x20;
      const int KEY_ALL_ACCESS = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL;
      // Reg Key ROOT Types...
      const int HKEY_LOCAL_MACHINE = unchecked((int)0x80000002);
      const int ERROR_SUCCESS = 0;
      const int REG_SZ = 1; // Unicode nul terminated string
      const int REG_DWORD = 4; // 32-bit number

      private void cmdOk_Click(Object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

      //UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
      private void Form_Load()
      {
         this.Text = "About " + AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly());
         //lblVersion.Caption = "Version " & App.Major & "." & App.Minor & "." & App.Revision
         lblTitle.Text = AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly());
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }

}