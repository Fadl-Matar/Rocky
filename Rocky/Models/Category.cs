﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
       [DisplayName("Display Order")]
       [Range(1,int.MaxValue, ErrorMessage ="Display Order must be greater than 0")]
        public int DisplayOrder { get; set; }
    }
}
