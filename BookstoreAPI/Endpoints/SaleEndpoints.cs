using BookstoreLibrary.DataAccess;
using BookstoreLibrary.Models;

namespace BookstoreAPI.Endpoints;

public static class SaleEndpoints
{
    public static void ConfigureSaleEndpoints(this WebApplication app)
    {
        app.MapGet("/Sales", GetSales);
        app.MapGet("/Sales/{id}", GetSale);
        app.MapPost("/Sales", InsertSale);
    }
    private static async Task<IResult> GetSales(ISaleData data)
    {
        try
        {
            return Results.Ok(await data.GetSales());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetSale(int id, ISaleData data)
    {
        try
        {
            var results = await data.GetSale(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertSale(SaleBasicModel sale, ISaleData saleData, IProductData productData)
    {
        try
        {
            var productBought = await productData.GetProduct(sale.ProductId);
            if(productBought == null) return Results.NotFound();
            productBought.QuantityInStock = productBought.QuantityInStock - sale.Quantity;

            SaleModel saleDetail = new SaleModel(sale.ProductId, sale.Quantity, productBought.RetailPrice, sale.Quantity * productBought.RetailPrice, DateTime.UtcNow);

            await productData.UpdateProduct(productBought);
            await saleData.InsertSale(saleDetail);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
