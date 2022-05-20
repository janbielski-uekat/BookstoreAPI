CREATE PROCEDURE [dbo].[spProduct_Get]
	@Id int
AS
begin
	select Id, ProductName, [Description], RetailPrice, QuantityInStock
	from dbo.[Product]
	where Id = @Id;
end
