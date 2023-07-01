using System.ComponentModel.DataAnnotations;

namespace BigBang_Assessment_2.Models
{
    public class Doctor
    {
        [Key]
        public int DocId { get; set; }
        public string DocName { get; set; }
        public string DocSpecialty { get; set; }
        public bool DocActive { get; set; }
        public byte[]? DocImg { get; set; }
        public virtual ICollection<Patient>? Patients { get; set; }
    }
}
