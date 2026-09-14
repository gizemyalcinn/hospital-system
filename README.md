# Hospital Appointment System

A desktop application built with C# and Windows Forms that streamlines the hospital appointment booking process for patients, doctors, and administrative staff. The system uses Entity Framework Core for data access and provides role-based interfaces tailored to each user type.

## Features

**Patient Portal**
- Register and log in with a personal account
- Browse departments and available doctors
- Book appointments by selecting a department, doctor, date, and available time slot
- View upcoming and past appointments
- Cancel existing appointments

**Doctor Portal**
- Log in with doctor credentials
- View and manage assigned appointments

**Admin/Manager Portal**
- Oversee departments, doctors, and overall appointment activity

## Tech Stack

- **Language:** C#
- **UI Framework:** Windows Forms
- **Data Access:** Entity Framework Core
- **Architecture:** Role-based multi-form navigation (Login → Patient/Doctor/Manager), with a shared `DbContext` passed between forms

## Key Implementation Details

- Real-time available time slot calculation based on existing bookings per doctor and date
- Relational data modeling across Patients, Doctors, Departments, and Appointments (with `Include()`-based eager loading for related entities)
- Appointment lifecycle management (active, canceled) with status tracking
- Input validation before appointment creation (department, doctor, time, and date checks)
- Role-based authentication routing users to the appropriate interface (Patient, Doctor, or Admin)

## Project Structure

- `LoginForm` – Authentication and role-based routing
- `RegisterForm` – New patient registration
- `PatientForm` – Appointment booking, viewing, and cancellation for patients
- `DoctorForm` – Appointment management for doctors
- `ManagerForm` – Administrative oversight

## Status

This is an academic project developed to practice object-oriented design, relational data modeling, and Entity Framework Core in a desktop application context.
