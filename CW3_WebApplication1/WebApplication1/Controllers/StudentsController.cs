using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]  
    [Route("api/students")]

    public class StudentsController : ControllerBase
    {
         [HttpGet]
         public string GetStudent(string orderBy) {
             return $"Nowak, Kowalska, Kossak sortowanie={orderBy}";
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
    }
}