
namespace SKS
{
	partial class frmProducts
	{

		#region "Upgrade Support "
		private static frmProducts m_vb6FormDefInstance;
		private static bool m_InitializingDefInstance;
		public static frmProducts DefInstance
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
		public static frmProducts CreateInstance()
		{
			frmProducts theInstance = new frmProducts();
			theInstance.Form_Load();
			return theInstance;
		}
		private string[] visualControls = new string[]{"components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField"};
		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;
		public System.Windows.Forms.ToolTip ToolTipMain;
		private System.Windows.Forms.TextBox _txtField_6;
		private System.Windows.Forms.TextBox _txtField_0;
		private System.Windows.Forms.TextBox _txtField_5;
		public System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.TextBox _txtField_4;
		private System.Windows.Forms.TextBox _txtField_3;
		private System.Windows.Forms.TextBox _txtField_2;
		private System.Windows.Forms.TextBox _txtField_1;
		public System.Windows.Forms.CheckBox Check1;
		public System.Windows.Forms.TextBox txtCategory;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label11;
		public System.Windows.Forms.Label Label15;
		public System.Windows.Forms.GroupBox Frame1;
		public UpgradeHelpers.DB.ADO.ADODataControlHelper dcProducts;
		public System.Windows.Forms.ImageList ImageList1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button1;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button2;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button3;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button4;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button5;
		public System.Windows.Forms.ToolStripButton Toolbar1_Buttons_Button6;
		public System.Windows.Forms.ToolStrip Toolbar1;
		public System.Windows.Forms.TextBox[] txtField = new System.Windows.Forms.TextBox[7];
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
			this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._txtField_6 = new System.Windows.Forms.TextBox();
			this._txtField_0 = new System.Windows.Forms.TextBox();
			this._txtField_5 = new System.Windows.Forms.TextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this._txtField_4 = new System.Windows.Forms.TextBox();
			this._txtField_3 = new System.Windows.Forms.TextBox();
			this._txtField_2 = new System.Windows.Forms.TextBox();
			this._txtField_1 = new System.Windows.Forms.TextBox();
			this.Check1 = new System.Windows.Forms.CheckBox();
			this.txtCategory = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.dcProducts = new UpgradeHelpers.DB.ADO.ADODataControlHelper();
			this.ImageList1 = new System.Windows.Forms.ImageList();
			this.Toolbar1 = new System.Windows.Forms.ToolStrip();
			this.Toolbar1_Buttons_Button1 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button2 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button3 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button4 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button5 = new System.Windows.Forms.ToolStripButton();
			this.Toolbar1_Buttons_Button6 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize) this.dcProducts).BeginInit();
			this.Frame1.SuspendLayout();
			this.Toolbar1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Frame1
			// 
			this.Frame1.AllowDrop = true;
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this._txtField_6);
			this.Frame1.Controls.Add(this._txtField_0);
			this.Frame1.Controls.Add(this._txtField_5);
			this.Frame1.Controls.Add(this.cmbCategory);
			this.Frame1.Controls.Add(this._txtField_4);
			this.Frame1.Controls.Add(this._txtField_3);
			this.Frame1.Controls.Add(this._txtField_2);
			this.Frame1.Controls.Add(this._txtField_1);
			this.Frame1.Controls.Add(this.Check1);
			this.Frame1.Controls.Add(this.txtCategory);
			this.Frame1.Controls.Add(this.Label7);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.Label6);
			this.Frame1.Controls.Add(this.Label11);
			this.Frame1.Controls.Add(this.Label15);
			this.Frame1.Enabled = true;
			this.Frame1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(8, 48);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(433, 281);
			this.Frame1.TabIndex = 9;
			this.Frame1.Text = "Product information";
			this.Frame1.Visible = true;
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
			this._txtField_6.Location = new System.Drawing.Point(256, 240);
			this._txtField_6.MaxLength = 0;
			this._txtField_6.Name = "_txtField_6";
			this._txtField_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_6.Size = new System.Drawing.Size(105, 20);
			this._txtField_6.TabIndex = 20;
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
			this._txtField_0.MaxLength = 20;
			this._txtField_0.Name = "_txtField_0";
			this._txtField_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_0.Size = new System.Drawing.Size(113, 20);
			this._txtField_0.TabIndex = 0;
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
			this._txtField_5.Location = new System.Drawing.Point(104, 240);
			this._txtField_5.MaxLength = 0;
			this._txtField_5.Name = "_txtField_5";
			this._txtField_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_5.Size = new System.Drawing.Size(105, 20);
			this._txtField_5.TabIndex = 7;
			// 
			// cmbCategory
			// 
			this.cmbCategory.AllowDrop = true;
			this.cmbCategory.BackColor = System.Drawing.SystemColors.Window;
			this.cmbCategory.CausesValidation = true;
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.Enabled = true;
			this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cmbCategory.ForeColor = System.Drawing.SystemColors.WindowText;
			this.cmbCategory.IntegralHeight = true;
			this.cmbCategory.Location = new System.Drawing.Point(104, 117);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmbCategory.Size = new System.Drawing.Size(121, 21);
			this.cmbCategory.Sorted = false;
			this.cmbCategory.TabIndex = 3;
			this.cmbCategory.TabStop = true;
			this.cmbCategory.Visible = true;
			this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
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
			this._txtField_4.Location = new System.Drawing.Point(104, 210);
			this._txtField_4.MaxLength = 0;
			this._txtField_4.Name = "_txtField_4";
			this._txtField_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_4.Size = new System.Drawing.Size(105, 20);
			this._txtField_4.TabIndex = 6;
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
			this._txtField_3.Location = new System.Drawing.Point(104, 148);
			this._txtField_3.MaxLength = 0;
			this._txtField_3.Name = "_txtField_3";
			this._txtField_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_3.Size = new System.Drawing.Size(121, 20);
			this._txtField_3.TabIndex = 4;
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
			this._txtField_2.Location = new System.Drawing.Point(104, 88);
			this._txtField_2.MaxLength = 255;
			this._txtField_2.Name = "_txtField_2";
			this._txtField_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_2.Size = new System.Drawing.Size(305, 20);
			this._txtField_2.TabIndex = 2;
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
			this._txtField_1.Location = new System.Drawing.Point(104, 56);
			this._txtField_1.MaxLength = 50;
			this._txtField_1.Name = "_txtField_1";
			this._txtField_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._txtField_1.Size = new System.Drawing.Size(193, 20);
			this._txtField_1.TabIndex = 1;
			// 
			// Check1
			// 
			this.Check1.AllowDrop = true;
			this.Check1.Appearance = System.Windows.Forms.Appearance.Normal;
			this.Check1.BackColor = System.Drawing.SystemColors.Control;
			this.Check1.CausesValidation = true;
			this.Check1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Check1.CheckState = System.Windows.Forms.CheckState.Unchecked;
			this.Check1.Enabled = true;
			this.Check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Check1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Check1.Location = new System.Drawing.Point(104, 181);
			this.Check1.Name = "Check1";
			this.Check1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Check1.Size = new System.Drawing.Size(25, 17);
			this.Check1.TabIndex = 5;
			this.Check1.TabStop = true;
			this.Check1.Text = "";
			this.Check1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Check1.Visible = true;
			// 
			// txtCategory
			// 
			this.txtCategory.AcceptsReturn = true;
			this.txtCategory.AllowDrop = true;
			this.txtCategory.BackColor = System.Drawing.SystemColors.Window;
			this.txtCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCategory.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCategory.Location = new System.Drawing.Point(200, 120);
			this.txtCategory.MaxLength = 0;
			this.txtCategory.Name = "txtCategory";
			this.txtCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtCategory.Size = new System.Drawing.Size(10, 13);
			this.txtCategory.TabIndex = 16;
			this.txtCategory.TabStop = false;
			this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
			// 
			// Label7
			// 
			this.Label7.AllowDrop = true;
			this.Label7.BackColor = System.Drawing.SystemColors.Control;
			this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label7.Location = new System.Drawing.Point(216, 244);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(57, 17);
			this.Label7.TabIndex = 19;
			this.Label7.Text = "Unit";
			// 
			// Label3
			// 
			this.Label3.AllowDrop = true;
			this.Label3.BackColor = System.Drawing.SystemColors.Control;
			this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(16, 24);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(89, 17);
			this.Label3.TabIndex = 18;
			this.Label3.Text = "Product ";
			// 
			// Label2
			// 
			this.Label2.AllowDrop = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(16, 244);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(81, 17);
			this.Label2.TabIndex = 17;
			this.Label2.Text = "Qty per unit";
			// 
			// Label1
			// 
			this.Label1.AllowDrop = true;
			this.Label1.BackColor = System.Drawing.SystemColors.Control;
			this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(16, 56);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(89, 17);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Name";
			// 
			// Label4
			// 
			this.Label4.AllowDrop = true;
			this.Label4.BackColor = System.Drawing.SystemColors.Control;
			this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(16, 87);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(89, 17);
			this.Label4.TabIndex = 14;
			this.Label4.Text = "Desc";
			// 
			// Label5
			// 
			this.Label5.AllowDrop = true;
			this.Label5.BackColor = System.Drawing.SystemColors.Control;
			this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(16, 148);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(89, 17);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "Serial number";
			// 
			// Label6
			// 
			this.Label6.AllowDrop = true;
			this.Label6.BackColor = System.Drawing.SystemColors.Control;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(16, 210);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(81, 17);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Unit price";
			// 
			// Label11
			// 
			this.Label11.AllowDrop = true;
			this.Label11.BackColor = System.Drawing.SystemColors.Control;
			this.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label11.Location = new System.Drawing.Point(16, 118);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label11.Size = new System.Drawing.Size(89, 17);
			this.Label11.TabIndex = 11;
			this.Label11.Text = "Category";
			// 
			// Label15
			// 
			this.Label15.AllowDrop = true;
			this.Label15.BackColor = System.Drawing.SystemColors.Control;
			this.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label15.Location = new System.Drawing.Point(16, 179);
			this.Label15.Name = "Label15";
			this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label15.Size = new System.Drawing.Size(89, 17);
			this.Label15.TabIndex = 10;
			this.Label15.Text = "Discontinued";
			// 
			// dcProducts
			// 
			this.dcProducts.AllowDrop = true;
			this.dcProducts.BackColor = System.Drawing.SystemColors.Window;
			this.dcProducts.BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst;
			this.dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db";
			this.dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
			this.dcProducts.Enabled = true;
			this.dcProducts.EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
			this.dcProducts.FactoryName = "Access";
			this.dcProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.dcProducts.ForeColor = System.Drawing.SystemColors.WindowText;
			this.dcProducts.Location = new System.Drawing.Point(8, 336);
			this.dcProducts.LockType = UpgradeHelpers.DB.LockTypeEnum.LockOptimistic;
			this.dcProducts.Name = "dcProducts";
			this.dcProducts.Password = "";
			this.dcProducts.QueryTimeout = 30;
			this.dcProducts.QueryType = System.Data.CommandType.Text;
			this.dcProducts.RecordSource = "Select * from Products";
			this.dcProducts.Text = "Products";
			this.dcProducts.UserName = "";
			this.dcProducts.Width = 177;
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
			this.Toolbar1.Size = new System.Drawing.Size(448, 44);
			this.Toolbar1.TabIndex = 8;
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
			// frmProducts
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(448, 379);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.dcProducts);
			this.Controls.Add(this.Toolbar1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Location = new System.Drawing.Point(3, 25);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmProducts";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ShowInTaskbar = false;
			this.Text = "Products";
			this.Activated += new System.EventHandler(this.frmProducts_Activated);
			this.Closed += new System.EventHandler(this.Form_Closed);
			((System.ComponentModel.ISupportInitialize) this.dcProducts).EndInit();
			this.Frame1.ResumeLayout(false);
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
			this.txtField = new System.Windows.Forms.TextBox[7];
			this.txtField[6] = _txtField_6;
			this.txtField[0] = _txtField_0;
			this.txtField[5] = _txtField_5;
			this.txtField[4] = _txtField_4;
			this.txtField[3] = _txtField_3;
			this.txtField[2] = _txtField_2;
			this.txtField[1] = _txtField_1;
		}
		#endregion
		#region "Upgrade Support"
		public void VB6_AddADODataBinding()
		{
			dcProducts.Refresh();
			txtCategory.DataBindings.Add("Text", dcProducts, "CategoryID", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			Check1.DataBindings.Add("Checked", dcProducts, "Discontinued", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_1.DataBindings.Add("Text", dcProducts, "ProductName", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_2.DataBindings.Add("Text", dcProducts, "ProductDescription", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_3.DataBindings.Add("Text", dcProducts, "SerialNumber", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_5.DataBindings.Add("Text", dcProducts, "QuantityPerUnit", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_0.DataBindings.Add("Text", dcProducts, "ProductID", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
			_txtField_6.DataBindings.Add("Text", dcProducts, "Unit", false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
		}
		#endregion
	}
}