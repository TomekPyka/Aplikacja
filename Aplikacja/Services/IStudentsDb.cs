using Aplikacja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplikacja.Services
{
    public interface IStudentsDb
    {
        IEnumerable<Student> GetStudents();
        void AddStudent(Student student);

    }
}
