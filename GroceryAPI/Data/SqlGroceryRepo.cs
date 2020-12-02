using GroceryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryAPI.Data
{
    public class SqlGroceryRepo : IGroceryRepo
    {
        private readonly GroceryContext _context;

        public SqlGroceryRepo(GroceryContext context)
        {
            _context = context;
        }

        public void CreateGrocery(Grocery gcy)
        {
            if (gcy== null)
            {
                throw new ArgumentNullException(nameof(gcy));
            }
            _context.Grocerys.Add(gcy);
        }

        public void DeleteGrocery(Grocery gcy)
        {
            if(gcy==null)
            {
                throw new ArgumentNullException(nameof(gcy));
            }
            _context.Grocerys.Remove(gcy);
        }

        public IEnumerable<Grocery> GetAllGrocery()
        {
            return _context.Grocerys.ToList();
        }

        public Grocery GetGroceryByID(int Id)
        {
            return _context.Grocerys.FirstOrDefault(p => p.Id == Id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >=0);
        }

        public void UpdateGrocery(Grocery gcy)
        {

        }
    }
}
