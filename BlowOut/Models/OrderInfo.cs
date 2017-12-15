using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    public class OrderInfo
    {
        [Key]
        public int clientID { get; set; }
        public string clientName { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string instDesc { get; set; }
        public string instType { get; set; }
        public decimal price { get; set; }
    }
}