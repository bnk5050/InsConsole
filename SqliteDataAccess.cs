using Dapper;
using InsConsole.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsConsole
{
    public class SqliteDataAccess
    {
        public static List<Person> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Person>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<Visit> LoadVisits()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Visit>("select * from Visit", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<InsPlan> LoadPlans()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InsPlan>("select * from InsPlan", new DynamicParameters());
                return output.ToList();
            }

        }
        public static void SavePerson(Person person)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Person (FirstName, LastName) values (@FirstName, @LastName)", person);
            }
        }


        private static string LoadConnectionString(string connectionString = "Default") {

            return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
        }
    }
}
