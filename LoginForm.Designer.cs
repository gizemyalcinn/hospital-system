namespace HospitalAppoinmentSystem
{
    partial class LoginForm : Form
    {

        private void InitializeComponent()
        {
            panelTop = new Panel();
            pictureLogo = new PictureBox();
            lblTitle = new Label();
            lblEmail = new Label();
            girisBaslik = new Label();
            maskedTxtEmail = new MaskedTextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            linkForgotPassword = new LinkLabel();
            linkRegister = new LinkLabel();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 62, 80);
            panelTop.Controls.Add(pictureLogo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(384, 100);
            panelTop.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.icons8_hospital_96;
            pictureLogo.Location = new Point(12, 12);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(80, 80);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.FromArgb(45, 62, 80);
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.WhiteSmoke;
            lblTitle.Location = new Point(120, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 80);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "HASTANE RANDEVU SİSTEMİ";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(45, 62, 80);
            lblEmail.Location = new Point(35, 186);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(84, 33);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "E-posta:";
            // 
            // girisBaslik
            // 
            girisBaslik.AutoSize = true;
            girisBaslik.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            girisBaslik.ForeColor = Color.FromArgb(45, 62, 80);
            girisBaslik.Location = new Point(120, 125);
            girisBaslik.Name = "girisBaslik";
            girisBaslik.Size = new Size(143, 28);
            girisBaslik.TabIndex = 4;
            girisBaslik.Text = "HOŞGELDİNİZ";
            // 
            // maskedTxtEmail
            // 
            maskedTxtEmail.Font = new Font("Segoe UI", 13F);
            maskedTxtEmail.Location = new Point(143, 186);
            maskedTxtEmail.Name = "maskedTxtEmail";
            maskedTxtEmail.Size = new Size(212, 31);
            maskedTxtEmail.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(45, 62, 80);
            lblPassword.Location = new Point(35, 256);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(56, 25);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(143, 256);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(212, 28);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(39, 174, 96);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(44, 307);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 35);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(143, 359);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(95, 15);
            linkForgotPassword.TabIndex = 9;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Şifremi Unuttum";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(117, 388);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(146, 15);
            linkRegister.TabIndex = 10;
            linkRegister.TabStop = true;
            linkRegister.Text = "Hesabınız yoksa kayıt olun";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // LoginForm
            // 
            ClientSize = new Size(384, 461);
            Controls.Add(linkRegister);
            Controls.Add(linkForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(maskedTxtEmail);
            Controls.Add(girisBaslik);
            Controls.Add(lblEmail);
            Controls.Add(lblTitle);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hastane Randevı Sistemi - Giriş Sayfası";
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panelTop;
        private PictureBox pictureLogo;
        private Label lblTitle;
        private Label lblEmail;
        private Label girisBaslik;
        private MaskedTextBox maskedTxtEmail;
        private System.ComponentModel.IContainer components;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkRegister;
    }
}
