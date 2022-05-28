if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName, EmailAddress)
	values
	('Tim', 'Corey', 'timcorey@bookstore.com'),
	('Sue', 'Storm', 'suestorm@bookstore.com'),
	('John', 'Smith', 'johnsmith@bookstore.com'),
	('Mary', 'Jones', 'maryjones@bookstore.com')

	insert into dbo.[Product] (ProductName, [Description], RetailPrice, QuantityInStock)
	values
	('Książka 1', 'Opis książki 1', 25, 20),
	('Książka 2', 'Opis książki 2', 20, 25),
	('Książka 3', 'Opis książki 3', 50, 4),
	('Książka 4', 'Opis książki 4', 100, 11),
	('Książka 5', 'Opis książki 5', 12, 2)
end