using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmOrderReception
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmOrderReception m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmOrderReception DefInstance
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
      public static frmOrderReception CreateInstance()
      {
         frmOrderReception theInstance = new frmOrderReception();
         theInstance.Form_Load();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "txtNotes", "txtSubTotal", "txtTotal", "txtTotalTax", "txtFreightCharge", "txtSalesTax", "txtEntry", "fgProducts", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdSave", "cmdClose", "cmdAddProducts", "txtProviderName", "txtContactLastName", "txtContactName", "cmdProviders", "lvProviders_ColumnHeader_1_", "lvProviders_ColumnHeader_2_", "lvProviders_ColumnHeader_3_", "lvProviders_ColumnHeader_4_", "lvProviders_ColumnHeader_5_", "lvProviders_ColumnHeader_6_", "lvProviders_ColumnHeader_7_", "lvProviders", "Label3", "Label4", "Label2", "Frame1", "txtProviderContact", "txtProviderCompany", "Label5", "Label1", "Frame2", "Label7", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "listViewHelper1", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

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
      public Mobilize.Web.VBUC.FlexGrid fgProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripStatusLabel sbStatusBar_Panels_Panel1 { get; set; }

      [Intercepted]
      public Mobilize.Web.StatusStrip sbStatusBar { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdSave { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdAddProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtProviderName { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtContactLastName { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtContactName { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdProviders { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_1_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_2_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_3_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_4_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_5_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_6_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lvProviders_ColumnHeader_7_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView lvProviders { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label2 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 { get; set; }

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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderReception));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.txtNotes = new Mobilize.Web.TextBox();
         this.txtSubTotal = new Mobilize.Web.TextBox();
         this.txtTotal = new Mobilize.Web.TextBox();
         this.txtTotalTax = new Mobilize.Web.TextBox();
         this.txtFreightCharge = new Mobilize.Web.TextBox();
         this.txtSalesTax = new Mobilize.Web.TextBox();
         this.txtEntry = new Mobilize.Web.TextBox();
         this.fgProducts = new Mobilize.Web.VBUC.FlexGrid(this.components);
         this.sbStatusBar = new Mobilize.Web.StatusStrip();
         this.sbStatusBar_Panels_Panel1 = new Mobilize.Web.ToolStripStatusLabel();
         this.cmdSave = new Mobilize.Web.Button();
         this.cmdClose = new Mobilize.Web.Button();
         this.cmdAddProducts = new Mobilize.Web.Button();
         this.Frame1 = new Mobilize.Web.GroupBox();
         this.txtProviderName = new Mobilize.Web.TextBox();
         this.txtContactLastName = new Mobilize.Web.TextBox();
         this.txtContactName = new Mobilize.Web.TextBox();
         this.cmdProviders = new Mobilize.Web.Button();
         this.lvProviders = new Mobilize.Web.ListView();
         this.lvProviders_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProviders_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProviders_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProviders_ColumnHeader_4_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProviders_ColumnHeader_5_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProviders_ColumnHeader_6_ = new Mobilize.Web.ListViewColumnHeader();
         this.lvProviders_ColumnHeader_7_ = new Mobilize.Web.ListViewColumnHeader();
         this.Label3 = new Mobilize.Web.Label();
         this.Label4 = new Mobilize.Web.Label();
         this.Label2 = new Mobilize.Web.Label();
         this.Frame2 = new Mobilize.Web.GroupBox();
         this.txtProviderContact = new Mobilize.Web.TextBox();
         this.txtProviderCompany = new Mobilize.Web.TextBox();
         this.Label5 = new Mobilize.Web.Label();
         this.Label1 = new Mobilize.Web.Label();
         this.Label7 = new Mobilize.Web.Label();
         this.Label12 = new Mobilize.Web.Label();
         this.Label11 = new Mobilize.Web.Label();
         this.Label10 = new Mobilize.Web.Label();
         this.Label9 = new Mobilize.Web.Label();
         this.Label8 = new Mobilize.Web.Label();
         this.Label6 = new Mobilize.Web.Label();
         this.sbStatusBar.SuspendLayout();
         this.Frame1.SuspendLayout();
         this.lvProviders.SuspendLayout();
         this.Frame2.SuspendLayout();
         this.SuspendLayout();
         this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // txtNotes
         // 
         this.txtNotes.AcceptsReturn = true;
         this.txtNotes.AllowDrop = true;
         this.txtNotes.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtNotes.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtNotes.Properties().Cursor = null;
         this.txtNotes.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtNotes.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtNotes.Location = new System.Drawing.Point(56, 240);
         this.txtNotes.MaxLength = 0;
         this.txtNotes.Multiline = true;
         this.txtNotes.Name = "txtNotes";
         this.txtNotes.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtNotes.Size = new System.Drawing.Size(425, 44);
         this.txtNotes.TabIndex = 4;
         this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
         // 
         // txtSubTotal
         // 
         this.txtSubTotal.AcceptsReturn = true;
         this.txtSubTotal.AllowDrop = true;
         this.txtSubTotal.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtSubTotal.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSubTotal.Properties().Cursor = null;
         this.txtSubTotal.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtSubTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSubTotal.Location = new System.Drawing.Point(352, 536);
         this.txtSubTotal.MaxLength = 0;
         this.txtSubTotal.Name = "txtSubTotal";
         this.txtSubTotal.ReadOnly = true;
         this.txtSubTotal.RightToLeft = Mobilize.Web.RightToLeft.No;
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
         this.txtTotal.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtTotal.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtTotal.Location = new System.Drawing.Point(88, 560);
         this.txtTotal.MaxLength = 0;
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.ReadOnly = true;
         this.txtTotal.RightToLeft = Mobilize.Web.RightToLeft.No;
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
         this.txtTotalTax.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtTotalTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtTotalTax.Location = new System.Drawing.Point(352, 512);
         this.txtTotalTax.MaxLength = 0;
         this.txtTotalTax.Name = "txtTotalTax";
         this.txtTotalTax.ReadOnly = true;
         this.txtTotalTax.RightToLeft = Mobilize.Web.RightToLeft.No;
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
         this.txtFreightCharge.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtFreightCharge.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFreightCharge.Location = new System.Drawing.Point(88, 536);
         this.txtFreightCharge.MaxLength = 0;
         this.txtFreightCharge.Name = "txtFreightCharge";
         this.txtFreightCharge.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtFreightCharge.Size = new System.Drawing.Size(145, 20);
         this.txtFreightCharge.TabIndex = 7;
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
         this.txtSalesTax.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtSalesTax.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSalesTax.Location = new System.Drawing.Point(88, 512);
         this.txtSalesTax.MaxLength = 0;
         this.txtSalesTax.Name = "txtSalesTax";
         this.txtSalesTax.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtSalesTax.Size = new System.Drawing.Size(145, 20);
         this.txtSalesTax.TabIndex = 6;
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
         this.txtEntry.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtEntry.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtEntry.Location = new System.Drawing.Point(88, 488);
         this.txtEntry.MaxLength = 0;
         this.txtEntry.Name = "txtEntry";
         this.txtEntry.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtEntry.Size = new System.Drawing.Size(145, 19);
         this.txtEntry.TabIndex = 24;
         this.txtEntry.Visible = false;
         this.txtEntry.KeyDown += new Mobilize.Web.KeyEventHandler(this.txtEntry_KeyDown);
         this.txtEntry.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.txtEntry_KeyPress);
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
         this.fgProducts.Location = new System.Drawing.Point(8, 288);
         this.fgProducts.Name = "fgProducts";
         this.fgProducts.Properties().ReadOnly = true;
         this.fgProducts.RowsCount = 2;
         this.fgProducts.Properties().SelectionMode = Mobilize.Web.DataGridViewSelectionMode.CellSelect;
         this.fgProducts.Properties().ShowCellToolTips = false;
         this.fgProducts.Size = new System.Drawing.Size(505, 177);
         this.fgProducts.Properties().StandardTab = true;
         this.fgProducts.TabIndex = 5;
         this.fgProducts.CellLeave += new Mobilize.Web.DataGridViewCellEventHandler(this.fgProducts_CellLeave);
         this.fgProducts.Click += new System.EventHandler(this.fgProducts_Click);
         this.fgProducts.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.fgProducts_KeyPress);
         // 
         // sbStatusBar
         // 
         this.sbStatusBar.AllowDrop = true;
         this.sbStatusBar.Properties().BackColor = Mobilize.Web.SystemColors.Control;
         this.sbStatusBar.Dock = Mobilize.Web.DockStyle.Bottom;
         this.sbStatusBar.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.sbStatusBar.Location = new System.Drawing.Point(0, 623);
         this.sbStatusBar.Name = "sbStatusBar";
         this.sbStatusBar.Properties().ShowItemToolTips = true;
         this.sbStatusBar.Size = new System.Drawing.Size(521, 25);
         this.sbStatusBar.TabIndex = 23;
         this.sbStatusBar.Items.AddRange(new Mobilize.Web.ToolStripItem[] { this.sbStatusBar_Panels_Panel1 });
         // 
         // sbStatusBar_Panels_Panel1
         // 
         this.sbStatusBar_Panels_Panel1.BorderSides = (Mobilize.Web.ToolStripStatusLabelBorderSides)(Mobilize.Web.ToolStripStatusLabelBorderSides.Left | Mobilize.Web.ToolStripStatusLabelBorderSides.Top | Mobilize.Web.ToolStripStatusLabelBorderSides.Right | Mobilize.Web.ToolStripStatusLabelBorderSides.Bottom);
         this.sbStatusBar_Panels_Panel1.Properties().BorderStyle = Mobilize.Web.Border3DStyle.SunkenOuter;
         this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
         this.sbStatusBar_Panels_Panel1.Margin = new Mobilize.Web.Padding(0);
         this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(521, 25);
         this.sbStatusBar_Panels_Panel1.Spring = true;
         this.sbStatusBar_Panels_Panel1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.sbStatusBar_Panels_Panel1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageBeforeText;
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(320, 584);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(89, 25);
         this.cmdSave.TabIndex = 8;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(424, 584);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(89, 25);
         this.cmdClose.TabIndex = 9;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdAddProducts
         // 
         this.cmdAddProducts.AllowDrop = true;
         this.cmdAddProducts.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdAddProducts.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdAddProducts.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdAddProducts.Location = new System.Drawing.Point(488, 264);
         this.cmdAddProducts.Name = "cmdAddProducts";
         this.cmdAddProducts.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdAddProducts.Size = new System.Drawing.Size(25, 21);
         this.cmdAddProducts.TabIndex = 21;
         this.cmdAddProducts.TabStop = false;
         this.cmdAddProducts.Text = "...";
         this.cmdAddProducts.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdAddProducts.UseVisualStyleBackColor = false;
         this.cmdAddProducts.Click += new System.EventHandler(this.cmdAddProducts_Click);
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.txtProviderName);
         this.Frame1.Controls.Add(this.txtContactLastName);
         this.Frame1.Controls.Add(this.txtContactName);
         this.Frame1.Controls.Add(this.cmdProviders);
         this.Frame1.Controls.Add(this.lvProviders);
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
         this.Frame1.Size = new System.Drawing.Size(505, 169);
         this.Frame1.TabIndex = 12;
         this.Frame1.Text = "Search supplier";
         this.Frame1.Visible = true;
         // 
         // txtProviderName
         // 
         this.txtProviderName.AcceptsReturn = true;
         this.txtProviderName.AllowDrop = true;
         this.txtProviderName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtProviderName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderName.Properties().Cursor = null;
         this.txtProviderName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtProviderName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderName.Location = new System.Drawing.Point(88, 16);
         this.txtProviderName.MaxLength = 0;
         this.txtProviderName.Name = "txtProviderName";
         this.txtProviderName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtProviderName.Size = new System.Drawing.Size(145, 20);
         this.txtProviderName.TabIndex = 0;
         this.txtProviderName.TextChanged += new System.EventHandler(this.txtProviderName_TextChanged);
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
         this.txtContactName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtContactName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtContactName.Location = new System.Drawing.Point(88, 48);
         this.txtContactName.MaxLength = 0;
         this.txtContactName.Name = "txtContactName";
         this.txtContactName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtContactName.Size = new System.Drawing.Size(145, 20);
         this.txtContactName.TabIndex = 1;
         this.txtContactName.TextChanged += new System.EventHandler(this.txtContactName_TextChanged);
         // 
         // cmdProviders
         // 
         this.cmdProviders.AllowDrop = true;
         this.cmdProviders.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdProviders.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdProviders.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdProviders.Location = new System.Drawing.Point(456, 16);
         this.cmdProviders.Name = "cmdProviders";
         this.cmdProviders.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdProviders.Size = new System.Drawing.Size(25, 21);
         this.cmdProviders.TabIndex = 13;
         this.cmdProviders.TabStop = false;
         this.cmdProviders.Text = "...";
         this.cmdProviders.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdProviders.UseVisualStyleBackColor = false;
         this.cmdProviders.Click += new System.EventHandler(this.cmdProviders_Click);
         // 
         // lvProviders
         // 
         this.lvProviders.AllowDrop = true;
         this.lvProviders.BackColor = Mobilize.Web.SystemColors.Window;
         this.lvProviders.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lvProviders.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lvProviders.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lvProviders.FullRowSelect = true;
         this.lvProviders.GridLines = true;
         this.lvProviders.HideSelection = false;
         this.lvProviders.HotTracking = true;
         this.lvProviders.LabelEdit = false;
         this.lvProviders.Location = new System.Drawing.Point(8, 80);
         this.lvProviders.MultiSelect = false;
         this.lvProviders.Name = "lvProviders";
         this.lvProviders.Size = new System.Drawing.Size(489, 81);
         this.lvProviders.TabIndex = 3;
         this.lvProviders.View = Mobilize.Web.ListViewMode.Details;
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_1_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_2_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_3_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_4_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_5_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_6_);
         this.lvProviders.Columns.Add(this.lvProviders_ColumnHeader_7_);
         // 
         // lvProviders_ColumnHeader_1_
         // 
         this.lvProviders_ColumnHeader_1_.Text = "Supplier ID";
         this.lvProviders_ColumnHeader_1_.Width = 97;
         // 
         // lvProviders_ColumnHeader_2_
         // 
         this.lvProviders_ColumnHeader_2_.Text = "Supplier Name";
         this.lvProviders_ColumnHeader_2_.Width = 97;
         // 
         // lvProviders_ColumnHeader_3_
         // 
         this.lvProviders_ColumnHeader_3_.Text = "Contact Name";
         this.lvProviders_ColumnHeader_3_.Width = 97;
         // 
         // lvProviders_ColumnHeader_4_
         // 
         this.lvProviders_ColumnHeader_4_.Text = "Contact Last Name";
         this.lvProviders_ColumnHeader_4_.Width = 97;
         // 
         // lvProviders_ColumnHeader_5_
         // 
         this.lvProviders_ColumnHeader_5_.Text = "City";
         this.lvProviders_ColumnHeader_5_.Width = 97;
         // 
         // lvProviders_ColumnHeader_6_
         // 
         this.lvProviders_ColumnHeader_6_.Text = "State";
         this.lvProviders_ColumnHeader_6_.Width = 97;
         // 
         // lvProviders_ColumnHeader_7_
         // 
         this.lvProviders_ColumnHeader_7_.Text = "Country";
         this.lvProviders_ColumnHeader_7_.Width = 97;
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(240, 48);
         this.Label3.Name = "Label3";
         this.Label3.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(97, 17);
         this.Label3.TabIndex = 16;
         this.Label3.Text = "Last name";
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
         this.Label4.TabIndex = 15;
         this.Label4.Text = "Supplier";
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
         this.Label2.TabIndex = 14;
         this.Label2.Text = "First Name";
         // 
         // Frame2
         // 
         this.Frame2.AllowDrop = true;
         this.Frame2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame2.Controls.Add(this.txtProviderContact);
         this.Frame2.Controls.Add(this.txtProviderCompany);
         this.Frame2.Controls.Add(this.Label5);
         this.Frame2.Controls.Add(this.Label1);
         this.Frame2.Properties().Cursor = Stub._UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
         this.Frame2.Enabled = true;
         this.Frame2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Frame2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame2.Location = new System.Drawing.Point(8, 184);
         this.Frame2.Name = "Frame2";
         this.Frame2.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Frame2.Size = new System.Drawing.Size(505, 49);
         this.Frame2.TabIndex = 11;
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
         this.txtProviderContact.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtProviderContact.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderContact.Location = new System.Drawing.Point(288, 16);
         this.txtProviderContact.MaxLength = 0;
         this.txtProviderContact.Name = "txtProviderContact";
         this.txtProviderContact.ReadOnly = true;
         this.txtProviderContact.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtProviderContact.Size = new System.Drawing.Size(209, 20);
         this.txtProviderContact.TabIndex = 20;
         this.txtProviderContact.TabStop = false;
         // 
         // txtProviderCompany
         // 
         this.txtProviderCompany.AcceptsReturn = true;
         this.txtProviderCompany.AllowDrop = true;
         this.txtProviderCompany.BackColor = Mobilize.Web.SystemColors.Menu;
         this.txtProviderCompany.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtProviderCompany.Properties().Cursor = null;
         this.txtProviderCompany.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtProviderCompany.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtProviderCompany.Location = new System.Drawing.Point(72, 16);
         this.txtProviderCompany.MaxLength = 0;
         this.txtProviderCompany.Name = "txtProviderCompany";
         this.txtProviderCompany.ReadOnly = true;
         this.txtProviderCompany.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtProviderCompany.Size = new System.Drawing.Size(145, 20);
         this.txtProviderCompany.TabIndex = 19;
         this.txtProviderCompany.TabStop = false;
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(8, 16);
         this.Label5.Name = "Label5";
         this.Label5.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(57, 17);
         this.Label5.TabIndex = 18;
         this.Label5.Text = "Name:";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(232, 16);
         this.Label1.Name = "Label1";
         this.Label1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(57, 17);
         this.Label1.TabIndex = 17;
         this.Label1.Text = "Contact:";
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(8, 488);
         this.Label7.Name = "Label7";
         this.Label7.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(81, 17);
         this.Label7.TabIndex = 10;
         this.Label7.Text = "Quantity";
         // 
         // Label12
         // 
         this.Label12.AllowDrop = true;
         this.Label12.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label12.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label12.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label12.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label12.Location = new System.Drawing.Point(8, 536);
         this.Label12.Name = "Label12";
         this.Label12.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label12.Size = new System.Drawing.Size(89, 17);
         this.Label12.TabIndex = 32;
         this.Label12.Text = "Freight";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(8, 560);
         this.Label11.Name = "Label11";
         this.Label11.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 30;
         this.Label11.Text = "Total";
         // 
         // Label10
         // 
         this.Label10.AllowDrop = true;
         this.Label10.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label10.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label10.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label10.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label10.Location = new System.Drawing.Point(272, 512);
         this.Label10.Name = "Label10";
         this.Label10.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label10.Size = new System.Drawing.Size(89, 17);
         this.Label10.TabIndex = 28;
         this.Label10.Text = "Total Tax";
         // 
         // Label9
         // 
         this.Label9.AllowDrop = true;
         this.Label9.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label9.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label9.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label9.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label9.Location = new System.Drawing.Point(272, 536);
         this.Label9.Name = "Label9";
         this.Label9.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label9.Size = new System.Drawing.Size(89, 17);
         this.Label9.TabIndex = 26;
         this.Label9.Text = "Sub Total";
         // 
         // Label8
         // 
         this.Label8.AllowDrop = true;
         this.Label8.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label8.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label8.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label8.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label8.Location = new System.Drawing.Point(8, 512);
         this.Label8.Name = "Label8";
         this.Label8.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label8.Size = new System.Drawing.Size(89, 17);
         this.Label8.TabIndex = 25;
         this.Label8.Text = "Sales Tax";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(8, 248);
         this.Label6.Name = "Label6";
         this.Label6.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(33, 17);
         this.Label6.TabIndex = 22;
         this.Label6.Text = "Notes:";
         // 
         // frmOrderReception
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(521, 648);
         this.Controls.Add(this.txtNotes);
         this.Controls.Add(this.txtSubTotal);
         this.Controls.Add(this.txtTotal);
         this.Controls.Add(this.txtTotalTax);
         this.Controls.Add(this.txtFreightCharge);
         this.Controls.Add(this.txtSalesTax);
         this.Controls.Add(this.txtEntry);
         this.Controls.Add(this.fgProducts);
         this.Controls.Add(this.sbStatusBar);
         this.Controls.Add(this.cmdSave);
         this.Controls.Add(this.cmdClose);
         this.Controls.Add(this.cmdAddProducts);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.Frame2);
         this.Controls.Add(this.Label7);
         this.Controls.Add(this.Label12);
         this.Controls.Add(this.Label11);
         this.Controls.Add(this.Label10);
         this.Controls.Add(this.Label9);
         this.Controls.Add(this.Label8);
         this.Controls.Add(this.Label6);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmOrderReception";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Add Stock Order";
         this.commandButtonHelper1.SetStyle(this.cmdSave, 0);
         this.commandButtonHelper1.SetStyle(this.cmdClose, 0);
         this.commandButtonHelper1.SetStyle(this.cmdAddProducts, 0);
         this.commandButtonHelper1.SetStyle(this.cmdProviders, 0);
         this.Activated += new System.EventHandler(this.frmOrderReception_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.FormClosing += new Mobilize.Web.FormClosingEventHandler(this.Form_FormClosing);
         this.lvProviders.ItemClick += new Mobilize.Web.ListViewItemClickEventHandler(this.lvProviders_ItemClick);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lvProviders, true);
         this.sbStatusBar.ResumeLayout(false);
         this.Frame1.ResumeLayout(false);
         this.lvProviders.ResumeLayout(false);
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