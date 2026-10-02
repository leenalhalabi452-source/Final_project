using System;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class DeleteChoiceForm : Form
    {
        public DeleteChoiceForm()
        {
            InitializeComponent();
        }

        private void btn_delete_choice_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حذف مستخدم - قيد الإنشاء");
            // new DeleteUserForm().ShowDialog();
            this.Close();
        }

        private void btn_delete_choice_clinic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حذف عيادة - قيد الإنشاء");
            // new DeleteClinicForm().ShowDialog();
            this.Close();
        }

        private void btn_delete_choice_appointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حذف موعد - قيد الإنشاء");
            // new DeleteAppointmentForm().ShowDialog();
            this.Close();
        }

        private void btn_delete_choice_leave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("حذف طلب إجازة - قيد الإنشاء");
            // new DeleteLeaveForm().ShowDialog();
            this.Close();
        }

        private void btn_delete_choice_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}