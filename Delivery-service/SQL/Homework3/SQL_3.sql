USE [Northwind]
GO

SELECT E.FirstName, E.LastName, T.TerritoryDescription, R.RegionDescription
  FROM [dbo].[Employees] E
  Join [dbo].[EmployeeTerritories] ET On
  E.EmployeeID = ET.EmployeeID
  Join [dbo].[Territories] T On
  ET.TerritoryID = T.TerritoryID
  Join [dbo].[Region] R On
  R.RegionID = T.RegionID
GO
