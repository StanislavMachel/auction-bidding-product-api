using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionBiddingProduct.WebApi.Model
{
    public class AuctionItem
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public DateTime BiddingEndDate { get; set; }
    }
}
