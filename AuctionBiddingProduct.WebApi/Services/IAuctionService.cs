using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionBiddingProduct.WebApi.Model;

namespace AuctionBiddingProduct.WebApi.Services
{
    interface IAuctionService
    {
        List<AuctionItem> GetAll();
    }
}
