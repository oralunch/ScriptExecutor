using System;
using System.Windows.Forms;
using System.Diagnostics;
using Oracle.DataAccess.Client;

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
            ConfigurationHelper ch = new ConfigurationHelper();
            ch.UpdateAppConfig("configName", "value1");
        }
    }
}
