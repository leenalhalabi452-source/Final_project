namespace IPI201_FIN
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inquiry_fill_patient_file = new System.Windows.Forms.Button();
            this.btn_inquiry_book_appointment = new System.Windows.Forms.Button();
            this.btn_inquiry_view_schedule = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_inquiry_card_title = new System.Windows.Forms.Label();
            this.lbl_inquiry_search_icon = new System.Windows.Forms.Label();
            this.txt_inquiry_search = new System.Windows.Forms.TextBox();
            this.dgv_inquiry_appointments = new System.Windows.Forms.DataGridView();
            this.lbl_inquiry_icon_user = new System.Windows.Forms.Label();
            this.lbl_inquiry_icon_check = new System.Windows.Forms.Label();
            this.lbl_inquiry_icon_reception = new System.Windows.Forms.Label();
            this.lbl_inquiry_icon_chat = new System.Windows.Forms.Label();
            this.lbl_inquiry_icon_search = new System.Windows.Forms.Label();
            this.lbl_inquiry_icon_calendar = new System.Windows.Forms.Label();
            this.timer_inquiry_animation = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquiry_appointments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.label1.Location = new System.Drawing.Point(75, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الموظف:";
            // 
            // btn_inquiry_fill_patient_file
            // 
            this.btn_inquiry_fill_patient_file.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.btn_inquiry_fill_patient_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inquiry_fill_patient_file.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btn_inquiry_fill_patient_file.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.btn_inquiry_fill_patient_file.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btn_inquiry_fill_patient_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inquiry_fill_patient_file.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_inquiry_fill_patient_file.ForeColor = System.Drawing.Color.White;
            this.btn_inquiry_fill_patient_file.Location = new System.Drawing.Point(46, 109);
            this.btn_inquiry_fill_patient_file.Name = "btn_inquiry_fill_patient_file";
            this.btn_inquiry_fill_patient_file.Size = new System.Drawing.Size(118, 51);
            this.btn_inquiry_fill_patient_file.TabIndex = 1;
            this.btn_inquiry_fill_patient_file.Text = "😷 إملاء إضبارة";
            this.btn_inquiry_fill_patient_file.UseVisualStyleBackColor = false;
            // 
            // btn_inquiry_book_appointment
            // 
            this.btn_inquiry_book_appointment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.btn_inquiry_book_appointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inquiry_book_appointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btn_inquiry_book_appointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.btn_inquiry_book_appointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btn_inquiry_book_appointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inquiry_book_appointment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_inquiry_book_appointment.ForeColor = System.Drawing.Color.White;
            this.btn_inquiry_book_appointment.Location = new System.Drawing.Point(46, 175);
            this.btn_inquiry_book_appointment.Name = "btn_inquiry_book_appointment";
            this.btn_inquiry_book_appointment.Size = new System.Drawing.Size(118, 51);
            this.btn_inquiry_book_appointment.TabIndex = 2;
            this.btn_inquiry_book_appointment.Text = "📅 حجز موعد";
            this.btn_inquiry_book_appointment.UseVisualStyleBackColor = false;
            // 
            // btn_inquiry_view_schedule
            // 
            this.btn_inquiry_view_schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.btn_inquiry_view_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inquiry_view_schedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(100)))));
            this.btn_inquiry_view_schedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(170)))), ((int)(((byte)(110)))));
            this.btn_inquiry_view_schedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(170)))));
            this.btn_inquiry_view_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inquiry_view_schedule.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_inquiry_view_schedule.ForeColor = System.Drawing.Color.White;
            this.btn_inquiry_view_schedule.Location = new System.Drawing.Point(46, 257);
            this.btn_inquiry_view_schedule.Name = "btn_inquiry_view_schedule";
            this.btn_inquiry_view_schedule.Size = new System.Drawing.Size(118, 51);
            this.btn_inquiry_view_schedule.TabIndex = 3;
            this.btn_inquiry_view_schedule.Text = "🕐 جدول العيادات";
            this.btn_inquiry_view_schedule.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_inquiry_card_title);
            this.panel1.Controls.Add(this.lbl_inquiry_search_icon);
            this.panel1.Controls.Add(this.txt_inquiry_search);
            this.panel1.Controls.Add(this.dgv_inquiry_appointments);
            this.panel1.Controls.Add(this.lbl_inquiry_icon_user);
            this.panel1.Controls.Add(this.lbl_inquiry_icon_check);
            this.panel1.Location = new System.Drawing.Point(207, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 331);
            this.panel1.TabIndex = 4;
            // 
            // lbl_inquiry_card_title
            // 
            this.lbl_inquiry_card_title.AutoSize = true;
            this.lbl_inquiry_card_title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_inquiry_card_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.lbl_inquiry_card_title.Location = new System.Drawing.Point(20, 15);
            this.lbl_inquiry_card_title.Name = "lbl_inquiry_card_title";
            this.lbl_inquiry_card_title.Size = new System.Drawing.Size(257, 32);
            this.lbl_inquiry_card_title.TabIndex = 5;
            this.lbl_inquiry_card_title.Text = "RECEPTION & QUERIES";
            // 
            // lbl_inquiry_search_icon
            // 
            this.lbl_inquiry_search_icon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_search_icon.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.lbl_inquiry_search_icon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.lbl_inquiry_search_icon.Location = new System.Drawing.Point(20, 55);
            this.lbl_inquiry_search_icon.Name = "lbl_inquiry_search_icon";
            this.lbl_inquiry_search_icon.Size = new System.Drawing.Size(35, 35);
            this.lbl_inquiry_search_icon.TabIndex = 6;
            this.lbl_inquiry_search_icon.Text = "🔍";
            this.lbl_inquiry_search_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_inquiry_search
            // 
            this.txt_inquiry_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.txt_inquiry_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_inquiry_search.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txt_inquiry_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(80)))), ((int)(((byte)(45)))));
            this.txt_inquiry_search.Location = new System.Drawing.Point(60, 58);
            this.txt_inquiry_search.Name = "txt_inquiry_search";
            this.txt_inquiry_search.Size = new System.Drawing.Size(500, 32);
            this.txt_inquiry_search.TabIndex = 7;
            this.txt_inquiry_search.Text = "Search...";
            // 
            // dgv_inquiry_appointments
            // 
            this.dgv_inquiry_appointments.AllowUserToAddRows = false;
            this.dgv_inquiry_appointments.AllowUserToDeleteRows = false;
            this.dgv_inquiry_appointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_inquiry_appointments.BackgroundColor = System.Drawing.Color.White;
            this.dgv_inquiry_appointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_inquiry_appointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inquiry_appointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.dgv_inquiry_appointments.Location = new System.Drawing.Point(20, 105);
            this.dgv_inquiry_appointments.Name = "dgv_inquiry_appointments";
            this.dgv_inquiry_appointments.ReadOnly = true;
            this.dgv_inquiry_appointments.RowHeadersVisible = false;
            this.dgv_inquiry_appointments.RowHeadersWidth = 51;
            this.dgv_inquiry_appointments.RowTemplate.Height = 32;
            this.dgv_inquiry_appointments.Size = new System.Drawing.Size(540, 210);
            this.dgv_inquiry_appointments.TabIndex = 8;
            // 
            // lbl_inquiry_icon_user
            // 
            this.lbl_inquiry_icon_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_icon_user.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lbl_inquiry_icon_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.lbl_inquiry_icon_user.Location = new System.Drawing.Point(450, 15);
            this.lbl_inquiry_icon_user.Name = "lbl_inquiry_icon_user";
            this.lbl_inquiry_icon_user.Size = new System.Drawing.Size(45, 35);
            this.lbl_inquiry_icon_user.TabIndex = 13;
            this.lbl_inquiry_icon_user.Text = "👤";
            this.lbl_inquiry_icon_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inquiry_icon_check
            // 
            this.lbl_inquiry_icon_check.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_icon_check.Font = new System.Drawing.Font("Segoe UI Emoji", 20F);
            this.lbl_inquiry_icon_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(140)))));
            this.lbl_inquiry_icon_check.Location = new System.Drawing.Point(500, 15);
            this.lbl_inquiry_icon_check.Name = "lbl_inquiry_icon_check";
            this.lbl_inquiry_icon_check.Size = new System.Drawing.Size(45, 35);
            this.lbl_inquiry_icon_check.TabIndex = 14;
            this.lbl_inquiry_icon_check.Text = "✅";
            this.lbl_inquiry_icon_check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inquiry_icon_reception
            // 
            this.lbl_inquiry_icon_reception.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_icon_reception.Font = new System.Drawing.Font("Segoe UI Emoji", 32F);
            this.lbl_inquiry_icon_reception.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_inquiry_icon_reception.Location = new System.Drawing.Point(-9, 20);
            this.lbl_inquiry_icon_reception.Name = "lbl_inquiry_icon_reception";
            this.lbl_inquiry_icon_reception.Size = new System.Drawing.Size(60, 60);
            this.lbl_inquiry_icon_reception.TabIndex = 9;
            this.lbl_inquiry_icon_reception.Text = "🏥";
            this.lbl_inquiry_icon_reception.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inquiry_icon_chat
            // 
            this.lbl_inquiry_icon_chat.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_icon_chat.Font = new System.Drawing.Font("Segoe UI Emoji", 32F);
            this.lbl_inquiry_icon_chat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_inquiry_icon_chat.Location = new System.Drawing.Point(10, 380);
            this.lbl_inquiry_icon_chat.Name = "lbl_inquiry_icon_chat";
            this.lbl_inquiry_icon_chat.Size = new System.Drawing.Size(60, 60);
            this.lbl_inquiry_icon_chat.TabIndex = 10;
            this.lbl_inquiry_icon_chat.Text = "💬";
            this.lbl_inquiry_icon_chat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inquiry_icon_search
            // 
            this.lbl_inquiry_icon_search.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_icon_search.Font = new System.Drawing.Font("Segoe UI Emoji", 32F);
            this.lbl_inquiry_icon_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_inquiry_icon_search.Location = new System.Drawing.Point(730, 10);
            this.lbl_inquiry_icon_search.Name = "lbl_inquiry_icon_search";
            this.lbl_inquiry_icon_search.Size = new System.Drawing.Size(60, 60);
            this.lbl_inquiry_icon_search.TabIndex = 11;
            this.lbl_inquiry_icon_search.Text = "🔍";
            this.lbl_inquiry_icon_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_inquiry_icon_calendar
            // 
            this.lbl_inquiry_icon_calendar.BackColor = System.Drawing.Color.Transparent;
            this.lbl_inquiry_icon_calendar.Font = new System.Drawing.Font("Segoe UI Emoji", 32F);
            this.lbl_inquiry_icon_calendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbl_inquiry_icon_calendar.Location = new System.Drawing.Point(730, 403);
            this.lbl_inquiry_icon_calendar.Name = "lbl_inquiry_icon_calendar";
            this.lbl_inquiry_icon_calendar.Size = new System.Drawing.Size(60, 60);
            this.lbl_inquiry_icon_calendar.TabIndex = 12;
            this.lbl_inquiry_icon_calendar.Text = "📅";
            this.lbl_inquiry_icon_calendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_inquiry_animation
            // 
            this.timer_inquiry_animation.Interval = 50;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(210)))), ((int)(((byte)(150)))));
            this.ClientSize = new System.Drawing.Size(987, 521);
            this.Controls.Add(this.lbl_inquiry_icon_calendar);
            this.Controls.Add(this.lbl_inquiry_icon_search);
            this.Controls.Add(this.lbl_inquiry_icon_chat);
            this.Controls.Add(this.lbl_inquiry_icon_reception);
            this.Controls.Add(this.btn_inquiry_view_schedule);
            this.Controls.Add(this.btn_inquiry_book_appointment);
            this.Controls.Add(this.btn_inquiry_fill_patient_file);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة الاستعلامات";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inquiry_appointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button btn_inquiry_fill_patient_file;
        private System.Windows.Forms.Button btn_inquiry_book_appointment;
        private System.Windows.Forms.Button btn_inquiry_view_schedule;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_inquiry_card_title;
        private System.Windows.Forms.TextBox txt_inquiry_search;
        private System.Windows.Forms.Label lbl_inquiry_search_icon;
        private System.Windows.Forms.DataGridView dgv_inquiry_appointments;

        private System.Windows.Forms.Label lbl_inquiry_icon_reception;
        private System.Windows.Forms.Label lbl_inquiry_icon_chat;
        private System.Windows.Forms.Label lbl_inquiry_icon_search;
        private System.Windows.Forms.Label lbl_inquiry_icon_calendar;
        private System.Windows.Forms.Label lbl_inquiry_icon_user;
        private System.Windows.Forms.Label lbl_inquiry_icon_check;

        private System.Windows.Forms.Timer timer_inquiry_animation;
    }
}