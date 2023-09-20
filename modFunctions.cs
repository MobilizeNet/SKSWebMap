using Microsoft.VisualBasic;
using System;
using System.Collections.Specialized;
using System.Text;
using UpgradeHelpers.DB.ADO;
using UpgradeHelpers.Helpers;
using Mobilize.WebMap.Common.Attributes;
using Mobilize.Web.Extensions;

namespace SKS
{

   [Observable]
   internal static class modFunctions
   {

      internal static void AppendAND(dynamic filter)
      {
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(filter.RefValue) )
         {
            filter.RefValue = filter.RefValue + " AND ";
         }
      }

      internal static bool AddToCollection(OrderedDictionary col, string Item)
      {
         bool result = false;
         if ( !Exists(col, Item) )
         {
            col.Add(Item, Item);
            result = true;
         }
         return result;
      }

      internal static bool Exists(OrderedDictionary col, string Index)
      {
         object o = null;
         try
         {
            //UPGRADE_WARNING: (1068) col() of type Variant is being forced to Scalar. More Information: https://docs.mobilize.net/vbuc/ewis#1068
            o = col[Index];
         }
         catch
         {
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         return !Object.Equals(o, null);
      }

      internal static double DoubleValue(string strValue)
      {
         if ( Strings.Len(strValue) != 0 )
         {
            return Double.Parse(strValue);
         }
         else
         {
            return 0;
         }
      }

      internal static bool ValidateTextBoxDouble(Mobilize.Web.TextBox txBox, Mobilize.Web.Form parentForm)
      {
         bool result = false;
         try
         {
            DoubleValue(txBox.Text);
            return true;
         }
         catch
         {
            modMain.LogStatus("The value inserted is not valid", parentForm);
            txBox.Text = "";
            txBox.Focus();
            result = false;
         }
         return result;
      }

      internal static bool ValidateTextDouble(string text, Mobilize.Web.Form parentForm)
      {
         bool result = false;
         try
         {
            DoubleValue(text);
            return true;
         }
         catch
         {
            modMain.LogStatus("The value inserted is not valid", parentForm);
            result = false;
         }
         return result;
      }

      internal static void SelectAll(Mobilize.Web.TextBox txtBox)
      {
         txtBox.SelectionStart = 0;
         txtBox.SelectionLength = Strings.Len(txtBox.Text);
      }

      internal static int UpCase(int KeyAscii)
      {
         return Strings.Asc(Strings.Chr(KeyAscii).ToString().ToUpper()[0]);
      }

      //'''''''''''''''''''''''''''''''''
      //'' Combobox related functions '''
      //'''''''''''''''''''''''''''''''''
      internal static void LoadCombo(string Table, Mobilize.Web.ComboBox combo, string field, string valueField = "")
      {
         modConnection.ExecuteSql("Select * From " + Table);
         combo.Items.Clear();
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(valueField) )
         {
            while ( !modConnection.rs.EOF )
            {
               combo.AddItem(Convert.ToString(modConnection.rs[field]));
               combo.SetItemData(combo.GetNewIndex(), Convert.ToInt32(modConnection.rs[valueField]));
               modConnection.rs.MoveNext();
            }
         }
         else
         {
            while ( !modConnection.rs.EOF )
            {
               combo.AddItem(Convert.ToString(modConnection.rs[field]));
               modConnection.rs.MoveNext();
            }
         }
      //If strDefault <> Empty Then
      // combo = strDefault
      //End If
      }

