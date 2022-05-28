using DataAccess.DbAccess;

namespace BookstoreLibrary.DataAccess;
public class SaleData : ISaleData
{
    private readonly ISqlDataAccess _db;
    public SaleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<SaleModel>> GetSales() =>
        _db.LoadData<SaleModel, dynamic>("dbo.spSale_GetAll", new { });

    public async Task<SaleModel?> GetSale(int id)
    {
        var results = await _db.LoadData<SaleModel, dynamic>(
            "dbo.spSale_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertSale(SaleModel sale) =>
        _db.SaveData("dbo.spSale_Insert", new { sale.ProductId, sale.Quantity, sale.PurchasePrice, sale.Total, sale.SaleDate });
}
