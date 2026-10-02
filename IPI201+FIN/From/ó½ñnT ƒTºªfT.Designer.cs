namespace IPI201_FIN
{
    partial class Form1
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
            this.pnl_login_card = new System.Windows.Forms.Panel();
            this.btn_login_login = new System.Windows.Forms.Button();
            this.btn_login_create_admin = new System.Windows.Forms.Button();
            this.txt_login_password = new System.Windows.Forms.TextBox();
            this.lbl_login_password = new System.Windows.Forms.Label();
            this.txt_login_username = new System.Windows.Forms.TextBox();
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.btn_login_verify_server = new System.Windows.Forms.Button();
            this.txt_login_server_name = new System.Windows.Forms.TextBox();
            this.lbl_login_server_name = new System.Windows.Forms.Label();
            this.lbl_login_title = new System.Windows.Forms.Label();
            this.lbl_login_icon_key = new System.Windows.Forms.Label();
            this.lbl_login_icon_shield_lock = new System.Windows.Forms.Label();
            this.lbl_login_icon_shield_check = new System.Windows.Forms.Label();
            this.lbl_login_icon_user = new System.Windows.Forms.Label();
            this.pnl_login_card.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_login_card
            // 
            this.pnl_login_card.BackColor = System.Drawing.Color.White;
            this.pnl_login_card.Controls.Add(this.btn_login_login);
            this.pnl_login_card.Controls.Add(this.btn_login_create_admin);
            this.pnl_login_card.Controls.Add(this.txt_login_password);
            this.pnl_login_card.Controls.Add(this.lbl_login_password);
            this.pnl_login_card.Controls.Add(this.txt_login_username);
            this.pnl_login_card.Controls.Add(this.lbl_login_username);
            this.pnl_login_card.Controls.Add(this.btn_login_verify_server);
            this.pnl_login_card.Controls.Add(this.txt_login_server_name);
            this.pnl_login_card.Controls.Add(this.lbl_login_server_name);
            this.pnl_login_card.Controls.Add(this.lbl_login_title);
            this.pnl_login_card.Location = new System.Drawing.Point(210, 49);
            this.pnl_login_card.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnl_login_card.Name = "pnl_login_card";
            this.pnl_login_card.Size = new System.Drawing.Size(255, 395);
            this.pnl_login_card.TabIndex = 0;
            // 
            // btn_login_login
            // 
            this.btn_login_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btn_login_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_login.FlatAppearance.BorderSize = 0;
            this.btn_login_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(65)))), ((int)(((byte)(150)))));
            this.btn_login_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btn_login_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_login.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login_login.ForeColor = System.Drawing.Color.White;
            this.btn_login_login.Location = new System.Drawing.Point(19, 297);
            this.btn_login_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login_login.Name = "btn_login_login";
            this.btn_login_login.Size = new System.Drawing.Size(218, 37);
            this.btn_login_login.TabIndex = 9;
            this.btn_login_login.Text = "Log In";
            this.btn_login_login.UseVisualStyleBackColor = false;
            this.btn_login_login.Click += new System.EventHandler(this.btn_login_login_Click);
            // 
            // btn_login_create_admin
            // 
            this.btn_login_create_admin.BackColor = System.Drawing.Color.Transparent;
            this.btn_login_create_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_create_admin.FlatAppearance.BorderSize = 0;
            this.btn_login_create_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(250)))));
            this.btn_login_create_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_create_admin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btn_login_create_admin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(80)))), ((int)(((byte)(180)))));
            this.btn_login_create_admin.Location = new System.Drawing.Point(19, 356);
            this.btn_login_create_admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login_create_admin.Name = "btn_login_create_admin";
            this.btn_login_create_admin.Size = new System.Drawing.Size(218, 37);
            this.btn_login_create_admin.TabIndex = 10;
            this.btn_login_create_admin.Text = "إنشاء حساب المدير";
            this.btn_login_create_admin.UseVisualStyleBackColor = false;
            this.btn_login_create_admin.Click += new System.EventHandler(this.btn_login_create_admin_Click);
            // 
            // txt_login_password
            // 
            this.txt_login_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txt_login_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_login_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.txt_login_password.Location = new System.Drawing.Point(19, 252);
            this.txt_login_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_login_password.Name = "txt_login_password";
            this.txt_login_password.Size = new System.Drawing.Size(218, 27);
            this.txt_login_password.TabIndex = 8;
            this.txt_login_password.UseSystemPasswordChar = true;
            // 
            // lbl_login_password
            // 
            this.lbl_login_password.AutoSize = true;
            this.lbl_login_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_login_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.lbl_login_password.Location = new System.Drawing.Point(19, 232);
            this.lbl_login_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_password.Name = "lbl_login_password";
            this.lbl_login_password.Size = new System.Drawing.Size(59, 15);
            this.lbl_login_password.TabIndex = 7;
            this.lbl_login_password.Text = "Password";
            // 
            // txt_login_username
            // 
            this.txt_login_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txt_login_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.txt_login_username.Location = new System.Drawing.Point(19, 191);
            this.txt_login_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_login_username.Name = "txt_login_username";
            this.txt_login_username.Size = new System.Drawing.Size(218, 27);
            this.txt_login_username.TabIndex = 6;
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_login_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.lbl_login_username.Location = new System.Drawing.Point(19, 171);
            this.lbl_login_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(64, 15);
            this.lbl_login_username.TabIndex = 5;
            this.lbl_login_username.Text = "Username";
            // 
            // btn_login_verify_server
            // 
            this.btn_login_verify_server.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(125)))), ((int)(((byte)(210)))));
            this.btn_login_verify_server.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login_verify_server.FlatAppearance.BorderSize = 0;
            this.btn_login_verify_server.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(105)))), ((int)(((byte)(190)))));
            this.btn_login_verify_server.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(145)))), ((int)(((byte)(230)))));
            this.btn_login_verify_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_verify_server.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_login_verify_server.ForeColor = System.Drawing.Color.White;
            this.btn_login_verify_server.Location = new System.Drawing.Point(19, 126);
            this.btn_login_verify_server.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_login_verify_server.Name = "btn_login_verify_server";
            this.btn_login_verify_server.Size = new System.Drawing.Size(218, 28);
            this.btn_login_verify_server.TabIndex = 4;
            this.btn_login_verify_server.Text = "DONE ✔";
            this.btn_login_verify_server.UseVisualStyleBackColor = false;
            this.btn_login_verify_server.Click += new System.EventHandler(this.btn_login_verify_server_Click);
            // 
            // txt_login_server_name
            // 
            this.txt_login_server_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.txt_login_server_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_login_server_name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_login_server_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.txt_login_server_name.Location = new System.Drawing.Point(19, 93);
            this.txt_login_server_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_login_server_name.Name = "txt_login_server_name";
            this.txt_login_server_name.Size = new System.Drawing.Size(218, 27);
            this.txt_login_server_name.TabIndex = 3;
            // 
            // lbl_login_server_name
            // 
            this.lbl_login_server_name.AutoSize = true;
            this.lbl_login_server_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_login_server_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(110)))), ((int)(((byte)(140)))));
            this.lbl_login_server_name.Location = new System.Drawing.Point(19, 73);
            this.lbl_login_server_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_server_name.Name = "lbl_login_server_name";
            this.lbl_login_server_name.Size = new System.Drawing.Size(81, 15);
            this.lbl_login_server_name.TabIndex = 2;
            this.lbl_login_server_name.Text = "Server Name";
            // 
            // lbl_login_title
            // 
            this.lbl_login_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_login_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.lbl_login_title.Location = new System.Drawing.Point(15, 24);
            this.lbl_login_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_title.Name = "lbl_login_title";
            this.lbl_login_title.Size = new System.Drawing.Size(225, 32);
            this.lbl_login_title.TabIndex = 1;
            this.lbl_login_title.Text = "LOGIN";
            this.lbl_login_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_login_icon_key
            // 
            this.lbl_login_icon_key.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_key.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_key.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_login_icon_key.Location = new System.Drawing.Point(60, 106);
            this.lbl_login_icon_key.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_icon_key.Name = "lbl_login_icon_key";
            this.lbl_login_icon_key.Size = new System.Drawing.Size(75, 81);
            this.lbl_login_icon_key.TabIndex = 11;
            this.lbl_login_icon_key.Text = "🔑";
            this.lbl_login_icon_key.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_login_icon_shield_lock
            // 
            this.lbl_login_icon_shield_lock.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_shield_lock.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_shield_lock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_login_icon_shield_lock.Location = new System.Drawing.Point(536, 106);
            this.lbl_login_icon_shield_lock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_icon_shield_lock.Name = "lbl_login_icon_shield_lock";
            this.lbl_login_icon_shield_lock.Size = new System.Drawing.Size(75, 81);
            this.lbl_login_icon_shield_lock.TabIndex = 12;
            this.lbl_login_icon_shield_lock.Text = "🛡";
            this.lbl_login_icon_shield_lock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_login_icon_shield_check
            // 
            this.lbl_login_icon_shield_check.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_shield_check.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_shield_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_login_icon_shield_check.Location = new System.Drawing.Point(60, 325);
            this.lbl_login_icon_shield_check.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_icon_shield_check.Name = "lbl_login_icon_shield_check";
            this.lbl_login_icon_shield_check.Size = new System.Drawing.Size(75, 81);
            this.lbl_login_icon_shield_check.TabIndex = 13;
            this.lbl_login_icon_shield_check.Text = "✅";
            this.lbl_login_icon_shield_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_login_icon_user
            // 
            this.lbl_login_icon_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_icon_user.Font = new System.Drawing.Font("Segoe UI Emoji", 45F);
            this.lbl_login_icon_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_login_icon_user.Location = new System.Drawing.Point(536, 325);
            this.lbl_login_icon_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login_icon_user.Name = "lbl_login_icon_user";
            this.lbl_login_icon_user.Size = new System.Drawing.Size(75, 81);
            this.lbl_login_icon_user.TabIndex = 14;
            this.lbl_login_icon_user.Text = "👤";
            this.lbl_login_icon_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(125)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(671, 455);
            this.Controls.Add(this.lbl_login_icon_key);
            this.Controls.Add(this.lbl_login_icon_shield_lock);
            this.Controls.Add(this.lbl_login_icon_shield_check);
            this.Controls.Add(this.lbl_login_icon_user);
            this.Controls.Add(this.pnl_login_card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_login_card.ResumeLayout(false);
            this.pnl_login_card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_login_card;
        private System.Windows.Forms.TextBox txt_login_server_name;
        private System.Windows.Forms.Button btn_login_verify_server;
        private System.Windows.Forms.Label lbl_login_title;
        private System.Windows.Forms.Label lbl_login_server_name;
        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lbl_login_password;
        private System.Windows.Forms.Button btn_login_login;
        private System.Windows.Forms.Button btn_login_create_admin;
        private System.Windows.Forms.TextBox txt_login_password;
        private System.Windows.Forms.TextBox txt_login_username;

        private System.Windows.Forms.Label lbl_login_icon_key;
        private System.Windows.Forms.Label lbl_login_icon_shield_lock;
        private System.Windows.Forms.Label lbl_login_icon_shield_check;
        private System.Windows.Forms.Label lbl_login_icon_user;
    }
}