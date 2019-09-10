using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmActionOrderReception
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmActionOrderReception m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
      public static frmActionOrderReception DefInstance
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

      public static frmActionOrderReception CreateInstance()
      {
      	frmActionOrderReception theInstance = new frmActionOrderReception();
      	theInstance.Form_Load();
      	return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "txtReceivedBy", "cmdApprove", "txtStatus", "txtReceived", "txtChangedBy", "txtChanged", "txtOrderID", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgDetails", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label3", "Label19", "lblChangedBy", "Label4", "lblChanged", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtReceivedBy { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdApprove { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtStatus { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtReceived { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtChangedBy { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtChanged { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtOrderID { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtNotes { get; set; }

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
      public Mobilize.Web.VBUC.FlexGrid fgDetails { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdCancel { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtProviderContact { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtProviderCompany { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label5 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label1 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame2 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label7 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label19 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblChangedBy { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblChanged { get; set; }

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
      public Mobilize.Web.Label Label6 { get; set; }
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActionOrderReception));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.txtReceivedBy = new Mobilize.Web.TextBox();
      	this.cmdApprove = new Mobilize.Web.Button();
      	this.txtStatus = new Mobilize.Web.TextBox();
      	this.txtReceived = new Mobilize.Web.TextBox();
      	this.txtChangedBy = new Mobilize.Web.TextBox();
      	this.txtChanged = new Mobilize.Web.TextBox();
      	this.txtOrderID = new Mobilize.Web.TextBox();
      	this.txtNotes = new Mobilize.Web.TextBox();
      	this.txtSubTotal = new Mobilize.Web.TextBox();
      	this.txtTotal = new Mobilize.Web.TextBox();
      	this.txtTotalTax = new Mobilize.Web.TextBox();
      	this.txtFreightCharge = new Mobilize.Web.TextBox();
      	this.txtSalesTax = new Mobilize.Web.TextBox();
      	this.txtEntry = new Mobilize.Web.TextBox();
      	this.fgDetails = new Mobilize.Web.VBUC.FlexGrid(this.components);
      	this.sbStatusBar = new Mobilize.Web.StatusStrip();
      	this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
      	this.cmdCancel = new Mobilize.Web.Button();
      	this.cmdClose = new Mobilize.Web.Button();
      	this.Frame2 = new Mobilize.Web.GroupBox();
      	this.txtProviderContact = new Mobilize.Web.TextBox();
      	this.txtProviderCompany = new Mobilize.Web.TextBox();
      	this.Label5 = new Mobilize.Web.Label();
      	this.Label1 = new Mobilize.Web.Label();
      	this.Label7 = new Mobilize.Web.Label();
      	this.Label3 = new Mobilize.Web.Label();
      	this.Label19 = new Mobilize.Web.Label();
      	this.lblChangedBy = new Mobilize.Web.Label();
      	this.Label4 = new Mobilize.Web.Label();
      	this.lblChanged = new Mobilize.Web.Label();
      	this.Label12 = new Mobilize.Web.Label();
      	this.Label11 = new Mobilize.Web.Label();
      	this.Label10 = new Mobilize.Web.Label();
      	this.Label9 = new Mobilize.Web.Label();
      	this.Label8 = new Mobilize.Web.Label();
      	this.Label6 = new Mobilize.Web.Label();
      	this.sbStatusBar.SuspendLayout();
      	this.Frame2.SuspendLayout();
      	this.SuspendLayout();
      	// 
      	// txtReceivedBy
      	// 
      	this.txtReceivedBy.AcceptsReturn = true;
      	this.txtReceivedBy.AllowDrop = true;
      	this.txtReceivedBy.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtReceivedBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtReceivedBy.Properties().Cursor = null;
         this.txtReceivedBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtReceivedBy.Location = new System.Drawing.Point(96, 64);
         this.txtReceivedBy.MaxLength = 0;
         this.txtReceivedBy.Name = "txtReceivedBy";
         this.txtReceivedBy.ReadOnly = true;
         this.txtReceivedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtReceivedBy.Size = new System.Drawing.Size(105, 20);
         this.txtReceivedBy.TabIndex = 33;
         // 
         // cmdApprove
         // 
         this.cmdApprove.AllowDrop = true;
         this.cmdApprove.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdApprove.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdApprove.Location = new System.Drawing.Point(232, 456);
         this.cmdApprove.Name = "cmdApprove";
         this.cmdApprove.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdApprove.Size = new System.Drawing.Size(89, 25);
         this.cmdApprove.TabIndex = 0;
         this.cmdApprove.Text = "&Add";
         this.cmdApprove.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdApprove.UseVisualStyleBackColor = false;
         this.cmdApprove.Click += new System.EventHandler(this.cmdApprove_Click);
         // 
         // txtStatus
         // 
         this.txtStatus.AcceptsReturn = true;
         this.txtStatus.AllowDrop = true;
         this.txtStatus.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtStatus.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtStatus.Properties().Cursor = null;
         this.txtStatus.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtStatus.Location = new System.Drawing.Point(408, 8);
         this.txtStatus.MaxLength = 0;
         this.txtStatus.Name = "txtStatus";
         this.txtStatus.ReadOnly = true;
         this.txtStatus.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtStatus.Size = new System.Drawing.Size(105, 20);
         this.txtStatus.TabIndex = 31;
         // 
         // txtReceived
         // 
         this.txtReceived.AcceptsReturn = true;
         this.txtReceived.AllowDrop = true;
         this.txtReceived.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtReceived.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtReceived.Properties().Cursor = null;
         this.txtReceived.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtReceived.Location = new System.Drawing.Point(96, 36);
         this.txtReceived.MaxLength = 0;
         this.txtReceived.Name = "txtReceived";
         this.txtReceived.ReadOnly = true;
         this.txtReceived.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtReceived.Size = new System.Drawing.Size(105, 20);
         this.txtReceived.TabIndex = 29;
         // 
         // txtChangedBy
         // 
         this.txtChangedBy.AcceptsReturn = true;
         this.txtChangedBy.AllowDrop = true;
         this.txtChangedBy.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtChangedBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtChangedBy.Properties().Cursor = null;
         this.txtChangedBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtChangedBy.Location = new System.Drawing.Point(408, 64);
         this.txtChangedBy.MaxLength = 0;
         this.txtChangedBy.Name = "txtChangedBy";
         this.txtChangedBy.ReadOnly = true;
         this.txtChangedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtChangedBy.Size = new System.Drawing.Size(105, 20);
         this.txtChangedBy.TabIndex = 25;
         // 
         // txtChanged
         // 
         this.txtChanged.AcceptsReturn = true;
         this.txtChanged.AllowDrop = true;
         this.txtChanged.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtChanged.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtChanged.Properties().Cursor = null;
         this.txtChanged.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtChanged.Location = new System.Drawing.Point(408, 36);
         this.txtChanged.MaxLength = 0;
         this.txtChanged.Name = "txtChanged";
         this.txtChanged.ReadOnly = true;
         this.txtChanged.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtChanged.Size = new System.Drawing.Size(105, 20);
         this.txtChanged.TabIndex = 24;
         // 
         // txtOrderID
         // 
         this.txtOrderID.AcceptsReturn = true;
         this.txtOrderID.AllowDrop = true;
         this.txtOrderID.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtOrderID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtOrderID.Properties().Cursor = null;
         this.txtOrderID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtOrderID.Location = new System.Drawing.Point(96, 8);
         this.txtOrderID.MaxLength = 0;
         this.txtOrderID.Name = "txtOrderID";
         this.txtOrderID.ReadOnly = true;
         this.txtOrderID.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtOrderID.Size = new System.Drawing.Size(105, 20);
         this.txtOrderID.TabIndex = 23;
         // 
         // txtNotes
         // 
         this.txtNotes.AcceptsReturn = true;
         this.txtNotes.AllowDrop = true;
         this.txtNotes.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtNotes.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtNotes.Properties().Cursor = null;
         this.txtNotes.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtNotes.Location = new System.Drawing.Point(56, 152);
         this.txtNotes.MaxLength = 0;
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.ReadOnly = true;
         this.txtNotes.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtNotes.Size = new System.Drawing.Size(457, 44);
         this.txtNotes.TabIndex = 3;
         // 
         // txtSubTotal
         // 
         this.txtSubTotal.AcceptsReturn = true;
         this.txtSubTotal.AllowDrop = true;
         this.txtSubTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSubTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSubTotal.Properties().Cursor = null;
         this.txtSubTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSubTotal.Location = new System.Drawing.Point(368, 408);
         this.txtSubTotal.MaxLength = 0;
         this.txtSubTotal.Name = "txtSubTotal";
         this.txtSubTotal.ReadOnly = true;
         this.txtSubTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSubTotal.Size = new System.Drawing.Size(145, 20);
         this.txtSubTotal.TabIndex = 21;
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
         this.txtTotal.Location = new System.Drawing.Point(88, 432);
         this.txtTotal.MaxLength = 0;
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.ReadOnly = true;
         this.txtTotal.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotal.Size = new System.Drawing.Size(145, 20);
         this.txtTotal.TabIndex = 19;
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
         this.txtTotalTax.Location = new System.Drawing.Point(368, 384);
         this.txtTotalTax.MaxLength = 0;
         this.txtTotalTax.Name = "txtTotalTax";
         this.txtTotalTax.ReadOnly = true;
         this.txtTotalTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtTotalTax.Size = new System.Drawing.Size(145, 20);
         this.txtTotalTax.TabIndex = 17;
         this.txtTotalTax.TabStop = false;
         this.txtTotalTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtFreightCharge
         // 
         this.txtFreightCharge.AcceptsReturn = true;
         this.txtFreightCharge.AllowDrop = true;
         this.txtFreightCharge.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtFreightCharge.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtFreightCharge.Properties().Cursor = null;
         this.txtFreightCharge.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFreightCharge.Location = new System.Drawing.Point(88, 408);
         this.txtFreightCharge.MaxLength = 0;
         this.txtFreightCharge.Name = "txtFreightCharge";
         this.txtFreightCharge.ReadOnly = true;
         this.txtFreightCharge.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         this.txtFreightCharge.TabIndex = 6;
         this.txtFreightCharge.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtSalesTax
         // 
         this.txtSalesTax.AcceptsReturn = true;
         this.txtSalesTax.AllowDrop = true;
         this.txtSalesTax.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSalesTax.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSalesTax.Properties().Cursor = null;
         this.txtSalesTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSalesTax.Location = new System.Drawing.Point(88, 384);
         this.txtSalesTax.MaxLength = 0;
         this.txtSalesTax.Name = "txtSalesTax";
         this.txtSalesTax.ReadOnly = true;
         this.txtSalesTax.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
         this.txtSalesTax.TabIndex = 5;
         this.txtSalesTax.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         // 
         // txtEntry
         // 
         this.txtEntry.AcceptsReturn = true;
         this.txtEntry.AllowDrop = true;
         this.txtEntry.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtEntry.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.txtEntry.Properties().Cursor = null;
         this.txtEntry.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtEntry.Location = new System.Drawing.Point(416, 312);
         this.txtEntry.MaxLength = 0;
         this.txtEntry.Name = "txtEntry";
         this.txtEntry.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtEntry.Size = new System.Drawing.Size(73, 19);
         this.txtEntry.TabIndex = 14;
         this.txtEntry.Visible = false;
         // 
         // fgDetails
         // 
         this.fgDetails.AllowDrop = true;
         this.fgDetails.Properties().BorderStyle = Mobilize.Web.BorderStyle.None;
         this.fgDetails.ColumnsCount = 0;
         this.fgDetails.FixedColumns = 0;
         this.fgDetails.FixedRows = 0;
         this.fgDetails.Location = new System.Drawing.Point(8, 200);
         this.fgDetails.Name = "fgDetails";
         this.fgDetails.RowsCount = 5;
         this.fgDetails.Size = new System.Drawing.Size(505, 177);
         this.fgDetails.TabIndex = 4;
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Properties().Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Location = new System.Drawing.Point(0, 494);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar.TabIndex = 13;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.Properties().BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides) (Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Properties().Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar_Panels_Panel1.Properties().Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdCancel
         // 
         this.cmdCancel.AllowDrop = true;
         this.cmdCancel.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCancel.Location = new System.Drawing.Point(328, 456);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdCancel.Size = new System.Drawing.Size(89, 25);
         this.cmdCancel.TabIndex = 1;
         this.cmdCancel.Text = "&Cancel";
         this.cmdCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCancel.UseVisualStyleBackColor = false;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(424, 456);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 2;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // Frame2
         // 
         this.Frame2.AllowDrop = true;
         this.Frame2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame2.Controls.Add(this.txtProviderContact);
         this.Frame2.Controls.Add(this.txtProviderCompany);
         this.Frame2.Controls.Add(this.Label5);
         this.Frame2.Controls.Add(this.Label1);
         this.Frame2.Enabled = true;
         this.Frame2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame2.Location = new System.Drawing.Point(8, 96);
         this.Frame2.Name = "Frame2";
         this.Frame2.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Frame2.Size = new System.Drawing.Size(505, 49);
         this.Frame2.TabIndex = 7;
         this.Frame2.Text = "Supplier";
         this.Frame2.Visible = true;
         // 
         // txtProviderContact
         // 
         this.txtProviderContact.AcceptsReturn = true;
         this.txtProviderContact.AllowDrop = true;
         this.txtProviderContact.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProviderContact.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderContact.Properties().Cursor = null;
         this.txtProviderContact.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderContact.Location = new System.Drawing.Point(288, 16);
         this.txtProviderContact.MaxLength = 0;
         this.txtProviderContact.Name = "txtProviderContact";
         this.txtProviderContact.ReadOnly = true;
         this.txtProviderContact.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProviderContact.Size = new System.Drawing.Size(209, 20);
         this.txtProviderContact.TabIndex = 11;
         this.txtProviderContact.TabStop = false;
         // 
         // txtProviderCompany
         // 
         this.txtProviderCompany.AcceptsReturn = true;
         this.txtProviderCompany.AllowDrop = true;
         this.txtProviderCompany.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProviderCompany.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderCompany.Properties().Cursor = null;
         this.txtProviderCompany.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderCompany.Location = new System.Drawing.Point(72, 16);
         this.txtProviderCompany.MaxLength = 0;
         this.txtProviderCompany.Name = "txtProviderCompany";
         this.txtProviderCompany.ReadOnly = true;
         this.txtProviderCompany.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtProviderCompany.Size = new System.Drawing.Size(145, 20);
         this.txtProviderCompany.TabIndex = 10;
         this.txtProviderCompany.TabStop = false;
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
         this.Label5.TabIndex = 9;
         this.Label5.Text = "Name:";
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
         this.Label1.TabIndex = 8;
         this.Label1.Text = "Contact:";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(8, 64);
         this.Label7.Name = "Label7";
         this.Label7.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(57, 17);
         this.Label7.TabIndex = 34;
         this.Label7.Text = "By:";
         this.Label7.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(328, 8);
         this.Label3.Name = "Label3";
         this.Label3.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(49, 17);
         this.Label3.TabIndex = 32;
         this.Label3.Text = "Status:";
         this.Label3.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Label19
         // 
         this.Label19.AllowDrop = true;
         this.Label19.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label19.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label19.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label19.Location = new System.Drawing.Point(8, 32);
         this.Label19.Name = "Label19";
         this.Label19.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label19.Size = new System.Drawing.Size(57, 17);
         this.Label19.TabIndex = 30;
         this.Label19.Text = "Received:";
         this.Label19.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblChangedBy
         // 
         this.lblChangedBy.AllowDrop = true;
         this.lblChangedBy.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblChangedBy.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblChangedBy.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblChangedBy.Location = new System.Drawing.Point(320, 64);
         this.lblChangedBy.Name = "lblChangedBy";
         this.lblChangedBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblChangedBy.Size = new System.Drawing.Size(57, 17);
         this.lblChangedBy.TabIndex = 28;
         this.lblChangedBy.Text = "By:";
         this.lblChangedBy.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(16, 8);
         this.Label4.Name = "Label4";
         this.Label4.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(49, 17);
         this.Label4.TabIndex = 27;
         this.Label4.Text = "Order Id:";
         this.Label4.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblChanged
         // 
         this.lblChanged.AllowDrop = true;
         this.lblChanged.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblChanged.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblChanged.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblChanged.Location = new System.Drawing.Point(312, 36);
         this.lblChanged.Name = "lblChanged";
         this.lblChanged.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblChanged.Size = new System.Drawing.Size(65, 17);
         this.lblChanged.TabIndex = 26;
         this.lblChanged.Text = "Changed:";
         this.lblChanged.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(8, 408);
         this.Label12.Name = "Label12";
         this.Label12.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(57, 17);
         this.Label12.TabIndex = 22;
         this.Label12.Text = "Freight:";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(8, 432);
         this.Label11.Name = "Label11";
         this.Label11.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 20;
         this.Label11.Text = "Total:";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(288, 384);
         this.Label10.Name = "Label10";
         this.Label10.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(89, 17);
         this.Label10.TabIndex = 18;
         this.Label10.Text = "Total Tax:";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(288, 408);
         this.Label9.Name = "Label9";
         this.Label9.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(89, 17);
         this.Label9.TabIndex = 16;
         this.Label9.Text = "Sub Total:";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(8, 384);
         this.Label8.Name = "Label8";
         this.Label8.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 15;
         this.Label8.Text = "Sales Tax:";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 160);
         this.Label6.Name = "Label6";
         this.Label6.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(33, 17);
         this.Label6.TabIndex = 12;
         this.Label6.Text = "Notes:";
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(523, 519);
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
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmActionOrderReception";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Add Stock to Inventory";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame2.ResumeLayout(false);
         this.ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         this.MdiParent = SKS.frmMain.DefInstance;
         SKS.frmMain.DefInstance.Show();
      }
      #endregion

   }
}