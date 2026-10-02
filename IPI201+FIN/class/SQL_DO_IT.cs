using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace IPI201_FIN
{
    internal class SQL_DO_IT
    {
        public static string Sql_conn;
        public static SqlConnection CON_all;

        public static void Conntion_now()
        {
            Sql_conn = File.ReadAllText("AppConnection.txt");
        }
        public static void GetCon()
        {
            CON_all = new SqlConnection(Sql_conn);
        }

        public static bool OpenConntion()
        {
            try
            {
                if (CON_all == null)
                {
                    GetCon();
                }
                CON_all.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void CloseConntion()
        {
            CON_all.Close();
        }

        public static bool Exec_proc(string procName, List<SqlParameter> parameters)
        {

            if (OpenConntion())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(procName, CON_all))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddRange(parameters.ToArray());
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    // ⚠️ هذا السطر رح يبين لك الخطأ الحقيقي
                    System.Windows.Forms.MessageBox.Show(
                        "خطأ في تنفيذ الإجراء: " + procName + "\n" +
                        ex.Message,
                        "خطأ SQL",
                        System.Windows.Forms.MessageBoxButtons.OK,
                        System.Windows.Forms.MessageBoxIcon.Error);

                    return false;
                }
                finally
                {
                    CloseConntion();
                }
            }
            return false;
        }
    }
}