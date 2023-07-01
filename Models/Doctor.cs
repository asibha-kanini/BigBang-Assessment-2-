using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Doctor
    {
       
        [Key]
        public int Doctor_Id { get; set; }
        public string? Doctor_Name { get; set; }
        public string? Specialization { get; set; }
        public string? Doctor_Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Contact_No { get; set; }
        public string? Password { get; set; }
        public string? Status { get; set; }

        public ICollection<Patient>? Patients { get; set; }
        public ICollection<Appointment>? Appointments { get; set; }

       
    }
}
