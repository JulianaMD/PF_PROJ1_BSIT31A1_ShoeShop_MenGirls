using System.Collections.Generic;
using System.Linq;
using ShoeShop.Data;
using ShoeShop.Models;
using ShoeShop.Services.Interfaces;
using Supplier = ShoeShop.Models.Supplier;

namespace ShoeShop.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly AppDbContext _context;

        // ✅ Classic constructor format
        public SupplierService(AppDbContext context)
        {
            _context = context;
        }

        public List<Models.Supplier> GetAllSuppliers()
        {
            return _context.Suppliers.ToList();
        }

        public Supplier GetById(int id)
        {
            return _context.Suppliers.Find(id);
        }

        public void AddSupplier(Supplier supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void UpdateSupplier(Supplier supplier)
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
        }

        public void DeleteSupplier(int id)
        {
            var supplier = _context.Suppliers.Find(id);
            if (supplier != null)
            {
                _context.Suppliers.Remove(supplier);
                _context.SaveChanges();
            }
        }

        List<Interfaces.Supplier> ISupplierService.GetAllSuppliers()
        {
            throw new NotImplementedException();
        }

        Interfaces.Supplier ISupplierService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void ISupplierService.AddSupplier(Interfaces.Supplier supplier)
        {
            throw new NotImplementedException();
        }

        void ISupplierService.UpdateSupplier(Interfaces.Supplier supplier)
        {
            throw new NotImplementedException();
        }
    }
}