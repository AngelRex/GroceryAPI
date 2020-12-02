using GroceryAPI.Dtos;
using GroceryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryAPI.Data
{
    public interface IGroceryRepo
    {
        bool SaveChanges();
        public IEnumerable<Grocery> GetAllGrocery();
        public Grocery GetGroceryByID(int Id);
        void CreateGrocery(Grocery gcy);
        void UpdateGrocery(Grocery gcy);
        void DeleteGrocery(Grocery gcy);
    }
}
