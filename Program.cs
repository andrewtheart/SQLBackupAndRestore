﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SQLServerDatabaseBackup
{
    static class Program
    {

        public static frmMain Form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form = new frmMain();
            Application.Run(Form);
            
        }
    }
}
