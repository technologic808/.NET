CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL  IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(MAX) NULL, 
    [Age] INT NULL, 
    [Phone] NVARCHAR(50) NULL
)
