namespace BookstoreLibrary.Models;
public class ProductModel
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public decimal RetailPrice { get; set; }
    public int QuantityInStock { get; set; }
}
