using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using SQLServerDatabaseBackup.Configuration;
using System.Linq;
using System.Collections.Generic;
using SQLServerDatabaseBackup.Models;
using SQLServerDatabaseBackup.Process;

namespace SQLServerDatabaseBackup
{
    public partial class frmMain : Form
    {
      
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Add columns

            GetConfig();

            var activeLocalDrives = GetActiveLocalDrives();

            foreach (var drive in activeLocalDrives)
            {
                if (radioButton1.Text == "-")
                {
                    radioButton1.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

                if (radioButton2.Text == "-")
                {
                    radioButton2.Text = drive.Name.Replace(":\\", "");
                    continue;
                }
                if (radioButton3.Text == "-")
                {
                    radioButton3.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

                if (radioButton4.Text == "-")
                {
                    radioButton4.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

                if (radioButton5.Text == "-")
                {
                    radioButton5.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

            }

            var first = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Text == "-").FirstOrDefault();

            if (first != null)
                first.Visible = false;

            foreach (var drive in activeLocalDrives)
            {
                if (radioButton6.Text == "-")
                {
                    radioButton6.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

                if (radioButton7.Text == "-")
                {
                    radioButton7.Text = drive.Name.Replace(":\\", "");
                    continue;
                }
                if (radioButton8.Text == "-")
                {
                    radioButton8.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

                if (radioButton9.Text == "-")
                {
                    radioButton9.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

                if (radioButton10.Text == "-")
                {
                    radioButton10.Text = drive.Name.Replace(":\\", "");
                    continue;
                }

            }

            var second = groupBox2.Controls.OfType<RadioButton>().Where(x => x.Text == "-").FirstOrDefault();

            if (second != null)
                second.Visible = false;

            CleanupLocalDrivesList();


        }

        private void CleanupLocalDrivesList()
        {
            var invalidFirst = groupBox1.Controls.OfType<RadioButton>().Where(x => x.Text == "-");

            if (invalidFirst.Any())
            {
                foreach (var invalid in invalidFirst)
                {
                    invalid.Visible = false;
                }
            }
              

            var invalidSecond = groupBox2.Controls.OfType<RadioButton>().Where(x => x.Text == "-");

            if (invalidSecond.Any())
            {
                foreach (var invalid in invalidSecond)
                {
                    invalid.Visible = false;
                }
            }


        }

        public void GetConfig()
        {

            lstLocalInstances.Items.Clear();

            var bakRestObj = new BackupRestoreActionHandler();
            bakRestObj.getServers();

            foreach (var bakRest in bakRestObj.actions)
            {
                var obj = bakRest;
                ListViewItem v = new ListViewItem(new[] { bakRest.description, bakRest.fromDatabase, bakRest.toDatabase, bakRest.fromServer, bakRest.toServer });
                v.Tag = obj;
                v.Text = obj.ToString();
                lstLocalInstances.Items.Add(v);
            }
        }

        private List<DriveInfo> GetActiveLocalDrives()
        {
            var drivesList = new List<DriveInfo>();
             
            var drives = DriveInfo.GetDrives();

            foreach (var drive in drives)
            {
                if(drive.IsReady)
                  drivesList.Add(drive);
            }

            return drivesList;
        }

        private static void SetAuthentication(ref Server srv, BackupRestoreAction bakRest, RestoreDestination resAction)
        {

            if(resAction == RestoreDestination.FromServer)
            {
                if (bakRest.UseWindowsAuthenticationFromServer)
                {
                    // Use Windows Auth
                    srv.ConnectionContext.LoginSecure = true;
                }
                else
                {
                    if (bakRest.IsSQLAuthenticationFromServer)
                    {
                        srv.ConnectionContext.LoginSecure = false;
                        srv.ConnectionContext.Login = bakRest.SQLusernameFromServer;
                        srv.ConnectionContext.Password = bakRest.SQLpasswordFromServer;

                    }
                    else
                    {
                        // Use Windows Auth
                        srv.ConnectionContext.LoginSecure = true;
                    }
                }
            }
            else
            {
                if (bakRest.UseWindowsAuthenticationToServer)
                {
                    // Use Windows Auth
                    srv.ConnectionContext.LoginSecure = true;
                }
                else
                {
                    if (bakRest.IsSQLAuthenticationToServer)
                    {
                        srv.ConnectionContext.LoginSecure = false;
                        srv.ConnectionContext.Login = bakRest.SQLusernameToServer;
                        srv.ConnectionContext.Password = bakRest.SQLpasswordToServer;
                    }
                    else
                    {
                        // Use Windows Auth
                        srv.ConnectionContext.LoginSecure = true;
                    }
                }
            }
           
        }

        private long GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.TotalFreeSpace;
                }
            }
            return -1;
        }

        delegate void SetMessageCallback(string text);

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach(var ctrl in groupBox1.Controls)
                {
                    if(ctrl is RadioButton)
                    {
                        (ctrl as RadioButton).Enabled = false;
                        (ctrl as RadioButton).Checked = false;
                    }
                }
            }
            else
            {
                foreach (var ctrl in groupBox1.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        (ctrl as RadioButton).Enabled = true;
                        (ctrl as RadioButton).Checked = false;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                foreach (var ctrl in groupBox2.Controls)
                {
                    if (ctrl is RadioButton)
                    {
                        (ctrl as RadioButton).Enabled = false;
                        (ctrl as RadioButton).Checked = false;
                    }
                }
            }
            else
            {
                foreach (var a in groupBox2.Controls)
                {
                    if (a is RadioButton)
                    {
                        (a as RadioButton).Enabled = true;
                        (a as RadioButton).Checked = false;
                    }
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                checkBox1.Checked = false;
                radioButton1.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                checkBox1.Checked = false;
                radioButton2.Checked = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Checked = false;
                radioButton3.Checked = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checkBox1.Checked = false;
                radioButton4.Checked = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                checkBox1.Checked = false;
                radioButton5.Checked = true;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                checkBox2.Checked = false;
                radioButton6.Checked = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                checkBox2.Checked = false;
                radioButton7.Checked = true;
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                checkBox2.Checked = false;
                radioButton8.Checked = true;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                checkBox2.Checked = false;
                radioButton9.Checked = true;
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                checkBox2.Checked = false;
                radioButton10.Checked = true;
            }
        }
        
 
        private void lstLocalInstances_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Only allow one item to be selected in a ListView

            if (this.lstLocalInstances.SelectedItems.Count > 1)
            { 
                e.Item.Selected = false;
            }
        }

        private void lstLocalInstances_DoubleClick(object sender, EventArgs e)
        {
            AddEditBackupRestoreAction frm = new AddEditBackupRestoreAction((BackupRestoreAction)lstLocalInstances.SelectedItems[0].Tag);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void lstLocalInstances_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (lstLocalInstances.FocusedItem.Bounds.Contains(e.Location))
                {
                    Actions.Show(Cursor.Position);
                }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            AddEditBackupRestoreAction frm = new AddEditBackupRestoreAction((BackupRestoreAction)lstLocalInstances.SelectedItems[0].Tag);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void BackupAndRestore_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Refresh();
            var action = (BackupRestoreAction)lstLocalInstances.SelectedItems[0].Tag;
            var start = DateTime.Now;
            var result = BackupAndRestoreSelectedItem(action);
            var end = DateTime.Now;
            result.StartTime = start;
            result.EndTime = end;
            result.action = action;
            AddBackupAndRestoreResultToListView(result);
        }

        private void AddBackupAndRestoreResultToListView(BackupAndRestoreResult result)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = result.Message;
            lvi.Tag = result;
            listView1.Items.Add(lvi);
        }

