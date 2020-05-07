using Aplikacja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja.Services
{
    public class MockStudentsDb : IStudentsDb
    {
        private static List<Student> _students = new List<Student>();
        public MockStudentsDb()
        {
            _students.Add(new Student()
            {
                IdStudent = 1,
                FirstName = "Waldek",
                LastName = "Pyka",
                IndexNumber = "12343"
            });;
            _students.Add(new Student()
            {
                IdStudent = 2,
                FirstName = "Gonia",
                LastName = "LOL",
                IndexNumber = "12355"
            }); ;
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
