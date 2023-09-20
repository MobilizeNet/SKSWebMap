using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   partial class frmProducts
   {

#region "Upgrade Support "
      [Intercepted]
      private static frmProducts m_vb6FormDefInstance { get; set; }

      [Intercepted]
      private static bool m_InitializingDefInstance { get; set; }

      public static frmProducts DefInstance
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
      public static frmProducts CreateInstance()
      {
         frmProducts theInstance = new frmProducts();
         theInstance.Form_Load();
         return theInstance;
      }

      [Intercepted]
      private string[] visualControls { get; set; } = new string[] { "components", "ToolTipMain", "_txtField_6", "_txtField_0", "_txtField_5", "cmbCategory", "_txtField_4", "_txtField_3", "_txtField_2", "_txtField_1", "Check1", "txtCategory", "Label7", "Label3", "Label2", "Label1", "Label4", "Label5", "Label6", "Label11", "Label15", "Frame1", "dcProducts", "ImageList1", "Toolbar1_Buttons_Button1", "Toolbar1_Buttons_Button2", "Toolbar1_Buttons_Button3", "Toolbar1_Buttons_Button4", "Toolbar1_Buttons_Button5", "Toolbar1_Buttons_Button6", "Toolbar1", "txtField" };

      //Required by the Windows Form Designer
      [Intercepted]
      private Mobilize.Web.Controls.Interfaces.IContainer components { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolTip ToolTipMain { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_6 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_0 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_5 { get; set; }

      [Intercepted]
      public Mobilize.Web.ComboBox cmbCategory { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_4 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_3 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_2 { get; set; }

      [Intercepted]
      private Mobilize.Web.TextBox _txtField_1 { get; set; }

      [Intercepted]
      public Mobilize.Web.CheckBox Check1 { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox txtCategory { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label7 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label3 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label2 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label1 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label4 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label5 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label6 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label11 { get; set; }

      [Intercepted]
      public Mobilize.Web.Label Label15 { get; set; }

      [Intercepted]
      public Mobilize.Web.GroupBox Frame1 { get; set; }

      [Intercepted]
      public Mobilize.Web.VBUC.ADODataControlHelper dcProducts { get; set; }

      [Intercepted]
      public Mobilize.Web.ImageList ImageList1 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button1 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button2 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button3 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button4 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button5 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStripButton Toolbar1_Buttons_Button6 { get; set; }

      [Intercepted]
      public Mobilize.Web.ToolStrip Toolbar1 { get; set; }

      [Intercepted]
      public Mobilize.Web.TextBox[] txtField { get; set; } = new Mobilize.Web.TextBox[7];

      //NOTE: The following procedure is required by the Windows Form Designer
      //It can be modified using the Windows Form Designer.
      //Do not modify it using the code editor.
      [System.Diagnostics.DebuggerStepThrough()]
      [Mobilize.WebMap.Common.Attributes.Designer]
      private void InitializeComponent()
      {
         this.components = new Mobilize.Web.ControlCollection();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducts));
         this.ToolTipMain = new Mobilize.Web.ToolTip(this.components);
         this.Frame1 = new Mobilize.Web.GroupBox();
         this._txtField_6 = new Mobilize.Web.TextBox();
         this._txtField_0 = new Mobilize.Web.TextBox();
         this._txtField_5 = new Mobilize.Web.TextBox();
         this.cmbCategory = new Mobilize.Web.ComboBox();
         this._txtField_4 = new Mobilize.Web.TextBox();
         this._txtField_3 = new Mobilize.Web.TextBox();
         this._txtField_2 = new Mobilize.Web.TextBox();
         this._txtField_1 = new Mobilize.Web.TextBox();
         this.Check1 = new Mobilize.Web.CheckBox();
         this.txtCategory = new Mobilize.Web.TextBox();
         this.Label7 = new Mobilize.Web.Label();
         this.Label3 = new Mobilize.Web.Label();
         this.Label2 = new Mobilize.Web.Label();
         this.Label1 = new Mobilize.Web.Label();
         this.Label4 = new Mobilize.Web.Label();
         this.Label5 = new Mobilize.Web.Label();
         this.Label6 = new Mobilize.Web.Label();
         this.Label11 = new Mobilize.Web.Label();
         this.Label15 = new Mobilize.Web.Label();
         this.dcProducts = new Mobilize.Web.VBUC.ADODataControlHelper();
         this.ImageList1 = new Mobilize.Web.ImageList();
         this.Toolbar1 = new Mobilize.Web.ToolStrip();
         this.Toolbar1_Buttons_Button1 = new Mobilize.Web.ToolStripButton();
         this.Toolbar1_Buttons_Button2 = new Mobilize.Web.ToolStripButton();
         this.Toolbar1_Buttons_Button3 = new Mobilize.Web.ToolStripButton();
         this.Toolbar1_Buttons_Button4 = new Mobilize.Web.ToolStripButton();
         this.Toolbar1_Buttons_Button5 = new Mobilize.Web.ToolStripButton();
         this.Toolbar1_Buttons_Button6 = new Mobilize.Web.ToolStripButton();
         this.Frame1.SuspendLayout();
         this.Toolbar1.SuspendLayout();
         this.SuspendLayout();
         // 
         // Frame1
         // 
         this.Frame1.AllowDrop = true;
         this.Frame1.BackColor = Mobilize.Web.SystemColors.Control;
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
         this.Frame1.Properties().Cursor = Stub._UpgradeHelpers.Helpers.CursorHelper.CursorDefault;
         this.Frame1.Enabled = true;
         this.Frame1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Frame1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Frame1.Location = new System.Drawing.Point(8, 48);
         this.Frame1.Name = "Frame1";
         this.Frame1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Frame1.Size = new System.Drawing.Size(433, 281);
         this.Frame1.TabIndex = 9;
         this.Frame1.Text = "Product information";
         this.Frame1.Visible = true;
         // 
         // _txtField_6
         // 
         this._txtField_6.AcceptsReturn = true;
         this._txtField_6.AllowDrop = true;
         this._txtField_6.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_6.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_6.Properties().Cursor = null;
         this._txtField_6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_6.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_6.Location = new System.Drawing.Point(256, 240);
         this._txtField_6.MaxLength = 0;
         this._txtField_6.Name = "_txtField_6";
         this._txtField_6.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_6.Size = new System.Drawing.Size(105, 20);
         this._txtField_6.TabIndex = 20;
         // 
         // _txtField_0
         // 
         this._txtField_0.AcceptsReturn = true;
         this._txtField_0.AllowDrop = true;
         this._txtField_0.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_0.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_0.Properties().Cursor = null;
         this._txtField_0.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_0.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_0.Location = new System.Drawing.Point(104, 24);
         this._txtField_0.MaxLength = 20;
         this._txtField_0.Name = "_txtField_0";
         this._txtField_0.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_0.Size = new System.Drawing.Size(113, 20);
         this._txtField_0.TabIndex = 0;
         // 
         // _txtField_5
         // 
         this._txtField_5.AcceptsReturn = true;
         this._txtField_5.AllowDrop = true;
         this._txtField_5.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_5.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_5.Properties().Cursor = null;
         this._txtField_5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_5.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_5.Location = new System.Drawing.Point(104, 240);
         this._txtField_5.MaxLength = 0;
         this._txtField_5.Name = "_txtField_5";
         this._txtField_5.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_5.Size = new System.Drawing.Size(105, 20);
         this._txtField_5.TabIndex = 7;
         // 
         // cmbCategory
         // 
         this.cmbCategory.AllowDrop = true;
         this.cmbCategory.BackColor = Mobilize.Web.SystemColors.Window;
         this.cmbCategory.CausesValidation = true;
         this.cmbCategory.DropDownStyle = Mobilize.Web.ComboBoxStyle.DropDownList;
         this.cmbCategory.Enabled = true;
         this.cmbCategory.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.cmbCategory.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.cmbCategory.IntegralHeight = true;
         this.cmbCategory.Location = new System.Drawing.Point(104, 117);
         this.cmbCategory.Name = "cmbCategory";
         this.cmbCategory.RightToLeft = Mobilize.Web.RightToLeft.No;
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
         this._txtField_4.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_4.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_4.Properties().Cursor = null;
         this._txtField_4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_4.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_4.Location = new System.Drawing.Point(104, 210);
         this._txtField_4.MaxLength = 0;
         this._txtField_4.Name = "_txtField_4";
         this._txtField_4.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_4.Size = new System.Drawing.Size(105, 20);
         this._txtField_4.TabIndex = 6;
         // 
         // _txtField_3
         // 
         this._txtField_3.AcceptsReturn = true;
         this._txtField_3.AllowDrop = true;
         this._txtField_3.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_3.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_3.Properties().Cursor = null;
         this._txtField_3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_3.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_3.Location = new System.Drawing.Point(104, 148);
         this._txtField_3.MaxLength = 0;
         this._txtField_3.Name = "_txtField_3";
         this._txtField_3.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_3.Size = new System.Drawing.Size(121, 20);
         this._txtField_3.TabIndex = 4;
         // 
         // _txtField_2
         // 
         this._txtField_2.AcceptsReturn = true;
         this._txtField_2.AllowDrop = true;
         this._txtField_2.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_2.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_2.Properties().Cursor = null;
         this._txtField_2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_2.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_2.Location = new System.Drawing.Point(104, 88);
         this._txtField_2.MaxLength = 255;
         this._txtField_2.Name = "_txtField_2";
         this._txtField_2.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_2.Size = new System.Drawing.Size(305, 20);
         this._txtField_2.TabIndex = 2;
         // 
         // _txtField_1
         // 
         this._txtField_1.AcceptsReturn = true;
         this._txtField_1.AllowDrop = true;
         this._txtField_1.BackColor = Mobilize.Web.SystemColors.Window;
         this._txtField_1.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this._txtField_1.Properties().Cursor = null;
         this._txtField_1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this._txtField_1.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this._txtField_1.Location = new System.Drawing.Point(104, 56);
         this._txtField_1.MaxLength = 50;
         this._txtField_1.Name = "_txtField_1";
         this._txtField_1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this._txtField_1.Size = new System.Drawing.Size(193, 20);
         this._txtField_1.TabIndex = 1;
         // 
         // Check1
         // 
         this.Check1.AllowDrop = true;
         this.Check1.Appearance = Mobilize.Web.Appearance.Normal;
         this.Check1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Check1.CausesValidation = true;
         this.Check1.CheckAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.Check1.CheckState = Mobilize.Web.CheckState.Unchecked;
         this.Check1.Enabled = true;
         this.Check1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Check1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Check1.Location = new System.Drawing.Point(104, 181);
         this.Check1.Name = "Check1";
         this.Check1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Check1.Size = new System.Drawing.Size(25, 17);
         this.Check1.TabIndex = 5;
         this.Check1.TabStop = true;
         this.Check1.Text = "";
         this.Check1.TextAlign = Mobilize.Web.ContentAlignment.MiddleLeft;
         this.Check1.Visible = true;
         // 
         // txtCategory
         // 
         this.txtCategory.AcceptsReturn = true;
         this.txtCategory.AllowDrop = true;
         this.txtCategory.BackColor = Mobilize.Web.SystemColors.Window;
         this.txtCategory.BorderStyle = Mobilize.Web.BorderStyle.Fixed3D;
         this.txtCategory.Properties().Cursor = null;
         this.txtCategory.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.txtCategory.ForeColor = Mobilize.Web.SystemColors.WindowText;
         this.txtCategory.Location = new System.Drawing.Point(200, 120);
         this.txtCategory.MaxLength = 0;
         this.txtCategory.Name = "txtCategory";
         this.txtCategory.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.txtCategory.Size = new System.Drawing.Size(10, 13);
         this.txtCategory.TabIndex = 16;
         this.txtCategory.TabStop = false;
         this.txtCategory.TextChanged += new System.EventHandler(this.txtCategory_TextChanged);
         // 
         // Label7
         // 
         this.Label7.AllowDrop = true;
         this.Label7.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label7.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label7.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label7.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label7.Location = new System.Drawing.Point(216, 244);
         this.Label7.Name = "Label7";
         this.Label7.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label7.Size = new System.Drawing.Size(57, 17);
         this.Label7.TabIndex = 19;
         this.Label7.Text = "Unit";
         // 
         // Label3
         // 
         this.Label3.AllowDrop = true;
         this.Label3.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label3.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label3.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label3.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label3.Location = new System.Drawing.Point(16, 24);
         this.Label3.Name = "Label3";
         this.Label3.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label3.Size = new System.Drawing.Size(89, 17);
         this.Label3.TabIndex = 18;
         this.Label3.Text = "Product ";
         // 
         // Label2
         // 
         this.Label2.AllowDrop = true;
         this.Label2.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label2.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label2.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label2.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label2.Location = new System.Drawing.Point(16, 244);
         this.Label2.Name = "Label2";
         this.Label2.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label2.Size = new System.Drawing.Size(81, 17);
         this.Label2.TabIndex = 17;
         this.Label2.Text = "Qty per unit";
         // 
         // Label1
         // 
         this.Label1.AllowDrop = true;
         this.Label1.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label1.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label1.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label1.Location = new System.Drawing.Point(16, 56);
         this.Label1.Name = "Label1";
         this.Label1.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label1.Size = new System.Drawing.Size(89, 17);
         this.Label1.TabIndex = 15;
         this.Label1.Text = "Name";
         // 
         // Label4
         // 
         this.Label4.AllowDrop = true;
         this.Label4.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label4.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label4.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label4.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label4.Location = new System.Drawing.Point(16, 87);
         this.Label4.Name = "Label4";
         this.Label4.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label4.Size = new System.Drawing.Size(89, 17);
         this.Label4.TabIndex = 14;
         this.Label4.Text = "Desc";
         // 
         // Label5
         // 
         this.Label5.AllowDrop = true;
         this.Label5.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label5.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label5.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label5.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label5.Location = new System.Drawing.Point(16, 148);
         this.Label5.Name = "Label5";
         this.Label5.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label5.Size = new System.Drawing.Size(89, 17);
         this.Label5.TabIndex = 13;
         this.Label5.Text = "Serial number";
         // 
         // Label6
         // 
         this.Label6.AllowDrop = true;
         this.Label6.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label6.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label6.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label6.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label6.Location = new System.Drawing.Point(16, 210);
         this.Label6.Name = "Label6";
         this.Label6.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label6.Size = new System.Drawing.Size(81, 17);
         this.Label6.TabIndex = 12;
         this.Label6.Text = "Unit price";
         // 
         // Label11
         // 
         this.Label11.AllowDrop = true;
         this.Label11.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label11.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label11.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label11.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label11.Location = new System.Drawing.Point(16, 118);
         this.Label11.Name = "Label11";
         this.Label11.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label11.Size = new System.Drawing.Size(89, 17);
         this.Label11.TabIndex = 11;
         this.Label11.Text = "Category";
         // 
         // Label15
         // 
         this.Label15.AllowDrop = true;
         this.Label15.BackColor = Mobilize.Web.SystemColors.Control;
         this.Label15.BorderStyle = Mobilize.Web.BorderStyle.None;
         this.Label15.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.Label15.ForeColor = Mobilize.Web.SystemColors.ControlText;
         this.Label15.Location = new System.Drawing.Point(16, 179);
         this.Label15.Name = "Label15";
         this.Label15.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Label15.Size = new System.Drawing.Size(89, 17);
         this.Label15.TabIndex = 10;
         this.Label15.Text = "Discontinued";
         // 
         // dcProducts
         // 
         this.dcProducts.AllowDrop = true;
         this.dcProducts.Properties().BackColor = Mobilize.Web.SystemColors.Window;
         this.dcProducts.Properties().BOFAction = UpgradeHelpers.DB.BOFActionEnum.MoveFirst;
         this.dcProducts.ConnectionString = "Driver=SQLite3 ODBC Driver; Database=Orders.db";
         this.dcProducts.CursorLocation = UpgradeHelpers.DB.ADO.CursorLocationEnum.adUseClient;
         this.dcProducts.Enabled = true;
         this.dcProducts.Properties().EOFAction = UpgradeHelpers.DB.EOFActionEnum.MoveLast;
         this.dcProducts.FactoryName = "Access";
         this.dcProducts.Properties().Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.dcProducts.Properties().ForeColor = Mobilize.Web.SystemColors.WindowText;
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
         this.ImageList1.ImageStream = "SKS.frmProducts.ImageList1.ImageStream";
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
         this.Toolbar1.Dock = Mobilize.Web.DockStyle.Top;
         this.Toolbar1.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
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
         this.Toolbar1_Buttons_Button1.DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button1.ImageIndex = 0;
         this.Toolbar1_Buttons_Button1.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button1.Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button1.Text = "Add";
         this.Toolbar1_Buttons_Button1.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button1.Properties().ToolTipText = "Create a new record";
         this.Toolbar1_Buttons_Button1.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button2
         // 
         this.Toolbar1_Buttons_Button2.DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button2.ImageIndex = 1;
         this.Toolbar1_Buttons_Button2.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button2.Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button2.Text = "Edit";
         this.Toolbar1_Buttons_Button2.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button2.Properties().ToolTipText = "Edit this record";
         this.Toolbar1_Buttons_Button2.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button3
         // 
         this.Toolbar1_Buttons_Button3.DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button3.ImageIndex = 2;
         this.Toolbar1_Buttons_Button3.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button3.Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button3.Text = "Save";
         this.Toolbar1_Buttons_Button3.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button3.Properties().ToolTipText = "Save the current changes";
         this.Toolbar1_Buttons_Button3.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button4
         // 
         this.Toolbar1_Buttons_Button4.DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button4.ImageIndex = 3;
         this.Toolbar1_Buttons_Button4.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button4.Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button4.Text = "Delete";
         this.Toolbar1_Buttons_Button4.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button4.Properties().ToolTipText = "Delete the current record";
         this.Toolbar1_Buttons_Button4.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button5
         // 
         this.Toolbar1_Buttons_Button5.DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button5.ImageIndex = 4;
         this.Toolbar1_Buttons_Button5.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button5.Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button5.Text = "Search";
         this.Toolbar1_Buttons_Button5.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button5.Properties().ToolTipText = "Search for a record";
         this.Toolbar1_Buttons_Button5.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // Toolbar1_Buttons_Button6
         // 
         this.Toolbar1_Buttons_Button6.DisplayStyle = Mobilize.Web.ToolStripItemDisplayStyle.ImageAndText;
         this.Toolbar1_Buttons_Button6.ImageIndex = 5;
         this.Toolbar1_Buttons_Button6.Properties().ImageScaling = Mobilize.Web.ToolStripItemImageScaling.None;
         this.Toolbar1_Buttons_Button6.Size = new System.Drawing.Size(44, 39);
         this.Toolbar1_Buttons_Button6.Text = "Cancel";
         this.Toolbar1_Buttons_Button6.TextImageRelation = Mobilize.Web.TextImageRelation.ImageAboveText;
         this.Toolbar1_Buttons_Button6.Properties().ToolTipText = "Cancel edited changes";
         this.Toolbar1_Buttons_Button6.Click += new System.EventHandler(this.Toolbar1_ButtonClick);
         // 
         // frmProducts
         // 
         this.AllowDrop = true;
         this.Properties().AutoScaleDimensions = new System.Drawing.SizeF(6, 13);
         this.Properties().AutoScaleMode = Stub._System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = Mobilize.Web.SystemColors.Control;
         this.ClientSize = new System.Drawing.Size(448, 379);
         this.Controls.Add(this.Frame1);
         this.Controls.Add(this.dcProducts);
         this.Controls.Add(this.Toolbar1);
         this.Font = new Mobilize.Web.Font("Microsoft Sans Serif", 8.25f, Mobilize.Web.FontStyle.Regular, Mobilize.Web.GraphicsUnit.Point, 0);
         this.FormBorderStyle = Mobilize.Web.FormBorderStyle.FixedSingle;
         this.Properties().Location = new System.Drawing.Point(3, 25);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmProducts";
         this.RightToLeft = Mobilize.Web.RightToLeft.No;
         this.Properties().ShowInTaskbar = false;
         this.Text = "Products";
         this.Activated += new System.EventHandler(this.frmProducts_Activated);
         this.Closed += new System.EventHandler(this.Form_Closed);
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
         this.txtField = new Mobilize.Web.TextBox[7];
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
         txtCategory.DataBindings.Add("Text", dcProducts, "CategoryID", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         Check1.DataBindings.Add("Checked", dcProducts, "Discontinued", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_1.DataBindings.Add("Text", dcProducts, "ProductName", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_2.DataBindings.Add("Text", dcProducts, "ProductDescription", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_3.DataBindings.Add("Text", dcProducts, "SerialNumber", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_4.DataBindings.Add("Text", dcProducts, "UnitPrice", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_5.DataBindings.Add("Text", dcProducts, "QuantityPerUnit", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_0.DataBindings.Add("Text", dcProducts, "ProductID", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
         _txtField_6.DataBindings.Add("Text", dcProducts, "Unit", false, Mobilize.Web.DataSourceUpdateMode.OnPropertyChanged);
      }
#endregion

   }

}