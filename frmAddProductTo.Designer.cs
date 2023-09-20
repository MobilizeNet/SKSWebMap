using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAddProductTo
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmAddProductTo m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmAddProductTo DefInstance
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
      public static frmAddProductTo CreateInstance()
      {
         frmAddProductTo theInstance = new frmAddProductTo();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "chkAll", "cmdRemove", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdClose", "cmdSave", "cmdProducts", "txtName", "txtCode", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label4", "Label5", "Frame1", "lvProductsBy_ColumnHeader_1_", "lvProductsBy_ColumnHeader_2_", "lvProductsBy_ColumnHeader_3_", "lvProductsBy_ColumnHeader_4_", "lvProductsBy", "lblProductsRelated", "listViewHelper1", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.CheckBox chkAll { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdRemove { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdSave { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtName { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCode { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_1_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_2_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_3_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_4_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_5_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_6_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProducts_ColumnHeader_7_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView lvProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label5 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_1_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_2_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_3_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProductsBy_ColumnHeader_4_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView lvProductsBy { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblProductsRelated { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView listViewHelper1 { get; set; }

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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductTo));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.chkAll = new Mobilize.Web.CheckBox();
         this.cmdRemove = new Mobilize.Web.Button();
         this.sbStatusBar = new Mobilize.Web.StatusStrip();
         this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
         this.cmdClose = new Mobilize.Web.Button();
         this.cmdSave = new Mobilize.Web.Button();
         this.Frame1 = new Mobilize.Web.GroupBox();
         this.cmdProducts = new Mobilize.Web.Button();
         this.txtName = new Mobilize.Web.TextBox();
         this.txtCode = new Mobilize.Web.TextBox();
         this.lvProducts = new Mobilize.Web.ListView();
         this.lvProducts_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProducts_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProducts_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProducts_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProducts_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProducts_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProducts_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
         this.Label4 = new Mobilize.Web.Label();
         this.Label5 = new Mobilize.Web.Label();
         this.lvProductsBy = new Mobilize.Web.ListView();
         this.lvProductsBy_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProductsBy_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProductsBy_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProductsBy_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
         this.lblProductsRelated = new Mobilize.Web.Label();
         this.sbStatusBar.SuspendLayout();
         this.Frame1.SuspendLayout();
         this.lvProducts.SuspendLayout();
         this.lvProductsBy.SuspendLayout();
         this.SuspendLayout();
         this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // chkAll
         // 
         this.chkAll.AllowDrop = true;
         this.chkAll.Appearance = Mobilize.Web.Appearance.Normal;
         this.chkAll.BackColor = Mobilize.Web.SystemColors.Control;
         this.chkAll.CausesValidation = true;
         this.chkAll.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkAll.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.chkAll.Enabled = true;
         this.chkAll.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.chkAll.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.chkAll.Location = new System.Drawing.Point(112, 454);
         this.chkAll.Name = "chkAll";
         this.chkAll.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.chkAll.Size = new System.Drawing.Size(81, 17);
         this.chkAll.TabIndex = 13;
         this.chkAll.TabStop = false;
         this.chkAll.Text = "Check All";
         this.chkAll.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.chkAll.Visible = true;
         this.chkAll.CheckStateChanged += new System.EventHandler(this.chkAll_CheckStateChanged);
         // 
         // cmdRemove
         // 
         this.cmdRemove.AllowDrop = true;
         this.cmdRemove.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdRemove.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdRemove.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdRemove.Location = new System.Drawing.Point(8, 448);
         this.cmdRemove.Name = "cmdRemove";
         this.cmdRemove.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdRemove.Size = new System.Drawing.Size(97, 25);
         this.cmdRemove.TabIndex = 12;
         this.cmdRemove.TabStop = false;
         this.cmdRemove.Text = "&Remove ";
         this.cmdRemove.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdRemove.UseVisualStyleBackColor = false;
         this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.sbStatusBar.Location = new System.Drawing.Point(0, 488);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(424, 23);
         this.sbStatusBar.TabIndex = 11;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.sbStatusBar_Panels_Panel1 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides)(Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(423, 23);
         this.sbStatusBar_Panels_Panel1.Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(328, 448);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 7;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(224, 448);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(89, 25);
         this.cmdSave.TabIndex = 6;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.cmdProducts);
         this.Frame1.Controls.Add(this.txtName);
         this.Frame1.Controls.Add(this.txtCode);
         this.Frame1.Controls.Add(this.lvProducts);
         this.Frame1.Controls.Add(this.Label4);
         this.Frame1.Controls.Add(this.Label5);
         this.Frame1.Properties().Cursor = Stub._UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
         this.Frame1.Enabled = true;
         this.Frame1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 8);
         this.Frame1.Name = "Frame1";
         this.Frame1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(409, 233);
         this.Frame1.TabIndex = 4;
         this.Frame1.Text = "Search product ";
         this.Frame1.Visible = true;
         // 
         // cmdProducts
         // 
         this.cmdProducts.AllowDrop = true;
         this.cmdProducts.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdProducts.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdProducts.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdProducts.Location = new System.Drawing.Point(360, 16);
         this.cmdProducts.Name = "cmdProducts";
         this.cmdProducts.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdProducts.Size = new System.Drawing.Size(25, 21);
         this.cmdProducts.TabIndex = 5;
         this.cmdProducts.TabStop = false;
         this.cmdProducts.Text = "...";
         this.cmdProducts.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdProducts.UseVisualStyleBackColor = false;
         this.cmdProducts.Click += new System.EventHandler(this.cmdProducts_Click);
         // 
         // txtName
         // 
         this.txtName.AcceptsReturn = true;
         this.txtName.AllowDrop = true;
         this.txtName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtName.Properties().Cursor = null;
         this.txtName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtName.Location = new System.Drawing.Point(112, 40);
         this.txtName.MaxLength = 0;
         this.txtName.Name = "txtName";
         this.txtName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtName.Size = new System.Drawing.Size(145, 20);
         this.txtName.TabIndex = 1;
         this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
         // 
         // txtCode
         // 
         this.txtCode.AcceptsReturn = true;
         this.txtCode.AllowDrop = true;
         this.txtCode.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtCode.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCode.Properties().Cursor = null;
         this.txtCode.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtCode.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCode.Location = new System.Drawing.Point(112, 16);
         this.txtCode.MaxLength = 0;
         this.txtCode.Name = "txtCode";
         this.txtCode.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtCode.Size = new System.Drawing.Size(97, 20);
         this.txtCode.TabIndex = 0;
         this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
         this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
         // 
         // lvProducts
         // 
         this.lvProducts.AllowDrop = true;
         this.lvProducts.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvProducts.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvProducts.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lvProducts.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvProducts.FullRowSelect = true;
         this.lvProducts.GridLines = true;
         this.lvProducts.HideSelection = false;
         this.lvProducts.HotTracking = true;
         this.lvProducts.LabelEdit = false;
         this.lvProducts.Location = new System.Drawing.Point(8, 64);
         this.lvProducts.MultiSelect = false;
         this.lvProducts.Name = "lvProducts";
         this.lvProducts.Size = new System.Drawing.Size(393, 161);
         this.lvProducts.TabIndex = 2;
         this.lvProducts.View = Mobilize.Web.ListViewMode.Details;
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_1_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_2_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_3_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_4_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_5_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_6_);
         this.lvProducts.Columns.Add(this.lvProducts_ColumnHeader_7_);
         // 
         // lvProducts_ColumnHeader_1_
         // 
         this.lvProducts_ColumnHeader_1_.Text = "Code";
         this.lvProducts_ColumnHeader_1_.Width = 97;
         // 
         // lvProducts_ColumnHeader_2_
         // 
         this.lvProducts_ColumnHeader_2_.Text = "Name";
         this.lvProducts_ColumnHeader_2_.Width = 97;
         // 
         // lvProducts_ColumnHeader_3_
         // 
         this.lvProducts_ColumnHeader_3_.Text = "Price";
         this.lvProducts_ColumnHeader_3_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_3_.Width = 97;
         // 
         // lvProducts_ColumnHeader_4_
         // 
         this.lvProducts_ColumnHeader_4_.Text = "Existence";
         this.lvProducts_ColumnHeader_4_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_4_.Width = 97;
         // 
         // lvProducts_ColumnHeader_5_
         // 
         this.lvProducts_ColumnHeader_5_.Text = "Ordered";
         this.lvProducts_ColumnHeader_5_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_5_.Width = 97;
         // 
         // lvProducts_ColumnHeader_6_
         // 
         this.lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
         this.lvProducts_ColumnHeader_6_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProducts_ColumnHeader_6_.Width = 97;
         // 
         // lvProducts_ColumnHeader_7_
         // 
         this.lvProducts_ColumnHeader_7_.Text = "Unit";
         this.lvProducts_ColumnHeader_7_.Width = 97;
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(16, 40);
         this.Label4.Name = "Label4";
         this.Label4.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 9;
         this.Label4.Text = "Name";
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(16, 16);
         this.Label5.Name = "Label5";
         this.Label5.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(89, 17);
         this.Label5.TabIndex = 8;
         this.Label5.Text = "Code";
         // 
         // lvProductsBy
         // 
         this.lvProductsBy.AllowDrop = true;
         this.lvProductsBy.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvProductsBy.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvProductsBy.CheckBoxes = true;
         this.lvProductsBy.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lvProductsBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvProductsBy.FullRowSelect = true;
         this.lvProductsBy.GridLines = true;
         this.lvProductsBy.HideSelection = false;
         this.lvProductsBy.HotTracking = true;
         this.lvProductsBy.LabelEdit = false;
         this.lvProductsBy.Location = new System.Drawing.Point(8, 272);
         this.lvProductsBy.MultiSelect = false;
         this.lvProductsBy.Name = "lvProductsBy";
         this.lvProductsBy.Size = new System.Drawing.Size(409, 169);
         this.lvProductsBy.TabIndex = 3;
         this.lvProductsBy.View = Mobilize.Web.ListViewMode.Details;
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_1_);
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_2_);
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_3_);
         this.lvProductsBy.Columns.Add(this.lvProductsBy_ColumnHeader_4_);
         // 
         // lvProductsBy_ColumnHeader_1_
         // 
         this.lvProductsBy_ColumnHeader_1_.Text = "Code";
         this.lvProductsBy_ColumnHeader_1_.Width = 97;
         // 
         // lvProductsBy_ColumnHeader_2_
         // 
         this.lvProductsBy_ColumnHeader_2_.Text = "Name";
         this.lvProductsBy_ColumnHeader_2_.Width = 97;
         // 
         // lvProductsBy_ColumnHeader_3_
         // 
         this.lvProductsBy_ColumnHeader_3_.Text = "Price";
         this.lvProductsBy_ColumnHeader_3_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProductsBy_ColumnHeader_3_.Width = 61;
         // 
         // lvProductsBy_ColumnHeader_4_
         // 
         this.lvProductsBy_ColumnHeader_4_.Text = "Quantity per Unit";
         this.lvProductsBy_ColumnHeader_4_.TextAlign = Mobilize.Web.HorizontalAlignment.Right;
         this.lvProductsBy_ColumnHeader_4_.Width = 94;
         // 
         // lblProductsRelated
         // 
         this.lblProductsRelated.AllowDrop = true;
         this.lblProductsRelated.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblProductsRelated.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblProductsRelated.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblProductsRelated.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblProductsRelated.Location = new System.Drawing.Point(8, 248);
         this.lblProductsRelated.Name = "lblProductsRelated";
         this.lblProductsRelated.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblProductsRelated.Size = new System.Drawing.Size(409, 17);
         this.lblProductsRelated.TabIndex = 10;
         this.lblProductsRelated.Text = "Products";
         // 
         // frmAddProductTo
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(424, 511);
         this.Controls.Add(this.chkAll);
         this.Controls.Add(this.cmdRemove);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.lvProductsBy);
         this.Controls.Add(this.lblProductsRelated);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAddProductTo";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Text = "Create New Product Item";
         this.commandButtonHelper1.SetStyle(this.cmdRemove, 0);
         this.commandButtonHelper1.SetStyle(this.cmdClose, 0);
         this.commandButtonHelper1.SetStyle(this.cmdSave, 0);
         this.commandButtonHelper1.SetStyle(this.cmdProducts, 0);
         this.Activated += new System.EventHandler(this.frmAddProductTo_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);
         this.lvProducts.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvProducts_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvProducts, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvProducts.ResumeLayout(false);
         this.lvProductsBy.ResumeLayout(false);
         this.ResumeLayout(false);
      }
#endregion

   }

}