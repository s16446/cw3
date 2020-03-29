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
        public string GetStudent() {
            return "Nowak, Kowalska, Kossak";
        }
    }
}