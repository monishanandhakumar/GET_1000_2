using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace prjMVCDay4.VM
{
    public class CustomerVM
    {
        [Key]
        public string CustomerID { get; set; } //customer.cs
        public string CompanyName { get; set; }//customer.cs

        public int OrderId { get; set; } //Order.cs

        public DateTime? OrderDate { get; set; }//Order.cs

    }
}
