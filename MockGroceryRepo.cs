using GroceryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryAPI.Data
{
    public class MockGroceryRepo : IGroceryRepo
    {
        public void CreateGrocery(Grocery gcy)
        {
            throw new NotImplementedException();
        }

        public void DeleteGrocery(Grocery gcy)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Grocery> GetAllGrocery()
        {
            var grocery = new List<Grocery>
            {
                    new Grocery
                {
                    Id = 0,
                    Name = "Kellogg Mini Wheats",
                    Description = "Product of USA",
                    Weight = 1000,
                    WarehousePrice = 9.99,
                    InstantSaving = 2.00,
                    YourCost = 7.99,
                    CurrentInventory = 300
                },
                new Grocery
                {
                    Id = 1,
                    Name = "Frank Red Hot Pepper Sauce",
                    Description = "Product of Mexico",
                    Weight = 740,
                    WarehousePrice = 9.00,
                    InstantSaving = 2.00,
                    YourCost = 7.00,
                    CurrentInventory = 150
                },
                new Grocery
                {
                    Id = 2,
                    Name = "Lipton Chicken Noodle Soup",
                    Description = "Product of Canada",
                    Weight = 1748,
                    WarehousePrice = 9.99,
                    InstantSaving = 2.00,
                    YourCost = 7.99,
                    CurrentInventory = 200
                }
            };

            return grocery;
        }

        public Grocery GetGroceryByID(int Id)
        {
            return new Grocery
            {
                //Id = 0,
                //Name = "Columbian Coffee",
                //Description = "Product of South America",
                //Weight = 1000,
                //WarehousePrice = 23.29,
                //InstantSaving = 3.29,
                //YourCost = 20.00,
                //CurrentInventory = 120
                Id = 0,
                Name = "Kellogg Mini Wheats",
                Description = "Product of USA",
                Weight = 1000,
                WarehousePrice = 9.99,
                InstantSaving = 2.00,
                YourCost = 7.99,
                CurrentInventory = 300
            };
        }

        //curl -k -i -X POST "https://localhost:44380/api/Grocery" -H "accept: */*" -d "{\"Name"\:\"Columbian Coffee"\,\"Description"\:\"Product of South America"\,\"Weight"\:\"1000"\,\"WarhousePrice"\:\"23.29"\,\"InstantSaving"\:\"2.00"\,\"YourCost"\:\"7.99"\,\"CurrentInventory"\:\"300"}"|jq 
        
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateGrocery(Grocery gcy)
        {
            throw new NotImplementedException();
        }
    }
}