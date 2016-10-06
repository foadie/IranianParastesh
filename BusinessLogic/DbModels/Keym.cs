﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DbModels
{
    public class Keym
    {
        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        public string Name { get; set; }
    }
}