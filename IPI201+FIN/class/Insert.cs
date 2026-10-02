using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IPI201_FIN
{
    internal class Insert
    {
        public bool InsertUser(string full_name, string username, string password,
            string role, string phone, string email, int age, string gender)
        {
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@الاسم_الكامل", full_name),
                new SqlParameter("@اسم_الدخول", username),
                new SqlParameter("@كلمة_المرور", password),
                new SqlParameter("@الصلاحية", role),
                new SqlParameter("@رقم_الجوال", phone),
                new SqlParameter("@البريد_الإلكتروني", email),
                new SqlParameter("@العمر", age),
                new SqlParameter("@الجنس", gender)
            };

            return SQL_DO_IT.Exec_proc("PR_AddUser", parameters);
        }
    }
}