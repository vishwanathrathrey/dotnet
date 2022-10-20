using System;
using System.Collections.Generic;

namespace Assignment.Models
{
    public partial class Order
    {
        public int Oid { get; set; }
        public int Qty { get; set; }
        public string DateOfPurchase { get; set; } = null!;
        public int Custid { get; set; }
        public int Pid { get; set; }

       // public virtual Customer Cust { get; set; } = null!;
        //public virtual Product PidNavigation { get; set; } = null!;
    }
}
