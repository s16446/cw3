using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class MockDbService : IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService() 
        {
            _students = new List<Student> 
            {
                new Student{ IdStudent = 1, FirstName = "Anna", LastName = "Nowak"},
                new Student{ IdStudent = 2, FirstName = "Robert", LastName = "Kowalski"},
                new Student{ IdStudent = 3, FirstName = "Jerzy", LastName = "Szczepaniak"}
            };


        }
        public IEnumerable<Student> GetStudents()
        {
            return _students;
        }
    }
}
