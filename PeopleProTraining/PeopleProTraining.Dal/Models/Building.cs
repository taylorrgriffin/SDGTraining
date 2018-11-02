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
    public partial class Building
    {
        [Key]
        public int BuildingID { get; set; }
        public string BuildingName {get; set;}
        public ICollection<Department> Departments { get; set; }
    }
}
