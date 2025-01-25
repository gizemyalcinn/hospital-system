namespace HospitalAppoinmentSystem
{
    partial class DoctorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnLogout = new Button();
            lblWelcome = new Label();
            picHospitalLogo = new PictureBox();
            tabMainControl = new TabControl();
            tabDashboard = new TabPage();
            pnlDashboard = new Panel();
            btnRefresh = new Button();
            gbTodayAppointments = new GroupBox();
            lblCancelledAppValue = new Label();
            lblCancelledAppTitle = new Label();
            lblActiveAppValue = new Label();
            lblActiveAppTitle = new Label();
            lblTodayAppValue = new Label();
            lblTodayAppTitle = new Label();
            lblTotalAppValue = new Label();
            lblTotalAppTitle = new Label();
            gbSummary = new GroupBox();
            dgvTodayAppointments = new DataGridView();
            tabAppointments = new TabPage();
            pnlInfo = new Panel();
            lblTotalRecords = new Label();
            tabAppointmentList = new TabControl();
            tabUpCOming = new TabPage();
            dgvUpComingAppointments = new DataGridView();
            colDate = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colPatientName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colDetail = new DataGridViewButtonColumn();
            tabPast = new TabPage();
            dgvPastAppointments = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewButtonColumn1 = new DataGridViewButtonColumn();
            pnlFilter = new Panel();
            btnClear = new Button();
            btnFilter = new Button();
            gbDateFilter = new GroupBox();
            gbViewOptions = new GroupBox();
            cmbViewType = new ComboBox();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblStartDate = new Label();
            tabProfile = new TabPage();
            pnlProfile = new Panel();
            pnlSeparator = new Panel();
            btnUpdate = new Button();
            gbPersonalInfo = new GroupBox();
            txtSurname = new TextBox();
            lblSurname = new Label();
            cmbSpecialty = new ComboBox();
            lblSpecialty = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtName = new TextBox();
            lblName = new Label();
            gbWorkingHours = new GroupBox();
            lblStartTime = new Label();
            cmbEndTime = new ComboBox();
            cmbStartTime = new ComboBox();
            lblEndTime = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHospitalLogo).BeginInit();
            tabMainControl.SuspendLayout();
            tabDashboard.SuspendLayout();
            pnlDashboard.SuspendLayout();
            gbTodayAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppointments).BeginInit();
            tabAppointments.SuspendLayout();
            pnlInfo.SuspendLayout();
            tabAppointmentList.SuspendLayout();
            tabUpCOming.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUpComingAppointments).BeginInit();
            tabPast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPastAppointments).BeginInit();
            pnlFilter.SuspendLayout();
            gbDateFilter.SuspendLayout();
            gbViewOptions.SuspendLayout();
            tabProfile.SuspendLayout();
            pnlProfile.SuspendLayout();
            gbPersonalInfo.SuspendLayout();
            gbWorkingHours.SuspendLayout();
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
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(818, 107);
            pnlHeader.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 82, 83);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(681, 35);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 40);
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
            lblWelcome.Location = new Point(144, 35);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Padding = new Padding(3, 4, 3, 4);
            lblWelcome.Size = new Size(413, 45);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "HOŞGELDİNİZ DR. [AD SOYAD]";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picHospitalLogo
            // 
            picHospitalLogo.BackColor = Color.Transparent;
            picHospitalLogo.Image = Properties.Resources.icons8_hospital_96;
            picHospitalLogo.Location = new Point(14, 0);
            picHospitalLogo.Margin = new Padding(3, 4, 3, 4);
            picHospitalLogo.Name = "picHospitalLogo";
            picHospitalLogo.Size = new Size(91, 107);
            picHospitalLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picHospitalLogo.TabIndex = 1;
            picHospitalLogo.TabStop = false;
            // 
            // tabMainControl
            // 
            tabMainControl.Appearance = TabAppearance.Buttons;
            tabMainControl.Controls.Add(tabDashboard);
            tabMainControl.Controls.Add(tabAppointments);
            tabMainControl.Controls.Add(tabProfile);
            tabMainControl.Dock = DockStyle.Fill;
            tabMainControl.Font = new Font("Segoe UI", 10F);
            tabMainControl.ItemSize = new Size(100, 30);
            tabMainControl.Location = new Point(0, 107);
            tabMainControl.Margin = new Padding(3, 4, 3, 4);
            tabMainControl.Name = "tabMainControl";
            tabMainControl.Padding = new Point(6, 6);
            tabMainControl.SelectedIndex = 0;
            tabMainControl.Size = new Size(818, 865);
            tabMainControl.SizeMode = TabSizeMode.Fixed;
            tabMainControl.TabIndex = 1;
            tabMainControl.SelectedIndexChanged += tabMainControl_SelectedIndexChanged;
            // 
            // tabDashboard
            // 
            tabDashboard.BackColor = Color.White;
            tabDashboard.Controls.Add(pnlDashboard);
            tabDashboard.Location = new Point(4, 34);
            tabDashboard.Margin = new Padding(3, 4, 3, 4);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(11, 13, 11, 13);
            tabDashboard.Size = new Size(810, 827);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Ana Sayfa";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlDashboard
            // 
            pnlDashboard.BackColor = Color.FromArgb(245, 247, 249);
            pnlDashboard.Controls.Add(btnRefresh);
            pnlDashboard.Controls.Add(gbTodayAppointments);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new Point(11, 13);
            pnlDashboard.Margin = new Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Padding = new Padding(23, 27, 23, 27);
            pnlDashboard.Size = new Size(788, 801);
            pnlDashboard.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImageLayout = ImageLayout.Zoom;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Location = new Point(731, 27);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(29, 39);
            btnRefresh.TabIndex = 1;
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // gbTodayAppointments
            // 
            gbTodayAppointments.Controls.Add(lblCancelledAppValue);
            gbTodayAppointments.Controls.Add(lblCancelledAppTitle);
            gbTodayAppointments.Controls.Add(lblActiveAppValue);
            gbTodayAppointments.Controls.Add(lblActiveAppTitle);
            gbTodayAppointments.Controls.Add(lblTodayAppValue);
            gbTodayAppointments.Controls.Add(lblTodayAppTitle);
            gbTodayAppointments.Controls.Add(lblTotalAppValue);
            gbTodayAppointments.Controls.Add(lblTotalAppTitle);
            gbTodayAppointments.Controls.Add(gbSummary);
            gbTodayAppointments.Controls.Add(dgvTodayAppointments);
            gbTodayAppointments.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbTodayAppointments.ForeColor = Color.FromArgb(45, 62, 80);
            gbTodayAppointments.Location = new Point(23, 27);
            gbTodayAppointments.Margin = new Padding(3, 4, 3, 4);
            gbTodayAppointments.Name = "gbTodayAppointments";
            gbTodayAppointments.Padding = new Padding(3, 4, 3, 4);
            gbTodayAppointments.Size = new Size(614, 712);
            gbTodayAppointments.TabIndex = 0;
            gbTodayAppointments.TabStop = false;
            gbTodayAppointments.Text = "Bugünün Randevuları";
            // 
            // lblCancelledAppValue
            // 
            lblCancelledAppValue.AutoSize = true;
            lblCancelledAppValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCancelledAppValue.ForeColor = Color.FromArgb(45, 62, 80);
            lblCancelledAppValue.Location = new Point(206, 213);
            lblCancelledAppValue.Name = "lblCancelledAppValue";
            lblCancelledAppValue.Size = new Size(32, 23);
            lblCancelledAppValue.TabIndex = 1;
            lblCancelledAppValue.Text = "[0]";
            // 
            // lblCancelledAppTitle
            // 
            lblCancelledAppTitle.AutoSize = true;
            lblCancelledAppTitle.Font = new Font("Segoe UI", 10F);
            lblCancelledAppTitle.ForeColor = SystemColors.WindowFrame;
            lblCancelledAppTitle.Location = new Point(23, 213);
            lblCancelledAppTitle.Name = "lblCancelledAppTitle";
            lblCancelledAppTitle.Size = new Size(189, 23);
            lblCancelledAppTitle.TabIndex = 1;
            lblCancelledAppTitle.Text = "İptal Edilen Randevular:";
            // 
            // lblActiveAppValue
            // 
            lblActiveAppValue.AutoSize = true;
            lblActiveAppValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActiveAppValue.ForeColor = Color.FromArgb(45, 62, 80);
            lblActiveAppValue.Location = new Point(206, 160);
            lblActiveAppValue.Name = "lblActiveAppValue";
            lblActiveAppValue.Size = new Size(32, 23);
            lblActiveAppValue.TabIndex = 1;
            lblActiveAppValue.Text = "[0]";
            // 
            // lblActiveAppTitle
            // 
            lblActiveAppTitle.AutoSize = true;
            lblActiveAppTitle.Font = new Font("Segoe UI", 10F);
            lblActiveAppTitle.ForeColor = SystemColors.WindowFrame;
            lblActiveAppTitle.Location = new Point(23, 160);
            lblActiveAppTitle.Name = "lblActiveAppTitle";
            lblActiveAppTitle.Size = new Size(138, 23);
            lblActiveAppTitle.TabIndex = 5;
            lblActiveAppTitle.Text = "Aktif Randevular:";
            // 
            // lblTodayAppValue
            // 
            lblTodayAppValue.AutoSize = true;
            lblTodayAppValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTodayAppValue.Location = new Point(206, 107);
            lblTodayAppValue.Name = "lblTodayAppValue";
            lblTodayAppValue.Size = new Size(32, 23);
            lblTodayAppValue.TabIndex = 4;
            lblTodayAppValue.Text = "[0]";
            // 
            // lblTodayAppTitle
            // 
            lblTodayAppTitle.AutoSize = true;
            lblTodayAppTitle.Font = new Font("Segoe UI", 10F);
            lblTodayAppTitle.ForeColor = SystemColors.WindowFrame;
            lblTodayAppTitle.Location = new Point(23, 107);
            lblTodayAppTitle.Name = "lblTodayAppTitle";
            lblTodayAppTitle.Size = new Size(172, 23);
            lblTodayAppTitle.TabIndex = 3;
            lblTodayAppTitle.Text = "Bugünkü Randevular:";
            // 
            // lblTotalAppValue
            // 
            lblTotalAppValue.AutoSize = true;
            lblTotalAppValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalAppValue.Location = new Point(206, 49);
            lblTotalAppValue.Name = "lblTotalAppValue";
            lblTotalAppValue.Size = new Size(32, 23);
            lblTotalAppValue.TabIndex = 2;
            lblTotalAppValue.Text = "[0]";
            // 
            // lblTotalAppTitle
            // 
            lblTotalAppTitle.AutoSize = true;
            lblTotalAppTitle.Font = new Font("Segoe UI", 10F);
            lblTotalAppTitle.ForeColor = SystemColors.WindowFrame;
            lblTotalAppTitle.Location = new Point(23, 49);
            lblTotalAppTitle.Name = "lblTotalAppTitle";
            lblTotalAppTitle.Size = new Size(140, 23);
            lblTotalAppTitle.TabIndex = 1;
            lblTotalAppTitle.Text = "Toplam Randevu:";
            // 
            // gbSummary
            // 
            gbSummary.BackColor = Color.AliceBlue;
            gbSummary.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbSummary.Location = new Point(731, 27);
            gbSummary.Margin = new Padding(3, 4, 3, 4);
            gbSummary.Name = "gbSummary";
            gbSummary.Padding = new Padding(3, 4, 3, 4);
            gbSummary.Size = new Size(343, 333);
            gbSummary.TabIndex = 1;
            gbSummary.TabStop = false;
            gbSummary.Text = "Özet Bilgiler";
            // 
            // dgvTodayAppointments
            // 
            dgvTodayAppointments.AllowUserToAddRows = false;
            dgvTodayAppointments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 247, 249);
            dgvTodayAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTodayAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodayAppointments.BackgroundColor = Color.White;
            dgvTodayAppointments.BorderStyle = BorderStyle.None;
            dgvTodayAppointments.ColumnHeadersHeight = 30;
            dgvTodayAppointments.Dock = DockStyle.Fill;
            dgvTodayAppointments.Location = new Point(3, 29);
            dgvTodayAppointments.Margin = new Padding(3, 4, 3, 4);
            dgvTodayAppointments.MultiSelect = false;
            dgvTodayAppointments.Name = "dgvTodayAppointments";
            dgvTodayAppointments.ReadOnly = true;
            dgvTodayAppointments.RowHeadersVisible = false;
            dgvTodayAppointments.RowHeadersWidth = 51;
            dgvTodayAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTodayAppointments.Size = new Size(608, 679);
            dgvTodayAppointments.TabIndex = 0;
            // 
            // tabAppointments
            // 
            tabAppointments.BackColor = Color.White;
            tabAppointments.Controls.Add(pnlInfo);
            tabAppointments.Controls.Add(tabAppointmentList);
            tabAppointments.Controls.Add(pnlFilter);
            tabAppointments.Location = new Point(4, 34);
            tabAppointments.Margin = new Padding(3, 4, 3, 4);
            tabAppointments.Name = "tabAppointments";
            tabAppointments.Padding = new Padding(11, 13, 11, 13);
            tabAppointments.Size = new Size(810, 827);
            tabAppointments.TabIndex = 1;
            tabAppointments.Text = "Randevularım";
            tabAppointments.UseVisualStyleBackColor = true;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(245, 247, 249);
            pnlInfo.Controls.Add(lblTotalRecords);
            pnlInfo.Dock = DockStyle.Bottom;
            pnlInfo.Location = new Point(11, 761);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Padding = new Padding(11, 0, 11, 0);
            pnlInfo.Size = new Size(788, 53);
            pnlInfo.TabIndex = 1;
            // 
            // lblTotalRecords
            // 
            lblTotalRecords.AutoSize = true;
            lblTotalRecords.Font = new Font("Segoe UI", 9F);
            lblTotalRecords.ForeColor = Color.FromArgb(45, 62, 80);
            lblTotalRecords.Location = new Point(306, 15);
            lblTotalRecords.Name = "lblTotalRecords";
            lblTotalRecords.Size = new Size(111, 20);
            lblTotalRecords.TabIndex = 1;
            lblTotalRecords.Text = "Toplam Kayıt: 0";
            lblTotalRecords.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabAppointmentList
            // 
            tabAppointmentList.Appearance = TabAppearance.FlatButtons;
            tabAppointmentList.Controls.Add(tabUpCOming);
            tabAppointmentList.Controls.Add(tabPast);
            tabAppointmentList.Dock = DockStyle.Fill;
            tabAppointmentList.ItemSize = new Size(200, 30);
            tabAppointmentList.Location = new Point(11, 156);
            tabAppointmentList.Margin = new Padding(3, 4, 3, 4);
            tabAppointmentList.Name = "tabAppointmentList";
            tabAppointmentList.Padding = new Point(8, 2);
            tabAppointmentList.SelectedIndex = 0;
            tabAppointmentList.Size = new Size(788, 658);
            tabAppointmentList.SizeMode = TabSizeMode.Fixed;
            tabAppointmentList.TabIndex = 0;
            // 
            // tabUpCOming
            // 
            tabUpCOming.BackColor = Color.White;
            tabUpCOming.Controls.Add(dgvUpComingAppointments);
            tabUpCOming.Location = new Point(4, 34);
            tabUpCOming.Margin = new Padding(0);
            tabUpCOming.Name = "tabUpCOming";
            tabUpCOming.Padding = new Padding(11, 13, 11, 13);
            tabUpCOming.Size = new Size(780, 620);
            tabUpCOming.TabIndex = 0;
            tabUpCOming.Text = "Gelecek Randevular";
            tabUpCOming.UseVisualStyleBackColor = true;
            // 
            // dgvUpComingAppointments
            // 
            dgvUpComingAppointments.AllowUserToAddRows = false;
            dgvUpComingAppointments.AllowUserToDeleteRows = false;
            dgvUpComingAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(245, 247, 249);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUpComingAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUpComingAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUpComingAppointments.BackgroundColor = Color.White;
            dgvUpComingAppointments.BorderStyle = BorderStyle.None;
            dgvUpComingAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUpComingAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUpComingAppointments.ColumnHeadersHeight = 40;
            dgvUpComingAppointments.Columns.AddRange(new DataGridViewColumn[] { colDate, colTime, colPatientName, colPhone, colStatus, colDetail });
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle10.Padding = new Padding(5);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvUpComingAppointments.DefaultCellStyle = dataGridViewCellStyle10;
            dgvUpComingAppointments.Dock = DockStyle.Fill;
            dgvUpComingAppointments.EnableHeadersVisualStyles = false;
            dgvUpComingAppointments.GridColor = Color.FromArgb(45, 62, 80);
            dgvUpComingAppointments.Location = new Point(11, 13);
            dgvUpComingAppointments.Margin = new Padding(0);
            dgvUpComingAppointments.MultiSelect = false;
            dgvUpComingAppointments.Name = "dgvUpComingAppointments";
            dgvUpComingAppointments.ReadOnly = true;
            dgvUpComingAppointments.RowHeadersVisible = false;
            dgvUpComingAppointments.RowHeadersWidth = 51;
            dgvUpComingAppointments.RowTemplate.Height = 35;
            dgvUpComingAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUpComingAppointments.Size = new Size(758, 594);
            dgvUpComingAppointments.TabIndex = 0;
            // 
            // colDate
            // 
            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle4.Format = "dd.MM.yyyy";
            dataGridViewCellStyle4.Padding = new Padding(2);
            colDate.DefaultCellStyle = dataGridViewCellStyle4;
            colDate.HeaderText = "Tarih";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Resizable = DataGridViewTriState.False;
            colDate.Width = 120;
            // 
            // colTime
            // 
            colTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle5.Format = "HH:mm";
            dataGridViewCellStyle5.Padding = new Padding(2);
            colTime.DefaultCellStyle = dataGridViewCellStyle5;
            colTime.HeaderText = "Saat";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.Resizable = DataGridViewTriState.False;
            colTime.Width = 125;
            // 
            // colPatientName
            // 
            colPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle6.Padding = new Padding(10, 0, 0, 0);
            colPatientName.DefaultCellStyle = dataGridViewCellStyle6;
            colPatientName.HeaderText = "Hasta Adı";
            colPatientName.MinimumWidth = 6;
            colPatientName.Name = "colPatientName";
            colPatientName.ReadOnly = true;
            colPatientName.Resizable = DataGridViewTriState.False;
            colPatientName.Width = 170;
            // 
            // colPhone
            // 
            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            colPhone.DefaultCellStyle = dataGridViewCellStyle7;
            colPhone.HeaderText = "Telefon";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Resizable = DataGridViewTriState.False;
            colPhone.Width = 150;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            colStatus.DefaultCellStyle = dataGridViewCellStyle8;
            colStatus.HeaderText = "Durum";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.Resizable = DataGridViewTriState.False;
            colStatus.Width = 120;
            // 
            // colDetail
            // 
            colDetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.Padding = new Padding(2);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            colDetail.DefaultCellStyle = dataGridViewCellStyle9;
            colDetail.FlatStyle = FlatStyle.Flat;
            colDetail.HeaderText = "Detay";
            colDetail.MinimumWidth = 6;
            colDetail.Name = "colDetail";
            colDetail.ReadOnly = true;
            colDetail.Resizable = DataGridViewTriState.False;
            colDetail.SortMode = DataGridViewColumnSortMode.Automatic;
            colDetail.Text = "Görüntüle";
            colDetail.UseColumnTextForButtonValue = true;
            colDetail.Width = 125;
            // 
            // tabPast
            // 
            tabPast.BackColor = Color.White;
            tabPast.Controls.Add(dgvPastAppointments);
            tabPast.Location = new Point(4, 34);
            tabPast.Margin = new Padding(0);
            tabPast.Name = "tabPast";
            tabPast.Padding = new Padding(11, 13, 11, 13);
            tabPast.Size = new Size(778, 607);
            tabPast.TabIndex = 1;
            tabPast.Text = "Geçmiş Randevular";
            tabPast.UseVisualStyleBackColor = true;
            // 
            // dgvPastAppointments
            // 
            dgvPastAppointments.AllowUserToAddRows = false;
            dgvPastAppointments.AllowUserToDeleteRows = false;
            dgvPastAppointments.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(245, 247, 249);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle11.Padding = new Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvPastAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgvPastAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPastAppointments.BackgroundColor = Color.White;
            dgvPastAppointments.BorderStyle = BorderStyle.None;
            dgvPastAppointments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle12.Padding = new Padding(5);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvPastAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgvPastAppointments.ColumnHeadersHeight = 40;
            dgvPastAppointments.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewButtonColumn1 });
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle19.ForeColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle19.Padding = new Padding(5);
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(45, 62, 80);
            dataGridViewCellStyle19.SelectionForeColor = Color.White;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            dgvPastAppointments.DefaultCellStyle = dataGridViewCellStyle19;
            dgvPastAppointments.Dock = DockStyle.Fill;
            dgvPastAppointments.EnableHeadersVisualStyles = false;
            dgvPastAppointments.GridColor = Color.FromArgb(45, 62, 80);
            dgvPastAppointments.Location = new Point(11, 13);
            dgvPastAppointments.Margin = new Padding(0);
            dgvPastAppointments.MultiSelect = false;
            dgvPastAppointments.Name = "dgvPastAppointments";
            dgvPastAppointments.ReadOnly = true;
            dgvPastAppointments.RowHeadersVisible = false;
            dgvPastAppointments.RowHeadersWidth = 51;
            dgvPastAppointments.RowTemplate.Height = 35;
            dgvPastAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPastAppointments.Size = new Size(756, 581);
            dgvPastAppointments.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle13.Format = "dd.MM.yyyy";
            dataGridViewCellStyle13.Padding = new Padding(2);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewTextBoxColumn1.HeaderText = "Tarih";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle14.Format = "HH:mm";
            dataGridViewCellStyle14.Padding = new Padding(2);
            dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewTextBoxColumn2.HeaderText = "Saat";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle15.Padding = new Padding(10, 0, 0, 0);
            dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewTextBoxColumn3.HeaderText = "Hasta Adı";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 175;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle16;
            dataGridViewTextBoxColumn4.HeaderText = "Telefon";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewTextBoxColumn5.HeaderText = "Durum";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewButtonColumn1
            // 
            dataGridViewButtonColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle18.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.Padding = new Padding(2);
            dataGridViewCellStyle18.SelectionBackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            dataGridViewButtonColumn1.DefaultCellStyle = dataGridViewCellStyle18;
            dataGridViewButtonColumn1.FlatStyle = FlatStyle.Flat;
            dataGridViewButtonColumn1.HeaderText = "Detay";
            dataGridViewButtonColumn1.MinimumWidth = 6;
            dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            dataGridViewButtonColumn1.ReadOnly = true;
            dataGridViewButtonColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewButtonColumn1.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewButtonColumn1.Text = "Görüntüle";
            dataGridViewButtonColumn1.UseColumnTextForButtonValue = true;
            dataGridViewButtonColumn1.Width = 125;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(245, 247, 249);
            pnlFilter.Controls.Add(btnClear);
            pnlFilter.Controls.Add(btnFilter);
            pnlFilter.Controls.Add(gbDateFilter);
            pnlFilter.Dock = DockStyle.Top;
            pnlFilter.Location = new Point(11, 13);
            pnlFilter.Margin = new Padding(0);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Padding = new Padding(17, 20, 17, 20);
            pnlFilter.Size = new Size(788, 143);
            pnlFilter.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(231, 76, 60);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(231, 76, 60);
            btnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 57, 43);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(651, 20);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 47);
            btnClear.TabIndex = 1;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(39, 174, 96);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(651, 81);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(97, 47);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // gbDateFilter
            // 
            gbDateFilter.BackColor = Color.White;
            gbDateFilter.Controls.Add(gbViewOptions);
            gbDateFilter.Controls.Add(dtpEndDate);
            gbDateFilter.Controls.Add(lblEndDate);
            gbDateFilter.Controls.Add(dtpStartDate);
            gbDateFilter.Controls.Add(lblStartDate);
            gbDateFilter.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbDateFilter.ForeColor = Color.FromArgb(45, 62, 80);
            gbDateFilter.Location = new Point(3, 4);
            gbDateFilter.Margin = new Padding(3, 4, 3, 4);
            gbDateFilter.Name = "gbDateFilter";
            gbDateFilter.Padding = new Padding(11, 13, 11, 13);
            gbDateFilter.Size = new Size(526, 133);
            gbDateFilter.TabIndex = 1;
            gbDateFilter.TabStop = false;
            gbDateFilter.Text = "Tarih Aralığı Seçin";
            // 
            // gbViewOptions
            // 
            gbViewOptions.Controls.Add(cmbViewType);
            gbViewOptions.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbViewOptions.Location = new Point(334, 0);
            gbViewOptions.Margin = new Padding(3, 4, 3, 4);
            gbViewOptions.Name = "gbViewOptions";
            gbViewOptions.Padding = new Padding(11, 13, 11, 13);
            gbViewOptions.Size = new Size(229, 80);
            gbViewOptions.TabIndex = 1;
            gbViewOptions.TabStop = false;
            gbViewOptions.Text = "Görünüm";
            // 
            // cmbViewType
            // 
            cmbViewType.BackColor = Color.Silver;
            cmbViewType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbViewType.FlatStyle = FlatStyle.Flat;
            cmbViewType.Font = new Font("Segoe UI", 9F);
            cmbViewType.ForeColor = Color.FromArgb(45, 62, 80);
            cmbViewType.FormattingEnabled = true;
            cmbViewType.Items.AddRange(new object[] { "Günlük", "Haftalık", "Aylık" });
            cmbViewType.Location = new Point(0, 37);
            cmbViewType.Margin = new Padding(3, 4, 3, 4);
            cmbViewType.Name = "cmbViewType";
            cmbViewType.Size = new Size(198, 28);
            cmbViewType.TabIndex = 1;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CalendarForeColor = Color.FromArgb(45, 62, 80);
            dtpEndDate.CalendarMonthBackground = Color.White;
            dtpEndDate.CustomFormat = "dd.MM.yyyy";
            dtpEndDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(99, 93);
            dtpEndDate.Margin = new Padding(3, 4, 3, 4);
            dtpEndDate.MaxDate = new DateTime(2025, 4, 18, 0, 0, 0, 0);
            dtpEndDate.MinDate = new DateTime(2025, 1, 18, 0, 0, 0, 0);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(171, 27);
            dtpEndDate.TabIndex = 1;
            dtpEndDate.Value = new DateTime(2025, 1, 18, 0, 0, 0, 0);
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.ForeColor = Color.FromArgb(45, 62, 80);
            lblEndDate.Location = new Point(15, 93);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(46, 23);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "Bİtiş:";
            lblEndDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CalendarForeColor = Color.FromArgb(45, 62, 80);
            dtpStartDate.CalendarMonthBackground = Color.White;
            dtpStartDate.CustomFormat = "dd.MM.yyyy";
            dtpStartDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(99, 37);
            dtpStartDate.Margin = new Padding(3, 4, 3, 4);
            dtpStartDate.MaxDate = new DateTime(2025, 4, 18, 0, 0, 0, 0);
            dtpStartDate.MinDate = new DateTime(2025, 1, 18, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(171, 27);
            dtpStartDate.TabIndex = 1;
            dtpStartDate.Value = new DateTime(2025, 1, 18, 0, 0, 0, 0);
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.Location = new Point(15, 37);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(85, 23);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Başlangıç:";
            lblStartDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabProfile
            // 
            tabProfile.BackColor = Color.White;
            tabProfile.Controls.Add(pnlProfile);
            tabProfile.Location = new Point(4, 34);
            tabProfile.Margin = new Padding(3, 4, 3, 4);
            tabProfile.Name = "tabProfile";
            tabProfile.Padding = new Padding(11, 13, 11, 13);
            tabProfile.Size = new Size(810, 827);
            tabProfile.TabIndex = 2;
            tabProfile.Text = "Profilim";
            tabProfile.UseVisualStyleBackColor = true;
            // 
            // pnlProfile
            // 
            pnlProfile.BackColor = Color.FromArgb(245, 247, 249);
            pnlProfile.Controls.Add(pnlSeparator);
            pnlProfile.Controls.Add(btnUpdate);
            pnlProfile.Controls.Add(gbPersonalInfo);
            pnlProfile.Controls.Add(gbWorkingHours);
            pnlProfile.Dock = DockStyle.Fill;
            pnlProfile.Location = new Point(11, 13);
            pnlProfile.Margin = new Padding(3, 4, 3, 4);
            pnlProfile.Name = "pnlProfile";
            pnlProfile.Size = new Size(788, 801);
            pnlProfile.TabIndex = 0;
            // 
            // pnlSeparator
            // 
            pnlSeparator.BackColor = Color.FromArgb(45, 62, 80);
            pnlSeparator.Location = new Point(0, 451);
            pnlSeparator.Margin = new Padding(3, 4, 3, 4);
            pnlSeparator.Name = "pnlSeparator";
            pnlSeparator.Size = new Size(766, 3);
            pnlSeparator.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(39, 174, 96);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(541, 665);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(229, 47);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Bilgileri Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // gbPersonalInfo
            // 
            gbPersonalInfo.BackColor = Color.White;
            gbPersonalInfo.Controls.Add(txtSurname);
            gbPersonalInfo.Controls.Add(lblSurname);
            gbPersonalInfo.Controls.Add(cmbSpecialty);
            gbPersonalInfo.Controls.Add(lblSpecialty);
            gbPersonalInfo.Controls.Add(txtEmail);
            gbPersonalInfo.Controls.Add(lblEmail);
            gbPersonalInfo.Controls.Add(txtName);
            gbPersonalInfo.Controls.Add(lblName);
            gbPersonalInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbPersonalInfo.ForeColor = Color.FromArgb(45, 62, 80);
            gbPersonalInfo.Location = new Point(23, 27);
            gbPersonalInfo.Margin = new Padding(3, 4, 3, 4);
            gbPersonalInfo.Name = "gbPersonalInfo";
            gbPersonalInfo.Padding = new Padding(3, 4, 3, 4);
            gbPersonalInfo.Size = new Size(514, 427);
            gbPersonalInfo.TabIndex = 0;
            gbPersonalInfo.TabStop = false;
            gbPersonalInfo.Text = "Kişisel Bilgiler";
            // 
            // txtSurname
            // 
            txtSurname.BorderStyle = BorderStyle.FixedSingle;
            txtSurname.Location = new Point(23, 177);
            txtSurname.Margin = new Padding(3, 4, 3, 4);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(361, 32);
            txtSurname.TabIndex = 7;
            // 
            // lblSurname
            // 
            lblSurname.Font = new Font("Segoe UI", 10F);
            lblSurname.Location = new Point(23, 143);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(98, 31);
            lblSurname.TabIndex = 6;
            lblSurname.Text = "Soyad:";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Items.AddRange(new object[] { "Dahiliye", "Kardiyoloji", "Nöroloji", "Ortopedi", "Göz Hastalıkları", "Kulak Burun Boğaz", "Genel Cerrahi" });
            cmbSpecialty.Location = new Point(23, 357);
            cmbSpecialty.Margin = new Padding(3, 4, 3, 4);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(361, 33);
            cmbSpecialty.TabIndex = 5;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Font = new Font("Segoe UI", 10F);
            lblSpecialty.Location = new Point(23, 309);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(127, 23);
            lblSpecialty.TabIndex = 4;
            lblSpecialty.Text = "Uzmanlık Alanı:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(23, 255);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(361, 32);
            txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.Location = new Point(23, 225);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(72, 23);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-posta:";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(23, 88);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(361, 32);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI", 10F);
            lblName.Location = new Point(23, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 31);
            lblName.TabIndex = 0;
            lblName.Text = "Ad:";
            // 
            // gbWorkingHours
            // 
            gbWorkingHours.BackColor = Color.White;
            gbWorkingHours.Controls.Add(lblStartTime);
            gbWorkingHours.Controls.Add(cmbEndTime);
            gbWorkingHours.Controls.Add(cmbStartTime);
            gbWorkingHours.Controls.Add(lblEndTime);
            gbWorkingHours.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            gbWorkingHours.ForeColor = Color.FromArgb(45, 62, 80);
            gbWorkingHours.Location = new Point(23, 547);
            gbWorkingHours.Margin = new Padding(3, 4, 3, 4);
            gbWorkingHours.Name = "gbWorkingHours";
            gbWorkingHours.Padding = new Padding(3, 4, 3, 4);
            gbWorkingHours.Size = new Size(461, 204);
            gbWorkingHours.TabIndex = 6;
            gbWorkingHours.TabStop = false;
            gbWorkingHours.Text = "Çalışma Saatleri";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Font = new Font("Segoe UI", 10F);
            lblStartTime.Location = new Point(23, 53);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(127, 23);
            lblStartTime.TabIndex = 7;
            lblStartTime.Text = "Başlangıç Saati:";
            // 
            // cmbEndTime
            // 
            cmbEndTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEndTime.FormattingEnabled = true;
            cmbEndTime.Items.AddRange(new object[] { "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30" });
            cmbEndTime.Location = new Point(272, 87);
            cmbEndTime.Margin = new Padding(3, 4, 3, 4);
            cmbEndTime.Name = "cmbEndTime";
            cmbEndTime.Size = new Size(137, 33);
            cmbEndTime.TabIndex = 10;
            // 
            // cmbStartTime
            // 
            cmbStartTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStartTime.FormattingEnabled = true;
            cmbStartTime.Items.AddRange(new object[] { "08:00", "08:30", "09:00", "09:30", "10:00", "10:30", "11:00", "11:30" });
            cmbStartTime.Location = new Point(23, 87);
            cmbStartTime.Margin = new Padding(3, 4, 3, 4);
            cmbStartTime.Name = "cmbStartTime";
            cmbStartTime.Size = new Size(137, 33);
            cmbStartTime.TabIndex = 8;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Font = new Font("Segoe UI", 10F);
            lblEndTime.Location = new Point(272, 53);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(87, 23);
            lblEndTime.TabIndex = 9;
            lblEndTime.Text = "Bitiş Saati:";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 972);
            Controls.Add(tabMainControl);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Randevu Sistemi - Doktor Paneli";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHospitalLogo).EndInit();
            tabMainControl.ResumeLayout(false);
            tabDashboard.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            gbTodayAppointments.ResumeLayout(false);
            gbTodayAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTodayAppointments).EndInit();
            tabAppointments.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            tabAppointmentList.ResumeLayout(false);
            tabUpCOming.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUpComingAppointments).EndInit();
            tabPast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPastAppointments).EndInit();
            pnlFilter.ResumeLayout(false);
            gbDateFilter.ResumeLayout(false);
            gbDateFilter.PerformLayout();
            gbViewOptions.ResumeLayout(false);
            tabProfile.ResumeLayout(false);
            pnlProfile.ResumeLayout(false);
            gbPersonalInfo.ResumeLayout(false);
            gbPersonalInfo.PerformLayout();
            gbWorkingHours.ResumeLayout(false);
            gbWorkingHours.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox picHospitalLogo;
        private Label lblWelcome;
        private Button btnLogout;
        private TabControl tabMainControl;
        private TabPage tabDashboard;
        private TabPage tabAppointments;
        private TabPage tabProfile;
        private Panel pnlDashboard;
        private GroupBox gbTodayAppointments;
        private DataGridView dgvTodayAppointments;
        private Label lblTotalAppTitle;
        private GroupBox gbSummary;
        private Label lblTotalAppValue;
        private Label lblActiveAppTitle;
        private Label lblTodayAppValue;
        private Label lblTodayAppTitle;
        private Label lblCancelledAppValue;
        private Label lblCancelledAppTitle;
        private Label lblActiveAppValue;
        private GroupBox gbDateFilter;
        private Panel pnlFilter;
        private DateTimePicker dtpStartDate;
        private Label lblStartDate;
        private Label lblEndDate;
        private DateTimePicker dtpEndDate;
        private GroupBox gbViewOptions;
        private ComboBox cmbViewType;
        private Button btnFilter;
        private Button btnClear;
        private TabControl tabAppointmentList;
        private TabPage tabUpCOming;
        private TabPage tabPast;
        private DataGridView dgvUpComingAppointments;
        private Panel pnlInfo;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colPatientName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewButtonColumn colDetail;
        private DataGridView dgvPastAppointments;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewButtonColumn dataGridViewButtonColumn1;
        private Label lblTotalRecords;
        private Panel pnlProfile;
        private GroupBox gbPersonalInfo;
        private Label lblName;
        private GroupBox gbWorkingHours;
        private ComboBox cmbSpecialty;
        private Label lblSpecialty;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtName;
        private Panel pnlSeparator;
        private Button btnUpdate;
        private ComboBox cmbEndTime;
        private Label lblEndTime;
        private ComboBox cmbStartTime;
        private Label lblStartTime;
        private Button btnRefresh;
        private TextBox txtSurname;
        private Label lblSurname;
    }
}