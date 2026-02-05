using System.ComponentModel.DataAnnotations;

namespace HealthcareFrontend.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the patient's name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Patient name must be between 2 and 100 characters.")]
        public string PatientName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please specify the doctor's name.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Doctor name must be between 2 and 100 characters.")]
        public string DoctorName { get; set; } = string.Empty;

        [Required(ErrorMessage = "An appointment date is required.")]
        public DateTime AppointmentDate { get; set; } = DateTime.Now;
    }
}