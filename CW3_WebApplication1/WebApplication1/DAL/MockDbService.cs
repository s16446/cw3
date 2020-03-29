using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class MockDbService : IDbService
    {
        private static List<Student> _students;

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

        public IEnumerable<Student> GetStudent(int id) {
            List<Student> n = new List<Student>();
            n.Add(_students.Find(x => x.IdStudent == id));
            return n;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void DeleteStudent(Student student)
        {
            _students.Remove(student);
        }
    }
}
