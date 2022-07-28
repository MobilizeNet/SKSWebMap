
namespace SKS
{
	partial class frmActionOrderReception
	{

		#region "Upgrade Support "
		private static frmActionOrderReception m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmActionOrderReception DefInstance
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
		public static frmActionOrderReception CreateInstance()
		{
			frmActionOrderReception theInstance = new frmActionOrderReception();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "txtReceivedBy", "cmdApprove", "txtStatus", "txtReceived", "txtChangedBy", "txtChanged", "txtOrderID", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgDetails", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label3", "Label19", "lblChangedBy", "Label4", "lblChanged", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.TextBox txtReceivedBy;
		public System.Windows.Forms.Button cmdApprove;
		public System.Windows.Forms.TextBox txtStatus;
		public System.Windows.Forms.TextBox txtReceived;
		public System.Windows.Forms.TextBox txtChangedBy;
		public System.Windows.Forms.TextBox txtChanged;
		public System.Windows.Forms.TextBox txtOrderID;
		public System.Windows.Forms.TextBox txtNotes;
		public System.Windows.Forms.TextBox txtSubTotal;
		public System.Windows.Forms.TextBox txtTotal;
		public System.Windows.Forms.TextBox txtTotalTax;
		public System.Windows.Forms.TextBox txtFreightCharge;
		public System.Windows.Forms.TextBox txtSalesTax;
		public System.Windows.Forms.TextBox txtEntry;
		public UpgradeHelpers.DataGridViewFlex fgDetails;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.Button cmdCancel;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.TextBox txtProviderContact;
		public System.Windows.Forms.TextBox txtProviderCompany;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label19;
		public System.Windows.Forms.Label lblChangedBy;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label lblChanged;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label6;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionOrderReception));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.txtReceivedBy = new System.Windows.Forms.TextBox();
			this.cmdApprove = new System.Windows.Forms.Button();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.txtReceived = new System.Windows.Forms.TextBox();
			this.txtChangedBy = new System.Windows.Forms.TextBox();
			this.txtChanged = new System.Windows.Forms.TextBox();
			this.txtOrderID = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.txtTotalTax = new System.Windows.Forms.TextBox();
			this.txtFreightCharge = new System.Windows.Forms.TextBox();
			this.txtSalesTax = new System.Windows.Forms.TextBox();
			this.txtEntry = new System.Windows.Forms.TextBox();
			this.fgDetails = new UpgradeHelpers.DataGridViewFlex(this.components);
			this.sbStatusBar = new System.Windows.Forms.StatusStrip();
			this.sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdClose = new System.Windows.Forms.Button();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.txtProviderContact = new System.Windows.Forms.TextBox();
			this.txtProviderCompany = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.lblChangedBy = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.lblChanged = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.sbStatusBar.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.fgDetails).BeginInit();
			// 
			// txtReceivedBy
			// 
			this.txtReceivedBy.AcceptsReturn = true;
			this.txtReceivedBy.AllowDrop = true;
			this.txtReceivedBy.BackColor = System.Drawing.SystemColors.Menu;
			this.txtReceivedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtReceivedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtReceivedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtReceivedBy.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtReceivedBy.Location = new System.Drawing.Point(96, 64);
			this.txtReceivedBy.MaxLength = 0;
			this.txtReceivedBy.Name = "txtReceivedBy";
			this.txtReceivedBy.ReadOnly = true;
			this.txtReceivedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtReceivedBy.Size = new System.Drawing.Size(105, 20);
			this.txtReceivedBy.TabIndex = 33;
			// 
			// cmdApprove
			// 
			this.cmdApprove.AllowDrop = true;
			this.cmdApprove.BackColor = System.Drawing.SystemColors.Control;
			this.cmdApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdApprove.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdApprove.Location = new System.Drawing.Point(232, 456);
			this.cmdApprove.Name = "cmdApprove";
			this.cmdApprove.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdApprove.Size = new System.Drawing.Size(89, 25);
			this.cmdApprove.TabIndex = 0;
			this.cmdApprove.Text = "&Add";
			this.cmdApprove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdApprove.UseVisualStyleBackColor = false;
			this.cmdApprove.Click += new System.EventHandler(this.cmdApprove_Click);
			// 
			// txtStatus
			// 
			this.txtStatus.AcceptsReturn = true;
			this.txtStatus.AllowDrop = true;
			this.txtStatus.BackColor = System.Drawing.SystemColors.Menu;
			this.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtStatus.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtStatus.Location = new System.Drawing.Point(408, 8);
			this.txtStatus.MaxLength = 0;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ReadOnly = true;
			this.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtStatus.Size = new System.Drawing.Size(105, 20);
			this.txtStatus.TabIndex = 31;
			// 
			// txtReceived
			// 
			this.txtReceived.AcceptsReturn = true;
			this.txtReceived.AllowDrop = true;
			this.txtReceived.BackColor = System.Drawing.SystemColors.Menu;
			this.txtReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtReceived.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtReceived.Location = new System.Drawing.Point(96, 36);
			this.txtReceived.MaxLength = 0;
			this.txtReceived.Name = "txtReceived";
			this.txtReceived.ReadOnly = true;
			this.txtReceived.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtReceived.Size = new System.Drawing.Size(105, 20);
			this.txtReceived.TabIndex = 29;
			// 
			// txtChangedBy
			// 
			this.txtChangedBy.AcceptsReturn = true;
			this.txtChangedBy.AllowDrop = true;
			this.txtChangedBy.BackColor = System.Drawing.SystemColors.Menu;
			this.txtChangedBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtChangedBy.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtChangedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtChangedBy.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtChangedBy.Location = new System.Drawing.Point(408, 64);
			this.txtChangedBy.MaxLength = 0;
			this.txtChangedBy.Name = "txtChangedBy";
			this.txtChangedBy.ReadOnly = true;
			this.txtChangedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtChangedBy.Size = new System.Drawing.Size(105, 20);
			this.txtChangedBy.TabIndex = 25;
			// 
			// txtChanged
			// 
			this.txtChanged.AcceptsReturn = true;
			this.txtChanged.AllowDrop = true;
			this.txtChanged.BackColor = System.Drawing.SystemColors.Menu;
			this.txtChanged.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtChanged.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtChanged.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtChanged.Location = new System.Drawing.Point(408, 36);
			this.txtChanged.MaxLength = 0;
			this.txtChanged.Name = "txtChanged";
			this.txtChanged.ReadOnly = true;
			this.txtChanged.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtChanged.Size = new System.Drawing.Size(105, 20);
			this.txtChanged.TabIndex = 24;
			// 
			// txtOrderID
			// 
			this.txtOrderID.AcceptsReturn = true;
			this.txtOrderID.AllowDrop = true;
			this.txtOrderID.BackColor = System.Drawing.SystemColors.Menu;
			this.txtOrderID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtOrderID.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOrderID.Location = new System.Drawing.Point(96, 8);
			this.txtOrderID.MaxLength = 0;
			this.txtOrderID.Name = "txtOrderID";
			this.txtOrderID.ReadOnly = true;
			this.txtOrderID.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtOrderID.Size = new System.Drawing.Size(105, 20);
			this.txtOrderID.TabIndex = 23;
			// 
			// txtNotes
			// 
			this.txtNotes.AcceptsReturn = true;
			this.txtNotes.AllowDrop = true;
			this.txtNotes.BackColor = System.Drawing.SystemColors.Menu;
			this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNotes.Location = new System.Drawing.Point(56, 152);
			this.txtNotes.MaxLength = 0;
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ReadOnly = true;
			this.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtNotes.Size = new System.Drawing.Size(457, 44);
			this.txtNotes.TabIndex = 3;
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
			this.txtSubTotal.Location = new System.Drawing.Point(368, 408);
			this.txtSubTotal.MaxLength = 0;
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.ReadOnly = true;
			this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSubTotal.Size = new System.Drawing.Size(145, 20);
			this.txtSubTotal.TabIndex = 21;
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
			this.txtTotal.Location = new System.Drawing.Point(88, 432);
			this.txtTotal.MaxLength = 0;
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTotal.Size = new System.Drawing.Size(145, 20);
			this.txtTotal.TabIndex = 19;
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
			this.txtTotalTax.Location = new System.Drawing.Point(368, 384);
			this.txtTotalTax.MaxLength = 0;
			this.txtTotalTax.Name = "txtTotalTax";
			this.txtTotalTax.ReadOnly = true;
			this.txtTotalTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtTotalTax.Size = new System.Drawing.Size(145, 20);
			this.txtTotalTax.TabIndex = 17;
			this.txtTotalTax.TabStop = false;
			this.txtTotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtFreightCharge
			// 
			this.txtFreightCharge.AcceptsReturn = true;
			this.txtFreightCharge.AllowDrop = true;
			this.txtFreightCharge.BackColor = System.Drawing.SystemColors.Menu;
			this.txtFreightCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtFreightCharge.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFreightCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtFreightCharge.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFreightCharge.Location = new System.Drawing.Point(88, 408);
			this.txtFreightCharge.MaxLength = 0;
			this.txtFreightCharge.Name = "txtFreightCharge";
			this.txtFreightCharge.ReadOnly = true;
			this.txtFreightCharge.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
			this.txtFreightCharge.TabIndex = 6;
			this.txtFreightCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtSalesTax
			// 
			this.txtSalesTax.AcceptsReturn = true;
			this.txtSalesTax.AllowDrop = true;
			this.txtSalesTax.BackColor = System.Drawing.SystemColors.Menu;
			this.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSalesTax.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSalesTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSalesTax.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSalesTax.Location = new System.Drawing.Point(88, 384);
			this.txtSalesTax.MaxLength = 0;
			this.txtSalesTax.Name = "txtSalesTax";
			this.txtSalesTax.ReadOnly = true;
			this.txtSalesTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
			this.txtSalesTax.TabIndex = 5;
			this.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtEntry
			// 
			this.txtEntry.AcceptsReturn = true;
			this.txtEntry.AllowDrop = true;
			this.txtEntry.BackColor = System.Drawing.SystemColors.Window;
			this.txtEntry.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEntry.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtEntry.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtEntry.Location = new System.Drawing.Point(416, 312);
			this.txtEntry.MaxLength = 0;
			this.txtEntry.Name = "txtEntry";
			this.txtEntry.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtEntry.Size = new System.Drawing.Size(73, 19);
			this.txtEntry.TabIndex = 14;
			this.txtEntry.Visible = false;
			// 
			// fgDetails
			// 
			this.fgDetails.AllowDrop = true;
			this.fgDetails.AllowUserToAddRows = false;
			this.fgDetails.AllowUserToDeleteRows = false;
			this.fgDetails.AllowUserToResizeColumns = false;
			this.fgDetails.AllowUserToResizeRows = false;
			this.fgDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fgDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.fgDetails.ColumnsCount = 0;
			this.fgDetails.FixedColumns = 0;
			this.fgDetails.FixedRows = 0;
			this.fgDetails.Location = new System.Drawing.Point(8, 200);
			this.fgDetails.Name = "fgDetails";
			this.fgDetails.ReadOnly = true;
			this.fgDetails.RowsCount = 5;
			this.fgDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.fgDetails.ShowCellToolTips = false;
			this.fgDetails.Size = new System.Drawing.Size(505, 177);
			this.fgDetails.StandardTab = true;
			this.fgDetails.TabIndex = 4;
			// 
			// sbStatusBar
			// 
			this.sbStatusBar.AllowDrop = true;
			this.sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.sbStatusBar.Location = new System.Drawing.Point(0, 494);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.ShowItemToolTips = true;
			this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
			this.sbStatusBar.TabIndex = 13;
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
			this.cmdCancel.Location = new System.Drawing.Point(328, 456);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCancel.Size = new System.Drawing.Size(89, 25);
			this.cmdCancel.TabIndex = 1;
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
			this.cmdClose.Location = new System.Drawing.Point(424, 456);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(89, 25);
			this.cmdClose.TabIndex = 2;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.txtProviderContact);
			this.Frame2.Controls.Add(this.txtProviderCompany);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Enabled = true;
			this.Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(8, 96);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(505, 49);
			this.Frame2.TabIndex = 7;
			this.Frame2.Text = "Supplier";
			this.Frame2.Visible = true;
			// 
			// txtProviderContact
			// 
			this.txtProviderContact.AcceptsReturn = true;
			this.txtProviderContact.AllowDrop = true;
			this.txtProviderContact.BackColor = System.Drawing.SystemColors.Menu;
			this.txtProviderContact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtProviderContact.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtProviderContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtProviderContact.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtProviderContact.Location = new System.Drawing.Point(288, 16);
			this.txtProviderContact.MaxLength = 0;
			this.txtProviderContact.Name = "txtProviderContact";
			this.txtProviderContact.ReadOnly = true;
			this.txtProviderContact.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtProviderContact.Size = new System.Drawing.Size(209, 20);
			this.txtProviderContact.TabIndex = 11;
			this.txtProviderContact.TabStop = false;
			// 
			// txtProviderCompany
			// 
			this.txtProviderCompany.AcceptsReturn = true;
			this.txtProviderCompany.AllowDrop = true;
			this.txtProviderCompany.BackColor = System.Drawing.SystemColors.Menu;
			this.txtProviderCompany.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtProviderCompany.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtProviderCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtProviderCompany.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtProviderCompany.Location = new System.Drawing.Point(72, 16);
			this.txtProviderCompany.MaxLength = 0;
			this.txtProviderCompany.Name = "txtProviderCompany";
			this.txtProviderCompany.ReadOnly = true;
			this.txtProviderCompany.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtProviderCompany.Size = new System.Drawing.Size(145, 20);
			this.txtProviderCompany.TabIndex = 10;
			this.txtProviderCompany.TabStop = false;
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
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Name:";
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
			this.Label1.TabIndex = 8;
			this.Label1.Text = "Contact:";
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(8, 64);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(57, 17);
			this.Label7.TabIndex = 34;
			this.Label7.Text = "By:";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(328, 8);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(49, 17);
			this.Label3.TabIndex = 32;
			this.Label3.Text = "Status:";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label19
			// 
			this.Label19.AllowDrop = true;
			this.Label19.BackColor = System.Drawing.SystemColors.Control;
			this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label19.Location = new System.Drawing.Point(8, 32);
			this.Label19.Name = "Label19";
			this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label19.Size = new System.Drawing.Size(57, 17);
			this.Label19.TabIndex = 30;
			this.Label19.Text = "Received:";
			this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblChangedBy
			// 
			this.lblChangedBy.AllowDrop = true;
			this.lblChangedBy.BackColor = System.Drawing.SystemColors.Control;
			this.lblChangedBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblChangedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblChangedBy.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblChangedBy.Location = new System.Drawing.Point(320, 64);
			this.lblChangedBy.Name = "lblChangedBy";
			this.lblChangedBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblChangedBy.Size = new System.Drawing.Size(57, 17);
			this.lblChangedBy.TabIndex = 28;
			this.lblChangedBy.Text = "By:";
			this.lblChangedBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(16, 8);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(49, 17);
			this.Label4.TabIndex = 27;
			this.Label4.Text = "Order Id:";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblChanged
			// 
			this.lblChanged.AllowDrop = true;
			this.lblChanged.BackColor = System.Drawing.SystemColors.Control;
			this.lblChanged.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblChanged.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblChanged.Location = new System.Drawing.Point(312, 36);
			this.lblChanged.Name = "lblChanged";
			this.lblChanged.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblChanged.Size = new System.Drawing.Size(65, 17);
			this.lblChanged.TabIndex = 26;
			this.lblChanged.Text = "Changed:";
			this.lblChanged.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label12
			// 
			this.Label12.AllowDrop = true;
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(8, 408);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(57, 17);
			this.Label12.TabIndex = 22;
			this.Label12.Text = "Freight:";
			// 
			// Label11
			// 
			this.Label11.AllowDrop = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(8, 432);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(89, 17);
			this.Label11.TabIndex = 20;
			this.Label11.Text = "Total:";
			// 
			// Label10
			// 
			this.Label10.AllowDrop = true;
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(288, 384);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(89, 17);
			this.Label10.TabIndex = 18;
			this.Label10.Text = "Total Tax:";
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(288, 408);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(89, 17);
			this.Label9.TabIndex = 16;
			this.Label9.Text = "Sub Total:";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(8, 384);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(89, 17);
			this.Label8.TabIndex = 15;
			this.Label8.Text = "Sales Tax:";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(8, 160);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(33, 17);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Notes:";
			// 
			// frmActionOrderReception
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(523, 519);
			this.Controls.Add(this.txtReceivedBy);
			this.Controls.Add(this.cmdApprove);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.txtReceived);
			this.Controls.Add(this.txtChangedBy);
			this.Controls.Add(this.txtChanged);
			this.Controls.Add(this.txtOrderID);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtSubTotal);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtTotalTax);
			this.Controls.Add(this.txtFreightCharge);
			this.Controls.Add(this.txtSalesTax);
			this.Controls.Add(this.txtEntry);
			this.Controls.Add(this.fgDetails);
			this.Controls.Add(this.sbStatusBar);
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label19);
			this.Controls.Add(this.lblChangedBy);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.lblChanged);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label6);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 25);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmActionOrderReception";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Add Stock to Inventory";
			this.Activated += new System.EventHandler(this.frmActionOrderReception_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.fgDetails).EndInit();
			this.sbStatusBar.ResumeLayout(false);
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