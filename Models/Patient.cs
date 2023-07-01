using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public int? PatientAge { get; set; }

        public string? PatientGender { get; set; }
        public string PatientDescription { get; set; }

        public byte[]? PatientImg { get; set; }

        public virtual ICollection<Medication>? Meds { get; set; }
        public virtual ICollection<Doctor>? Doctors { get; set; }
    }
}
