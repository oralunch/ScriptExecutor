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

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseHandler dbh = new DatabaseHandler();
            OracleConnection conn = dbh.GetConnection();
            conn.Open();
            OracleDataReader rd = dbh.GetResult("select ename from emp", conn);
            string userList = null;
            while (rd.Read())
            {
                userList = userList + " " + rd.GetString(0);
            }

            MessageBox.Show(userList);
            rd.Close();            
            conn.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txbScript.Text = Environment.CurrentDirectory;
            txbLog.Text = Environment.CurrentDirectory;
        }

        private void btnScript_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            txbScript.Text = folderDialog.SelectedPath;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            folderDialog.ShowDialog();
            txbLog.Text = folderDialog.SelectedPath;
        }
    }
}
