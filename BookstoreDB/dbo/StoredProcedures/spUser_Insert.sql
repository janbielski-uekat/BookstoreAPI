CREATE PROCEDURE [dbo].[spUser_Insert]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@EmailAddress nvarchar(100)
AS
begin
	insert into dbo.[User] (FirstName, LastName, EmailAddress)
	values (@FirstName, @LastName, @EmailAddress);
end
