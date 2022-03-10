using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjMVCDay4.MyModel
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public int Price{ get; set; }
        public string Description { get; set; }

        public List<string> BookType { get; set; }
    }
}
