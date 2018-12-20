using System;
using System.Collections.Generic;
using System.Text;
using AuctionBiddingProduct.WebApi.Services;
using Xunit;

namespace Auction.UnitTests.Services
{

    public class AuctionServiceTests
    {
        [Fact]
        public void test()
        {
            var auctionService = new AuctionService();
            auctionService.GetAll();
        }
    }
}
