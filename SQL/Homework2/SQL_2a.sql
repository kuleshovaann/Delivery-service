USE [DeliveryService]
GO

UPDATE [dbo].[Dish]
   SET Composition = 'check with your waiter'
   WHERE Composition is null
GO


