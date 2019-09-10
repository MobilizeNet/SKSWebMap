using System;
using Mobilize.WebMap.Common.Attributes;

namespace SKS
{

   [Observable]
   internal static class modMain
   {

      [Intercepted]


      public static bool CurrentUserAdmin { get; set; } = false;

      [Intercepted]
      public static string UserFullname { get; set; } = "";

      [Intercepted]
      public static string UserLevel { get; set; } = "";

      [Intercepted]
      public static string UserId { get; set; } = "";

      [Intercepted]

      public static string ConnectionString { get; set; } = "";

      [Intercepted]

      public static int DetectionType { get; set; } = 0;

      [Intercepted]
      public static double n { get; set; } = 0;

      [Intercepted]
      public static int i { get; set; } = 0;

      [Intercepted]
      public static string s { get; set; } = "";

      [Intercepted]
      public static System.DateTime d { get; set; } = DateTime.FromOADate(0);

      [Intercepted]
      public static string msg { get; set; } = "";

      [Intercepted]
      public static string ImgName { get; set; } = "";

      [Intercepted]
      public static string ImgSrc { get; set; } = "";





      //UPGRADE_WARNING: (1047) Application will terminate when Sub Main() finishes. More Information: https://www.mobilize.net/vbtonet/ewis/ewi1047

      [STAThread]
      public static void Main()
      {
         Stub._System.Windows.Forms.Application.EnableVisualStyles();
         Stub._System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
         ConnectionString = @"Data Source=.\Orders.db;Version=3;";

         modConnection.OpenConnection();
         CurrentUserAdmin = true;
         UserFullname = "Allan Cantillo";
         UserLevel = "Administrator";
         UserId = "acantillo";
         frmMain.DefInstance.Show();
         		}

      internal static void LogStatus(string message, Mobilize.Web.Form frm = null)
      {
         Mobilize.Web.StatusStrip sb = null;
         sb = null;
         ((Mobilize.Web.ToolStripStatusLabel) frmMain.DefInstance.sbStatusBar.Items[0]).Text = message;
         if (frm != null)
         {
         	if (frm == frmAdjustStockManual.DefInstance)
            {
            	sb = frmAdjustStockManual.DefInstance.sbStatusBar;
            }
            else if (frm == frmActionOrderReception.DefInstance)
            {
            	sb = frmActionOrderReception.DefInstance.sbStatusBar;
            }
            else if (frm == frmActionOrderRequest.DefInstance)
            {
            	sb = frmActionOrderRequest.DefInstance.sbStatusBar;
            }
            else if (frm == frmAddStockManual.DefInstance)
            {
            	sb = frmAddStockManual.DefInstance.sbStatusBar;
            }
            else if (frm == frmReceptionApproval.DefInstance)
            {
            	sb = frmReceptionApproval.DefInstance.sbStatusBar;
            }
            else if (frm == frmOrderReception.DefInstance)
            {
            	sb = frmOrderReception.DefInstance.sbStatusBar;
            }
            else if (frm == frmOrderRequest.DefInstance)
            {
            	sb = frmOrderRequest.DefInstance.sbStatusBar;
            }
            else if (frm == frmRequestApproval.DefInstance)
            {
            	sb = frmRequestApproval.DefInstance.sbStatusBar;
            }
            if (sb != null)
            {
            	if (((Mobilize.Web.ToolStripStatusLabel) sb.Items[0]) != null)
               {
               	((Mobilize.Web.ToolStripStatusLabel) sb.Items[0]).Text = message;
               }
            }
         }
      }

      internal static void ClearLogStatus(Mobilize.Web.Form frm = null)
      {
      	LogStatus("", frm);
      }

   }
}