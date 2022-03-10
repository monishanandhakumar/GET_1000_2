using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace prjMVCDay4.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryId { get; set; }
        [Required (ErrorMessage = "Please enter CategoryName")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage = "Please enter Description")]
        [StringLength(10,ErrorMessage ="Description Length should be maxium 10")]
        public string Description { get; set; }
        public byte[] Picture { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
