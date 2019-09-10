using System;
using System.Data.Common;
using UpgradeHelpers.DB.ADO;
using Mobilize.WebMap.Common.Attributes;

namespace SKS
{

   [Observable]
   internal static class modConnection
   {

      [Intercepted]


      private static DbConnection _CurrentConnection { get; set; } = null;

      [Intercepted]
      internal static DbConnection CurrentConnection
      {
      	get
      	{
      		if (_CurrentConnection == null)
            {
            	_CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
            }
            return _CurrentConnection;
         }
         set
         {
            _CurrentConnection = value;
         }
      }

      [Intercepted]

      private static ADORecordSetHelper _rs { get; set; } = null;

      [Intercepted]
      internal static ADORecordSetHelper rs
      {
      	get
      	{
      		if (_rs == null)
            {
            	_rs = new ADORecordSetHelper("");
            }
            return _rs;
         }
         set
         {
            _rs = value;
         }
      }

      [Intercepted]

      private static ADORecordSetHelper _rs2 { get; set; } = null;

      [Intercepted]
      internal static ADORecordSetHelper rs2
      {
      	get
      	{
      		if (_rs2 == null)
            {
            	_rs2 = new ADORecordSetHelper("");
            }
            return _rs2;
         }
         set
         {
            _rs2 = value;
         }
      }


      internal static void OpenConnection()
      {
      	CurrentConnection = UpgradeHelpers.DB.AdoFactoryManager.GetFactory().CreateConnection();
      	//UPGRADE_TODO: (7010) The connection string must be verified to fullfill the .NET data provider connection string requirements. More Information: https://www.mobilize.net/vbtonet/ewis/ewi7010
      	CurrentConnection.ConnectionString = modMain.ConnectionString;
      	CurrentConnection.Open();
      }

      internal static void ExecuteSql(string Statement)
      {
      	rs = new ADORecordSetHelper("");
      	rs.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
      }

      internal static void ExecuteSql2(string Statement)
      {
      	rs2 = new ADORecordSetHelper("");
      	rs2.Open(Statement, CurrentConnection, UpgradeHelpers.DB.LockTypeEnum.LockPessimistic);
      }

   }
}