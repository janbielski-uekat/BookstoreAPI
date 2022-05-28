CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(200) NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL,
    [Author] NVARCHAR(200) NOT NULL, 
    [ISBN] NVARCHAR(20) NOT NULL,
    [RetailPrice] MONEY NOT NULL,
    [QuantityInStock] INT NOT NULL DEFAULT 1,    
)
