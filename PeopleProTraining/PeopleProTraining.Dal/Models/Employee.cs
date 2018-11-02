using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PeopleProTraining.Dal.Models
{
    public partial class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string First_Name { get; set; }
        public string LastName { get; set; }
        public Department Department { get; set; }
    }
}
