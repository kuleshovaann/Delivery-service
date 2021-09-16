USE [Northwind]
GO

SELECT *
  FROM [dbo].[Products]
  Where UnitPrice > (Select AVG(UnitPrice) from [dbo].[Products])

GO


