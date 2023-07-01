using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Appointment
    {
        [Key]
        public int Appointment_Id { get; set; }
        public DateTime? Appointment_Date { get; set; }
        public string? Description { get; set; }
        public Doctor? Doctor { get; set; }
        public Patient? Patient { get; set; }
    }
}

