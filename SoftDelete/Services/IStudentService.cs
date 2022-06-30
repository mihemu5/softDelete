using SoftDelete.Models;

namespace SoftDelete.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
    }
}
