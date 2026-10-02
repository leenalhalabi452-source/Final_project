namespace IPI201_FIN
{
    partial class EditChoiceForm
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
            this.lbl_edit_choice_title = new System.Windows.Forms.Label();
            this.btn_edit_choice_user = new System.Windows.Forms.Button();
            this.btn_edit_choice_clinic = new System.Windows.Forms.Button();
            this.btn_edit_choice_appointment = new System.Windows.Forms.Button();
            this.btn_edit_choice_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_edit_choice_title
            // 
            this.lbl_edit_choice_title.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_edit_choice_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lbl_edit_choice_title.Location = new System.Drawing.Point(222, 9);
            this.lbl_edit_choice_title.Name = "lbl_edit_choice_title";
            this.lbl_edit_choice_title.Size = new System.Drawing.Size(177, 40);
            this.lbl_edit_choice_title.TabIndex = 0;
            this.lbl_edit_choice_title.Text = "التعديلات ";
            this.lbl_edit_choice_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_edit_choice_title.Click += new System.EventHandler(this.lbl_edit_choice_title_Click);
            // 
            // btn_edit_choice_user
            // 
            this.btn_edit_choice_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_edit_choice_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_choice_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_edit_choice_user.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_edit_choice_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_choice_user.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_edit_choice_user.ForeColor = System.Drawing.Color.White;
            this.btn_edit_choice_user.Location = new System.Drawing.Point(100, 80);
            this.btn_edit_choice_user.Name = "btn_edit_choice_user";
            this.btn_edit_choice_user.Size = new System.Drawing.Size(200, 50);
            this.btn_edit_choice_user.TabIndex = 1;
            this.btn_edit_choice_user.Text = "👤 تعديل مستخدم";
            this.btn_edit_choice_user.UseVisualStyleBackColor = false;
            this.btn_edit_choice_user.Click += new System.EventHandler(this.btn_edit_choice_user_Click);
            // 
            // btn_edit_choice_clinic
            // 
            this.btn_edit_choice_clinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_edit_choice_clinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_choice_clinic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_edit_choice_clinic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_edit_choice_clinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_choice_clinic.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_edit_choice_clinic.ForeColor = System.Drawing.Color.White;
            this.btn_edit_choice_clinic.Location = new System.Drawing.Point(100, 145);
            this.btn_edit_choice_clinic.Name = "btn_edit_choice_clinic";
            this.btn_edit_choice_clinic.Size = new System.Drawing.Size(200, 50);
            this.btn_edit_choice_clinic.TabIndex = 2;
            this.btn_edit_choice_clinic.Text = "🏥 تعديل عيادة";
            this.btn_edit_choice_clinic.UseVisualStyleBackColor = false;
            this.btn_edit_choice_clinic.Click += new System.EventHandler(this.btn_edit_choice_clinic_Click);
            // 
            // btn_edit_choice_appointment
            // 
            this.btn_edit_choice_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.btn_edit_choice_appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_choice_appointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_edit_choice_appointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.btn_edit_choice_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_choice_appointment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_edit_choice_appointment.ForeColor = System.Drawing.Color.White;
            this.btn_edit_choice_appointment.Location = new System.Drawing.Point(100, 210);
            this.btn_edit_choice_appointment.Name = "btn_edit_choice_appointment";
            this.btn_edit_choice_appointment.Size = new System.Drawing.Size(200, 50);
            this.btn_edit_choice_appointment.TabIndex = 3;
            this.btn_edit_choice_appointment.Text = "🕐 تعديل موعد";
            this.btn_edit_choice_appointment.UseVisualStyleBackColor = false;
            this.btn_edit_choice_appointment.Click += new System.EventHandler(this.btn_edit_choice_appointment_Click);
            // 
            // btn_edit_choice_cancel
            // 
            this.btn_edit_choice_cancel.BackColor = System.Drawing.Color.Red;
            this.btn_edit_choice_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_edit_choice_cancel.FlatAppearance.BorderSize = 0;
            this.btn_edit_choice_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btn_edit_choice_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_choice_cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_edit_choice_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_edit_choice_cancel.Location = new System.Drawing.Point(100, 280);
            this.btn_edit_choice_cancel.Name = "btn_edit_choice_cancel";
            this.btn_edit_choice_cancel.Size = new System.Drawing.Size(200, 40);
            this.btn_edit_choice_cancel.TabIndex = 4;
            this.btn_edit_choice_cancel.Text = "إلغاء";
            this.btn_edit_choice_cancel.UseVisualStyleBackColor = false;
            this.btn_edit_choice_cancel.Click += new System.EventHandler(this.btn_edit_choice_cancel_Click);
            // 
            // EditChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(400, 360);
            this.Controls.Add(this.lbl_edit_choice_title);
            this.Controls.Add(this.btn_edit_choice_user);
            this.Controls.Add(this.btn_edit_choice_clinic);
            this.Controls.Add(this.btn_edit_choice_appointment);
            this.Controls.Add(this.btn_edit_choice_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditChoiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختر نوع التعديل";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_edit_choice_title;
        private System.Windows.Forms.Button btn_edit_choice_user;
        private System.Windows.Forms.Button btn_edit_choice_clinic;
        private System.Windows.Forms.Button btn_edit_choice_appointment;
        private System.Windows.Forms.Button btn_edit_choice_cancel;
    }
}