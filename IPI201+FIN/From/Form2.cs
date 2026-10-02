using System;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            WireUpButtons();
        }

        private void WireUpButtons()
        {
            btn_admin_view_employees.Click += btn_admin_view_employees_Click;
            btn_admin_view_shifts.Click += btn_admin_view_shifts_Click;
            btn_admin_view_leaves.Click += btn_admin_view_leaves_Click;
            btn_admin_view_appointments.Click += btn_admin_view_appointments_Click;
            btn_admin_view_clinics.Click += btn_admin_view_clinics_Click;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btn_admin_view_employees_Click(null, null);
        }

        private void btn_admin_view_employees_Click(object sender, EventArgs e)
        {
            try
            {
                GetData gd = new GetData();
                dgv_admin_display.DataSource = gd.GetAllUsers();
                label1.Text = " عرض الموظفين";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العرض: " + ex.Message);
            }
        }

        private void btn_admin_view_shifts_Click(object sender, EventArgs e)
        {
            try
            {
                GetData gd = new GetData();
                dgv_admin_display.DataSource = gd.GetAllShifts();
                label1.Text = " جدول المناوبات";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العرض: " + ex.Message);
            }
        }

        private void btn_admin_view_leaves_Click(object sender, EventArgs e)
        {
            try
            {
                GetData gd = new GetData();
                dgv_admin_display.DataSource = gd.GetAllLeaveRequests();
                label1.Text = " طلبات الإجازات";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العرض: " + ex.Message);
            }
        }

        private void btn_admin_view_appointments_Click(object sender, EventArgs e)
        {
            try
            {
                GetData gd = new GetData();
                dgv_admin_display.DataSource = gd.GetAllAppointments();
                label1.Text = " مواعيد العيادات";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العرض: " + ex.Message);
            }
        }

        private void btn_admin_view_clinics_Click(object sender, EventArgs e)
        {
            try
            {
                GetData gd = new GetData();
                dgv_admin_display.DataSource = gd.GetAllClinics();
                label1.Text = "اسم الموظف: عرض العيادات";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العرض: " + ex.Message);
            }
        }
        // ============================================================
        // زر إضافة - يفتح فورم اختيار النوع
        // ============================================================
        private void btn_admin_add_Click(object sender, EventArgs e)
        {
            AddChoiceForm frm = new AddChoiceForm();
            ShowFormInPanel(frm);
        }

        // ============================================================
        // زر تعديل
        // ============================================================
        private void btn_admin_edit_Click(object sender, EventArgs e)
        {

            EditChoiceForm frm = new EditChoiceForm();
            ShowFormInPanel(frm);
        }

        // ============================================================
        // زر حذف
        // ============================================================
        private void btn_admin_delete_Click(object sender, EventArgs e)
        {
            DeleteChoiceForm frm = new DeleteChoiceForm();
            ShowFormInPanel(frm);
        }

        // ============================================================
        // زر الموافقة على إجازة
        // ============================================================
        private void btn_admin_approve_leave_Click(object sender, EventArgs e)
        {
            // نعرض طلبات الإجازات أولاً
            btn_admin_view_leaves_Click(null, null);

            // بعدين نفتح فورم الموافقة
            ApproveLeaveForm frm = new ApproveLeaveForm();
            ShowFormInPanel(frm);
        }
        // ============================================================
        // دالة مساعدة لعرض فورم داخل panel1
        // ============================================================
        private void ShowFormInPanel(Form form)
        {
            // نحذف أي عنصر موجود في panel1
            panel1.Controls.Clear();

            // نجعل الفورم بدون إطار
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // نضيفه داخل panel1
            panel1.Controls.Add(form);
            form.Show();
        }

        private void btn_admin_approve_leave_Click_1(object sender, EventArgs e)
        {
            ApproveLeaveForm frm = new ApproveLeaveForm();
            ShowFormInPanel(frm);


        }
    }
}