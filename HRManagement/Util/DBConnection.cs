using System;
using Mono.Data.Sqlite;
namespace HRManagement.Util
{
    public class DBConnection
    {
        private SqliteConnection _conn;

        private DBConnection(SqliteConnection conn)
        {
            _conn = conn;
            _conn.Open();
        }

        public static SqliteConnection GetConnection(String absolutePath)
        {
            return new SqliteConnection("Data Source=" + absolutePath);
        }

        public static SqliteConnection GetConnection(String path, String dbName)
        {
            return new SqliteConnection("Data Source=" + path + dbName);
        }

        public SqliteConnection Connection => _conn;

        public void Disconnect()
        {
            //Closed connection
            if (_conn != null)
            {
                _conn.Close();
                _conn.Dispose();
            }
        }

        public class DBConnectionBuilder
        {
            public DBConnection BuildConnection()
            {
                return new DBConnection(GetConnection(Path.DATABASE_PATH));
            }
        }

    }
}
