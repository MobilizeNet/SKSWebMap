
namespace SKS
{
	partial class frmAddProductTo
	{

		#region "Upgrade Support "
		private static frmAddProductTo m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmAddProductTo DefInstance
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
		public static frmAddProductTo CreateInstance()
		{
			frmAddProductTo theInstance = new frmAddProductTo();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "chkAll", "cmdRemove", "sbStatusBar_Panels_Panel1", "sbStatusBar", "cmdClose", "cmdSave", "cmdProducts", "txtName", "txtCode", "lvProducts_ColumnHeader_1_", "lvProducts_ColumnHeader_2_", "lvProducts_ColumnHeader_3_", "lvProducts_ColumnHeader_4_", "lvProducts_ColumnHeader_5_", "lvProducts_ColumnHeader_6_", "lvProducts_ColumnHeader_7_", "lvProducts", "Label4", "Label5", "Frame1", "lvProductsBy_ColumnHeader_1_", "lvProductsBy_ColumnHeader_2_", "lvProductsBy_ColumnHeader_3_", "lvProductsBy_ColumnHeader_4_", "lvProductsBy", "lblProductsRelated", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.CheckBox chkAll;
		public System.Windows.Forms.Button cmdRemove;
		public System.Windows.Forms.ToolStripStatusLabel sbStatusBar_Panels_Panel1;
		public System.Windows.Forms.StatusStrip sbStatusBar;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.Button cmdProducts;
		public System.Windows.Forms.TextBox txtName;
		public System.Windows.Forms.TextBox txtCode;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_4_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_5_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_6_;
		public System.Windows.Forms.ColumnHeader lvProducts_ColumnHeader_7_;
		public System.Windows.Forms.ListView lvProducts;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_3_;
		public System.Windows.Forms.ColumnHeader lvProductsBy_ColumnHeader_4_;
		public System.Windows.Forms.ListView lvProductsBy;
		public System.Windows.Forms.Label lblProductsRelated;
		public UpgradeHelpers.Gui.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProductTo));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.chkAll = new System.Windows.Forms.CheckBox();
			this.cmdRemove = new System.Windows.Forms.Button();
			this.sbStatusBar = new System.Windows.Forms.StatusStrip();
			this.sbStatusBar_Panels_Panel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.cmdProducts = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lvProducts = new System.Windows.Forms.ListView();
			this.lvProducts_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_5_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_6_ = new System.Windows.Forms.ColumnHeader();
			this.lvProducts_ColumnHeader_7_ = new System.Windows.Forms.ColumnHeader();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.lvProductsBy = new System.Windows.Forms.ListView();
			this.lvProductsBy_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lvProductsBy_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lvProductsBy_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.lvProductsBy_ColumnHeader_4_ = new System.Windows.Forms.ColumnHeader();
			this.lblProductsRelated = new System.Windows.Forms.Label();
			this.sbStatusBar.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.lvProducts.SuspendLayout();
			this.lvProductsBy.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// chkAll
			// 
			this.chkAll.AllowDrop = true;
			this.chkAll.Appearance = System.Windows.Forms.Appearance.Normal;
			this.chkAll.BackColor = System.Drawing.SystemColors.Control;
			this.chkAll.CausesValidation = true;
			this.chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkAll.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.chkAll.Enabled = true;
			this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.chkAll.ForeColor = System.Drawing.SystemColors.ControlText;
			this.chkAll.Location = new System.Drawing.Point(112, 454);
			this.chkAll.Name = "chkAll";
			this.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.chkAll.Size = new System.Drawing.Size(81, 17);
			this.chkAll.TabIndex = 13;
			this.chkAll.TabStop = false;
			this.chkAll.Text = "Check All";
			this.chkAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.chkAll.Visible = true;
			this.chkAll.CheckStateChanged += new System.EventHandler(this.chkAll_CheckStateChanged);
			// 
			// cmdRemove
			// 
			this.cmdRemove.AllowDrop = true;
			this.cmdRemove.BackColor = System.Drawing.SystemColors.Control;
			this.cmdRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdRemove.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdRemove.Location = new System.Drawing.Point(8, 448);
			this.cmdRemove.Name = "cmdRemove";
			this.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdRemove.Size = new System.Drawing.Size(97, 25);
			this.cmdRemove.TabIndex = 12;
			this.cmdRemove.TabStop = false;
			this.cmdRemove.Text = "&Remove ";
			this.cmdRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdRemove.UseVisualStyleBackColor = false;
			this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
			// 
			// sbStatusBar
			// 
			this.sbStatusBar.AllowDrop = true;
			this.sbStatusBar.BackColor = System.Drawing.SystemColors.Control;
			this.sbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.sbStatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.sbStatusBar.Location = new System.Drawing.Point(0, 488);
			this.sbStatusBar.Name = "sbStatusBar";
			this.sbStatusBar.ShowItemToolTips = true;
			this.sbStatusBar.Size = new System.Drawing.Size(424, 23);
			this.sbStatusBar.TabIndex = 11;
			this.sbStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[]{this.sbStatusBar_Panels_Panel1});
			// 
			// sbStatusBar_Panels_Panel1
			// 
			this.sbStatusBar_Panels_Panel1.BorderSides = (System.Windows.Forms.ToolStripStatusLabelBorderSides) (System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom);
			this.sbStatusBar_Panels_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
			this.sbStatusBar_Panels_Panel1.DoubleClickEnabled = true;
			this.sbStatusBar_Panels_Panel1.Margin = new System.Windows.Forms.Padding(0);
			this.sbStatusBar_Panels_Panel1.Size = new System.Drawing.Size(423, 23);
			this.sbStatusBar_Panels_Panel1.Spring = true;
			this.sbStatusBar_Panels_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.sbStatusBar_Panels_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			// 
			// cmdClose
			// 
			this.cmdClose.AllowDrop = true;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Location = new System.Drawing.Point(328, 448);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(89, 25);
			this.cmdClose.TabIndex = 7;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.AllowDrop = true;
			this.cmdSave.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSave.Location = new System.Drawing.Point(224, 448);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSave.Size = new System.Drawing.Size(89, 25);
			this.cmdSave.TabIndex = 6;
			this.cmdSave.Text = "&Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.cmdProducts);
			this.Frame1.Controls.Add(this.txtName);
			this.Frame1.Controls.Add(this.txtCode);
			this.Frame1.Controls.Add(this.lvProducts);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 8);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(409, 233);
			this.Frame1.TabIndex = 4;
			this.Frame1.Text = "Search product ";
			this.Frame1.Visible = true;
			// 
			// cmdProducts
			// 
			this.cmdProducts.AllowDrop = true;
			this.cmdProducts.BackColor = System.Drawing.SystemColors.Control;
			this.cmdProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdProducts.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdProducts.Location = new System.Drawing.Point(360, 16);
			this.cmdProducts.Name = "cmdProducts";
			this.cmdProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdProducts.Size = new System.Drawing.Size(25, 21);
			this.cmdProducts.TabIndex = 5;
			this.cmdProducts.TabStop = false;
			this.cmdProducts.Text = "...";
			this.cmdProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdProducts.UseVisualStyleBackColor = false;
			this.cmdProducts.Click += new System.EventHandler(this.cmdProducts_Click);
			// 
			// txtName
			// 
			this.txtName.AcceptsReturn = true;
			this.txtName.AllowDrop = true;
			this.txtName.BackColor = System.Drawing.SystemColors.Window;
			this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtName.Location = new System.Drawing.Point(112, 40);
			this.txtName.MaxLength = 0;
			this.txtName.Name = "txtName";
			this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtName.Size = new System.Drawing.Size(145, 20);
			this.txtName.TabIndex = 1;
			this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
			// 
			// txtCode
			// 
			this.txtCode.AcceptsReturn = true;
			this.txtCode.AllowDrop = true;
			this.txtCode.BackColor = System.Drawing.SystemColors.Window;
			this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCode.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCode.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCode.Location = new System.Drawing.Point(112, 16);
			this.txtCode.MaxLength = 0;
			this.txtCode.Name = "txtCode";
			this.txtCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCode.Size = new System.Drawing.Size(97, 20);
			this.txtCode.TabIndex = 0;
			this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
			this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
			// 
			// lvProducts
			// 
			this.lvProducts.AllowDrop = true;
			this.lvProducts.BackColor = System.Drawing.SystemColors.Window;
			this.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lvProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lvProducts.ForeColor = System.Drawing.SystemColors.WindowText;
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
			this.lvProducts.View = System.Windows.Forms.View.Details;
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
			this.lvProducts_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_3_.Width = 97;
			// 
			// lvProducts_ColumnHeader_4_
			// 
			this.lvProducts_ColumnHeader_4_.Text = "Existence";
			this.lvProducts_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_4_.Width = 97;
			// 
			// lvProducts_ColumnHeader_5_
			// 
			this.lvProducts_ColumnHeader_5_.Text = "Ordered";
			this.lvProducts_ColumnHeader_5_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProducts_ColumnHeader_5_.Width = 97;
			// 
			// lvProducts_ColumnHeader_6_
			// 
			this.lvProducts_ColumnHeader_6_.Text = "Qty per Unit";
			this.lvProducts_ColumnHeader_6_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(16, 40);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 9;
			this.Label4.Text = "Name";
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(16, 16);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Code";
			// 
			// lvProductsBy
			// 
			this.lvProductsBy.AllowDrop = true;
			this.lvProductsBy.BackColor = System.Drawing.SystemColors.Window;
			this.lvProductsBy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lvProductsBy.CheckBoxes = true;
			this.lvProductsBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lvProductsBy.ForeColor = System.Drawing.SystemColors.WindowText;
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
			this.lvProductsBy.View = System.Windows.Forms.View.Details;
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
			this.lvProductsBy_ColumnHeader_3_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProductsBy_ColumnHeader_3_.Width = 61;
			// 
			// lvProductsBy_ColumnHeader_4_
			// 
			this.lvProductsBy_ColumnHeader_4_.Text = "Quantity per Unit";
			this.lvProductsBy_ColumnHeader_4_.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.lvProductsBy_ColumnHeader_4_.Width = 94;
			// 
			// lblProductsRelated
			// 
			this.lblProductsRelated.AllowDrop = true;
			this.lblProductsRelated.BackColor = System.Drawing.SystemColors.Control;
			this.lblProductsRelated.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblProductsRelated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblProductsRelated.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblProductsRelated.Location = new System.Drawing.Point(8, 248);
			this.lblProductsRelated.Name = "lblProductsRelated";
			this.lblProductsRelated.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblProductsRelated.Size = new System.Drawing.Size(409, 17);
			this.lblProductsRelated.TabIndex = 10;
			this.lblProductsRelated.Text = "Products";
			// 
			// frmAddProductTo
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(424, 511);
			this.Controls.Add(this.chkAll);
			this.Controls.Add(this.cmdRemove);
			this.Controls.Add(this.sbStatusBar);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.lvProductsBy);
			this.Controls.Add(this.lblProductsRelated);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 25);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmAddProductTo";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Create New Product Item";
			this.Activated += new System.EventHandler(this.frmAddProductTo_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
			this.listViewHelper1.SetItemClickMethod(this.lvProducts, "lvProducts_ItemClick");
			this.listViewHelper1.SetCorrectEventsBehavior(this.lvProducts, true);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
			this.sbStatusBar.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.lvProducts.ResumeLayout(false);
			this.lvProductsBy.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
	}
}