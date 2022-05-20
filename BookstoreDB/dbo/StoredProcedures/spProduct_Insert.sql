CREATE PROCEDURE [dbo].[spProduct_Insert]
	@ProductName nvarchar(100),
	@Description nvarchar(MAX),
	@RetailPrice money,
	@QuantityInStock int
AS
begin
	insert into dbo.[Product] (ProductName, [Description], RetailPrice, QuantityInStock)
	values (@ProductName, @Description, @RetailPrice, @QuantityInStock);
end
