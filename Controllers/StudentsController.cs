using Microsoft.AspNetCore.Mvc;

namespace auth_jwt_token_asp_net_core_web_api_with_sameer.Controllers
{
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "Jonh", "Jane", "Mark" };

            return Ok(studentNames);
        }
    }
}
