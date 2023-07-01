using Microsoft.EntityFrameworkCore;

namespace BigBang_Assessment_2.Models
{
    public class HospitalConetxt : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Medication> Medications { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public HospitalConetxt(DbContextOptions<HospitalConetxt> options) : base(options)
        {

        }
    }
}
