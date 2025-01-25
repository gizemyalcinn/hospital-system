using HospitalAppoinmentSystem.Data;
using HospitalAppoinmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppoinmentSystem
{
    public partial class LoginForm : Form
    {
        private HospitalDbContext _dbContext;
        public LoginForm(HospitalDbContext dbContext)
        {
            this._dbContext = dbContext;
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            var patient = _dbContext.Patients.FirstOrDefault(p => p.Email == maskedTxtEmail.Text);
            if (patient != null && patient.Password == txtPassword.Text)
            {
                MessageBox.Show("Login Successful");
                PatientForm patientForm = new PatientForm(patient, _dbContext, this);
                patientForm.Show();
                this.Hide();
            }

            var doctor = _dbContext.Doctors
                .FirstOrDefault(d => d.Email == maskedTxtEmail.Text && d.Password == txtPassword.Text);

            if (doctor != null)
            {
                var doctorForm = new DoctorForm(doctor, _dbContext, this); 
                this.Hide();
                doctorForm.ShowDialog();
                this.Close();
                return;
            }

            if(maskedTxtEmail.Text == "admin" && txtPassword.Text == "admin")
            {
                ManagerForm adminForm = new ManagerForm(_dbContext, this);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(_dbContext, this);
            registerForm.Show();
            this.Hide();
        }
    }
}
