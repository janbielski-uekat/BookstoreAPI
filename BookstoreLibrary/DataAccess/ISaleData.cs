namespace BookstoreLibrary.DataAccess;

public interface ISaleData
{
    Task<SaleModel?> GetSale(int id);
    Task<IEnumerable<SaleModel>> GetSales();
    Task InsertSale(SaleModel sale);
}