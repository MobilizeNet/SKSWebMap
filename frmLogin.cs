using System;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal partial class frmLogin
      : Mobilize.Web.Form
   {

      [Intercepted]


      public bool LoginSucceeded { get; set; } = false;


      public frmLogin()
      	: base()
      {
      	if (m_vb6FormDefInstance == null)
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
         			if (System.Reflection.Assembly.GetExecutingAssembly().EntryPoint != null && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
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



      private void cmdCancel_Click(Object eventSender, EventArgs eventArgs)
      {
      	LoginSucceeded = false;
         this.Close();
      }

      private void cmdOk_Click(Object eventSender, EventArgs eventArgs)
      {
      	modConnection.ExecuteSql("SELECT * FROM Users WHERE username = '" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'");
      	if (modConnection.rs.EOF)
      	{
            Mobilize.Web.MessageBox.Show("Invalid 'Username' or 'Password', please try again!", System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductName, Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Exclamation);
            txtUserName.Focus();
            modFunctions.SelectAll(txtUserName);
            return;
         }
         modMain.UserFullname = Convert.ToString(modConnection.rs["Fullname"]);
         modMain.UserLevel = Convert.ToString(modConnection.rs["Level"]);
         modMain.CurrentUserAdmin = (modMain.UserLevel == "Administrator");
         this.Properties().Cursor = null;
         LoginSucceeded = true;
         modMain.LogStatus("User : " + modMain.UserFullname + " logged at " + DateTimeHelper.ToString(DateTime.Parse(DateTimeHelper.ToString(DateTime.Now))) + "," + DateTimeHelper.ToString(DateTime.Now));
         this.Close();
      }

      private void Form_Closed(Object eventSender, EventArgs eventArgs)
      {
      }

   }
}