CREATE PROCEDURE [dbo].[spSale_Insert]
	@ProductId int,
	@Quantity int,
	@PurchasePrice money,
	@Total money,
	@SaleDate datetime2 = getutcdate
AS
begin
	insert into dbo.[Sale] (ProductId, Quantity, PurchasePrice, Total, SaleDate)
	values (@ProductId, @Quantity, @PurchasePrice, @Total, @SaleDate);
end
