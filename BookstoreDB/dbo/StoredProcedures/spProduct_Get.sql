CREATE PROCEDURE [dbo].[spProduct_Get]
	@Id int
AS
begin
	select Id, ProductName, [Description], Author, ISBN, RetailPrice, QuantityInStock
	from dbo.[Product]
	where Id = @Id;
end
