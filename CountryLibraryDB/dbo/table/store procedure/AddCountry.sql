CREATE PROCEDURE [dbo].[AddCountry]
  @Name NVARCHAR(100),
  @Language NVARCHAR(100),
  @Capital NVARCHAR(100),
  @Currency NVARCHAR(3),
  @Population INT
AS
BEGIN
  INSERT INTO [dbo].[Country]
  VALUES (@Name, @Language, @Capital, @Currency, @Population)
END
