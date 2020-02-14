using System.Collections.Generic;
using Employee.Data;

namespace Employee.Repository
{
    public class EmployeeRepository
    {
        public static List<Employees> employees = new List<Employees>();
        static EmployeeRepository()
        {
            employees.Add(new Employees("Rohini", "fulltime", "E001", 2 ));
            employees.Add(new Employees("Megala", "fulltime", "E002", 3));
            employees.Add(new Employees("Adhav", "parttime", "E003", 1));
        }

        public IEnumerable<Employees> GetAllEmployees()
        {
            return employees;
        }
    }
}
