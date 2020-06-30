using System;
using System.Configuration;

namespace CodeSamples.Settings
{
    internal class ConfigurationManagerSnippets
    {
        /// <summary>
        /// Add following to App.config:
        /// <example>
        ///   <code>
        /// =============================
        ///     <appSettings>
        ///       <add key="Setting1" value="May 5, 2014"/>
        ///       <add key="Setting2" value="May 6, 2014"/>
        ///     </appSettings>
        /// =============================
        ///   </code>
        /// </example>
        /// </summary>
        private void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("AppSettings is empty.");
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        Console.WriteLine("Key: {0} Value: {1}", key, appSettings[key]);
                    }
                }
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error reading app settings");
            }
        }

        public void Run()
        {
            ReadAllSettings();
        }
    }
}
