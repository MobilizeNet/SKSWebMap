using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmMain
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmMain m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmMain DefInstance
      {
         get
         {
            if ( m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed )
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
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

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
         this.components = new Mobilize.Web.ControlCollection();
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
         this.sbStatusBar.SuspendLayout();
         this.SuspendLayout();
         // 
         // MainMenu1
         // 
         this.MainMenu1.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.mnuFile, this.mnuOrders, this.mnuMainInventory, this.mnuAccounts, this.mnuHelp });
         // 
         // mnuFile
         // 
         this.mnuFile.Available = true;
         this.mnuFile.Checked = false;
         this.mnuFile.Enabled = true;
         this.mnuFile.Properties().MergeAction = Mobilize.Web.MergeAction.Remove;
         this.mnuFile.Name = "mnuFile";
         this.mnuFile.Text = "&File";
         this.mnuFile.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.mnuCustomer, this.mnuProviders, this.mnuExit });
         // 
         // mnuCustomer
         // 
         this.mnuCustomer.Available = true;
         this.mnuCustomer.Checked = false;
         this.mnuCustomer.Enabled = true;
         this.mnuCustomer.Name = "mnuCustomer";
         this.mnuCustomer.Text = "&Manage Customers";
         this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
         // 
         // mnuProviders
         // 
         this.mnuProviders.Available = true;
         this.mnuProviders.Checked = false;
         this.mnuProviders.Enabled = true;
         this.mnuProviders.Name = "mnuProviders";
         this.mnuProviders.Text = "Manage Su&ppliers ";
         this.mnuProviders.Click += new System.EventHandler(this.mnuProviders_Click);
         // 
         // mnuExit
         // 
         this.mnuExit.Available = true;
         this.mnuExit.Checked = false;
         this.mnuExit.Enabled = true;
         this.mnuExit.Name = "mnuExit";
         this.mnuExit.Text = "&Exit";
         this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
         // 
         // mnuOrders
         // 
         this.mnuOrders.Available = true;
         this.mnuOrders.Checked = false;
         this.mnuOrders.Enabled = true;
         this.mnuOrders.Properties().MergeAction = Mobilize.Web.MergeAction.Remove;
         this.mnuOrders.Name = "mnuOrders";
         this.mnuOrders.Text = "&Orders";
         this.mnuOrders.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.mnuCreateOrderRequest, this.mnuOrderRequestsApproval, this.lExit2, this.mnuCreateOrderReception, this.mnuOrderReceptionsApproval });
         // 
         // mnuCreateOrderRequest
         // 
         this.mnuCreateOrderRequest.Available = true;
         this.mnuCreateOrderRequest.Checked = false;
         this.mnuCreateOrderRequest.Enabled = true;
         this.mnuCreateOrderRequest.Name = "mnuCreateOrderRequest";
         this.mnuCreateOrderRequest.Text = "Create Order";
         this.mnuCreateOrderRequest.Click += new System.EventHandler(this.mnuCreateOrderRequest_Click);
         // 
         // mnuOrderRequestsApproval
         // 
         this.mnuOrderRequestsApproval.Available = true;
         this.mnuOrderRequestsApproval.Checked = false;
         this.mnuOrderRequestsApproval.Enabled = true;
         this.mnuOrderRequestsApproval.Name = "mnuOrderRequestsApproval";
         this.mnuOrderRequestsApproval.Text = "Create Invoice";
         this.mnuOrderRequestsApproval.Click += new System.EventHandler(this.mnuOrderRequestsApproval_Click);
         // 
         // lExit2
         // 
         this.lExit2.Properties().AllowDrop = true;
         this.lExit2.Available = true;
         this.lExit2.Enabled = true;
         this.lExit2.Name = "lExit2";
         // 
         // mnuCreateOrderReception
         // 
         this.mnuCreateOrderReception.Available = true;
         this.mnuCreateOrderReception.Checked = false;
         this.mnuCreateOrderReception.Enabled = true;
         this.mnuCreateOrderReception.Name = "mnuCreateOrderReception";
         this.mnuCreateOrderReception.Text = "Add Stock Order";
         this.mnuCreateOrderReception.Click += new System.EventHandler(this.mnuCreateOrderReception_Click);
         // 
         // mnuOrderReceptionsApproval
         // 
         this.mnuOrderReceptionsApproval.Available = true;
         this.mnuOrderReceptionsApproval.Checked = false;
         this.mnuOrderReceptionsApproval.Enabled = true;
         this.mnuOrderReceptionsApproval.Name = "mnuOrderReceptionsApproval";
         this.mnuOrderReceptionsApproval.Text = "Add Stock to Inventory";
         this.mnuOrderReceptionsApproval.Click += new System.EventHandler(this.mnuOrderReceptionsApproval_Click);
         // 
         // mnuMainInventory
         // 
         this.mnuMainInventory.Available = true;
         this.mnuMainInventory.Checked = false;
         this.mnuMainInventory.Enabled = true;
         this.mnuMainInventory.Properties().MergeAction = Mobilize.Web.MergeAction.Remove;
         this.mnuMainInventory.Name = "mnuMainInventory";
         this.mnuMainInventory.Text = "&Inventory";
         this.mnuMainInventory.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.mnuAddStockManually, this.mnuAdjustStockManually });
         // 
         // mnuAddStockManually
         // 
         this.mnuAddStockManually.Available = true;
         this.mnuAddStockManually.Checked = false;
         this.mnuAddStockManually.Enabled = true;
         this.mnuAddStockManually.Name = "mnuAddStockManually";
         this.mnuAddStockManually.Text = "Inventory Update";
         this.mnuAddStockManually.Click += new System.EventHandler(this.mnuAddStockManually_Click);
         // 
         // mnuAdjustStockManually
         // 
         this.mnuAdjustStockManually.Available = true;
         this.mnuAdjustStockManually.Checked = false;
         this.mnuAdjustStockManually.Enabled = true;
         this.mnuAdjustStockManually.Name = "mnuAdjustStockManually";
         this.mnuAdjustStockManually.Text = "Inventory Adjust";
         this.mnuAdjustStockManually.Click += new System.EventHandler(this.mnuAdjustStockManually_Click);
         // 
         // mnuAccounts
         // 
         this.mnuAccounts.Available = true;
         this.mnuAccounts.Checked = false;
         this.mnuAccounts.Enabled = true;
         this.mnuAccounts.Properties().MergeAction = Mobilize.Web.MergeAction.Remove;
         this.mnuAccounts.Name = "mnuAccounts";
         this.mnuAccounts.Text = "&Maintenance";
         this.mnuAccounts.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.mnuProducts, this.mnuSecurity });
         // 
         // mnuProducts
         // 
         this.mnuProducts.Available = true;
         this.mnuProducts.Checked = false;
         this.mnuProducts.Enabled = true;
         this.mnuProducts.Name = "mnuProducts";
         this.mnuProducts.Text = "Manage Products";
         this.mnuProducts.Click += new System.EventHandler(this.mnuProducts_Click);
         // 
         // mnuSecurity
         // 
         this.mnuSecurity.Available = true;
         this.mnuSecurity.Checked = false;
         this.mnuSecurity.Enabled = true;
         this.mnuSecurity.Name = "mnuSecurity";
         this.mnuSecurity.Text = "Manage Users";
         this.mnuSecurity.Click += new System.EventHandler(this.mnuSecurity_Click);
         // 
         // mnuHelp
         // 
         this.mnuHelp.Available = true;
         this.mnuHelp.Checked = false;
         this.mnuHelp.Enabled = true;
         this.mnuHelp.Properties().MergeAction = Mobilize.Web.MergeAction.Remove;
         this.mnuHelp.Name = "mnuHelp";
         this.mnuHelp.Text = "&Help";
         this.mnuHelp.DropDownItems.AddRange(new Mobilize.Web.ToolStripItem[] { this.mnuAbout });
         // 
         // mnuAbout
         // 
         this.mnuAbout.Available = true;
         this.mnuAbout.Checked = false;
         this.mnuAbout.Enabled = true;
         this.mnuAbout.Name = "mnuAbout";
         this.mnuAbout.Text = "&About";
         this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.sbStatusBar.Location = new System.Drawing.Point(0, 683);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(1113, 25);
         this.sbStatusBar.TabIndex = 0;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.sbStatusBar_Panels_Panel1 });
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.sbStatusBar_Panels_Panel2 });
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.sbStatusBar_Panels_Panel3 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides)(Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(901, 25);
         this.sbStatusBar_Panels_Panel1.Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // sbStatusBar_Panels_Panel2
         // 
         this.sbStatusBar_Panels_Panel2.AutoSize = false;
         this.sbStatusBar_Panels_Panel2.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides)(Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel2.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel2.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel2.Size = new System.Drawing.Size(96, 25);
         this.sbStatusBar_Panels_Panel2.Text = "1:25 PM";
         this.sbStatusBar_Panels_Panel2.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel2.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // sbStatusBar_Panels_Panel3
         // 
         this.sbStatusBar_Panels_Panel3.AutoSize = false;
         this.sbStatusBar_Panels_Panel3.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides)(Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel3.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel3.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel3.Size = new System.Drawing.Size(96, 25);
         this.sbStatusBar_Panels_Panel3.Text = "2/21/2018";
         this.sbStatusBar_Panels_Panel3.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel3.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // frmMain
         // 
         this.AllowDrop = true;
         this.BackColor = Mobilize.Web.SystemColors.AppWorkspace;
         this.ClientSize = new System.Drawing.Size(1113, 708);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(MainMenu1);
         this.Enabled = true;
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.IsMdiContainer = true;
         this.Properties().Location = new System.Drawing.Point(11, 54);
         this.Name = "frmMain";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Text = "Sales Agent";
         this.WindowState = Mobilize.Web.FormWindowState.Maximized;
         this.Activated += new System.EventHandler(this.frmMain_Activated);
         this.sbStatusBar.ResumeLayout(false);
         this.ResumeLayout(false);
      }
#endregion

   }

}