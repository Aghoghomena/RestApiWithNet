using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entity
{
    //inherit from dbcontext
    public class EmployeeContext: DbContext
    {

        //constructor of the class an dpass to the base constructor
        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        {

        }

        //dbset property which will act as our table

        public DbSet<Employee> Employees { get; set; }
        
    }
}
