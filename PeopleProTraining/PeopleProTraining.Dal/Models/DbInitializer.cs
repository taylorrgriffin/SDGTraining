using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using PeopleProTraining.Dal.Models;

namespace PeopleProTraining.Dal
{
    public class DbInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            var employees = new List<Employee>
            {
            new Employee{First_Name="Roger",LastName="Dunder"},
            new Employee{First_Name="Tyler",LastName="Faught"},
            new Employee{First_Name="Robert",LastName="Copper"}
            };
            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
            var departments = new List<Department>
            {
            new Department{DepartmentName="Physics"},
            new Department{DepartmentName="Engineering"},
            new Department{DepartmentName="Math"}
            };
            departments.ForEach(d => context.Departments.Add(d));
            context.SaveChanges();
            var buildings = new List<Building>
            {
            new Building{BuildingName="Johnson Hall"},
            new Building{BuildingName="Milne Computer Center"},
            new Building{BuildingName="Kelley Engineering Center"}
            };
            buildings.ForEach(b => context.Buildings.Add(b));
            context.SaveChanges();
        }
    }
}
