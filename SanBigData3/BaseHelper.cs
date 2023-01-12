using Dapper;
using SanBigData3.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigData3
{
    public static class BaseHelper
    {
        public static int GetPersonId(FullName nameToFind, string connectionString)
        {
            
            using (var connection = new SqlConnection(connectionString))
            {

                string query = "select Id from dbo.Persons where FirstName = @param1 and LastName = @param2";

                connection.Open();

                return connection.Query<int>(query, new { param1 = nameToFind.FirstName, param2 = nameToFind.LastName }).FirstOrDefault();
            }
        }
        public static int GetPersonId2(FullName nameToFind, string connectionString)
        {

            using (var connection = new SqlConnection(connectionString))
            {

                string query = $"select Id from dbo.Persons where FirstName like '%{nameToFind.FirstName}%' and LastName like '%{nameToFind.LastName}%'";

                connection.Open();

                return connection.Query<int>(query, new { param1 = nameToFind.FirstName, param2 = nameToFind.LastName }).FirstOrDefault();
            }
        }
    }
}
