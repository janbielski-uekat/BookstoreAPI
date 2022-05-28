namespace BookstoreLibrary.Models;
public class SaleModel
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public decimal Total { get; set; }
    public DateTime SaleDate { get; set; }
}
