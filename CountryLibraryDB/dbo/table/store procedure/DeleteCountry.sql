CREATE PROCEDURE [dbo].[DeleteCountry]
  @Id INT
AS
BEGIN
  DELETE FROM [dbo].[Country]
  WHERE [Id] = @Id
END