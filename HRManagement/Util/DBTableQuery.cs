using System;
using Mono.Data.Sqlite;
namespace HRManagement.Util
{
    public class DBTableQuery
    {
        private DBTableQuery()
        {
        }

        public static void CreateTable(HRManagementTable tableName, SqliteConnection conn)
        {
            string query = null;
            switch (tableName)
            {
                case HRManagementTable.DEPARTMENT:
                    query = GetDepartmentCreateQuery(tableName);
                    break;
                case HRManagementTable.DESIGNATION:
                    query = GetDesignationCreateQuery(tableName);
                    break;
                default: break;
            }
            if(query != null)
            {
                using (SqliteCommand command = conn.CreateCommand())
                {
                    command.CommandText = query;
                    command.ExecuteNonQuery();

                    Console.WriteLine($"Table '{tableName}' created successfully.");
                }
            }

        }

        private static string GetDepartmentCreateQuery(HRManagementTable tableName)
        {
            return "CREATE TABLE IF NOT EXISTS " + tableName +
                @" (
                ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                DEPARTMENT TEXT NOT NULL
                )";
        }

        private static string GetDesignationCreateQuery(HRManagementTable tableName)
        {
            return "CREATE TABLE IF NOT EXISTS " + tableName +
                @" (
                ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, 
                DESIGNATION TEXT NOT NULL
                )";
        }


    }//EOF DBTableQuery
}