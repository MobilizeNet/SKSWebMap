using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmSplash
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmSplash m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmSplash DefInstance
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
      public static frmSplash CreateInstance()
      {
         frmSplash theInstance = new frmSplash();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "Timer1", "Image1" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      public Mobilize.Web.Timer Timer1 { get; set; }

      [Intercepted]
      public Mobilize.Web.PictureBox Image1 { get; set; }

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
         this.components = new Mobilize.Web.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.Timer1 = new Mobilize.Web.Timer(components);
         this.Image1 = new Mobilize.Web.PictureBox();
         this.SuspendLayout();
         // 
         // Timer1
         // 
         this.Timer1.Enabled = true;
         this.Timer1.Interval = 3000;
         this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
         // 
         // Image1
         // 
         this.Image1.AllowDrop = true;
         this.Image1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Image1.Enabled = true;
         this.Image1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Image1.Image = "assets/images/SKS.frmSplash.Image1.Image.png";
         this.Image1.Location = new System.Drawing.Point(0, 0);
         this.Image1.Name = "Image1";
         this.Image1.Size = new System.Drawing.Size(964, 642);
         this.Image1.SizeMode = Mobilize.Web.PictureBoxSizeMode.StretchImage;
         this.Image1.Visible = true;
         // 
         // frmSplash
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(943, 613);
         this.Controls.Add(this.Image1);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedDialog;
         this.KeyPreview = true;
         this.Properties().Location = new System.Drawing.Point(17, 116);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmSplash";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Properties().StartPosition = Mobilize.Web.FormStartPosition.CenterScreen;
         this.Activated += new System.EventHandler(this.frmSplash_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
         this.KeyPress += new Mobilize.Web.KeyPressEventHandler(this.Form_KeyPress);
         this.ResumeLayout(false);
      }
#endregion

   }

}