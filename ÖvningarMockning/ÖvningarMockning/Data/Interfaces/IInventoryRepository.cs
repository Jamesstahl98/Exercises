namespace ÖvningarMockning.Data.Interfaces
{
    public interface IInventoryRepository
    {
        int GetStock(string productId);
    }
}
