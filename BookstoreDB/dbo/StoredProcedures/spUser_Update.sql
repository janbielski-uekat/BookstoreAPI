CREATE PROCEDURE [dbo].[spUser_Update]
	@Id int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(100)
AS
begin
	update dbo.[User]
	set FirstName = @FirstName, LastName = @LastName, EmailAddress = @EmailAddress
	where Id = @Id;
end