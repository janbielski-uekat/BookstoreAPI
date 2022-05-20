CREATE PROCEDURE [dbo].[spProduct_Update]
	@Id int,
	@ProductName nvarchar(100),
	@Description nvarchar(MAX),
	@RetailPrice money,
	@QuantityInStock int
AS
begin
	update dbo.[Product]
	set ProductName = @ProductName, [Description] = @Description, RetailPrice = @RetailPrice, QuantityInStock = @QuantityInStock
	where Id = @Id;
end
