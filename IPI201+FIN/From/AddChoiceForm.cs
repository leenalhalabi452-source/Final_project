using System;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class AddChoiceForm : Form
    {
        public AddChoiceForm()
        {
            InitializeComponent();
        }

        private void btn_add_choice_user_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سيتم فتح فورم إضافة مستخدم");
            // new AddUserForm().ShowDialog();
            this.Close();
        }

        private void btn_add_choice_doctor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سيتم فتح فورم إضافة طبيب");
            // new AddDoctorForm().ShowDialog();
            this.Close();
        }

        private void btn_add_choice_clinic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سيتم فتح فورم إضافة عيادة");
            // new AddClinicForm().ShowDialog();
            this.Close();
        }

        private void btn_add_choice_shift_Click(object sender, EventArgs e)
        {
            MessageBox.Show("سيتم فتح فورم إضافة مناوبة");
            // new AddShiftForm().ShowDialog();
            this.Close();
        }

        private void btn_add_choice_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddChoiceForm_Load(object sender, EventArgs e)
        {

        }
    }
}