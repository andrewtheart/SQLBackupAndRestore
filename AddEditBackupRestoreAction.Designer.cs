namespace SQLServerDatabaseBackup
{
    partial class AddEditBackupRestoreAction
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
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.textServerNameOrigin = new System.Windows.Forms.TextBox();
            this.textDatabaseNameOrigin = new System.Windows.Forms.TextBox();
            this.textSqlUserNameOrigin = new System.Windows.Forms.TextBox();
            this.textSqlPasswordOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textServerNameDestination = new System.Windows.Forms.TextBox();
            this.textDatabaseNameDestination = new System.Windows.Forms.TextBox();
            this.textSqlPasswordDestination = new System.Windows.Forms.TextBox();
            this.textSqlUserNameDestination = new System.Windows.Forms.TextBox();
            this.checkBoxReplaceDatabase = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxUseWindowsAuthOriginServer = new System.Windows.Forms.CheckBox();
            this.checkBoxUseWindowsAuthDestinationServer = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(141, 19);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 20);
            this.txtDescription.TabIndex = 0;
            // 
            // textServerNameOrigin
            // 
            this.textServerNameOrigin.Location = new System.Drawing.Point(115, 23);
            this.textServerNameOrigin.Name = "textServerNameOrigin";
            this.textServerNameOrigin.Size = new System.Drawing.Size(157, 20);
            this.textServerNameOrigin.TabIndex = 1;
            // 
            // textDatabaseNameOrigin
            // 
            this.textDatabaseNameOrigin.Location = new System.Drawing.Point(115, 49);
            this.textDatabaseNameOrigin.Name = "textDatabaseNameOrigin";
            this.textDatabaseNameOrigin.Size = new System.Drawing.Size(157, 20);
            this.textDatabaseNameOrigin.TabIndex = 2;
            // 
            // textSqlUserNameOrigin
            // 
            this.textSqlUserNameOrigin.Location = new System.Drawing.Point(115, 75);
            this.textSqlUserNameOrigin.Name = "textSqlUserNameOrigin";
            this.textSqlUserNameOrigin.Size = new System.Drawing.Size(157, 20);
            this.textSqlUserNameOrigin.TabIndex = 3;
            // 
            // textSqlPasswordOrigin
            // 
            this.textSqlPasswordOrigin.Location = new System.Drawing.Point(115, 101);
            this.textSqlPasswordOrigin.Name = "textSqlPasswordOrigin";
            this.textSqlPasswordOrigin.Size = new System.Drawing.Size(157, 20);
            this.textSqlPasswordOrigin.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxUseWindowsAuthOriginServer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textServerNameOrigin);
            this.groupBox1.Controls.Add(this.textDatabaseNameOrigin);
            this.groupBox1.Controls.Add(this.textSqlPasswordOrigin);
            this.groupBox1.Controls.Add(this.textSqlUserNameOrigin);
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 166);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origin Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SQL Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "SQL Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxUseWindowsAuthDestinationServer);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textServerNameDestination);
            this.groupBox2.Controls.Add(this.textDatabaseNameDestination);
            this.groupBox2.Controls.Add(this.textSqlPasswordDestination);
            this.groupBox2.Controls.Add(this.textSqlUserNameDestination);
            this.groupBox2.Location = new System.Drawing.Point(26, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 173);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destination Server";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "SQL Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "SQL Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Database Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Server Name";
            // 
            // textServerNameDestination
            // 
            this.textServerNameDestination.Location = new System.Drawing.Point(115, 25);
            this.textServerNameDestination.Name = "textServerNameDestination";
            this.textServerNameDestination.Size = new System.Drawing.Size(157, 20);
            this.textServerNameDestination.TabIndex = 9;
            // 
            // textDatabaseNameDestination
            // 
            this.textDatabaseNameDestination.Location = new System.Drawing.Point(115, 51);
            this.textDatabaseNameDestination.Name = "textDatabaseNameDestination";
            this.textDatabaseNameDestination.Size = new System.Drawing.Size(157, 20);
            this.textDatabaseNameDestination.TabIndex = 10;
            // 
            // textSqlPasswordDestination
            // 
            this.textSqlPasswordDestination.Location = new System.Drawing.Point(115, 103);
            this.textSqlPasswordDestination.Name = "textSqlPasswordDestination";
            this.textSqlPasswordDestination.Size = new System.Drawing.Size(157, 20);
            this.textSqlPasswordDestination.TabIndex = 12;
            // 
            // textSqlUserNameDestination
            // 
            this.textSqlUserNameDestination.Location = new System.Drawing.Point(115, 77);
            this.textSqlUserNameDestination.Name = "textSqlUserNameDestination";
            this.textSqlUserNameDestination.Size = new System.Drawing.Size(157, 20);
            this.textSqlUserNameDestination.TabIndex = 11;
            // 
            // checkBoxReplaceDatabase
            // 
            this.checkBoxReplaceDatabase.AutoSize = true;
            this.checkBoxReplaceDatabase.Location = new System.Drawing.Point(26, 401);
            this.checkBoxReplaceDatabase.Name = "checkBoxReplaceDatabase";
            this.checkBoxReplaceDatabase.Size = new System.Drawing.Size(113, 17);
            this.checkBoxReplaceDatabase.TabIndex = 9;
            this.checkBoxReplaceDatabase.Text = "Replace database";
            this.checkBoxReplaceDatabase.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(236, 418);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxUseWindowsAuthOriginServer
            // 
            this.checkBoxUseWindowsAuthOriginServer.AutoSize = true;
            this.checkBoxUseWindowsAuthOriginServer.Location = new System.Drawing.Point(10, 133);
            this.checkBoxUseWindowsAuthOriginServer.Name = "checkBoxUseWindowsAuthOriginServer";
            this.checkBoxUseWindowsAuthOriginServer.Size = new System.Drawing.Size(117, 17);
            this.checkBoxUseWindowsAuthOriginServer.TabIndex = 10;
            this.checkBoxUseWindowsAuthOriginServer.Text = "Use Windows Auth";
            this.checkBoxUseWindowsAuthOriginServer.UseVisualStyleBackColor = true;
            this.checkBoxUseWindowsAuthOriginServer.CheckedChanged += new System.EventHandler(this.checkBoxUseWindowsAuthOriginServer_CheckedChanged);
            // 
            // checkBoxUseWindowsAuthDestinationServer
            // 
            this.checkBoxUseWindowsAuthDestinationServer.AutoSize = true;
            this.checkBoxUseWindowsAuthDestinationServer.Location = new System.Drawing.Point(10, 140);
            this.checkBoxUseWindowsAuthDestinationServer.Name = "checkBoxUseWindowsAuthDestinationServer";
            this.checkBoxUseWindowsAuthDestinationServer.Size = new System.Drawing.Size(117, 17);
            this.checkBoxUseWindowsAuthDestinationServer.TabIndex = 11;
            this.checkBoxUseWindowsAuthDestinationServer.Text = "Use Windows Auth";
            this.checkBoxUseWindowsAuthDestinationServer.UseVisualStyleBackColor = true;
            this.checkBoxUseWindowsAuthDestinationServer.CheckedChanged += new System.EventHandler(this.checkBoxUseWindowsAuthDestinationServer_CheckedChanged);
            // 
            // AddEditBackupRestoreAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 463);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxReplaceDatabase);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.MaximumSize = new System.Drawing.Size(336, 502);
            this.MinimumSize = new System.Drawing.Size(336, 502);
            this.Name = "AddEditBackupRestoreAction";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox textServerNameOrigin;
        private System.Windows.Forms.TextBox textDatabaseNameOrigin;
        private System.Windows.Forms.TextBox textSqlUserNameOrigin;
        private System.Windows.Forms.TextBox textSqlPasswordOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textServerNameDestination;
        private System.Windows.Forms.TextBox textDatabaseNameDestination;
        private System.Windows.Forms.TextBox textSqlPasswordDestination;
        private System.Windows.Forms.TextBox textSqlUserNameDestination;
        private System.Windows.Forms.CheckBox checkBoxReplaceDatabase;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxUseWindowsAuthOriginServer;
        private System.Windows.Forms.CheckBox checkBoxUseWindowsAuthDestinationServer;
    }
}