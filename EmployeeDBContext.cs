using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace _51.EntityFramework.Code.Approach
{
    public class EmployeeDBContext : DbContext
    {
        
        // Το property Departments θα επιστρέφει ένα DbSet από Department Objects.
        public DbSet<Department> Departments { get; set; }


        // Το property Employees θα επιστρέφει ένα DbSet από Employees Objects.
        public DbSet<Employee> Employees { get; set; }

    }
}