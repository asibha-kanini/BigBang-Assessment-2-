using BigBang_Assessment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace BigBang_Assessment_2.Repository
{
    public class DoctorRepo
    {
        private readonly HospitalConetxt _context;

        public DoctorRepo(HospitalConetxt context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Doctor>> GetAll()
        {
            return await _context.Doctors.ToListAsync();
        }

        public async Task<Doctor> GetById(int id)
        {
            return await _context.Doctors.FindAsync(id);
        }

        public async Task Add(Doctor doctor)
        {
            _context.Doctors.Add(doctor);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Doctor doctor)
        {
            _context.Entry(doctor).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Doctor doctor)
        {
            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Doctor>> GetDoctorsByActiveStatus(bool isActive)
        {
            return await _context.Doctors
                .Where(d => d.DocActive == isActive)
                .ToListAsync();
        }

        public async Task<IEnumerable<Doctor>> GetDoctorsBySpecialty(string specialty)
        {
            return await _context.Doctors
                .Where(d => d.DocSpecialty == specialty)
                .ToListAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await _context.Doctors.AnyAsync(e => e.DocId == id);
        }
    }
}
    
