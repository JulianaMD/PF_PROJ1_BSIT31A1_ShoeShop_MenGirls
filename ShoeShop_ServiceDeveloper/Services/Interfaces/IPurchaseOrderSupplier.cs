namespace ShoeShop.Services.Interfaces
{
    public interface IPurchaseOrderService
    {
        List<PurchaseOrder> GetAllOrders();
        PurchaseOrder GetById(int id);
        void AddOrder(PurchaseOrder order);
        void UpdateOrder(PurchaseOrder order);
        void DeleteOrder(int id);
    }

    public class PurchaseOrder
    {
    }
}