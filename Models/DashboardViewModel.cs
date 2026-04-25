using System.Collections.Generic;

namespace MediCare.Models
{
    public class DashboardViewModel
    {
        public int TotalDoctors { get; set; }
        public int TotalPatients { get; set; }
        public int TodaysAppointments { get; set; }
        public int PendingPayments { get; set; }
        public List<Doctor> RecentDoctors { get; set; } = new();
        public List<ScheduleItem> TodaysSchedule { get; set; } = new();
        public int NotificationCount { get; set; }
    }

    public class Doctor
    {
        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Specialty { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Status { get; set; } = ""; // Available, In Surgery, On Leave
        public string AvatarUrl { get; set; } = "";
    }

    public class ScheduleItem
    {
        public string Time { get; set; } = "";
        public string DoctorName { get; set; } = "";
        public string AppointmentType { get; set; } = ""; // Consultation, Surgery, Checkup
    }
}
