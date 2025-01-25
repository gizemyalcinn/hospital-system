using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAppoinmentSystem.Data;
using HospitalAppoinmentSystem.Models;
using HospitalAppoinmentSystem.Models.Enums;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace HospitalAppoinmentSystem
{
    public partial class PatientForm : Form
    {
        private readonly HospitalDbContext _dbContext;
        private readonly Patient _patient;
        private Form backForm;
        public PatientForm(Patient patient, HospitalDbContext dbContext, Form backForm)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _patient = patient;
            this.backForm = backForm;
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            try
            {
                lblNameValue.Text = $"{_patient.Name} {_patient.Surname}";
                lblEmailValue.Text = _patient.Email;

                var totalAppointments = _dbContext.Appointments
                    .Count(a => a.PatientId == _patient.Id);
                lblTotalAppValue.Text = totalAppointments.ToString();

                LoadFutureAppointments();
                LoadPastAppointments();
                LoadDepartmentsAndDoctors();
                LoadAvailableTimeSlots();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFutureAppointments()
        {
            var today = DateTime.Today;
            var futureAppointments = _dbContext.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Department)
                .Where(a => a.PatientId == _patient.Id && a.IsActive)
                .AsEnumerable() 
                .Where(a => a.Date >= today) 
                .Select(a => new
                {
                    Tarih = a.Date.ToString("dd/MM/yyyy"),
                    Saat = $"{a.Time:D2}:00",
                    Bölüm = a.Department.Name,
                    Doktor = $"{a.Doctor.Name} {a.Doctor.Surname}",
                    Durum = a.Status.ToString(),
                    İşlem = "İptal Et"
                })
                .OrderBy(a => a.Tarih)
                .ThenBy(a => a.Saat)
                .ToList();

            dgvFutureAppointments.DataSource = futureAppointments;
            dgvUpComing.DataSource = futureAppointments;
            ConfigureDataGridView(dgvFutureAppointments);
            ConfigureDataGridView(dgvUpComing);
        }

        private void LoadPastAppointments()
        {
            var today = DateTime.Today;
            var pastAppointments = _dbContext.Appointments
                .Include(a => a.Doctor)
                .Include(a => a.Department)
                .Where(a => a.PatientId == _patient.Id)
                .AsEnumerable() 
                .Where(a => !a.IsActive || a.Date < today) 
                .Select(a => new
                {
                    Tarih = a.Date.ToString("dd/MM/yyyy"),
                    Saat = $"{a.Time:D2}:00",
                    Bölüm = a.Department.Name,
                    Doktor = $"{a.Doctor.Name} {a.Doctor.Surname}",
                    Durum = a.Status.ToString()
                })
                .OrderByDescending(a => a.Tarih)
                .ThenBy(a => a.Saat)
                .ToList();

            dataGridView1.DataSource = pastAppointments;
            ConfigureDataGridView(dataGridView1);
        }

        private void LoadDepartmentsAndDoctors()
        {
            var departments = _dbContext.Departments
                .Where(d => d.IsActive)
                .OrderBy(d => d.Name)
                .ToList();

            cmbDepartment.DataSource = departments;
            cmbDepartment.DisplayMember = "Name";
            cmbDepartment.ValueMember = "Id";
            LoadDoctorsForDepartment();
        }

        private void LoadDoctorsForDepartment()
        {
            try
            {
                if (cmbDepartment.SelectedItem == null) return;

                var departmentId = ((Department)cmbDepartment.SelectedItem).Id;
                var doctors = _dbContext.Doctors
                    .Where(d => d.DepartmentId == departmentId)
                    .ToList()
                    .Select(d => new
                    {
                        Id = d.Id,
                        Name = $"Dr. {d.Name}"
                    })
                    .ToList();

                cmbDoctor.DataSource = doctors;
                cmbDoctor.DisplayMember = "Name";
                cmbDoctor.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Doktorlar yüklenirken hata oluştu: " + ex.Message);
            }
        }


        private void LoadAvailableTimeSlots()
        {
            try
            {
                cmbAppointmentTime.Items.Clear();

                if (cmbDoctor.SelectedItem == null || dtpAppointmentDate.Value == null)
                    return;

                var selectedDoctorId = Convert.ToInt32(cmbDoctor.SelectedValue);
                var selectedDate = dtpAppointmentDate.Value.Date;

                var takenAppointments = _dbContext.Appointments
                    .Where(a => a.DoctorId == selectedDoctorId &&
                                a.IsActive &&
                                a.Status != AppointmentStatus.Canceled)
                    .AsEnumerable()
                    .Where(a => a.Date.Date == selectedDate)
                    .Select(a => a.Time)
                    .ToList();

                for (int hour = 9; hour <= 17; hour++)
                {
                    if (!takenAppointments.Contains(hour))
                    {
                        cmbAppointmentTime.Items.Add($"{hour:D2}:00");
                    }
                }

                if (cmbAppointmentTime.Items.Count > 0)
                    cmbAppointmentTime.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müsait saatler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private async void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateAppointmentInput()) return;

                string selectedTime = cmbAppointmentTime.SelectedItem.ToString().Replace(":00", "");
                int hours = int.Parse(selectedTime);
                TimeSpan time = TimeSpan.FromHours(hours);
                int a = (int)time.TotalHours;


                int depId = ((Department)cmbDepartment.SelectedItem).Id;

                int docId = ((dynamic)cmbDoctor.SelectedItem).Id;

                var appointment = new Appointment
                {
                    PatientId = _patient.Id,
                    DepartmentId = depId,
                    DoctorId = docId,
                    IsActive = true,
                    Status = AppointmentStatus.Active,
                    Date = dtpAppointmentDate.Value.Date,
                    Time = a,
                };

                _dbContext.Appointments.Add(appointment);
                _dbContext.SaveChangesAsync();

                MessageBox.Show("Randevu başarıyla oluşturuldu.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadFutureAppointments();
                LoadAvailableTimeSlots();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Randevu oluşturulurken bir hata oluştu: {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateAppointmentInput()
        {
            if (cmbDepartment.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir bölüm seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbDoctor.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir doktor seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbAppointmentTime.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir saat seçin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpAppointmentDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Geçmiş bir tarih seçemezsiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ConfigureDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDoctorsForDepartment();
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        private void dtpAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAvailableTimeSlots();
        }

        private async void dgvFutureAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFutureAppointments.Columns["İşlem"].Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("Randevuyu iptal etmek istediğinize emin misiniz?",
                    "Randevu İptali", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        var selectedAppointment = await _dbContext.Appointments
                            .FirstOrDefaultAsync(a =>
                                a.Date.ToShortDateString() == dgvFutureAppointments.Rows[e.RowIndex].Cells["Tarih"].Value.ToString() &&
                                $"{a.Time:D2}:00" == dgvFutureAppointments.Rows[e.RowIndex].Cells["Saat"].Value.ToString() &&
                                a.PatientId == _patient.Id);

                        if (selectedAppointment != null)
                        {
                            selectedAppointment.Status = AppointmentStatus.Canceled;
                            selectedAppointment.IsActive = false;

                            _dbContext.SaveChangesAsync();
                            LoadFutureAppointments();
                            LoadPastAppointments();
                            LoadAvailableTimeSlots();

                            MessageBox.Show("Randevu başarıyla iptal edildi.", "Başarılı",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Randevu iptal edilirken bir hata oluştu: {ex.Message}",
                            "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnQuickAppointment_Click(object sender, EventArgs e)
        {
        }

        private void txtAppointmentSummary_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            backForm.Show();
        }
    }
}