using System;
using System.Collections.Generic;
using System.Text;

namespace Linq5practice.EntityClass
{
    public class SalesOrderDetail
    {
        public int SalesOrderID { get; set; }
        public short OrderQty { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineTotal { get; set; }
    }
}
