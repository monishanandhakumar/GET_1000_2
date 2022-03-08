﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMvcDay2.Models
{
    public class Ten_Most_Expensive_Products
    {
        [Key]
        public string TenMostExpensiveProducts { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    }
}
