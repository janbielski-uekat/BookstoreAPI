CREATE PROCEDURE [dbo].[spProduct_Update]
	@Id int,
	@ProductName nvarchar(100),
	@Description nvarchar(MAX),
	@Author nvarchar(200),
	@ISBN nvarchar(20),
	@RetailPrice money,
	@QuantityInStock int
AS
begin
	update dbo.[Product]
	set ProductName = @ProductName, [Description] = @Description, Author = @Author, ISBN = @ISBN, RetailPrice = @RetailPrice, QuantityInStock = @QuantityInStock
	where Id = @Id;
end
