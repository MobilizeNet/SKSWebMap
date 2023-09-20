using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmLogin
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmLogin m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmLogin DefInstance
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
      public static frmLogin CreateInstance()
      {
         frmLogin theInstance = new frmLogin();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "txtUserName", "cmdCancel", "txtPassword", "cmdOK", "_lblLabels_0", "_lblLabels_1", "lblLabels", "commandButtonHelper1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtUserName { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdCancel { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtPassword { get; set; }

      [Intercepted]
      public Mobilize.Web.Button cmdOK { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _lblLabels_0 { get; set; }

      [Intercepted]
      private Mobilize.Web.Label _lblLabels_1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label[] lblLabels { get; set; } = new Mobilize.Web.Label[2];

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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.txtUserName = new Mobilize.Web.TextBox();
         this.cmdCancel = new Mobilize.Web.Button();
         this.txtPassword = new Mobilize.Web.TextBox();
         this.cmdOK = new Mobilize.Web.Button();
         this._lblLabels_0 = new Mobilize.Web.Label();
         this._lblLabels_1 = new Mobilize.Web.Label();
         this.SuspendLayout();
         this.commandButtonHelper1 = new Stub._UpgradeHelpers.Gui.Controls.CommandButtonHelper(this.components);
         // 
         // txtUserName
         // 
         this.txtUserName.AcceptsReturn = true;
         this.txtUserName.AllowDrop = true;
         this.txtUserName.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtUserName.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtUserName.Properties().Cursor = null;
         this.txtUserName.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtUserName.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtUserName.Location = new System.Drawing.Point(118, 25);
         this.txtUserName.MaxLength = 0;
         this.txtUserName.Name = "txtUserName";
         this.txtUserName.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtUserName.Size = new System.Drawing.Size(155, 23);
         this.txtUserName.TabIndex = 1;
         // 
         // cmdCancel
         // 
         this.cmdCancel.AllowDrop = true;
         this.cmdCancel.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdCancel.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdCancel.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdCancel.Location = new System.Drawing.Point(196, 100);
         this.cmdCancel.Name = "cmdCancel";
         this.cmdCancel.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdCancel.Size = new System.Drawing.Size(76, 26);
         this.cmdCancel.TabIndex = 5;
         this.cmdCancel.Text = "Cancel";
         this.cmdCancel.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdCancel.UseVisualStyleBackColor = false;
         this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
         // 
         // txtPassword
         // 
         this.txtPassword.AcceptsReturn = true;
         this.txtPassword.AllowDrop = true;
         this.txtPassword.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtPassword.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtPassword.Properties().Cursor = null;
         this.txtPassword.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtPassword.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtPassword.Properties().ImeMode = Mobilize.Web.ImeMode.Disable;
         this.txtPassword.Location = new System.Drawing.Point(118, 51);
         this.txtPassword.MaxLength = 0;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = (char)42;
         this.txtPassword.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtPassword.Size = new System.Drawing.Size(155, 23);
         this.txtPassword.TabIndex = 3;
         // 
         // cmdOK
         // 
         this.cmdOK.AllowDrop = true;
         this.cmdOK.BackColor = Mobilize.Web.SystemColors.Control;
         this.cmdOK.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmdOK.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.cmdOK.Location = new System.Drawing.Point(89, 100);
         this.cmdOK.Name = "cmdOK";
         this.cmdOK.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.cmdOK.Size = new System.Drawing.Size(76, 26);
         this.cmdOK.TabIndex = 4;
         this.cmdOK.Text = "OK";
         this.cmdOK.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.cmdOK.UseVisualStyleBackColor = false;
         this.cmdOK.Click += new System.EventHandler(this.cmdOk_Click);
         // 
         // _lblLabels_0
         // 
         this._lblLabels_0.AllowDrop = true;
         this._lblLabels_0.BackColor = Mobilize.Web.SystemColors.Control;
         this._lblLabels_0.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._lblLabels_0.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._lblLabels_0.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this._lblLabels_0.Location = new System.Drawing.Point(39, 26);
         this._lblLabels_0.Name = "_lblLabels_0";
         this._lblLabels_0.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._lblLabels_0.Size = new System.Drawing.Size(72, 18);
         this._lblLabels_0.TabIndex = 0;
         this._lblLabels_0.Text = "&User Name:";
         // 
         // _lblLabels_1
         // 
         this._lblLabels_1.AllowDrop = true;
         this._lblLabels_1.BackColor = Mobilize.Web.SystemColors.Control;
         this._lblLabels_1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this._lblLabels_1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._lblLabels_1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this._lblLabels_1.Location = new System.Drawing.Point(39, 52);
         this._lblLabels_1.Name = "_lblLabels_1";
         this._lblLabels_1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._lblLabels_1.Size = new System.Drawing.Size(72, 18);
         this._lblLabels_1.TabIndex = 2;
         this._lblLabels_1.Text = "&Password:";
         // 
         // frmLogin
         // 
         this.AcceptButton = this.cmdOK;
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.CancelButton = this.cmdCancel;
         this.ClientSize = new System.Drawing.Size(289, 137);
         this.Controls.Add(this.txtUserName);
         this.Controls.Add(this.cmdCancel);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.cmdOK);
         this.Controls.Add(this._lblLabels_0);
         this.Controls.Add(this._lblLabels_1);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Icon = (Mobilize.Web.Icon)new Mobilize.Web.Icon("assets/images/SKS.frmLogin.frmLogin.Icon.png");
         this.Properties().Location = new System.Drawing.Point(189, 232);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmLogin";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.commandButtonHelper1.SetStyle(this.cmdCancel, 0);
         this.commandButtonHelper1.SetStyle(this.cmdOK, 0);
         this.Activated += new System.EventHandler(this.frmLogin_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.ResumeLayout(false);
      }

      void ReLoadForm(bool addEvents)
      {
         InitializelblLabels();
      }

      void InitializelblLabels()
      {
         this.lblLabels = new Mobilize.Web.Label[2];
         this.lblLabels[0] = _lblLabels_0;
         this.lblLabels[1] = _lblLabels_1;
      }
#endregion

   }

}