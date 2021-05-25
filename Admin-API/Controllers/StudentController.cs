using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudnetContext  _context;

        public StudentController(StudnetContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Get()
        {
          var c= _context.Sign_Up.ToList();
            return Ok(c);
        }
        [HttpPost]
        public IActionResult Post(Sign_Up sign_Up)
        {
            //if (ModelState.IsValid)
            //{
                _context.Sign_Up.Add(sign_Up);
                _context.SaveChanges();
                return Ok(1);
            //}
            //else
            //    return BadRequest("no");
        }
        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            var c=_context.Sign_Up.Find(ID);
            return Ok(c);
        }
        [HttpPut("{ID:int}")]
        public IActionResult putt(int ID,Sign_Up sign_Up)
        {
            _context.Sign_Up.Update(sign_Up);
           var c= _context.SaveChanges();
            return Ok(c);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest("Not a valid student id");
            else
            {
                var student = _context.Sign_Up
                       .Where(s => s.ID == id)
                       .FirstOrDefault();
                _context.Sign_Up.Remove(student);
                _context.SaveChanges();

            }
            return Ok("nvalid");
        }
      
    }
}
