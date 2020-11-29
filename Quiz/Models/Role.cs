﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz.Models
{
    [Table("Roles")]
    public class Role : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
