using BigBang_Assessment_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBang_Assessment_2.Interface
{
    public interface IAdmin
    {
        Task<IEnumerable<Admin>> GetAdmins();
        Task<Admin> GetAdminById(int id);
        Task<Admin> PostAdmin(Admin admin);
        Task<IActionResult> DeleteAdmin(int id);
    }
}
