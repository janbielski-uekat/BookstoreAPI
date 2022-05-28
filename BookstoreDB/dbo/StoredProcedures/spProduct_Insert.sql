CREATE PROCEDURE [dbo].[spProduct_Insert]
	@ProductName nvarchar(100),
	@Description nvarchar(MAX),
	@Author nvarchar(200),
	@ISBN nvarchar(20),
	@RetailPrice money,
	@QuantityInStock int
AS
begin
	insert into dbo.[Product] (ProductName, [Description], Author, ISBN, RetailPrice, QuantityInStock)
	values (@ProductName, @Description, @Author, @ISBN, @RetailPrice, @QuantityInStock);
end
