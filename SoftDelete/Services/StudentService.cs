using Microsoft.EntityFrameworkCore;
using SoftDelete.Models;

namespace SoftDelete.Services
{
    public class StudentService: IStudentService
    {
        private readonly SoftDeleteContext _context;
        public StudentService(SoftDeleteContext softDeleteContext)
        {
            this._context = softDeleteContext;    
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _context.Students.ToListAsync();
        }
    }
}
