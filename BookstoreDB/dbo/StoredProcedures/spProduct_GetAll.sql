CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
BEGIN
	SELECT Id, ProductName, [Description], Author, ISBN, RetailPrice, QuantityInStock
	FROM dbo.[Product];
END
