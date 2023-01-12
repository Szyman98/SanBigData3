using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanBigData3
{
    public class DataInsert
    {
        private string _connectionString;

        public DataInsert(string connectionString)
        {
            _connectionString = connectionString;
        }



        public void InsertToDatabase(string filePath)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using (var command = new SqlCommand("InsertFullNames", connection))
                {
                    command.CommandTimeout = 32767;
                    command.CommandType = CommandType.StoredProcedure;
                    SqlParameter parametro = new SqlParameter("@DATA", SqlDbType.Structured);
                    parametro.TypeName = "dbo.Person";
                    parametro.Value = GetData(filePath);
                    command.Parameters.Add(parametro);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }


        private static IEnumerable<SqlDataRecord> GetData(string filePath)
        {

            SqlMetaData c1Info = new("FirstName", SqlDbType.NVarChar, 50);
            SqlMetaData c2Info = new("LastName", SqlDbType.NVarChar, 50);


            SqlDataRecord record = new SqlDataRecord(new SqlMetaData[] { c1Info, c2Info, });

            using (StreamReader? reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] data = line.Split(',');
                    record.SetString(0, data[0]);
                    record.SetString(1, data[1]);
                    yield return record;
                }
            }
        }



    }
}
