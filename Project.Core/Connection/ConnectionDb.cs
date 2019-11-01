using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Project.Core.Connection
{
    public class ConnectionDb :Helper.TryCatchAction,Interface.IConnectionDb
    {
        public SqlConnection _conn;
        public SqlCommand _cmd;
        public SqlDataReader _rdr;
        public object obj;
        public int result;
        private readonly string _connStr = @"Data Source=.\SqlExpress;Initial Catalog = BigData; Integrated Security = true";

        public void Close()
        {
            _conn.Close();
        }

        public string ConnString()
        {
            return _connStr==null ? throw new ArgumentNullException("Database değeri null döndü,buraya Error oluştur") : _connStr;
        }

        public int ExecuteNonQuery(SqlCommand cmd)
        {
            return cmd == null ? throw new ArgumentNullException("the value of cmd can not a null") : cmd.ExecuteNonQuery();
        }

        public object ExecuteScalar(SqlCommand cmd)
        {
            return cmd == null ? throw new ArgumentNullException("the value of cmd can not a null") : cmd.ExecuteScalar();
        }

        public SqlCommand GetSqlCommand(string str)
        {
            _cmd = new SqlCommand(str);
            _cmd.Connection = GetSqlConnection();
            return _cmd;
        }

        public SqlConnection GetSqlConnection()
        {
            _conn = new SqlConnection(ConnString());
            State(_conn);
            return _conn;
        }

        public SqlDataReader GetSqlDataReader(string str)
        {
            return _rdr = GetSqlCommand(str).ExecuteReader();
        }

        public void Open()
        {
            _conn.Open();
        }

        public void State(SqlConnection conn)
        {
            if (conn.State== ConnectionState.Closed)
            {
                Open();
            }
            else
            {
                Close();
            }
        }
    }
}
