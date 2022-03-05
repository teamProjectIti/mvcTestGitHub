using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using mvc1.Models;
using System.Linq;

namespace mvc1.Controllers
{
    public class StudentController : Controller
    {//Student/stdentdetal/2
        public IActionResult Index()
        {
            StudentList studentList = new StudentList();

            List<Student> allStudent = studentList.GetAllStudents();
            return View("Students", allStudent);
        }
        public IActionResult stdentdetal(int id)
        {
            StudentList studentList = new StudentList();

            List<Student> allStudent = studentList.GetAllStudents();
            Student student = allStudent.FirstOrDefault(s => s.ID == id); 

            return View("StudentDet", student);
        }
    }
    
}
