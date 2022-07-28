using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Windows.Forms;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Gui;

namespace SKS
{
	internal partial class frmAddProductTo
		: System.Windows.Forms.Form
	{

		public frmAddProductTo()
			: base()
		{
			if (m_vb6FormDefInstance is null)
			{
				if (m_InitializingDefInstance)
				{
					m_vb6FormDefInstance = this;
				}
				else
				{
					try
					{
						//For the start-up form, the first instance created is the default instance.
						if (!(System.Reflection.Assembly.GetExecutingAssembly().EntryPoint is null) && System.Reflection.Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == this.GetType())
						{
							m_vb6FormDefInstance = this;
						}
					}
					catch
					{
					}
				}
			}
			//This call is required by the Windows Form Designer.
			InitializeComponent();
		}


		private void frmAddProductTo_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (UpgradeHelpers.Gui.ActivateHelper.myActiveForm != eventSender)
			{
				UpgradeHelpers.Gui.ActivateHelper.myActiveForm = (System.Windows.Forms.Form) eventSender;
			}
		}

		public int Id = 0;
		public string ObjectReferred = "";
		public string Table = "";
		public string ColumnName = "";

		public bool SavedChanges = false;
		private OrderedDictionary productsStored = null;
		private OrderedDictionary productsToDelete = null;
		private OrderedDictionary productsToAdd = null;
		private bool editingData = false;
		private string currentIdProduct = "";

		private bool codeGeneratedChange = false;

		private void chkAll_CheckStateChanged(Object eventSender, EventArgs eventArgs)
		{
			bool check = chkAll.CheckState == CheckState.Checked;
			int tempForEndVar = lvProductsBy.Items.Count;
			for (modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++)
			{
				lvProductsBy.Items[modMain.i - 1].Checked = check;
			}
		}

		private void cmdClose_Click(Object eventSender, EventArgs eventArgs)
		{
			this.Close();
		}

		private void cmdProducts_Click(Object eventSender, EventArgs eventArgs)
		{
			frmProducts.DefInstance.ShowDialog();
			txtCode.Text = frmProducts.DefInstance.CurrentProductID;
			txtName.Text = "";
			DoSearchProduct();
		}

		private void cmdRemove_Click(Object eventSender, EventArgs eventArgs)
		{
			string productIdToDelete = "";
			for (modMain.i = lvProductsBy.Items.Count; modMain.i >= 1; modMain.i--)
			{
				if (lvProductsBy.Items[modMain.i - 1].Checked)
				{
					productIdToDelete = lvProductsBy.Items[modMain.i - 1].Text;

					if (modFunctions.Exists(productsStored, productIdToDelete))
					{
						if (modFunctions.Exists(productsToAdd, productIdToDelete))
						{
							productsToDelete.Remove(productIdToDelete);
						}
						else
						{
							modFunctions.AddToCollection(productsToDelete, productIdToDelete);
						}
					}
					else
					{
						if (modFunctions.Exists(productsToAdd, currentIdProduct))
						{
							productsToAdd.Remove(currentIdProduct);
						}
					}

					lvProductsBy.Items.RemoveAt(modMain.i - 1);
					editingData = true;
				}
			}
		}

