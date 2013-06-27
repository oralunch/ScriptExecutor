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

            foreach (FileInfo scriptFile in scriptInfo.o)
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
                proc.StartInfo.Arguments = "sys/oracle@localhost:1521/orcl as sysdba @" + script;
                System.Windows.Forms.MessageBox.Show(script);

                proc.Start();
                string output = proc.StandardOutput.ReadToEnd();
                System.Windows.Forms.MessageBox.Show(output);
            }

            //proc.WaitForExit();
            proc.Close();
        }
    }
}
