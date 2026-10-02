namespace IPI201_FIN
{
    partial class AddChoiceForm
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
            this.lbl_add_choice_title = new System.Windows.Forms.Label();
            this.btn_add_choice_user = new System.Windows.Forms.Button();
            this.btn_add_choice_doctor = new System.Windows.Forms.Button();
            this.btn_add_choice_clinic = new System.Windows.Forms.Button();
            this.btn_add_choice_shift = new System.Windows.Forms.Button();
            this.btn_add_choice_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_add_choice_title
            // 
            this.lbl_add_choice_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_add_choice_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lbl_add_choice_title.Location = new System.Drawing.Point(38, 16);
            this.lbl_add_choice_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_add_choice_title.Name = "lbl_add_choice_title";
            this.lbl_add_choice_title.Size = new System.Drawing.Size(225, 32);
            this.lbl_add_choice_title.TabIndex = 0;
            this.lbl_add_choice_title.Text = "شو بدك تضيف؟";
            this.lbl_add_choice_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_add_choice_user
            // 
            this.btn_add_choice_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btn_add_choice_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_choice_user.FlatAppearance.BorderSize = 0;
            this.btn_add_choice_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_choice_user.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add_choice_user.ForeColor = System.Drawing.Color.White;
            this.btn_add_choice_user.Location = new System.Drawing.Point(75, 65);
            this.btn_add_choice_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_choice_user.Name = "btn_add_choice_user";
            this.btn_add_choice_user.Size = new System.Drawing.Size(150, 41);
            this.btn_add_choice_user.TabIndex = 1;
            this.btn_add_choice_user.Text = "👤 إضافة مستخدم";
            this.btn_add_choice_user.UseVisualStyleBackColor = false;
            this.btn_add_choice_user.Click += new System.EventHandler(this.btn_add_choice_user_Click);
            // 
            // btn_add_choice_doctor
            // 
            this.btn_add_choice_doctor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btn_add_choice_doctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_choice_doctor.FlatAppearance.BorderSize = 0;
            this.btn_add_choice_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_choice_doctor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add_choice_doctor.ForeColor = System.Drawing.Color.White;
            this.btn_add_choice_doctor.Location = new System.Drawing.Point(75, 118);
            this.btn_add_choice_doctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_choice_doctor.Name = "btn_add_choice_doctor";
            this.btn_add_choice_doctor.Size = new System.Drawing.Size(150, 41);
            this.btn_add_choice_doctor.TabIndex = 2;
            this.btn_add_choice_doctor.Text = "🩺 إضافة طبيب";
            this.btn_add_choice_doctor.UseVisualStyleBackColor = false;
            this.btn_add_choice_doctor.Click += new System.EventHandler(this.btn_add_choice_doctor_Click);
            // 
            // btn_add_choice_clinic
            // 
            this.btn_add_choice_clinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btn_add_choice_clinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_choice_clinic.FlatAppearance.BorderSize = 0;
            this.btn_add_choice_clinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_choice_clinic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add_choice_clinic.ForeColor = System.Drawing.Color.White;
            this.btn_add_choice_clinic.Location = new System.Drawing.Point(75, 171);
            this.btn_add_choice_clinic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_choice_clinic.Name = "btn_add_choice_clinic";
            this.btn_add_choice_clinic.Size = new System.Drawing.Size(150, 41);
            this.btn_add_choice_clinic.TabIndex = 3;
            this.btn_add_choice_clinic.Text = "🏥 إضافة عيادة";
            this.btn_add_choice_clinic.UseVisualStyleBackColor = false;
            this.btn_add_choice_clinic.Click += new System.EventHandler(this.btn_add_choice_clinic_Click);
            // 
            // btn_add_choice_shift
            // 
            this.btn_add_choice_shift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btn_add_choice_shift.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_choice_shift.FlatAppearance.BorderSize = 0;
            this.btn_add_choice_shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_choice_shift.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_add_choice_shift.ForeColor = System.Drawing.Color.White;
            this.btn_add_choice_shift.Location = new System.Drawing.Point(75, 223);
            this.btn_add_choice_shift.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_choice_shift.Name = "btn_add_choice_shift";
            this.btn_add_choice_shift.Size = new System.Drawing.Size(150, 41);
            this.btn_add_choice_shift.TabIndex = 4;
            this.btn_add_choice_shift.Text = "📅 إضافة مناوبة";
            this.btn_add_choice_shift.UseVisualStyleBackColor = false;
            this.btn_add_choice_shift.Click += new System.EventHandler(this.btn_add_choice_shift_Click);
            // 
            // btn_add_choice_cancel
            // 
            this.btn_add_choice_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(190)))));
            this.btn_add_choice_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_choice_cancel.FlatAppearance.BorderSize = 0;
            this.btn_add_choice_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_choice_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_add_choice_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_add_choice_cancel.Location = new System.Drawing.Point(75, 276);
            this.btn_add_choice_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add_choice_cancel.Name = "btn_add_choice_cancel";
            this.btn_add_choice_cancel.Size = new System.Drawing.Size(150, 32);
            this.btn_add_choice_cancel.TabIndex = 5;
            this.btn_add_choice_cancel.Text = "إلغاء";
            this.btn_add_choice_cancel.UseVisualStyleBackColor = false;
            this.btn_add_choice_cancel.Click += new System.EventHandler(this.btn_add_choice_cancel_Click);
            // 
            // AddChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(300, 341);
            this.Controls.Add(this.lbl_add_choice_title);
            this.Controls.Add(this.btn_add_choice_user);
            this.Controls.Add(this.btn_add_choice_doctor);
            this.Controls.Add(this.btn_add_choice_clinic);
            this.Controls.Add(this.btn_add_choice_shift);
            this.Controls.Add(this.btn_add_choice_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختر نوع الإضافة";
            this.Load += new System.EventHandler(this.AddChoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_add_choice_title;
        private System.Windows.Forms.Button btn_add_choice_user;
        private System.Windows.Forms.Button btn_add_choice_doctor;
        private System.Windows.Forms.Button btn_add_choice_clinic;
        private System.Windows.Forms.Button btn_add_choice_shift;
        private System.Windows.Forms.Button btn_add_choice_cancel;
    }
}