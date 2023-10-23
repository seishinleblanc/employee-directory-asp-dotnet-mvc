using System;
using employee.Data;
using Microsoft.EntityFrameworkCore;

namespace employee.Models
{
    public class EmployeeContext : ApplicationDbContext
    {
        public EmployeeContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }

    public class Employee
	{
		public int id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
	}
}

