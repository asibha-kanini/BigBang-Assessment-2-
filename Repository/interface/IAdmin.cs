using BigBang_Assessment_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBang_Assessment_2.Repository.@interface
{
    public interface IAdmin
    {
        Task<IEnumerable<Admin>> GetAdmins();
        Task<Admin> GetAdmin(int id);
        Task AddAdmin(Admin admin);
        Task UpdateAdmin(Admin admin);
        Task DeleteAdmin(Admin admin);
        Task<bool> AdminExists(int id);
    }
}
