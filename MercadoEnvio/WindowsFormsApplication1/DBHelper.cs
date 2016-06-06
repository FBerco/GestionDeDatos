using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GDD
{
    //http://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C
    public static class DBHelper
    {
        //DB: DataBase
        private static SqlConnection DB;
        static DBHelper()
        {
            DB = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD1C2016;Integrated Security=True");
        }

        //SP: StoredProcedure
        public static void ExecuteNonQuery(string SP, List<SqlParameter> parametros = null)
        {
            DB.Open();
            SqlCommand command = new SqlCommand(SP, DB);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (var parametro in parametros)
            {
                command.Parameters.Add(parametro);
            }

            command.ExecuteNonQuery();
            DB.Close();
        }

        public static SqlDataReader ExecuteReader(string SP, List<SqlParameter> parametros = null)
        {
            DB.Open();
            SqlCommand command = new SqlCommand(SP, DB);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (var parametro in parametros)
            {
                command.Parameters.Add(parametro);
            }

            SqlDataReader result = command.ExecuteReader(); 
            DB.Close();
            return result;
        }
    }
}
