
namespace SKS
{
	partial class frmUsersManage
	{

		#region "Upgrade Support "
		private static frmUsersManage m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmUsersManage DefInstance
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
		public static frmUsersManage CreateInstance()
		{
			frmUsersManage theInstance = new frmUsersManage();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "lstAccounts_ColumnHeader_1_", "lstAccounts_ColumnHeader_2_", "lstAccounts_ColumnHeader_3_", "lstAccounts", "cmdClear", "cmdSave", "ctrlLiner1", "txtFullname", "txtPassword", "txtUsername", "cboLevel", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_3", "lblId", "Frame1", "cmdClose", "cmdEdit", "cmdDelete", "_Label1_4", "Label19", "Label4", "Image1", "Label1", "listViewHelper1", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.ColumnHeader lstAccounts_ColumnHeader_1_;
		public System.Windows.Forms.ColumnHeader lstAccounts_ColumnHeader_2_;
		public System.Windows.Forms.ColumnHeader lstAccounts_ColumnHeader_3_;
		public System.Windows.Forms.ListView lstAccounts;
		public System.Windows.Forms.Button cmdClear;
		public System.Windows.Forms.Button cmdSave;
		public System.Windows.Forms.PictureBox ctrlLiner1;
		public System.Windows.Forms.TextBox txtFullname;
		public System.Windows.Forms.TextBox txtPassword;
		public System.Windows.Forms.TextBox txtUsername;
		public System.Windows.Forms.ComboBox cboLevel;
		private System.Windows.Forms.Label _Label1_2;
		private System.Windows.Forms.Label _Label1_0;
		private System.Windows.Forms.Label _Label1_1;
		private System.Windows.Forms.Label _Label1_3;
		public System.Windows.Forms.Label lblId;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.Button cmdEdit;
		public System.Windows.Forms.Button cmdDelete;
		private System.Windows.Forms.Label _Label1_4;
		public System.Windows.Forms.Label Label19;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.PictureBox Image1;
		public System.Windows.Forms.Label[] Label1 = new System.Windows.Forms.Label[5];
		public UpgradeHelpers.Gui.ListViewHelper listViewHelper1;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManage));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.lstAccounts = new System.Windows.Forms.ListView();
			this.lstAccounts_ColumnHeader_1_ = new System.Windows.Forms.ColumnHeader();
			this.lstAccounts_ColumnHeader_2_ = new System.Windows.Forms.ColumnHeader();
			this.lstAccounts_ColumnHeader_3_ = new System.Windows.Forms.ColumnHeader();
			this.cmdClear = new System.Windows.Forms.Button();
			this.cmdSave = new System.Windows.Forms.Button();
			this.ctrlLiner1 = new System.Windows.Forms.PictureBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.cboLevel = new System.Windows.Forms.ComboBox();
			this._Label1_2 = new System.Windows.Forms.Label();
			this._Label1_0 = new System.Windows.Forms.Label();
			this._Label1_1 = new System.Windows.Forms.Label();
			this._Label1_3 = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdEdit = new System.Windows.Forms.Button();
			this.cmdDelete = new System.Windows.Forms.Button();
			this._Label1_4 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Image1 = new System.Windows.Forms.PictureBox();
			this.lstAccounts.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			this.listViewHelper1 = new UpgradeHelpers.Gui.ListViewHelper(this.components);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).BeginInit();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// lstAccounts
			// 
			this.lstAccounts.AllowDrop = true;
			this.lstAccounts.BackColor = System.Drawing.SystemColors.Window;
			this.lstAccounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lstAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lstAccounts.ForeColor = System.Drawing.SystemColors.WindowText;
			this.lstAccounts.FullRowSelect = true;
			this.lstAccounts.HideSelection = true;
			this.lstAccounts.LabelEdit = true;
			this.lstAccounts.Location = new System.Drawing.Point(0, 264);
			this.lstAccounts.MultiSelect = false;
			this.lstAccounts.Name = "lstAccounts";
			this.lstAccounts.Size = new System.Drawing.Size(337, 113);
			this.lstAccounts.TabIndex = 7;
			this.lstAccounts.View = System.Windows.Forms.View.Details;
			this.lstAccounts.Columns.Add(this.lstAccounts_ColumnHeader_1_);
			this.lstAccounts.Columns.Add(this.lstAccounts_ColumnHeader_2_);
			this.lstAccounts.Columns.Add(this.lstAccounts_ColumnHeader_3_);
			this.lstAccounts.DoubleClick += new System.EventHandler(this.lstAccounts_DoubleClick);
			// 
			// lstAccounts_ColumnHeader_1_
			// 
			this.lstAccounts_ColumnHeader_1_.Text = "UserId";
			this.lstAccounts_ColumnHeader_1_.Width = 97;
			// 
			// lstAccounts_ColumnHeader_2_
			// 
			this.lstAccounts_ColumnHeader_2_.Text = "Name";
			this.lstAccounts_ColumnHeader_2_.Width = 97;
			// 
			// lstAccounts_ColumnHeader_3_
			// 
			this.lstAccounts_ColumnHeader_3_.Text = "Level";
			this.lstAccounts_ColumnHeader_3_.Width = 97;
			// 
			// cmdClear
			// 
			this.cmdClear.AllowDrop = true;
			this.cmdClear.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClear.Location = new System.Drawing.Point(168, 232);
			this.cmdClear.Name = "cmdClear";
			this.cmdClear.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClear.Size = new System.Drawing.Size(81, 25);
			this.cmdClear.TabIndex = 5;
			this.cmdClear.Text = "&New";
			this.cmdClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClear.UseVisualStyleBackColor = false;
			this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
			// 
			// cmdSave
			// 
			this.cmdSave.AllowDrop = true;
			this.cmdSave.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSave.Location = new System.Drawing.Point(80, 232);
			this.cmdSave.Name = "cmdSave";
			this.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSave.Size = new System.Drawing.Size(81, 25);
			this.cmdSave.TabIndex = 4;
			this.cmdSave.Text = "&Save";
			this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSave.UseVisualStyleBackColor = false;
			this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
			// 
			// ctrlLiner1
			// 
			this.ctrlLiner1.AllowDrop = true;
			this.ctrlLiner1.BackColor = System.Drawing.SystemColors.Control;
			this.ctrlLiner1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ctrlLiner1.CausesValidation = true;
			this.ctrlLiner1.Dock = System.Windows.Forms.DockStyle.None;
			this.ctrlLiner1.Enabled = true;
			this.ctrlLiner1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.ctrlLiner1.Location = new System.Drawing.Point(0, 56);
			this.ctrlLiner1.Name = "ctrlLiner1";
			this.ctrlLiner1.Size = new System.Drawing.Size(313, 2);
			this.ctrlLiner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			this.ctrlLiner1.TabIndex = 15;
			this.ctrlLiner1.TabStop = true;
			this.ctrlLiner1.Visible = true;
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.txtFullname);
			this.Frame1.Controls.Add(this.txtPassword);
			this.Frame1.Controls.Add(this.txtUsername);
			this.Frame1.Controls.Add(this.cboLevel);
			this.Frame1.Controls.Add(this._Label1_2);
			this.Frame1.Controls.Add(this._Label1_0);
			this.Frame1.Controls.Add(this._Label1_1);
			this.Frame1.Controls.Add(this._Label1_3);
			this.Frame1.Controls.Add(this.lblId);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 64);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(329, 153);
			this.Frame1.TabIndex = 10;
			this.Frame1.Text = "User information";
			this.Frame1.Visible = true;
			// 
			// txtFullname
			// 
			this.txtFullname.AcceptsReturn = true;
			this.txtFullname.AllowDrop = true;
			this.txtFullname.BackColor = System.Drawing.SystemColors.Window;
			this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtFullname.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtFullname.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFullname.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtFullname.Location = new System.Drawing.Point(120, 88);
			this.txtFullname.MaxLength = 50;
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtFullname.Size = new System.Drawing.Size(193, 19);
			this.txtFullname.TabIndex = 2;
			this.txtFullname.Enter += new System.EventHandler(this.txtFullname_Enter);
			// 
			// txtPassword
			// 
			this.txtPassword.AcceptsReturn = true;
			this.txtPassword.AllowDrop = true;
			this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
			this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPassword.Font = new System.Drawing.Font("Wingdings", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 2);
			this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txtPassword.Location = new System.Drawing.Point(120, 56);
			this.txtPassword.MaxLength = 50;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = (char) 108;
			this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtPassword.Size = new System.Drawing.Size(193, 19);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
			// 
			// txtUsername
			// 
			this.txtUsername.AcceptsReturn = true;
			this.txtUsername.AllowDrop = true;
			this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
			this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtUsername.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtUsername.Location = new System.Drawing.Point(120, 24);
			this.txtUsername.MaxLength = 50;
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtUsername.Size = new System.Drawing.Size(193, 19);
			this.txtUsername.TabIndex = 0;
			this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
			// 
			// cboLevel
			// 
			this.cboLevel.AllowDrop = true;
			this.cboLevel.BackColor = System.Drawing.SystemColors.Window;
			this.cboLevel.CausesValidation = true;
			this.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLevel.Enabled = true;
			this.cboLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboLevel.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cboLevel.IntegralHeight = true;
			this.cboLevel.Location = new System.Drawing.Point(120, 120);
			this.cboLevel.Name = "cboLevel";
			this.cboLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cboLevel.Size = new System.Drawing.Size(193, 21);
			this.cboLevel.Sorted = false;
			this.cboLevel.TabIndex = 3;
			this.cboLevel.TabStop = true;
			this.cboLevel.Visible = true;
			// 
			// _Label1_2
			// 
			this._Label1_2.AllowDrop = true;
			this._Label1_2.AutoSize = true;
			this._Label1_2.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Label1_2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this._Label1_2.Location = new System.Drawing.Point(16, 88);
			this._Label1_2.Name = "_Label1_2";
			this._Label1_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_2.Size = new System.Drawing.Size(68, 13);
			this._Label1_2.TabIndex = 16;
			this._Label1_2.Text = "Full name: *";
			// 
			// _Label1_0
			// 
			this._Label1_0.AllowDrop = true;
			this._Label1_0.AutoSize = true;
			this._Label1_0.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Label1_0.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this._Label1_0.Location = new System.Drawing.Point(16, 32);
			this._Label1_0.Name = "_Label1_0";
			this._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_0.Size = new System.Drawing.Size(70, 13);
			this._Label1_0.TabIndex = 14;
			this._Label1_0.Text = "Username: *";
			// 
			// _Label1_1
			// 
			this._Label1_1.AllowDrop = true;
			this._Label1_1.AutoSize = true;
			this._Label1_1.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Label1_1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this._Label1_1.Location = new System.Drawing.Point(16, 56);
			this._Label1_1.Name = "_Label1_1";
			this._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_1.Size = new System.Drawing.Size(96, 13);
			this._Label1_1.TabIndex = 13;
			this._Label1_1.Text = "New password: *";
			// 
			// _Label1_3
			// 
			this._Label1_3.AllowDrop = true;
			this._Label1_3.AutoSize = true;
			this._Label1_3.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Label1_3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this._Label1_3.Location = new System.Drawing.Point(16, 120);
			this._Label1_3.Name = "_Label1_3";
			this._Label1_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_3.Size = new System.Drawing.Size(71, 13);
			this._Label1_3.TabIndex = 12;
			this._Label1_3.Text = "User level: *";
			// 
			// lblId
			// 
			this.lblId.AllowDrop = true;
			this.lblId.AutoSize = true;
			this.lblId.BackColor = System.Drawing.SystemColors.Control;
			this.lblId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblId.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.lblId.Location = new System.Drawing.Point(128, 24);
			this.lblId.Name = "lblId";
			this.lblId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblId.Size = new System.Drawing.Size(3, 13);
			this.lblId.TabIndex = 11;
			// 
			// cmdClose
			// 
			this.cmdClose.AllowDrop = true;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Location = new System.Drawing.Point(256, 232);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(81, 25);
			this.cmdClose.TabIndex = 6;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdEdit
			// 
			this.cmdEdit.AllowDrop = true;
			this.cmdEdit.BackColor = System.Drawing.SystemColors.Control;
			this.cmdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdEdit.Location = new System.Drawing.Point(168, 384);
			this.cmdEdit.Name = "cmdEdit";
			this.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdEdit.Size = new System.Drawing.Size(81, 25);
			this.cmdEdit.TabIndex = 8;
			this.cmdEdit.Text = "&Edit";
			this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdEdit.UseVisualStyleBackColor = false;
			this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
			// 
			// cmdDelete
			// 
			this.cmdDelete.AllowDrop = true;
			this.cmdDelete.BackColor = System.Drawing.SystemColors.Control;
			this.cmdDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdDelete.Location = new System.Drawing.Point(256, 384);
			this.cmdDelete.Name = "cmdDelete";
			this.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdDelete.Size = new System.Drawing.Size(81, 25);
			this.cmdDelete.TabIndex = 9;
			this.cmdDelete.Text = "&Delete";
			this.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdDelete.UseVisualStyleBackColor = false;
			this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
			// 
			// _Label1_4
			// 
			this._Label1_4.AllowDrop = true;
			this._Label1_4.AutoSize = true;
			this._Label1_4.BackColor = System.Drawing.SystemColors.Control;
			this._Label1_4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this._Label1_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._Label1_4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this._Label1_4.Location = new System.Drawing.Point(8, 392);
			this._Label1_4.Name = "_Label1_4";
			this._Label1_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Label1_4.Size = new System.Drawing.Size(95, 13);
			this._Label1_4.TabIndex = 19;
			this._Label1_4.Text = "* Required fields";
			// 
			// Label19
			// 
			this.Label19.AllowDrop = true;
			this.Label19.AutoSize = true;
			this.Label19.BackColor = System.Drawing.Color.Transparent;
			this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label19.Location = new System.Drawing.Point(48, 8);
			this.Label19.Name = "Label19";
			this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label19.Size = new System.Drawing.Size(34, 16);
			this.Label19.TabIndex = 18;
			this.Label19.Text = "User";
			this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label4.Location = new System.Drawing.Point(48, 32);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(176, 13);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Set user information and access level";
			// 
			// Image1
			// 
			this.Image1.AllowDrop = true;
			this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Image1.Cursor = new System.Windows.Forms.Cursor((new System.Drawing.Bitmap((System.Drawing.Image) resources.GetObject("Image1.Cursor"))).GetHicon());
			this.Image1.Enabled = true;
			this.Image1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Image1.Image = (System.Drawing.Image) resources.GetObject("Image1.Image");
			this.Image1.Location = new System.Drawing.Point(8, 8);
			this.Image1.Name = "Image1";
			this.Image1.Size = new System.Drawing.Size(32, 32);
			this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Image1.Visible = true;
			// 
			// frmUsersManage
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(341, 414);
			this.Controls.Add(this.lstAccounts);
			this.Controls.Add(this.cmdClear);
			this.Controls.Add(this.cmdSave);
			this.Controls.Add(this.ctrlLiner1);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cmdEdit);
			this.Controls.Add(this.cmdDelete);
			this.Controls.Add(this._Label1_4);
			this.Controls.Add(this.Label19);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Image1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmUsersManage.Icon");
			this.Location = new System.Drawing.Point(327, 144);
			this.MaximizeBox = false;
			this.MinimizeBox = true;
			this.Name = "frmUsersManage";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Users Management";
			this.ToolTipMain.SetToolTip(this.Image1, "View warnings");
			this.Activated += new System.EventHandler(this.frmUsersManage_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.listViewHelper1.SetCorrectEventsBehavior(this.lstAccounts, true);
			((System.ComponentModel.ISupportInitialize) this.listViewHelper1).EndInit();
			this.lstAccounts.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializeLabel1();
			//This form is an MDI child.
			//This code simulates the VB6 
			// functionality of automatically
			// loading and showing an MDI
			// child's parent.
			this.MdiParent = SKS.frmMain.DefInstance;
			SKS.frmMain.DefInstance.Show();
		}
		void InitializeLabel1()
		{
			this.Label1 = new System.Windows.Forms.Label[5];
			this.Label1[2] = _Label1_2;
			this.Label1[0] = _Label1_0;
			this.Label1[1] = _Label1_1;
			this.Label1[3] = _Label1_3;
			this.Label1[4] = _Label1_4;
		}
		#endregion
	}
}