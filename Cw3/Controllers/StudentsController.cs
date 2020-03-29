using System;
using Microsoft.AspNetCore.Mvc;
using Cw3.DAL;

namespace Cw3.Models
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
        public IActionResult GetStudents(string orderBy) 
        {
            return Ok(_dbService.GetStudents());
           // return $"Kowalski, Malewski, Andrzejewski sortowanie={orderBy}";
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id) 
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2) 
            {
                return Ok("Malewski");
            }

            return NotFound("Nie znaleziono studenta");
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }

        
        [HttpPut]
        public OkObjectResult Put(int id)
        {           
            return Ok("Aktualizacja dokonczona");
        }

        
        [HttpDelete]
        public OkObjectResult Delete(int id)
        {
            return Ok("Usuwanie ukonczone");
        }

      

    }
}
