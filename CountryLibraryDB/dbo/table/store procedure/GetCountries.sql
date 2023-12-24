CREATE PROCEDURE [dbo].[GetCountries]
AS
BEGIN
  SELECT ID , Name , Language, Capital,Currency,Population
  FROM Country
END