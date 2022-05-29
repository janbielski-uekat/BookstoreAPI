CREATE TABLE [dbo].[Product]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ProductName] NVARCHAR(200) NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Author] NVARCHAR(200) NULL, 
    [ISBN] NVARCHAR(50) NULL, 
    [RetailPrice] MONEY NULL, 
    [QuantityInStock] INT NULL
)
