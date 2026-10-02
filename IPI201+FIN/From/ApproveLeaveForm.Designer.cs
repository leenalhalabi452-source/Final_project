namespace IPI201_FIN
{
    partial class ApproveLeaveForm
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
            this.lbl_approve_leave_title = new System.Windows.Forms.Label();
            this.lbl_approve_leave_request = new System.Windows.Forms.Label();
            this.cmb_approve_leave_request = new System.Windows.Forms.ComboBox();
            this.btn_approve_leave_yes = new System.Windows.Forms.Button();
            this.btn_approve_leave_no = new System.Windows.Forms.Button();
            this.btn_approve_leave_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_approve_leave_title
            // 
            this.lbl_approve_leave_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_approve_leave_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lbl_approve_leave_title.Location = new System.Drawing.Point(50, 20);
            this.lbl_approve_leave_title.Name = "lbl_approve_leave_title";
            this.lbl_approve_leave_title.Size = new System.Drawing.Size(400, 40);
            this.lbl_approve_leave_title.TabIndex = 0;
            this.lbl_approve_leave_title.Text = "اختر طلب الإجازة";
            this.lbl_approve_leave_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_approve_leave_title.Click += new System.EventHandler(this.lbl_approve_leave_title_Click);
            // 
            // lbl_approve_leave_request
            // 
            this.lbl_approve_leave_request.AutoSize = true;
            this.lbl_approve_leave_request.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_approve_leave_request.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lbl_approve_leave_request.Location = new System.Drawing.Point(50, 80);
            this.lbl_approve_leave_request.Name = "lbl_approve_leave_request";
            this.lbl_approve_leave_request.Size = new System.Drawing.Size(99, 23);
            this.lbl_approve_leave_request.TabIndex = 1;
            this.lbl_approve_leave_request.Text = "طلب الإجازة:";
            // 
            // cmb_approve_leave_request
            // 
            this.cmb_approve_leave_request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(65)))));
            this.cmb_approve_leave_request.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_approve_leave_request.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_approve_leave_request.ForeColor = System.Drawing.Color.White;
            this.cmb_approve_leave_request.FormattingEnabled = true;
            this.cmb_approve_leave_request.Location = new System.Drawing.Point(50, 110);
            this.cmb_approve_leave_request.Name = "cmb_approve_leave_request";
            this.cmb_approve_leave_request.Size = new System.Drawing.Size(400, 31);
            this.cmb_approve_leave_request.TabIndex = 2;
            // 
            // btn_approve_leave_yes
            // 
            this.btn_approve_leave_yes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(118)))));
            this.btn_approve_leave_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave_yes.FlatAppearance.BorderSize = 0;
            this.btn_approve_leave_yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btn_approve_leave_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave_yes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave_yes.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave_yes.Location = new System.Drawing.Point(50, 180);
            this.btn_approve_leave_yes.Name = "btn_approve_leave_yes";
            this.btn_approve_leave_yes.Size = new System.Drawing.Size(120, 50);
            this.btn_approve_leave_yes.TabIndex = 3;
            this.btn_approve_leave_yes.Text = "✅ موافقة";
            this.btn_approve_leave_yes.UseVisualStyleBackColor = false;
            this.btn_approve_leave_yes.Click += new System.EventHandler(this.btn_approve_leave_yes_Click);
            // 
            // btn_approve_leave_no
            // 
            this.btn_approve_leave_no.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_approve_leave_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave_no.FlatAppearance.BorderSize = 0;
            this.btn_approve_leave_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn_approve_leave_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave_no.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave_no.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave_no.Location = new System.Drawing.Point(190, 180);
            this.btn_approve_leave_no.Name = "btn_approve_leave_no";
            this.btn_approve_leave_no.Size = new System.Drawing.Size(120, 50);
            this.btn_approve_leave_no.TabIndex = 4;
            this.btn_approve_leave_no.Text = "❌ رفض";
            this.btn_approve_leave_no.UseVisualStyleBackColor = false;
            this.btn_approve_leave_no.Click += new System.EventHandler(this.btn_approve_leave_no_Click);
            // 
            // btn_approve_leave_cancel
            // 
            this.btn_approve_leave_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btn_approve_leave_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_approve_leave_cancel.FlatAppearance.BorderSize = 0;
            this.btn_approve_leave_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(110)))));
            this.btn_approve_leave_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_approve_leave_cancel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_approve_leave_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_approve_leave_cancel.Location = new System.Drawing.Point(330, 180);
            this.btn_approve_leave_cancel.Name = "btn_approve_leave_cancel";
            this.btn_approve_leave_cancel.Size = new System.Drawing.Size(120, 50);
            this.btn_approve_leave_cancel.TabIndex = 5;
            this.btn_approve_leave_cancel.Text = "إلغاء";
            this.btn_approve_leave_cancel.UseVisualStyleBackColor = false;
            this.btn_approve_leave_cancel.Click += new System.EventHandler(this.btn_approve_leave_cancel_Click);
            // 
            // ApproveLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(500, 335);
            this.Controls.Add(this.lbl_approve_leave_title);
            this.Controls.Add(this.lbl_approve_leave_request);
            this.Controls.Add(this.cmb_approve_leave_request);
            this.Controls.Add(this.btn_approve_leave_yes);
            this.Controls.Add(this.btn_approve_leave_no);
            this.Controls.Add(this.btn_approve_leave_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ApproveLeaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الموافقة على طلب إجازة";
            this.Load += new System.EventHandler(this.ApproveLeaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_approve_leave_title;
        private System.Windows.Forms.Label lbl_approve_leave_request;
        private System.Windows.Forms.ComboBox cmb_approve_leave_request;
        private System.Windows.Forms.Button btn_approve_leave_yes;
        private System.Windows.Forms.Button btn_approve_leave_no;
        private System.Windows.Forms.Button btn_approve_leave_cancel;
    }
}