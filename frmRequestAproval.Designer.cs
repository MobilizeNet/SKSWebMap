using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmRequestApproval
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmRequestApproval m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmRequestApproval DefInstance
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
      public static frmRequestApproval CreateInstance()
      {
         frmRequestApproval theInstance = new frmRequestApproval();
         theInstance.Form_Load();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "cmdApprove", "cmdInfo", "fgOrders", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdCancel", "cmdClose", "cmbStatus", "chkTo", "chkFrom", "txtProductID", "txtOrderID", "txtContactLastName", "txtContactName", "cmdCustomers", "txtCompanyName", "dtFrom", "dtTo", "Label5", "Label8", "Label1", "Label6", "Label3", "Label4", "Label2", "Frame1", "listBoxComboBoxHelper1", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdApprove { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdInfo { get; set; }

      [Intercepted]
      public Mobilize.Web.VBUC.FlexGrid fgOrders { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdCancel { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.ComboBox cmbStatus { get; set; }

      [Intercepted]
      public Mobilize.Web.CheckBox chkTo { get; set; }

      [Intercepted]
      public Mobilize.Web.CheckBox chkFrom { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtProductID { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtOrderID { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtContactLastName { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtContactName { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdCustomers { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCompanyName { get; set; }

      [Intercepted]
      public Mobilize.Web.DateTimePicker dtFrom { get; set; }

      [Intercepted]
      public Mobilize.Web.DateTimePicker dtTo { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label5 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label8 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label6 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label2 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 { get; set; }

      [Intercepted]
      public Stub._UpgradeHelpers.Gui.Controls.ListControlHelper listBoxComboBoxHelper1 { get; set; }

      [Intercepted]
      public Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper commandButtonHelper1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
         this.components = new Mobilize.Web.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestApproval));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.cmdApprove = new Mobilize.Web.Button();
         this.cmdInfo = new Mobilize.Web.Button();
         this.fgOrders = new Mobilize.Web.VBUC.FlexGrid(this.components);
         this.sbStatusBar = new Mobilize.Web.StatusStrip();
         this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
         this.cmdCancel = new Mobilize.Web.Button();
         this.cmdClose = new Mobilize.Web.Button();
         this.Frame1 = new Mobilize.Web.GroupBox();
         this.cmbStatus = new Mobilize.Web.ComboBox();
         this.chkTo = new Mobilize.Web.CheckBox();
         this.chkFrom = new Mobilize.Web.CheckBox();
         this.txtProductID = new Mobilize.Web.TextBox();
         this.txtOrderID = new Mobilize.Web.TextBox();
         this.txtContactLastName = new Mobilize.Web.TextBox();
         this.txtContactName = new Mobilize.Web.TextBox();
         this.cmdCustomers = new Mobilize.Web.Button();
         this.txtCompanyName = new Mobilize.Web.TextBox();
         this.dtFrom = new Mobilize.Web.DateTimePicker();
         this.dtTo = new Mobilize.Web.DateTimePicker();
         this.Label5 = new Mobilize.Web.Label();
         this.Label8 = new Mobilize.Web.Label();
         this.Label1 = new Mobilize.Web.Label();
         this.Label6 = new Mobilize.Web.Label();
         this.Label3 = new Mobilize.Web.Label();
         this.Label4 = new Mobilize.Web.Label();
         this.Label2 = new Mobilize.Web.Label();
         this.sbStatusBar.SuspendLayout();
         this.Frame1.SuspendLayout();
         this.SuspendLayout();
         this.listBoxComboBoxHelper1 = new Stub._UpgradeHelpers.Gui.Controls.ListControlHelper(this.components);
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // cmdApprove
         // 
         this.cmdApprove.AllowDrop = true;
         this.cmdApprove.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdApprove.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdApprove.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdApprove.Location = new System.Drawing.Point(232, 440);
         this.cmdApprove.Name = "cmdApprove";
         this.cmdApprove.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdApprove.Size = new System.Drawing.Size(89, 25);
         this.cmdApprove.TabIndex = 10;
         this.cmdApprove.Text = "&Create";
         this.cmdApprove.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdApprove.UseVisualStyleBackColor = false;
         this.cmdApprove.Click += new System.EventHandler(this.cmdApprove_Click);
         // 
         // cmdInfo
         // 
         this.cmdInfo.AllowDrop = true;
         this.cmdInfo.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdInfo.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdInfo.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdInfo.Location = new System.Drawing.Point(136, 440);
         this.cmdInfo.Name = "cmdInfo";
         this.cmdInfo.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdInfo.Size = new System.Drawing.Size(89, 25);
         this.cmdInfo.TabIndex = 9;
         this.cmdInfo.Text = "&Info";
         this.cmdInfo.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdInfo.UseVisualStyleBackColor = false;
         this.cmdInfo.Click += new System.EventHandler(this.cmdInfo_Click);
         // 
         // fgOrders
         // 
         this.fgOrders.Properties().AllowBigSelection = false;
         this.fgOrders.AllowDrop = true;
         this.fgOrders.AllowUserToAddRows = false;
         this.fgOrders.AllowUserToDeleteRows = false;
         this.fgOrders.Properties().AllowUserToResizeColumns = false;
         this.fgOrders.Properties().AllowUserToResizeRows = false;
         this.fgOrders.Properties().BorderStyle = Mobilize.Web.BorderStyle.None;
         this.fgOrders.Properties().ColumnHeadersHeightSizeMode = Mobilize.Web.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
         this.fgOrders.ColumnsCount = 1;
         this.fgOrders.FixedColumns = 0;
         this.fgOrders.FixedRows = 0;
         this.fgOrders.Location = new System.Drawing.Point(8, 168);
         this.fgOrders.Name = "fgOrders";
         this.fgOrders.Properties().ReadOnly = true;
         this.fgOrders.RowsCount = 1;
         this.fgOrders.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.FullRowSelect;
         this.fgOrders.Properties().ShowCellToolTips = false;
         this.fgOrders.Size = new System.Drawing.Size(505, 265);
         this.fgOrders.Properties().StandardTab = true;
         this.fgOrders.TabIndex = 8;
         this.fgOrders.DoubleClick += new System.EventHandler(this.fgOrders_DoubleClick);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.sbStatusBar.Location = new System.Drawing.Point(0, 471);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar.TabIndex = 18;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.sbStatusBar_Panels_Panel1 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides)(Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(523, 25);
         this.sbStatusBar_Panels_Panel1.Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdCancel
         // 
         this.cmdCancel.AllowDrop = true;
         this.cmdCancel.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCancel.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdCancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCancel.Location = new System.Drawing.Point(328, 440);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdCancel.Size = new System.Drawing.Size(89, 25);
         this.cmdCancel.TabIndex = 11;
         this.cmdCancel.Text = "&Cancel";
         this.cmdCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCancel.UseVisualStyleBackColor = false;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(424, 440);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 12;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
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
         this.Frame1.Properties().Cursor = Stub._UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
         this.Frame1.Enabled = true;
         this.Frame1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 8);
         this.Frame1.Name = "Frame1";
         this.Frame1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(505, 153);
         this.Frame1.TabIndex = 13;
         this.Frame1.Text = "Search customer";
         this.Frame1.Visible = true;
         // 
         // cmbStatus
         // 
         this.cmbStatus.AllowDrop = true;
         this.cmbStatus.BackColor = Mobilize.Web.SystemColors.Window;
         this.cmbStatus.CausesValidation = true;
         this.cmbStatus.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cmbStatus.Enabled = true;
         this.cmbStatus.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmbStatus.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cmbStatus.IntegralHeight = true;
         this.cmbStatus.Location = new System.Drawing.Point(336, 16);
         this.cmbStatus.Name = "cmbStatus";
         this.cmbStatus.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmbStatus.Size = new System.Drawing.Size(145, 21);
         this.cmbStatus.Sorted = false;
         this.cmbStatus.TabIndex = 1;
         this.cmbStatus.TabStop = true;
         this.cmbStatus.Visible = true;
         this.cmbStatus.Items.AddRange(new object[] { "All", "Requested", "Cancelled", "Approved" });
         this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
         // 
         // chkTo
         // 
         this.chkTo.AllowDrop = true;
         this.chkTo.Appearance = Mobilize.Web.Appearance.Normal;
         this.chkTo.BackColor = Mobilize.Web.SystemColors.Control;
         this.chkTo.CausesValidation = true;
         this.chkTo.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkTo.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.chkTo.Enabled = true;
         this.chkTo.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.chkTo.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.chkTo.Location = new System.Drawing.Point(336, 80);
         this.chkTo.Name = "chkTo";
         this.chkTo.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.chkTo.Size = new System.Drawing.Size(41, 17);
         this.chkTo.TabIndex = 23;
         this.chkTo.TabStop = false;
         this.chkTo.Text = "To:";
         this.chkTo.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkTo.Visible = true;
         // 
         // chkFrom
         // 
         this.chkFrom.AllowDrop = true;
         this.chkFrom.Appearance = Mobilize.Web.Appearance.Normal;
         this.chkFrom.BackColor = Mobilize.Web.SystemColors.Control;
         this.chkFrom.CausesValidation = true;
         this.chkFrom.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkFrom.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.chkFrom.Enabled = true;
         this.chkFrom.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.chkFrom.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.chkFrom.Location = new System.Drawing.Point(88, 80);
         this.chkFrom.Name = "chkFrom";
         this.chkFrom.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.chkFrom.Size = new System.Drawing.Size(47, 17);
         this.chkFrom.TabIndex = 22;
         this.chkFrom.TabStop = false;
         this.chkFrom.Text = "From:";
         this.chkFrom.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkFrom.Visible = true;
         // 
         // txtProductID
         // 
         this.txtProductID.AcceptsReturn = true;
         this.txtProductID.AllowDrop = true;
         this.txtProductID.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtProductID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProductID.Properties().Cursor = null;
         this.txtProductID.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtProductID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProductID.Location = new System.Drawing.Point(336, 112);
         this.txtProductID.MaxLength = 0;
         this.txtProductID.Name = "txtProductID";
         this.txtProductID.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtProductID.Size = new System.Drawing.Size(145, 20);
         this.txtProductID.TabIndex = 7;
         this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
         // 
         // txtOrderID
         // 
         this.txtOrderID.AcceptsReturn = true;
         this.txtOrderID.AllowDrop = true;
         this.txtOrderID.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtOrderID.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtOrderID.Properties().Cursor = null;
         this.txtOrderID.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtOrderID.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtOrderID.Location = new System.Drawing.Point(88, 112);
         this.txtOrderID.MaxLength = 0;
         this.txtOrderID.Name = "txtOrderID";
         this.txtOrderID.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtOrderID.Size = new System.Drawing.Size(145, 20);
         this.txtOrderID.TabIndex = 6;
         this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
         // 
         // txtContactLastName
         // 
         this.txtContactLastName.AcceptsReturn = true;
         this.txtContactLastName.AllowDrop = true;
         this.txtContactLastName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtContactLastName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtContactLastName.Properties().Cursor = null;
         this.txtContactLastName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtContactLastName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactLastName.Location = new System.Drawing.Point(336, 48);
         this.txtContactLastName.MaxLength = 0;
         this.txtContactLastName.Name = "txtContactLastName";
         this.txtContactLastName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtContactLastName.Size = new System.Drawing.Size(145, 20);
         this.txtContactLastName.TabIndex = 3;
         this.txtContactLastName.TextChanged += new System.EventHandler(this.txtContactLastName_TextChanged);
         // 
         // txtContactName
         // 
         this.txtContactName.AcceptsReturn = true;
         this.txtContactName.AllowDrop = true;
         this.txtContactName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtContactName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtContactName.Properties().Cursor = null;
         this.txtContactName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtContactName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactName.Location = new System.Drawing.Point(88, 48);
         this.txtContactName.MaxLength = 0;
         this.txtContactName.Name = "txtContactName";
         this.txtContactName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtContactName.Size = new System.Drawing.Size(145, 20);
         this.txtContactName.TabIndex = 2;
         this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
         // 
         // cmdCustomers
         // 
         this.cmdCustomers.AllowDrop = true;
         this.cmdCustomers.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCustomers.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdCustomers.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCustomers.Location = new System.Drawing.Point(240, 16);
         this.cmdCustomers.Name = "cmdCustomers";
         this.cmdCustomers.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdCustomers.Size = new System.Drawing.Size(25, 21);
         this.cmdCustomers.TabIndex = 14;
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
         this.txtCompanyName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtCompanyName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCompanyName.Location = new System.Drawing.Point(88, 16);
         this.txtCompanyName.MaxLength = 0;
         this.txtCompanyName.Name = "txtCompanyName";
         this.txtCompanyName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtCompanyName.Size = new System.Drawing.Size(145, 20);
         this.txtCompanyName.TabIndex = 0;
         this.txtCompanyName.TextChanged += new System.EventHandler(this.txtCompanyName_TextChanged);
         // 
         // dtFrom
         // 
         this.dtFrom.AllowDrop = true;
         this.dtFrom.Checked = false;
         this.dtFrom.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.dtFrom.Format = Mobilize.Web.DateTimePickerFormat.Short;
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
         this.dtTo.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.dtTo.Format = Mobilize.Web.DateTimePickerFormat.Short;
         this.dtTo.Location = new System.Drawing.Point(384, 80);
         this.dtTo.Name = "dtTo";
         this.dtTo.Size = new System.Drawing.Size(97, 20);
         this.dtTo.TabIndex = 5;
         this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(288, 16);
         this.Label5.Name = "Label5";
         this.Label5.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(41, 17);
         this.Label5.TabIndex = 24;
         this.Label5.Text = "Status";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(256, 112);
         this.Label8.Name = "Label8";
         this.Label8.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(73, 17);
         this.Label8.TabIndex = 21;
         this.Label8.Text = "Product";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(8, 112);
         this.Label1.Name = "Label1";
         this.Label1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(89, 17);
         this.Label1.TabIndex = 20;
         this.Label1.Text = "Order";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 80);
         this.Label6.Name = "Label6";
         this.Label6.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(65, 17);
         this.Label6.TabIndex = 19;
         this.Label6.Text = "Date range:";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(256, 48);
         this.Label3.Name = "Label3";
         this.Label3.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(65, 17);
         this.Label3.TabIndex = 17;
         this.Label3.Text = "Last Name";
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(8, 16);
         this.Label4.Name = "Label4";
         this.Label4.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 16;
         this.Label4.Text = "Company";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(8, 48);
         this.Label2.Name = "Label2";
         this.Label2.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(89, 17);
         this.Label2.TabIndex = 15;
         this.Label2.Text = "First Name";
         // 
         // frmRequestApproval
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(523, 496);
         this.Controls.Add(this.cmdApprove);
         this.Controls.Add(this.cmdInfo);
         this.Controls.Add(this.fgOrders);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.Frame1);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmRequestApproval";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Create Invoice";
         this.commandButtonHelper1.SetStyle(this.cmdApprove, 0);
         this.commandButtonHelper1.SetStyle(this.cmdInfo, 0);
         this.commandButtonHelper1.SetStyle(this.cmdCancel, 0);
         this.commandButtonHelper1.SetStyle(this.cmdClose, 0);
         this.commandButtonHelper1.SetStyle(this.cmdCustomers, 0);
         this.listBoxComboBoxHelper1.SetItemData(this.cmbStatus, new int[] { 0, 0, 0, 0 });
         this.Activated += new System.EventHandler(this.frmRequestApproval_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
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