using SQLite;
using System.IO;
using TODOList.Interface;
using TODOList.iOS.Database;

[assembly: Xamarin.Forms.Dependency(typeof(Database))]
namespace TODOList.iOS.Database
{
    public class Database : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "TodoList.db3";
            var especialFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryFolder = Path.Combine(especialFolder, "..", "Library");
            var directoryName = Path.Combine(libraryFolder, nomeDB);

            return new SQLiteConnection(directoryName);
        }
    }
}