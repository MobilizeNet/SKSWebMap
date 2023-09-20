using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmUsersManage
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmUsersManage m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmUsersManage DefInstance
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
      public static frmUsersManage CreateInstance()
      {
         frmUsersManage theInstance = new frmUsersManage();
         theInstance.Form_Load();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "lstAccounts_ColumnHeader_1_", "lstAccounts_ColumnHeader_2_", "lstAccounts_ColumnHeader_3_", "lstAccounts", "cmdClear", "cmdSave", "ctrlLiner1", "txtFullname", "txtPassword", "txtUsername", "cboLevel", "_Label1_2", "_Label1_0", "_Label1_1", "_Label1_3", "lblId", "Frame1", "cmdClose", "cmdEdit", "cmdDelete", "_Label1_4", "Label19", "Label4", "Image1", "Label1", "listViewHelper1", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_1_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_2_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListViewColumnHeader lstAccounts_ColumnHeader_3_ { get; set; }

      [Intercepted]
      public Mobilize.Web.ListView lstAccounts { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClear { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdSave { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox ctrlLiner1 { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtFullname { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtPassword { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtUsername { get; set; }

      [Intercepted]
      public Mobilize.Web.ComboBox cboLevel { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Label1_2 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Label1_0 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Label1_1 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Label1_3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblId { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdEdit { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdDelete { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Label1_4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label19 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox Image1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label[] Label1 { get; set; } = new Mobilize.Web.Label[5];

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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsersManage));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.lstAccounts = new Mobilize.Web.ListView();
         this.lstAccounts_ColumnHeader_1_ = new Mobilize.Web.ListViewColumnHeader();
         this.lstAccounts_ColumnHeader_2_ = new Mobilize.Web.ListViewColumnHeader();
         this.lstAccounts_ColumnHeader_3_ = new Mobilize.Web.ListViewColumnHeader();
         this.cmdClear = new Mobilize.Web.Button();
         this.cmdSave = new Mobilize.Web.Button();
         this.ctrlLiner1 = new Mobilize.Web.PictureBox();
         this.Frame1 = new Mobilize.Web.GroupBox();
         this.txtFullname = new Mobilize.Web.TextBox();
         this.txtPassword = new Mobilize.Web.TextBox();
         this.txtUsername = new Mobilize.Web.TextBox();
         this.cboLevel = new Mobilize.Web.ComboBox();
         this._Label1_2 = new Mobilize.Web.Label();
         this._Label1_0 = new Mobilize.Web.Label();
         this._Label1_1 = new Mobilize.Web.Label();
         this._Label1_3 = new Mobilize.Web.Label();
         this.lblId = new Mobilize.Web.Label();
         this.cmdClose = new Mobilize.Web.Button();
         this.cmdEdit = new Mobilize.Web.Button();
         this.cmdDelete = new Mobilize.Web.Button();
         this._Label1_4 = new Mobilize.Web.Label();
         this.Label19 = new Mobilize.Web.Label();
         this.Label4 = new Mobilize.Web.Label();
         this.Image1 = new Mobilize.Web.PictureBox();
         this.lstAccounts.SuspendLayout();
         this.Frame1.SuspendLayout();
         this.SuspendLayout();
         this.listViewHelper1 = new Mobilize.Web.ListView(this.components);
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // lstAccounts
         // 
         this.lstAccounts.AllowDrop = true;
         this.lstAccounts.BackColor = Mobilize.Web.SystemColors.Window;
         this.lstAccounts.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.lstAccounts.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lstAccounts.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.lstAccounts.FullRowSelect = true;
         this.lstAccounts.HideSelection = true;
         this.lstAccounts.LabelEdit = true;
         this.lstAccounts.Location = new System.Drawing.Point(0, 264);
         this.lstAccounts.MultiSelect = false;
         this.lstAccounts.Name = "lstAccounts";
         this.lstAccounts.Size = new System.Drawing.Size(337, 113);
         this.lstAccounts.TabIndex = 7;
         this.lstAccounts.View = Mobilize.Web.ListViewMode.Details;
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
         this.cmdClear.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClear.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdClear.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClear.Location = new System.Drawing.Point(168, 232);
         this.cmdClear.Name = "cmdClear";
         this.cmdClear.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdClear.Size = new System.Drawing.Size(81, 25);
         this.cmdClear.TabIndex = 5;
         this.cmdClear.Text = "&New";
         this.cmdClear.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClear.UseVisualStyleBackColor = false;
         this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
         // 
         // cmdSave
         // 
         this.cmdSave.AllowDrop = true;
         this.cmdSave.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSave.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdSave.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSave.Location = new System.Drawing.Point(80, 232);
         this.cmdSave.Name = "cmdSave";
         this.cmdSave.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdSave.Size = new System.Drawing.Size(81, 25);
         this.cmdSave.TabIndex = 4;
         this.cmdSave.Text = "&Save";
         this.cmdSave.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSave.UseVisualStyleBackColor = false;
         this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
         // 
         // ctrlLiner1
         // 
         this.ctrlLiner1.AllowDrop = true;
         this.ctrlLiner1.BackColor = Mobilize.Web.SystemColors.Control;
         this.ctrlLiner1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.ctrlLiner1.Properties().CausesValidation = true;
         this.ctrlLiner1.Dock = Mobilize.Web.DockStyle.None;
         this.ctrlLiner1.Enabled = true;
         this.ctrlLiner1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.ctrlLiner1.Location = new System.Drawing.Point(0, 56);
         this.ctrlLiner1.Name = "ctrlLiner1";
         this.ctrlLiner1.Size = new System.Drawing.Size(313, 2);
         this.ctrlLiner1.SizeMode = Mobilize.Web.PictureBoxSizeMode.Normal;
         this.ctrlLiner1.Properties().TabIndex = 15;
         this.ctrlLiner1.Properties().TabStop = true;
         this.ctrlLiner1.Visible = true;
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Frame1.Controls.Add(this.txtFullname);
         this.Frame1.Controls.Add(this.txtPassword);
         this.Frame1.Controls.Add(this.txtUsername);
         this.Frame1.Controls.Add(this.cboLevel);
         this.Frame1.Controls.Add(this._Label1_2);
         this.Frame1.Controls.Add(this._Label1_0);
         this.Frame1.Controls.Add(this._Label1_1);
         this.Frame1.Controls.Add(this._Label1_3);
         this.Frame1.Controls.Add(this.lblId);
         this.Frame1.Properties().Cursor = Stub._UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
         this.Frame1.Enabled = true;
         this.Frame1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 64);
         this.Frame1.Name = "Frame1";
         this.Frame1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(329, 153);
         this.Frame1.TabIndex = 10;
         this.Frame1.Text = "User information";
         this.Frame1.Visible = true;
         // 
         // txtFullname
         // 
         this.txtFullname.AcceptsReturn = true;
         this.txtFullname.AllowDrop = true;
         this.txtFullname.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtFullname.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtFullname.Properties().Cursor = null;
         this.txtFullname.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtFullname.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtFullname.Properties().ImeMode = Mobilize.Web.ImeMode.Disable;
         this.txtFullname.Location = new System.Drawing.Point(120, 88);
         this.txtFullname.MaxLength = 50;
         this.txtFullname.Name = "txtFullname";
         this.txtFullname.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtFullname.Size = new System.Drawing.Size(193, 19);
         this.txtFullname.TabIndex = 2;
         this.txtFullname.Enter += new System.EventHandler(this.txtFullname_Enter);
         // 
         // txtPassword
         // 
         this.txtPassword.AcceptsReturn = true;
         this.txtPassword.AllowDrop = true;
         this.txtPassword.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtPassword.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtPassword.Properties().Cursor = null;
         this.txtPassword.Font = new Mobilize.Web.Font("Wingdings", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 2);
         this.txtPassword.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtPassword.Properties().ImeMode = Mobilize.Web.ImeMode.Disable;
         this.txtPassword.Location = new System.Drawing.Point(120, 56);
         this.txtPassword.MaxLength = 50;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = (char)108;
         this.txtPassword.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtPassword.Size = new System.Drawing.Size(193, 19);
         this.txtPassword.TabIndex = 1;
         this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
         // 
         // txtUsername
         // 
         this.txtUsername.AcceptsReturn = true;
         this.txtUsername.AllowDrop = true;
         this.txtUsername.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtUsername.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtUsername.Properties().Cursor = null;
         this.txtUsername.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtUsername.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtUsername.Location = new System.Drawing.Point(120, 24);
         this.txtUsername.MaxLength = 50;
         this.txtUsername.Name = "txtUsername";
         this.txtUsername.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtUsername.Size = new System.Drawing.Size(193, 19);
         this.txtUsername.TabIndex = 0;
         this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
         // 
         // cboLevel
         // 
         this.cboLevel.AllowDrop = true;
         this.cboLevel.BackColor = Mobilize.Web.SystemColors.Window;
         this.cboLevel.CausesValidation = true;
         this.cboLevel.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboLevel.Enabled = true;
         this.cboLevel.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cboLevel.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cboLevel.IntegralHeight = true;
         this.cboLevel.Location = new System.Drawing.Point(120, 120);
         this.cboLevel.Name = "cboLevel";
         this.cboLevel.RightToLeft = Mobilize.Web.RightToLeft.No;
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
         this._Label1_2.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_2.Location = new System.Drawing.Point(16, 88);
         this._Label1_2.Name = "_Label1_2";
         this._Label1_2.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._Label1_2.Size = new System.Drawing.Size(68, 13);
         this._Label1_2.TabIndex = 16;
         this._Label1_2.Text = "Full name: *";
         // 
         // _Label1_0
         // 
         this._Label1_0.AllowDrop = true;
         this._Label1_0.AutoSize = true;
         this._Label1_0.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_0.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_0.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_0.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_0.Location = new System.Drawing.Point(16, 32);
         this._Label1_0.Name = "_Label1_0";
         this._Label1_0.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._Label1_0.Size = new System.Drawing.Size(70, 13);
         this._Label1_0.TabIndex = 14;
         this._Label1_0.Text = "Username: *";
         // 
         // _Label1_1
         // 
         this._Label1_1.AllowDrop = true;
         this._Label1_1.AutoSize = true;
         this._Label1_1.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_1.Location = new System.Drawing.Point(16, 56);
         this._Label1_1.Name = "_Label1_1";
         this._Label1_1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._Label1_1.Size = new System.Drawing.Size(96, 13);
         this._Label1_1.TabIndex = 13;
         this._Label1_1.Text = "New password: *";
         // 
         // _Label1_3
         // 
         this._Label1_3.AllowDrop = true;
         this._Label1_3.AutoSize = true;
         this._Label1_3.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_3.Location = new System.Drawing.Point(16, 120);
         this._Label1_3.Name = "_Label1_3";
         this._Label1_3.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._Label1_3.Size = new System.Drawing.Size(71, 13);
         this._Label1_3.TabIndex = 12;
         this._Label1_3.Text = "User level: *";
         // 
         // lblId
         // 
         this.lblId.AllowDrop = true;
         this.lblId.AutoSize = true;
         this.lblId.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblId.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblId.Font = new Mobilize.Web.Font("Tahoma", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblId.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.lblId.Location = new System.Drawing.Point(128, 24);
         this.lblId.Name = "lblId";
         this.lblId.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblId.Size = new System.Drawing.Size(3, 13);
         this.lblId.TabIndex = 11;
         // 
         // cmdClose
         // 
         this.cmdClose.AllowDrop = true;
         this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(256, 232);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(81, 25);
         this.cmdClose.TabIndex = 6;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdEdit
         // 
         this.cmdEdit.AllowDrop = true;
         this.cmdEdit.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdEdit.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdEdit.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdEdit.Location = new System.Drawing.Point(168, 384);
         this.cmdEdit.Name = "cmdEdit";
         this.cmdEdit.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdEdit.Size = new System.Drawing.Size(81, 25);
         this.cmdEdit.TabIndex = 8;
         this.cmdEdit.Text = "&Edit";
         this.cmdEdit.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdEdit.UseVisualStyleBackColor = false;
         this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
         // 
         // cmdDelete
         // 
         this.cmdDelete.AllowDrop = true;
         this.cmdDelete.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdDelete.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdDelete.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdDelete.Location = new System.Drawing.Point(256, 384);
         this.cmdDelete.Name = "cmdDelete";
         this.cmdDelete.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdDelete.Size = new System.Drawing.Size(81, 25);
         this.cmdDelete.TabIndex = 9;
         this.cmdDelete.Text = "&Delete";
         this.cmdDelete.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdDelete.UseVisualStyleBackColor = false;
         this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
         // 
         // _Label1_4
         // 
         this._Label1_4.AllowDrop = true;
         this._Label1_4.AutoSize = true;
         this._Label1_4.BackColor = Mobilize.Web.SystemColors.Control;
         this._Label1_4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._Label1_4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Label1_4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this._Label1_4.Location = new System.Drawing.Point(8, 392);
         this._Label1_4.Name = "_Label1_4";
         this._Label1_4.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._Label1_4.Size = new System.Drawing.Size(95, 13);
         this._Label1_4.TabIndex = 19;
         this._Label1_4.Text = "* Required fields";
         // 
         // Label19
         // 
         this.Label19.AllowDrop = true;
         this.Label19.AutoSize = true;
         this.Label19.BackColor = System.Drawing.Color.Transparent;
         this.Label19.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label19.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 9.75f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label19.Location = new System.Drawing.Point(48, 8);
         this.Label19.Name = "Label19";
         this.Label19.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label19.Size = new System.Drawing.Size(34, 16);
         this.Label19.TabIndex = 18;
         this.Label19.Text = "User";
         this.Label19.TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.AutoSize = true;
         this.Label4.BackColor = System.Drawing.Color.Transparent;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label4.Location = new System.Drawing.Point(48, 32);
         this.Label4.Name = "Label4";
         this.Label4.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(176, 13);
         this.Label4.TabIndex = 17;
         this.Label4.Text = "Set user information and access level";
         // 
         // Image1
         // 
         this.Image1.AllowDrop = true;
         this.Image1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Image1.Properties().Cursor = null;
         this.Image1.Enabled = true;
         this.Image1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Image1.Image = "assets/images/SKS.frmUsersManage.Image1.Image.png";
         this.Image1.Location = new System.Drawing.Point(8, 8);
         this.Image1.Name = "Image1";
         this.Image1.Size = new System.Drawing.Size(32, 32);
         this.Image1.SizeMode = Mobilize.Web.PictureBoxSizeMode.StretchImage;
         this.Image1.Visible = true;
         // 
         // frmUsersManage
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.AutoScroll = true;
         this.BackColor = Mobilize.Web.SystemColors.Control;
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
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Icon = (Mobilize.Web.Icon)new Mobilize.Web.Icon("assets/images/SKS.frmUsersManage.frmUsersManage.Icon.png");
         this.Properties().Location = new System.Drawing.Point(327, 144);
         this.MaximizeBox = false;
         this.MinimizeBox = true;
         this.Name = "frmUsersManage";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.Manual;
         this.Text = "Users Management";
         this.commandButtonHelper1.SetStyle(this.cmdClear, 0);
         this.commandButtonHelper1.SetStyle(this.cmdSave, 0);
         this.commandButtonHelper1.SetStyle(this.cmdClose, 0);
         this.commandButtonHelper1.SetStyle(this.cmdEdit, 0);
         this.commandButtonHelper1.SetStyle(this.cmdDelete, 0);
         this.ToolTipMain.SetToolTip(this.Image1, "View warnings");
         this.Activated += new System.EventHandler(this.frmUsersManage_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.listViewHelper1.SetCorrectEventsBehavior(this.lstAccounts, true);
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
         this.Label1 = new Mobilize.Web.Label[5];
         this.Label1[2] = _Label1_2;
         this.Label1[0] = _Label1_0;
         this.Label1[1] = _Label1_1;
         this.Label1[3] = _Label1_3;
         this.Label1[4] = _Label1_4;
      }
#endregion

   }

}