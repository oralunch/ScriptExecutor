using System;
using System.Windows.Forms;
using System.Diagnostics;
using Oracle.DataAccess.Client;
using System.Collections;
using System.IO;

namespace ScriptExecutor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Executor ex = new Executor();
            ex.User = "testUser";
            ex.TracePath = @"D:\document\tmp\ScriptExecutor\log\trace\";
            ex.ScriptPath = @"D:\document\tmp\ScriptExecutor\script";
            ex.Execute();
        }
    }
}
