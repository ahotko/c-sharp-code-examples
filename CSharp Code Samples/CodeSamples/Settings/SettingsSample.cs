using System;

namespace CodeSamples.Settings
{
    public class SettingsSample : SampleExecute
    {
        private void LoadMainSettings()
        {
            Console.WriteLine($"SettingString = {Properties.Settings.Default.SettingString}");
            Console.WriteLine($"SettingInt = {Properties.Settings.Default.SettingInt}");
        }

        private void LoadOtherSettings()
        {
            Console.WriteLine($"SomeOtherStringSetting = {Properties.OtherSettings.Default.SomeOtherStringSetting}");
            Console.WriteLine($"SomeOtherIntSetting = {Properties.OtherSettings.Default.SomeOtherIntSetting}");
        }

        private void StoreMainSettings()
        {
            Properties.Settings.Default.SettingString = DateTime.Now.ToString();
            Properties.Settings.Default.SettingInt = DateTime.Now.Second;
            Properties.Settings.Default.Save();
        }

        private void StoreOtherSettings()
        {
            Properties.OtherSettings.Default.SomeOtherStringSetting = DateTime.Now.ToString();
            Properties.OtherSettings.Default.SomeOtherIntSetting = DateTime.Now.Second;
            Properties.OtherSettings.Default.Save();
        }

        public override void Execute()
        {
            Title("SettingsSampleExecute");

            StoreMainSettings();
            StoreOtherSettings();

            LoadMainSettings();
            LoadOtherSettings();

            var configurationManagerSnippets = new ConfigurationManagerSnippets();
            configurationManagerSnippets.Run();

            Finish();
        }
    }
}
