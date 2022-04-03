using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _51.EntityFramework.Code.Approach
{
    public class EmployeeRepository
    {

        public List<Department> GetDepartments()
        {
           
            EmployeeDBContext employeeDBContext = new EmployeeDBContext();

            // θα επιστρέψει μία λίστα από Depertments.
            
            //return employeeDBContext.Departments.ToList();
            return employeeDBContext.Departments.Include("Employees").ToList();

        }

    }
}