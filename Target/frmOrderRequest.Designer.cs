using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{
	partial class frmOrderRequest
	{

#region "Upgrade Support "
      [Intercepted]
      private static frmOrderRequest m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmOrderRequest DefInstance
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

      public static frmOrderRequest CreateInstance()
      {
      	frmOrderRequest theInstance = new frmOrderRequest();
      	theInstance.Form_Load();
      	return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "dtRequired", "cmdSave", "cmdAddProducts", "cmdClose", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "lvCustomers_ColumnHeader_1_", "lvCustomers_ColumnHeader_2_", "lvCustomers_ColumnHeader_3_", "lvCustomers_ColumnHeader_4_", "lvCustomers_ColumnHeader_5_", "lvCustomers_ColumnHeader_6_", "lvCustomers_ColumnHeader_7_", "lvCustomers", "Label3", "Label4", "Label2", "Frame1", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "dtPromised", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label7", "Label6", "listViewHelper1"};

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtSubTotal { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtTotal { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtTotalTax { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtFreightCharge { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtSalesTax { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtEntry { get; set; }

      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar { get; set; }

      [Intercepted]
      public Mobilize.Web.DateTimePicker dtRequired { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdSave { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdAddProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtContactLastName { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtContactName { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdCustomers { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCompanyName { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_1_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_2_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_3_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_4_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_5_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_6_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvCustomers_ColumnHeader_7_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView lvCustomers { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label2 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCustomerContact { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCustomerCompany { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label5 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label1 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame2 { get; set; }

      [Intercepted]
      public Mobilize.Web.DateTimePicker dtPromised { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label13 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label12 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label11 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label10 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label9 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label8 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label7 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label6 { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView listViewHelper1 { get; set; }
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new Mobilize.Web.ControlCollection();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderRequest));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.txtSubTotal = new Mobilize.Web.TextBox();
      	this.txtTotal = new Mobilize.Web.TextBox();
      	this.txtTotalTax = new Mobilize.Web.TextBox();
      	this.txtFreightCharge = new Mobilize.Web.TextBox();
      	this.txtSalesTax = new Mobilize.Web.TextBox();
      	this.txtEntry = new Mobilize.Web.TextBox();
      	this.fgProducts = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.dtRequired = new Mobilize.Web.DateTimePicker();
      	this.cmdSave = new Mobilize.Web.Button();
      	this.cmdAddProducts = new Mobilize.Web.Button();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.Frame1 = new Mobilize.Web.GroupBox();
      	this.txtContactLastName = new Mobilize.Web.TextBox();
      	this.txtContactName = new Mobilize.Web.TextBox();
      	this.cmdCustomers = new Mobilize.Web.Button();
      	this.txtCompanyName = new Mobilize.Web.TextBox();
      	this.lvCustomers = new Mobilize.Web.ListView();
      	this.lvCustomers_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvCustomers_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvCustomers_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvCustomers_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvCustomers_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvCustomers_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
      	this.lvCustomers_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.Label2 = new Mobilize.Web.Label();
      	this.Frame2 = new Mobilize.Web.GroupBox();
      	this.txtCustomerContact = new Mobilize.Web.TextBox();
      	this.txtCustomerCompany = new Mobilize.Web.TextBox();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.dtPromised = new Mobilize.Web.DateTimePicker();
      	this.Label13 = new Mobilize.Web.Label();
      	this.Label12 = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame1.SuspendLayout();
      	this.lvCustomers.SuspendLayout();
      	this.Frame2.SuspendLayout();
      	this.SuspendLayout();
      	this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
      	// 
      	// txtSubTotal
      	// 
      	this.txtSubTotal.AcceptsReturn = true;
      	this.txtSubTotal.AllowDrop = true;
      	this.txtSubTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSubTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSubTotal.Properties().Cursor = null;
         this.txtSubTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSubTotal.Location = new System.Drawing.Point(352, 616);
         this.txtSubTotal.MaxLength = 0;
         this.txtSubTotal.Name = "txtSubTotal";
         this.txtSubTotal.ReadOnly = true;
         this.txtSubTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSubTotal.Size = new System.Drawing.Size(145, 20);
         this.txtSubTotal.TabIndex = 31;
         this.txtSubTotal.TabStop = false;
         this.txtSubTotal.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtTotal
         // 
         this.txtTotal.AcceptsReturn = true;
         this.txtTotal.AllowDrop = true;
         this.txtTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtTotal.Properties().Cursor = null;
         this.txtTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtTotal.Location = new System.Drawing.Point(96, 616);
         this.txtTotal.MaxLength = 0;
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.ReadOnly = true;
         this.txtTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotal.Size = new System.Drawing.Size(145, 20);
         this.txtTotal.TabIndex = 29;
         this.txtTotal.TabStop = false;
         this.txtTotal.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtTotalTax
         // 
         this.txtTotalTax.AcceptsReturn = true;
         this.txtTotalTax.AllowDrop = true;
         this.txtTotalTax.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtTotalTax.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtTotalTax.Properties().Cursor = null;
         this.txtTotalTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtTotalTax.Location = new System.Drawing.Point(352, 592);
         this.txtTotalTax.MaxLength = 0;
         this.txtTotalTax.Name = "txtTotalTax";
         this.txtTotalTax.ReadOnly = true;
         this.txtTotalTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotalTax.Size = new System.Drawing.Size(145, 20);
         this.txtTotalTax.TabIndex = 27;
         this.txtTotalTax.TabStop = false;
         this.txtTotalTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtFreightCharge
         // 
         this.txtFreightCharge.AcceptsReturn = true;
         this.txtFreightCharge.AllowDrop = true;
         this.txtFreightCharge.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtFreightCharge.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtFreightCharge.Properties().Cursor = null;
         this.txtFreightCharge.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFreightCharge.Location = new System.Drawing.Point(96, 592);
         this.txtFreightCharge.MaxLength = 0;
         this.txtFreightCharge.Name = "txtFreightCharge";
         this.txtFreightCharge.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         this.txtFreightCharge.TabIndex = 8;
         this.txtFreightCharge.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.txtFreightCharge.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtFreightCharge_KeyPress);
         this.txtFreightCharge.TextChanged += new System.EventHandler(this.txtFreightCharge_TextChanged);
         // 
         // txtSalesTax
         // 
         this.txtSalesTax.AcceptsReturn = true;
         this.txtSalesTax.AllowDrop = true;
         this.txtSalesTax.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtSalesTax.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSalesTax.Properties().Cursor = null;
         this.txtSalesTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSalesTax.Location = new System.Drawing.Point(96, 568);
         this.txtSalesTax.MaxLength = 0;
         this.txtSalesTax.Name = "txtSalesTax";
         this.txtSalesTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
         this.txtSalesTax.TabIndex = 7;
         this.txtSalesTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.txtSalesTax.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtSalesTax_KeyPress);
         this.txtSalesTax.TextChanged += new System.EventHandler(this.txtSalesTax_TextChanged);
         // 
         // txtEntry
         // 
         this.txtEntry.AcceptsReturn = true;
         this.txtEntry.AllowDrop = true;
         this.txtEntry.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtEntry.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtEntry.Properties().Cursor = null;
         this.txtEntry.Enabled = false;
         this.txtEntry.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtEntry.Location = new System.Drawing.Point(96, 544);
         this.txtEntry.MaxLength = 0;
         this.txtEntry.Name = "txtEntry";
         this.txtEntry.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtEntry.Size = new System.Drawing.Size(145, 19);
         this.txtEntry.TabIndex = 24;
         this.txtEntry.Leave += new System.EventHandler(this.txtEntry_Leave);
         // 
         // fgProducts
         // 
         this.fgProducts.AllowDrop = true;
         this.fgProducts.AllowUserToAddRows = false;
         this.fgProducts.AllowUserToDeleteRows = false;
         this.fgProducts.Properties().AllowUserToResizeColumns = false;
         this.fgProducts.Properties().AllowUserToResizeRows = false;
         this.fgProducts.Properties().BorderStyle = Mobilize.Web.BorderStyle.None;
         this.fgProducts.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.fgProducts.ColumnsCount = 0;
         this.fgProducts.FixedColumns = 0;
         this.fgProducts.FixedRows = 0;
         this.fgProducts.Location = new System.Drawing.Point(8, 360);
         this.fgProducts.Name = "fgProducts";
         this.fgProducts.Properties().ReadOnly = true;
         this.fgProducts.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.CellSelect;
         this.fgProducts.Properties().ShowCellToolTips = false;
         this.fgProducts.Size = new System.Drawing.Size(505, 177);
         this.fgProducts.Properties().StandardTab = true;
         this.fgProducts.TabIndex = 6;
         this.fgProducts.CellLeave += new Mobilize.Web.DataGridViewCellEventHandler(this.fgProducts_CellLeave);
         this.fgProducts.Click += new System.EventHandler(this.fgProducts_Click);
         this.fgProducts.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.fgProducts_KeyPress);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 678);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar.TabIndex = 23;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar_Panels_Panel1.Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // dtRequired
         // 
         this.dtRequired.AllowDrop = true;
         this.dtRequired.Checked = false;
         this.dtRequired.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtRequired.Location = new System.Drawing.Point(120, 320);
         this.dtRequired.Name = "dtRequired";
         this.dtRequired.Size = new System.Drawing.Size(97, 20);
         this.dtRequired.TabIndex = 4;
         this.dtRequired.ValueChanged += new System.EventHandler(this.dtRequired_ValueChanged);
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(320, 648);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(89, 25);
         this.cmdSave.TabIndex = 9;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // cmdAddProducts
         // 
         this.cmdAddProducts.AllowDrop = true;
         this.cmdAddProducts.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdAddProducts.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdAddProducts.Location = new System.Drawing.Point(488, 336);
         this.cmdAddProducts.Name = "cmdAddProducts";
         this.cmdAddProducts.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdAddProducts.Size = new System.Drawing.Size(25, 21);
         this.cmdAddProducts.TabIndex = 21;
         this.cmdAddProducts.TabStop = false;
         this.cmdAddProducts.Text = "...";
         this.cmdAddProducts.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdAddProducts.UseVisualStyleBackColor = false;
         this.cmdAddProducts.Click += new System.EventHandler(this.cmdAddProducts_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(416, 648);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 10;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.txtContactLastName);
         this.Frame1.Controls.Add(this.txtContactName);
         this.Frame1.Controls.Add(this.cmdCustomers);
         this.Frame1.Controls.Add(this.txtCompanyName);
         this.Frame1.Controls.Add(this.lvCustomers);
         this.Frame1.Controls.Add(this.Label3);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label2);
         this.Frame1.Enabled = true;
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 8);
         this.Frame1.Name = "Frame1";
         this.Frame1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(505, 249);
         this.Frame1.TabIndex = 12;
         this.Frame1.Text = "Search customer";
         this.Frame1.Visible = true;
         // 
         // txtContactLastName
         // 
         this.txtContactLastName.AcceptsReturn = true;
         this.txtContactLastName.AllowDrop = true;
         this.txtContactLastName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtContactLastName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtContactLastName.Properties().Cursor = null;
         this.txtContactLastName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactLastName.Location = new System.Drawing.Point(336, 48);
         this.txtContactLastName.MaxLength = 0;
         this.txtContactLastName.Name = "txtContactLastName";
         this.txtContactLastName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtContactLastName.Size = new System.Drawing.Size(145, 20);
         this.txtContactLastName.TabIndex = 2;
         this.txtContactLastName.TextChanged += new System.EventHandler(this.txtContactLastName_TextChanged);
         // 
         // txtContactName
         // 
         this.txtContactName.AcceptsReturn = true;
         this.txtContactName.AllowDrop = true;
         this.txtContactName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtContactName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtContactName.Properties().Cursor = null;
         this.txtContactName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactName.Location = new System.Drawing.Point(88, 48);
         this.txtContactName.MaxLength = 0;
         this.txtContactName.Name = "txtContactName";
         this.txtContactName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtContactName.Size = new System.Drawing.Size(145, 20);
         this.txtContactName.TabIndex = 1;
         this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
         // 
         // cmdCustomers
         // 
         this.cmdCustomers.AllowDrop = true;
         this.cmdCustomers.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCustomers.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCustomers.Location = new System.Drawing.Point(456, 16);
         this.cmdCustomers.Name = "cmdCustomers";
         this.cmdCustomers.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdCustomers.Size = new System.Drawing.Size(25, 21);
         this.cmdCustomers.TabIndex = 13;
         this.cmdCustomers.TabStop = false;
         this.cmdCustomers.Text = "...";
         this.cmdCustomers.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCustomers.UseVisualStyleBackColor = false;
         this.cmdCustomers.Click += new System.EventHandler(this.cmdCustomers_Click);
         // 
         // txtCompanyName
         // 
         this.txtCompanyName.AcceptsReturn = true;
         this.txtCompanyName.AllowDrop = true;
         this.txtCompanyName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtCompanyName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCompanyName.Properties().Cursor = null;
         this.txtCompanyName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCompanyName.Location = new System.Drawing.Point(88, 16);
         this.txtCompanyName.MaxLength = 0;
         this.txtCompanyName.Name = "txtCompanyName";
         this.txtCompanyName.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCompanyName.Size = new System.Drawing.Size(145, 20);
         this.txtCompanyName.TabIndex = 0;
         this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
         // 
         // lvCustomers
         // 
         this.lvCustomers.AllowDrop = true;
         this.lvCustomers.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvCustomers.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvCustomers.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvCustomers.FullRowSelect = true;
         this.lvCustomers.GridLines = true;
         this.lvCustomers.HideSelection = false;
         this.lvCustomers.Properties().HotTracking = true;
         this.lvCustomers.LabelEdit = false;
         this.lvCustomers.Location = new System.Drawing.Point(8, 80);
         this.lvCustomers.MultiSelect = false;
         this.lvCustomers.Name = "lvCustomers";
         this.lvCustomers.Size = new System.Drawing.Size(489, 161);
         this.lvCustomers.TabIndex = 3;
         this.lvCustomers.View = Mobilize.Web.ListViewMode.Details;
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_1_);
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_2_);
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_3_);
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_4_);
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_5_);
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_6_);
         this.lvCustomers.Columns.Add(this.lvCustomers_ColumnHeader_7_);
         // 
         // lvCustomers_ColumnHeader_1_
         // 
         this.lvCustomers_ColumnHeader_1_.Text = "Customer ID";
         this.lvCustomers_ColumnHeader_1_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_2_
         // 
         this.lvCustomers_ColumnHeader_2_.Text = "Company Name";
         this.lvCustomers_ColumnHeader_2_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_3_
         // 
         this.lvCustomers_ColumnHeader_3_.Text = "Contact Name";
         this.lvCustomers_ColumnHeader_3_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_4_
         // 
         this.lvCustomers_ColumnHeader_4_.Text = "Contact Last Name";
         this.lvCustomers_ColumnHeader_4_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_5_
         // 
         this.lvCustomers_ColumnHeader_5_.Text = "City";
         this.lvCustomers_ColumnHeader_5_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_6_
         // 
         this.lvCustomers_ColumnHeader_6_.Text = "State";
         this.lvCustomers_ColumnHeader_6_.Width = 97;
         // 
         // lvCustomers_ColumnHeader_7_
         // 
         this.lvCustomers_ColumnHeader_7_.Text = "Country";
         this.lvCustomers_ColumnHeader_7_.Width = 97;
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(240, 48);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(97, 17);
         this.Label3.TabIndex = 16;
         this.Label3.Text = "Contact last name:";
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(8, 16);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 15;
         this.Label4.Text = "Company name:";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(8, 48);
         this.Label2.Name = "Label2";
         this.Label2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(89, 17);
         this.Label2.TabIndex = 14;
         this.Label2.Text = "Contact name:";
         // 
         // Frame2
         // 
         this.Frame2.AllowDrop = true;
         this.Frame2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame2.Controls.Add(this.txtCustomerContact);
         this.Frame2.Controls.Add(this.txtCustomerCompany);
         this.Frame2.Controls.Add(this.Label5);
         this.Frame2.Controls.Add(this.Label1);
         this.Frame2.Enabled = true;
         this.Frame2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame2.Location = new System.Drawing.Point(8, 256);
         this.Frame2.Name = "Frame2";
         this.Frame2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame2.Size = new System.Drawing.Size(505, 49);
         this.Frame2.TabIndex = 11;
         this.Frame2.Text = "Customer";
         this.Frame2.Visible = true;
         // 
         // txtCustomerContact
         // 
         this.txtCustomerContact.AcceptsReturn = true;
         this.txtCustomerContact.AllowDrop = true;
         this.txtCustomerContact.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtCustomerContact.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCustomerContact.Properties().Cursor = null;
         this.txtCustomerContact.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCustomerContact.Location = new System.Drawing.Point(288, 16);
         this.txtCustomerContact.MaxLength = 0;
         this.txtCustomerContact.Name = "txtCustomerContact";
         this.txtCustomerContact.ReadOnly = true;
         this.txtCustomerContact.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCustomerContact.Size = new System.Drawing.Size(209, 20);
         this.txtCustomerContact.TabIndex = 20;
         this.txtCustomerContact.TabStop = false;
         // 
         // txtCustomerCompany
         // 
         this.txtCustomerCompany.AcceptsReturn = true;
         this.txtCustomerCompany.AllowDrop = true;
         this.txtCustomerCompany.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtCustomerCompany.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCustomerCompany.Properties().Cursor = null;
         this.txtCustomerCompany.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCustomerCompany.Location = new System.Drawing.Point(72, 16);
         this.txtCustomerCompany.MaxLength = 0;
         this.txtCustomerCompany.Name = "txtCustomerCompany";
         this.txtCustomerCompany.ReadOnly = true;
         this.txtCustomerCompany.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
         this.txtCustomerCompany.TabIndex = 19;
         this.txtCustomerCompany.TabStop = false;
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(8, 16);
         this.Label5.Name = "Label5";
         this.Label5.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(57, 17);
         this.Label5.TabIndex = 18;
         this.Label5.Text = "Company:";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(232, 16);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(57, 17);
         this.Label1.TabIndex = 17;
         this.Label1.Text = "Contact:";
         // 
         // dtPromised
         // 
         this.dtPromised.AllowDrop = true;
         this.dtPromised.Checked = false;
         this.dtPromised.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtPromised.Location = new System.Drawing.Point(352, 320);
         this.dtPromised.Name = "dtPromised";
         this.dtPromised.Size = new System.Drawing.Size(97, 20);
         this.dtPromised.TabIndex = 5;
         this.dtPromised.ValueChanged += new System.EventHandler(this.dtPromised_ValueChanged);
         // 
         // Label13
         // 
         this.Label13.AllowDrop = true;
         this.Label13.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label13.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label13.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label13.Location = new System.Drawing.Point(8, 544);
         this.Label13.Name = "Label13";
         this.Label13.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label13.Size = new System.Drawing.Size(89, 17);
         this.Label13.TabIndex = 33;
         this.Label13.Text = "Line quantity:";
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(8, 592);
         this.Label12.Name = "Label12";
         this.Label12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(89, 17);
         this.Label12.TabIndex = 32;
         this.Label12.Text = "Freight Charge:";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(8, 616);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 30;
         this.Label11.Text = "Total:";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(272, 592);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(89, 17);
         this.Label10.TabIndex = 28;
         this.Label10.Text = "Total Tax:";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(272, 616);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(89, 17);
         this.Label9.TabIndex = 26;
         this.Label9.Text = "Sub Total:";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(8, 568);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 25;
         this.Label8.Text = "Sales Tax:";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(256, 320);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(105, 17);
         this.Label7.TabIndex = 22;
         this.Label7.Text = "Promised by date:";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 320);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(105, 17);
         this.Label6.TabIndex = 34;
         this.Label6.Text = "Required by date:";
         // 
         // frmOrderRequest
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(523, 703);
         this.Controls.Add(this.txtSubTotal);
         this.Controls.Add(this.txtTotal);
         this.Controls.Add(this.txtTotalTax);
         this.Controls.Add(this.txtFreightCharge);
         this.Controls.Add(this.txtSalesTax);
         this.Controls.Add(this.txtEntry);
         this.Controls.Add(this.fgProducts);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.dtRequired);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.cmdAddProducts);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.Frame2);
         this.Controls.Add(this.dtPromised);
         this.Controls.Add(this.Label13);
         this.Controls.Add(this.Label12);
         this.Controls.Add(this.Label11);
         this.Controls.Add(this.Label10);
         this.Controls.Add(this.Label9);
         this.Controls.Add(this.Label8);
         this.Controls.Add(this.Label7);
         this.Controls.Add(this.Label6);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmOrderRequest";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Create Order";
         this.Activated += new System.EventHandler(this.frmOrderRequest_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);this.lvCustomers.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvCustomers_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvCustomers, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvCustomers.ResumeLayout(false);
         this.Frame2.ResumeLayout(false);
         this.ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
      	//This form is an MDI child.
      	//This code simulates the VB6 
      	// functionality of automatically
      	// loading and showing an MDI
      	// child's parent.
      	this.MdiParent = SKS.frmMain.DefInstance;
      	SKS.frmMain.DefInstance.Show();
      }
      #endregion
   }
}