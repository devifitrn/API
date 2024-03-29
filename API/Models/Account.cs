﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("Account")]
    public class Account
    {
        [Key, Required]
        public string NIK { get; set; } 
        [Required]
        public string Password { get; set; }
        public Employee Employee { get; set; }
        public Profiling Profiling { get; set; }
    }
}
