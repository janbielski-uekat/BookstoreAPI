if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName, EmailAddress)
	values
	('Tim', 'Corey', 'timcorey@bookstore.com'),
	('Sue', 'Storm', 'suestorm@bookstore.com'),
	('John', 'Smith', 'johnsmith@bookstore.com'),
	('Mary', 'Jones', 'maryjones@bookstore.com')
end