using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IPI201_FIN
{
    internal class Create_Tables
    {
        private static readonly string Table_Users = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'المستخدمون')
            BEGIN
                CREATE TABLE المستخدمون (
                    رقم_المستخدم UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    الاسم_الكامل NVARCHAR(100) NOT NULL,
                    اسم_الدخول NVARCHAR(50) UNIQUE NOT NULL,
                    كلمة_المرور NVARCHAR(255) NOT NULL,
                    الصلاحية NVARCHAR(20) NOT NULL,
                    رقم_الجوال NVARCHAR(15),
                    البريد_الإلكتروني NVARCHAR(100),
                    العمر INT,
                    الجنس NVARCHAR(10),
                    هل_نشط BIT DEFAULT 1
                )
            END;";

        private static readonly string Table_Doctors = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'الأطباء')
            BEGIN
                CREATE TABLE الأطباء (
                    رقم_الطبيب UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_المستخدم UNIQUEIDENTIFIER NOT NULL UNIQUE,
                    التخصص NVARCHAR(50) NOT NULL,
                    غرفة_العيادة NVARCHAR(20),
                    ساعات_العمل NVARCHAR(100),
                    FOREIGN KEY (رقم_المستخدم) REFERENCES المستخدمون(رقم_المستخدم)
                )
            END;";

        private static readonly string Table_Patients = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'المرضى')
            BEGIN
                CREATE TABLE المرضى (
                    رقم_المريض UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    الاسم_الكامل NVARCHAR(100) NOT NULL,
                    الرقم_الوطني NVARCHAR(20) UNIQUE NOT NULL,
                    تاريخ_الميلاد DATE,
                    العمر INT,
                    الجنس NVARCHAR(10),
                    رقم_الجوال NVARCHAR(15),
                    البريد_الإلكتروني NVARCHAR(100),
                    فصيلة_الدم NVARCHAR(5),
                    الحساسية NVARCHAR(500),
                    الأمراض_المزمنة NVARCHAR(500)
                )
            END;";

        private static readonly string Table_Clinics = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'العيادات')
            BEGIN
                CREATE TABLE العيادات (
                    رقم_العيادة UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    اسم_العيادة NVARCHAR(50) NOT NULL,
                    التخصص NVARCHAR(50) NOT NULL,
                    رقم_الغرفة NVARCHAR(20),
                    هاتف_العيادة NVARCHAR(15)
                )
            END;";

        private static readonly string Table_Appointments = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'المواعيد')
            BEGIN
                CREATE TABLE المواعيد (
                    رقم_الموعد UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_المريض UNIQUEIDENTIFIER NOT NULL,
                    رقم_الطبيب UNIQUEIDENTIFIER NOT NULL,
                    رقم_العيادة UNIQUEIDENTIFIER NOT NULL,
                    تاريخ_الموعد DATE NOT NULL,
                    وقت_الموعد TIME NOT NULL,
                    الحالة NVARCHAR(20) DEFAULT N'مؤكد',
                    FOREIGN KEY (رقم_المريض) REFERENCES المرضى(رقم_المريض),
                    FOREIGN KEY (رقم_الطبيب) REFERENCES الأطباء(رقم_الطبيب),
                    FOREIGN KEY (رقم_العيادة) REFERENCES العيادات(رقم_العيادة)
                )
            END;";

        private static readonly string Table_MedicalRecords = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'السجلات_الطبية')
            BEGIN
                CREATE TABLE السجلات_الطبية (
                    رقم_السجل UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_المريض UNIQUEIDENTIFIER NOT NULL,
                    رقم_الطبيب UNIQUEIDENTIFIER NOT NULL,
                    تاريخ_الزيارة DATE NOT NULL,
                    التشخيص NVARCHAR(500),
                    الأعراض NVARCHAR(500),
                    العلاج NVARCHAR(500),
                    وصف_الدواء NVARCHAR(500),
                    ملاحظات NVARCHAR(500),
                    هل_يحتاج_عملية BIT DEFAULT 0,
                    هل_يحتاج_مراجعة BIT DEFAULT 0,
                    تاريخ_المراجعة DATE,
                    FOREIGN KEY (رقم_المريض) REFERENCES المرضى(رقم_المريض),
                    FOREIGN KEY (رقم_الطبيب) REFERENCES الأطباء(رقم_الطبيب)
                )
            END;";

        private static readonly string Table_LeaveRequests = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'طلبات_الإجازات')
            BEGIN
                CREATE TABLE طلبات_الإجازات (
                    رقم_الطلب UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_المستخدم UNIQUEIDENTIFIER NOT NULL,
                    تاريخ_البداية DATE NOT NULL,
                    تاريخ_النهاية DATE NOT NULL,
                    السبب NVARCHAR(200),
                    الموافق BIT DEFAULT 0,
                    FOREIGN KEY (رقم_المستخدم) REFERENCES المستخدمون(رقم_المستخدم)
                )
            END;";

        private static readonly string Table_Shifts = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'المناوبات')
            BEGIN
                CREATE TABLE المناوبات (
                    رقم_المناوبة UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_الطبيب UNIQUEIDENTIFIER NOT NULL,
                    تاريخ_المناوبة DATE NOT NULL,
                    وقت_البداية TIME NOT NULL,
                    وقت_النهاية TIME NOT NULL,
                    نوع_المناوبة NVARCHAR(20),
                    FOREIGN KEY (رقم_الطبيب) REFERENCES الأطباء(رقم_الطبيب)
                )
            END;";

        private static readonly string Table_Salaries = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'الرواتب')
            BEGIN
                CREATE TABLE الرواتب (
                    رقم_الراتب UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_المستخدم UNIQUEIDENTIFIER NOT NULL,
                    شهر_الراتب NVARCHAR(20),
                    الراتب_الأساسي DECIMAL(10,2),
                    المكافآت DECIMAL(10,2),
                    الخصومات DECIMAL(10,2),
                    صافي_الراتب DECIMAL(10,2),
                    FOREIGN KEY (رقم_المستخدم) REFERENCES المستخدمون(رقم_المستخدم)
                )
            END;";

        private static readonly string Table_Evaluations = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = N'تقييم_الأداء')
            BEGIN
                CREATE TABLE تقييم_الأداء (
                    رقم_التقييم UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
                    رقم_المستخدم UNIQUEIDENTIFIER NOT NULL,
                    تاريخ_التقييم DATE,
                    الدرجة INT,
                    ملاحظات NVARCHAR(500),
                    FOREIGN KEY (رقم_المستخدم) REFERENCES المستخدمون(رقم_المستخدم)
                )
            END;";

        private static List<string> tablesQueries = new List<string>
        {
            Table_Users,
            Table_Doctors,
            Table_Patients,
            Table_Clinics,
            Table_Appointments,
            Table_MedicalRecords,
            Table_LeaveRequests,
            Table_Shifts,
            Table_Salaries,
            Table_Evaluations
        };

        public static bool ExecuteAllTables(string sql_con)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql_con))
                {
                    conn.Open();

                    foreach (var query in tablesQueries)
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
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