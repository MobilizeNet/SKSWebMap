
namespace SKS
{
	partial class frmSplash
	{

		#region "Upgrade Support "
		private static frmSplash m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmSplash DefInstance
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
		public static frmSplash CreateInstance()
		{
			frmSplash theInstance = new frmSplash();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "Timer1", "Image1"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public System.Windows.Forms.Timer Timer1;
		public System.Windows.Forms.PictureBox Image1;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(components);
			this.Image1 = new System.Windows.Forms.PictureBox();
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
			this.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Image1.Enabled = true;
			this.Image1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Image1.Image = (System.Drawing.Image) resources.GetObject("Image1.Image");
			this.Image1.Location = new System.Drawing.Point(0, 0);
			this.Image1.Name = "Image1";
			this.Image1.Size = new System.Drawing.Size(964, 642);
			this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Image1.Visible = true;
			// 
			// frmSplash
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(943, 613);
			this.Controls.Add(this.Image1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.Location = new System.Drawing.Point(17, 116);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSplash";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Activated += new System.EventHandler(this.frmSplash_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
			this.ResumeLayout(false);
		}
		#endregion
	}
}