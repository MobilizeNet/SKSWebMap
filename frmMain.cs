namespace SKS
{
    using System;
    using Mobilize.Web.Extensions;
    using Mobilize.WebMap.Common.Attributes;

    [Observable]
    internal partial class frmMain
      : Mobilize.Web.Form
   {

    public frmMain()
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
      }

    private void frmMain_Activated(object eventSender, EventArgs eventArgs)
      {
         if ( Stub._UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
         {
            Stub._UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (Mobilize.Web.Form) eventSender;
         }
      }

      // UPGRADE_WARNING: (2080) Form_Load event was upgraded to Form_Load method and has a new behavior. More Information: https://www.mobilize.net/vbtonet/ewis/ewi2080
    private void MDIForm_Load()
      {
         frmSplash.DefInstance.ShowDialog();
         frmOrderRequest.DefInstance.Show();

      }

    public void mnuAbout_Click(object eventSender, EventArgs eventArgs)
      {
         frmAbout.DefInstance.ShowDialog(this);
      }

    public void mnuAddStockManually_Click(object eventSender, EventArgs eventArgs)
      {
         frmAddStockManual.DefInstance.Show();
      }

    public void mnuAdjustStockManually_Click(object eventSender, EventArgs eventArgs)
      {
         frmAdjustStockManual.DefInstance.Show();
      }

    public void mnuCreateOrderReception_Click(object eventSender, EventArgs eventArgs)
      {
         frmOrderReception.DefInstance.Show();
      }

    public void mnuCreateOrderRequest_Click(object eventSender, EventArgs eventArgs)
      {
         frmOrderRequest.DefInstance.Show();
      }

    public void mnuCustomer_Click(object eventSender, EventArgs eventArgs)
      {
         frmCustomers.DefInstance.ShowDialog();
         frmCustomers.DefInstance.InitForm();
      }

    public void mnuExit_Click(object eventSender, EventArgs eventArgs)
      {
         this.Close();
      }

    public void mnuOrderReceptionsApproval_Click(object eventSender, EventArgs eventArgs)
      {
         frmReceptionApproval.DefInstance.Show();
      }

    public void mnuOrderRequestsApproval_Click(object eventSender, EventArgs eventArgs)
      {
         frmRequestApproval.DefInstance.Show();
      }

    public void mnuProducts_Click(object eventSender, EventArgs eventArgs)
      {
         frmProducts.DefInstance.ShowDialog();
      }

    public void mnuProviders_Click(object eventSender, EventArgs eventArgs)
      {
         frmProviders.DefInstance.ShowDialog();
      }

    public void mnuSecurity_Click(object eventSender, EventArgs eventArgs)
      {
         frmUsersManage.DefInstance.Show();
      }

    // UPGRADE_NOTE: (7001) The following declaration (Form_Unload) seems to be dead code More Information: https://www.mobilize.net/vbtonet/ewis/ewi7001
    // private void Form_Unload(int Cancel)
    // {
    // }

   }
}