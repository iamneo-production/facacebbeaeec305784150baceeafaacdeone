using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetmicroserviceone
{
    public class Order
    {
        public int OrderID{get; set;}
        public string CustomerID{get; set;}
        public string ProductID{get; set;}
        public DateTime OrderDate{get; set;}
        public string OrderStatus{get; set;}
        public string DeliveryAddress{get; set;}
    }
}