using System;
using System.Windows.Forms;

namespace SKS
{
	internal static class modMain
	{


		public static bool CurrentUserAdmin = false;
		public static string UserFullname = "";
		public static string UserLevel = "";
		public static string UserId = "";

		public static string ConnectionString = "";

		public static int DetectionType = 0;
		public static double n = 0;
		public static int i = 0;
		public static string s = "";
		public static System.DateTime d = DateTime.FromOADate(0);
		public static string msg = "";
		public static string ImgName = "", ImgSrc = "";

		//UPGRADE_WARNING: (1047) Application will terminate when Sub Main() finishes. More Information: https://docs.mobilize.net/vbuc/ewis#1047
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ConnectionString = "DRIVER=SQLite3 ODBC Driver; Database=Orders.db; LongNames=0; Timeout=1000; NoTXN=0; SyncPragma=NORMAL; StepAPI=0;";

			modConnection.OpenConnection();
			CurrentUserAdmin = true;
			UserFullname = "Allan Cantillo";
			UserLevel = "Administrator";
			UserId = "acantillo";
			Application.Run(frmMain.DefInstance);
		}

		internal static void LogStatus(string message, Form frm = null)
		{
			StatusStrip sb = null;
			sb = null;
			((ToolStripStatusLabel) frmMain.DefInstance.sbStatusBar.Items[0]).Text = message;
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
					if (((ToolStripStatusLabel) sb.Items[0]) != null)
					{
						((ToolStripStatusLabel) sb.Items[0]).Text = message;
					}
				}
			}
		}

		internal static void ClearLogStatus(Form frm = null)
		{
			LogStatus("", frm);
		}
	}
}