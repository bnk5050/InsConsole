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
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("select * from Person", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<VisitModel> LoadVisits()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<VisitModel>("select * from Visit", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<InsPlanModel> LoadPlan()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<InsPlanModel>("select * from InsPlan", new DynamicParameters());
                return output.ToList();
            }

        }
        public static void SavePerson(PersonModel person)
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
