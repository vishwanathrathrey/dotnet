using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Customer
    {
        public Customer()
        {
            //Orders = new HashSet<Order>();
        }

        public int Custid { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Phone { get; set; }

        //public virtual ICollection<Order> Orders { get; set; }
    }
}
