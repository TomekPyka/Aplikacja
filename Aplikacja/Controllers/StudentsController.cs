using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplikacja.Models;
using Aplikacja.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aplikacja.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsDb _dbService;

        public StudentsController(IStudentsDb service) {
            _dbService = service;
        }

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbService.GetStudents());
        }
       
        [HttpGet("{id:min(1):int}")]
        public string GetStudents2(int id){
            if (id == 1){
            return "Anna";
            }
            return "nie znaleziono";
        }
        
        [HttpPost]
        public IActionResult createStudent(Student student){
            student.IndexNumber=$"s{new Random().Next(1, 10000)}";
            _dbService.AddStudent(student);
            return Ok(student);
        }
    }
}