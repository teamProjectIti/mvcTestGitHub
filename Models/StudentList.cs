using System.Collections.Generic;

namespace mvc1.Models
     
{
    public class StudentList
    {
        List<Student> students = new List<Student>()
        {
            new Student{ID = 1,Name = "Mahran",Age = 25, Address = "assuit", Image="1.jpg"},
            new Student{ID = 2,Name = "Mohamed",Age = 22, Address = "assuit", Image="2.jpg"},
             new Student{ID = 3,Name = "Ali",Age = 24, Address = "sohage", Image="3.jpg"}
        };

        public List<Student> GetAllStudents()
        {
            return students;
        }
    }
}
