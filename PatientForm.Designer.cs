namespace HospitalAppoinmentSystem
{
    partial class PatientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle45 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle46 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle47 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle48 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle55 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle49 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle50 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle51 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle52 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle53 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle54 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle56 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle57 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle63 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle58 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle59 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle60 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle61 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle62 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblWelcome = new Label();
            picHospitalLogo = new PictureBox();
            tabMainControl = new TabControl();
            tabDashboard = new TabPage();
            pnlDashboardInfo = new Panel();
            gbUpcomingAppontments = new GroupBox();
            dgvUpComing = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colDoctor = new DataGridViewTextBoxColumn();
            gbPersonelInfo = new GroupBox();
            lblTotalAppValue = new Label();
            lblTotalAppTitle = new Label();
            lblEmailValue = new Label();
            lblEmailTitle = new Label();
            lblNameValue = new Label();
            lblNameTitle = new Label();
            tabNewAppointment = new TabPage();
            gbAppointmentSummary = new GroupBox();
            txtAppointmentSummary = new TextBox();
            gbAppointmentDetails = new GroupBox();
            btnCreateAppointment = new Button();
            cmbAppointmentTime = new ComboBox();
            lblTime = new Label();
            dtpAppointmentDate = new DateTimePicker();
            lblDate = new Label();
            cmbDoctor = new ComboBox();
            lblDoctor = new Label();
            cmbDepartment = new ComboBox();
            lblDepartment = new Label();
            tabAppointments = new TabPage();
            tabAppointmentList = new TabControl();
            tabUpComing = new TabPage();
            dgvFutureAppointments = new DataGridView();
            colFutureDate = new DataGridViewTextBoxColumn();
            colFutureTime = new DataGridViewTextBoxColumn();
            colFutureDepartment = new DataGridViewTextBoxColumn();
            colFutureDoctor = new DataGridViewTextBoxColumn();
            colFutureStatus = new DataGridViewTextBoxColumn();
            colCancelButton = new DataGridViewButtonColumn();
            tabPast = new TabPage();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            notifyIcon1 = new NotifyIcon(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHospitalLogo).BeginInit();
            tabMainControl.SuspendLayout();
            tabDashboard.SuspendLayout();
            pnlDashboardInfo.SuspendLayout();
            gbUpcomingAppontments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpComing).BeginInit();
            gbPersonelInfo.SuspendLayout();
            tabNewAppointment.SuspendLayout();
            gbAppointmentSummary.SuspendLayout();
            gbAppointmentDetails.SuspendLayout();
            tabAppointments.SuspendLayout();
            tabAppointmentList.SuspendLayout();
            tabUpComing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFutureAppointments).BeginInit();
            tabPast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(45, 62, 80);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(picHospitalLogo);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1008, 80);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 82, 83);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(932, 25);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(70, 30);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Çıkış";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(120, 26);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(294, 30);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "HOŞGELDİNİZ [HASTA ADI]";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picHospitalLogo
            // 
            picHospitalLogo.BackColor = Color.Transparent;
            picHospitalLogo.Image = Properties.Resources.icons8_hospital_96;
            picHospitalLogo.Location = new Point(12, 0);
            picHospitalLogo.Name = "picHospitalLogo";
            picHospitalLogo.Size = new Size(80, 80);
            picHospitalLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picHospitalLogo.TabIndex = 0;
            picHospitalLogo.TabStop = false;
            // 
            // tabMainControl
            // 
            tabMainControl.Appearance = TabAppearance.FlatButtons;
            tabMainControl.Controls.Add(tabDashboard);
            tabMainControl.Controls.Add(tabNewAppointment);
            tabMainControl.Controls.Add(tabAppointments);
            tabMainControl.Dock = DockStyle.Fill;
            tabMainControl.Font = new Font("Segoe UI", 10F);
            tabMainControl.ItemSize = new Size(100, 30);
            tabMainControl.Location = new Point(0, 80);
            tabMainControl.Name = "tabMainControl";
            tabMainControl.Padding = new Point(6, 6);
            tabMainControl.SelectedIndex = 0;
            tabMainControl.Size = new Size(1008, 649);
            tabMainControl.SizeMode = TabSizeMode.Fixed;
            tabMainControl.TabIndex = 1;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.White;
            tabDashboard.Controls.Add(pnlDashboardInfo);
            tabDashboard.Location = new Point(4, 34);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(10);
            tabDashboard.Size = new Size(1000, 611);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Ana Sayfa";
            // 
            // pnlDashboardInfo
            // 
            pnlDashboardInfo.BackColor = Color.FromArgb(245, 247, 249);
            pnlDashboardInfo.Controls.Add(gbUpcomingAppontments);
            pnlDashboardInfo.Controls.Add(gbPersonelInfo);
            pnlDashboardInfo.Dock = DockStyle.Top;
            pnlDashboardInfo.Location = new Point(10, 10);
            pnlDashboardInfo.Name = "pnlDashboardInfo";
            pnlDashboardInfo.Padding = new Padding(20);
            pnlDashboardInfo.Size = new Size(980, 598);
            pnlDashboardInfo.TabIndex = 0;
            // 
            // gbUpcomingAppontments
            // 
            gbUpcomingAppontments.BackColor = Color.AliceBlue;
            gbUpcomingAppontments.Controls.Add(dgvUpComing);
            gbUpcomingAppontments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbUpcomingAppontments.ForeColor = Color.FromArgb(45, 62, 80);
            gbUpcomingAppontments.Location = new Point(448, 20);
            gbUpcomingAppontments.Name = "gbUpcomingAppontments";
            gbUpcomingAppontments.Size = new Size(367, 489);
            gbUpcomingAppontments.TabIndex = 1;
            gbUpcomingAppontments.TabStop = false;
            gbUpcomingAppontments.Text = "Yaklaşan Randevularım";
            // 
            // dgvUpComing
            // 
            dgvUpComing.AllowUserToAddRows = false;
            dgvUpComing.AllowUserToDeleteRows = false;
            dgvUpComing.AllowUserToResizeRows = false;
            dgvUpComing.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvUpComing.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUpComing.BackgroundColor = Color.White;
            dgvUpComing.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUpComing.Columns.AddRange(new DataGridViewColumn[] { colDate, colTime, colDepartment, colDoctor });
            dgvUpComing.Dock = DockStyle.Fill;
            dgvUpComing.GridColor = Color.FromArgb(45, 62, 80);
            dgvUpComing.Location = new Point(3, 23);
            dgvUpComing.MultiSelect = false;
            dgvUpComing.Name = "dgvUpComing";
            dgvUpComing.ReadOnly = true;
            dgvUpComing.RowHeadersVisible = false;
            dgvUpComing.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpComing.Size = new Size(361, 463);
            dgvUpComing.TabIndex = 0;
            // 
            // colDate
            // 
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDate.DataPropertyName = "AppointmentDate";
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle43.Format = "dd.MM.yyyy";
            dataGridViewCellStyle43.NullValue = null;
            colDate.DefaultCellStyle = dataGridViewCellStyle43;
            colDate.HeaderText = "Tarih";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Resizable = DataGridViewTriState.False;
            colDate.Width = 80;
            // 
            // colTime
            // 
            colTime.DataPropertyName = "AppointmentTime";
            dataGridViewCellStyle44.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle44.Format = "HH:mm";
            colTime.DefaultCellStyle = dataGridViewCellStyle44;
            colTime.HeaderText = "Saat";
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.Resizable = DataGridViewTriState.False;
            colTime.Width = 64;
            // 
            // colDepartment
            // 
            colDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDepartment.DataPropertyName = "DepartmentName";
            dataGridViewCellStyle45.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle45.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle45.Padding = new Padding(5, 0, 0, 0);
            colDepartment.DefaultCellStyle = dataGridViewCellStyle45;
            colDepartment.HeaderText = "Bölüm";
            colDepartment.Name = "colDepartment";
            colDepartment.ReadOnly = true;
            colDepartment.Resizable = DataGridViewTriState.False;
            // 
            // colDoctor
            // 
            colDoctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDoctor.DataPropertyName = "DoctorName";
            dataGridViewCellStyle46.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle46.Padding = new Padding(5, 0, 0, 0);
            colDoctor.DefaultCellStyle = dataGridViewCellStyle46;
            colDoctor.HeaderText = "Doktor";
            colDoctor.Name = "colDoctor";
            colDoctor.ReadOnly = true;
            colDoctor.Resizable = DataGridViewTriState.False;
            colDoctor.Width = 120;
            // 
            // gbPersonelInfo
            // 
            gbPersonelInfo.BackColor = Color.AliceBlue;
            gbPersonelInfo.Controls.Add(lblTotalAppValue);
            gbPersonelInfo.Controls.Add(lblTotalAppTitle);
            gbPersonelInfo.Controls.Add(lblEmailValue);
            gbPersonelInfo.Controls.Add(lblEmailTitle);
            gbPersonelInfo.Controls.Add(lblNameValue);
            gbPersonelInfo.Controls.Add(lblNameTitle);
            gbPersonelInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbPersonelInfo.ForeColor = Color.FromArgb(45, 62, 80);
            gbPersonelInfo.Location = new Point(20, 20);
            gbPersonelInfo.Name = "gbPersonelInfo";
            gbPersonelInfo.Size = new Size(350, 270);
            gbPersonelInfo.TabIndex = 0;
            gbPersonelInfo.TabStop = false;
            gbPersonelInfo.Text = "Profil Bilgileri";
            // 
            // lblTotalAppValue
            // 
            lblTotalAppValue.AutoSize = true;
            lblTotalAppValue.Font = new Font("Segoe UI", 10F);
            lblTotalAppValue.Location = new Point(164, 108);
            lblTotalAppValue.Name = "lblTotalAppValue";
            lblTotalAppValue.Size = new Size(54, 19);
            lblTotalAppValue.TabIndex = 7;
            lblTotalAppValue.Text = "[Değer]";
            // 
            // lblTotalAppTitle
            // 
            lblTotalAppTitle.AutoSize = true;
            lblTotalAppTitle.Font = new Font("Segoe UI", 10F);
            lblTotalAppTitle.ForeColor = SystemColors.WindowFrame;
            lblTotalAppTitle.Location = new Point(19, 108);
            lblTotalAppTitle.Name = "lblTotalAppTitle";
            lblTotalAppTitle.Size = new Size(113, 19);
            lblTotalAppTitle.TabIndex = 6;
            lblTotalAppTitle.Text = "Toplam Randevu:";
            // 
            // lblEmailValue
            // 
            lblEmailValue.AutoSize = true;
            lblEmailValue.Font = new Font("Segoe UI", 10F);
            lblEmailValue.Location = new Point(164, 70);
            lblEmailValue.Name = "lblEmailValue";
            lblEmailValue.Size = new Size(54, 19);
            lblEmailValue.TabIndex = 3;
            lblEmailValue.Text = "[Değer]";
            // 
            // lblEmailTitle
            // 
            lblEmailTitle.AutoSize = true;
            lblEmailTitle.Font = new Font("Segoe UI", 10F);
            lblEmailTitle.ForeColor = SystemColors.WindowFrame;
            lblEmailTitle.Location = new Point(19, 70);
            lblEmailTitle.Name = "lblEmailTitle";
            lblEmailTitle.Size = new Size(59, 19);
            lblEmailTitle.TabIndex = 2;
            lblEmailTitle.Text = "E-posta:";
            // 
            // lblNameValue
            // 
            lblNameValue.AutoSize = true;
            lblNameValue.Font = new Font("Segoe UI", 10F);
            lblNameValue.Location = new Point(164, 40);
            lblNameValue.Name = "lblNameValue";
            lblNameValue.Size = new Size(54, 19);
            lblNameValue.TabIndex = 1;
            lblNameValue.Text = "[Değer]";
            // 
            // lblNameTitle
            // 
            lblNameTitle.AutoSize = true;
            lblNameTitle.Font = new Font("Segoe UI", 10F);
            lblNameTitle.ForeColor = SystemColors.WindowFrame;
            lblNameTitle.Location = new Point(19, 40);
            lblNameTitle.Name = "lblNameTitle";
            lblNameTitle.Size = new Size(70, 19);
            lblNameTitle.TabIndex = 0;
            lblNameTitle.Text = "Ad Soyad:";
            // 
            // tabNewAppointment
            // 
            tabNewAppointment.BackColor = Color.White;
            tabNewAppointment.Controls.Add(gbAppointmentSummary);
            tabNewAppointment.Controls.Add(gbAppointmentDetails);
            tabNewAppointment.Location = new Point(4, 34);
            tabNewAppointment.Name = "tabNewAppointment";
            tabNewAppointment.Padding = new Padding(10);
            tabNewAppointment.Size = new Size(1000, 611);
            tabNewAppointment.TabIndex = 1;
            tabNewAppointment.Text = "Randevu Al";
            // 
            // gbAppointmentSummary
            // 
            gbAppointmentSummary.BackColor = Color.FromArgb(245, 247, 80);
            gbAppointmentSummary.Controls.Add(txtAppointmentSummary);
            gbAppointmentSummary.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbAppointmentSummary.ForeColor = Color.FromArgb(45, 62, 80);
            gbAppointmentSummary.Location = new Point(389, 30);
            gbAppointmentSummary.Name = "gbAppointmentSummary";
            gbAppointmentSummary.Size = new Size(526, 517);
            gbAppointmentSummary.TabIndex = 1;
            gbAppointmentSummary.TabStop = false;
            gbAppointmentSummary.Text = "Randevu Özeti";
            // 
            // txtAppointmentSummary
            // 
            txtAppointmentSummary.BackColor = Color.White;
            txtAppointmentSummary.BorderStyle = BorderStyle.None;
            txtAppointmentSummary.Font = new Font("Segoe UI", 9F);
            txtAppointmentSummary.Location = new Point(15, 30);
            txtAppointmentSummary.Multiline = true;
            txtAppointmentSummary.Name = "txtAppointmentSummary";
            txtAppointmentSummary.ReadOnly = true;
            txtAppointmentSummary.ScrollBars = ScrollBars.Vertical;
            txtAppointmentSummary.Size = new Size(496, 467);
            txtAppointmentSummary.TabIndex = 0;
            // 
            // gbAppointmentDetails
            // 
            gbAppointmentDetails.BackColor = Color.FromArgb(245, 247, 249);
            gbAppointmentDetails.Controls.Add(btnCreateAppointment);
            gbAppointmentDetails.Controls.Add(cmbAppointmentTime);
            gbAppointmentDetails.Controls.Add(lblTime);
            gbAppointmentDetails.Controls.Add(dtpAppointmentDate);
            gbAppointmentDetails.Controls.Add(lblDate);
            gbAppointmentDetails.Controls.Add(cmbDoctor);
            gbAppointmentDetails.Controls.Add(lblDoctor);
            gbAppointmentDetails.Controls.Add(cmbDepartment);
            gbAppointmentDetails.Controls.Add(lblDepartment);
            gbAppointmentDetails.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbAppointmentDetails.ForeColor = Color.FromArgb(45, 62, 80);
            gbAppointmentDetails.Location = new Point(20, 30);
            gbAppointmentDetails.Name = "gbAppointmentDetails";
            gbAppointmentDetails.Size = new Size(300, 330);
            gbAppointmentDetails.TabIndex = 0;
            gbAppointmentDetails.TabStop = false;
            gbAppointmentDetails.Text = "Randevu Bilgileri";
            // 
            // btnCreateAppointment
            // 
            btnCreateAppointment.BackColor = Color.FromArgb(39, 174, 96);
            btnCreateAppointment.Cursor = Cursors.Hand;
            btnCreateAppointment.FlatAppearance.BorderSize = 0;
            btnCreateAppointment.FlatStyle = FlatStyle.Flat;
            btnCreateAppointment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCreateAppointment.ForeColor = Color.White;
            btnCreateAppointment.Location = new Point(15, 250);
            btnCreateAppointment.Name = "btnCreateAppointment";
            btnCreateAppointment.Size = new Size(250, 35);
            btnCreateAppointment.TabIndex = 8;
            btnCreateAppointment.Text = "RANDEVU OLUŞTUR";
            btnCreateAppointment.UseVisualStyleBackColor = false;
            btnCreateAppointment.Click += btnCreateAppointment_Click;
            // 
            // cmbAppointmentTime
            // 
            cmbAppointmentTime.BackColor = Color.White;
            cmbAppointmentTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAppointmentTime.FlatStyle = FlatStyle.Flat;
            cmbAppointmentTime.Font = new Font("Segoe UI", 9F);
            cmbAppointmentTime.FormattingEnabled = true;
            cmbAppointmentTime.Location = new Point(15, 210);
            cmbAppointmentTime.Name = "cmbAppointmentTime";
            cmbAppointmentTime.Size = new Size(250, 23);
            cmbAppointmentTime.TabIndex = 7;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTime.Location = new Point(15, 190);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(100, 20);
            lblTime.TabIndex = 6;
            lblTime.Text = "Saat Seçiniz";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.CustomFormat = "dd.MM.yyyy";
            dtpAppointmentDate.Font = new Font("Segoe UI", 9F);
            dtpAppointmentDate.Format = DateTimePickerFormat.Short;
            dtpAppointmentDate.Location = new Point(15, 155);
            dtpAppointmentDate.MaxDate = new DateTime(2025, 2, 18, 0, 0, 0, 0);
            dtpAppointmentDate.MinDate = new DateTime(2025, 1, 18, 3, 22, 48, 0);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(250, 23);
            dtpAppointmentDate.TabIndex = 5;
            dtpAppointmentDate.Value = new DateTime(2025, 1, 18, 3, 22, 48, 0);
            dtpAppointmentDate.ValueChanged += dtpAppointmentDate_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDate.Location = new Point(15, 135);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Tarih Seçiniz";
            // 
            // cmbDoctor
            // 
            cmbDoctor.BackColor = Color.White;
            cmbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDoctor.FlatStyle = FlatStyle.Flat;
            cmbDoctor.Font = new Font("Segoe UI", 9F);
            cmbDoctor.FormattingEnabled = true;
            cmbDoctor.Location = new Point(15, 100);
            cmbDoctor.Name = "cmbDoctor";
            cmbDoctor.Size = new Size(250, 23);
            cmbDoctor.TabIndex = 3;
            // 
            // lblDoctor
            // 
            lblDoctor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDoctor.Location = new Point(15, 80);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(100, 20);
            lblDoctor.TabIndex = 2;
            lblDoctor.Text = "Doktor Seçiniz";
            // 
            // cmbDepartment
            // 
            cmbDepartment.BackColor = Color.White;
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FlatStyle = FlatStyle.Flat;
            cmbDepartment.Font = new Font("Segoe UI", 9F);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(15, 45);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(250, 23);
            cmbDepartment.TabIndex = 1;
            // 
            // lblDepartment
            // 
            lblDepartment.Location = new Point(15, 25);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(100, 20);
            lblDepartment.TabIndex = 0;
            lblDepartment.Text = "Bölüm Seçiniz";
            // 
            // tabAppointments
            // 
            tabAppointments.BackColor = Color.White;
            tabAppointments.Controls.Add(tabAppointmentList);
            tabAppointments.Location = new Point(4, 34);
            tabAppointments.Margin = new Padding(10);
            tabAppointments.Name = "tabAppointments";
            tabAppointments.Padding = new Padding(3);
            tabAppointments.Size = new Size(1000, 611);
            tabAppointments.TabIndex = 2;
            tabAppointments.Text = "Randevularım";
            // 
            // tabAppointmentList
            // 
            tabAppointmentList.Appearance = TabAppearance.FlatButtons;
            tabAppointmentList.Controls.Add(tabUpComing);
            tabAppointmentList.Controls.Add(tabPast);
            tabAppointmentList.Dock = DockStyle.Fill;
            tabAppointmentList.ItemSize = new Size(150, 30);
            tabAppointmentList.Location = new Point(3, 3);
            tabAppointmentList.Name = "tabAppointmentList";
            tabAppointmentList.SelectedIndex = 0;
            tabAppointmentList.Size = new Size(994, 605);
            tabAppointmentList.SizeMode = TabSizeMode.Fixed;
            tabAppointmentList.TabIndex = 0;
            // 
            // tabUpComing
            // 
            tabUpComing.Controls.Add(dgvFutureAppointments);
            tabUpComing.Location = new Point(4, 34);
            tabUpComing.Name = "tabUpComing";
            tabUpComing.Padding = new Padding(10);
            tabUpComing.Size = new Size(986, 567);
            tabUpComing.TabIndex = 0;
            tabUpComing.Text = "Gelecek Randevular";
            tabUpComing.UseVisualStyleBackColor = true;
            // 
            // dgvFutureAppointments
            // 
            dgvFutureAppointments.AllowUserToAddRows = false;
            dgvFutureAppointments.AllowUserToDeleteRows = false;
            dgvFutureAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle47.BackColor = Color.FromArgb(245, 247, 249);
            dgvFutureAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle47;
            dgvFutureAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFutureAppointments.BackgroundColor = Color.White;
            dataGridViewCellStyle48.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle48.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle48.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle48.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle48.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle48.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle48.WrapMode = DataGridViewTriState.True;
            dgvFutureAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle48;
            dgvFutureAppointments.ColumnHeadersHeight = 30;
            dgvFutureAppointments.Columns.AddRange(new DataGridViewColumn[] { colFutureDate, colFutureTime, colFutureDepartment, colFutureDoctor, colFutureStatus, colCancelButton });
            dataGridViewCellStyle55.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = Color.White;
            dataGridViewCellStyle55.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle55.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle55.SelectionBackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle55.SelectionForeColor = Color.White;
            dataGridViewCellStyle55.WrapMode = DataGridViewTriState.False;
            dgvFutureAppointments.DefaultCellStyle = dataGridViewCellStyle55;
            dgvFutureAppointments.Dock = DockStyle.Fill;
            dgvFutureAppointments.EnableHeadersVisualStyles = false;
            dgvFutureAppointments.GridColor = Color.FromArgb(45, 62, 80);
            dgvFutureAppointments.Location = new Point(10, 10);
            dgvFutureAppointments.MultiSelect = false;
            dgvFutureAppointments.Name = "dgvFutureAppointments";
            dgvFutureAppointments.ReadOnly = true;
            dgvFutureAppointments.RowHeadersVisible = false;
            dgvFutureAppointments.RowTemplate.Height = 30;
            dgvFutureAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFutureAppointments.Size = new Size(966, 547);
            dgvFutureAppointments.TabIndex = 0;
            // 
            // colFutureDate
            // 
            colFutureDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle49.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle49.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle49.Format = "dd.MM.yyyy";
            colFutureDate.DefaultCellStyle = dataGridViewCellStyle49;
            colFutureDate.HeaderText = "Tarih";
            colFutureDate.Name = "colFutureDate";
            colFutureDate.ReadOnly = true;
            colFutureDate.Width = 150;
            // 
            // colFutureTime
            // 
            colFutureTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle50.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle50.Format = "HH:mm";
            colFutureTime.DefaultCellStyle = dataGridViewCellStyle50;
            colFutureTime.HeaderText = "Saat";
            colFutureTime.Name = "colFutureTime";
            colFutureTime.ReadOnly = true;
            colFutureTime.Resizable = DataGridViewTriState.False;
            colFutureTime.Width = 130;
            // 
            // colFutureDepartment
            // 
            colFutureDepartment.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle51.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle51.Padding = new Padding(5, 0, 0, 0);
            colFutureDepartment.DefaultCellStyle = dataGridViewCellStyle51;
            colFutureDepartment.HeaderText = "Bölüm";
            colFutureDepartment.Name = "colFutureDepartment";
            colFutureDepartment.ReadOnly = true;
            colFutureDepartment.Resizable = DataGridViewTriState.False;
            colFutureDepartment.Width = 180;
            // 
            // colFutureDoctor
            // 
            colFutureDoctor.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle52.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle52.Padding = new Padding(5, 0, 0, 0);
            colFutureDoctor.DefaultCellStyle = dataGridViewCellStyle52;
            colFutureDoctor.HeaderText = "Doktor";
            colFutureDoctor.Name = "colFutureDoctor";
            colFutureDoctor.ReadOnly = true;
            colFutureDoctor.Resizable = DataGridViewTriState.False;
            colFutureDoctor.Width = 180;
            // 
            // colFutureStatus
            // 
            colFutureStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle53.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle53.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle53.Format = "Custom";
            colFutureStatus.DefaultCellStyle = dataGridViewCellStyle53;
            colFutureStatus.HeaderText = "Durum";
            colFutureStatus.Name = "colFutureStatus";
            colFutureStatus.ReadOnly = true;
            colFutureStatus.Resizable = DataGridViewTriState.False;
            colFutureStatus.Width = 170;
            // 
            // colCancelButton
            // 
            colCancelButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle54.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = Color.FromArgb(255, 82, 82);
            dataGridViewCellStyle54.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle54.ForeColor = Color.White;
            dataGridViewCellStyle54.Padding = new Padding(2);
            dataGridViewCellStyle54.SelectionBackColor = Color.FromArgb(255, 82, 82);
            dataGridViewCellStyle54.SelectionForeColor = Color.White;
            colCancelButton.DefaultCellStyle = dataGridViewCellStyle54;
            colCancelButton.HeaderText = "İşlem";
            colCancelButton.Name = "colCancelButton";
            colCancelButton.ReadOnly = true;
            colCancelButton.Resizable = DataGridViewTriState.False;
            colCancelButton.Text = "İptal Et";
            colCancelButton.UseColumnTextForButtonValue = true;
            colCancelButton.Width = 150;
            // 
            // tabPast
            // 
            tabPast.Controls.Add(dataGridView1);
            tabPast.ImeMode = ImeMode.NoControl;
            tabPast.Location = new Point(4, 34);
            tabPast.Name = "tabPast";
            tabPast.Padding = new Padding(10);
            tabPast.Size = new Size(986, 567);
            tabPast.TabIndex = 1;
            tabPast.Text = "Geçmiş Randevular";
            tabPast.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle56.BackColor = Color.FromArgb(245, 247, 249);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle56;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle57.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle57.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle57.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle57.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle57.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle57.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle63.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = Color.White;
            dataGridViewCellStyle63.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle63.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle63.SelectionBackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle63.SelectionForeColor = Color.White;
            dataGridViewCellStyle63.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle63;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(45, 62, 80);
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(966, 547);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle58.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle58.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle58.Format = "dd.MM.yyyy";
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle58;
            dataGridViewTextBoxColumn1.HeaderText = "Tarih";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle59.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle59.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle59.Format = "HH:mm";
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle59;
            dataGridViewTextBoxColumn2.HeaderText = "Saat";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle60.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle60.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle60.Padding = new Padding(5, 0, 0, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle60;
            dataGridViewTextBoxColumn3.HeaderText = "Bölüm";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle61.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle61.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle61.Padding = new Padding(5, 0, 0, 0);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle61;
            dataGridViewTextBoxColumn4.HeaderText = "Doktor";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle62.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle62.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle62.Format = "Custom";
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle62;
            dataGridViewTextBoxColumn5.HeaderText = "Durum";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn5.Width = 200;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tabMainControl);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PatientForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hastane Randevu Sistemi - Hasta Paneli";
            Load += PatientForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHospitalLogo).EndInit();
            tabMainControl.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            pnlDashboardInfo.ResumeLayout(false);
            gbUpcomingAppontments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUpComing).EndInit();
            gbPersonelInfo.ResumeLayout(false);
            gbPersonelInfo.PerformLayout();
            tabNewAppointment.ResumeLayout(false);
            gbAppointmentSummary.ResumeLayout(false);
            gbAppointmentSummary.PerformLayout();
            gbAppointmentDetails.ResumeLayout(false);
            tabAppointments.ResumeLayout(false);
            tabAppointmentList.ResumeLayout(false);
            tabUpComing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFutureAppointments).EndInit();
            tabPast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        /*
         cortexin yazdığı randevularım sayfasındaki datagridview için kod
         *
         * dgvFutureAppointments.Rows.Add(
               appointment.Date.ToString("dd.MM.yyyy"),
               appointment.Time.ToString("HH:mm"),
               appointment.Department,
               appointment.Doctor,
               appointment.Status,
               "İptal Et"
           );

        ----------------------------------------------------------------
        private void dgvFutureAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               if (e.ColumnIndex == colCancelButton.Index && e.RowIndex >= 0)
               {
                   if (MessageBox.Show("Randevuyu iptal etmek istediğinize emin misiniz?", 
                       "Randevu İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                   {
                       // İptal işlemleri burada yapılacak
                   }
               }
           }
         *
         */

        private Panel pnlHeader;
        private PictureBox picHospitalLogo;
        private Label lblWelcome;
        private Button btnLogout;
        private TabControl tabMainControl;
        private TabPage tabDashboard;
        private TabPage tabNewAppointment;
        private TabPage tabAppointments;
        private Panel pnlDashboardInfo;
        private GroupBox gbPersonelInfo;
        private Label lblEmailTitle;
        private Label lblNameValue;
        private Label lblNameTitle;
        private Label lblTotalAppTitle;
        private Label lblEmailValue;
        private Label lblTotalAppValue;
        private GroupBox gbUpcomingAppontments;
        private DataGridView dgvUpComing;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colDoctor;
        private GroupBox gbAppointmentDetails;
        private Label lblDepartment;
        private Label lblDoctor;
        private ComboBox cmbDepartment;
        private Label lblDate;
        private ComboBox cmbDoctor;
        private DateTimePicker dtpAppointmentDate;
        private ComboBox cmbAppointmentTime;
        private Label lblTime;
        private Button btnCreateAppointment;
        private GroupBox gbAppointmentSummary;
        private TextBox txtAppointmentSummary;
        private TabControl tabAppointmentList;
        private TabPage tabUpComing;
        private TabPage tabPast;
        private DataGridView dgvFutureAppointments;
        private NotifyIcon notifyIcon1;
        private DataGridViewTextBoxColumn colFutureDate;
        private DataGridViewTextBoxColumn colFutureTime;
        private DataGridViewTextBoxColumn colFutureDepartment;
        private DataGridViewTextBoxColumn colFutureDoctor;
        private DataGridViewTextBoxColumn colFutureStatus;
        private DataGridViewButtonColumn colCancelButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}