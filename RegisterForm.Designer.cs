namespace HospitalAppoinmentSystem
{
    partial class RegisterForm
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
            pnlTop = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblSurname = new Label();
            txtSurname = new TextBox();
            lblEposta = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            lblPasswordConfirm = new Label();
            txtPasswordConfirm = new TextBox();
            btnRegister = new Button();
            lblhesapSorgu = new Label();
            lnkBackLogin = new LinkLabel();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(45, 62, 80);
            pnlTop.Controls.Add(pictureBox1);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(384, 100);
            pnlTop.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_hospital_96;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 85);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.ImageAlign = ContentAlignment.MiddleRight;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(384, 100);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "KAYIT OL";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblName.ForeColor = Color.FromArgb(45, 62, 80);
            lblName.Location = new Point(12, 112);
            lblName.Name = "lblName";
            lblName.Size = new Size(33, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Ad";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top;
            txtName.BackColor = Color.White;
            txtName.BorderStyle = BorderStyle.None;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(12, 136);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 23);
            txtName.TabIndex = 2;
            // 
            // lblSurname
            // 
            lblSurname.Anchor = AnchorStyles.Top;
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblSurname.ForeColor = Color.FromArgb(45, 62, 80);
            lblSurname.Location = new Point(12, 182);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(59, 23);
            lblSurname.TabIndex = 3;
            lblSurname.Text = "Soyad";
            // 
            // txtSurname
            // 
            txtSurname.Anchor = AnchorStyles.Top;
            txtSurname.BackColor = Color.White;
            txtSurname.BorderStyle = BorderStyle.None;
            txtSurname.Font = new Font("Segoe UI", 10F);
            txtSurname.Location = new Point(12, 206);
            txtSurname.Multiline = true;
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(360, 23);
            txtSurname.TabIndex = 4;
            // 
            // lblEposta
            // 
            lblEposta.Anchor = AnchorStyles.Top;
            lblEposta.AutoSize = true;
            lblEposta.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblEposta.ForeColor = Color.FromArgb(45, 62, 80);
            lblEposta.Location = new Point(12, 252);
            lblEposta.Name = "lblEposta";
            lblEposta.Size = new Size(76, 25);
            lblEposta.TabIndex = 5;
            lblEposta.Text = "E-posta";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top;
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 62, 80);
            lblPassword.Location = new Point(12, 322);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(51, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Şifre";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top;
            txtEmail.BackColor = Color.White;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(12, 276);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.Location = new Point(12, 346);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(360, 23);
            txtPassword.TabIndex = 8;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.Anchor = AnchorStyles.Top;
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPasswordConfirm.ForeColor = Color.FromArgb(45, 62, 80);
            lblPasswordConfirm.Location = new Point(12, 392);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(109, 25);
            lblPasswordConfirm.TabIndex = 9;
            lblPasswordConfirm.Text = "Şifre Tekrar";
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Anchor = AnchorStyles.Top;
            txtPasswordConfirm.BackColor = Color.White;
            txtPasswordConfirm.BorderStyle = BorderStyle.None;
            txtPasswordConfirm.Font = new Font("Segoe UI", 10F);
            txtPasswordConfirm.Location = new Point(12, 416);
            txtPasswordConfirm.Multiline = true;
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.PasswordChar = '*';
            txtPasswordConfirm.Size = new Size(360, 23);
            txtPasswordConfirm.TabIndex = 10;
            txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.AutoEllipsis = true;
            btnRegister.BackColor = Color.FromArgb(39, 174, 96);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(55, 457);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(258, 37);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblhesapSorgu
            // 
            lblhesapSorgu.AutoSize = true;
            lblhesapSorgu.ForeColor = Color.FromArgb(45, 62, 80);
            lblhesapSorgu.Location = new Point(55, 518);
            lblhesapSorgu.Name = "lblhesapSorgu";
            lblhesapSorgu.Size = new Size(116, 15);
            lblhesapSorgu.TabIndex = 12;
            lblhesapSorgu.Text = "Zaten kayıtlı mısınız?";
            // 
            // lnkBackLogin
            // 
            lnkBackLogin.ActiveLinkColor = Color.LightSkyBlue;
            lnkBackLogin.AutoSize = true;
            lnkBackLogin.Cursor = Cursors.Hand;
            lnkBackLogin.Location = new Point(177, 518);
            lnkBackLogin.Name = "lnkBackLogin";
            lnkBackLogin.Size = new Size(105, 15);
            lnkBackLogin.TabIndex = 13;
            lnkBackLogin.TabStop = true;
            lnkBackLogin.Text = "Giriş sayfasına dön";
            lnkBackLogin.LinkClicked += lnkBackLogin_LinkClicked;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 561);
            Controls.Add(lnkBackLogin);
            Controls.Add(lblhesapSorgu);
            Controls.Add(btnRegister);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEposta);
            Controls.Add(txtSurname);
            Controls.Add(lblSurname);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HASTANE RANDEVU SİSTEMİ - Kayıt Sayfası";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblTitle;
        private PictureBox pictureBox1;
        private Label lblName;
        private TextBox txtName;
        private Label lblSurname;
        private TextBox txtSurname;
        private Label lblEposta;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label lblPasswordConfirm;
        private TextBox txtPasswordConfirm;
        private Button btnRegister;
        private Label lblhesapSorgu;
        private LinkLabel lnkBackLogin;
    }
}