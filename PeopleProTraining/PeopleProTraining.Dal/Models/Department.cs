using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Models
{
    public partial class Department
    {
        public int DepartmentID;
        public string DepartmentName;
        public Building Location;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
