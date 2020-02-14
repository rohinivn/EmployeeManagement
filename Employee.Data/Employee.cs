using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Data
{
    public class Employees
    {
        public string EmployeeName { get; set; }
        public string WorkType { get; set; }
        public string Id { get; set; }
        public byte Experience { get; set; }
        public Employees(string name,string workType,string id,byte experience)
        {
            this.EmployeeName = name;
            this.WorkType = workType;
            this.Id = id;
            this.Experience = experience;
        }
        
    }
}
