
namespace SKS
{
	partial class frmOrderRequest
	{

		#region "Upgrade Support "
		private static frmOrderRequest m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
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
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "dtRequired", "cmdSave", "cmdAddProducts", "cmdClose", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "lvCustomers_ColumnHeader_1_", "lvCustomers_ColumnHeader_2_", "lvCustomers_ColumnHeader_3_", "lvCustomers_ColumnHeader_4_", "lvCustomers_ColumnHeader_5_", "lvCustomers_ColumnHeader_6_", "lvCustomers_ColumnHeader_7_", "lvCustomers", "Label3", "Label4", "Label2", "Frame1", "txtCustomerContact", "txtCustomerCompany", "Label5", "Label1", "Frame2", "dtPromised", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label7", "Label6", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtSubTotal;
		public System.Windows.Forms.TextBox txtTotal;
		public System.Windows.Forms.TextBox txtTotalTax;
		public System.Windows.Forms.TextBox txtFreightCharge;
		public System.Windows.Forms.TextBox txtSalesTax;
		public System.Windows.Forms.TextBox txtEntry;
		public UpgradeHelpers.DataGridViewFlex fgProducts;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.DateTimePicker dtRequired;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.Button cmdAddProducts;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.TextBox txtContactLastName;
		public System.Windows.Forms.TextBox txtContactName;
		public System.Windows.Forms.Button cmdCustomers;
		public System.Windows.Forms.TextBox txtCompanyName;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvCustomers_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvCustomers;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.TextBox txtCustomerContact;
		public System.Windows.Forms.TextBox txtCustomerCompany;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.DateTimePicker dtPromised;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label6;
		public UpgradeHelpers.Gui.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderRequest));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtTotalTax = new System.Windows.Forms.TextBox();
			this.txtFreightCharge = new System.Windows.Forms.TextBox();
			this.txtSalesTax = new System.Windows.Forms.TextBox();
			this.txtEntry = new System.Windows.Forms.TextBox();
			this.fgProducts = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.sbStatusBar = new System.Windows.Forms.StatusStrip();
			this.sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.dtRequired = new System.Windows.Forms.DateTimePicker();
			this.cmdSave = new System.Windows.Forms.Button();
			this.cmdAddProducts = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.txtContactLastName = new System.Windows.Forms.TextBox();
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.cmdCustomers = new System.Windows.Forms.Button();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.lvCustomers = new System.Windows.Forms.ListView();
			this.lvCustomers_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lvCustomers_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lvCustomers_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.lvCustomers_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			this.lvCustomers_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			this.lvCustomers_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			this.lvCustomers_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.txtCustomerContact = new System.Windows.Forms.TextBox();
			this.txtCustomerCompany = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.dtPromised = new System.Windows.Forms.DateTimePicker();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.sbStatusBar.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.lvCustomers.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.fgProducts).BeginInit();
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.AcceptsReturn = true;
			this.txtSubTotal.AllowDrop = true;
			this.txtSubTotal.BackColor = System.Drawing.SystemColors.Menu;
			this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSubTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSubTotal.Location = new System.Drawing.Point(352, 616);
			this.txtSubTotal.MaxLength = 0;
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.ReadOnly = true;
			this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSubTotal.Size = new System.Drawing.Size(145, 20);
			this.txtSubTotal.TabIndex = 31;
			this.txtSubTotal.TabStop = false;
			this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotal
			// 
			this.txtTotal.AcceptsReturn = true;
			this.txtTotal.AllowDrop = true;
			this.txtTotal.BackColor = System.Drawing.SystemColors.Menu;
			this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTotal.Location = new System.Drawing.Point(96, 616);
			this.txtTotal.MaxLength = 0;
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTotal.Size = new System.Drawing.Size(145, 20);
			this.txtTotal.TabIndex = 29;
			this.txtTotal.TabStop = false;
			this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalTax
			// 
			this.txtTotalTax.AcceptsReturn = true;
			this.txtTotalTax.AllowDrop = true;
			this.txtTotalTax.BackColor = System.Drawing.SystemColors.Menu;
			this.txtTotalTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtTotalTax.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtTotalTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotalTax.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTotalTax.Location = new System.Drawing.Point(352, 592);
			this.txtTotalTax.MaxLength = 0;
			this.txtTotalTax.Name = "txtTotalTax";
			this.txtTotalTax.ReadOnly = true;
			this.txtTotalTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTotalTax.Size = new System.Drawing.Size(145, 20);
			this.txtTotalTax.TabIndex = 27;
			this.txtTotalTax.TabStop = false;
			this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtFreightCharge
			// 
			this.txtFreightCharge.AcceptsReturn = true;
			this.txtFreightCharge.AllowDrop = true;
			this.txtFreightCharge.BackColor = System.Drawing.SystemColors.Window;
			this.txtFreightCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtFreightCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFreightCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFreightCharge.Location = new System.Drawing.Point(96, 592);
			this.txtFreightCharge.MaxLength = 0;
			this.txtFreightCharge.Name = "txtFreightCharge";
			this.txtFreightCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
			this.txtFreightCharge.TabIndex = 8;
			this.txtFreightCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtFreightCharge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreightCharge_KeyPress);
			this.txtFreightCharge.TextChanged += new System.EventHandler(this.txtFreightCharge_TextChanged);
			// 
			// txtSalesTax
			// 
			this.txtSalesTax.AcceptsReturn = true;
			this.txtSalesTax.AllowDrop = true;
			this.txtSalesTax.BackColor = System.Drawing.SystemColors.Window;
			this.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSalesTax.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSalesTax.Location = new System.Drawing.Point(96, 568);
			this.txtSalesTax.MaxLength = 0;
			this.txtSalesTax.Name = "txtSalesTax";
			this.txtSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
			this.txtSalesTax.TabIndex = 7;
			this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtSalesTax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesTax_KeyPress);
			this.txtSalesTax.TextChanged += new System.EventHandler(this.txtSalesTax_TextChanged);
			// 
			// txtEntry
			// 
			this.txtEntry.AcceptsReturn = true;
			this.txtEntry.AllowDrop = true;
			this.txtEntry.BackColor = System.Drawing.SystemColors.Window;
			this.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEntry.Enabled = false;
			this.txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtEntry.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEntry.Location = new System.Drawing.Point(96, 544);
			this.txtEntry.MaxLength = 0;
			this.txtEntry.Name = "txtEntry";
			this.txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtEntry.Size = new System.Drawing.Size(145, 19);
			this.txtEntry.TabIndex = 24;
			this.txtEntry.Leave += new System.EventHandler(this.txtEntry_Leave);
			// 
			// fgProducts
			// 
			this.fgProducts.AllowDrop = true;
			this.fgProducts.AllowUserToAddRows = false;
			this.fgProducts.AllowUserToDeleteRows = false;
			this.fgProducts.AllowUserToResizeColumns = false;
			this.fgProducts.AllowUserToResizeRows = false;
			this.fgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.fgProducts.ColumnsCount = 0;
			this.fgProducts.FixedColumns = 0;
			this.fgProducts.FixedRows = 0;
			this.fgProducts.Location = new System.Drawing.Point(8, 360);
			this.fgProducts.Name = "fgProducts";
			this.fgProducts.ReadOnly = true;
			this.fgProducts.RowsCount = 2;
			this.fgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.fgProducts.ShowCellToolTips = false;
			this.fgProducts.Size = new System.Drawing.Size(505, 177);
			this.fgProducts.StandardTab = true;
			this.fgProducts.TabIndex = 6;
			this.fgProducts.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.fgProducts_CellLeave);
			this.fgProducts.Click += new System.EventHandler(this.fgProducts_Click);
			this.fgProducts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fgProducts_KeyPress);
			// 
			// sbStatusBar
			// 
			this.sbStatusBar.AllowDrop = true;
			this.sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.sbStatusBar.Location = new System.Drawing.Point(0, 678);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.ShowItemToolTips = true;
			this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
			this.sbStatusBar.TabIndex = 23;
			this.sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			this.sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			this.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			this.sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(523, 25);
			this.sbStatusBar_Panels_Panel1.Spring = true;
			this.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// dtRequired
			// 
			this.dtRequired.AllowDrop = true;
			this.dtRequired.Checked = false;
			this.dtRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtRequired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtRequired.Location = new System.Drawing.Point(120, 320);
			this.dtRequired.Name = "dtRequired";
			this.dtRequired.Size = new System.Drawing.Size(97, 20);
			this.dtRequired.TabIndex = 4;
			this.dtRequired.ValueChanged += new System.EventHandler(this.dtRequired_ValueChanged);
			// 
			// cmdSave
			// 
			this.cmdSave.AllowDrop = true;
			this.cmdSave.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSave.Location = new System.Drawing.Point(320, 648);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSave.Size = new System.Drawing.Size(89, 25);
			this.cmdSave.TabIndex = 9;
			this.cmdSave.Text = "&Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// cmdAddProducts
			// 
			this.cmdAddProducts.AllowDrop = true;
			this.cmdAddProducts.BackColor = System.Drawing.SystemColors.Control;
			this.cmdAddProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdAddProducts.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdAddProducts.Location = new System.Drawing.Point(488, 336);
			this.cmdAddProducts.Name = "cmdAddProducts";
			this.cmdAddProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdAddProducts.Size = new System.Drawing.Size(25, 21);
			this.cmdAddProducts.TabIndex = 21;
			this.cmdAddProducts.TabStop = false;
			this.cmdAddProducts.Text = "...";
			this.cmdAddProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdAddProducts.UseVisualStyleBackColor = false;
			this.cmdAddProducts.Click += new System.EventHandler(this.cmdAddProducts_Click);
			// 
			// cmdClose
			// 
			this.cmdClose.AllowDrop = true;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Location = new System.Drawing.Point(416, 648);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(89, 25);
			this.cmdClose.TabIndex = 10;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.txtContactLastName);
			this.Frame1.Controls.Add(this.txtContactName);
			this.Frame1.Controls.Add(this.cmdCustomers);
			this.Frame1.Controls.Add(this.txtCompanyName);
			this.Frame1.Controls.Add(this.lvCustomers);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 8);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(505, 249);
			this.Frame1.TabIndex = 12;
			this.Frame1.Text = "Search customer";
			this.Frame1.Visible = true;
			// 
			// txtContactLastName
			// 
			this.txtContactLastName.AcceptsReturn = true;
			this.txtContactLastName.AllowDrop = true;
			this.txtContactLastName.BackColor = System.Drawing.SystemColors.Window;
			this.txtContactLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtContactLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtContactLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtContactLastName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtContactLastName.Location = new System.Drawing.Point(336, 48);
			this.txtContactLastName.MaxLength = 0;
			this.txtContactLastName.Name = "txtContactLastName";
			this.txtContactLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtContactLastName.Size = new System.Drawing.Size(145, 20);
			this.txtContactLastName.TabIndex = 2;
			this.txtContactLastName.TextChanged += new System.EventHandler(this.txtContactLastName_TextChanged);
			// 
			// txtContactName
			// 
			this.txtContactName.AcceptsReturn = true;
			this.txtContactName.AllowDrop = true;
			this.txtContactName.BackColor = System.Drawing.SystemColors.Window;
			this.txtContactName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtContactName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtContactName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtContactName.Location = new System.Drawing.Point(88, 48);
			this.txtContactName.MaxLength = 0;
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtContactName.Size = new System.Drawing.Size(145, 20);
			this.txtContactName.TabIndex = 1;
			this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
			// 
			// cmdCustomers
			// 
			this.cmdCustomers.AllowDrop = true;
			this.cmdCustomers.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCustomers.Location = new System.Drawing.Point(456, 16);
			this.cmdCustomers.Name = "cmdCustomers";
			this.cmdCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCustomers.Size = new System.Drawing.Size(25, 21);
			this.cmdCustomers.TabIndex = 13;
			this.cmdCustomers.TabStop = false;
			this.cmdCustomers.Text = "...";
			this.cmdCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCustomers.UseVisualStyleBackColor = false;
			this.cmdCustomers.Click += new System.EventHandler(this.cmdCustomers_Click);
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.AcceptsReturn = true;
			this.txtCompanyName.AllowDrop = true;
			this.txtCompanyName.BackColor = System.Drawing.SystemColors.Window;
			this.txtCompanyName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCompanyName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCompanyName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCompanyName.Location = new System.Drawing.Point(88, 16);
			this.txtCompanyName.MaxLength = 0;
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCompanyName.Size = new System.Drawing.Size(145, 20);
			this.txtCompanyName.TabIndex = 0;
			this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
			// 
			// lvCustomers
			// 
			this.lvCustomers.AllowDrop = true;
			this.lvCustomers.BackColor = System.Drawing.SystemColors.Window;
			this.lvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lvCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lvCustomers.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lvCustomers.FullRowSelect = true;
			this.lvCustomers.GridLines = true;
			this.lvCustomers.HideSelection = false;
			this.lvCustomers.HotTracking = true;
			this.lvCustomers.LabelEdit = false;
			this.lvCustomers.Location = new System.Drawing.Point(8, 80);
			this.lvCustomers.MultiSelect = false;
			this.lvCustomers.Name = "lvCustomers";
			this.lvCustomers.Size = new System.Drawing.Size(489, 161);
			this.lvCustomers.TabIndex = 3;
			this.lvCustomers.View = System.Windows.Forms.View.Details;
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
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(240, 48);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(97, 17);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Contact last name:";
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(8, 16);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 15;
			this.Label4.Text = "Company name:";
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 48);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(89, 17);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Contact name:";
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.txtCustomerContact);
			this.Frame2.Controls.Add(this.txtCustomerCompany);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Enabled = true;
			this.Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(8, 256);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(505, 49);
			this.Frame2.TabIndex = 11;
			this.Frame2.Text = "Customer";
			this.Frame2.Visible = true;
			// 
			// txtCustomerContact
			// 
			this.txtCustomerContact.AcceptsReturn = true;
			this.txtCustomerContact.AllowDrop = true;
			this.txtCustomerContact.BackColor = System.Drawing.SystemColors.Menu;
			this.txtCustomerContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCustomerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCustomerContact.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCustomerContact.Location = new System.Drawing.Point(288, 16);
			this.txtCustomerContact.MaxLength = 0;
			this.txtCustomerContact.Name = "txtCustomerContact";
			this.txtCustomerContact.ReadOnly = true;
			this.txtCustomerContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCustomerContact.Size = new System.Drawing.Size(209, 20);
			this.txtCustomerContact.TabIndex = 20;
			this.txtCustomerContact.TabStop = false;
			// 
			// txtCustomerCompany
			// 
			this.txtCustomerCompany.AcceptsReturn = true;
			this.txtCustomerCompany.AllowDrop = true;
			this.txtCustomerCompany.BackColor = System.Drawing.SystemColors.Menu;
			this.txtCustomerCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCustomerCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCustomerCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCustomerCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCustomerCompany.Location = new System.Drawing.Point(72, 16);
			this.txtCustomerCompany.MaxLength = 0;
			this.txtCustomerCompany.Name = "txtCustomerCompany";
			this.txtCustomerCompany.ReadOnly = true;
			this.txtCustomerCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCustomerCompany.Size = new System.Drawing.Size(145, 20);
			this.txtCustomerCompany.TabIndex = 19;
			this.txtCustomerCompany.TabStop = false;
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(8, 16);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(57, 17);
			this.Label5.TabIndex = 18;
			this.Label5.Text = "Company:";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(232, 16);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(57, 17);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Contact:";
			// 
			// dtPromised
			// 
			this.dtPromised.AllowDrop = true;
			this.dtPromised.Checked = false;
			this.dtPromised.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtPromised.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtPromised.Location = new System.Drawing.Point(352, 320);
			this.dtPromised.Name = "dtPromised";
			this.dtPromised.Size = new System.Drawing.Size(97, 20);
			this.dtPromised.TabIndex = 5;
			this.dtPromised.ValueChanged += new System.EventHandler(this.dtPromised_ValueChanged);
			// 
			// Label13
			// 
			this.Label13.AllowDrop = true;
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(8, 544);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(89, 17);
			this.Label13.TabIndex = 33;
			this.Label13.Text = "Line quantity:";
			// 
			// Label12
			// 
			this.Label12.AllowDrop = true;
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(8, 592);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(89, 17);
			this.Label12.TabIndex = 32;
			this.Label12.Text = "Freight Charge:";
			// 
			// Label11
			// 
			this.Label11.AllowDrop = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(8, 616);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(89, 17);
			this.Label11.TabIndex = 30;
			this.Label11.Text = "Total:";
			// 
			// Label10
			// 
			this.Label10.AllowDrop = true;
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(272, 592);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(89, 17);
			this.Label10.TabIndex = 28;
			this.Label10.Text = "Total Tax:";
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(272, 616);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(89, 17);
			this.Label9.TabIndex = 26;
			this.Label9.Text = "Sub Total:";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 568);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(89, 17);
			this.Label8.TabIndex = 25;
			this.Label8.Text = "Sales Tax:";
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(256, 320);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(105, 17);
			this.Label7.TabIndex = 22;
			this.Label7.Text = "Promised by date:";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 320);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(105, 17);
			this.Label6.TabIndex = 34;
			this.Label6.Text = "Required by date:";
			// 
			// frmOrderRequest
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
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
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 25);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmOrderRequest";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Create Order";
			this.Activated += new System.EventHandler(this.frmOrderRequest_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
			((System.ComponentModel.ISupportInitialize) this.fgProducts).EndInit();
			this.listViewHelper1.SetItemClickMethod(this.lvCustomers, "lvCustomers_ItemClick");
			this.listViewHelper1.SetCorrectEventsBehavior(this.lvCustomers, true);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
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