using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin_API.Model;
namespace Admin_API
{
    public class StudnetContext :DbContext
    {
        public StudnetContext(DbContextOptions<StudnetContext> options) : base(options)
        {
        }
        public DbSet<Sign_Up> Sign_Up { get; set; }
        public DbSet<Employee> Employee { get; set; }
    }
}
