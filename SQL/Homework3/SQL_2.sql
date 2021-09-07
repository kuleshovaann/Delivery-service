USE [Northwind]
GO

SELECT C.CategoryName, MAX(P.UnitPrice) as MaxPr
  FROM [dbo].[Categories] as C
  Join [dbo].[Products] as P On
  C.CategoryID = P.CategoryID
  Group by C.CategoryName

GO
