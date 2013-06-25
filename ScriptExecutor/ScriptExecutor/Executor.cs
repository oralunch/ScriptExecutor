using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptExecutor
{
    class Executor
    {
        ConfigurationHelper confHelper;
        string tracePath;
        string scriptPath;

        public Executor()
        {
            confHelper = new ConfigurationHelper();
            tracePath = confHelper.GetAppConfig("tracePath");
            scriptPath = confHelper.GetAppConfig("scriptPath");
        }
    }
}
