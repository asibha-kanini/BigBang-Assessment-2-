using BigBang_Assessment_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace BigBang_Assessment_2.Repository.@interface
{
    public interface IPatient
    {
        Task<ActionResult<IEnumerable<Patient>>> GetPatients();
        Task<ActionResult<Patient>> GetPatientById(int id);
        Task<ActionResult<Patient>> PostPatient(Patient entity);
        Task<IActionResult> PutPatient(int id, Patient entity);
        Task<IActionResult> DeletePatient(int id);
        Task<bool> Exists(int id);
    }
}
