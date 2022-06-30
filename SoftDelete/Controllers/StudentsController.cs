using Microsoft.AspNetCore.Mvc;
using SoftDelete.Services;

namespace SoftDelete.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return new JsonResult(new { data = await _studentService.GetAllAsync()});
        }
    }
}