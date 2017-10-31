using System;
using System.Data.SqlClient;

namespace DesafioConcreteSolution.Infrastructure.Context
{
    public class SqlContext
    {
        public object Execute(string sql, params SqlParameter[] parameters)
        {
            if (System.Configuration.ConfigurationManager.ConnectionStrings["DesafioConcreteSolutionsContext"] == null)
                throw new Exception("ConnectionString inválida.");

            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DesafioConcreteSolutionsContext"].ConnectionString;
            var connection = new SqlConnection(connectionString);
            var command = new SqlCommand(sql);
            command.Parameters.AddRange(parameters);
            command.Connection = connection;

            try
            {
                connection.Open();
                var result = command.ExecuteScalar();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
                command.Dispose();
            }
        }
    }
}
