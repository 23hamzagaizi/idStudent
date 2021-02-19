using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using studentID.Models;

namespace studentID.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class studentsController : ControllerBase
    {
        public static List<students> GetStudent()
        {
            List<Students> studentsList = new List<Games>();
            studentsList.Add(new Students(){id = 1000, first_name= "John", last_name= "Keita",age= 20 });
            studentsList.Add(new Students(){id = 1001, first_name= "Jean", last_name= "Dupond",age= 21 });
            studentsList.Add(new Students(){id = 1002, first_name= "Mohammed", last_name= "Alaoui",age= 19 });
            studentsList.Add(new Students(){id = 1003, first_name= "Karen", last_name= "Smith",age= 20 });
            return studentsList;
        }

        [HttpGet]
        public IEnumerable<Games> GetStudents_List()
        {
            return GetStudent();
        }

        [HttpGet("{id}")]
        public ActionResult<Students> GetStudents_ById(int id)
        {
            var students = GetStudent().Find(x => x.Id == id);
            if(students != null)
            {
                return students;
            }
            else 
            {
                return NotFound();
            }
        }
    }
}