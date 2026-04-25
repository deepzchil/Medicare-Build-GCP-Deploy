using Microsoft.AspNetCore.Mvc;
using MediCare.Models;
using System.Collections.Generic;

namespace MediCare.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardViewModel
            {
                TotalDoctors = 24,
                TotalPatients = 1248,
                TodaysAppointments = 32,
                PendingPayments = 18,
                NotificationCount = 3,
                RecentDoctors = new List<Doctor>
                {
                    new Doctor { Id = "DOC001", Name = "Dr. John Smith",    Specialty = "Cardiology",       Phone = "+1 (555) 123-4567", Status = "Available" },
                    new Doctor { Id = "DOC002", Name = "Dr. Emily Johnson", Specialty = "Neurology",        Phone = "+1 (555) 234-5678", Status = "In Surgery" },
                    new Doctor { Id = "DOC003", Name = "Dr. Michael Brown", Specialty = "Orthopedics",     Phone = "+1 (555) 345-6789", Status = "Available" },
                    new Doctor { Id = "DOC004", Name = "Dr. Sarah Wilson",  Specialty = "Pediatrics",      Phone = "+1 (555) 456-7890", Status = "Available" },
                    new Doctor { Id = "DOC005", Name = "Dr. David Lee",     Specialty = "General Medicine", Phone = "+1 (555) 567-8901", Status = "On Leave" },
                },
                TodaysSchedule = new List<ScheduleItem>
                {
                    new ScheduleItem { Time = "09:00 AM", DoctorName = "Dr. John Smith",    AppointmentType = "Consultation" },
                    new ScheduleItem { Time = "10:30 AM", DoctorName = "Dr. Emily Johnson", AppointmentType = "Surgery" },
                    new ScheduleItem { Time = "01:00 PM", DoctorName = "Dr. Michael Brown", AppointmentType = "Checkup" },
                }
            };

            return View(model);
        }
    }
}
