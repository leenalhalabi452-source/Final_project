using System;
using System.Data.SqlClient;
using System.IO;

namespace IPI201_FIN
{
    internal class Create_DB
    {
        private static readonly string filePath = "SQL Connection.txt";
        private static string GetConnectionString()
        {
            return File.ReadAllText(filePath);
        }

        public static bool CreateDatabase(string dbName)
        {
            string createDbQuery = $@"
                IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = '{dbName}')
                BEGIN
                    CREATE DATABASE [{dbName}];
                END;";

            try
            {
                string connectionString = GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(createDbQuery, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}