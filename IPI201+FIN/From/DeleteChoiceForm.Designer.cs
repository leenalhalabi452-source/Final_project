namespace IPI201_FIN
{
    partial class DeleteChoiceForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lbl_delete_choice_title = new System.Windows.Forms.Label();
            this.btn_delete_choice_user = new System.Windows.Forms.Button();
            this.btn_delete_choice_clinic = new System.Windows.Forms.Button();
            this.btn_delete_choice_appointment = new System.Windows.Forms.Button();
            this.btn_delete_choice_leave = new System.Windows.Forms.Button();
            this.btn_delete_choice_cancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ================= DeleteChoiceForm =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.ClientSize = new System.Drawing.Size(400, 420);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DeleteChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختر نوع الحذف";

            // ================= lbl_delete_choice_title =================
            this.lbl_delete_choice_title.AutoSize = false;
            this.lbl_delete_choice_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_delete_choice_title.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.lbl_delete_choice_title.Location = new System.Drawing.Point(50, 20);
            this.lbl_delete_choice_title.Name = "lbl_delete_choice_title";
            this.lbl_delete_choice_title.Size = new System.Drawing.Size(300, 40);
            this.lbl_delete_choice_title.TabIndex = 0;
            this.lbl_delete_choice_title.Text = "شو بدك تحذف؟";
            this.lbl_delete_choice_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= btn_delete_choice_user =================
            this.btn_delete_choice_user.BackColor = System.Drawing.Color.FromArgb(220, 90, 90);
            this.btn_delete_choice_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_choice_user.FlatAppearance.BorderSize = 0;
            this.btn_delete_choice_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_choice_user.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_delete_choice_user.ForeColor = System.Drawing.Color.White;
            this.btn_delete_choice_user.Location = new System.Drawing.Point(100, 80);
            this.btn_delete_choice_user.Name = "btn_delete_choice_user";
            this.btn_delete_choice_user.Size = new System.Drawing.Size(200, 50);
            this.btn_delete_choice_user.TabIndex = 1;
            this.btn_delete_choice_user.Text = "👤 حذف مستخدم";
            this.btn_delete_choice_user.UseVisualStyleBackColor = false;
            this.btn_delete_choice_user.Click += new System.EventHandler(this.btn_delete_choice_user_Click);

            // ================= btn_delete_choice_clinic =================
            this.btn_delete_choice_clinic.BackColor = System.Drawing.Color.FromArgb(220, 90, 90);
            this.btn_delete_choice_clinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_choice_clinic.FlatAppearance.BorderSize = 0;
            this.btn_delete_choice_clinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_choice_clinic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_delete_choice_clinic.ForeColor = System.Drawing.Color.White;
            this.btn_delete_choice_clinic.Location = new System.Drawing.Point(100, 145);
            this.btn_delete_choice_clinic.Name = "btn_delete_choice_clinic";
            this.btn_delete_choice_clinic.Size = new System.Drawing.Size(200, 50);
            this.btn_delete_choice_clinic.TabIndex = 2;
            this.btn_delete_choice_clinic.Text = "🏥 حذف عيادة";
            this.btn_delete_choice_clinic.UseVisualStyleBackColor = false;
            this.btn_delete_choice_clinic.Click += new System.EventHandler(this.btn_delete_choice_clinic_Click);

            // ================= btn_delete_choice_appointment =================
            this.btn_delete_choice_appointment.BackColor = System.Drawing.Color.FromArgb(220, 90, 90);
            this.btn_delete_choice_appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_choice_appointment.FlatAppearance.BorderSize = 0;
            this.btn_delete_choice_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_choice_appointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_delete_choice_appointment.ForeColor = System.Drawing.Color.White;
            this.btn_delete_choice_appointment.Location = new System.Drawing.Point(100, 210);
            this.btn_delete_choice_appointment.Name = "btn_delete_choice_appointment";
            this.btn_delete_choice_appointment.Size = new System.Drawing.Size(200, 50);
            this.btn_delete_choice_appointment.TabIndex = 3;
            this.btn_delete_choice_appointment.Text = "🕐 حذف موعد";
            this.btn_delete_choice_appointment.UseVisualStyleBackColor = false;
            this.btn_delete_choice_appointment.Click += new System.EventHandler(this.btn_delete_choice_appointment_Click);

            // ================= btn_delete_choice_leave =================
            this.btn_delete_choice_leave.BackColor = System.Drawing.Color.FromArgb(220, 90, 90);
            this.btn_delete_choice_leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_choice_leave.FlatAppearance.BorderSize = 0;
            this.btn_delete_choice_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_choice_leave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_delete_choice_leave.ForeColor = System.Drawing.Color.White;
            this.btn_delete_choice_leave.Location = new System.Drawing.Point(100, 275);
            this.btn_delete_choice_leave.Name = "btn_delete_choice_leave";
            this.btn_delete_choice_leave.Size = new System.Drawing.Size(200, 50);
            this.btn_delete_choice_leave.TabIndex = 4;
            this.btn_delete_choice_leave.Text = "🌴 حذف طلب إجازة";
            this.btn_delete_choice_leave.UseVisualStyleBackColor = false;
            this.btn_delete_choice_leave.Click += new System.EventHandler(this.btn_delete_choice_leave_Click);

            // ================= btn_delete_choice_cancel =================
            this.btn_delete_choice_cancel.BackColor = System.Drawing.Color.FromArgb(180, 180, 190);
            this.btn_delete_choice_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete_choice_cancel.FlatAppearance.BorderSize = 0;
            this.btn_delete_choice_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_choice_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_delete_choice_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_delete_choice_cancel.Location = new System.Drawing.Point(100, 340);
            this.btn_delete_choice_cancel.Name = "btn_delete_choice_cancel";
            this.btn_delete_choice_cancel.Size = new System.Drawing.Size(200, 40);
            this.btn_delete_choice_cancel.TabIndex = 5;
            this.btn_delete_choice_cancel.Text = "إلغاء";
            this.btn_delete_choice_cancel.UseVisualStyleBackColor = false;
            this.btn_delete_choice_cancel.Click += new System.EventHandler(this.btn_delete_choice_cancel_Click);

            // ================= إضافة العناصر للفورم =================
            this.Controls.Add(this.lbl_delete_choice_title);
            this.Controls.Add(this.btn_delete_choice_user);
            this.Controls.Add(this.btn_delete_choice_clinic);
            this.Controls.Add(this.btn_delete_choice_appointment);
            this.Controls.Add(this.btn_delete_choice_leave);
            this.Controls.Add(this.btn_delete_choice_cancel);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lbl_delete_choice_title;
        private System.Windows.Forms.Button btn_delete_choice_user;
        private System.Windows.Forms.Button btn_delete_choice_clinic;
        private System.Windows.Forms.Button btn_delete_choice_appointment;
        private System.Windows.Forms.Button btn_delete_choice_leave;
        private System.Windows.Forms.Button btn_delete_choice_cancel;
    }
}