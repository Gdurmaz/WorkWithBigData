using System.Data.SqlClient;

namespace Project.Core.Interface
{
    public interface IConnectionDb
    {
        int ExecuteNonQuery(SqlCommand cmd);
        object ExecuteScalar(SqlCommand cmd);
        SqlCommand GetSqlCommand(string str);
        SqlDataReader GetSqlDataReader(string str);
        SqlConnection GetSqlConnection();
        string ConnString();
        void Close();
        void Open();
        void State(SqlConnection conn);
    }
}
