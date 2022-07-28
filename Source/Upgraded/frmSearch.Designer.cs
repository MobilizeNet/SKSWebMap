
namespace SKS
{
	partial class frmSearch
	{

		#region "Upgrade Support "
		private static frmSearch m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSearch DefInstance
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
		public static frmSearch CreateInstance()
		{
			frmSearch theInstance = new frmSearch();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "cmdClose", "cmdSearch", "ctrlLiner1", "cboSrchBy", "txtSrchStr", "Label20", "Label19", "Image3", "Label1", "lblSrchBy", "commandButtonHelper1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Button cmdClose;
		public System.Windows.Forms.Button cmdSearch;
		public System.Windows.Forms.PictureBox ctrlLiner1;
		public System.Windows.Forms.ComboBox cboSrchBy;
		public System.Windows.Forms.TextBox txtSrchStr;
		public System.Windows.Forms.Label Label20;
		public System.Windows.Forms.Label Label19;
		public System.Windows.Forms.PictureBox Image3;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblSrchBy;
		public UpgradeHelpers.Gui.CommandButtonHelper commandButtonHelper1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.cmdClose = new System.Windows.Forms.Button();
			this.cmdSearch = new System.Windows.Forms.Button();
			this.ctrlLiner1 = new System.Windows.Forms.PictureBox();
			this.cboSrchBy = new System.Windows.Forms.ComboBox();
			this.txtSrchStr = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Image3 = new System.Windows.Forms.PictureBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblSrchBy = new System.Windows.Forms.Label();
			this.SuspendLayout();
			this.commandButtonHelper1 = new UpgradeHelpers.Gui.CommandButtonHelper(this.components);
			// 
			// cmdClose
			// 
			this.cmdClose.AllowDrop = true;
			this.cmdClose.BackColor = System.Drawing.SystemColors.Control;
			this.cmdClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdClose.Location = new System.Drawing.Point(272, 104);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdClose.Size = new System.Drawing.Size(81, 25);
			this.cmdClose.TabIndex = 8;
			this.cmdClose.Text = "&Close";
			this.cmdClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdClose.UseVisualStyleBackColor = false;
			this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
			// 
			// cmdSearch
			// 
			this.cmdSearch.AllowDrop = true;
			this.cmdSearch.BackColor = System.Drawing.SystemColors.Control;
			this.cmdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmdSearch.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdSearch.Location = new System.Drawing.Point(184, 104);
			this.cmdSearch.Name = "cmdSearch";
			this.cmdSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdSearch.Size = new System.Drawing.Size(81, 25);
			this.cmdSearch.TabIndex = 7;
			this.cmdSearch.Text = "&Search";
			this.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdSearch.UseVisualStyleBackColor = false;
			this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
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
			this.ctrlLiner1.Size = new System.Drawing.Size(385, 2);
			this.ctrlLiner1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			this.ctrlLiner1.TabIndex = 6;
			this.ctrlLiner1.TabStop = true;
			this.ctrlLiner1.Visible = true;
			// 
			// cboSrchBy
			// 
			this.cboSrchBy.AllowDrop = true;
			this.cboSrchBy.BackColor = System.Drawing.SystemColors.Window;
			this.cboSrchBy.CausesValidation = true;
			this.cboSrchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSrchBy.Enabled = true;
			this.cboSrchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cboSrchBy.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cboSrchBy.IntegralHeight = true;
			this.cboSrchBy.Location = new System.Drawing.Point(208, 144);
			this.cboSrchBy.Name = "cboSrchBy";
			this.cboSrchBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cboSrchBy.Size = new System.Drawing.Size(145, 21);
			this.cboSrchBy.Sorted = false;
			this.cboSrchBy.TabIndex = 3;
			this.cboSrchBy.TabStop = true;
			this.cboSrchBy.Visible = true;
			this.cboSrchBy.SelectedIndexChanged += new System.EventHandler(this.cboSrchBy_SelectedIndexChanged);
			// 
			// txtSrchStr
			// 
			this.txtSrchStr.AcceptsReturn = true;
			this.txtSrchStr.AllowDrop = true;
			this.txtSrchStr.BackColor = System.Drawing.SystemColors.Window;
			this.txtSrchStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSrchStr.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSrchStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtSrchStr.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtSrchStr.Location = new System.Drawing.Point(136, 72);
			this.txtSrchStr.MaxLength = 0;
			this.txtSrchStr.Name = "txtSrchStr";
			this.txtSrchStr.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtSrchStr.Size = new System.Drawing.Size(217, 19);
			this.txtSrchStr.TabIndex = 0;
			// 
			// Label20
			// 
			this.Label20.AllowDrop = true;
			this.Label20.AutoSize = true;
			this.Label20.BackColor = System.Drawing.Color.Transparent;
			this.Label20.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label20.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label20.Location = new System.Drawing.Point(49, 32);
			this.Label20.Name = "Label20";
			this.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label20.Size = new System.Drawing.Size(119, 13);
			this.Label20.TabIndex = 5;
			this.Label20.Text = "Search for a specific item";
			// 
			// Label19
			// 
			this.Label19.AllowDrop = true;
			this.Label19.AutoSize = true;
			this.Label19.BackColor = System.Drawing.Color.Transparent;
			this.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label19.Location = new System.Drawing.Point(49, 8);
			this.Label19.Name = "Label19";
			this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label19.Size = new System.Drawing.Size(50, 16);
			this.Label19.TabIndex = 4;
			this.Label19.Text = "Search";
			this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// Image3
			// 
			this.Image3.AllowDrop = true;
			this.Image3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Image3.Enabled = true;
			this.Image3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Image3.Image = (System.Drawing.Image) resources.GetObject("Image3.Image");
			this.Image3.Location = new System.Drawing.Point(8, 8);
			this.Image3.Name = "Image3";
			this.Image3.Size = new System.Drawing.Size(16, 16);
			this.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			this.Image3.Visible = true;
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label1.Location = new System.Drawing.Point(125, 144);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(62, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Search by:";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// lblSrchBy
			// 
			this.lblSrchBy.AllowDrop = true;
			this.lblSrchBy.AutoSize = true;
			this.lblSrchBy.BackColor = System.Drawing.SystemColors.Control;
			this.lblSrchBy.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblSrchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.lblSrchBy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.lblSrchBy.Location = new System.Drawing.Point(7, 72);
			this.lblSrchBy.Name = "lblSrchBy";
			this.lblSrchBy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSrchBy.Size = new System.Drawing.Size(116, 13);
			this.lblSrchBy.TabIndex = 1;
			this.lblSrchBy.Text = "Field";
			this.lblSrchBy.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// frmSearch
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(378, 173);
			this.Controls.Add(this.cmdClose);
			this.Controls.Add(this.cmdSearch);
			this.Controls.Add(this.ctrlLiner1);
			this.Controls.Add(this.cboSrchBy);
			this.Controls.Add(this.txtSrchStr);
			this.Controls.Add(this.Label20);
			this.Controls.Add(this.Label19);
			this.Controls.Add(this.Image3);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.lblSrchBy);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = (System.Drawing.Icon) resources.GetObject("frmSearch.Icon");
			this.Location = new System.Drawing.Point(486, 322);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSearch";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Search";
			this.Activated += new System.EventHandler(this.frmSearch_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.ResumeLayout(false);
		}
		#endregion
	}
}