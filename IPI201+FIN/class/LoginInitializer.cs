using System;
using System.Windows.Forms;

namespace IPI201_FIN
{
    internal static class LoginInitializer
    {
        // ============================================================
        // 1) تعطيل الحقول في البداية
        // ============================================================
        public static void DisableLoginFields(
            TextBox txtUsername,
            TextBox txtPassword,
            Button btnLogin)
        {
            txtUsername.Enabled = false;
            txtPassword.Enabled = false;
            btnLogin.Enabled = false;
        }

        // ============================================================
        // 2) تفعيل الحقول بعد التحقق
        // ============================================================
        public static void EnableLoginFields(
            TextBox txtUsername,
            TextBox txtPassword,
            Button btnLogin)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            btnLogin.Enabled = true;
            txtUsername.Focus();
        }

        // ============================================================
        // 3) قفل حقل السيرفر
        // ============================================================
        public static void LockServerField(
            TextBox txtServer,
            Button btnVerify)
        {
            txtServer.Enabled = false;
            btnVerify.Enabled = false;
        }

        // ============================================================
        // 4) تفريغ الحقول
        // ============================================================
        public static void ClearFields(params TextBox[] boxes)
        {
            foreach (var box in boxes)
            {
                box.Clear();
            }
        }

        // ============================================================
        // 5) التحقق من المدخلات
        // ============================================================
        public static bool ValidateInputs(params TextBox[] boxes)
        {
            foreach (var box in boxes)
            {
                if (string.IsNullOrWhiteSpace(box.Text))
                {
                    MessageBox.Show("الرجاء تعبئة جميع الحقول المطلوبة",
                        "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    box.Focus();
                    return false;
                }
            }
            return true;
        }

        // ============================================================
        // 6) رسائل الحالة
        // ============================================================
        public static void ShowSuccess(string message)
        {
            MessageBox.Show(message, "نجاح",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowError(string message)
        {
            MessageBox.Show(message, "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarning(string message)
        {
            MessageBox.Show(message, "تنبيه",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ============================================================
        // 7) فتح الفورم حسب الصلاحية
        // ============================================================
        public static void OpenFormByRole(string role, Form currentForm)
        {
            Form target = null;

            switch (role)
            {
                case "مدير":
                    target = new Form2();
                     MessageBox.Show("واجهة المدير (قيد التصميم)");
                    break;
                case "HR":
                    // target = new HRForm();
                    MessageBox.Show("واجهة HR (قيد التصميم)");
                    break;
                case "موظف استعلام":
                    // target = new ReceptionForm();
                    MessageBox.Show("واجهة الاستعلام (قيد التصميم)");
                    break;
                case "طبيب":
                    // target = new DoctorForm();
                    MessageBox.Show("واجهة الطبيب (قيد التصميم)");
                    break;
                case "طبيب أشعة":
                    // target = new RadiologyForm();
                    MessageBox.Show("واجهة الأشعة (قيد التصميم)");
                    break;
                case "ممرض":
                    // target = new NurseForm();
                    MessageBox.Show("واجهة الممرض (قيد التصميم)");
                    break;
                default:
                    MessageBox.Show("لا توجد واجهة لهذه الصلاحية");
                    break;
            }

            if (target != null)
            {
                target.Show();
                currentForm.Hide();
            }
        }
    }
}