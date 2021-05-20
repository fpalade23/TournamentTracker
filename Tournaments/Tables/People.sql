CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [EmailAdress] NVARCHAR(200) NOT NULL, 
    [CellphoneNumber] VARCHAR(20) NULL 
)
