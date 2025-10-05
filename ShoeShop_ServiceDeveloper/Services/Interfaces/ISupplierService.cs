namespace ShoeShop.Services.Interfaces
{
    public interface ISupplierService
    {
        List<Supplier> GetAllSuppliers();
        Supplier GetById(int id);
        void AddSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int id);
    }

    public class Supplier
    {
    }
}