using SQLServerDatabaseBackup.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SQLServerDatabaseBackup.Configuration
{
	public class BackupRestoreActionHandler
	{
		public List<BackupRestoreAction> actions { get; set; }
		
		public BackupRestoreActionHandler()
		{
			actions = new List<BackupRestoreAction>();
		}

		public List<BackupRestoreAction> getServerList()
		{
			List<BackupRestoreAction> serv = new List<BackupRestoreAction>();
			BackupRestoreActionConfigSection config = ConfigurationManager.GetSection("backupRestoreSetting") as BackupRestoreActionConfigSection;
            
			for (int i = 0; i < config.Servers.Count; i++)
			{
				var bra = new BackupRestoreAction()
				{
					fromDatabase = config.Servers[i].fromDatabase,
					toDatabase = config.Servers[i].toDatabase,
					fromServer = config.Servers[i].fromServer,
					toServer = config.Servers[i].toServer,
					replace = (config.Servers[i].replace.ToLower() == "true" ? true : false),
					description = config.Servers[i].description,
                    SQLusernameFromServer = config.Servers[i].SQLusernameFromServer,
                    SQLpasswordFromServer = config.Servers[i].SQLpasswordFromServer,
                    SQLusernameToServer = config.Servers[i].SQLusernameToServer,
                    SQLpasswordToServer = config.Servers[i].SQLpasswordToServer,
                    UseWindowsAuthenticationFromServer = config.Servers[i].UseWindowsAuthenticationFromServer,
                    UseWindowsAuthenticationToServer = config.Servers[i].UseWindowsAuthenticationToServer

                };

				serv.Add(bra);
			}
			return serv;
		}

		public void getServers()
		{
            actions = this.getServerList();
            modifyServerAttributes();
		}

		public void modifyServerAttributes()
		{
			foreach (BackupRestoreAction bActions in this.actions)
			{
				if (!bActions.replace)
				{
					BackupRestoreAction backupRestoreAction = bActions;
					string str = backupRestoreAction.toDatabase;
					DateTime now = DateTime.Now;
					backupRestoreAction.toDatabase = string.Concat(str, now.ToString("MMddyyyyHHmmss"));
				}
                else
                {
                    BackupRestoreAction backupRestoreAction = bActions;
                    string fromdb = backupRestoreAction.fromDatabase;
                    string str = backupRestoreAction.toDatabase;
                   
                    backupRestoreAction.toDatabase = fromdb;
                }
			}
		}
	}
}