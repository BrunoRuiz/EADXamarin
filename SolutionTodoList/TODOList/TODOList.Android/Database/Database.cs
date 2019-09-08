using SQLite;
using System.IO;
using TODOList.Droid.Database;
using TODOList.Interface;

[assembly: Xamarin.Forms.Dependency(typeof(Database))]
namespace TODOList.Droid.Database
{
    public class Database : IDatabase
    {
        public SQLiteConnection GetConnection()
        {
            var nomeDB = "TodoList.db3";
            var pathDB = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), nomeDB);

            return new SQLiteConnection(pathDB);
        }
    }
}