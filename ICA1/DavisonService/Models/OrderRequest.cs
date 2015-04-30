using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DavisonService.Models
{
    public class OrderRequest
    {
        public string AccountName { get; set; }
        public string CardNumber { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
    }
}