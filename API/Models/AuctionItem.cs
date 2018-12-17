using System;
using System.Collections.Generic;
using System.Text;

namespace API.Models
{
    class AuctionItem
    {
        public int ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public double RatingPrize { get; set; }
        public double BidPrize { get; set; }
        public string BidCustomName { get; set; }
        public string BidCustomPhone { get; set; }
        public DateTime BidTimestamp { get; set; }

    }
}
