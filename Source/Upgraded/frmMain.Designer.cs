
namespace SKS
{
	partial class frmMain
	{

		#region "Upgrade Support "
		private static frmMain m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmMain DefInstance
		{
			get
			{
				if (m_vb6FormDefInstance is null || m_vb6FormDefInstance.IsDisposed)
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "mnuCustomer", "mnuProviders", "mnuExit", "mnuFile", "mnuCreateOrderRequest", "mnuOrderRequestsApproval", "lExit2", "mnuCreateOrderReception", "mnuOrderReceptionsApproval", "mnuOrders", "mnuAddStockManually", "mnuAdjustStockManually", "mnuMainInventory", "mnuProducts", "mnuSecurity", "mnuAccounts", "mnuAbout", "mnuHelp", "MainMenu1", "sbStatusBar_Panels_Panel1", "sbStatusBar_Panels_Panel2", "sbStatusBar_Panels_Panel3", "sbStatusBar"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ToolStripMenuItem mnuCustomer;
		public System.Windows.Forms.ToolStripMenuItem mnuProviders;
		public System.Windows.Forms.ToolStripMenuItem mnuExit;
		public System.Windows.Forms.ToolStripMenuItem mnuFile;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateOrderRequest;
		public System.Windows.Forms.ToolStripMenuItem mnuOrderRequestsApproval;
		public System.Windows.Forms.ToolStripSeparator lExit2;
		public System.Windows.Forms.ToolStripMenuItem mnuCreateOrderReception;
		public System.Windows.Forms.ToolStripMenuItem mnuOrderReceptionsApproval;
		public System.Windows.Forms.ToolStripMenuItem mnuOrders;
		public System.Windows.Forms.ToolStripMenuItem mnuAddStockManually;
		public System.Windows.Forms.ToolStripMenuItem mnuAdjustStockManually;
		public System.Windows.Forms.ToolStripMenuItem mnuMainInventory;
		public System.Windows.Forms.ToolStripMenuItem mnuProducts;
		public System.Windows.Forms.ToolStripMenuItem mnuSecurity;
		public System.Windows.Forms.ToolStripMenuItem mnuAccounts;
		public System.Windows.Forms.ToolStripMenuItem mnuAbout;
		public System.Windows.Forms.ToolStripMenuItem mnuHelp;
		public System.Windows.Forms.MenuStrip MainMenu1;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel2;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel3;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.MainMenu1 = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuProviders = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOrders = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCreateOrderRequest = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOrderRequestsApproval = new System.Windows.Forms.ToolStripMenuItem();
			this.lExit2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuCreateOrderReception = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOrderReceptionsApproval = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMainInventory = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAddStockManually = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAdjustStockManually = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAccounts = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuProducts = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSecurity = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.sbStatusBar = new System.Windows.Forms.StatusStrip();
			this.sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.sbStatusBar_Panels_Panel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.sbStatusBar_Panels_Panel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.sbStatusBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenu1
			// 
			this.MainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuFile, this.mnuOrders, this.mnuMainInventory, this.mnuAccounts, this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Available = true;
			this.mnuFile.Checked = false;
			this.mnuFile.Enabled = true;
			this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.Remove;
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Text = "&File";
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuCustomer, this.mnuProviders, this.mnuExit});
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
			this.mnuOrders.MergeAction = System.Windows.Forms.MergeAction.Remove;
			this.mnuOrders.Name = "mnuOrders";
			this.mnuOrders.Text = "&Orders";
			this.mnuOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuCreateOrderRequest, this.mnuOrderRequestsApproval, this.lExit2, this.mnuCreateOrderReception, this.mnuOrderReceptionsApproval});
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
			this.lExit2.AllowDrop = true;
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
			this.mnuMainInventory.MergeAction = System.Windows.Forms.MergeAction.Remove;
			this.mnuMainInventory.Name = "mnuMainInventory";
			this.mnuMainInventory.Text = "&Inventory";
			this.mnuMainInventory.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuAddStockManually, this.mnuAdjustStockManually});
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
			this.mnuAccounts.MergeAction = System.Windows.Forms.MergeAction.Remove;
			this.mnuAccounts.Name = "mnuAccounts";
			this.mnuAccounts.Text = "&Maintenance";
			this.mnuAccounts.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuProducts, this.mnuSecurity});
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
			this.mnuHelp.MergeAction = System.Windows.Forms.MergeAction.Remove;
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Text = "&Help";
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]{this.mnuAbout});
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
			this.sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.sbStatusBar.Location = new System.Drawing.Point(0, 683);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.ShowItemToolTips = true;
			this.sbStatusBar.Size = new System.Drawing.Size(1113, 25);
			this.sbStatusBar.TabIndex = 0;
			this.sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
			this.sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.sbStatusBar_Panels_Panel2});
			this.sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.sbStatusBar_Panels_Panel3});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			this.sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			this.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			this.sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(901, 25);
			this.sbStatusBar_Panels_Panel1.Spring = true;
			this.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// sbStatusBar_Panels_Panel2
			// 
			this.sbStatusBar_Panels_Panel2.AutoSize = false;
			this.sbStatusBar_Panels_Panel2.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			this.sbStatusBar_Panels_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.sbStatusBar_Panels_Panel2.DoubleClickEnabled = true;
			this.sbStatusBar_Panels_Panel2.Margin = new System.Windows.Forms.Padding(0);
			this.sbStatusBar_Panels_Panel2.Size = new System.Drawing.Size(96, 25);
			this.sbStatusBar_Panels_Panel2.Text = "1:25 PM";
			this.sbStatusBar_Panels_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sbStatusBar_Panels_Panel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// sbStatusBar_Panels_Panel3
			// 
			this.sbStatusBar_Panels_Panel3.AutoSize = false;
			this.sbStatusBar_Panels_Panel3.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			this.sbStatusBar_Panels_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.sbStatusBar_Panels_Panel3.DoubleClickEnabled = true;
			this.sbStatusBar_Panels_Panel3.Margin = new System.Windows.Forms.Padding(0);
			this.sbStatusBar_Panels_Panel3.Size = new System.Drawing.Size(96, 25);
			this.sbStatusBar_Panels_Panel3.Text = "2/21/2018";
			this.sbStatusBar_Panels_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sbStatusBar_Panels_Panel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// frmMain
			// 
			this.AllowDrop = true;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.ClientSize = new System.Drawing.Size(1113, 708);
			this.Controls.Add(this.sbStatusBar);
			this.Controls.Add(MainMenu1);
			this.Enabled = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.IsMdiContainer = true;
			this.Location = new System.Drawing.Point(11, 54);
			this.Name = "frmMain";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Sales Agent";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Activated += new System.EventHandler(this.frmMain_Activated);
			this.sbStatusBar.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
	}
}