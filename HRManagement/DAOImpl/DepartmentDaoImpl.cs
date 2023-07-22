using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

using HRManagement.DAO;
using HRManagement.Models;
using HRManagement.Util;

namespace HRManagement.DAOImpl
{
    public class DepartmentDaoImpl : DepartmentDao
    {
        private SqliteConnection _conn;
        private string _tableName;
        public DepartmentDaoImpl(SqliteConnection conn)
        {
            _conn = conn;
            _tableName = HRManagementTable.DEPARTMENT.ToString();
        }

        public bool Insert(Department department)
        {
            using (SqliteCommand command = _conn.CreateCommand())
            {

                // Insert multiple records using a transaction
                using (SqliteTransaction transaction = _conn.BeginTransaction())
                {
                    // Insert a single record
                    command.CommandText = $"INSERT INTO {_tableName} (DEPARTMENT) VALUES (@DEPARTMENT); SELECT last_insert_rowid()";
                    command.Parameters.AddWithValue("@DEPARTMENT", department.Name);
                    //command.ExecuteNonQuery();


                    long generatedId = (long)command.ExecuteScalar();
                    Console.WriteLine($"Auto-generated ID: {generatedId}");

                    department.Id = (int) generatedId;

                    transaction.Commit();
                    return true;
                }
            }
        }

        public bool Delete(int id)
        {
            // Create the SQL command to delete the record
            string deleteQuery = $"DELETE FROM {_tableName} WHERE Id = @Id";

            using (SqliteCommand command = new SqliteCommand(deleteQuery, _conn))
            {
                // Insert multiple records using a transaction
                using (SqliteTransaction transaction = _conn.BeginTransaction())
                {
                    // Add the ID parameter to the command
                    command.Parameters.AddWithValue("@Id", id);

                    // Execute the DELETE command
                    int rowsAffected = command.ExecuteNonQuery();

                    transaction.Commit();

                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public Department Read(int id)
        {
            Department department = null;
            using (SqliteCommand command = _conn.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {_tableName} WHERE id = @Id";
                command.Parameters.AddWithValue("@Id", id);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        department = new Department()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        };
                    }
                }
            }
            return department;
        }

        public IList<Department> ReadAll()
        {
            IList<Department> departments = new List<Department>();

            using (SqliteCommand command = _conn.CreateCommand())
            {
                command.CommandText = $"SELECT * FROM {_tableName}";

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        departments.Add(new Department() { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                    }
                }
            }
            return departments;
        }

        public bool Update(Department department)
        {
            throw new NotImplementedException();
        }

        public bool IsRecordExists(string departmentName)
        {
            string query = $"SELECT * FROM {_tableName} WHERE DEPARTMENT=@DepartmentName";

            using (SqliteCommand command = new SqliteCommand(query, _conn))
            {
                // Add parameters to the query
                command.Parameters.AddWithValue("@DepartmentName", departmentName);

                // Execute the query and check if any rows are returned
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
    }
}
