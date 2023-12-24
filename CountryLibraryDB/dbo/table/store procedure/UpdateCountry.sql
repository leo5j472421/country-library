CREATE PROCEDURE [dbo].[UpdateCountry]
  @Id INT,
  @Name NVARCHAR(100),
  @Language NVARCHAR(100),
  @Capital NVARCHAR(100),
  @Currency NVARCHAR(3),
  @Population INT
AS
BEGIN
  UPDATE [dbo].[Country]
  SET [Name] = @Name,
      [Language] = @Language,
      [Capital] = @Capital,
      [Currency] = @Currency,
      [Population] = @Population
  WHERE [Id] = @Id
END
