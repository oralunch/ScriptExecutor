using System;
using System.Windows.Forms;
using System.Diagnostics;
using Oracle.DataAccess.Client;
using ScriptExecutor.view;

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
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
