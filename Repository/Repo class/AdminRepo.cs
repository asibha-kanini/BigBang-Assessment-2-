using BigBang_Assessment_2.Models;
using BigBang_Assessment_2.Repository.@interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BigBang_Assessment_2.Repository
{
    public class AdminRepo : IAdmin
    {
        private readonly HospitalConetxt cont;

        public AdminRepo(HospitalConetxt context)
        {
            cont = context;
        }

        public async Task<IEnumerable<Admin>> GetAdmins()
        {
            return await cont.Admins.ToListAsync();
        }

        public async Task<Admin> GetAdmin(int id)
        {
            return await cont.Admins.FindAsync(id);
        }

        public async Task AddAdmin(Admin admin)
        {
            cont.Admins.Add(admin);
            await cont.SaveChangesAsync();
        }

        public async Task UpdateAdmin(Admin admin)
        {
            cont.Entry(admin).State = EntityState.Modified;
            await cont.SaveChangesAsync();
        }

        public async Task DeleteAdmin(Admin admin)
        {
            cont.Admins.Remove(admin);
            await cont.SaveChangesAsync();
        }

        public async Task<bool> AdminExists(int id)
        {
            return await cont.Admins.AnyAsync(e => e.Admin_Id == id);
        }
    }
}
