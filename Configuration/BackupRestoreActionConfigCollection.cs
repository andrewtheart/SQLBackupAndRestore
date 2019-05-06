using System.Collections.Generic;
using System.Configuration;

namespace SQLServerDatabaseBackup.Configuration
{
    [ConfigurationCollection(typeof(BackupRestoreActionConfigElement), AddItemName="BackupRestoreAction", CollectionType=ConfigurationElementCollectionType.BasicMap)]
	public class BackupRestoreActionConfigCollection : ConfigurationElementCollection
	{
		public BackupRestoreActionConfigElement this[int index]
		{
			get
			{
				return (BackupRestoreActionConfigElement)base.BaseGet(index);
			}
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				this.BaseAdd(index, value);
			}
		}

		public BackupRestoreActionConfigCollection()
		{
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new BackupRestoreActionConfigElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((BackupRestoreActionConfigElement)element).description;
		}

		public new IEnumerator<ConfigurationElement> GetEnumerator()
		{
			int num = base.Count;
			for (int i = 0; i < num; i++)
			{
				yield return base.BaseGet(i);
			}
		}
	}
}