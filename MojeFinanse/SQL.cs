using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Serialization.Formatters;
using System.Data.Common;

namespace MojeFinanse
{
    class SQL
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MojeFinanse;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection connection;

        public SQL()
        // constructor connects with the database and throws exception when could not connect
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            if (connection.State != System.Data.ConnectionState.Open)
                throw new Exception("Połączenie z bazą danych nie udało się.\n" + connection.State.ToString());
        }

        ~SQL()
        {
            connection.Close();
        }

        public object runSelect(string sql)
        // OK = returns list of dictionaries with values
        // not OK = returns string with error message
        { 
            try
            {
                var sqlCommand = new SqlCommand(sql, connection);

                var reader = sqlCommand.ExecuteReader();

                if (!reader.HasRows)
                    return null;

                var result = new List<Dictionary<string, string>>();

                while (reader.Read())
                {
                    var record = new Dictionary<string, string>();
                    foreach (var field in reader.GetColumnSchema())
                        record.Add(field.ColumnName, reader.GetString(field.ColumnOrdinal.Value));

                    result.Add(record);
                }

                return result;
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string runProcedure(string sql, Dictionary<string, string> parameters)
        // OK = returns empty string and set values in dictionary
        // not OK = return string with error message
        {
            try
            {
                var sqlCommand = new SqlCommand(sql, connection);
             
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                foreach (var parameter in parameters)
                {
                    if (parameter.Value == null)
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value).Direction = System.Data.ParameterDirection.ReturnValue;

                    else
                        sqlCommand.Parameters.AddWithValue(parameter.Key, parameter.Value).Direction = System.Data.ParameterDirection.Input;
                }

                sqlCommand.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                return ex.Message;
            }

            return "";
        }

        public string runSql(string sql)
        // OK = returns empty string
        // not OK = returns string with error message
        {
            try
            {
                var sqlCommand = new SqlCommand(sql, connection);
                sqlCommand.ExecuteNonQuery();
                return "";
            }

            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
