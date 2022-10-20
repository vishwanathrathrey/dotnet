using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Product
    {
        public Product()
        {
          //  Orders = new HashSet<Order>();
        }

        public int Pid { get; set; }
        public string Pname { get; set; } = null!;
        public double Price { get; set; }
        public int Qty { get; set; }
        public int Subcatid { get; set; }

        //public virtual Subcategory Subcat { get; set; } = null!;
        //public virtual ICollection<Order> Orders { get; set; }
    }
}
