using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmSearch
   {

      [Intercepted]

      #region "Upgrade Support "
      private static frmSearch m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      [Intercepted]
      public static frmSearch DefInstance
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

      public static frmSearch CreateInstance()
      {
      	frmSearch theInstance = new frmSearch();
      	return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[]{"components", "ToolTipMain", "cmdClose", "cmdSearch", "ctrlLiner1", "cboSrchBy", "txtSrchStr", "Label20", "Label19", "Image3", "Label1", "lblSrchBy"};

      [Intercepted]
      //Required by the Windows Form Designer
      private
      System.ComponentModel.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdClose { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdSearch { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox ctrlLiner1 { get; set; }

      [Intercepted]
      public Mobilize.Web.ComboBox cboSrchBy { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtSrchStr { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label20 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label19 { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox Image3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblSrchBy { get; set; }
      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.

      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
      	this.components = new System.ComponentModel.Container();
      	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
      	this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
      	this.cmdClose = new Mobilize.Web.Button();
      	this.cmdSearch = new Mobilize.Web.Button();
      	this.ctrlLiner1 = new Mobilize.Web.PictureBox();
      	this.cboSrchBy = new Mobilize.Web.ComboBox();
      	this.txtSrchStr = new Mobilize.Web.TextBox();
      	this.Label20 = new Mobilize.Web.Label();
      	this.Label19 = new Mobilize.Web.Label();
      	this.Image3 = new Mobilize.Web.PictureBox();
      	this.Label1 = new Mobilize.Web.Label();
      	this.lblSrchBy = new Mobilize.Web.Label();
      	this.SuspendLayout();
      	// 
      	// cmdClose
      	// 
      	this.cmdClose.AllowDrop = true;
      	this.cmdClose.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdClose.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdClose.Location = new System.Drawing.Point(272, 104);
         this.cmdClose.Name = "cmdClose";
         this.cmdClose.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdClose.Size = new System.Drawing.Size(81, 25);
         this.cmdClose.TabIndex = 8;
         this.cmdClose.Text = "&Close";
         this.cmdClose.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdClose.UseVisualStyleBackColor = false;
         this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
         // 
         // cmdSearch
         // 
         this.cmdSearch.AllowDrop = true;
         this.cmdSearch.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdSearch.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdSearch.Location = new System.Drawing.Point(184, 104);
         this.cmdSearch.Name = "cmdSearch";
         this.cmdSearch.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.cmdSearch.Size = new System.Drawing.Size(81, 25);
         this.cmdSearch.TabIndex = 7;
         this.cmdSearch.Text = "&Search";
         this.cmdSearch.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdSearch.UseVisualStyleBackColor = false;
         this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
         // 
         // ctrlLiner1
         // 
         this.ctrlLiner1.AllowDrop = true;
         this.ctrlLiner1.BackColor = Mobilize.Web.SystemColors.Control;
         this.ctrlLiner1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.ctrlLiner1.Properties().CausesValidation = true;
         this.ctrlLiner1.Properties().Dock = Mobilize.Web.DockStyle.None;
         this.ctrlLiner1.Enabled = true;
         this.ctrlLiner1.Location = new System.Drawing.Point(0, 56);
         this.ctrlLiner1.Name = "ctrlLiner1";
         this.ctrlLiner1.Size = new System.Drawing.Size(385, 2);
         this.ctrlLiner1.SizeMode = Mobilize.Web.PictureBoxSizeMode.Normal;
         this.ctrlLiner1.Properties().TabIndex = 6;
         this.ctrlLiner1.Properties().TabStop = true;
         this.ctrlLiner1.Visible = true;
         // 
         // cboSrchBy
         // 
         this.cboSrchBy.AllowDrop = true;
         this.cboSrchBy.BackColor = Mobilize.Web.SystemColors.Window;
         this.cboSrchBy.CausesValidation = true;
         this.cboSrchBy.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cboSrchBy.Enabled = true;
         this.cboSrchBy.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cboSrchBy.IntegralHeight = true;
         this.cboSrchBy.Location = new System.Drawing.Point(208, 144);
         this.cboSrchBy.Name = "cboSrchBy";
         this.cboSrchBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
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
         this.txtSrchStr.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtSrchStr.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtSrchStr.Properties().Cursor = null;
         this.txtSrchStr.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtSrchStr.Location = new System.Drawing.Point(136, 72);
         this.txtSrchStr.MaxLength = 0;
         this.txtSrchStr.Name = "txtSrchStr";
         this.txtSrchStr.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.txtSrchStr.Size = new System.Drawing.Size(217, 19);
         this.txtSrchStr.TabIndex = 0;
         // 
         // Label20
         // 
         this.Label20.AllowDrop = true;
         this.Label20.AutoSize = true;
         this.Label20.BackColor = System.Drawing.Color.Transparent;
         this.Label20.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label20.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label20.Location = new System.Drawing.Point(49, 32);
         this.Label20.Name = "Label20";
         this.Label20.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label20.Size = new System.Drawing.Size(119, 13);
         this.Label20.TabIndex = 5;
         this.Label20.Text = "Search for a specific item";
         // 
         // Label19
         // 
         this.Label19.AllowDrop = true;
         this.Label19.AutoSize = true;
         this.Label19.BackColor = System.Drawing.Color.Transparent;
         this.Label19.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label19.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 9.75f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label19.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label19.Location = new System.Drawing.Point(49, 8);
         this.Label19.Name = "Label19";
         this.Label19.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label19.Size = new System.Drawing.Size(50, 16);
         this.Label19.TabIndex = 4;
         this.Label19.Text = "Search";
         this.Label19.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // Image3
         // 
         this.Image3.AllowDrop = true;
         this.Image3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Image3.Enabled = true;
         this.Image3.Image = "assets/images/SKS.frmSearch.Image3.Image.png";
         this.Image3.Location = new System.Drawing.Point(8, 8);
         this.Image3.Name = "Image3";
         this.Image3.Size = new System.Drawing.Size(16, 16);
         this.Image3.SizeMode = Mobilize.Web.PictureBoxSizeMode.Normal;
         this.Image3.Visible = true;
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.AutoSize = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.Label1.Location = new System.Drawing.Point(125, 144);
         this.Label1.Name = "Label1";
         this.Label1.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(62, 13);
         this.Label1.TabIndex = 2;
         this.Label1.Text = "Search by:";
         this.Label1.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         // 
         // lblSrchBy
         // 
         this.lblSrchBy.AllowDrop = true;
         this.lblSrchBy.AutoSize = true;
         this.lblSrchBy.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblSrchBy.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblSrchBy.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblSrchBy.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
         this.lblSrchBy.Location = new System.Drawing.Point(7, 72);
         this.lblSrchBy.Name = "lblSrchBy";
         this.lblSrchBy.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.lblSrchBy.Size = new System.Drawing.Size(116, 13);
         this.lblSrchBy.TabIndex = 1;
         this.lblSrchBy.Text = "Field";
         this.lblSrchBy.Properties().TextAlign = Mobilize.Web.ContentAlignment.TopRight;
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.Properties().ClientSize = new System.Drawing.Size(378, 173);
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
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Icon = null;
         this.Properties().Location = new System.Drawing.Point(486, 322);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmSearch";
         this.Properties().RightToLeft = Stub._System.Windows.Forms.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Search";
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);
      }
      #endregion

   }
}