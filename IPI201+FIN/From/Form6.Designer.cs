namespace IPI201_FIN
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_clinic_header = new System.Windows.Forms.Panel();
            this.lbl_clinic_title = new System.Windows.Forms.Label();
            this.lbl_clinic_subtitle = new System.Windows.Forms.Label();
            this.lbl_clinic_employee_name = new System.Windows.Forms.Label();
            this.lbl_clinic_icon_syringe = new System.Windows.Forms.Label();
            this.lbl_clinic_icon_bone = new System.Windows.Forms.Label();
            this.lbl_clinic_icon_stethoscope = new System.Windows.Forms.Label();
            this.lbl_clinic_icon_cross = new System.Windows.Forms.Label();
            this.lbl_clinic_icon_scissors = new System.Windows.Forms.Label();
            this.pnl_clinic_actions = new System.Windows.Forms.Panel();
            this.lbl_clinic_icon_bandage = new System.Windows.Forms.Label();
            this.lbl_clinic_actions_title = new System.Windows.Forms.Label();
            this.btn_clinic_add = new System.Windows.Forms.Button();
            this.btn_clinic_edit = new System.Windows.Forms.Button();
            this.btn_clinic_delete = new System.Windows.Forms.Button();
            this.btn_clinic_need_radiology = new System.Windows.Forms.Button();
            this.lbl_clinic_icon_thermometer = new System.Windows.Forms.Label();
            this.lbl_clinic_icon_microscope = new System.Windows.Forms.Label();
            this.pnl_clinic_content = new System.Windows.Forms.Panel();
            this.grp_clinic_patient_info = new System.Windows.Forms.GroupBox();
            this.lbl_clinic_patient_name = new System.Windows.Forms.Label();
            this.txt_clinic_patient_name = new System.Windows.Forms.TextBox();
            this.lbl_clinic_patient_age = new System.Windows.Forms.Label();
            this.txt_clinic_patient_age = new System.Windows.Forms.TextBox();
            this.lbl_clinic_patient_gender = new System.Windows.Forms.Label();
            this.txt_clinic_patient_gender = new System.Windows.Forms.TextBox();
            this.lbl_clinic_patient_blood = new System.Windows.Forms.Label();
            this.txt_clinic_patient_blood = new System.Windows.Forms.TextBox();
            this.lbl_clinic_patient_diagnosis = new System.Windows.Forms.Label();
            this.txt_clinic_patient_diagnosis = new System.Windows.Forms.TextBox();
            this.lbl_clinic_records_title = new System.Windows.Forms.Label();
            this.dgv_clinic_records = new System.Windows.Forms.DataGridView();
            this.timer_clinic_animation = new System.Windows.Forms.Timer(this.components);
            this.pnl_clinic_header.SuspendLayout();
            this.pnl_clinic_actions.SuspendLayout();
            this.pnl_clinic_content.SuspendLayout();
            this.grp_clinic_patient_info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clinic_records)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_clinic_header
            // 
            this.pnl_clinic_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.pnl_clinic_header.Controls.Add(this.lbl_clinic_title);
            this.pnl_clinic_header.Controls.Add(this.lbl_clinic_subtitle);
            this.pnl_clinic_header.Controls.Add(this.lbl_clinic_employee_name);
            this.pnl_clinic_header.Controls.Add(this.lbl_clinic_icon_syringe);
            this.pnl_clinic_header.Controls.Add(this.lbl_clinic_icon_bone);
            this.pnl_clinic_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_clinic_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_clinic_header.Name = "pnl_clinic_header";
            this.pnl_clinic_header.Size = new System.Drawing.Size(1127, 80);
            this.pnl_clinic_header.TabIndex = 0;
            // 
            // lbl_clinic_title
            // 
            this.lbl_clinic_title.AutoSize = true;
            this.lbl_clinic_title.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_clinic_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_title.Location = new System.Drawing.Point(35, 0);
            this.lbl_clinic_title.Name = "lbl_clinic_title";
            this.lbl_clinic_title.Size = new System.Drawing.Size(115, 41);
            this.lbl_clinic_title.TabIndex = 0;
            this.lbl_clinic_title.Text = "CLINIC";
            // 
            // lbl_clinic_subtitle
            // 
            this.lbl_clinic_subtitle.AutoSize = true;
            this.lbl_clinic_subtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_clinic_subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(160)))), ((int)(((byte)(180)))));
            this.lbl_clinic_subtitle.Location = new System.Drawing.Point(35, 55);
            this.lbl_clinic_subtitle.Name = "lbl_clinic_subtitle";
            this.lbl_clinic_subtitle.Size = new System.Drawing.Size(167, 19);
            this.lbl_clinic_subtitle.TabIndex = 1;
            this.lbl_clinic_subtitle.Text = "DOCTOR CONSULTATION";
            // 
            // lbl_clinic_employee_name
            // 
            this.lbl_clinic_employee_name.AutoSize = true;
            this.lbl_clinic_employee_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_clinic_employee_name.ForeColor = System.Drawing.Color.White;
            this.lbl_clinic_employee_name.Location = new System.Drawing.Point(880, 28);
            this.lbl_clinic_employee_name.Name = "lbl_clinic_employee_name";
            this.lbl_clinic_employee_name.Size = new System.Drawing.Size(121, 25);
            this.lbl_clinic_employee_name.TabIndex = 2;
            this.lbl_clinic_employee_name.Text = "اسم الموظف:";
            // 
            // lbl_clinic_icon_syringe
            // 
            this.lbl_clinic_icon_syringe.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_syringe.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lbl_clinic_icon_syringe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_syringe.Location = new System.Drawing.Point(510, 12);
            this.lbl_clinic_icon_syringe.Name = "lbl_clinic_icon_syringe";
            this.lbl_clinic_icon_syringe.Size = new System.Drawing.Size(55, 55);
            this.lbl_clinic_icon_syringe.TabIndex = 5;
            this.lbl_clinic_icon_syringe.Text = "💉";
            this.lbl_clinic_icon_syringe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clinic_icon_bone
            // 
            this.lbl_clinic_icon_bone.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_bone.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lbl_clinic_icon_bone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_bone.Location = new System.Drawing.Point(730, 12);
            this.lbl_clinic_icon_bone.Name = "lbl_clinic_icon_bone";
            this.lbl_clinic_icon_bone.Size = new System.Drawing.Size(55, 55);
            this.lbl_clinic_icon_bone.TabIndex = 9;
            this.lbl_clinic_icon_bone.Text = "🦴";
            this.lbl_clinic_icon_bone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clinic_icon_stethoscope
            // 
            this.lbl_clinic_icon_stethoscope.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_stethoscope.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lbl_clinic_icon_stethoscope.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_stethoscope.Location = new System.Drawing.Point(1200, 289);
            this.lbl_clinic_icon_stethoscope.Name = "lbl_clinic_icon_stethoscope";
            this.lbl_clinic_icon_stethoscope.Size = new System.Drawing.Size(55, 55);
            this.lbl_clinic_icon_stethoscope.TabIndex = 4;
            this.lbl_clinic_icon_stethoscope.Text = "🩺";
            this.lbl_clinic_icon_stethoscope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clinic_icon_cross
            // 
            this.lbl_clinic_icon_cross.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_cross.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lbl_clinic_icon_cross.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_cross.Location = new System.Drawing.Point(-28, -31);
            this.lbl_clinic_icon_cross.Name = "lbl_clinic_icon_cross";
            this.lbl_clinic_icon_cross.Size = new System.Drawing.Size(130, 140);
            this.lbl_clinic_icon_cross.TabIndex = 8;
            this.lbl_clinic_icon_cross.Text = "⚕️";
            this.lbl_clinic_icon_cross.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clinic_icon_scissors
            // 
            this.lbl_clinic_icon_scissors.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_scissors.Font = new System.Drawing.Font("Segoe UI Emoji", 26F);
            this.lbl_clinic_icon_scissors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_scissors.Location = new System.Drawing.Point(21, 533);
            this.lbl_clinic_icon_scissors.Name = "lbl_clinic_icon_scissors";
            this.lbl_clinic_icon_scissors.Size = new System.Drawing.Size(133, 194);
            this.lbl_clinic_icon_scissors.TabIndex = 10;
            this.lbl_clinic_icon_scissors.Text = "✂️";
            this.lbl_clinic_icon_scissors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_clinic_actions
            // 
            this.pnl_clinic_actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.pnl_clinic_actions.Controls.Add(this.lbl_clinic_icon_bandage);
            this.pnl_clinic_actions.Controls.Add(this.lbl_clinic_actions_title);
            this.pnl_clinic_actions.Controls.Add(this.btn_clinic_add);
            this.pnl_clinic_actions.Controls.Add(this.btn_clinic_edit);
            this.pnl_clinic_actions.Controls.Add(this.lbl_clinic_icon_cross);
            this.pnl_clinic_actions.Controls.Add(this.btn_clinic_delete);
            this.pnl_clinic_actions.Controls.Add(this.btn_clinic_need_radiology);
            this.pnl_clinic_actions.Controls.Add(this.lbl_clinic_icon_thermometer);
            this.pnl_clinic_actions.Controls.Add(this.lbl_clinic_icon_microscope);
            this.pnl_clinic_actions.Controls.Add(this.lbl_clinic_icon_scissors);
            this.pnl_clinic_actions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_clinic_actions.Location = new System.Drawing.Point(1127, 0);
            this.pnl_clinic_actions.Name = "pnl_clinic_actions";
            this.pnl_clinic_actions.Size = new System.Drawing.Size(243, 749);
            this.pnl_clinic_actions.TabIndex = 1;
            // 
            // lbl_clinic_icon_bandage
            // 
            this.lbl_clinic_icon_bandage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_bandage.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lbl_clinic_icon_bandage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_bandage.Location = new System.Drawing.Point(21, 439);
            this.lbl_clinic_icon_bandage.Name = "lbl_clinic_icon_bandage";
            this.lbl_clinic_icon_bandage.Size = new System.Drawing.Size(106, 70);
            this.lbl_clinic_icon_bandage.TabIndex = 13;
            this.lbl_clinic_icon_bandage.Text = "🩹";
            this.lbl_clinic_icon_bandage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clinic_actions_title
            // 
            this.lbl_clinic_actions_title.AutoSize = true;
            this.lbl_clinic_actions_title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_clinic_actions_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_actions_title.Location = new System.Drawing.Point(55, 15);
            this.lbl_clinic_actions_title.Name = "lbl_clinic_actions_title";
            this.lbl_clinic_actions_title.Size = new System.Drawing.Size(74, 20);
            this.lbl_clinic_actions_title.TabIndex = 0;
            this.lbl_clinic_actions_title.Text = "ACTIONS";
            // 
            // btn_clinic_add
            // 
            this.btn_clinic_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            this.btn_clinic_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clinic_add.FlatAppearance.BorderSize = 0;
            this.btn_clinic_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clinic_add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clinic_add.ForeColor = System.Drawing.Color.White;
            this.btn_clinic_add.Location = new System.Drawing.Point(32, 71);
            this.btn_clinic_add.Name = "btn_clinic_add";
            this.btn_clinic_add.Size = new System.Drawing.Size(150, 63);
            this.btn_clinic_add.TabIndex = 2;
            this.btn_clinic_add.Text = "إضافة";
            this.btn_clinic_add.UseVisualStyleBackColor = false;
            // 
            // btn_clinic_edit
            // 
            this.btn_clinic_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_clinic_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clinic_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.btn_clinic_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clinic_edit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clinic_edit.ForeColor = System.Drawing.Color.White;
            this.btn_clinic_edit.Location = new System.Drawing.Point(32, 165);
            this.btn_clinic_edit.Name = "btn_clinic_edit";
            this.btn_clinic_edit.Size = new System.Drawing.Size(150, 73);
            this.btn_clinic_edit.TabIndex = 3;
            this.btn_clinic_edit.Text = "تعديل";
            this.btn_clinic_edit.UseVisualStyleBackColor = false;
            // 
            // btn_clinic_delete
            // 
            this.btn_clinic_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_clinic_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clinic_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(120)))));
            this.btn_clinic_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clinic_delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clinic_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(160)))));
            this.btn_clinic_delete.Location = new System.Drawing.Point(32, 262);
            this.btn_clinic_delete.Name = "btn_clinic_delete";
            this.btn_clinic_delete.Size = new System.Drawing.Size(150, 67);
            this.btn_clinic_delete.TabIndex = 4;
            this.btn_clinic_delete.Text = "حذف";
            this.btn_clinic_delete.UseVisualStyleBackColor = false;
            // 
            // btn_clinic_need_radiology
            // 
            this.btn_clinic_need_radiology.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_clinic_need_radiology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clinic_need_radiology.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(180)))), ((int)(((byte)(80)))));
            this.btn_clinic_need_radiology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clinic_need_radiology.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_clinic_need_radiology.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(120)))));
            this.btn_clinic_need_radiology.Location = new System.Drawing.Point(32, 347);
            this.btn_clinic_need_radiology.Name = "btn_clinic_need_radiology";
            this.btn_clinic_need_radiology.Size = new System.Drawing.Size(150, 68);
            this.btn_clinic_need_radiology.TabIndex = 5;
            this.btn_clinic_need_radiology.Text = "يحتاج أشعة";
            this.btn_clinic_need_radiology.UseVisualStyleBackColor = false;
            // 
            // lbl_clinic_icon_thermometer
            // 
            this.lbl_clinic_icon_thermometer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_thermometer.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lbl_clinic_icon_thermometer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_thermometer.Location = new System.Drawing.Point(188, -15);
            this.lbl_clinic_icon_thermometer.Name = "lbl_clinic_icon_thermometer";
            this.lbl_clinic_icon_thermometer.Size = new System.Drawing.Size(60, 176);
            this.lbl_clinic_icon_thermometer.TabIndex = 6;
            this.lbl_clinic_icon_thermometer.Text = "🌡️";
            this.lbl_clinic_icon_thermometer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_clinic_icon_microscope
            // 
            this.lbl_clinic_icon_microscope.BackColor = System.Drawing.Color.Transparent;
            this.lbl_clinic_icon_microscope.Font = new System.Drawing.Font("Segoe UI Emoji", 30F);
            this.lbl_clinic_icon_microscope.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_icon_microscope.Location = new System.Drawing.Point(180, 498);
            this.lbl_clinic_icon_microscope.Name = "lbl_clinic_icon_microscope";
            this.lbl_clinic_icon_microscope.Size = new System.Drawing.Size(60, 159);
            this.lbl_clinic_icon_microscope.TabIndex = 12;
            this.lbl_clinic_icon_microscope.Text = "🔬";
            this.lbl_clinic_icon_microscope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_clinic_content
            // 
            this.pnl_clinic_content.AutoScroll = true;
            this.pnl_clinic_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.pnl_clinic_content.Controls.Add(this.grp_clinic_patient_info);
            this.pnl_clinic_content.Controls.Add(this.lbl_clinic_records_title);
            this.pnl_clinic_content.Controls.Add(this.dgv_clinic_records);
            this.pnl_clinic_content.Controls.Add(this.lbl_clinic_icon_stethoscope);
            this.pnl_clinic_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_clinic_content.Location = new System.Drawing.Point(0, 0);
            this.pnl_clinic_content.Name = "pnl_clinic_content";
            this.pnl_clinic_content.Size = new System.Drawing.Size(1370, 749);
            this.pnl_clinic_content.TabIndex = 6;
            // 
            // grp_clinic_patient_info
            // 
            this.grp_clinic_patient_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.grp_clinic_patient_info.Controls.Add(this.lbl_clinic_patient_name);
            this.grp_clinic_patient_info.Controls.Add(this.txt_clinic_patient_name);
            this.grp_clinic_patient_info.Controls.Add(this.lbl_clinic_patient_age);
            this.grp_clinic_patient_info.Controls.Add(this.txt_clinic_patient_age);
            this.grp_clinic_patient_info.Controls.Add(this.lbl_clinic_patient_gender);
            this.grp_clinic_patient_info.Controls.Add(this.txt_clinic_patient_gender);
            this.grp_clinic_patient_info.Controls.Add(this.lbl_clinic_patient_blood);
            this.grp_clinic_patient_info.Controls.Add(this.txt_clinic_patient_blood);
            this.grp_clinic_patient_info.Controls.Add(this.lbl_clinic_patient_diagnosis);
            this.grp_clinic_patient_info.Controls.Add(this.txt_clinic_patient_diagnosis);
            this.grp_clinic_patient_info.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grp_clinic_patient_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.grp_clinic_patient_info.Location = new System.Drawing.Point(324, 120);
            this.grp_clinic_patient_info.Name = "grp_clinic_patient_info";
            this.grp_clinic_patient_info.Size = new System.Drawing.Size(880, 180);
            this.grp_clinic_patient_info.TabIndex = 7;
            this.grp_clinic_patient_info.TabStop = false;
            this.grp_clinic_patient_info.Text = "معلومات المريض";
            // 
            // lbl_clinic_patient_name
            // 
            this.lbl_clinic_patient_name.AutoSize = true;
            this.lbl_clinic_patient_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_clinic_patient_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lbl_clinic_patient_name.Location = new System.Drawing.Point(760, 35);
            this.lbl_clinic_patient_name.Name = "lbl_clinic_patient_name";
            this.lbl_clinic_patient_name.Size = new System.Drawing.Size(88, 19);
            this.lbl_clinic_patient_name.TabIndex = 0;
            this.lbl_clinic_patient_name.Text = "اسم المريض:";
            // 
            // txt_clinic_patient_name
            // 
            this.txt_clinic_patient_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txt_clinic_patient_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clinic_patient_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_clinic_patient_name.ForeColor = System.Drawing.Color.White;
            this.txt_clinic_patient_name.Location = new System.Drawing.Point(460, 32);
            this.txt_clinic_patient_name.Name = "txt_clinic_patient_name";
            this.txt_clinic_patient_name.Size = new System.Drawing.Size(280, 25);
            this.txt_clinic_patient_name.TabIndex = 8;
            // 
            // lbl_clinic_patient_age
            // 
            this.lbl_clinic_patient_age.AutoSize = true;
            this.lbl_clinic_patient_age.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_clinic_patient_age.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lbl_clinic_patient_age.Location = new System.Drawing.Point(370, 35);
            this.lbl_clinic_patient_age.Name = "lbl_clinic_patient_age";
            this.lbl_clinic_patient_age.Size = new System.Drawing.Size(43, 19);
            this.lbl_clinic_patient_age.TabIndex = 9;
            this.lbl_clinic_patient_age.Text = "العمر:";
            // 
            // txt_clinic_patient_age
            // 
            this.txt_clinic_patient_age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txt_clinic_patient_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clinic_patient_age.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_clinic_patient_age.ForeColor = System.Drawing.Color.White;
            this.txt_clinic_patient_age.Location = new System.Drawing.Point(280, 32);
            this.txt_clinic_patient_age.Name = "txt_clinic_patient_age";
            this.txt_clinic_patient_age.Size = new System.Drawing.Size(80, 25);
            this.txt_clinic_patient_age.TabIndex = 9;
            // 
            // lbl_clinic_patient_gender
            // 
            this.lbl_clinic_patient_gender.AutoSize = true;
            this.lbl_clinic_patient_gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_clinic_patient_gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lbl_clinic_patient_gender.Location = new System.Drawing.Point(190, 35);
            this.lbl_clinic_patient_gender.Name = "lbl_clinic_patient_gender";
            this.lbl_clinic_patient_gender.Size = new System.Drawing.Size(50, 19);
            this.lbl_clinic_patient_gender.TabIndex = 10;
            this.lbl_clinic_patient_gender.Text = "الجنس:";
            // 
            // txt_clinic_patient_gender
            // 
            this.txt_clinic_patient_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txt_clinic_patient_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clinic_patient_gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_clinic_patient_gender.ForeColor = System.Drawing.Color.White;
            this.txt_clinic_patient_gender.Location = new System.Drawing.Point(90, 32);
            this.txt_clinic_patient_gender.Name = "txt_clinic_patient_gender";
            this.txt_clinic_patient_gender.Size = new System.Drawing.Size(90, 25);
            this.txt_clinic_patient_gender.TabIndex = 10;
            // 
            // lbl_clinic_patient_blood
            // 
            this.lbl_clinic_patient_blood.AutoSize = true;
            this.lbl_clinic_patient_blood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_clinic_patient_blood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lbl_clinic_patient_blood.Location = new System.Drawing.Point(760, 80);
            this.lbl_clinic_patient_blood.Name = "lbl_clinic_patient_blood";
            this.lbl_clinic_patient_blood.Size = new System.Drawing.Size(78, 19);
            this.lbl_clinic_patient_blood.TabIndex = 11;
            this.lbl_clinic_patient_blood.Text = "فصيلة الدم:";
            // 
            // txt_clinic_patient_blood
            // 
            this.txt_clinic_patient_blood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txt_clinic_patient_blood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clinic_patient_blood.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_clinic_patient_blood.ForeColor = System.Drawing.Color.White;
            this.txt_clinic_patient_blood.Location = new System.Drawing.Point(460, 77);
            this.txt_clinic_patient_blood.Name = "txt_clinic_patient_blood";
            this.txt_clinic_patient_blood.Size = new System.Drawing.Size(280, 25);
            this.txt_clinic_patient_blood.TabIndex = 11;
            // 
            // lbl_clinic_patient_diagnosis
            // 
            this.lbl_clinic_patient_diagnosis.AutoSize = true;
            this.lbl_clinic_patient_diagnosis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_clinic_patient_diagnosis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lbl_clinic_patient_diagnosis.Location = new System.Drawing.Point(760, 125);
            this.lbl_clinic_patient_diagnosis.Name = "lbl_clinic_patient_diagnosis";
            this.lbl_clinic_patient_diagnosis.Size = new System.Drawing.Size(70, 19);
            this.lbl_clinic_patient_diagnosis.TabIndex = 12;
            this.lbl_clinic_patient_diagnosis.Text = "التشخيص:";
            // 
            // txt_clinic_patient_diagnosis
            // 
            this.txt_clinic_patient_diagnosis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.txt_clinic_patient_diagnosis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_clinic_patient_diagnosis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_clinic_patient_diagnosis.ForeColor = System.Drawing.Color.White;
            this.txt_clinic_patient_diagnosis.Location = new System.Drawing.Point(90, 122);
            this.txt_clinic_patient_diagnosis.Name = "txt_clinic_patient_diagnosis";
            this.txt_clinic_patient_diagnosis.Size = new System.Drawing.Size(650, 25);
            this.txt_clinic_patient_diagnosis.TabIndex = 12;
            // 
            // lbl_clinic_records_title
            // 
            this.lbl_clinic_records_title.AutoSize = true;
            this.lbl_clinic_records_title.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_clinic_records_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lbl_clinic_records_title.Location = new System.Drawing.Point(1056, 303);
            this.lbl_clinic_records_title.Name = "lbl_clinic_records_title";
            this.lbl_clinic_records_title.Size = new System.Drawing.Size(117, 25);
            this.lbl_clinic_records_title.TabIndex = 8;
            this.lbl_clinic_records_title.Text = "سجل المريض";
            // 
            // dgv_clinic_records
            // 
            this.dgv_clinic_records.AllowUserToAddRows = false;
            this.dgv_clinic_records.AllowUserToDeleteRows = false;
            this.dgv_clinic_records.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_clinic_records.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(42)))));
            this.dgv_clinic_records.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_clinic_records.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_clinic_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(38)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_clinic_records.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_clinic_records.EnableHeadersVisualStyles = false;
            this.dgv_clinic_records.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.dgv_clinic_records.Location = new System.Drawing.Point(324, 347);
            this.dgv_clinic_records.Name = "dgv_clinic_records";
            this.dgv_clinic_records.ReadOnly = true;
            this.dgv_clinic_records.RowHeadersVisible = false;
            this.dgv_clinic_records.RowHeadersWidth = 51;
            this.dgv_clinic_records.RowTemplate.Height = 35;
            this.dgv_clinic_records.Size = new System.Drawing.Size(880, 380);
            this.dgv_clinic_records.TabIndex = 13;
            this.dgv_clinic_records.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clinic_records_CellContentClick);
            // 
            // timer_clinic_animation
            // 
            this.timer_clinic_animation.Interval = 50;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnl_clinic_header);
            this.Controls.Add(this.pnl_clinic_actions);
            this.Controls.Add(this.pnl_clinic_content);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form6";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "واجهة العيادة - الدكتور";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.pnl_clinic_header.ResumeLayout(false);
            this.pnl_clinic_header.PerformLayout();
            this.pnl_clinic_actions.ResumeLayout(false);
            this.pnl_clinic_actions.PerformLayout();
            this.pnl_clinic_content.ResumeLayout(false);
            this.pnl_clinic_content.PerformLayout();
            this.grp_clinic_patient_info.ResumeLayout(false);
            this.grp_clinic_patient_info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clinic_records)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // ===== Header =====
        private System.Windows.Forms.Panel pnl_clinic_header;
        private System.Windows.Forms.Label lbl_clinic_title;
        private System.Windows.Forms.Label lbl_clinic_subtitle;
        private System.Windows.Forms.Label lbl_clinic_employee_name;
        private System.Windows.Forms.Label lbl_clinic_icon_stethoscope;
        private System.Windows.Forms.Label lbl_clinic_icon_syringe;
        private System.Windows.Forms.Label lbl_clinic_icon_cross;
        private System.Windows.Forms.Label lbl_clinic_icon_bone;
        private System.Windows.Forms.Label lbl_clinic_icon_scissors;

        // ===== Sidebar =====
        private System.Windows.Forms.Panel pnl_clinic_actions;
        private System.Windows.Forms.Label lbl_clinic_actions_title;
        private System.Windows.Forms.Button btn_clinic_add;
        private System.Windows.Forms.Button btn_clinic_edit;
        private System.Windows.Forms.Button btn_clinic_delete;
        private System.Windows.Forms.Button btn_clinic_need_radiology;

        // ===== أيقونات Sidebar =====
        private System.Windows.Forms.Label lbl_clinic_icon_thermometer;
        private System.Windows.Forms.Label lbl_clinic_icon_microscope;

        // ===== Content =====
        private System.Windows.Forms.Panel pnl_clinic_content;

        // ===== Patient Info =====
        private System.Windows.Forms.GroupBox grp_clinic_patient_info;
        private System.Windows.Forms.Label lbl_clinic_patient_name;
        private System.Windows.Forms.TextBox txt_clinic_patient_name;
        private System.Windows.Forms.Label lbl_clinic_patient_age;
        private System.Windows.Forms.TextBox txt_clinic_patient_age;
        private System.Windows.Forms.Label lbl_clinic_patient_gender;
        private System.Windows.Forms.TextBox txt_clinic_patient_gender;
        private System.Windows.Forms.Label lbl_clinic_patient_blood;
        private System.Windows.Forms.TextBox txt_clinic_patient_blood;
        private System.Windows.Forms.Label lbl_clinic_patient_diagnosis;
        private System.Windows.Forms.TextBox txt_clinic_patient_diagnosis;

        // ===== Records =====
        private System.Windows.Forms.Label lbl_clinic_records_title;
        private System.Windows.Forms.DataGridView dgv_clinic_records;

        private System.Windows.Forms.Timer timer_clinic_animation;
        private System.Windows.Forms.Label lbl_clinic_icon_bandage;
    }
}