using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ComercioDAO
    {
        static string sqlCS;  
        static SqlCommand command;    
        static SqlDataReader reader;   

        static ComercioDAO()
        {


            sqlCS = new string(@"Data Source = DESKTOP-U9GILKK\SQLEXPRESS;
                                Database = Comercio;
                                Trusted_Connection = True;");

            command = new SqlCommand();
            command.CommandType = CommandType.Text;

        }

        public static void Cargar()
        {

            using (SqlConnection connection = new SqlConnection(sqlCS))
            {
                connection.Open();
                // Lógica

                try
                {
                    command.CommandText = "SELECT * FROM tabla";
                    connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                    }

                }
                catch (SqlException)
                {
                    throw new Exception("Error de SQL");
                }
                catch (Exception)
                {
                    throw new Exception("Error de conexión a la base de datos");
                }
            }
        }

    }

}

