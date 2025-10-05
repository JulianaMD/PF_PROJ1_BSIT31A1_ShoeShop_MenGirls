using ShoeShop.Data;
using ShoeShop.Models;
using ShoeShop.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Shoe = ShoeShop.Models.Shoe;

namespace ShoeShop.Services
{
    public class ShoeService : IShoeService
    {
        private readonly AppDbContext _context;

        public ShoeService(AppDbContext context)
        {
            _context = context;
        }

        public List<Shoe> GetAllShoes()
        {
            return _context.Shoes.ToList();
        }

        public Shoe GetById(int id)
        {
            return _context.Shoes.Find(id);
        }

        public void AddShoe(Shoe shoe)
        {
            _context.Shoes.Add(shoe);
            _context.SaveChanges();
        }

        public void UpdateShoe(Shoe shoe)
        {
            _context.Shoes.Update(shoe);
            _context.SaveChanges();
        }

        public void DeleteShoe(int id)
        {
            var shoe = _context.Shoes.Find(id);
            if (shoe != null)
            {
                _context.Shoes.Remove(shoe);
                _context.SaveChanges();
            }
        }

        List<Interfaces.Shoe> IShoeService.GetAllShoes()
        {
            throw new NotImplementedException();
        }

        Interfaces.Shoe IShoeService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IShoeService.AddShoe(Interfaces.Shoe shoe)
        {
            throw new NotImplementedException();
        }

        void IShoeService.UpdateShoe(Interfaces.Shoe shoe)
        {
            throw new NotImplementedException();
        }
    }
}