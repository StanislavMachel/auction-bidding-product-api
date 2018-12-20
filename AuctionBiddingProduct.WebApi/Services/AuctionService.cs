using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuctionBiddingProduct.WebApi.Model;
using Bogus;
using Bogus.DataSets;


namespace AuctionBiddingProduct.WebApi.Services
{
    public class AuctionService : IAuctionService
    {
        public List<AuctionItem> GetAll()
        {
           


            var categories = new List<Category>()
            {
                new Category() {Id = new Guid("40589ec5-dda4-4681-a968-22f48056fe57"), Name = "Books"},
                new Category() {Id = new Guid("98daeaba-a3e4-4c78-8490-eab2a1e1bfbd"), Name = "Movies"},
                new Category() {Id = new Guid("e24900a4-71e0-48cd-9512-a49f5e1449be"), Name = "Music"},
                new Category() {Id = new Guid("5c7bde65-da72-4053-8deb-bc0f6d2b3697"), Name = "Games"},
                new Category() {Id = new Guid("2b9abf3f-0bb9-4c5d-8af8-1c0493707c86"), Name = "Electronics"},
                new Category() {Id = new Guid("393d5362-6d0c-4dfa-919f-f94eecdf0d66"), Name = "Home"},
                new Category() {Id = new Guid("cbe0aa60-5aaf-4c18-840e-69deb25fff20"), Name = "Garden"},
                new Category() {Id = new Guid("f35d9c4d-49d1-4316-9f20-7ba2be770f5c"), Name = "Tools"},
                new Category() {Id = new Guid("2717713a-20c4-405e-81a6-5962676d4e09"), Name = "Grocery"},
                new Category() {Id = new Guid("94fb0fe2-1ea7-413b-ac96-0e766d528ccb"), Name = "Health"},
                new Category() {Id = new Guid("8cb730da-7bfb-4014-afc6-70a29920a142"), Name = "Beauty"},
                new Category() {Id = new Guid("d894f14d-7906-4947-ac93-cae45a84d0b4"), Name = "Toys"},
                new Category() {Id = new Guid("88b12baf-a36c-48dd-9b0c-f730716aadc5"), Name = "Kids"},
                new Category() {Id = new Guid("d26e7510-ac4a-42fd-8a14-ec8629d9ad46"), Name = "Baby"},
                new Category() {Id = new Guid("080e7372-a960-433a-9db3-33cac2dc4a3d"), Name = "Clothing"},
                new Category() {Id = new Guid("c9097b98-bd62-4ffa-b546-2635000fc255"), Name = "Shoes"},
                new Category() {Id = new Guid("6e9574fd-4dff-4a7a-bd6a-bfda127abb85"), Name = "Jewelery"},
                new Category() {Id = new Guid("45700fc2-b463-4784-a379-9019d3baa2d2"), Name = "Sports"},
                new Category() {Id = new Guid("7ae3b48a-5e2d-41ad-b37c-390e449f9faf"), Name = "Outdoors"},
                new Category() {Id = new Guid("c2613044-5d9e-40b9-8bdd-ad9844519032"), Name = "Automotive"},
                new Category() {Id = new Guid("01789fb1-a7b9-4e36-8653-a2bf538b2db3"), Name = "Industrial"},
            };


            var products = new List<Product>()
            {
                //Books




                new Product(){Name = "Chair", Category = categories.First(x=>x.Name == "Home")},
                new Product(){Name = "Car", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Computer", Category = categories.First(x=>x.Name == "Electronics")},
                new Product(){Name = "Keyboard", Category = categories.First(x=>x.Name == "Electronics")},
                new Product(){Name = "Mouse", Category = categories.First(x=>x.Name == "Electronics")},
                new Product(){Name = "Bike",Category = categories.First(x=>x.Name == "Sports")},
                new Product(){Name = "Ball", Category = categories.First(x=>x.Name == "Sports")},
                new Product(){Name = "Gloves", Category = categories.First(x=>x.Name == "Clothing")},
                new Product(){Name = "Pants", Category = categories.First(x=>x.Name == "Clothing")},
                new Product(){Name = "Shirt", Category = categories.First(x=>x.Name == "Clothing")},
                new Product(){Name = "Table", Category = categories.First(x=>x.Name == "Home")},
                new Product(){Name = "Shoes", Category = categories.First(x=>x.Name == "Clothing")},
                new Product(){Name = "Hat", Category = categories.First(x=>x.Name == "Clothing")},
                new Product(){Name = "Towels", Category = categories.First(x=>x.Name == "Home")},
                new Product(){Name = "Soap", Category = categories.First(x=>x.Name == "Home")},
                new Product(){Name = "Tuna", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Chicken", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Fish", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Cheese", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Pizza", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Salad", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Sausages", Category = categories.First(x=>x.Name == "Automotive")},
                new Product(){Name = "Chips", Category = categories.First(x=>x.Name == "Automotive")},
            };



            //var faker = new Faker();


            //faker.Commerce.


            //var fakeProducts = new Faker<Product>()
            //    .Rules((f, p) =>
            //    {
            //        p.Id = new Guid();

            //        var productName = f.Commerce.ProductName();
            //        p.Name = productName;
            //        var foo = f.Commerce.Categories();
            //        p.Description = $"{f.Commerce.ProductAdjective()} {productName}";
            //    });


            //var fakeAuctionItems = new Faker<AuctionItem>()
            //    .RuleFor(ai => ai.Id, Guid.NewGuid)
            //    .RuleFor(ai => ai.Product, f => fakeProducts.Generate());



            //var auctionItems = fakeAuctionItems.Generate(10);
            //return auctionItems;
            return new List<AuctionItem>();
        }
    }
}
