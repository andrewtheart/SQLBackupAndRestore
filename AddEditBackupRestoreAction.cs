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

            //var theConfig = from s in config.Servers
            //                where s.
            //exeConfiguration.Save();


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
