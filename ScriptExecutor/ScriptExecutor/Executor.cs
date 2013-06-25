
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
    }
}
