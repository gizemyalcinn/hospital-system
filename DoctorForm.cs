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
using HospitalAppoinmentSystem.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppoinmentSystem
{
    public partial class DoctorForm : Form
    {
        private Form backForm;
        private Doctor doctor;
        private HospitalDbContext _dbContext;
        public DoctorForm(Doctor doctor, HospitalDbContext cpContext, Form backForm)
        {
            this.doctor = doctor;
            this.backForm = backForm;
            this._dbContext = cpContext;
            InitializeComponent();
            LoadDoctorInfo();
            UpdateAppointmentStats();
        }

        private void LoadDoctorInfo()
        {

            Doctor doctor = this.doctor;
            _dbContext.Entry(doctor).Reference(d => d.Department).Load();
            _dbContext.Entry(doctor).Collection(d => d.Appointments).Load();
            txtName.Text = doctor.Name;
            txtSurname.Text = doctor.Surname;
            txtEmail.Text = doctor.Email;
            cmbSpecialty.DataSource = _dbContext.Departments.ToList();
            cmbSpecialty.DisplayMember = doctor.Department.Name;
            cmbStartTime.Text = doctor.WorkStartTime.ToString();
            cmbEndTime.Text = doctor.WorkEndTime.ToString();
            lblWelcome.Text = $"Welcome, Dr. {_dbContext.Doctors.First().Name} {_dbContext.Doctors.First().Surname}";
        }


        private void UpdateAppointmentStats()
        {
            lblTotalAppValue.Text = _dbContext.Appointments.Count().ToString();
            lblTodayAppValue.Text = _dbContext.Appointments
                .Where(a => a.Date.Date == DateTime.Today).Count().ToString();

            lblActiveAppValue.Text = _dbContext.Appointments
                .Where(a => a.Status == AppointmentStatus.Active).Count().ToString();

            lblCancelledAppValue.Text = _dbContext.Appointments
                .Where(a => a.Status == AppointmentStatus.Canceled).Count().ToString();

            lblWelcome.Text = $"Welcome, Dr. {_dbContext.Doctors.First().Name} {_dbContext.Doctors.First().Surname}";
        }

        private void LoadAppointments()
        {
            try
            {
                var currentDateTime = DateTime.Now;

                var appointments = _dbContext.Appointments
                    .Include(a => a.Patient) 
                    .Where(a => a.DoctorId == doctor.Id &&
                                a.Date > currentDateTime && 
                                a.Date.Date >= dtpStartDate.Value.Date &&
                                a.Date.Date <= dtpEndDate.Value.Date)
                    .Select(a => new
                    {
                        Tarih = a.Date.Date,
                        Saat = a.Date.TimeOfDay,
                        HastaAdı = a.Patient.Name + " " + a.Patient.Surname,
                        Durum = a.Status,
                        KalanSüre = a.Date - currentDateTime 
                    })
                    .OrderBy(a => a.Tarih)
                    .ThenBy(a => a.Saat)
                    .ToList();

                dgvUpComingAppointments.DataSource = appointments;

                lblTotalRecords.Text = $"Gelecek Randevu Sayısı: {appointments.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular yüklenirken bir hata oluştu: " + ex.Message,
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            LoadAppointments();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                var doctor = _dbContext.Doctors.Find(this.doctor.Id);
                MessageBox.Show("Bilgileriniz başarıyla güncellenmedi.");
            }

            

            _dbContext.SaveChanges();
            MessageBox.Show("Bilgileriniz başarıyla güncellendi.");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Show();
            this.Dispose();
        }

        private void tabMainControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMainControl.TabIndex == 1)
                UpdateAppointmentStats();
            else if (tabMainControl.TabIndex == 2)
                LoadAppointments();
            else if (tabMainControl.TabIndex == 0)
                LoadDoctorInfo();
        }
    }
}
