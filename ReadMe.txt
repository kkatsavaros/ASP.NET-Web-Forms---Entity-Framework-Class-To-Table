ASP.NET Web Forms - Entity Framework Class To Table



In that project i use Entity Framework to create two database table from two classes using Entity Framework.

Entity Framework is an ORM (Object Relational Mapping).




1. Firstly i make two classes the Employee.cs and Department.cs so to map these tables in SQL Server.


2. Then i add the class EmployeeDBContext.cs. That class makes all the work to make the connection with the database  and public our objects. Aslo that class inherits the DbContext class. That class belongs to Entity Framework.


3. After that i make the class EmployeeRepository.cs with the method GetDepartments().


4. Then i add GridView Control and also a ObjectDatasource Control.


5. We run the programm and after that we can see the tables in the SQL Server.



Katsavaros Konstantinos



