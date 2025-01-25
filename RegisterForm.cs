using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppoinmentSystem.Data;
using HospitalAppoinmentSystem.Models;

namespace HospitalAppoinmentSystem
{
    public partial class RegisterForm : Form
    {
        private HospitalDbContext _dbContext;
        private Form backForm;
        public RegisterForm(HospitalDbContext dbContext, Form backform)
        {
            this.backForm = backform;
            _dbContext = dbContext;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };
            _dbContext.Patients.Add(patient);
            _dbContext.SaveChanges();
            MessageBox.Show("Registration Successful");
            backForm.Show();
            this.Dispose();
        }

        private void lnkBackLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
