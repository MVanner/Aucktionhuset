using System;
using System.Collections.Generic;
using System.Text;

namespace API.Models
{
    class Bid
    {
        public int ItemNumber { get; set; }
        public double Prize { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
    }
}
