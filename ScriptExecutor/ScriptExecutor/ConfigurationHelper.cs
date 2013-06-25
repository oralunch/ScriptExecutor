using System.Configuration;

namespace ScriptExecutor
{
    class ConfigurationHelper
    {
        public string GetAppConfig(string configName)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == configName)
                {
                    return ConfigurationManager.AppSettings[configName];
                }
            }

            return null;
        }

        public void UpdateAppConfig(string configName, string configValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == configName)
                {
                    isModified = true;
                }
            }

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (isModified)
            { 
                config.AppSettings.Settings.Remove(configName); 
            }
            config.AppSettings.Settings.Add(configName, configValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
