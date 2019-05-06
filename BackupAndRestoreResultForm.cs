using SQLServerDatabaseBackup.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServerDatabaseBackup
{
    public partial class BackupAndRestoreResultForm : Form
    {
        public BackupAndRestoreResultForm(BackupAndRestoreResult result)
        {
            InitializeComponent();
            textBox1.Text = result.Message;
            label4.Text = result.StartTime.ToString("MM/dd/yyyy HH:mm:ss");
            label5.Text = result.EndTime.ToString("MM/dd/yyyy HH:mm:ss");
            checkBox1.Checked = result.Sucess;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
