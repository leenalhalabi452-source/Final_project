namespace IPI201_FIN
{
    partial class FirstAdminForm
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
            this.pnl_first_admin_card = new System.Windows.Forms.Panel();
            this.lbl_first_admin_title = new System.Windows.Forms.Label();
            this.lbl_first_admin_name = new System.Windows.Forms.Label();
            this.txt_first_admin_name = new System.Windows.Forms.TextBox();
            this.lbl_first_admin_username = new System.Windows.Forms.Label();
            this.txt_first_admin_username = new System.Windows.Forms.TextBox();
            this.lbl_first_admin_password = new System.Windows.Forms.Label();
            this.txt_first_admin_password = new System.Windows.Forms.TextBox();
            this.lbl_first_admin_confirm = new System.Windows.Forms.Label();
            this.txt_first_admin_confirm = new System.Windows.Forms.TextBox();
            this.btn_first_admin_save = new System.Windows.Forms.Button();
            this.btn_first_admin_cancel = new System.Windows.Forms.Button();

            this.pnl_first_admin_card.SuspendLayout();
            this.SuspendLayout();

            // ================= FirstAdminForm =================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(155, 125, 210);
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FirstAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء حساب المدير";
            this.Load += new System.EventHandler(this.FirstAdminForm_Load);

            // ================= pnl_first_admin_card =================
            this.pnl_first_admin_card.BackColor = System.Drawing.Color.White;
            this.pnl_first_admin_card.Location = new System.Drawing.Point(80, 40);
            this.pnl_first_admin_card.Name = "pnl_first_admin_card";
            this.pnl_first_admin_card.Size = new System.Drawing.Size(340, 470);
            this.pnl_first_admin_card.TabIndex = 0;

            // ================= lbl_first_admin_title =================
            this.lbl_first_admin_title.AutoSize = false;
            this.lbl_first_admin_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_first_admin_title.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.lbl_first_admin_title.Location = new System.Drawing.Point(20, 20);
            this.lbl_first_admin_title.Name = "lbl_first_admin_title";
            this.lbl_first_admin_title.Size = new System.Drawing.Size(300, 40);
            this.lbl_first_admin_title.TabIndex = 1;
            this.lbl_first_admin_title.Text = "إنشاء المدير الأول";
            this.lbl_first_admin_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ================= lbl_first_admin_name =================
            this.lbl_first_admin_name.AutoSize = true;
            this.lbl_first_admin_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_first_admin_name.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_first_admin_name.Location = new System.Drawing.Point(25, 80);
            this.lbl_first_admin_name.Name = "lbl_first_admin_name";
            this.lbl_first_admin_name.Size = new System.Drawing.Size(100, 20);
            this.lbl_first_admin_name.TabIndex = 2;
            this.lbl_first_admin_name.Text = "الاسم الكامل";

            // ================= txt_first_admin_name =================
            this.txt_first_admin_name.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_first_admin_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_first_admin_name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_first_admin_name.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_first_admin_name.Location = new System.Drawing.Point(25, 105);
            this.txt_first_admin_name.Name = "txt_first_admin_name";
            this.txt_first_admin_name.Size = new System.Drawing.Size(290, 32);
            this.txt_first_admin_name.TabIndex = 3;

            // ================= lbl_first_admin_username =================
            this.lbl_first_admin_username.AutoSize = true;
            this.lbl_first_admin_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_first_admin_username.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_first_admin_username.Location = new System.Drawing.Point(25, 155);
            this.lbl_first_admin_username.Name = "lbl_first_admin_username";
            this.lbl_first_admin_username.Size = new System.Drawing.Size(80, 20);
            this.lbl_first_admin_username.TabIndex = 4;
            this.lbl_first_admin_username.Text = "اسم الدخول";

            // ================= txt_first_admin_username =================
            this.txt_first_admin_username.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_first_admin_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_first_admin_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_first_admin_username.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_first_admin_username.Location = new System.Drawing.Point(25, 180);
            this.txt_first_admin_username.Name = "txt_first_admin_username";
            this.txt_first_admin_username.Size = new System.Drawing.Size(290, 32);
            this.txt_first_admin_username.TabIndex = 5;

            // ================= lbl_first_admin_password =================
            this.lbl_first_admin_password.AutoSize = true;
            this.lbl_first_admin_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_first_admin_password.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_first_admin_password.Location = new System.Drawing.Point(25, 230);
            this.lbl_first_admin_password.Name = "lbl_first_admin_password";
            this.lbl_first_admin_password.Size = new System.Drawing.Size(75, 20);
            this.lbl_first_admin_password.TabIndex = 6;
            this.lbl_first_admin_password.Text = "كلمة المرور";

            // ================= txt_first_admin_password =================
            this.txt_first_admin_password.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_first_admin_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_first_admin_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_first_admin_password.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_first_admin_password.Location = new System.Drawing.Point(25, 255);
            this.txt_first_admin_password.Name = "txt_first_admin_password";
            this.txt_first_admin_password.Size = new System.Drawing.Size(290, 32);
            this.txt_first_admin_password.TabIndex = 7;
            this.txt_first_admin_password.UseSystemPasswordChar = true;

            // ================= lbl_first_admin_confirm =================
            this.lbl_first_admin_confirm.AutoSize = true;
            this.lbl_first_admin_confirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_first_admin_confirm.ForeColor = System.Drawing.Color.FromArgb(120, 110, 140);
            this.lbl_first_admin_confirm.Location = new System.Drawing.Point(25, 305);
            this.lbl_first_admin_confirm.Name = "lbl_first_admin_confirm";
            this.lbl_first_admin_confirm.Size = new System.Drawing.Size(110, 20);
            this.lbl_first_admin_confirm.TabIndex = 8;
            this.lbl_first_admin_confirm.Text = "تأكيد كلمة المرور";

            // ================= txt_first_admin_confirm =================
            this.txt_first_admin_confirm.BackColor = System.Drawing.Color.FromArgb(245, 243, 250);
            this.txt_first_admin_confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_first_admin_confirm.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_first_admin_confirm.ForeColor = System.Drawing.Color.FromArgb(60, 50, 90);
            this.txt_first_admin_confirm.Location = new System.Drawing.Point(25, 330);
            this.txt_first_admin_confirm.Name = "txt_first_admin_confirm";
            this.txt_first_admin_confirm.Size = new System.Drawing.Size(290, 32);
            this.txt_first_admin_confirm.TabIndex = 9;
            this.txt_first_admin_confirm.UseSystemPasswordChar = true;

            // ================= btn_first_admin_save =================
            this.btn_first_admin_save.BackColor = System.Drawing.Color.FromArgb(110, 80, 180);
            this.btn_first_admin_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first_admin_save.FlatAppearance.BorderSize = 0;
            this.btn_first_admin_save.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_first_admin_save.ForeColor = System.Drawing.Color.White;
            this.btn_first_admin_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_first_admin_save.Location = new System.Drawing.Point(25, 390);
            this.btn_first_admin_save.Name = "btn_first_admin_save";
            this.btn_first_admin_save.Size = new System.Drawing.Size(140, 45);
            this.btn_first_admin_save.TabIndex = 10;
            this.btn_first_admin_save.Text = "حفظ";
            this.btn_first_admin_save.UseVisualStyleBackColor = false;
            this.btn_first_admin_save.Click += new System.EventHandler(this.btn_first_admin_save_Click);

            // ================= btn_first_admin_cancel =================
            this.btn_first_admin_cancel.BackColor = System.Drawing.Color.FromArgb(180, 180, 190);
            this.btn_first_admin_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_first_admin_cancel.FlatAppearance.BorderSize = 0;
            this.btn_first_admin_cancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_first_admin_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_first_admin_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_first_admin_cancel.Location = new System.Drawing.Point(175, 390);
            this.btn_first_admin_cancel.Name = "btn_first_admin_cancel";
            this.btn_first_admin_cancel.Size = new System.Drawing.Size(140, 45);
            this.btn_first_admin_cancel.TabIndex = 11;
            this.btn_first_admin_cancel.Text = "إلغاء";
            this.btn_first_admin_cancel.UseVisualStyleBackColor = false;
            this.btn_first_admin_cancel.Click += new System.EventHandler(this.btn_first_admin_cancel_Click);

            // ================= إضافة العناصر للبطاقة =================
            this.pnl_first_admin_card.Controls.Add(this.lbl_first_admin_title);
            this.pnl_first_admin_card.Controls.Add(this.lbl_first_admin_name);
            this.pnl_first_admin_card.Controls.Add(this.txt_first_admin_name);
            this.pnl_first_admin_card.Controls.Add(this.lbl_first_admin_username);
            this.pnl_first_admin_card.Controls.Add(this.txt_first_admin_username);
            this.pnl_first_admin_card.Controls.Add(this.lbl_first_admin_password);
            this.pnl_first_admin_card.Controls.Add(this.txt_first_admin_password);
            this.pnl_first_admin_card.Controls.Add(this.lbl_first_admin_confirm);
            this.pnl_first_admin_card.Controls.Add(this.txt_first_admin_confirm);
            this.pnl_first_admin_card.Controls.Add(this.btn_first_admin_save);
            this.pnl_first_admin_card.Controls.Add(this.btn_first_admin_cancel);

            this.Controls.Add(this.pnl_first_admin_card);

            this.pnl_first_admin_card.ResumeLayout(false);
            this.pnl_first_admin_card.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_first_admin_card;
        private System.Windows.Forms.Label lbl_first_admin_title;
        private System.Windows.Forms.Label lbl_first_admin_name;
        private System.Windows.Forms.TextBox txt_first_admin_name;
        private System.Windows.Forms.Label lbl_first_admin_username;
        private System.Windows.Forms.TextBox txt_first_admin_username;
        private System.Windows.Forms.Label lbl_first_admin_password;
        private System.Windows.Forms.TextBox txt_first_admin_password;
        private System.Windows.Forms.Label lbl_first_admin_confirm;
        private System.Windows.Forms.TextBox txt_first_admin_confirm;
        private System.Windows.Forms.Button btn_first_admin_save;
        private System.Windows.Forms.Button btn_first_admin_cancel;
    }
}