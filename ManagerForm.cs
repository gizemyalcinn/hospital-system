using HospitalAppoinmentSystem.Data;
using HospitalAppoinmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppoinmentSystem.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace HospitalAppoinmentSystem
{
    public partial class ManagerForm : Form
    {
        private readonly HospitalDbContext _dbContext;
        private Form backForm;
        public ManagerForm(HospitalDbContext dbContext, Form backForm)
        {
            InitializeComponent();
            this.backForm = backForm;
            _dbContext = dbContext;
        }

        private void ManagerForm_Load_1(object sender, EventArgs e)
        {
            UpdateDashboardStats();
            LoadDepartments();
            LoadDoctors();
            LoadAppointments();
        }

        private void UpdateDashboardStats()
        {
            lblTotalDoctorsValue.Text = _dbContext.Doctors.Count().ToString();
            lblTotalDoctors.Text = _dbContext.Doctors.Count().ToString();
            lblTotalDepartmentsValue.Text = _dbContext.Departments.Count().ToString();
            lblActiveAppointmentsValue.Text = _dbContext.Appointments
                .Count(a => a.Status == AppointmentStatus.Active).ToString();
            lblCancelledAppointmentsValue.Text = _dbContext.Appointments
                .Count(a => a.Status == AppointmentStatus.Canceled).ToString();
        }

        private void LoadDoctors()
        {
            var doctors = _dbContext.Doctors
                .Include(d => d.Department)
                .Select(d => new
                {
                    d.Id,
                    AdSoyad = d.Name + " " + d.Surname,
                    d.Email,
                    UzmanlıkAlanı = d.Department.Name,
                }).ToList();

            dgvDoctors.DataSource = doctors;
        }

        private void btnSaveDoctor_Click_2(object sender, EventArgs e)
        {
            try
            {
                var selectedDepartment = _dbContext.Departments
                    .FirstOrDefault(d => d.Name == cmbSpecialty.Text);
                if (selectedDepartment == null)
                {
                    MessageBox.Show("Bölüm seçiniz.");
                    return;
                }
                TimeSpan time1 = new TimeSpan(hours: 8, minutes: 30, seconds: 0);
                TimeSpan time2 = new TimeSpan(hours: 17, minutes: 30, seconds: 0);
                var doctor = new Doctor
                {
                    Name = txtName.Text,
                    Surname = txtSurname.Text,
                    Email = txtEmail.Text,
                    DepartmentId = selectedDepartment.Id,
                    Password = txtPassword.Text,
                    WorkStartTime = time1,
                    WorkEndTime = time2,
                };

                _dbContext.Doctors.Add(doctor);
                _dbContext.SaveChanges();

                MessageBox.Show("Doktor başarıyla eklendi.");
                LoadDoctors();
                ClearDoctorForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktor eklenirken hata oluştu: " + ex.Message);
            }
        }

        private void LoadDepartments()
        {
            var departments = _dbContext.Departments
                .Select(d => new
                {
                    d.Id,
                    BölümAdı = d.Name,
                    DoktorSayısı = d.Doctors.Count(),
                    Durum = d.IsActive == true ? "Aktif" : "Pasif"
                }).ToList();

            dgvDepartments.DataSource = departments;
        }

        private void btnSaveDepartment_Click_1(object sender, EventArgs e)
        {
            try
            {
                var department = new Department
                {
                    Name = txtDepartmentName.Text,
                    IsActive = cmbStatus.Text == "Aktif" ? true : false

                };

                _dbContext.Departments.Add(department);
                _dbContext.SaveChanges();

                MessageBox.Show("Bölüm başarıyla eklendi.");
                LoadDepartments();
                ClearDepartmentForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bölüm eklenirken hata oluştu: " + ex.Message);
            }
        }

        private void LoadAppointments()
        {
            try
            {
                var appointmentCount = _dbContext.Appointments.Count();
                Debug.WriteLine($"Toplam randevu sayısı: {appointmentCount}");

                var appointments = _dbContext.Appointments
                    .Include(a => a.Doctor)
                    .Include(a => a.Patient)
                    .Include(a => a.Doctor.Department)
                    .Where(a => a.Date.Date >= dtpStartDate.Value.Date &&
                                a.Date.Date <= dtpEndDate.Value.Date)
                    .Select(a => new
                    {
                        Tarih = a.Date.Date,
                        Saat = a.Date.TimeOfDay,
                        HastaAdı = a.Patient.Name + " " + a.Patient.Surname,
                        DoktorAdı = a.Doctor.Name + " " + a.Doctor.Surname,
                        Bölüm = a.Doctor.Department.Name,
                        Durum = a.Status
                    })
                    .OrderBy(a => a.Tarih)
                    .ThenBy(a => a.Saat)
                    .ToList();

                Debug.WriteLine($"Filtrelenmiş randevu sayısı: {appointments.Count}");

                dgvDepartments.DataSource = appointments;

                Debug.WriteLine($"DataGridView sütun sayısı: {dgvDepartments.Columns.Count}");
                Debug.WriteLine($"DataGridView satır sayısı: {dgvDepartments.Rows.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Randevular yüklenirken bir hata oluştu: {ex.Message}\n\nStack Trace: {ex.StackTrace}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterAppointments_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
            LoadAppointments();
        }

        private void ClearDoctorForm()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            cmbSpecialty.SelectedIndex = -1;
            txtPassword.Clear();
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void ClearDepartmentForm()
        {
            txtDepartmentName.Clear();
            cmbStatus.SelectedIndex = -1;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbViewType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
