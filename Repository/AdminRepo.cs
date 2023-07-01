using BigBang_Assessment_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBang_Assessment_2.Repository
{
    public class AdminRepo
    {
        private readonly HospitalConetxt cont;

        public AdminRepo(HospitalConetxt context)
        {
            cont = context;
        }

        public async Task<IEnumerable<Admin>> GetAdmins()
        {
            return await cont.Admins.Include(x => x.Doctors).ToListAsync();
        }

        public async Task<Admin> GetAdminById(int id)
        {
            var admin = await cont.Admins.FindAsync(id);
            return admin;
        }

        public async Task<Admin> PostAdmin(Admin admin)
        {
            cont.Admins.Add(admin);
            await cont.SaveChangesAsync();
            return admin;
        }

        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var admin = await cont.Admins.FindAsync(id);
            if (admin == null)
                return new NotFoundResult();

            cont.Admins.Remove(admin);
            await cont.SaveChangesAsync();
            return new NoContentResult();
        }
    }
}
    
