using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Models
{
    public partial class Building
    {
        public int BuildingID;
        public string BuildingName;
        public ICollection<Department> Departments;
    }
}
