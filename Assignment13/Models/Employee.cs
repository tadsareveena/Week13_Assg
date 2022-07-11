﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment13.Models
{

    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EId { get; set; }
        public string EName { get; set; }

        public string EDesign { get; set; }

        public DateTime? EDOJ { get; set; }

    }
}

