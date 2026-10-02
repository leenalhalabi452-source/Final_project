using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class FirstAdminForm : Form
    {
        public FirstAdminForm()
        {
            InitializeComponent();

            // ✅ ربط الأزرار بالأحداث (ضمان)
            this.btn_first_admin_save.Click += new System.EventHandler(this.btn_first_admin_save_Click);
            this.btn_first_admin_cancel.Click += new System.EventHandler(this.btn_first_admin_cancel_Click);
        }

        // ============================================================
        // عند تحميل الفورم
        // ============================================================
        private void FirstAdminForm_Load(object sender, EventArgs e)
        {
            // فحص إذا في مدير موجود
            if (AdminExists())
            {
                MessageBox.Show("يوجد مدير بالفعل في النظام",
                    "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        // ============================================================
        // فحص وجود مدير
        // ============================================================
        private bool AdminExists()
        {
            if (!SQL_DO_IT.OpenConntion()) return true;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT COUNT(*) FROM المستخدمون WHERE الصلاحية = N'مدير'",
                    SQL_DO_IT.CON_all))
                {
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return true;
            }
            finally
            {
                SQL_DO_IT.CloseConntion();
            }
        }

        // ============================================================
        // زر حفظ
        // ============================================================
        private void btn_first_admin_save_Click(object sender, EventArgs e)
        {
            // التحقق من المدخلات
            if (string.IsNullOrWhiteSpace(txt_first_admin_name.Text) ||
                string.IsNullOrWhiteSpace(txt_first_admin_username.Text) ||
                string.IsNullOrWhiteSpace(txt_first_admin_password.Text))
            {
                MessageBox.Show("الرجاء تعبئة جميع الحقول",
                    "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_first_admin_password.Text != txt_first_admin_confirm.Text)
            {
                MessageBox.Show("كلمة المرور وتأكيدها غير متطابقين",
                    "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // إضافة المدير
            Insert ins = new Insert();
            bool result = ins.InsertUser(
                txt_first_admin_name.Text.Trim(),
                txt_first_admin_username.Text.Trim(),
                txt_first_admin_password.Text.Trim(),
                "مدير",
                "",
                "",
                0,
                "ذكر"
            );

            if (result)
            {
                MessageBox.Show("تم إنشاء حساب المدير بنجاح ✅\n" +
                    "يمكنك الآن تسجيل الدخول",
                    "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("فشل إنشاء الحساب ❌",
                    "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // زر إلغاء
        // ============================================================
        private void btn_first_admin_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}