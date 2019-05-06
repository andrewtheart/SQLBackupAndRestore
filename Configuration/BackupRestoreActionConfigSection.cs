using System;
using System.Configuration;

namespace SQLServerDatabaseBackup.Configuration
{
	public class BackupRestoreActionConfigSection : ConfigurationSection
	{
		public const string SECTION_NAME = "backupRestoreSetting";

		[ConfigurationProperty("BackupRestoreActions")]
		public BackupRestoreActionConfigCollection Servers
		{
			get
			{
				return base["BackupRestoreActions"] as BackupRestoreActionConfigCollection;
			}
		}

		public BackupRestoreActionConfigSection()
		{
		}
	}
}