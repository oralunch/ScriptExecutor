using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptExecutor
{
    class Executor
    {
        private ConfigurationHelper confHelper;
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
            confHelper = new ConfigurationHelper();
            tracePath = confHelper.GetAppConfig("tracePath");
            scriptPath = confHelper.GetAppConfig("scriptPath");
        }
    }
}
