using System;
using System.Data;
using Npgsql;

namespace Segundo_Parcial_POO
{
public static class DBConnection
    {
        private static string dbConnection = 
            "Server=localhost;Port=5432;User Id=postgres;Password=Carolinac15.;Database=HugoApp;";

        public static DataTable ExecuteQuery(string query)
            {
                NpgsqlConnection connection = new NpgsqlConnection(dbConnection);
                DataSet dataS = new DataSet();
                connection.Open();
            
                NpgsqlDataAdapter dataA = new NpgsqlDataAdapter(query, connection);
                dataA.Fill(dataS);
                connection.Close();
            
                return dataS.Tables[0];
            }

            public static void ExecuteNonQuery(string action)
            {
                NpgsqlConnection connection = new NpgsqlConnection(dbConnection);
                connection.Open();
            
                NpgsqlCommand command = new NpgsqlCommand(action, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }