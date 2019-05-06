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

        }

    }
}
