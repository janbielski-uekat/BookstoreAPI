CREATE PROCEDURE [dbo].[spProduct_Get]
	@Id int
AS
BEGIN
	SELECT Id, ProductName, [Description], Author, ISBN, RetailPrice, QuantityInStock
	FROM dbo.[Product]
	WHERE Id = @Id;
END
