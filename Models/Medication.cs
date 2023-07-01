using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Medication
    {
        [Key]
        public int MedId { get; set; }

        public string? MedName { get; set; }

        public string? MedDescription { get; set; }

        public virtual ICollection<Patient>? Patients { get; set; }

    }
}
