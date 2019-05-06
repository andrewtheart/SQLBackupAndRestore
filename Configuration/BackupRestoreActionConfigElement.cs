using System;
using System.Configuration;

namespace SQLServerDatabaseBackup.Configuration
{
    public class BackupRestoreActionConfigElement : ConfigurationSection
	{
		[ConfigurationProperty("description", DefaultValue="false", IsRequired=false)]
		public string description
		{
			get
			{
				return (string)base["description"];
			}
			set
			{
				base["description"] = value;
			}
		}

		[ConfigurationProperty("fromDatabase", DefaultValue="false", IsRequired=false)]
		public string fromDatabase
		{
			get
			{
				return (string)base["fromDatabase"];
			}
			set
			{
				base["fromDatabase"] = value;
			}
		}

		[ConfigurationProperty("fromServer", DefaultValue="false", IsRequired=false)]
		public string fromServer
		{
			get
			{
				return (string)base["fromServer"];
			}
			set
			{
				base["fromServer"] = value;
			}
		}

		[ConfigurationProperty("replace", DefaultValue="false", IsRequired=false)]
		public string replace
		{
			get
			{
				return (string)base["replace"];
			}
			set
			{
				base["replace"] = value;
			}
		}

		[ConfigurationProperty("toDatabase", DefaultValue="false", IsRequired=false)]
		public string toDatabase
		{
			get
			{
				return (string)base["toDatabase"];
			}
			set
			{
				base["toDatabase"] = value;
			}
		}

		[ConfigurationProperty("toServer", DefaultValue="false", IsRequired=false)]
		public string toServer
		{
			get
			{
				return (string)base["toServer"];
			}
			set
			{
				base["toServer"] = value;
			}
		}



        [ConfigurationProperty("SQLusernameFromServer", DefaultValue = "", IsRequired = false)]
        public string SQLusernameFromServer
        {
            get
            {
                return (string)base["SQLusernameFromServer"];
            }
            set
            {
                base["SQLusernameFromServer"] = value;
            }
        }

        [ConfigurationProperty("SQLpasswordFromServer", DefaultValue = "", IsRequired = false)]
        public string SQLpasswordFromServer
        {
            get
            {
                return (string)base["SQLpasswordFromServer"];
            }
            set
            {
                base["SQLpasswordFromServer"] = value;
            }
        }


        [ConfigurationProperty("SQLusernameToServer", DefaultValue = "", IsRequired = false)]
        public string SQLusernameToServer
        {
            get
            {
                return (string)base["SQLusernameFromServer"];
            }
            set
            {
                base["SQLusernameFromServer"] = value;
            }
        }

        [ConfigurationProperty("SQLpasswordToServer", DefaultValue = "", IsRequired = false)]
        public string SQLpasswordToServer
        {
            get
            {
                return (string)base["SQLpasswordToServer"];
            }
            set
            {
                base["SQLpasswordToServer"] = value;
            }
        }



        [ConfigurationProperty("UseWindowsAuthenticationFromServer", DefaultValue = true, IsRequired = false)]
        public bool UseWindowsAuthenticationFromServer
        {
            get
            {
                return (bool)base["UseWindowsAuthenticationFromServer"];
            }
            set
            {
                base["UseWindowsAuthenticationFromServer"] = value;
            }
        }



        [ConfigurationProperty("UseWindowsAuthenticationToServer", DefaultValue = true, IsRequired = false)]
        public bool UseWindowsAuthenticationToServer
        {
            get
            {
                return (bool)base["UseWindowsAuthenticationToServer"];
            }
            set
            {
                base["UseWindowsAuthenticationToServer"] = value;
            }
        }


        

        public BackupRestoreActionConfigElement()
		{
		}
	}
}