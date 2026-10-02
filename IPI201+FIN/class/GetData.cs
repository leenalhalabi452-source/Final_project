using System;
using System.Data;
using System.Data.SqlClient;

namespace IPI201_FIN
{
    internal class GetData
    {
        // ============================================================
        // تسجيل الدخول
        // ============================================================
        public model Login(string username, string password)
        {
            model m = null;
            if (!SQL_DO_IT.OpenConntion()) return null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("PR_Login", SQL_DO_IT.CON_all))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@اسم_الدخول", username);
                    cmd.Parameters.AddWithValue("@كلمة_المرور", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            m = new model
                            {
                                ID = Guid.Parse(reader["رقم_المستخدم"].ToString()),
                                Name = reader["الاسم_الكامل"].ToString(),
                                role = reader["الصلاحية"].ToString()
                            };
                        }
                    }
                }
            }
            catch { return null; }
            finally { SQL_DO_IT.CloseConntion(); }

            return m;
        }

        // ============================================================
        // عرض كل المستخدمين
        // ============================================================
        public DataTable GetAllUsers()
        {
            return ExecuteTable("PR_GetAllUsers");
        }

        // ============================================================
        // عرض المناوبات
        // ============================================================
        public DataTable GetAllShifts()
        {
            return ExecuteTable("PR_GetAllShifts");
        }

        // ============================================================
        // عرض طلبات الإجازات
        // ============================================================
        public DataTable GetAllLeaveRequests()
        {
            return ExecuteTable("PR_GetAllLeaveRequests");
        }

        // ============================================================
        // عرض المواعيد
        // ============================================================
        public DataTable GetAllAppointments()
        {
            return ExecuteTable("PR_GetAllAppointments");
        }

        // ============================================================
        // عرض العيادات
        // ============================================================
        public DataTable GetAllClinics()
        {
            return ExecuteTable("PR_GetAllClinics");
        }

        // ============================================================
        // دالة مساعدة لتنفيذ أي إجراء وعرض النتيجة كـ DataTable
        // ============================================================
        private DataTable ExecuteTable(string procName)
        {
            DataTable dt = new DataTable();
            if (!SQL_DO_IT.OpenConntion()) return dt;

            try
            {
                using (SqlCommand cmd = new SqlCommand(procName, SQL_DO_IT.CON_all))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch { }
            finally { SQL_DO_IT.CloseConntion(); }

            return dt;
        }
    }
}