        private BackupAndRestoreResult BackupAndRestoreSelectedItem(BackupRestoreAction bra)
        {
            return BackupAndRestoreAction(bra);
        }

        private BackupAndRestoreResult BackupAndRestoreAction(BackupRestoreAction bra)
        {
            var result = new BackupAndRestoreResult();
            var bkp = new Backup();
            Server srv;
            var conn = new ServerConnection();

            try
            {
                String fullyQualifiedServerNameOrigin = (!string.IsNullOrEmpty(bra.fromServerInstanceName) ? bra.fromServer + "\\" + bra.fromServerInstanceName : bra.fromServer);

                conn.ServerInstance = fullyQualifiedServerNameOrigin;
                conn.DatabaseName = "master";

                srv = new Server(conn);

                SetAuthentication(ref srv, bra, RestoreDestination.FromServer);

                var originDatabaseSizeBytes = srv.Databases[bra.fromDatabase].Size * 1000000;

                var dBusiness = new DriveBusiness(new DriveRepository());

                var backupDriveExplicit = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                var restorDriveExplicit = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

                Drive originDrive = null;
                Drive destinationDrive = null;

                if (backupDriveExplicit != null)
                {
                    originDrive = dBusiness.GetDrive(bra.fromServer, backupDriveExplicit.Text);
                }
                else
                {
                    originDrive = dBusiness.GetLeastFilledDrive(bra.fromServer);
                }

                if (restorDriveExplicit != null)
                {
                    destinationDrive = dBusiness.GetDrive(bra.toServer, restorDriveExplicit.Text);
                }
                else
                {
                    destinationDrive = dBusiness.GetLeastFilledDrive(bra.toServer);
                }

                // will we leave at least 10gb free on the origin and destination drives?

                if (originDrive.TotalFreeSpace - originDatabaseSizeBytes > 10000000000
                    && destinationDrive.TotalFreeSpace - originDatabaseSizeBytes > 10000000000)
                {

                    String ORIGIN_backupsPathRemote = string.Format("\\\\{0}\\{1}\\{2}", bra.fromServer, originDrive.UNCDriveName, "Backups");
                    String ORIGIN_backupsPathLocal = string.Format("{0}\\{1}", originDrive.LocalDriveName, "Backups");

                    Guid newGuidOrigin = Guid.NewGuid();

                    String ORIGIN_backupFileNameLocal = string.Format("BACKUP_{0}_{1}.BAK", bra.fromDatabase, newGuidOrigin);
                    String ORIGIN_fullBackupFilePathLocal = ORIGIN_backupsPathLocal + "\\" + ORIGIN_backupFileNameLocal;

                    String ORIGIN_backupFileNameRemote = string.Format("BACKUP_{0}_{1}.BAK", bra.fromDatabase, newGuidOrigin);
                    String ORIGIN_fullBackupFilePathRemote = ORIGIN_backupsPathRemote + "\\" + ORIGIN_backupFileNameRemote;

                    result.BackedUpTo = ORIGIN_fullBackupFilePathRemote;

                    String DESTINATION_backupsPathRemote = string.Format("\\\\{0}\\{1}\\{2}", bra.toServer, destinationDrive.UNCDriveName, "Backups");
                    String DESTINATION_backupsPathLocal = string.Format("{0}\\{1}", destinationDrive.LocalDriveName, "Backups");

                    Guid newGuidDestination = Guid.NewGuid();

                    String DESTINATION_backupFileNameLocal = string.Format("BACKUP_{0}_{1}.BAK", bra.toDatabase, newGuidDestination);

                    String DESTINATION_replacedDBBackupFileNameLocal = string.Format("BACKUPBEFORERESTORED_{0}_{1}.BAK", bra.toDatabase, DateTime.Now.ToString("MMddyyyHHmmss"), newGuidDestination);
                    String DESTINATION_fullBackupFilePathLocal = DESTINATION_backupsPathLocal + "\\" + DESTINATION_backupFileNameLocal;
                    String DESTINATION_replacedDBBackupFilePathLocal = DESTINATION_backupsPathLocal + "\\" + DESTINATION_replacedDBBackupFileNameLocal;

                    String DESTINATION_backupFileNameRemote = string.Format("BACKUP_{0}_{1}.BAK", bra.toDatabase, newGuidDestination);
                    String DESTINATION_fullBackupFilePathRemote = DESTINATION_backupsPathRemote + "\\" + DESTINATION_backupFileNameRemote;

                    result.RestoredTo = DESTINATION_fullBackupFilePathRemote;


                    if (!Directory.Exists(ORIGIN_backupsPathRemote))
                    {
                        Directory.CreateDirectory(ORIGIN_backupsPathRemote);
                    }

                    bkp.Action = BackupActionType.Database;
                    bkp.Database = bra.fromDatabase;
                    bkp.Devices.AddDevice(ORIGIN_fullBackupFilePathLocal, DeviceType.File);
                    bkp.Incremental = false;

                    int percentBackup = 0;

                    bkp.PercentComplete += new PercentCompleteEventHandler(delegate (object s, PercentCompleteEventArgs ev)
                    {
                        percentBackup = ev.Percent;
                    });

                    bkp.SqlBackup(srv);


                    while (percentBackup != 100)
                    {

                    }

                    if (!Directory.Exists(DESTINATION_backupsPathRemote))
                    {
                        Directory.CreateDirectory(DESTINATION_backupsPathRemote);
                    }

                    File.Copy(ORIGIN_fullBackupFilePathRemote, DESTINATION_fullBackupFilePathRemote);

                    if (File.Exists(DESTINATION_fullBackupFilePathRemote))
                    {
                        File.Delete(ORIGIN_fullBackupFilePathRemote);
                    }

                    conn = new ServerConnection();

                    String fullyQualifiedServerNameDestination = (!string.IsNullOrEmpty(bra.toServerInstanceName) ? bra.toServer + "\\" + bra.toServerInstanceName : bra.toServer);

                    conn.ServerInstance = fullyQualifiedServerNameDestination;
                    conn.DatabaseName = "master";
                    srv = new Server(conn);

                    SetAuthentication(ref srv, bra, RestoreDestination.ToServer);

                    Restore res = new Restore();

                    res.Database = bra.toDatabase;
                    res.ReplaceDatabase = true;

                    var relocate = new RelocateFile(bra.toDatabase, "C:\\logs\\" + bra.toDatabase + ".mdf");
                    relocate.LogicalFileName = bra.toDatabase;
                    relocate.PhysicalFileName = "C:\\logs\\" + bra.toDatabase + ".mdf";

                    res.RelocateFiles.Add(relocate);

                    if (bra.replace == false)
                    {
                        Database database = new Database(srv, bra.toDatabase);

                        FileGroup fileGroup = new FileGroup(database, "PRIMARY");
                        database.FileGroups.Add(fileGroup);

                        DataFile dataFile = new DataFile(fileGroup, bra.toDatabase + ".mdf", "C:\\logs\\" + bra.toDatabase + ".mdf");
                        dataFile.IsPrimaryFile = true;
                        fileGroup.Files.Add(dataFile);

                        LogFile logFile = new LogFile(database, bra.toDatabase + ".ldf", "C:\\logs\\" + bra.toDatabase + ".ldf");
                        database.LogFiles.Add(logFile);

                        database.Create();
                        database.Refresh();
                    }
                    else
                    {

                        // Back up the destination database before we replace it

                        Backup backupDestionationDatabaseBeforeRestore = new Backup();

                        backupDestionationDatabaseBeforeRestore.Action = BackupActionType.Database;
                        backupDestionationDatabaseBeforeRestore.Database = bra.toDatabase;
                        backupDestionationDatabaseBeforeRestore.Devices.AddDevice(DESTINATION_replacedDBBackupFilePathLocal, DeviceType.File);
                        backupDestionationDatabaseBeforeRestore.Incremental = false;

                        int percentBackedUp = 0;

                        backupDestionationDatabaseBeforeRestore.PercentComplete += new PercentCompleteEventHandler(delegate (object s, PercentCompleteEventArgs ev)
                        {
                            percentBackedUp = ev.Percent;
                            progressBar1.Increment(ev.Percent);
                        });

                        backupDestionationDatabaseBeforeRestore.SqlBackup(srv);

                        while (percentBackedUp != 100)
                        {

                        }

                        // Set single-user mode

                        Database db = srv.Databases[bra.toDatabase];
                        db.DatabaseOptions.UserAccess = DatabaseUserAccess.Single;
                        db.Alter(TerminationClause.RollbackTransactionsImmediately);
                    }

                    res.Action = RestoreActionType.Database;
                    res.Devices.AddDevice(DESTINATION_fullBackupFilePathLocal, DeviceType.File);

                    RelocateFile DataFile = new RelocateFile();
                    string MDF = res.ReadFileList(srv).Rows[0][1].ToString();
                    DataFile.LogicalFileName = res.ReadFileList(srv).Rows[0][0].ToString();
                    DataFile.PhysicalFileName = srv.Databases[bra.toDatabase].FileGroups[0].Files[0].FileName;

                    RelocateFile LogFile = new RelocateFile();
                    string LDF = res.ReadFileList(srv).Rows[1][1].ToString();
                    LogFile.LogicalFileName = res.ReadFileList(srv).Rows[1][0].ToString();
                    LogFile.PhysicalFileName = srv.Databases[bra.toDatabase].LogFiles[0].FileName;

                    res.RelocateFiles.Clear();
                    res.RelocateFiles.Add(DataFile);
                    res.RelocateFiles.Add(LogFile);

                    int percentRestore = 0;
                    progressBar1.Value = 0;

                    res.PercentComplete += new PercentCompleteEventHandler(delegate (object s, PercentCompleteEventArgs ev)
                    {
                        percentRestore = ev.Percent;
                        progressBar1.Increment(ev.Percent);
                    });

                    res.SqlRestore(srv);

                    while (percentRestore != 100)
                    {

                    }

                    if (bra.replace == false)
                    {

                    }
                    else
                    {
                        Database db = srv.Databases[bra.toDatabase];
                        db.DatabaseOptions.UserAccess = DatabaseUserAccess.Multiple;
                    }

                    File.Delete(DESTINATION_fullBackupFilePathRemote);
                   
                }

                result.Message = $"Backed up {bra.description} ({bra.fromServer}..{bra.fromDatabase} to {bra.toServer}..{bra.toDatabase})";
                result.Sucess = true;
                
            }

            catch (Exception ex)
            {
                result.Message = $"Error backing up / restoring database : {ex.ToString()}";
                result.Sucess = false;
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                conn.Disconnect();
               
            }
            return result;
        }
        private void buttonBackupAll_Click(object sender, EventArgs e)
        {
            GUICleanupBeforeBackupAndRestore();

            var braObj = new BackupRestoreActionHandler();
            braObj.getServers();

            foreach(var bra in braObj.actions)
            {
                DateTime start = DateTime.Now;

                BackupAndRestoreResult result = BackupAndRestoreAction(bra);
                result.StartTime = start;
                DateTime end = DateTime.Now;
                result.EndTime = end;
                result.action = bra;

                AddBackupAndRestoreResultToListView(result);
            }

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Only allow one item to be selected in a ListView

            if (this.listView1.SelectedItems.Count > 1)
            {
                e.Item.Selected = false;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // Show the toolstrip context menu on the listview item

            if (listView1.FocusedItem.Bounds.Contains(e.Location))
            {
                BackupResultMenuStrip.Show(Cursor.Position);
            }
           
        }

        private void detailsMenuStripItem_Click(object sender, EventArgs e)
        {
            BackupAndRestoreResultForm frm = new BackupAndRestoreResultForm((BackupAndRestoreResult)listView1.SelectedItems[0].Tag);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            BackupAndRestoreResultForm frm = new BackupAndRestoreResultForm((BackupAndRestoreResult)listView1.SelectedItems[0].Tag);
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUICleanupBeforeBackupAndRestore();

            for(int i = 0; i < lstLocalInstances.SelectedItems.Count; i++)
            {
               
                var actionTag = (BackupRestoreAction)lstLocalInstances.SelectedItems[i].Tag;
                var start = DateTime.Now;
                var result = BackupAndRestoreSelectedItem(actionTag);
                var end = DateTime.Now;
                result.StartTime = start;
                result.EndTime = end;
                result.action = actionTag;
                AddBackupAndRestoreResultToListView(result);
            }
        

        }

        private void GUICleanupBeforeBackupAndRestore()
        {
            progressBar1.Value = 0;
            listView1.Items.Clear();
            listView1.Refresh();
        }
    }
}
