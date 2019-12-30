CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL  IDENTITY(1,1) PRIMARY KEY, 
    [UserName] NVARCHAR(MAX) NULL, 
    [Password] NVARCHAR(MAX) NULL, 
)

CREATE TABLE [dbo].[Questions]
(
	[Id] INT NOT NULL  IDENTITY(1,1) PRIMARY KEY, 
    [QuestionString] NVARCHAR(MAX) NULL, 
    [Answer] INT NULL, 
    [OptionOne] NVARCHAR(MAX) NULL,
    [OptionTwo] NVARCHAR(MAX) NULL,
    [OptionThree] NVARCHAR(MAX) NULL,
    [OptionFour] NVARCHAR(MAX) NULL
)
