using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/students")]

    public class StudentsController : ControllerBase
    {
        private readonly IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudent(string orderBy) {
            //return $"Nowak, Kowalska, Kossak sortowanie={orderBy}";
            return Ok(_dbService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) {
            if (id == 1)
            {
                return Ok("Nowak");
            }
            else if (id == 2) {
                return Ok("Malewski");
            }
            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student) {
            // ... adding to the database
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        [HttpPut("{id}")] // update
        public IActionResult UpdateStudent(int id)
        {
            return Ok("Aktualizacja zakonczona: " + id);
        }

        [HttpDelete("{id}")] // delete
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Usuwanie zakonczone" + id);
        }
    }
}