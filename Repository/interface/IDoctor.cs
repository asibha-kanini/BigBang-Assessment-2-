using BigBang_Assessment_2.Models;

namespace BigBang_Assessment_2.Interface
{
    public interface IDoctor
    {
        Task<IEnumerable<Doctor>> GetDoctors();
        Task<Doctor> GetDoctor(int id);
        Task AddDoctor(Doctor doctor);
        Task UpdateDoctor(Doctor doctor);
        Task DeleteDoctor(Doctor doctor);
        Task<bool> DoctorExists(int id);

    }
}
