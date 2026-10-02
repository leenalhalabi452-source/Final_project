using System;
using System.Windows.Forms;
//using MedicalComplexApp.Control;
//using MedicalComplexApp.SQL;

namespace IPI201_FIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ============================================================
        // عند تحميل الفورم
        // ============================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginInitializer.DisableLoginFields(
                txt_login_username,
                txt_login_password,
                btn_login_login);
        }

        // ============================================================
        // زر التحقق من السيرفر
        // ============================================================
        private void btn_login_verify_server_Click(object sender, EventArgs e)
        {
            if (!LoginInitializer.ValidateInputs(txt_login_server_name))
                return;

            bool result = DatabaseInitializer.CreateFullStructure("MedicalComplexApplication");

            if (result)
            {
                LoginInitializer.ShowSuccess("تم التحقق من السيرفر وإنشاء قاعدة البيانات بنجاح ✅");

                LoginInitializer.EnableLoginFields(
                    txt_login_username,
                    txt_login_password,
                    btn_login_login);

                LoginInitializer.LockServerField(
                    txt_login_server_name,
                    btn_login_verify_server);
            }
            else
            {
                LoginInitializer.ShowError("فشل الاتصال بالسيرفر أو إنشاء قاعدة البيانات ❌");
            }


        }

        // ============================================================
        // زر تسجيل الدخول
        // ============================================================
        private void btn_login_login_Click(object sender, EventArgs e)
        {
            if (!LoginInitializer.ValidateInputs(txt_login_username, txt_login_password))
                return;

            GetData gd = new GetData();
            model m = gd.Login(txt_login_username.Text.Trim(), txt_login_password.Text.Trim());

            if (m != null)
            {
                LoginInitializer.ShowSuccess($"مرحباً {m.Name}\nالصلاحية: {m.role}");
                LoginInitializer.OpenFormByRole(m.role, this);
            }
            else
            {
                LoginInitializer.ShowError("اسم المستخدم أو كلمة المرور غير صحيحة، أو الحساب غير نشط");
                LoginInitializer.ClearFields(txt_login_password);
                txt_login_password.Focus();
            }


        }

        private void btn_login_create_admin_Click(object sender, EventArgs e)
        {
            new FirstAdminForm().ShowDialog();
        }
    }
}