USE [Northwind]
GO

SELECT Country, Region, COUNT(*) AS Count
FROM [dbo].[Suppliers]
WHERE Region IS NOT NULL
GROUP BY Country, Region
HAVING COUNT(*) > 1

GO


