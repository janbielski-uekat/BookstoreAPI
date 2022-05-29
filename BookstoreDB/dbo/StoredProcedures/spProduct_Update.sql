CREATE PROCEDURE [dbo].[spProduct_Update]
	@Id INT,
	@ProductName NVARCHAR(100),
	@Description NVARCHAR(MAX),
	@Author NVARCHAR(200),
	@ISBN NVARCHAR(20),
	@RetailPrice MONEY,
	@QuantityInStock INT
AS
BEGIN
	UPDATE dbo.[Product]
	SET ProductName = @ProductName, [Description] = @Description, Author = @Author, ISBN = @ISBN, RetailPrice = @RetailPrice, QuantityInStock = @QuantityInStock
	WHERE Id = @Id;
END
