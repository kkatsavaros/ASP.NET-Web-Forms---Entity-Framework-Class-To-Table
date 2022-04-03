﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _51.EntityFramework.Code.Approach
{
    public class Department
    {

        // Scalar Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        // Navigation Property
        public List<Employee> Employees { get; set; }

    }
}