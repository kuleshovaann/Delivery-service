USE [Northwind]
GO

SELECT LastName, FirstName, City, Region
  FROM [dbo].[Employees]
  Where Region = 'WA'
  EXCEPT
  SELECT LastName, FirstName, City, Region
  FROM [dbo].[Employees]
  Where City = 'Tacoma'

GO


