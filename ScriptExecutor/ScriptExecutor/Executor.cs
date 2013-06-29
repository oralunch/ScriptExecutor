using System.Collections;
using System.IO;
using System;
using System.Diagnostics;

namespace ScriptExecutor
{
    class Executor
    {
        private ConfigurationHelper configHelper;
        private string tracePath;
        private string scriptPath;
        private string user;
        private string password;

        public string TracePath
        {
            get { return tracePath; }
            set { tracePath = value; }
        }

        public string ScriptPath
        {
            get { return scriptPath; }
            set { scriptPath = value; }
        }

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Executor()
        {
            configHelper = new ConfigurationHelper();
            tracePath = configHelper.GetAppConfig("tracePath");
            scriptPath = configHelper.GetAppConfig("scriptPath");
        }

        /// <summary>
        /// 返回ScriptPath中排序后的脚本名(含路径)
        /// </summary>
        /// <returns></returns>
        public Array GetScript()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(scriptPath);
            FileInfo[] scriptInfo = dirInfo.GetFiles();
            ArrayList scriptArr = new ArrayList();

            foreach (FileInfo scriptFile in scriptInfo)
            {
                scriptArr.Add(scriptFile.FullName);
            }

            Array script = scriptArr.ToArray(typeof(string));
            Array.Sort(script);

            return script;
        }

        public void Execute()
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;

            foreach (string script in this.GetScript())
            {
                proc.StartInfo.FileName = "sqlplus";
                proc.StartInfo.Arguments = " sys/oracle@localhost:1521/orcl as sysdba @" + script;

                proc.Start();
                WriteTrace(proc.StandardOutput.ReadToEnd());
            }

            //proc.WaitForExit();
            proc.Close();
        }

        public void WriteTrace(string trace)
        {
            string fileName = tracePath + '/' + this.user + ".txt";
            FileStream fileStream = new FileStream(fileName, FileMode.Append);
            System.Windows.Forms.MessageBox.Show(tracePath + this.user + ".txt");
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(trace);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();
        }
    }
}
