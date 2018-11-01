﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleProTraining.Dal.Models
{
    [MetadataType(typeof(BuildingMetaData))]
    public partial class Building
    {
    }
    public class BuildingMetaData
    {
        public int BuildingID;

        [Required]
        public string BuildingName;
        public ICollection<Department> Departments;
    }
}
