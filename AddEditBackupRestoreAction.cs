using SQLServerDatabaseBackup.Configuration;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace SQLServerDatabaseBackup
{
    public partial class AddEditBackupRestoreAction : Form
    {
        public AddEditBackupRestoreAction(BackupRestoreAction bra)
        {
            InitializeComponent();
            Populate(bra);
        }

        private void Populate(BackupRestoreAction bra)
        {
            txtDescription.Text = bra.description;

            textServerNameOrigin.Text = bra.fromServer;
            textDatabaseNameOrigin.Text = bra.fromDatabase;
            textSqlUserNameOrigin.Text = bra.SQLusernameFromServer;
            textSqlPasswordOrigin.Text = bra.SQLpasswordFromServer;

            textServerNameDestination.Text = bra.toServer;
            textDatabaseNameDestination.Text = bra.toDatabase;
            textSqlUserNameDestination.Text = bra.SQLusernameToServer;
            textSqlPasswordDestination.Text = bra.SQLpasswordToServer;

            checkBoxReplaceDatabase.Checked = bra.replace;

            checkBoxUseWindowsAuthOriginServer.Checked = bra.UseWindowsAuthenticationFromServer;

            if (bra.UseWindowsAuthenticationFromServer)
            {
                textSqlUserNameOrigin.Enabled = false;
                textSqlPasswordOrigin.Enabled = false;
            }
            checkBoxUseWindowsAuthDestinationServer.Checked = bra.UseWindowsAuthenticationToServer;

            if (bra.UseWindowsAuthenticationToServer)
            {
                textSqlUserNameDestination.Enabled = false;
                textSqlPasswordDestination.Enabled = false;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            BackupRestoreAction newBra = BindBra();

            var exeConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            BackupRestoreActionConfigSection config = ConfigurationManager.GetSection("backupRestoreSetting") as BackupRestoreActionConfigSection;

            for (int x = 0; x < config.Servers.Count; x++)
            {
                config.Servers[x].description = txtDescription.Text;
                config.Servers[x].fromServer = textServerNameOrigin.Text;
                config.Servers[x].fromDatabase = textDatabaseNameOrigin.Text;
                config.Servers[x].SQLusernameFromServer = textSqlUserNameOrigin.Text;
                config.Servers[x].SQLpasswordFromServer = textSqlPasswordOrigin.Text;

                config.Servers[x].toServer = textServerNameDestination.Text;
                config.Servers[x].toDatabase = textDatabaseNameDestination.Text;
                config.Servers[x].SQLusernameToServer = textSqlUserNameDestination.Text;
                config.Servers[x].SQLpasswordToServer = textSqlPasswordDestination.Text;

                config.Servers[x].replace = checkBoxReplaceDatabase.Checked.ToString().ToLower();
                config.Servers[x].UseWindowsAuthenticationFromServer = checkBoxUseWindowsAuthOriginServer.Checked;
            
            }
            exeConfiguration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("backupRestoreSetting");

        }

        private BackupRestoreAction BindBra()
        {
            BackupRestoreAction newBra = new BackupRestoreAction();

            newBra.description = txtDescription.Text;

            newBra.fromServer = textServerNameOrigin.Text;
            newBra.fromDatabase = textDatabaseNameOrigin.Text;
            newBra.SQLusernameFromServer = textSqlUserNameOrigin.Text;
            newBra.SQLpasswordFromServer = textSqlPasswordOrigin.Text;

            newBra.toServer = textServerNameDestination.Text;
            newBra.toDatabase = textDatabaseNameDestination.Text;
            newBra.SQLusernameToServer = textSqlUserNameDestination.Text;
            newBra.SQLpasswordToServer = textSqlPasswordDestination.Text;

            newBra.replace = checkBoxReplaceDatabase.Checked;

            return newBra;

        }

        private void checkBoxUseWindowsAuthOriginServer_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxUseWindowsAuthOriginServer.Checked)
            {
                textSqlUserNameOrigin.Enabled = true;
                textSqlPasswordOrigin.Enabled = true;
            }
            else
            {
                textSqlUserNameOrigin.Enabled = false;
                textSqlPasswordOrigin.Enabled = false;
            }
        }

        private void checkBoxUseWindowsAuthDestinationServer_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxUseWindowsAuthDestinationServer.Checked)
            {
                textSqlUserNameDestination.Enabled = true;
                textSqlPasswordDestination.Enabled = true;
            }
            else
            {
                textSqlUserNameDestination.Enabled = false;
                textSqlPasswordDestination.Enabled = false;
            }
        }
    }
}
