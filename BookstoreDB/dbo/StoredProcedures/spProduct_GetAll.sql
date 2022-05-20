CREATE PROCEDURE [dbo].[spProduct_GetAll]
AS
begin
	select Id, ProductName, [Description], RetailPrice, QuantityInStock
	from dbo.[Product];
end
