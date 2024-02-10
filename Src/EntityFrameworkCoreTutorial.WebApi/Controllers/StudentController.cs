using EntityFrameworkCore.Data.Context;
using EntityFrameworkCore.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace EntityFrameworkCoreTutorial.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Loading Types =>EagerLoading ,LazyLoading
        private async Task<Student> EagerLoading(int param)
        {
            //Eager Loading
            var students = await _context.Students
                .Include(i=>i.Books)
                .FirstOrDefaultAsync(i=>i.Id == param);
            return students;
        }

        //Loading Types => LazyLoading
        // Virtual sign should be used in Entity
        private async Task<Student> LazyLoading(int param)
        {
            var student = await _context.Students.FirstOrDefaultAsync(i=>i.Id == param);

            return student;
        }
        

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Eager
            //var data = await EagerLoading(1003);
            //return Ok(data);

            //Lazy
            var data = await LazyLoading(1003);
            return Ok(data);
        }

      

        [HttpPost]
        public async Task<IActionResult> Add()
        {

            Student student = new Student()
            {
                Name = "Osman",
                SureName = "KUŞTU",
                Address = new StudentAddress()
                {
                    City = "Antalya",
                    Country = "Turkey",
                    Distric = "Muratpasha",
                    FullAddress = "x",
                }

            };

            await _context.Students.AddAsync(student);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")] 
        public async Task<IActionResult> Delete(int id)
        {
            var student = await _context.Students.FindAsync(id);
            //Or
            //var student = await _context.Students.Where(i => i.Id == id).SingleOrDefaultAsync();
            
            _context.Students.Remove(student);

            await _context.SaveChangesAsync();
            return Ok();

        }


        [HttpPut]
        public async Task<IActionResult> Update()
        {
            var student = await _context.Students.SingleOrDefaultAsync();

            student.Name = "Ozan";

            await _context.SaveChangesAsync();
            return Ok();

        }

    }
}
