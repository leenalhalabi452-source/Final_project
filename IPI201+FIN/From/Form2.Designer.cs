namespace IPI201_FIN
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_admin_display = new System.Windows.Forms.DataGridView();

            this.btn_admin_view_employees = new System.Windows.Forms.Button();
            this.btn_admin_view_shifts = new System.Windows.Forms.Button();
            this.btn_admin_view_leaves = new System.Windows.Forms.Button();
            this.btn_admin_view_appointments = new System.Windows.Forms.Button();
            this.btn_admin_view_clinics = new System.Windows.Forms.Button();

            this.btn_admin_add = new System.Windows.Forms.Button();
            this.btn_admin_edit = new System.Windows.Forms.Button();
            this.btn_admin_delete = new System.Windows.Forms.Button();
            this.btn_admin_approve_leave = new System.Windows.Forms.Button();

            this.timer_admin_animation = new System.Windows.Forms.Timer(this.components);

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_display)).BeginInit();
            this.SuspendLayout();

            // =========================
            // FORM
            // =========================
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(17, 15, 28);
            this.ClientSize = new System.Drawing.Size(1050, 680);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة تحكم المدير";

            // =========================
            // TITLE
            // =========================
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.label1.Location = new System.Drawing.Point(350, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "لوحة تحكم المدير";

            // =========================
            // MAIN PANEL
            // =========================
            this.panel1.BackColor = System.Drawing.Color.FromArgb(27, 24, 43);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(245, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 400);
            this.panel1.TabIndex = 1;
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Controls.Add(this.dgv_admin_display);

            // =========================
            // DATAGRIDVIEW
            // =========================
            this.dgv_admin_display.AllowUserToAddRows = false;
            this.dgv_admin_display.AllowUserToDeleteRows = false;
            this.dgv_admin_display.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_admin_display.BackgroundColor = System.Drawing.Color.FromArgb(20, 18, 32);
            this.dgv_admin_display.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_admin_display.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_admin_display.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_admin_display.ColumnHeadersHeight = 50;
            this.dgv_admin_display.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgv_admin_display.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(91, 63, 145),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,
                SelectionBackColor = System.Drawing.Color.FromArgb(91, 63, 145),
                SelectionForeColor = System.Drawing.Color.White
            };

            this.dgv_admin_display.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                BackColor = System.Drawing.Color.FromArgb(30, 27, 48),
                ForeColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI", 10F),
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter,
                SelectionBackColor = System.Drawing.Color.FromArgb(111, 78, 168),
                SelectionForeColor = System.Drawing.Color.White,
                Padding = new System.Windows.Forms.Padding(5)
            };

            this.dgv_admin_display.EnableHeadersVisualStyles = false;
            this.dgv_admin_display.GridColor = System.Drawing.Color.FromArgb(55, 48, 75);
            this.dgv_admin_display.ReadOnly = true;
            this.dgv_admin_display.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_admin_display.RowHeadersVisible = false;
            this.dgv_admin_display.RowTemplate.Height = 45;
            this.dgv_admin_display.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_admin_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_admin_display.Name = "dgv_admin_display";
            this.dgv_admin_display.TabIndex = 0;

            // =========================
            // VIEW BUTTONS
            // =========================

            // الموظفين
            this.btn_admin_view_employees.BackColor = System.Drawing.Color.FromArgb(40, 35, 65);
            this.btn_admin_view_employees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_view_employees.FlatAppearance.BorderSize = 1;
            this.btn_admin_view_employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_view_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_view_employees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_admin_view_employees.ForeColor = System.Drawing.Color.White;
            this.btn_admin_view_employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_view_employees.Location = new System.Drawing.Point(35, 105);
            this.btn_admin_view_employees.Name = "btn_admin_view_employees";
            this.btn_admin_view_employees.Size = new System.Drawing.Size(180, 50);
            this.btn_admin_view_employees.TabIndex = 2;
            this.btn_admin_view_employees.Text = "الموظفين";
            this.btn_admin_view_employees.UseVisualStyleBackColor = false;

            // المناوبات
            this.btn_admin_view_shifts.BackColor = System.Drawing.Color.FromArgb(40, 35, 65);
            this.btn_admin_view_shifts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_view_shifts.FlatAppearance.BorderSize = 1;
            this.btn_admin_view_shifts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_view_shifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_view_shifts.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_admin_view_shifts.ForeColor = System.Drawing.Color.White;
            this.btn_admin_view_shifts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_view_shifts.Location = new System.Drawing.Point(35, 170);
            this.btn_admin_view_shifts.Name = "btn_admin_view_shifts";
            this.btn_admin_view_shifts.Size = new System.Drawing.Size(180, 50);
            this.btn_admin_view_shifts.TabIndex = 3;
            this.btn_admin_view_shifts.Text = "المناوبات";
            this.btn_admin_view_shifts.UseVisualStyleBackColor = false;

            // طلبات الإجازة
            this.btn_admin_view_leaves.BackColor = System.Drawing.Color.FromArgb(40, 35, 65);
            this.btn_admin_view_leaves.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_view_leaves.FlatAppearance.BorderSize = 1;
            this.btn_admin_view_leaves.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_view_leaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_view_leaves.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_admin_view_leaves.ForeColor = System.Drawing.Color.White;
            this.btn_admin_view_leaves.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_view_leaves.Location = new System.Drawing.Point(35, 235);
            this.btn_admin_view_leaves.Name = "btn_admin_view_leaves";
            this.btn_admin_view_leaves.Size = new System.Drawing.Size(180, 50);
            this.btn_admin_view_leaves.TabIndex = 4;
            this.btn_admin_view_leaves.Text = "طلبات الإجازة";
            this.btn_admin_view_leaves.UseVisualStyleBackColor = false;

            // مواعيد العيادات
            this.btn_admin_view_appointments.BackColor = System.Drawing.Color.FromArgb(40, 35, 65);
            this.btn_admin_view_appointments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_view_appointments.FlatAppearance.BorderSize = 1;
            this.btn_admin_view_appointments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_view_appointments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_view_appointments.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_admin_view_appointments.ForeColor = System.Drawing.Color.White;
            this.btn_admin_view_appointments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_view_appointments.Location = new System.Drawing.Point(35, 300);
            this.btn_admin_view_appointments.Name = "btn_admin_view_appointments";
            this.btn_admin_view_appointments.Size = new System.Drawing.Size(180, 50);
            this.btn_admin_view_appointments.TabIndex = 5;
            this.btn_admin_view_appointments.Text = "مواعيد العيادات";
            this.btn_admin_view_appointments.UseVisualStyleBackColor = false;

            // العيادات
            this.btn_admin_view_clinics.BackColor = System.Drawing.Color.FromArgb(40, 35, 65);
            this.btn_admin_view_clinics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_view_clinics.FlatAppearance.BorderSize = 1;
            this.btn_admin_view_clinics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_view_clinics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_view_clinics.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_admin_view_clinics.ForeColor = System.Drawing.Color.White;
            this.btn_admin_view_clinics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_view_clinics.Location = new System.Drawing.Point(35, 365);
            this.btn_admin_view_clinics.Name = "btn_admin_view_clinics";
            this.btn_admin_view_clinics.Size = new System.Drawing.Size(180, 50);
            this.btn_admin_view_clinics.TabIndex = 6;
            this.btn_admin_view_clinics.Text = "العيادات";
            this.btn_admin_view_clinics.UseVisualStyleBackColor = false;

            // =========================
            // ADD
            // =========================
            this.btn_admin_add.BackColor = System.Drawing.Color.FromArgb(72, 61, 110);
            this.btn_admin_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_add.FlatAppearance.BorderSize = 1;
            this.btn_admin_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_admin_add.ForeColor = System.Drawing.Color.White;
            this.btn_admin_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_add.Location = new System.Drawing.Point(245, 535);
            this.btn_admin_add.Name = "btn_admin_add";
            this.btn_admin_add.Size = new System.Drawing.Size(170, 50);
            this.btn_admin_add.TabIndex = 10;
            this.btn_admin_add.Text = "إضافة";
            this.btn_admin_add.UseVisualStyleBackColor = false;
            this.btn_admin_add.Click += new System.EventHandler(this.btn_admin_add_Click);

            // =========================
            // EDIT
            // =========================
            this.btn_admin_edit.BackColor = System.Drawing.Color.FromArgb(72, 61, 110);
            this.btn_admin_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_edit.FlatAppearance.BorderSize = 1;
            this.btn_admin_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_admin_edit.ForeColor = System.Drawing.Color.White;
            this.btn_admin_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_edit.Location = new System.Drawing.Point(430, 535);
            this.btn_admin_edit.Name = "btn_admin_edit";
            this.btn_admin_edit.Size = new System.Drawing.Size(170, 50);
            this.btn_admin_edit.TabIndex = 11;
            this.btn_admin_edit.Text = "تعديل";
            this.btn_admin_edit.UseVisualStyleBackColor = false;
            this.btn_admin_edit.Click += new System.EventHandler(this.btn_admin_edit_Click);

            // =========================
            // DELETE
            // =========================
            this.btn_admin_delete.BackColor = System.Drawing.Color.FromArgb(95, 45, 70);
            this.btn_admin_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(170, 70, 90);
            this.btn_admin_delete.FlatAppearance.BorderSize = 1;
            this.btn_admin_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(140, 60, 90);
            this.btn_admin_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_admin_delete.ForeColor = System.Drawing.Color.White;
            this.btn_admin_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_delete.Location = new System.Drawing.Point(615, 535);
            this.btn_admin_delete.Name = "btn_admin_delete";
            this.btn_admin_delete.Size = new System.Drawing.Size(170, 50);
            this.btn_admin_delete.TabIndex = 12;
            this.btn_admin_delete.Text = "حذف";
            this.btn_admin_delete.UseVisualStyleBackColor = false;
            this.btn_admin_delete.Click += new System.EventHandler(this.btn_admin_delete_Click);

            // =========================
            // APPROVE LEAVE
            // =========================
            this.btn_admin_approve_leave.BackColor = System.Drawing.Color.FromArgb(72, 61, 110);
            this.btn_admin_approve_leave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.btn_admin_approve_leave.FlatAppearance.BorderSize = 1;
            this.btn_admin_approve_leave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(91, 63, 145);
            this.btn_admin_approve_leave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_approve_leave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_admin_approve_leave.ForeColor = System.Drawing.Color.White;
            this.btn_admin_approve_leave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admin_approve_leave.Location = new System.Drawing.Point(800, 535);
            this.btn_admin_approve_leave.Name = "btn_admin_approve_leave";
            this.btn_admin_approve_leave.Size = new System.Drawing.Size(170, 50);
            this.btn_admin_approve_leave.TabIndex = 13;
            this.btn_admin_approve_leave.Text = "موافقة إجازة";
            this.btn_admin_approve_leave.UseVisualStyleBackColor = false;
            this.btn_admin_approve_leave.Click += new System.EventHandler(this.btn_admin_approve_leave_Click_1);

            // =========================
            // TIMER
            // =========================
            this.timer_admin_animation.Interval = 50;

            // =========================
            // ADD CONTROLS
            // =========================
            this.Controls.Add(this.btn_admin_view_employees);
            this.Controls.Add(this.btn_admin_view_shifts);
            this.Controls.Add(this.btn_admin_view_leaves);
            this.Controls.Add(this.btn_admin_view_appointments);
            this.Controls.Add(this.btn_admin_view_clinics);

            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);

            this.Controls.Add(this.btn_admin_add);
            this.Controls.Add(this.btn_admin_edit);
            this.Controls.Add(this.btn_admin_delete);
            this.Controls.Add(this.btn_admin_approve_leave);

            this.Load += new System.EventHandler(this.Form2_Load);

            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_admin_display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_admin_display;
        private System.Windows.Forms.Button btn_admin_view_employees;
        private System.Windows.Forms.Button btn_admin_view_shifts;
        private System.Windows.Forms.Button btn_admin_view_leaves;
        private System.Windows.Forms.Button btn_admin_view_appointments;
        private System.Windows.Forms.Button btn_admin_view_clinics;
        private System.Windows.Forms.Button btn_admin_add;
        private System.Windows.Forms.Button btn_admin_edit;
        private System.Windows.Forms.Button btn_admin_delete;
        private System.Windows.Forms.Button btn_admin_approve_leave;
        private System.Windows.Forms.Timer timer_admin_animation;
    }
}