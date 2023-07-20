using System;
using Mono.Data.Sqlite;
namespace HRManagement.Util
{
    public class DBTableChecker
    {
        private DBTableChecker(){}

        public static bool IsTableExists(string tableName, string databasePath)
        {
            bool tableExists = false;

            using (SqliteConnection connection = new SqliteConnection(databasePath))
            {
                connection.Open();

                using (SqliteCommand command = connection.CreateCommand())
                {
                    // Query the SQLite master table to check if the specified table exists
                    command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName";
                    command.Parameters.AddWithValue("@tableName", tableName);

                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            tableExists = true;
                        }
                    }
                }

                connection.Close();
            }

            return tableExists;
        }

        /// <summary>
        /// Checking if a given the table exists or not.
        /// </summary>
        /// <returns><c>true</c>, if table exists on table, <c>false</c> otherwise.</returns>
        /// <param name="tableName">Table name.</param>
        /// <param name="connection">Connection.</param>
        public static bool IsTableExists(string tableName, SqliteConnection connection)
        {
            bool tableExists = false;

            using (SqliteCommand command = connection.CreateCommand())
            {
                // Query the SQLite master table to check if the specified table exists
                command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name=@tableName";
                command.Parameters.AddWithValue("@tableName", tableName);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        tableExists = true;
                    }
                }
            }

            return tableExists;
        }

    }
}
