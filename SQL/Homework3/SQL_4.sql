USE [Northwind]
GO

SELECT R.*
  FROM [dbo].[Region] R
  LEFT Join [dbo].[Territories] T On
  R.RegionID = T.RegionID
  LEFT Join [dbo].[EmployeeTerritories] E On
  T.TerritoryID = E.TerritoryID 
  Group by R.RegionID, R.RegionDescription
  Having COUNT(E.EmployeeID) = 0;

GO

