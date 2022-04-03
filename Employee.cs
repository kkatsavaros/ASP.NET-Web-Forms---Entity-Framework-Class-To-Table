using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace _51.EntityFramework.Code.Approach
{
    [Table("tblEmployees")]
    public class Employee
    {

        // Scalar Properties
        public int Id { get; set; }

        [Column("First_Name")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]

        // Navigation Property
        public Department Department { get; set; }

        public String JobTitle { get; set; }


    }
}