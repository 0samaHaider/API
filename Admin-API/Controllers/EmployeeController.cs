using Admin_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly StudnetContext _context;

        public EmployeeController(StudnetContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            //if (ModelState.IsValid)
            //{
            _context.Employee.Add(emp);
            _context.SaveChanges();
            return Ok(1);
            //}
            //else
            //    return BadRequest("no");
        }
        [HttpGet]
        public IActionResult Get()
        {
            var c = _context.Employee.ToList();
            return Ok(c);
        }
        [HttpDelete]
        public IActionResult Dell(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");
            else
            {
                var emp = _context.Employee
                       .Where(s => s.ID == id)
                       .FirstOrDefault();
                _context.Employee.Remove(emp);
                _context.SaveChanges();

            }
            return Ok("valid");
        }
    }
}
