
namespace SKS
{
	partial class frmRequestApproval
	{

		#region "Upgrade Support "
		private static frmRequestApproval m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmRequestApproval DefInstance
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
		public static frmRequestApproval CreateInstance()
		{
			frmRequestApproval theInstance = new frmRequestApproval();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdApprove", "cmdInfo", "fgOrders", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "cmbStatus", "chkTo", "chkFrom", "txtProductID", "txtOrderID", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "dtFrom", "dtTo", "Label5", "Label8", "Label1", "Label6", "Label3", "Label4", "Label2", "Frame1", "listBoxComboBoxHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdApprove;
		public System.Windows.Forms.Button cmdInfo;
		public UpgradeHelpers.DataGridViewFlex fgOrders;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.Button cmdCancel;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.ComboBox cmbStatus;
		public System.Windows.Forms.CheckBox chkTo;
		public System.Windows.Forms.CheckBox chkFrom;
		public System.Windows.Forms.TextBox txtProductID;
		public System.Windows.Forms.TextBox txtOrderID;
		public System.Windows.Forms.TextBox txtContactLastName;
		public System.Windows.Forms.TextBox txtContactName;
		public System.Windows.Forms.Button cmdCustomers;
		public System.Windows.Forms.TextBox txtCompanyName;
		public System.Windows.Forms.DateTimePicker dtFrom;
		public System.Windows.Forms.DateTimePicker dtTo;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame1;
		public UpgradeHelpers.Gui.ListControlHelper listBoxComboBoxHelper1;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestApproval));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cmdApprove = new System.Windows.Forms.Button();
			this.cmdInfo = new System.Windows.Forms.Button();
			this.fgOrders = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.sbStatusBar = new System.Windows.Forms.StatusStrip();
			this.sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.chkTo = new System.Windows.Forms.CheckBox();
			this.chkFrom = new System.Windows.Forms.CheckBox();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.txtContactLastName = new System.Windows.Forms.TextBox();
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.cmdCustomers = new System.Windows.Forms.Button();
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.dtFrom = new System.Windows.Forms.DateTimePicker();
			this.dtTo = new System.Windows.Forms.DateTimePicker();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.sbStatusBar.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			this.listBoxComboBoxHelper1 = new UpgradeHelpers.Gui.ListControlHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.fgOrders).BeginInit();
			// 
			// cmdApprove
			// 
			this.cmdApprove.AllowDrop = true;
			this.cmdApprove.BackColor = System.Drawing.SystemColors.Control;
			this.cmdApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdApprove.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdApprove.Location = new System.Drawing.Point(232, 440);
			this.cmdApprove.Name = "cmdApprove";
			this.cmdApprove.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdApprove.Size = new System.Drawing.Size(89, 25);
			this.cmdApprove.TabIndex = 10;
			this.cmdApprove.Text = "&Create";
			this.cmdApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdApprove.UseVisualStyleBackColor = false;
			this.cmdApprove.Click += new System.EventHandler(this.cmdApprove_Click);
			// 
			// cmdInfo
			// 
			this.cmdInfo.AllowDrop = true;
			this.cmdInfo.BackColor = System.Drawing.SystemColors.Control;
			this.cmdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdInfo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdInfo.Location = new System.Drawing.Point(136, 440);
			this.cmdInfo.Name = "cmdInfo";
			this.cmdInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdInfo.Size = new System.Drawing.Size(89, 25);
			this.cmdInfo.TabIndex = 9;
			this.cmdInfo.Text = "&Info";
			this.cmdInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdInfo.UseVisualStyleBackColor = false;
			this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
			// 
			// fgOrders
			// 
			this.fgOrders.AllowBigSelection = false;
			this.fgOrders.AllowDrop = true;
			this.fgOrders.AllowUserToAddRows = false;
			this.fgOrders.AllowUserToDeleteRows = false;
			this.fgOrders.AllowUserToResizeColumns = false;
			this.fgOrders.AllowUserToResizeRows = false;
			this.fgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.fgOrders.ColumnsCount = 1;
			this.fgOrders.FixedColumns = 0;
			this.fgOrders.FixedRows = 0;
			this.fgOrders.Location = new System.Drawing.Point(8, 168);
			this.fgOrders.Name = "fgOrders";
			this.fgOrders.ReadOnly = true;
			this.fgOrders.RowsCount = 1;
			this.fgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.fgOrders.ShowCellToolTips = false;
			this.fgOrders.Size = new System.Drawing.Size(505, 265);
			this.fgOrders.StandardTab = true;
			this.fgOrders.TabIndex = 8;
			this.fgOrders.DoubleClick += new System.EventHandler(this.fgOrders_DoubleClick);
			// 
			// sbStatusBar
			// 
			this.sbStatusBar.AllowDrop = true;
			this.sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.sbStatusBar.Location = new System.Drawing.Point(0, 471);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.ShowItemToolTips = true;
			this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
			this.sbStatusBar.TabIndex = 18;
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
			// cmdCancel
			// 
			this.cmdCancel.AllowDrop = true;
			this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCancel.Location = new System.Drawing.Point(328, 440);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCancel.Size = new System.Drawing.Size(89, 25);
			this.cmdCancel.TabIndex = 11;
			this.cmdCancel.Text = "&Cancel";
			this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdCancel.UseVisualStyleBackColor = false;
			this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
			// 
			// cmdClose
			// 
			this.cmdClose.AllowDrop = true;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Location = new System.Drawing.Point(424, 440);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(89, 25);
			this.cmdClose.TabIndex = 12;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.cmbStatus);
			this.Frame1.Controls.Add(this.chkTo);
			this.Frame1.Controls.Add(this.chkFrom);
			this.Frame1.Controls.Add(this.txtProductID);
			this.Frame1.Controls.Add(this.txtOrderID);
			this.Frame1.Controls.Add(this.txtContactLastName);
			this.Frame1.Controls.Add(this.txtContactName);
			this.Frame1.Controls.Add(this.cmdCustomers);
			this.Frame1.Controls.Add(this.txtCompanyName);
			this.Frame1.Controls.Add(this.dtFrom);
			this.Frame1.Controls.Add(this.dtTo);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.Label8);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 8);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(505, 153);
			this.Frame1.TabIndex = 13;
			this.Frame1.Text = "Search customer";
			this.Frame1.Visible = true;
			// 
			// cmbStatus
			// 
			this.cmbStatus.AllowDrop = true;
			this.cmbStatus.BackColor = System.Drawing.SystemColors.Window;
			this.cmbStatus.CausesValidation = true;
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.Enabled = true;
			this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbStatus.IntegralHeight = true;
			this.cmbStatus.Location = new System.Drawing.Point(336, 16);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbStatus.Size = new System.Drawing.Size(145, 21);
			this.cmbStatus.Sorted = false;
			this.cmbStatus.TabIndex = 1;
			this.cmbStatus.TabStop = true;
			this.cmbStatus.Visible = true;
			this.cmbStatus.Items.AddRange(new object[]{"All", "Requested", "Cancelled", "Approved"});
			this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
			// 
			// chkTo
			// 
			this.chkTo.AllowDrop = true;
			this.chkTo.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkTo.BackColor = System.Drawing.SystemColors.Control;
			this.chkTo.CausesValidation = true;
			this.chkTo.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkTo.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkTo.Enabled = true;
			this.chkTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkTo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkTo.Location = new System.Drawing.Point(336, 80);
			this.chkTo.Name = "chkTo";
			this.chkTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkTo.Size = new System.Drawing.Size(41, 17);
			this.chkTo.TabIndex = 23;
			this.chkTo.TabStop = false;
			this.chkTo.Text = "To:";
			this.chkTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkTo.Visible = true;
			// 
			// chkFrom
			// 
			this.chkFrom.AllowDrop = true;
			this.chkFrom.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkFrom.BackColor = System.Drawing.SystemColors.Control;
			this.chkFrom.CausesValidation = true;
			this.chkFrom.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkFrom.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkFrom.Enabled = true;
			this.chkFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkFrom.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkFrom.Location = new System.Drawing.Point(88, 80);
			this.chkFrom.Name = "chkFrom";
			this.chkFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkFrom.Size = new System.Drawing.Size(47, 17);
			this.chkFrom.TabIndex = 22;
			this.chkFrom.TabStop = false;
			this.chkFrom.Text = "From:";
			this.chkFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkFrom.Visible = true;
			// 
			// txtProductID
			// 
			this.txtProductID.AcceptsReturn = true;
			this.txtProductID.AllowDrop = true;
			this.txtProductID.BackColor = System.Drawing.SystemColors.Window;
			this.txtProductID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtProductID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtProductID.Location = new System.Drawing.Point(336, 112);
			this.txtProductID.MaxLength = 0;
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtProductID.Size = new System.Drawing.Size(145, 20);
			this.txtProductID.TabIndex = 7;
			this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
			// 
			// txtOrderID
			// 
			this.txtOrderID.AcceptsReturn = true;
			this.txtOrderID.AllowDrop = true;
			this.txtOrderID.BackColor = System.Drawing.SystemColors.Window;
			this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOrderID.Location = new System.Drawing.Point(88, 112);
			this.txtOrderID.MaxLength = 0;
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtOrderID.Size = new System.Drawing.Size(145, 20);
			this.txtOrderID.TabIndex = 6;
			this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
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
			this.txtContactLastName.TabIndex = 3;
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
			this.txtContactName.TabIndex = 2;
			this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
			// 
			// cmdCustomers
			// 
			this.cmdCustomers.AllowDrop = true;
			this.cmdCustomers.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCustomers.Location = new System.Drawing.Point(240, 16);
			this.cmdCustomers.Name = "cmdCustomers";
			this.cmdCustomers.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCustomers.Size = new System.Drawing.Size(25, 21);
			this.cmdCustomers.TabIndex = 14;
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
			// dtFrom
			// 
			this.dtFrom.AllowDrop = true;
			this.dtFrom.Checked = false;
			this.dtFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtFrom.Location = new System.Drawing.Point(136, 80);
			this.dtFrom.Name = "dtFrom";
			this.dtFrom.Size = new System.Drawing.Size(97, 20);
			this.dtFrom.TabIndex = 4;
			this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
			// 
			// dtTo
			// 
			this.dtTo.AllowDrop = true;
			this.dtTo.Checked = false;
			this.dtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtTo.Location = new System.Drawing.Point(384, 80);
			this.dtTo.Name = "dtTo";
			this.dtTo.Size = new System.Drawing.Size(97, 20);
			this.dtTo.TabIndex = 5;
			this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(288, 16);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(41, 17);
			this.Label5.TabIndex = 24;
			this.Label5.Text = "Status";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(256, 112);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(73, 17);
			this.Label8.TabIndex = 21;
			this.Label8.Text = "Product";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 112);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "Order";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 80);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(65, 17);
			this.Label6.TabIndex = 19;
			this.Label6.Text = "Date range:";
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(256, 48);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(65, 17);
			this.Label3.TabIndex = 17;
			this.Label3.Text = "Last Name";
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
			this.Label4.TabIndex = 16;
			this.Label4.Text = "Company";
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
			this.Label2.TabIndex = 15;
			this.Label2.Text = "First Name";
			// 
			// frmRequestApproval
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(523, 496);
			this.Controls.Add(this.cmdApprove);
			this.Controls.Add(this.cmdInfo);
			this.Controls.Add(this.fgOrders);
			this.Controls.Add(this.sbStatusBar);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.Frame1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 25);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRequestApproval";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Create Invoice";
			this.listBoxComboBoxHelper1.SetItemData(this.cmbStatus, new int[]{0, 0, 0, 0});
			this.Activated += new System.EventHandler(this.frmRequestApproval_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.fgOrders).EndInit();
			((System.ComponentModel.ISupportInitialize) this.listBoxComboBoxHelper1).EndInit();
			this.sbStatusBar.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
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