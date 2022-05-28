using BookstoreLibrary.DataAccess;
using BookstoreLibrary.Models;

namespace BookstoreAPI;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        //User Endpoints Mapping
        app.MapGet("/Users", GetUsers);
        app.MapGet("/Users/{id}", GetUser);
        app.MapPost("/Users", InsertUser);
        app.MapPut("/Users", UpdateUser);
        app.MapDelete("/Users", DeleteUser);

        //Product Endpoints Mapping
        app.MapGet("/Products", GetProducts);
        app.MapGet("/Products/{id}", GetProduct);
        app.MapPost("/Products", InsertProduct);
        app.MapPut("/Products", UpdateProduct);
        app.MapDelete("/Products", DeleteProduct);

        //Sale Endpoints Mapping
        app.MapGet("/Sales", GetSales);
        app.MapGet("/Sales/{id}", GetSale);
        app.MapPost("/Sales", InsertSale);
    }

    //User Endpoints Definitions
    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(await data.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        try
        {
            var results = await data.GetUser(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertUser(UserModel user, IUserData data)
    {
        try
        {
            await data.InsertUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateUser(UserModel user, IUserData data)
    {
        try
        {
            await data.UpdateUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeleteUser(int id, IUserData data)
    {
        try
        {
            await data.DeleteUser(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    //Product Endpoints Definitions

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

    //Sale Endpoints Definitions

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

    private static async Task<IResult> InsertSale(SaleModel sale, ISaleData data)
    {
        try
        {
            await data.InsertSale(sale);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
