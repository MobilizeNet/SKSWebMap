using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmMain
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmMain m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
      public static frmMain DefInstance
      {
      	get
      	{
      		if (m_vb6FormDefInstance == null || m_vb6FormDefInstance.IsDisposed)
            {
            	m_InitializingDefInstance = true;
            	m_vb6FormDefInstance = CreateInstance();
            	m_InitializingDefInstance = false;
            }
            return m_vb6FormDefInstance;
         }
         set
         {
            m_vb6FormDefInstance = value;
         }
      }

      #endregion
      #region "Windows Form Designer generated code "

      public static frmMain CreateInstance()
      {
      	frmMain theInstance = new frmMain();
      	theInstance.MDIForm_Load();
      	return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuCustomer { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuProviders { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuExit { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuFile { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuCreateOrderRequest { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuOrderRequestsApproval { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripSeparator lExit2 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuCreateOrderReception { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuOrderReceptionsApproval { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuOrders { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAddStockManually { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAdjustStockManually { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuMainInventory { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuSecurity { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAccounts { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuAbout { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripMenuItem mnuHelp { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStrip MainMenu1 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel2 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel3 { get; set; }

      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar { get; set; }
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
            this.MainMenu1 = new Mobilize.Web.ToolStrip();
            this.mnuFile = new Mobilize.Web.ToolStripMenuItem();
            this.mnuCustomer = new Mobilize.Web.ToolStripMenuItem();
            this.mnuProviders = new Mobilize.Web.ToolStripMenuItem();
            this.mnuExit = new Mobilize.Web.ToolStripMenuItem();
            this.mnuOrders = new Mobilize.Web.ToolStripMenuItem();
            this.mnuCreateOrderRequest = new Mobilize.Web.ToolStripMenuItem();
            this.mnuOrderRequestsApproval = new Mobilize.Web.ToolStripMenuItem();
            this.lExit2 = new Mobilize.Web.ToolStripSeparator();
            this.mnuCreateOrderReception = new Mobilize.Web.ToolStripMenuItem();
            this.mnuOrderReceptionsApproval = new Mobilize.Web.ToolStripMenuItem();
            this.mnuMainInventory = new Mobilize.Web.ToolStripMenuItem();
            this.mnuAddStockManually = new Mobilize.Web.ToolStripMenuItem();
            this.mnuAdjustStockManually = new Mobilize.Web.ToolStripMenuItem();
            this.mnuAccounts = new Mobilize.Web.ToolStripMenuItem();
            this.mnuProducts = new Mobilize.Web.ToolStripMenuItem();
            this.mnuSecurity = new Mobilize.Web.ToolStripMenuItem();
            this.mnuHelp = new Mobilize.Web.ToolStripMenuItem();
            this.mnuAbout = new Mobilize.Web.ToolStripMenuItem();
            this.sbStatusBar = new Mobilize.Web.StatusStrip();
            this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
            this.sbStatusBar_Panels_Panel2 = new Mobilize.Web.ToolStripStatusLabel();
            this.sbStatusBar_Panels_Panel3 = new Mobilize.Web.ToolStripStatusLabel();
            this.MainMenu1.SuspendLayout();
            this.sbStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.Items.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.mnuFile,
            this.mnuOrders,
            this.mnuMainInventory,
            this.mnuAccounts,
            this.mnuHelp});
            this.MainMenu1.Location = new System.Drawing.Point(0, 0);
            this.MainMenu1.Name = "MainMenu1";
            this.MainMenu1.Size = new System.Drawing.Size(1113, 24);
            this.MainMenu1.TabIndex = 1;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuProviders,
            this.mnuExit});
            this.mnuFile.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuFile.Name = "mnuFile";
         this.mnuFile.Properties().Size = new System.Drawing.Size(37, 20);
         this.mnuFile.Text = "&File";
         // 
         // mnuCustomer
         // 
         this.mnuCustomer.Name = "mnuCustomer";
         this.mnuCustomer.Properties().Size = new System.Drawing.Size(177, 22);
         this.mnuCustomer.Text = "&Manage Customers";
         this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
         // 
         // mnuProviders
         // 
         this.mnuProviders.Name = "mnuProviders";
         this.mnuProviders.Properties().Size = new System.Drawing.Size(177, 22);
         this.mnuProviders.Text = "Manage Su&ppliers ";
         this.mnuProviders.Click += new System.EventHandler(this.mnuProviders_Click);
         // 
         // mnuExit
         // 
         this.mnuExit.Name = "mnuExit";
         this.mnuExit.Properties().Size = new System.Drawing.Size(177, 22);
         this.mnuExit.Text = "&Exit";
         this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
         // 
         // mnuOrders
         // 
         this.mnuOrders.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.mnuCreateOrderRequest,
            this.mnuOrderRequestsApproval,
            this.lExit2,
            this.mnuCreateOrderReception,
            this.mnuOrderReceptionsApproval});
            this.mnuOrders.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuOrders.Name = "mnuOrders";
         this.mnuOrders.Properties().Size = new System.Drawing.Size(54, 20);
         this.mnuOrders.Text = "&Orders";
         // 
         // mnuCreateOrderRequest
         // 
         this.mnuCreateOrderRequest.Name = "mnuCreateOrderRequest";
         this.mnuCreateOrderRequest.Properties().Size = new System.Drawing.Size(195, 22);
         this.mnuCreateOrderRequest.Text = "Create Order";
         this.mnuCreateOrderRequest.Click += new System.EventHandler(this.mnuCreateOrderRequest_Click);
         // 
         // mnuOrderRequestsApproval
         // 
         this.mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval";
         this.mnuOrderRequestsApproval.Properties().Size = new System.Drawing.Size(195, 22);
         this.mnuOrderRequestsApproval.Text = "Create Invoice";
         this.mnuOrderRequestsApproval.Click += new System.EventHandler(this.mnuOrderRequestsApproval_Click);
         // 
         // lExit2
         // 
         this.lExit2.Properties().AllowDrop = true;
         this.lExit2.Name = "lExit2";
         this.lExit2.Properties().Size = new System.Drawing.Size(192, 6);
         // 
         // mnuCreateOrderReception
         // 
         this.mnuCreateOrderReception.Name = "mnuCreateOrderReception";
         this.mnuCreateOrderReception.Properties().Size = new System.Drawing.Size(195, 22);
         this.mnuCreateOrderReception.Text = "Add Stock Order";
         this.mnuCreateOrderReception.Click += new System.EventHandler(this.mnuCreateOrderReception_Click);
         // 
         // mnuOrderReceptionsApproval
         // 
         this.mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval";
         this.mnuOrderReceptionsApproval.Properties().Size = new System.Drawing.Size(195, 22);
         this.mnuOrderReceptionsApproval.Text = "Add Stock to Inventory";
         this.mnuOrderReceptionsApproval.Click += new System.EventHandler(this.mnuOrderReceptionsApproval_Click);
         // 
         // mnuMainInventory
         // 
         this.mnuMainInventory.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.mnuAddStockManually,
            this.mnuAdjustStockManually});
            this.mnuMainInventory.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuMainInventory.Name = "mnuMainInventory";
         this.mnuMainInventory.Properties().Size = new System.Drawing.Size(69, 20);
         this.mnuMainInventory.Text = "&Inventory";
         // 
         // mnuAddStockManually
         // 
         this.mnuAddStockManually.Name = "mnuAddStockManually";
         this.mnuAddStockManually.Properties().Size = new System.Drawing.Size(165, 22);
         this.mnuAddStockManually.Text = "Inventory Update";
         this.mnuAddStockManually.Click += new System.EventHandler(this.mnuAddStockManually_Click);
         // 
         // mnuAdjustStockManually
         // 
         this.mnuAdjustStockManually.Name = "mnuAdjustStockManually";
         this.mnuAdjustStockManually.Properties().Size = new System.Drawing.Size(165, 22);
         this.mnuAdjustStockManually.Text = "Inventory Adjust";
         this.mnuAdjustStockManually.Click += new System.EventHandler(this.mnuAdjustStockManually_Click);
         // 
         // mnuAccounts
         // 
         this.mnuAccounts.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.mnuProducts,
            this.mnuSecurity});
            this.mnuAccounts.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuAccounts.Name = "mnuAccounts";
         this.mnuAccounts.Properties().Size = new System.Drawing.Size(88, 20);
         this.mnuAccounts.Text = "&Maintenance";
         // 
         // mnuProducts
         // 
         this.mnuProducts.Name = "mnuProducts";
         this.mnuProducts.Properties().Size = new System.Drawing.Size(167, 22);
         this.mnuProducts.Text = "Manage Products";
         this.mnuProducts.Click += new System.EventHandler(this.mnuProducts_Click);
         // 
         // mnuSecurity
         // 
         this.mnuSecurity.Name = "mnuSecurity";
         this.mnuSecurity.Properties().Size = new System.Drawing.Size(167, 22);
         this.mnuSecurity.Text = "Manage Users";
         this.mnuSecurity.Click += new System.EventHandler(this.mnuSecurity_Click);
         // 
         // mnuHelp
         // 
         this.mnuHelp.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Properties().MergeAction = Stub._System.Windows.Forms.MergeAction.Remove;
         this.mnuHelp.Name = "mnuHelp";
         this.mnuHelp.Properties().Size = new System.Drawing.Size(44, 20);
         this.mnuHelp.Text = "&Help";
         // 
         // mnuAbout
         // 
         this.mnuAbout.Name = "mnuAbout";
         this.mnuAbout.Properties().Size = new System.Drawing.Size(107, 22);
         this.mnuAbout.Text = "&About";
         this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] {
            this.sbStatusBar_Panels_Panel1,
            this.sbStatusBar_Panels_Panel2,
            this.sbStatusBar_Panels_Panel3});
            this.sbStatusBar.Location = new System.Drawing.Point(0, 683);
            this.sbStatusBar.Name = "sbStatusBar";
            this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(1113, 25);
         this.sbStatusBar.TabIndex = 0;
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = ((Mobilize.Web.ToolStripStatusLabelBorderSides)((((Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top)
                  | Mobilize.Web.ToolStripStatusLabelBorderSides.Right)
               | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom)));
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Name = "sbStatusBar_Panels_Panel1";
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(906, 25);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         // 
         // sbStatusBar_Panels_Panel2
         // 
         this.sbStatusBar_Panels_Panel2.Properties().AutoSize = false;
         this.sbStatusBar_Panels_Panel2.Properties().BorderSides = ((Mobilize.Web.ToolStripStatusLabelBorderSides)((((Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top)
                  | Mobilize.Web.ToolStripStatusLabelBorderSides.Right)
               | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom)));
         this.sbStatusBar_Panels_Panel2.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel2.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel2.Name = "sbStatusBar_Panels_Panel2";
         this.sbStatusBar_Panels_Panel2.Properties().Size = new System.Drawing.Size(96, 25);
         this.sbStatusBar_Panels_Panel2.Text = "1:25 PM";
         this.sbStatusBar_Panels_Panel2.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         // 
         // sbStatusBar_Panels_Panel3
         // 
         this.sbStatusBar_Panels_Panel3.Properties().AutoSize = false;
         this.sbStatusBar_Panels_Panel3.Properties().BorderSides = ((Mobilize.Web.ToolStripStatusLabelBorderSides)((((Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top)
                  | Mobilize.Web.ToolStripStatusLabelBorderSides.Right)
               | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom)));
         this.sbStatusBar_Panels_Panel3.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel3.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel3.Name = "sbStatusBar_Panels_Panel3";
         this.sbStatusBar_Panels_Panel3.Properties().Size = new System.Drawing.Size(96, 25);
         this.sbStatusBar_Panels_Panel3.Text = "2/21/2018";
         this.sbStatusBar_Panels_Panel3.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.AllowDrop = true;
         this.BackColor = Mobilize.Web.SystemColors.AppWorkspace;
         this.Properties().ClientSize = new System.Drawing.Size(1113, 708);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.MainMenu1);
         this.Icon = null;
         this.IsMdiContainer = true;
         this.Properties().Location = new System.Drawing.Point(11, 54);
         this.Name = "frmMain";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Text = "Sales Agent";
         this.WindowState = Mobilize.Web.FormWindowState.Maximized;
         this.MainMenu1.ResumeLayout(false);
         this.MainMenu1.PerformLayout();
         this.sbStatusBar.ResumeLayout(false);
         this.sbStatusBar.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

   }
   #endregion

   }
}