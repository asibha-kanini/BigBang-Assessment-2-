using BigBang_Assessment_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBang_Assessment_2.Repository
{
    public class MedRepo
    {
        private readonly HospitalConetxt cont;

        public MedRepo(HospitalConetxt context)
        {
            cont = context;
        }

        public async Task<IEnumerable<Medication>> GetMedications()
        {
            return await cont.Medications.Include(x => x.Patients).ToListAsync();
        }

        public async Task<Medication> GetMedicineById(int id)
        {
            var med = await cont.Medications.FindAsync(id);
            return med;
        }

        public async Task<Medication> PostMedication(Medication med)
        {
            cont.Medications.Add(med);
            await cont.SaveChangesAsync();
            return med;
        }

        public async Task<IActionResult> DeleteMedication(int id)
        {
            var med = await cont.Medications.FindAsync(id);
            if (med == null)
                return new NotFoundResult();

            cont.Medications.Remove(med);
            await cont.SaveChangesAsync();
            return new NoContentResult();
        }
    }
}
   
