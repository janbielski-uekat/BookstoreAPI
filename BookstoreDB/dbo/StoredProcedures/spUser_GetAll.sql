CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
begin
	select Id, FirstName, LastName, EmailAddress, CreatedDate
	from dbo.[User];
end
