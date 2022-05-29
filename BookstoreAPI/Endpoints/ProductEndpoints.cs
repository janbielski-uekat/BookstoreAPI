using BookstoreLibrary.DataAccess;
using BookstoreLibrary.Models;
using System.Linq;

namespace BookstoreAPI.Endpoints;

public static class ProductEndpoints
{
    public static void ConfigureProductEndpoints(this WebApplication app)
    {
        app.MapGet("/Products", GetProducts);
        app.MapGet("/Products/{id}", GetProduct);
        app.MapGet("/Products/SearchByName", GetProductByName);
        app.MapGet("/Products/SearchByAuthor", GetProductByAuthor);
        app.MapPost("/Products", InsertProduct);
        app.MapPut("/Products", UpdateProduct);
        app.MapDelete("/Products", DeleteProduct);
    }
    private static async Task<IResult> GetProducts(IProductData data)
    {
        try
        {
            return Results.Ok(await data.GetProducts());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProduct(int id, IProductData data)
    {
        try
        {
            var results = await data.GetProduct(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProductByName(string searchedName, IProductData data)
    {
        try
        {
            var products = await data.GetProducts();
            var results = products.Where(p => p.ProductName.ToLower().Contains(searchedName.ToLower()));
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetProductByAuthor(string searchedAuthor, IProductData data)
    {
        try
        {
            var products = await data.GetProducts();
            var results = products.Where(p => p.Author.ToLower().Contains(searchedAuthor.ToLower()));
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertProduct(ProductModel product, IProductData data)
    {
        try
        {
            await data.InsertProduct(product);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateProduct(ProductModel product, IProductData data)
    {
        try
        {
            await data.UpdateProduct(product);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteProduct(int id, IProductData data)
    {
        try
        {
            await data.DeleteProduct(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
