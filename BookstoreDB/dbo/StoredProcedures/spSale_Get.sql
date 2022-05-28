CREATE PROCEDURE [dbo].[spSale_Get]
	@Id int
AS
begin
	select Id, ProductId, Quantity, PurchasePrice, Total, SaleDate
	from dbo.[Sale]
	where Id = @Id;
end