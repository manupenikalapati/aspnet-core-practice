
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_Core_Demo_App.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public string GetStudents()
        {
            return "Welcome to Student API!";
        }


        [HttpPost]
        public string AddStudent()
        {
            return "Student added successfully!";
        }
    }
}
