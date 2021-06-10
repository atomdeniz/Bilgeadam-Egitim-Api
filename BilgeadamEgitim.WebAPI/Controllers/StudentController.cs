using BilgeadamEgitim.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BilgeadamEgitim.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public Student Get()
        {
            var student = new Student
            {
                Name = "Deniz",
                Surname = "Özoğul",
                Age = 24
            };

            return student;
        }



        [HttpPost]
        public Student Post()
        {
            var student = new Student
            {
                Name = "Deniz",
                Surname = "Özoğul",
                
            };

            return student;
        }


        [HttpDelete]
        public Student Delete()
        {
            var student = new Student
            {
                Name = "Deniz",
                Surname = "Özoğul",
                Age = 24
            };

            return student;
        }
    }
}
