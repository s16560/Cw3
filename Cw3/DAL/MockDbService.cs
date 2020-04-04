
using System.Collections.Generic;
using Cw3.Models;

namespace Cw3.DAL
{
    public class MockDbService : IDbService
    {
        private static List<Student> _students = new List<Student>();

        public MockDbService()
        {
            _students.Add(new Student
            {
                IdStudent = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                IndexNumber = "s1234"
            });

            _students.Add(new Student
            {
                IdStudent = 2,
                FirstName = "Andrzej",
                LastName = "Kowalski",
                IndexNumber = "s3423"
            });
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
