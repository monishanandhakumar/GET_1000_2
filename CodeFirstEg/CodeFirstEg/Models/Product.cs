using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstEg.Models
{
    //table
    public class Product
    {
        [Key]
        public int pid { get; set; }
        public string pname { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public int quantity { get; set; }

    }
}
