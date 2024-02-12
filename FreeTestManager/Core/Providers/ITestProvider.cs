using FreeTestManager.Entities;

namespace FreeTestManager.Core.ManagerInterfaces
{
    public interface ITestProvider
    {
        string BaseDirectoryPath { get; set; }
        bool Save(Test test);
        Test Load(string title);
    }
}
