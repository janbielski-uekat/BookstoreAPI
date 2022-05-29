CREATE PROCEDURE [dbo].[spProduct_Insert]
	@ProductName NVARCHAR(100),
	@Description NVARCHAR(MAX),
	@Author NVARCHAR(200),
	@ISBN NVARCHAR(20),
	@RetailPrice MONEY,
	@QuantityInStock INT
AS
BEGIN
	INSERT INTO dbo.[Product] (ProductName, [Description], Author, ISBN, RetailPrice, QuantityInStock)
	VALUES (@ProductName, @Description, @Author, @ISBN, @RetailPrice, @QuantityInStock);
END