		private void cmdSave_Click(Object eventSender, EventArgs eventArgs)
		{

			if (productsToAdd.Count == 0 && productsToDelete.Count == 0)
			{
				editingData = true;
				MessageBox.Show("No data to be saved", "No data modified", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
				return;
			}
			SavedChanges = true;
			string productCode = "";
			foreach (string productCodeIterator in productsToAdd.Values)
			{
				productCode = productCodeIterator;
				modConnection.ExecuteSql("Insert into " + Table + "(" + ColumnName + ", ProductID) Values (" + Id.ToString() + ", '" + productCode + "')");
				productCode = default(string);
			}
			foreach (string productCodeIterator2 in productsToDelete.Values)
			{
				productCode = productCodeIterator2;
				modConnection.ExecuteSql("Delete from " + Table + " Where " + ColumnName + " = " + Id.ToString() + " And ProductID = '" + productCode + "'");
				productCode = default(string);
			}

			editingData = false;
			MessageBox.Show("Data was succesfully saved", "New data", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
			return;

			//UPGRADE_WARNING: (2081) Err.Number has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2081
			MessageBox.Show("An error has occurred adding the data. Error: (" + Information.Err().Number.ToString() + ") " + Information.Err().Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public void LoadData()
		{
			editingData = false;
			editingData = false;
			codeGeneratedChange = false;
			this.Text = "Add product(s) to " + ObjectReferred;
			lblProductsRelated.Text = "Products related to " + ObjectReferred;
			productsStored = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
			productsToDelete = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
			productsToAdd = new OrderedDictionary(System.StringComparer.OrdinalIgnoreCase);
			LoadProductsById();
		}

		private void Form_FormClosing(Object eventSender, FormClosingEventArgs eventArgs)
		{
			int Cancel = (eventArgs.Cancel) ? 1 : 0;
			int UnloadMode = (int) eventArgs.CloseReason;
			try
			{
				DialogResult res = (DialogResult) 0;
				if (editingData)
				{
					res = MessageBox.Show("Do you want to save the edited data?", "Save data", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
					if (res == System.Windows.Forms.DialogResult.Yes)
					{
						cmdSave_Click(cmdSave, new EventArgs());
					}
					else if (res != System.Windows.Forms.DialogResult.No)
					{ 
						Cancel = -1;
					}
				}
			}
			finally
			{
				eventArgs.Cancel = Cancel != 0;
			}
		}

		private void lvProducts_ItemClick(ListViewItem Item)
		{
			AddProductToSet();
		}

		private void txtCode_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			DoSearchProduct();
		}

		//Private Sub txtCode_KeyPress(KeyAscii As Integer)
		//KeyAscii = UpCase(KeyAscii)
		//End Sub

		private void txtCode_Leave(Object eventSender, EventArgs eventArgs)
		{
			if (lvProducts.Items.Count == 1)
			{
				AddProductToSet();
			}
		}

		private void txtName_TextChanged(Object eventSender, EventArgs eventArgs)
		{
			DoSearchProduct();
		}

		private void LoadProductsById()
		{
			string productCode = "";
			modConnection.ExecuteSql("Select p.ProductID, p.ProductName, p.UnitPrice, p.QuantityPerUnit, p.Unit from Products as p, " + Table + " as pb Where pb." + ColumnName + " = " + Id.ToString() + " And pb.ProductId = p.ProductId");

			modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
			ListViewItem x = null;
			if (modConnection.rs.RecordCount > 0)
			{
				while (!modConnection.rs.EOF)
				{
					//productCode = CStr(rs.Fields(0).value)
					productCode = Convert.ToString(modConnection.rs[0]);
					modFunctions.AddToCollection(productsStored, productCode);
					x = lvProductsBy.Items.Add(productCode);
					for (modMain.i = 1; modMain.i <= 2; modMain.i++)
					{
						//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
						if (!(modConnection.rs.GetField(modMain.i) is null))
						{
							ListViewHelper.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
						}
					}
					ListViewHelper.GetListViewSubItem(x, 3).Text = Convert.ToString(modConnection.rs[3]) + Convert.ToString(modConnection.rs[4]);
					modConnection.rs.MoveNext();
				}
			}
		}

		private void DoSearchProduct()
		{
			string filter = "";
			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
			if (!String.IsNullOrEmpty(txtCode.Text))
			{
				filter = "ProductId LIKE '%" + txtCode.Text + "%'";
			}
			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
			if (!String.IsNullOrEmpty(txtName.Text))
			{
				//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
				if (!String.IsNullOrEmpty(filter))
				{
					filter = filter + " AND ";
				}
				filter = filter + "ProductName LIKE '%" + txtName.Text + "%'";
			}
			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
			if (!String.IsNullOrEmpty(filter))
			{
				filter = "Where " + filter;
			}
			modConnection.ExecuteSql("Select ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, QuantityPerUnit, Unit from Products " + filter);
			lvProducts.Items.Clear();
			modMain.LogStatus("There are " + modConnection.rs.RecordCount.ToString() + " records with the selected criteria", this);
			ListViewItem x = null;
			if (modConnection.rs.RecordCount > 0)
			{
				while (!modConnection.rs.EOF)
				{
					x = lvProducts.Items.Add(Convert.ToString(modConnection.rs[0]));
					int tempForEndVar = (modConnection.rs.FieldsMetadata.Count - 1);
					for (modMain.i = 1; modMain.i <= tempForEndVar; modMain.i++)
					{
						//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
						if (!(modConnection.rs.GetField(modMain.i) is null))
						{
							ListViewHelper.GetListViewSubItem(x, modMain.i).Text = Convert.ToString(modConnection.rs[modMain.i]);
						}
					}
					modConnection.rs.MoveNext();
				}
				if (lvProducts.Items.Count == 1)
				{
					lvProducts.Items[lvProducts.Items[0].Index].Selected = true;
				}
			}
		}

		private void AddProductToSet()
		{

			ListViewItem y = null;
			int i = 0;
			bool found = false;
			ListViewItem x = null;
			//UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
			if (!(lvProducts.FocusedItem is null))
			{
				y = lvProducts.FocusedItem;
				currentIdProduct = lvProducts.FocusedItem.Text;
				found = false;
				int tempForEndVar = lvProductsBy.Items.Count;
				for (i = 1; i <= tempForEndVar; i++)
				{
					if (lvProductsBy.Items[i - 1].Text == currentIdProduct)
					{
						lvProductsBy.Items[lvProductsBy.Items[i - 1].Index].Selected = true;
						found = true;
						break;
					}
					else if (String.CompareOrdinal(lvProductsBy.Items[i - 1].Text, currentIdProduct) > 0)
					{ 
						break;
					}
				}
				if (!found)
				{
					editingData = true;
					if (!modFunctions.Exists(productsStored, currentIdProduct))
					{
						if (modFunctions.Exists(productsToDelete, currentIdProduct))
						{
							productsToDelete.Remove(currentIdProduct);
						}
						else
						{
							modFunctions.AddToCollection(productsToAdd, currentIdProduct);
						}
					}
					else
					{
						if (modFunctions.Exists(productsToDelete, currentIdProduct))
						{
							productsToDelete.Remove(currentIdProduct);
						}
					}
					x = lvProductsBy.Items.Insert(i - 1, currentIdProduct);
					ListViewHelper.GetListViewSubItem(x, 1).Text = ListViewHelper.GetListViewSubItem(y, 1).Text;
					ListViewHelper.GetListViewSubItem(x, 2).Text = ListViewHelper.GetListViewSubItem(y, 2).Text;
					ListViewHelper.GetListViewSubItem(x, 3).Text = ListViewHelper.GetListViewSubItem(y, 5).Text + ListViewHelper.GetListViewSubItem(y, 6).Text;
				}
			}
		}

		//UPGRADE_NOTE: (7001) The following declaration (ClearFields) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
		//private void ClearFields()
		//{
			//codeGeneratedChange = true;
			//txtCode.Text = "";
			//txtName.Text = "";
			//lvProducts.Items.Clear();
			//lvProductsBy.Items.Clear();
			//txtCode.Focus();
			//editingData = false;
			//codeGeneratedChange = false;
		//}
		private void Form_Closed(Object eventSender, EventArgs eventArgs)
		{
		}
	}
}