using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IPI201_FIN
{
    public partial class ApproveLeaveForm : Form
    {
        public ApproveLeaveForm()
        {
            InitializeComponent();
        }

        private void ApproveLeaveForm_Load(object sender, EventArgs e)
        {
            LoadLeaveRequests();
        }

        private void LoadLeaveRequests()
        {
            try
            {
                GetData gd = new GetData();
                DataTable dt = gd.GetAllLeaveRequests();

                cmb_approve_leave_request.Items.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    cmb_approve_leave_request.Items.Add(
                        row["رقم_الطلب"].ToString() + " | " +
                        row["الاسم_الكامل"].ToString() + " | " +
                        row["تاريخ_البداية"].ToString()
                    );
                }

                if (cmb_approve_leave_request.Items.Count > 0)
                    cmb_approve_leave_request.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }

        private void btn_approve_leave_yes_Click(object sender, EventArgs e)
        {
            ApproveOrReject(true);
        }

        private void btn_approve_leave_no_Click(object sender, EventArgs e)
        {
            ApproveOrReject(false);
        }

        private void ApproveOrReject(bool approved)
        {
            if (cmb_approve_leave_request.SelectedItem == null)
            {
                MessageBox.Show("الرجاء اختيار طلب إجازة");
                return;
            }

            string selected = cmb_approve_leave_request.SelectedItem.ToString();
            string requestId = selected.Split('|')[0].Trim();

            if (!SQL_DO_IT.OpenConntion()) return;

            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE طلبات_الإجازات SET الموافق = @approved WHERE رقم_الطلب = @id",
                    SQL_DO_IT.CON_all))
                {
                    cmd.Parameters.AddWithValue("@approved", approved ? 1 : 0);
                    cmd.Parameters.AddWithValue("@id", Guid.Parse(requestId));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show(approved ? "تمت الموافقة ✅" : "تم الرفض ❌");
                    LoadLeaveRequests();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
            finally
            {
                SQL_DO_IT.CloseConntion();
            }
        }

        private void btn_approve_leave_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_approve_leave_title_Click(object sender, EventArgs e)
        {

        }
    }
}