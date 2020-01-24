using System.Collections.Generic;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public class MojaBaza
    {
        private string _connectionString = @"Data Source=DESKTOP-VH1486P\KOLEJKA;Initial Catalog=kolejka;User ID=admin;Password=admin";

        public int Insert(SqlCommand insertCommand)
        {
            int rowsAffected = -1;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    sqlConnection.Open();
                    adapter.InsertCommand = insertCommand;
                    insertCommand.Connection = sqlConnection;
                    rowsAffected = adapter.InsertCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
            }

            return rowsAffected;
        }

        public List<object[]> Select(SqlCommand selectCommand)
        {
            var wynik = new List<object[]>();
            int rowsAffected = -1;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter())
                {
                    sqlConnection.Open();
                    adapter.SelectCommand = selectCommand;
                    selectCommand.Connection = sqlConnection;
                    var reader = adapter.SelectCommand.ExecuteReader();


                    while (reader.Read())
                    {
                        var array = new object[reader.FieldCount];
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            array[i] = reader[i];
                        }
                        wynik.Add(array);
                    }
                    sqlConnection.Close();
                }
            }

            return wynik;
        }








    }






}
