using System;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class EditChoiceForm : Form
    {
        public EditChoiceForm()
        {
            InitializeComponent();
        }

        private void btn_edit_choice_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تعديل مستخدم - قيد الإنشاء");
            // new EditUserForm().ShowDialog();
            this.Close();
        }

        private void btn_edit_choice_clinic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تعديل عيادة - قيد الإنشاء");
            // new EditClinicForm().ShowDialog();
            this.Close();
        }

        private void btn_edit_choice_appointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("تعديل موعد - قيد الإنشاء");
            // new EditAppointmentForm().ShowDialog();
            this.Close();
        }

        private void btn_edit_choice_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_edit_choice_title_Click(object sender, EventArgs e)
        {

        }
    }
}