using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
    }
    public class DepartmentMetaData
    {
        public int DepartmentID;

        [Required]
        public string DepartmentName;
        public Building Location;
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
