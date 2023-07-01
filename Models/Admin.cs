using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Admin
    {
        [Key]
        public int Admin_Id { get; set; }
        public string? Admin_Name { get; set; }
        public string? Admin_Password { get; set; }

        public virtual ICollection<Doctor>? Doctors { get; set; }

        public virtual ICollection<Patient>? Patients { get; set; }

    }
}
