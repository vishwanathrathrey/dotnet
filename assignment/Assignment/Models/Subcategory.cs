using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Subcategory
    {
        public Subcategory()
        {
           // Products = new HashSet<Product>();
        }

        public int Subcatid { get; set; }
        public string Subcatname { get; set; } = null!;
        public int Catid { get; set; }

       // public virtual Category Cat { get; set; } = null!;
       // public virtual ICollection<Product> Products { get; set; }
    }
}
