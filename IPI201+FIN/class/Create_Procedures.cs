using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace IPI201_FIN
{
    internal class Create_Procedures
    {
        // ============================================================
        // 1) تسجيل الدخول
        // ============================================================
        private static readonly string PR_Login = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_Login]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_Login (@اسم_الدخول NVARCHAR(50), @كلمة_المرور NVARCHAR(255))
                AS
                    SELECT رقم_المستخدم, الاسم_الكامل, الصلاحية, هل_نشط 
                    FROM المستخدمون
                    WHERE اسم_الدخول = @اسم_الدخول 
                      AND كلمة_المرور = @كلمة_المرور 
                      AND هل_نشط = 1')
            END";

        // ============================================================
        // 2) إضافة مستخدم
        // ============================================================
        private static readonly string PR_AddUser = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddUser]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddUser (
                    @الاسم_الكامل NVARCHAR(100),
                    @اسم_الدخول NVARCHAR(50),
                    @كلمة_المرور NVARCHAR(255),
                    @الصلاحية NVARCHAR(20),
                    @رقم_الجوال NVARCHAR(15),
                    @البريد_الإلكتروني NVARCHAR(100),
                    @العمر INT,
                    @الجنس NVARCHAR(10))
                AS
                    INSERT INTO المستخدمون 
                    VALUES (NEWID(), @الاسم_الكامل, @اسم_الدخول, @كلمة_المرور, 
                            @الصلاحية, @رقم_الجوال, @البريد_الإلكتروني, @العمر, @الجنس, 1)')
            END";

        // ============================================================
        // 3) عرض كل المستخدمين
        // ============================================================
        private static readonly string PR_GetAllUsers = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllUsers]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllUsers
                AS
                    SELECT رقم_المستخدم, الاسم_الكامل, اسم_الدخول, الصلاحية, 
                           رقم_الجوال, البريد_الإلكتروني, العمر, الجنس, هل_نشط 
                    FROM المستخدمون')
            END";

        // ============================================================
        // 4) تعديل مستخدم
        // ============================================================
        private static readonly string PR_UpdateUser = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_UpdateUser]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_UpdateUser (
                    @اسم_الدخول NVARCHAR(50),
                    @الاسم_الكامل NVARCHAR(100),
                    @رقم_الجوال NVARCHAR(15),
                    @البريد_الإلكتروني NVARCHAR(100),
                    @الصلاحية NVARCHAR(20),
                    @هل_نشط BIT)
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    UPDATE المستخدمون
                    SET الاسم_الكامل = @الاسم_الكامل,
                        رقم_الجوال = @رقم_الجوال,
                        البريد_الإلكتروني = @البريد_الإلكتروني,
                        الصلاحية = @الصلاحية,
                        هل_نشط = @هل_نشط
                    WHERE رقم_المستخدم = @GUID')
            END";

        // ============================================================
        // 5) تعطيل مستخدم
        // ============================================================
        private static readonly string PR_DeleteUser = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_DeleteUser]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_DeleteUser (@اسم_الدخول NVARCHAR(50))
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    UPDATE المستخدمون SET هل_نشط = 0 WHERE رقم_المستخدم = @GUID')
            END";

        // ============================================================
        // 6) إضافة طبيب
        // ============================================================
        private static readonly string PR_AddDoctor = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddDoctor]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddDoctor (
                    @اسم_الدخول NVARCHAR(50),
                    @التخصص NVARCHAR(50),
                    @غرفة_العيادة NVARCHAR(20),
                    @ساعات_العمل NVARCHAR(100))
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    INSERT INTO الأطباء VALUES (NEWID(), @GUID, @التخصص, @غرفة_العيادة, @ساعات_العمل)')
            END";

        // ============================================================
        // 7) عرض كل الأطباء
        // ============================================================
        private static readonly string PR_GetAllDoctors = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllDoctors]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllDoctors
                AS
                    SELECT D.رقم_الطبيب, U.الاسم_الكامل, D.التخصص, 
                           D.غرفة_العيادة, D.ساعات_العمل
                    FROM الأطباء D
                    INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم')
            END";

        // ============================================================
        // 8) إضافة مريض
        // ============================================================
        private static readonly string PR_AddPatient = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddPatient]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddPatient (
                    @الاسم_الكامل NVARCHAR(100),
                    @الرقم_الوطني NVARCHAR(20),
                    @تاريخ_الميلاد DATE,
                    @العمر INT,
                    @الجنس NVARCHAR(10),
                    @رقم_الجوال NVARCHAR(15),
                    @البريد_الإلكتروني NVARCHAR(100),
                    @فصيلة_الدم NVARCHAR(5),
                    @الحساسية NVARCHAR(500),
                    @الأمراض_المزمنة NVARCHAR(500))
                AS
                    INSERT INTO المرضى VALUES (NEWID(), @الاسم_الكامل, @الرقم_الوطني, 
                        @تاريخ_الميلاد, @العمر, @الجنس, @رقم_الجوال, @البريد_الإلكتروني, 
                        @فصيلة_الدم, @الحساسية, @الأمراض_المزمنة)')
            END";

        // ============================================================
        // 9) البحث عن مريض
        // ============================================================
        private static readonly string PR_SearchPatient = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_SearchPatient]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_SearchPatient (@البحث NVARCHAR(100))
                AS
                    SELECT * FROM المرضى
                    WHERE الاسم_الكامل LIKE N''%'' + @البحث + N''%''
                       OR الرقم_الوطني = @البحث')
            END";

        // ============================================================
        // 10) تعديل مريض
        // ============================================================
        private static readonly string PR_UpdatePatient = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_UpdatePatient]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_UpdatePatient (
                    @الرقم_الوطني NVARCHAR(20),
                    @الاسم_الكامل NVARCHAR(100),
                    @رقم_الجوال NVARCHAR(15),
                    @البريد_الإلكتروني NVARCHAR(100),
                    @فصيلة_الدم NVARCHAR(5),
                    @الحساسية NVARCHAR(500),
                    @الأمراض_المزمنة NVARCHAR(500))
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المريض FROM المرضى WHERE الرقم_الوطني = @الرقم_الوطني)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المريض غير موجود'', 16, 1)
                        RETURN
                    END
                    UPDATE المرضى
                    SET الاسم_الكامل = @الاسم_الكامل,
                        رقم_الجوال = @رقم_الجوال,
                        البريد_الإلكتروني = @البريد_الإلكتروني,
                        فصيلة_الدم = @فصيلة_الدم,
                        الحساسية = @الحساسية,
                        الأمراض_المزمنة = @الأمراض_المزمنة
                    WHERE رقم_المريض = @GUID')
            END";

        // ============================================================
        // 11) إضافة عيادة
        // ============================================================
        private static readonly string PR_AddClinic = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddClinic]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddClinic (
                    @اسم_العيادة NVARCHAR(50),
                    @التخصص NVARCHAR(50),
                    @رقم_الغرفة NVARCHAR(20),
                    @هاتف_العيادة NVARCHAR(15))
                AS
                    INSERT INTO العيادات VALUES (NEWID(), @اسم_العيادة, @التخصص, @رقم_الغرفة, @هاتف_العيادة)')
            END";

        // ============================================================
        // 12) عرض كل العيادات
        // ============================================================
        private static readonly string PR_GetAllClinics = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllClinics]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllClinics
                AS
                    SELECT * FROM العيادات')
            END";

        // ============================================================
        // 13) إضافة موعد
        // ============================================================
        private static readonly string PR_AddAppointment = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddAppointment]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddAppointment (
                    @اسم_المريض NVARCHAR(100),
                    @اسم_الطبيب NVARCHAR(100),
                    @اسم_العيادة NVARCHAR(50),
                    @تاريخ_الموعد DATE,
                    @وقت_الموعد TIME)
                AS
                    DECLARE @GUID_Patient UNIQUEIDENTIFIER
                    DECLARE @GUID_Doctor UNIQUEIDENTIFIER
                    DECLARE @GUID_Clinic UNIQUEIDENTIFIER

                    SET @GUID_Patient = (SELECT رقم_المريض FROM المرضى WHERE الاسم_الكامل = @اسم_المريض)
                    SET @GUID_Doctor = (SELECT D.رقم_الطبيب FROM الأطباء D 
                                        INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                                        WHERE U.الاسم_الكامل = @اسم_الطبيب)
                    SET @GUID_Clinic = (SELECT رقم_العيادة FROM العيادات WHERE اسم_العيادة = @اسم_العيادة)

                    IF @GUID_Patient IS NULL OR @GUID_Doctor IS NULL OR @GUID_Clinic IS NULL
                    BEGIN
                        RAISERROR(N''تأكد من وجود المريض والطبيب والعيادة'', 16, 1)
                        RETURN
                    END

                    INSERT INTO المواعيد VALUES (NEWID(), @GUID_Patient, @GUID_Doctor, 
                        @GUID_Clinic, @تاريخ_الموعد, @وقت_الموعد, N''مؤكد'')')
            END";

        // ============================================================
        // 14) موعد مراجعة
        // ============================================================
        private static readonly string PR_AddFollowUpAppointment = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddFollowUpAppointment]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddFollowUpAppointment (
                    @اسم_المريض NVARCHAR(100),
                    @اسم_الطبيب NVARCHAR(100),
                    @اسم_العيادة NVARCHAR(50),
                    @تاريخ_الموعد DATE,
                    @وقت_الموعد TIME)
                AS
                    DECLARE @GUID_Patient UNIQUEIDENTIFIER
                    DECLARE @GUID_Doctor UNIQUEIDENTIFIER
                    DECLARE @GUID_Clinic UNIQUEIDENTIFIER

                    SET @GUID_Patient = (SELECT رقم_المريض FROM المرضى WHERE الاسم_الكامل = @اسم_المريض)
                    SET @GUID_Doctor = (SELECT D.رقم_الطبيب FROM الأطباء D 
                                        INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                                        WHERE U.الاسم_الكامل = @اسم_الطبيب)
                    SET @GUID_Clinic = (SELECT رقم_العيادة FROM العيادات WHERE اسم_العيادة = @اسم_العيادة)

                    IF @GUID_Patient IS NULL OR @GUID_Doctor IS NULL OR @GUID_Clinic IS NULL
                    BEGIN
                        RAISERROR(N''تأكد من وجود المريض والطبيب والعيادة'', 16, 1)
                        RETURN
                    END

                    INSERT INTO المواعيد VALUES (NEWID(), @GUID_Patient, @GUID_Doctor, 
                        @GUID_Clinic, @تاريخ_الموعد, @وقت_الموعد, N''مراجعة'')')
            END";

        // ============================================================
        // 15) عرض كل المواعيد
        // ============================================================
        private static readonly string PR_GetAllAppointments = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllAppointments]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllAppointments
                AS
                    SELECT A.رقم_الموعد, P.الاسم_الكامل AS اسم_المريض, 
                           U.الاسم_الكامل AS اسم_الطبيب,
                           C.اسم_العيادة, A.تاريخ_الموعد, A.وقت_الموعد, A.الحالة
                    FROM المواعيد A
                    INNER JOIN المرضى P ON A.رقم_المريض = P.رقم_المريض
                    INNER JOIN الأطباء D ON A.رقم_الطبيب = D.رقم_الطبيب
                    INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                    INNER JOIN العيادات C ON A.رقم_العيادة = C.رقم_العيادة')
            END";

        // ============================================================
        // 16) تعديل حالة موعد
        // ============================================================
        private static readonly string PR_UpdateAppointmentStatus = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_UpdateAppointmentStatus]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_UpdateAppointmentStatus (
                    @اسم_المريض NVARCHAR(100),
                    @تاريخ_الموعد DATE,
                    @الحالة NVARCHAR(20))
                AS
                    DECLARE @GUID_Patient UNIQUEIDENTIFIER
                    SET @GUID_Patient = (SELECT رقم_المريض FROM المرضى WHERE الاسم_الكامل = @اسم_المريض)
                    IF @GUID_Patient IS NULL
                    BEGIN
                        RAISERROR(N''المريض غير موجود'', 16, 1)
                        RETURN
                    END
                    UPDATE المواعيد
                    SET الحالة = @الحالة
                    WHERE رقم_المريض = @GUID_Patient AND تاريخ_الموعد = @تاريخ_الموعد')
            END";

        // ============================================================
        // 17) إضافة سجل طبي
        // ============================================================
        private static readonly string PR_AddMedicalRecord = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddMedicalRecord]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddMedicalRecord (
                    @اسم_المريض NVARCHAR(100),
                    @اسم_الطبيب NVARCHAR(100),
                    @تاريخ_الزيارة DATE,
                    @التشخيص NVARCHAR(500),
                    @الأعراض NVARCHAR(500),
                    @العلاج NVARCHAR(500),
                    @وصف_الدواء NVARCHAR(500),
                    @ملاحظات NVARCHAR(500),
                    @هل_يحتاج_عملية BIT,
                    @هل_يحتاج_مراجعة BIT,
                    @تاريخ_المراجعة DATE)
                AS
                    DECLARE @GUID_Patient UNIQUEIDENTIFIER
                    DECLARE @GUID_Doctor UNIQUEIDENTIFIER

                    SET @GUID_Patient = (SELECT رقم_المريض FROM المرضى WHERE الاسم_الكامل = @اسم_المريض)
                    SET @GUID_Doctor = (SELECT D.رقم_الطبيب FROM الأطباء D 
                                        INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                                        WHERE U.الاسم_الكامل = @اسم_الطبيب)

                    IF @GUID_Patient IS NULL OR @GUID_Doctor IS NULL
                    BEGIN
                        RAISERROR(N''تأكد من وجود المريض والطبيب'', 16, 1)
                        RETURN
                    END

                    INSERT INTO السجلات_الطبية VALUES (NEWID(), @GUID_Patient, @GUID_Doctor, 
                        @تاريخ_الزيارة, @التشخيص, @الأعراض, @العلاج, @وصف_الدواء, 
                        @ملاحظات, @هل_يحتاج_عملية, @هل_يحتاج_مراجعة, @تاريخ_المراجعة)')
            END";

        // ============================================================
        // 18) عرض سجلات مريض
        // ============================================================
        private static readonly string PR_GetPatientRecords = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetPatientRecords]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetPatientRecords (@اسم_المريض NVARCHAR(100))
                AS
                    DECLARE @GUID_Patient UNIQUEIDENTIFIER
                    SET @GUID_Patient = (SELECT رقم_المريض FROM المرضى WHERE الاسم_الكامل = @اسم_المريض)
                    IF @GUID_Patient IS NULL
                    BEGIN
                        RAISERROR(N''المريض غير موجود'', 16, 1)
                        RETURN
                    END
                    SELECT MR.رقم_السجل, MR.تاريخ_الزيارة, U.الاسم_الكامل AS اسم_الطبيب,
                           MR.التشخيص, MR.الأعراض, MR.العلاج, MR.وصف_الدواء, MR.ملاحظات,
                           MR.هل_يحتاج_عملية, MR.هل_يحتاج_مراجعة, MR.تاريخ_المراجعة
                    FROM السجلات_الطبية MR
                    INNER JOIN الأطباء D ON MR.رقم_الطبيب = D.رقم_الطبيب
                    INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                    WHERE MR.رقم_المريض = @GUID_Patient
                    ORDER BY MR.تاريخ_الزيارة DESC')
            END";

        // ============================================================
        // 19) عرض كل السجلات الطبية
        // ============================================================
        private static readonly string PR_GetAllMedicalRecords = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllMedicalRecords]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllMedicalRecords
                AS
                    SELECT MR.رقم_السجل, P.الاسم_الكامل AS اسم_المريض, 
                           U.الاسم_الكامل AS اسم_الطبيب,
                           MR.تاريخ_الزيارة, MR.التشخيص, MR.العلاج
                    FROM السجلات_الطبية MR
                    INNER JOIN المرضى P ON MR.رقم_المريض = P.رقم_المريض
                    INNER JOIN الأطباء D ON MR.رقم_الطبيب = D.رقم_الطبيب
                    INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم')
            END";

        // ============================================================
        // 20) تقديم طلب إجازة
        // ============================================================
        private static readonly string PR_AddLeaveRequest = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddLeaveRequest]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddLeaveRequest (
                    @اسم_الدخول NVARCHAR(50),
                    @تاريخ_البداية DATE,
                    @تاريخ_النهاية DATE,
                    @السبب NVARCHAR(200))
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    INSERT INTO طلبات_الإجازات VALUES (NEWID(), @GUID, @تاريخ_البداية, 
                        @تاريخ_النهاية, @السبب, 0)')
            END";

        // ============================================================
        // 21) عرض كل طلبات الإجازات
        // ============================================================
        private static readonly string PR_GetAllLeaveRequests = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllLeaveRequests]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllLeaveRequests
                AS
                    SELECT LR.رقم_الطلب, U.الاسم_الكامل, LR.تاريخ_البداية, 
                           LR.تاريخ_النهاية, LR.السبب, LR.الموافق
                    FROM طلبات_الإجازات LR
                    INNER JOIN المستخدمون U ON LR.رقم_المستخدم = U.رقم_المستخدم')
            END";

        // ============================================================
        // 22) الموافقة على طلب إجازة
        // ============================================================
        private static readonly string PR_ApproveLeaveRequest = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_ApproveLeaveRequest]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_ApproveLeaveRequest (
                    @اسم_الدخول NVARCHAR(50),
                    @تاريخ_البداية DATE,
                    @الموافق BIT)
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    UPDATE طلبات_الإجازات
                    SET الموافق = @الموافق
                    WHERE رقم_المستخدم = @GUID AND تاريخ_البداية = @تاريخ_البداية')
            END";

        // ============================================================
        // 23) إضافة مناوبة
        // ============================================================
        private static readonly string PR_AddShift = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddShift]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddShift (
                    @اسم_الدخول NVARCHAR(50),
                    @تاريخ_المناوبة DATE,
                    @وقت_البداية TIME,
                    @وقت_النهاية TIME,
                    @نوع_المناوبة NVARCHAR(20))
                AS
                    DECLARE @GUID_Doctor UNIQUEIDENTIFIER
                    SET @GUID_Doctor = (SELECT D.رقم_الطبيب FROM الأطباء D 
                                        INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                                        WHERE U.اسم_الدخول = @اسم_الدخول)
                    IF @GUID_Doctor IS NULL
                    BEGIN
                        RAISERROR(N''الطبيب غير موجود'', 16, 1)
                        RETURN
                    END
                    INSERT INTO المناوبات VALUES (NEWID(), @GUID_Doctor, @تاريخ_المناوبة, 
                        @وقت_البداية, @وقت_النهاية, @نوع_المناوبة)')
            END";

        // ============================================================
        // 24) عرض كل المناوبات
        // ============================================================
        private static readonly string PR_GetAllShifts = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllShifts]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllShifts
                AS
                    SELECT S.رقم_المناوبة, U.الاسم_الكامل AS اسم_الطبيب, 
                           S.تاريخ_المناوبة, S.وقت_البداية, S.وقت_النهاية, S.نوع_المناوبة
                    FROM المناوبات S
                    INNER JOIN الأطباء D ON S.رقم_الطبيب = D.رقم_الطبيب
                    INNER JOIN المستخدمون U ON D.رقم_المستخدم = U.رقم_المستخدم
                    ORDER BY S.تاريخ_المناوبة, S.وقت_البداية')
            END";

        // ============================================================
        // 25) إضافة راتب
        // ============================================================
        private static readonly string PR_AddSalary = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddSalary]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddSalary (
                    @اسم_الدخول NVARCHAR(50),
                    @شهر_الراتب NVARCHAR(20),
                    @الراتب_الأساسي DECIMAL(10,2),
                    @المكافآت DECIMAL(10,2),
                    @الخصومات DECIMAL(10,2),
                    @صافي_الراتب DECIMAL(10,2))
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    INSERT INTO الرواتب VALUES (NEWID(), @GUID, @شهر_الراتب, 
                        @الراتب_الأساسي, @المكافآت, @الخصومات, @صافي_الراتب)')
            END";

        // ============================================================
        // 26) عرض كل الرواتب
        // ============================================================
        private static readonly string PR_GetAllSalaries = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllSalaries]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllSalaries
                AS
                    SELECT S.رقم_الراتب, U.الاسم_الكامل, S.شهر_الراتب, 
                           S.الراتب_الأساسي, S.المكافآت, S.الخصومات, S.صافي_الراتب
                    FROM الرواتب S
                    INNER JOIN المستخدمون U ON S.رقم_المستخدم = U.رقم_المستخدم')
            END";

        // ============================================================
        // 27) إضافة تقييم
        // ============================================================
        private static readonly string PR_AddEvaluation = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_AddEvaluation]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_AddEvaluation (
                    @اسم_الدخول NVARCHAR(50),
                    @تاريخ_التقييم DATE,
                    @الدرجة INT,
                    @ملاحظات NVARCHAR(500))
                AS
                    DECLARE @GUID UNIQUEIDENTIFIER
                    SET @GUID = (SELECT رقم_المستخدم FROM المستخدمون WHERE اسم_الدخول = @اسم_الدخول)
                    IF @GUID IS NULL
                    BEGIN
                        RAISERROR(N''المستخدم غير موجود'', 16, 1)
                        RETURN
                    END
                    INSERT INTO تقييم_الأداء VALUES (NEWID(), @GUID, @تاريخ_التقييم, 
                        @الدرجة, @ملاحظات)')
            END";

        // ============================================================
        // 28) عرض كل التقييمات
        // ============================================================
        private static readonly string PR_GetAllEvaluations = @"
            IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PR_GetAllEvaluations]') AND type in (N'P', N'PC'))
            BEGIN
                EXEC('CREATE PROC PR_GetAllEvaluations
                AS
                    SELECT E.رقم_التقييم, U.الاسم_الكامل, E.تاريخ_التقييم, 
                           E.الدرجة, E.ملاحظات
                    FROM تقييم_الأداء E
                    INNER JOIN المستخدمون U ON E.رقم_المستخدم = U.رقم_المستخدم')
            END";

        // ============================================================
        // قائمة الإجراءات
        // ============================================================
        private static List<string> procedures = new List<string>
        {
            PR_Login,
            PR_AddUser,
            PR_GetAllUsers,
            PR_UpdateUser,
            PR_DeleteUser,
            PR_AddDoctor,
            PR_GetAllDoctors,
            PR_AddPatient,
            PR_SearchPatient,
            PR_UpdatePatient,
            PR_AddClinic,
            PR_GetAllClinics,
            PR_AddAppointment,
            PR_AddFollowUpAppointment,
            PR_GetAllAppointments,
            PR_UpdateAppointmentStatus,
            PR_AddMedicalRecord,
            PR_GetPatientRecords,
            PR_GetAllMedicalRecords,
            PR_AddLeaveRequest,
            PR_GetAllLeaveRequests,
            PR_ApproveLeaveRequest,
            PR_AddShift,
            PR_GetAllShifts,
            PR_AddSalary,
            PR_GetAllSalaries,
            PR_AddEvaluation,
            PR_GetAllEvaluations
        };

        // ============================================================
        // تنفيذ كل الإجراءات
        // ============================================================
        public static bool ExecuteAllProcedures(string sql_con)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(sql_con))
                {
                    conn.Open();

                    foreach (var procQuery in procedures)
                    {
                        using (SqlCommand cmd = new SqlCommand(procQuery, conn))
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