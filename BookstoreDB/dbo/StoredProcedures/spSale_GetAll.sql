CREATE PROCEDURE [dbo].[spSale_GetAll]
AS
begin
	select Id, ProductId, Quantity, PurchasePrice, Total, SaleDate
	from dbo.[Sale];
end