      internal static bool ComboEmpty(Mobilize.Web.ComboBox combo, object strip = null, int Index = 0)
      {
         bool result = false;
         if ( combo.SelectedIndex == -1 )
         {
            result = true;
            Mobilize.Web.MessageBox.Show("Please select an option from the list", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Exclamation);
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !Index.Equals(0) )
            {
            //strip.SelectedItem = strip.Tabs(Index)
            }
            combo.Focus();
         }
         else
         {
            result = false;
         }
         return result;
      }

      internal static bool NoRecords(Mobilize.Web.ListView lstView, string Prompt = "")
      {
         if ( lstView.Items.Count == 0 || lstView.FocusedItem == null )
         {
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !String.IsNullOrEmpty(Prompt) )
            {
               Mobilize.Web.MessageBox.Show(Prompt, AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Exclamation);
            }
            return true;
         }
         else
         {
            return false;
         }
      }

      internal static string RcrdId(string Table, string Identifier = "", string FldNo = "")
      {
         int RcrdNo = 0;
         modConnection.ExecuteSql("Select * from " + Table + " order by " + FldNo + " ASC");
         if ( !modConnection.rs.EOF )
         {
            modConnection.rs.MoveLast();
            RcrdNo = Convert.ToInt32(Convert.ToDouble(modConnection.rs[FldNo]) + 1);
         }
         else
         {
            RcrdNo = 1;
         }
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(Identifier) )
         {
            return Identifier + RcrdNo.ToString() + DateTime.Today.ToString("MM");
         }
         else
         {
            return RcrdNo.ToString();
         }
      }

      //''''''''''''''''''''''''''''''''''''''''
      internal static void SearchShow(string Table, string fieldToSearch, string itemToSearch)
      {
         frmSearch.DefInstance.Search(Table, fieldToSearch, itemToSearch);
         frmSearch.DefInstance.ShowDialog();
      }

      internal static double ValBox(string Prompt, Mobilize.Web.PictureBox Icon, string Title = "", double Default = 0, string Header = "Value Box")
      {
         //With frmValue
         //    If Title <> Empty Then
         //       .Caption = Title
         //    Else
         //        .Caption = App.Title
         //    End If
         //    .lblHeader.Caption = StrConv(Header, vbUpperCase)
         //    .imgIcon.Picture = Icon.Picture
         //    .lblPrompt.Caption = Prompt
         //    .Default Val(Default)
         //    .Show vbModal
         //    ValBox = Val(.txtValue.Text)
         //    Unload frmValue
         //End With
         return 0;
      }

      internal static bool TextBoxEmpty(Mobilize.Web.TextBox stext, object TabObject = null, int TabIndex = 0)
      {
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         bool result = false;
         if ( String.IsNullOrEmpty(stext.Text.Trim()) || stext.Text == "  /  /    " )
         {
            result = true;
            Mobilize.Web.MessageBox.Show("You need to fill in all required fields", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Exclamation);
            //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
            if ( !TabIndex.Equals(0) )
            {
            //TabObject.SelectedItem = TabObject.Tabs(TabIndex)
            }
            stext.Focus();
         }
         else
         {
            result = false;
         }
         return result;
      }

      internal static bool TextBoxNumberEmpty(Mobilize.Web.TextBox textbox)
      {
         //if the input is not a numeric then true
         bool result = false;
         if ( !Mobilize.Web.Information.IsNumeric(textbox.Text) )
         {
            result = true;
            Mobilize.Web.MessageBox.Show("The field requires a numeric value.", AssemblyHelper.GetTitle(System.Reflection.Assembly.GetExecutingAssembly()), Mobilize.Web.MessageBoxButtons.OK, Mobilize.Web.MessageBoxIcon.Exclamation);
            textbox.Focus();
            SelectAll(textbox);
         }
         else
         {
            result = false;
         }
         return result;
      }

      //UPGRADE_NOTE: (7001) The following declaration (SaveDetection) seems to be dead code More Information: https://docs.mobilize.net/vbuc/ewis#7001
      //private void SaveDetection(string Reference, string Title, string Description, string Table)
      //{
      //modConnection.ExecuteSql2("Select * from " + Table);
      //modConnection.rs2.AddNew();
      //modConnection.rs2["record_no"] = Conversion.Val(RcrdId(Table, "", "record_no"));
      //modConnection.rs2["Reference"] = Reference;
      //modConnection.rs2["war_type"] = Title;
      //modConnection.rs2["Description"] = Description;
      //modConnection.rs2.Update();
      //}
      internal static string ExecErr(string Prompt, string PromptFld = "", string Table = "", string RcrdFld = "", string RcrdStr = "")
      {
         StringBuilder Rcrds = new StringBuilder();
         //UPGRADE_WARNING: (2080) IsEmpty was upgraded to a comparison and has a new behavior. More Information: https://docs.mobilize.net/vbuc/ewis#2080
         if ( !String.IsNullOrEmpty(Table) )
         {
            modConnection.ExecuteSql("Select * from " + Table + " where " + RcrdFld + " = '" + RcrdStr + "'");
            while ( !modConnection.rs.EOF )
            {
               Rcrds.Append(Convert.ToString(modConnection.rs[PromptFld]) + "; ");
               modConnection.rs.MoveNext();
            }
            return "Error: " + Prompt + Environment.NewLine + Environment.NewLine + "Related Records: " + Rcrds.ToString();
         }
         else
         {
            return Prompt;
         }
      }

   }

}