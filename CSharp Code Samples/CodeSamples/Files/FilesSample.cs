using System;
using System.IO;
using System.Reflection;

namespace CodeSamples.Files
{
    public class FilesSample : SampleExecute
    {
        private void GetExecutableLocation()
        {
            var uri = new Uri(Assembly.GetEntryAssembly().GetName().CodeBase);
            string location = new FileInfo(uri.AbsolutePath).FullName;

            Console.WriteLine($"Executable Location = {location}");
        }

        private void GetExecutablePath()
        {
            var uri = Assembly.GetExecutingAssembly().GetName().CodeBase;
            string location = Path.GetDirectoryName(uri);

            Console.WriteLine($"Executable Path = {location}");
        }

        private void GetSpecialFolders()
        {
            Console.WriteLine($"Desktop Location = {Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}");

            Console.WriteLine($"Application Data Location = {Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}");
            Console.WriteLine($"Local Application Data Location = {Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}");

            Console.WriteLine($"Common Documents Location = {Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments)}");
            Console.WriteLine($"My Documents Location = {Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}");

            Console.WriteLine($"Common Program Files Location = {Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles)}");
            Console.WriteLine($"Common Program Files (x86) Location = {Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86)}");

            Console.WriteLine($"Program Files Location = {Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)}");
            Console.WriteLine($"Program Files (x86) Location = {Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)}");

            Console.WriteLine($"User Profile Location = {Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}");
            Console.WriteLine($"Windows Location = {Environment.GetFolderPath(Environment.SpecialFolder.Windows)}");
        }

        public override void Execute()
        {
            Title("FilesSampleExecute");

            GetExecutableLocation();
            GetExecutablePath();
            GetSpecialFolders();

            Finish();
        }
    }
}
