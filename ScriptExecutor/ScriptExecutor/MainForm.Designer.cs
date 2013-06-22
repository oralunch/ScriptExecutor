namespace ScriptExecutor
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnRun = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabConn = new System.Windows.Forms.TabPage();
            this.tabFolder = new System.Windows.Forms.TabPage();
            this.labHost = new System.Windows.Forms.Label();
            this.txbHost = new System.Windows.Forms.TextBox();
            this.labPort = new System.Windows.Forms.Label();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labService = new System.Windows.Forms.Label();
            this.btnScript = new System.Windows.Forms.Button();
            this.txbScript = new System.Windows.Forms.TextBox();
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabConn.SuspendLayout();
            this.tabFolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 167);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 29);
            this.progressBar1.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(116, 202);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(73, 28);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // folderDialog
            // 
            this.folderDialog.Description = "select the script folder";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabConn);
            this.tabControl.Controls.Add(this.tabFolder);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(287, 149);
            this.tabControl.TabIndex = 3;
            // 
            // tabConn
            // 
            this.tabConn.Controls.Add(this.textBox1);
            this.tabConn.Controls.Add(this.labService);
            this.tabConn.Controls.Add(this.txbPort);
            this.tabConn.Controls.Add(this.labPort);
            this.tabConn.Controls.Add(this.txbHost);
            this.tabConn.Controls.Add(this.labHost);
            this.tabConn.Location = new System.Drawing.Point(4, 22);
            this.tabConn.Name = "tabConn";
            this.tabConn.Padding = new System.Windows.Forms.Padding(3);
            this.tabConn.Size = new System.Drawing.Size(279, 123);
            this.tabConn.TabIndex = 0;
            this.tabConn.Text = "Connection";
            this.tabConn.UseVisualStyleBackColor = true;
            // 
            // tabFolder
            // 
            this.tabFolder.Controls.Add(this.txbLog);
            this.tabFolder.Controls.Add(this.btnLog);
            this.tabFolder.Controls.Add(this.txbScript);
            this.tabFolder.Controls.Add(this.btnScript);
            this.tabFolder.Location = new System.Drawing.Point(4, 22);
            this.tabFolder.Name = "tabFolder";
            this.tabFolder.Padding = new System.Windows.Forms.Padding(3);
            this.tabFolder.Size = new System.Drawing.Size(279, 123);
            this.tabFolder.TabIndex = 1;
            this.tabFolder.Text = "Folder";
            this.tabFolder.UseVisualStyleBackColor = true;
            // 
            // labHost
            // 
            this.labHost.AutoSize = true;
            this.labHost.Location = new System.Drawing.Point(59, 31);
            this.labHost.Name = "labHost";
            this.labHost.Size = new System.Drawing.Size(35, 12);
            this.labHost.TabIndex = 0;
            this.labHost.Text = "host:";
            // 
            // txbHost
            // 
            this.txbHost.Location = new System.Drawing.Point(100, 28);
            this.txbHost.Name = "txbHost";
            this.txbHost.Size = new System.Drawing.Size(100, 21);
            this.txbHost.TabIndex = 1;
            // 
            // labPort
            // 
            this.labPort.AutoSize = true;
            this.labPort.Location = new System.Drawing.Point(59, 58);
            this.labPort.Name = "labPort";
            this.labPort.Size = new System.Drawing.Size(35, 12);
            this.labPort.TabIndex = 2;
            this.labPort.Text = "port:";
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(100, 55);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(100, 21);
            this.txbPort.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 5;
            // 
            // labService
            // 
            this.labService.AutoSize = true;
            this.labService.Location = new System.Drawing.Point(41, 85);
            this.labService.Name = "labService";
            this.labService.Size = new System.Drawing.Size(53, 12);
            this.labService.TabIndex = 4;
            this.labService.Text = "service:";
            // 
            // btnScript
            // 
            this.btnScript.Location = new System.Drawing.Point(6, 26);
            this.btnScript.Name = "btnScript";
            this.btnScript.Size = new System.Drawing.Size(75, 23);
            this.btnScript.TabIndex = 0;
            this.btnScript.Text = "script";
            this.btnScript.UseVisualStyleBackColor = true;
            this.btnScript.Click += new System.EventHandler(this.btnScript_Click);
            // 
            // txbScript
            // 
            this.txbScript.Location = new System.Drawing.Point(87, 28);
            this.txbScript.Name = "txbScript";
            this.txbScript.Size = new System.Drawing.Size(186, 21);
            this.txbScript.TabIndex = 1;
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(87, 74);
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(186, 21);
            this.txbLog.TabIndex = 3;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(6, 72);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 239);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmMain";
            this.Text = "ScriptExecutor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl.ResumeLayout(false);
            this.tabConn.ResumeLayout(false);
            this.tabConn.PerformLayout();
            this.tabFolder.ResumeLayout(false);
            this.tabFolder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabConn;
        private System.Windows.Forms.TabPage tabFolder;
        private System.Windows.Forms.TextBox txbHost;
        private System.Windows.Forms.Label labHost;
        private System.Windows.Forms.Label labPort;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labService;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbScript;
        private System.Windows.Forms.Button btnScript;
        private System.Windows.Forms.TextBox txbLog;
        private System.Windows.Forms.Button btnLog;


    }
}

