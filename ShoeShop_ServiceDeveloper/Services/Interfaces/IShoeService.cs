namespace ShoeShop.Services.Interfaces
{
    public interface IShoeService
    {
        List<Shoe> GetAllShoes();
        Shoe GetById(int id);
        void AddShoe(Shoe shoe);
        void UpdateShoe(Shoe shoe);
        void DeleteShoe(int id);
    }

    public class Shoe
    {
    }
}