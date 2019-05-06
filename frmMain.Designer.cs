namespace SQLServerDatabaseBackup
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lstLocalInstances = new System.Windows.Forms.ListView();
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromDatabase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToDatabase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FromServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ToServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Actions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupAndRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonBackupAll = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.BackupResultMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detailsMenuStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Actions.SuspendLayout();
            this.BackupResultMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(17, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(156, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Backup to least filled drive?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(29, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(28, 17);
            this.radioButton1.TabIndex = 22;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "-";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(29, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(28, 17);
            this.radioButton2.TabIndex = 23;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Enabled = false;
            this.radioButton3.Location = new System.Drawing.Point(29, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(28, 17);
            this.radioButton3.TabIndex = 24;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "-";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(29, 88);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(28, 17);
            this.radioButton4.TabIndex = 25;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "-";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(29, 111);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(28, 17);
            this.radioButton5.TabIndex = 26;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "-";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(13, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 138);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup to drive:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Location = new System.Drawing.Point(173, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 142);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore to drive:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Enabled = false;
            this.radioButton6.Location = new System.Drawing.Point(17, 23);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(28, 17);
            this.radioButton6.TabIndex = 22;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "-";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Enabled = false;
            this.radioButton7.Location = new System.Drawing.Point(17, 46);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(28, 17);
            this.radioButton7.TabIndex = 26;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "-";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Enabled = false;
            this.radioButton8.Location = new System.Drawing.Point(17, 69);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(28, 17);
            this.radioButton8.TabIndex = 23;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "-";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Enabled = false;
            this.radioButton9.Location = new System.Drawing.Point(17, 92);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(28, 17);
            this.radioButton9.TabIndex = 25;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "-";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Enabled = false;
            this.radioButton10.Location = new System.Drawing.Point(17, 115);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(28, 17);
            this.radioButton10.TabIndex = 24;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "-";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(173, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(156, 17);
            this.checkBox2.TabIndex = 28;
            this.checkBox2.Text = "Restore to least filled drive?";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(354, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 23);
            this.progressBar1.TabIndex = 30;
            // 
            // lstLocalInstances
            // 
            this.lstLocalInstances.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Description,
            this.FromDatabase,
            this.ToDatabase,
            this.FromServer,
            this.ToServer});
            this.lstLocalInstances.FullRowSelect = true;
            this.lstLocalInstances.Location = new System.Drawing.Point(12, 12);
            this.lstLocalInstances.Name = "lstLocalInstances";
            this.lstLocalInstances.Size = new System.Drawing.Size(721, 194);
            this.lstLocalInstances.TabIndex = 31;
            this.lstLocalInstances.UseCompatibleStateImageBehavior = false;
            this.lstLocalInstances.View = System.Windows.Forms.View.Details;
            this.lstLocalInstances.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstLocalInstances_ItemSelectionChanged);
            this.lstLocalInstances.DoubleClick += new System.EventHandler(this.lstLocalInstances_DoubleClick);
            this.lstLocalInstances.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstLocalInstances_MouseClick);
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 117;
            // 
            // FromDatabase
            // 
            this.FromDatabase.Text = "From Database";
            this.FromDatabase.Width = 139;
            // 
            // ToDatabase
            // 
            this.ToDatabase.Text = "To Database";
            this.ToDatabase.Width = 230;
            // 
            // FromServer
            // 
            this.FromServer.Text = "From Server";
            this.FromServer.Width = 129;
            // 
            // ToServer
            // 
            this.ToServer.Text = "To Server";
            this.ToServer.Width = 117;
            // 
            // Actions
            // 
            this.Actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit,
            this.BackupAndRestore});
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(181, 48);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(180, 22);
            this.Edit.Text = "Edit";
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // BackupAndRestore
            // 
            this.BackupAndRestore.Name = "BackupAndRestore";
            this.BackupAndRestore.Size = new System.Drawing.Size(180, 22);
            this.BackupAndRestore.Text = "Backup And Restore";
            this.BackupAndRestore.Click += new System.EventHandler(this.BackupAndRestore_Click);
            // 
            // buttonBackupAll
            // 
            this.buttonBackupAll.Location = new System.Drawing.Point(658, 220);
            this.buttonBackupAll.Name = "buttonBackupAll";
            this.buttonBackupAll.Size = new System.Drawing.Size(75, 23);
            this.buttonBackupAll.TabIndex = 32;
            this.buttonBackupAll.Text = "Backup All ";
            this.buttonBackupAll.UseVisualStyleBackColor = true;
            this.buttonBackupAll.Click += new System.EventHandler(this.buttonBackupAll_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(354, 255);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 97);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // BackupResultMenuStrip
            // 
            this.BackupResultMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detailsMenuStripItem});
            this.BackupResultMenuStrip.Name = "BackupResultMenuStrip";
            this.BackupResultMenuStrip.Size = new System.Drawing.Size(119, 26);
            // 
            // detailsMenuStripItem
            // 
            this.detailsMenuStripItem.Name = "detailsMenuStripItem";
            this.detailsMenuStripItem.Size = new System.Drawing.Size(118, 22);
            this.detailsMenuStripItem.Text = "Details...";
            this.detailsMenuStripItem.Click += new System.EventHandler(this.detailsMenuStripItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Backup Selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.buttonBackupAll);
            this.Controls.Add(this.lstLocalInstances);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox1);
            this.Name = "frmMain";
            this.Text = "SQL Server Database Backup and Restore v1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Actions.ResumeLayout(false);
            this.BackupResultMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView lstLocalInstances;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader FromDatabase;
        private System.Windows.Forms.ColumnHeader ToDatabase;
        private System.Windows.Forms.ColumnHeader FromServer;
        private System.Windows.Forms.ColumnHeader ToServer;
        private System.Windows.Forms.ContextMenuStrip Actions;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem BackupAndRestore;
        private System.Windows.Forms.Button buttonBackupAll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip BackupResultMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem detailsMenuStripItem;
        private System.Windows.Forms.Button button1;
    }
}

