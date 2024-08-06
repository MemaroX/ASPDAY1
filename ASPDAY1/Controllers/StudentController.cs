using ASPDAY1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDAY1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ahmed", Age = 20, Email = "ahmed@example.com", PhoneNumber = "1234567890", Address = "menouf" },
                new Student { Id = 2, Name = "Mohamed", Age = 22, Email = "mohamed@example.com", PhoneNumber = "9876543210", Address = "El minya" },
                new Student { Id = 3, Name = "George", Age = 21, Email = "george@example.com", PhoneNumber = "123123123132", Address = "Cairo" },
                new Student { Id = 4, Name = "Mohsen", Age = 23, Email = "mohsen@example.com", PhoneNumber = "13231231231", Address = "Alex" },
                new Student { Id = 5, Name = "Kamel", Age = 20, Email = "kamel@example.com", PhoneNumber = "431412312312", Address = "Bani suef" }
            };

            return View(students);
        }
    }
}
