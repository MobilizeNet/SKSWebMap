
namespace SKS
{
	partial class frmCustomers
	{

		#region "Upgrade Support "
		private static frmCustomers m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmCustomers DefInstance
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
		public static frmCustomers CreateInstance()
		{
			frmCustomers theInstance = new frmCustomers();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "dcCustomers", "_txtField_4", "_txtField_0", "_txtField_6", "_txtField_7", "_txtField_2", "_txtField_1", "_txtField_3", "_txtField_5", "_txtField_11", "_txtField_13", "_txtField_12", "Label7", "Label3", "Label2", "Frame2", "_txtField_8", "_txtField_10", "_txtField_14", "_txtField_9", "Label15", "Label14", "Label13", "Label12", "Label11", "Label10", "Label9", "Label8", "Label6", "Label5", "Label4", "Label1", "Frame1", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		public UpgradeHelpers.DB.ADO.ADODataControlHelper dcCustomers;
		private System.Windows.Forms.TextBox _txtField_4;
		private System.Windows.Forms.TextBox _txtField_0;
		private System.Windows.Forms.TextBox _txtField_6;
		private System.Windows.Forms.TextBox _txtField_7;
		private System.Windows.Forms.TextBox _txtField_2;
		private System.Windows.Forms.TextBox _txtField_1;
		private System.Windows.Forms.TextBox _txtField_3;
		private System.Windows.Forms.TextBox _txtField_5;
		private System.Windows.Forms.TextBox _txtField_11;
		private System.Windows.Forms.TextBox _txtField_13;
		private System.Windows.Forms.TextBox _txtField_12;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame2;
		private System.Windows.Forms.TextBox _txtField_8;
		private System.Windows.Forms.TextBox _txtField_10;
		private System.Windows.Forms.TextBox _txtField_14;
		private System.Windows.Forms.TextBox _txtField_9;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.Label Label14;
		public System.Windows.Forms.Label Label13;
		public System.Windows.Forms.Label Label12;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label10;
		public System.Windows.Forms.Label Label9;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.ImageList ImageList1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button2;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button3;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button4;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button5;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button6;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.TextBox[] txtField = new System.Windows.Forms.TextBox[15];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomers));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.dcCustomers = new UpgradeHelpers.DB.ADO.ADODataControlHelper();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._txtField_4 = new System.Windows.Forms.TextBox();
			this._txtField_0 = new System.Windows.Forms.TextBox();
			this._txtField_6 = new System.Windows.Forms.TextBox();
			this._txtField_7 = new System.Windows.Forms.TextBox();
			this._txtField_2 = new System.Windows.Forms.TextBox();
			this._txtField_1 = new System.Windows.Forms.TextBox();
			this._txtField_3 = new System.Windows.Forms.TextBox();
			this._txtField_5 = new System.Windows.Forms.TextBox();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this._txtField_11 = new System.Windows.Forms.TextBox();
			this._txtField_13 = new System.Windows.Forms.TextBox();
			this._txtField_12 = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this._txtField_8 = new System.Windows.Forms.TextBox();
			this._txtField_10 = new System.Windows.Forms.TextBox();
			this._txtField_14 = new System.Windows.Forms.TextBox();
			this._txtField_9 = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ImageList1 = new System.Windows.Forms.ImageList();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.Toolbar1_Buttons_Button1 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button2 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button3 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button4 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button5 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button6 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize) this.dcCustomers).BeginInit();
			this.Frame1.SuspendLayout();
			this.Frame2.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dcCustomers
			// 
			this.dcCustomers.AllowDrop = true;
			this.dcCustomers.BackColor = System.Drawing.SystemColors.Window;
			this.dcCustomers.BOFAction = UpgradeHelpers.DB.BOFActionEnum.BOF;
			this.dcCustomers.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db;";
			this.dcCustomers.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
			this.dcCustomers.Enabled = true;
			this.dcCustomers.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
			this.dcCustomers.FactoryName = "Access";
			this.dcCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dcCustomers.ForeColor = System.Drawing.SystemColors.WindowText;
			this.dcCustomers.Location = new System.Drawing.Point(8, 400);
			this.dcCustomers.LockType = UpgradeHelpers.DB.LockTypeEnum.LockPessimistic;
			this.dcCustomers.Name = "dcCustomers";
			this.dcCustomers.Password = "";
			this.dcCustomers.QueryTimeout = 30;
			this.dcCustomers.QueryType = System.Data.CommandType.Text;
			this.dcCustomers.RecordSource = "Select * from Customers;";
			this.dcCustomers.Text = "Customers";
			this.dcCustomers.UserName = "";
			this.dcCustomers.Width = 177;
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this._txtField_4);
			this.Frame1.Controls.Add(this._txtField_0);
			this.Frame1.Controls.Add(this._txtField_6);
			this.Frame1.Controls.Add(this._txtField_7);
			this.Frame1.Controls.Add(this._txtField_2);
			this.Frame1.Controls.Add(this._txtField_1);
			this.Frame1.Controls.Add(this._txtField_3);
			this.Frame1.Controls.Add(this._txtField_5);
			this.Frame1.Controls.Add(this.Frame2);
			this.Frame1.Controls.Add(this._txtField_8);
			this.Frame1.Controls.Add(this._txtField_10);
			this.Frame1.Controls.Add(this._txtField_14);
			this.Frame1.Controls.Add(this._txtField_9);
			this.Frame1.Controls.Add(this.Label15);
			this.Frame1.Controls.Add(this.Label14);
			this.Frame1.Controls.Add(this.Label13);
			this.Frame1.Controls.Add(this.Label12);
			this.Frame1.Controls.Add(this.Label11);
			this.Frame1.Controls.Add(this.Label10);
			this.Frame1.Controls.Add(this.Label9);
			this.Frame1.Controls.Add(this.Label8);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 48);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(433, 345);
			this.Frame1.TabIndex = 16;
			this.Frame1.Text = "Customer information";
			this.Frame1.Visible = true;
			// 
			// _txtField_4
			// 
			this._txtField_4.AcceptsReturn = true;
			this._txtField_4.AllowDrop = true;
			this._txtField_4.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_4.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_4.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_4.Location = new System.Drawing.Point(104, 148);
			this._txtField_4.MaxLength = 0;
			this._txtField_4.Name = "_txtField_4";
			this._txtField_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_4.Size = new System.Drawing.Size(105, 20);
			this._txtField_4.TabIndex = 7;
			this._txtField_4.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_0
			// 
			this._txtField_0.AcceptsReturn = true;
			this._txtField_0.AllowDrop = true;
			this._txtField_0.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_0.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_0.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_0.Location = new System.Drawing.Point(104, 24);
			this._txtField_0.MaxLength = 0;
			this._txtField_0.Name = "_txtField_0";
			this._txtField_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_0.Size = new System.Drawing.Size(105, 20);
			this._txtField_0.TabIndex = 0;
			this._txtField_0.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_6
			// 
			this._txtField_6.AcceptsReturn = true;
			this._txtField_6.AllowDrop = true;
			this._txtField_6.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_6.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_6.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_6.Location = new System.Drawing.Point(104, 209);
			this._txtField_6.MaxLength = 0;
			this._txtField_6.Name = "_txtField_6";
			this._txtField_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_6.Size = new System.Drawing.Size(105, 20);
			this._txtField_6.TabIndex = 9;
			this._txtField_6.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_7
			// 
			this._txtField_7.AcceptsReturn = true;
			this._txtField_7.AllowDrop = true;
			this._txtField_7.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_7.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_7.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_7.Location = new System.Drawing.Point(104, 240);
			this._txtField_7.MaxLength = 0;
			this._txtField_7.Name = "_txtField_7";
			this._txtField_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_7.Size = new System.Drawing.Size(105, 20);
			this._txtField_7.TabIndex = 10;
			this._txtField_7.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_2
			// 
			this._txtField_2.AcceptsReturn = true;
			this._txtField_2.AllowDrop = true;
			this._txtField_2.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_2.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_2.Location = new System.Drawing.Point(104, 86);
			this._txtField_2.MaxLength = 0;
			this._txtField_2.Name = "_txtField_2";
			this._txtField_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_2.Size = new System.Drawing.Size(105, 20);
			this._txtField_2.TabIndex = 2;
			this._txtField_2.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_1
			// 
			this._txtField_1.AcceptsReturn = true;
			this._txtField_1.AllowDrop = true;
			this._txtField_1.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_1.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_1.Location = new System.Drawing.Point(104, 55);
			this._txtField_1.MaxLength = 0;
			this._txtField_1.Name = "_txtField_1";
			this._txtField_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_1.Size = new System.Drawing.Size(105, 20);
			this._txtField_1.TabIndex = 1;
			this._txtField_1.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_3
			// 
			this._txtField_3.AcceptsReturn = true;
			this._txtField_3.AllowDrop = true;
			this._txtField_3.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_3.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_3.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_3.Location = new System.Drawing.Point(104, 117);
			this._txtField_3.MaxLength = 0;
			this._txtField_3.Name = "_txtField_3";
			this._txtField_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_3.Size = new System.Drawing.Size(313, 20);
			this._txtField_3.TabIndex = 6;
			this._txtField_3.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_5
			// 
			this._txtField_5.AcceptsReturn = true;
			this._txtField_5.AllowDrop = true;
			this._txtField_5.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_5.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_5.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_5.Location = new System.Drawing.Point(104, 178);
			this._txtField_5.MaxLength = 0;
			this._txtField_5.Name = "_txtField_5";
			this._txtField_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_5.Size = new System.Drawing.Size(105, 20);
			this._txtField_5.TabIndex = 8;
			this._txtField_5.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// Frame2
			// 
			this.Frame2.AllowDrop = true;
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this._txtField_11);
			this.Frame2.Controls.Add(this._txtField_13);
			this.Frame2.Controls.Add(this._txtField_12);
			this.Frame2.Controls.Add(this.Label7);
			this.Frame2.Controls.Add(this.Label3);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Enabled = true;
			this.Frame2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(224, 14);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(194, 97);
			this.Frame2.TabIndex = 28;
			this.Frame2.Text = "Contact";
			this.Frame2.Visible = true;
			// 
			// _txtField_11
			// 
			this._txtField_11.AcceptsReturn = true;
			this._txtField_11.AllowDrop = true;
			this._txtField_11.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_11.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_11.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_11.Location = new System.Drawing.Point(64, 16);
			this._txtField_11.MaxLength = 0;
			this._txtField_11.Name = "_txtField_11";
			this._txtField_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_11.Size = new System.Drawing.Size(121, 20);
			this._txtField_11.TabIndex = 3;
			this._txtField_11.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_13
			// 
			this._txtField_13.AcceptsReturn = true;
			this._txtField_13.AllowDrop = true;
			this._txtField_13.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_13.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_13.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_13.Location = new System.Drawing.Point(64, 64);
			this._txtField_13.MaxLength = 0;
			this._txtField_13.Name = "_txtField_13";
			this._txtField_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_13.Size = new System.Drawing.Size(121, 20);
			this._txtField_13.TabIndex = 5;
			this._txtField_13.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_12
			// 
			this._txtField_12.AcceptsReturn = true;
			this._txtField_12.AllowDrop = true;
			this._txtField_12.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_12.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_12.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_12.Location = new System.Drawing.Point(64, 40);
			this._txtField_12.MaxLength = 0;
			this._txtField_12.Name = "_txtField_12";
			this._txtField_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_12.Size = new System.Drawing.Size(121, 20);
			this._txtField_12.TabIndex = 4;
			this._txtField_12.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(8, 16);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(49, 17);
			this.Label7.TabIndex = 31;
			this.Label7.Text = "Title";
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(8, 69);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(57, 17);
			this.Label3.TabIndex = 30;
			this.Label3.Text = "Last name";
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(8, 43);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(57, 17);
			this.Label2.TabIndex = 29;
			this.Label2.Text = "First name";
			// 
			// _txtField_8
			// 
			this._txtField_8.AcceptsReturn = true;
			this._txtField_8.AllowDrop = true;
			this._txtField_8.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_8.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_8.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_8.Location = new System.Drawing.Point(312, 179);
			this._txtField_8.MaxLength = 0;
			this._txtField_8.Name = "_txtField_8";
			this._txtField_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_8.Size = new System.Drawing.Size(105, 20);
			this._txtField_8.TabIndex = 11;
			this._txtField_8.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_10
			// 
			this._txtField_10.AcceptsReturn = true;
			this._txtField_10.AllowDrop = true;
			this._txtField_10.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_10.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_10.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_10.Location = new System.Drawing.Point(312, 240);
			this._txtField_10.MaxLength = 0;
			this._txtField_10.Name = "_txtField_10";
			this._txtField_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_10.Size = new System.Drawing.Size(105, 20);
			this._txtField_10.TabIndex = 13;
			this._txtField_10.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_14
			// 
			this._txtField_14.AcceptsReturn = true;
			this._txtField_14.AllowDrop = true;
			this._txtField_14.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_14.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_14.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_14.Location = new System.Drawing.Point(16, 280);
			this._txtField_14.MaxLength = 0;
			this._txtField_14.Multiline = true;
			this._txtField_14.Name = "_txtField_14";
			this._txtField_14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_14.Size = new System.Drawing.Size(401, 52);
			this._txtField_14.TabIndex = 14;
			this._txtField_14.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// _txtField_9
			// 
			this._txtField_9.AcceptsReturn = true;
			this._txtField_9.AllowDrop = true;
			this._txtField_9.BackColor = System.Drawing.SystemColors.Window;
			this._txtField_9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this._txtField_9.Cursor = System.Windows.Forms.Cursors.IBeam;
			this._txtField_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this._txtField_9.ForeColor = System.Drawing.SystemColors.WindowText;
			this._txtField_9.Location = new System.Drawing.Point(312, 209);
			this._txtField_9.MaxLength = 0;
			this._txtField_9.Name = "_txtField_9";
			this._txtField_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_9.Size = new System.Drawing.Size(105, 20);
			this._txtField_9.TabIndex = 12;
			this._txtField_9.TextChanged += new System.EventHandler(this.txtField_TextChanged);
			// 
			// Label15
			// 
			this.Label15.AllowDrop = true;
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(16, 148);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(89, 17);
			this.Label15.TabIndex = 32;
			this.Label15.Text = "Zip";
			// 
			// Label14
			// 
			this.Label14.AllowDrop = true;
			this.Label14.BackColor = System.Drawing.SystemColors.Control;
			this.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label14.Location = new System.Drawing.Point(16, 240);
			this.Label14.Name = "Label14";
			this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label14.Size = new System.Drawing.Size(89, 17);
			this.Label14.TabIndex = 27;
			this.Label14.Text = "Country";
			// 
			// Label13
			// 
			this.Label13.AllowDrop = true;
			this.Label13.BackColor = System.Drawing.SystemColors.Control;
			this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label13.Location = new System.Drawing.Point(16, 209);
			this.Label13.Name = "Label13";
			this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label13.Size = new System.Drawing.Size(89, 17);
			this.Label13.TabIndex = 26;
			this.Label13.Text = "State/Prov";
			// 
			// Label12
			// 
			this.Label12.AllowDrop = true;
			this.Label12.BackColor = System.Drawing.SystemColors.Control;
			this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label12.Location = new System.Drawing.Point(16, 264);
			this.Label12.Name = "Label12";
			this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label12.Size = new System.Drawing.Size(89, 17);
			this.Label12.TabIndex = 25;
			this.Label12.Text = "Notes:";
			// 
			// Label11
			// 
			this.Label11.AllowDrop = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(16, 86);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(89, 17);
			this.Label11.TabIndex = 24;
			this.Label11.Text = "Email";
			// 
			// Label10
			// 
			this.Label10.AllowDrop = true;
			this.Label10.BackColor = System.Drawing.SystemColors.Control;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label10.Location = new System.Drawing.Point(232, 240);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label10.Size = new System.Drawing.Size(89, 17);
			this.Label10.TabIndex = 23;
			this.Label10.Text = "Fax";
			// 
			// Label9
			// 
			this.Label9.AllowDrop = true;
			this.Label9.BackColor = System.Drawing.SystemColors.Control;
			this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label9.Location = new System.Drawing.Point(232, 209);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label9.Size = new System.Drawing.Size(89, 17);
			this.Label9.TabIndex = 22;
			this.Label9.Text = "Ext";
			// 
			// Label8
			// 
			this.Label8.AllowDrop = true;
			this.Label8.BackColor = System.Drawing.SystemColors.Control;
			this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label8.Location = new System.Drawing.Point(232, 179);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(89, 17);
			this.Label8.TabIndex = 21;
			this.Label8.Text = "Phone";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(16, 178);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(89, 17);
			this.Label6.TabIndex = 20;
			this.Label6.Text = "City";
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(16, 117);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "Address";
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(16, 55);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Department";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(16, 24);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.TabIndex = 17;
			this.Label1.Text = "Company";
			// 
			// ImageList1
			// 
			this.ImageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.ImageList1.ImageStream = (System.Windows.Forms.ImageListStreamer) resources.GetObject("ImageList1.ImageStream");
			this.ImageList1.TransparentColor = System.Drawing.Color.White;
			this.ImageList1.Images.SetKeyName(0, "");
			this.ImageList1.Images.SetKeyName(1, "");
			this.ImageList1.Images.SetKeyName(2, "");
			this.ImageList1.Images.SetKeyName(3, "");
			this.ImageList1.Images.SetKeyName(4, "");
			this.ImageList1.Images.SetKeyName(5, "");
			// 
			// Toolbar1
			// 
			this.Toolbar1.AllowDrop = true;
			this.Toolbar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.Toolbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Toolbar1.ImageList = ImageList1;
			this.Toolbar1.Location = new System.Drawing.Point(0, 0);
			this.Toolbar1.Name = "Toolbar1";
			this.Toolbar1.ShowItemToolTips = true;
			this.Toolbar1.Size = new System.Drawing.Size(454, 44);
			this.Toolbar1.TabIndex = 15;
			this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button1);
			this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button2);
			this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button3);
			this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button4);
			this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button5);
			this.Toolbar1.Items.Add(this.Toolbar1_Buttons_Button6);
			// 
			// Toolbar1_Buttons_Button1
			// 
			this.Toolbar1_Buttons_Button1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.Toolbar1_Buttons_Button1.ImageIndex = 0;
			this.Toolbar1_Buttons_Button1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Toolbar1_Buttons_Button1.Size = new System.Drawing.Size(44, 39);
			this.Toolbar1_Buttons_Button1.Text = "Add";
			this.Toolbar1_Buttons_Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Toolbar1_Buttons_Button1.ToolTipText = "Create a new record";
			this.Toolbar1_Buttons_Button1.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button2
			// 
			this.Toolbar1_Buttons_Button2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.Toolbar1_Buttons_Button2.ImageIndex = 1;
			this.Toolbar1_Buttons_Button2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Toolbar1_Buttons_Button2.Size = new System.Drawing.Size(44, 39);
			this.Toolbar1_Buttons_Button2.Text = "Edit";
			this.Toolbar1_Buttons_Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Toolbar1_Buttons_Button2.ToolTipText = "Edit this record";
			this.Toolbar1_Buttons_Button2.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button3
			// 
			this.Toolbar1_Buttons_Button3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.Toolbar1_Buttons_Button3.ImageIndex = 2;
			this.Toolbar1_Buttons_Button3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Toolbar1_Buttons_Button3.Size = new System.Drawing.Size(44, 39);
			this.Toolbar1_Buttons_Button3.Text = "Save";
			this.Toolbar1_Buttons_Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Toolbar1_Buttons_Button3.ToolTipText = "Save the current changes";
			this.Toolbar1_Buttons_Button3.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button4
			// 
			this.Toolbar1_Buttons_Button4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.Toolbar1_Buttons_Button4.ImageIndex = 3;
			this.Toolbar1_Buttons_Button4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Toolbar1_Buttons_Button4.Size = new System.Drawing.Size(44, 39);
			this.Toolbar1_Buttons_Button4.Text = "Delete";
			this.Toolbar1_Buttons_Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Toolbar1_Buttons_Button4.ToolTipText = "Delete the current record";
			this.Toolbar1_Buttons_Button4.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button5
			// 
			this.Toolbar1_Buttons_Button5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.Toolbar1_Buttons_Button5.ImageIndex = 4;
			this.Toolbar1_Buttons_Button5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Toolbar1_Buttons_Button5.Size = new System.Drawing.Size(44, 39);
			this.Toolbar1_Buttons_Button5.Text = "Search";
			this.Toolbar1_Buttons_Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Toolbar1_Buttons_Button5.ToolTipText = "Search for a record";
			this.Toolbar1_Buttons_Button5.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
			// 
			// Toolbar1_Buttons_Button6
			// 
			this.Toolbar1_Buttons_Button6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
			this.Toolbar1_Buttons_Button6.ImageIndex = 5;
			this.Toolbar1_Buttons_Button6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.Toolbar1_Buttons_Button6.Size = new System.Drawing.Size(44, 39);
			this.Toolbar1_Buttons_Button6.Text = "Cancel";
			this.Toolbar1_Buttons_Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Toolbar1_Buttons_Button6.ToolTipText = "Cancel edited changes";
			this.Toolbar1_Buttons_Button6.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
			// 
			// frmCustomers
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(454, 443);
			this.Controls.Add(this.dcCustomers);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Toolbar1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(8, 30);
			this.MaximizeBox = true;
			this.MinimizeBox = true;
			this.Name = "frmCustomers";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Customers";
			this.Activated += new System.EventHandler(this.frmCustomers_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.dcCustomers).EndInit();
			this.Frame1.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			this.Toolbar1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		void ReLoadForm(bool addEvents)
		{
			InitializetxtField();
			VB6_AddADODataBinding();
		}
		void InitializetxtField()
		{
			this.txtField = new System.Windows.Forms.TextBox[15];
			this.txtField[4] = _txtField_4;
			this.txtField[0] = _txtField_0;
			this.txtField[6] = _txtField_6;
			this.txtField[7] = _txtField_7;
			this.txtField[2] = _txtField_2;
			this.txtField[1] = _txtField_1;
			this.txtField[3] = _txtField_3;
			this.txtField[5] = _txtField_5;
			this.txtField[11] = _txtField_11;
			this.txtField[13] = _txtField_13;
			this.txtField[12] = _txtField_12;
			this.txtField[8] = _txtField_8;
			this.txtField[10] = _txtField_10;
			this.txtField[14] = _txtField_14;
			this.txtField[9] = _txtField_9;
		}
		#endregion
		#region "Upgrade Support"
		public void VB6_AddADODataBinding()
		{
			dcCustomers.Refresh();
			_txtField_9.DataBindings.Add("Text", dcCustomers, "Extension", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_14.DataBindings.Add("Text", dcCustomers, "Notes", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_10.DataBindings.Add("Text", dcCustomers, "FaxNumber", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_8.DataBindings.Add("Text", dcCustomers, "PhoneNumber", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_12.DataBindings.Add("Text", dcCustomers, "ContactFirstName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_13.DataBindings.Add("Text", dcCustomers, "ContactLastName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_11.DataBindings.Add("Text", dcCustomers, "ContactTitle", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_5.DataBindings.Add("Text", dcCustomers, "City", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_3.DataBindings.Add("Text", dcCustomers, "BillingAddress", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_1.DataBindings.Add("Text", dcCustomers, "CompanyOrDepartment", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_2.DataBindings.Add("Text", dcCustomers, "EmailAddress", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_7.DataBindings.Add("Text", dcCustomers, "Country/Region", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_6.DataBindings.Add("Text", dcCustomers, "StateOrProvince", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_0.DataBindings.Add("Text", dcCustomers, "CompanyName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_4.DataBindings.Add("Text", dcCustomers, "PostalCode", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
		}
		#endregion
	}
}