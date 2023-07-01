using BigBang_Assessment_2.Interface;
using BigBang_Assessment_2.Models;
using BigBang_Assessment_2.Repository.@interface;
using Microsoft.EntityFrameworkCore;

namespace BigBang_Assessment_2.Repository
{
    public class DoctorRepo : IDoctor
    {
        private readonly HospitalConetxt _context;

        public DoctorRepo(HospitalConetxt context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Doctor>> GetDoctors()
        {
            return await _context.Doctors.Include(x => x.Patients).ToListAsync();
        }

        public async Task<Doctor> GetDoctor(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public async Task AddDoctor(Doctor doctor)
        {
            _context.Doctors.Add(doctor);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateDoctor(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteDoctor(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DoctorExists(int id)
        {
            return await _context.Doctors.AnyAsync(e => e.Doctor_Id == id);
        }
    }
}