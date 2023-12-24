CREATE TABLE [dbo].[Country]
(
  [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  [Name] NVARCHAR(100),
  [Languages] NVARCHAR(100),
  [Capital] NVARCHAR(100),
  [Currency] NVARCHAR(3),
  [Population] INT
)
