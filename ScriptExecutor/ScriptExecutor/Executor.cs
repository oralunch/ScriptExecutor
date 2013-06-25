using System.Collections;
using System.IO;

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

        public ArrayList GetScript()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(scriptPath);
            FileInfo[] scriptInfo = dirInfo.GetFiles();
            ArrayList script = new ArrayList();

            foreach (FileInfo scriptFile in scriptInfo)
            {
                script.Add(scriptFile.FullName);
            }

            return script;
        }
    }
}
