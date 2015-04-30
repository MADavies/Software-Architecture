using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ViewModels
{
    public class Order
    {
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string CardNumber { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime When { get; set; }
        public string ProductName { get; set; }
        public string ProductEan { get; set; }
        public double TotalPrice { get; set; }


    }
}