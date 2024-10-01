﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Model
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
    }
}
