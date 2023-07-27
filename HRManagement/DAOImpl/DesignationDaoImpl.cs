using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;

using HRManagement.DAO;
using HRManagement.Models;
using HRManagement.Util;

namespace HRManagement.DAOImpl
{
    public class DesignationDaoImpl : DesignationDao
    {
        private SqliteConnection _conn;
        private string _tableName;
        private string _refTableName;
        public DesignationDaoImpl(SqliteConnection conn)
        {
            _conn = conn;
            _tableName = HRManagementTable.DESIGNATION.ToString();
            _refTableName = HRManagementTable.DEPARTMENT.ToString();
        }

        //Check newly designation is getting duplicate before inserting
        public bool IsRecordExists(string designationName, int departmentId)
        {
            string query = $"SELECT * FROM {_tableName} WHERE DESIGNATION=@DesignationName AND DEPARTMENT_ID=@DepartmentId";

            using (SqliteCommand command = new SqliteCommand(query, _conn))
            {
                // Add parameters to the query
                command.Parameters.AddWithValue("@DesignationName", designationName);
                command.Parameters.AddWithValue("@DepartmentId", departmentId);


                // Execute the query and check if any rows are returned
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }

        public bool Delete(int id)
        {
            // Create the SQL command to delete the record
            string deleteQuery = $"DELETE FROM {_tableName} WHERE Id = @Id";

            using (SqliteCommand command = new SqliteCommand(deleteQuery, _conn))
            {
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

        public bool Insert(Designation designation)
        {
            using (SqliteCommand command = _conn.CreateCommand())
            {

                // Insert multiple records using a transaction
                using (SqliteTransaction transaction = _conn.BeginTransaction())
                {
                    // Insert a single record
                    command.CommandText = $"INSERT INTO {_tableName} (DESIGNATION, DEPARTMENT_ID) VALUES (@Designation, @DepartmentId); SELECT last_insert_rowid()";
                    command.Parameters.AddWithValue("@Designation", designation.Name);
                    command.Parameters.AddWithValue("@DepartmentId", designation.Department.Id);


                    long generatedId = (long)command.ExecuteScalar();
                    Console.WriteLine($"Auto-generated ID: {generatedId}");

                    designation.Id = (int)generatedId;

                    transaction.Commit();
                    return true;
                }
            }
        }

        public bool Update(Designation designation)
        {
            using (SqliteCommand command = _conn.CreateCommand())
            {

                // Insert multiple records using a transaction
                using (SqliteTransaction transaction = _conn.BeginTransaction())
                {
                    // Insert a single record
                    command.CommandText = $"UPDATE {_tableName} SET DESIGNATION = @Designation, DEPARTMENT_ID = @DepartmentId WHERE ID = @Id";
                    command.Parameters.AddWithValue("@Designation", designation.Name);
                    command.Parameters.AddWithValue("@DepartmentId", designation.Department.Id);
                    command.Parameters.AddWithValue("@Id", designation.Id);

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

        public Designation Read(int id)
        {
            string query = $"SELECT {_tableName}.*, {_refTableName}.* " +
                           $"FROM {_tableName} " +
                           $"INNER JOIN {_refTableName} ON {_tableName}.DEPARTMENT_ID = {_refTableName}.ID " +
                           $"WHERE {_tableName}.ID = @Id";

            Designation designation = null;
            using (SqliteCommand command = new SqliteCommand(query, _conn))
            {
                command.Parameters.AddWithValue("@Id", id);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        designation = new Designation()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("ID")),
                            Name = reader.GetString(reader.GetOrdinal("DESIGNATION")),
                            Department = new Department(reader.GetInt32(reader.GetOrdinal("DEPARTMENT_ID")), reader.GetString(reader.GetOrdinal("DEPARTMENT")))
                        };
                    }
                }
            }
            return designation;
        }

        public IList<Designation> ReadAll()
        {
            string query = $"SELECT {_tableName}.*, {_refTableName}.* " +
                           $"FROM {_tableName} " +
                           $"INNER JOIN {_refTableName} ON {_tableName}.DEPARTMENT_ID = {_refTableName}.ID;";

            IList<Designation> designations = new List<Designation>();

            try
            {
                using (SqliteCommand command = new SqliteCommand(query, _conn))
                {
                    using (SqliteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            designations.Add(new Designation()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                Name = reader.GetString(reader.GetOrdinal("DESIGNATION")),
                                Department = new Department(reader.GetInt32(reader.GetOrdinal("DEPARTMENT_ID")), reader.GetString(reader.GetOrdinal("DEPARTMENT")))
                            });
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
            return designations;
        }


    }
}
