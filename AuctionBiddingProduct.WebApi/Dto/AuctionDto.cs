using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionBiddingProduct.WebApi.Dto
{
    public class AuctionDto
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public DateTime BiddingEndDate { get; set; }
    }
}
