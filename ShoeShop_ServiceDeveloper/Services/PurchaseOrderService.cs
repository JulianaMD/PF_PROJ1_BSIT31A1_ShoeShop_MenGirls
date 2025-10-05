using System;
using System.Collections.Generic;
using System.Linq;
using ShoeShop.Data;
using ShoeShop.Models;
using ShoeShop.Services.Interfaces;
using PurchaseOrder = ShoeShop.Models.PurchaseOrder;

namespace ShoeShop.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly AppDbContext _context;

        public PurchaseOrderService(AppDbContext context)
        {
            _context = context;
        }

        public List<PurchaseOrder> GetAllOrders()
        {
            return _context.PurchaseOrders
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }

        public PurchaseOrder? GetById(int id)
        {
            return _context.PurchaseOrders.Find(id);
        }

        public void AddOrder(PurchaseOrder order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order cannot be null.");
            }

            _context.PurchaseOrders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(PurchaseOrder order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "Order cannot be null.");
            }

            _context.PurchaseOrders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.PurchaseOrders.Find(id);
            if (order != null)
            {
                _context.PurchaseOrders.Remove(order);
                _context.SaveChanges();
            }
        }

        List<Interfaces.PurchaseOrder> IPurchaseOrderService.GetAllOrders()
        {
            throw new NotImplementedException();
        }

        Interfaces.PurchaseOrder IPurchaseOrderService.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IPurchaseOrderService.AddOrder(Interfaces.PurchaseOrder order)
        {
            throw new NotImplementedException();
        }

        void IPurchaseOrderService.UpdateOrder(Interfaces.PurchaseOrder order)
        {
            throw new NotImplementedException();
        }
    }
}