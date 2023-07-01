using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public string? AdminName { get; set; } // = "admin";

        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }

        public virtual ICollection<Doctor>? Doctors { get; set; }

        public virtual ICollection<Patient>? Patients { get; set; }

    }
}
