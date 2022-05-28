CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	select Id, ProductName, [Description], Author, ISBN, RetailPrice, QuantityInStock
	from dbo.[Product];
end
