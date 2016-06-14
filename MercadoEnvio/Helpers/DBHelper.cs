﻿using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Helpers
{
    //http://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C
    public static class DBHelper
    {
        //DB: DataBase
        public static SqlConnection DB; 
        static DBHelper()
        {
            //var connection = ConfigurationManager.ConnectionStrings["GD1C2016ConnectionString"].ConnectionString;
            DB = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD1C2016;Integrated Security=True");
        }

        //SP: StoredProcedure
        public static void ExecuteNonQuery(string SP, Dictionary<string, object> parametros = null)
        {
            DB.Open();
            SqlCommand command = new SqlCommand(SP, DB);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            foreach (var parametro in parametros)
            {
                command.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value));
            }

            command.ExecuteNonQuery();
            DB.Close();
        }

        public static SqlDataReader ExecuteReader(string SP, Dictionary<string, object> parametros = null)
        {
            DB.Open();
            SqlCommand command = new SqlCommand(SP, DB);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            if (parametros != null)
            {
                foreach (var parametro in parametros)
                {
                    command.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value));
                }
            }
            SqlDataReader result = command.ExecuteReader();
            return result;
        }
    }
}