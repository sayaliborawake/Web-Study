using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAuction.Models
{
    public class Auction
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal StartPrize { get; set; }
        public decimal? CurrentPrize { get; set; }
    }
}