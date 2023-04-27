using System.Data.SqlClient;

namespace SingleResponsibilityFormsApp
{
    public class DbHelper
    {
        SqlConnection sqlConnection = null;
        public DbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            SqlCommand sqlCommand = new SqlCommand(query);
            foreach (var item in parameters)
            {
                sqlCommand.Parameters.AddWithValue(item.Key, item.Value);
            }
            sqlConnection.Open();
            var affectedRowsCount = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            return affectedRowsCount;
        }
    }
}
