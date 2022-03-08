﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMvcDay2.Models
{
    public class CustOrdersOrders
    {
        [Key]
        public int OrderID { get; set; }
       public DateTime OrderDate{get;set;}
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
    }
}
