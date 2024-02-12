using FreeTestManager.Core.ManagerInterfaces;
using FreeTestManager.Entities;
using System.IO;
using System.Text.Json;


namespace FreeTestManager.Core.Providers.Implementations
{
    public class FileTestProvider : ITestProvider
    {
        public string BaseDirectoryPath { get; set; }

        public FileTestProvider() 
        {
            BaseDirectoryPath = Directory.GetCurrentDirectory() + "\\tasks";
            if (!Directory.Exists(BaseDirectoryPath))
            {
                Directory.CreateDirectory(BaseDirectoryPath);
            }
            
        }
        public FileTestProvider(string baseDirectoryPath)
        {
            BaseDirectoryPath = baseDirectoryPath;
        }

        public Test Load(string title)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                return null;
            }
            string path = $"{BaseDirectoryPath}/{title}.json";
            string json;

            using (StreamReader fileStream = new StreamReader(path))
            {
                json = fileStream.ReadToEnd();
            }

            Test test = JsonSerializer.Deserialize<Test>(json);

            return test;
        }

        public bool Save(Test test)
        {
            if (string.IsNullOrWhiteSpace(test.Title))
            {
                return false;
            }
            string path = $"{BaseDirectoryPath}/{test.Title}.json";

            using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fileStream, test);
            }
            return true;
        }
    }
}
