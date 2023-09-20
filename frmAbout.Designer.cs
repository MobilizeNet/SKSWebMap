using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmAbout
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmAbout m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmAbout DefInstance
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
      public static frmAbout CreateInstance()
      {
         frmAbout theInstance = new frmAbout();
         theInstance.Form_Load();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "picIcon", "cmdOK", "_Line1_1", "lblDescription", "lblTitle", "_Line1_0", "lblVersion", "lblDisclaimer", "Line1", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox picIcon { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdOK { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Line1_1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblDescription { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblTitle { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _Line1_0 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblVersion { get; set; }

      [Intercepted]
      public Mobilize.Web.Label lblDisclaimer { get; set; }

      [Intercepted]
      public Mobilize.Web.Label[] Line1 { get; set; } = new Mobilize.Web.Label[2];

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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.picIcon = new Mobilize.Web.PictureBox();
         this.cmdOK = new Mobilize.Web.Button();
         this._Line1_1 = new Mobilize.Web.Label();
         this.lblDescription = new Mobilize.Web.Label();
         this.lblTitle = new Mobilize.Web.Label();
         this._Line1_0 = new Mobilize.Web.Label();
         this.lblVersion = new Mobilize.Web.Label();
         this.lblDisclaimer = new Mobilize.Web.Label();
         this.SuspendLayout();
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // picIcon
         // 
         this.picIcon.AllowDrop = true;
         this.picIcon.BackColor = Mobilize.Web.SystemColors.Control;
         this.picIcon.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.picIcon.Properties().CausesValidation = true;
         this.picIcon.Dock = Mobilize.Web.DockStyle.None;
         this.picIcon.Enabled = true;
         this.picIcon.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.picIcon.Image = "assets/images/SKS.frmAbout.picIcon.Image.png";
         this.picIcon.Location = new System.Drawing.Point(16, 16);
         this.picIcon.Name = "picIcon";
         this.picIcon.Size = new System.Drawing.Size(36, 36);
         this.picIcon.SizeMode = Mobilize.Web.PictureBoxSizeMode.AutoSize;
         this.picIcon.Properties().TabIndex = 1;
         this.picIcon.Properties().TabStop = true;
         this.picIcon.Visible = true;
         // 
         // cmdOK
         // 
         this.cmdOK.AllowDrop = true;
         this.cmdOK.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdOK.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdOK.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdOK.Location = new System.Drawing.Point(272, 208);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdOK.Size = new System.Drawing.Size(108, 23);
         this.cmdOK.TabIndex = 0;
         this.cmdOK.Text = "OK";
         this.cmdOK.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdOK.UseVisualStyleBackColor = false;
         this.cmdOK.Click += new System.EventHandler(this.cmdOk_Click);
         // 
         // _Line1_1
         // 
         this._Line1_1.AllowDrop = true;
         this._Line1_1.BackColor = System.Drawing.Color.Gray;
         this._Line1_1.BorderStyle = Mobilize.Web.BorderStyle.FixedSingle;
         this._Line1_1.Enabled = false;
         this._Line1_1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Line1_1.Location = new System.Drawing.Point(5, 147);
         this._Line1_1.Name = "_Line1_1";
         this._Line1_1.Size = new System.Drawing.Size(294, 1);
         this._Line1_1.Visible = true;
         // 
         // lblDescription
         // 
         this.lblDescription.AllowDrop = true;
         this.lblDescription.AutoSize = true;
         this.lblDescription.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblDescription.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblDescription.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblDescription.ForeColor = System.Drawing.Color.Black;
         this.lblDescription.Location = new System.Drawing.Point(164, 80);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblDescription.Size = new System.Drawing.Size(199, 13);
         this.lblDescription.TabIndex = 2;
         this.lblDescription.Text = "Order Processing Software by Mobilize.net";
         // 
         // lblTitle
         // 
         this.lblTitle.AllowDrop = true;
         this.lblTitle.AutoSize = true;
         this.lblTitle.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblTitle.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblTitle.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Bold | Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblTitle.ForeColor = System.Drawing.Color.Black;
         this.lblTitle.Location = new System.Drawing.Point(163, 24);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblTitle.Size = new System.Drawing.Size(122, 13);
         this.lblTitle.TabIndex = 4;
         this.lblTitle.Text = "Salmon King Seafood";
         // 
         // _Line1_0
         // 
         this._Line1_0.AllowDrop = true;
         this._Line1_0.BackColor = System.Drawing.Color.White;
         this._Line1_0.Enabled = false;
         this._Line1_0.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._Line1_0.Location = new System.Drawing.Point(6, 148);
         this._Line1_0.Name = "_Line1_0";
         this._Line1_0.Size = new System.Drawing.Size(293, 1);
         this._Line1_0.Visible = true;
         // 
         // lblVersion
         // 
         this.lblVersion.AllowDrop = true;
         this.lblVersion.AutoSize = true;
         this.lblVersion.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblVersion.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblVersion.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblVersion.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.lblVersion.Location = new System.Drawing.Point(163, 56);
         this.lblVersion.Name = "lblVersion";
         this.lblVersion.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblVersion.Size = new System.Drawing.Size(137, 13);
         this.lblVersion.TabIndex = 5;
         this.lblVersion.Text = "Version: Mobilize - WebMAP ";
         // 
         // lblDisclaimer
         // 
         this.lblDisclaimer.AllowDrop = true;
         this.lblDisclaimer.AutoSize = true;
         this.lblDisclaimer.BackColor = Mobilize.Web.SystemColors.Control;
         this.lblDisclaimer.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.lblDisclaimer.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.lblDisclaimer.ForeColor = System.Drawing.Color.Black;
         this.lblDisclaimer.Location = new System.Drawing.Point(17, 175);
         this.lblDisclaimer.Name = "lblDisclaimer";
         this.lblDisclaimer.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.lblDisclaimer.Size = new System.Drawing.Size(132, 13);
         this.lblDisclaimer.TabIndex = 3;
         this.lblDisclaimer.Text = "Copyright 2018 Mobilize.Net";
         // 
         // frmAbout
         // 
         this.AcceptButton = this.cmdOK;
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.CancelButton = this.cmdOK;
         this.ClientSize = new System.Drawing.Size(394, 237);
         this.Controls.Add(this.picIcon);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this._Line1_1);
         this.Controls.Add(this.lblDescription);
         this.Controls.Add(this.lblTitle);
         this.Controls.Add(this._Line1_0);
         this.Controls.Add(this.lblVersion);
         this.Controls.Add(this.lblDisclaimer);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.Properties().Location = new System.Drawing.Point(156, 129);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAbout";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Text = "About Salmon King Seafood";
         this.commandButtonHelper1.SetStyle(this.cmdOK, 0);
         this.Activated += new System.EventHandler(this.frmAbout_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         InitializeLine1();
      }

      void InitializeLine1()
      {
         this.Line1 = new Mobilize.Web.Label[2];
         this.Line1[1] = _Line1_1;
         this.Line1[0] = _Line1_0;
      }
#endregion

   }

}