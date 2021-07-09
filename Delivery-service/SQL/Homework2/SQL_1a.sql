USE [DeliveryService]
GO

INSERT INTO [dbo].[Dish]
           ([DishID]
           ,[Name]
           ,[Price]
           ,[Composition]
           ,[Weight]
           ,[Calories])
     VALUES
           (1, 'Coffee', 40.0, 'Instant coffee', 150, 10),
		   (2, 'Black tea', 30.0, 'Ceylon long leaf tea', 250, 1),
		   (3, 'Green tea', 30.0, 'Green tea leaves', 250, 1),
		   (4, 'Lemonade', 50.0, 'Water, lemons or lemon juice, sugar', 350, 60),
		   (5, 'Juice', 65.0, 'Fresh fruits', 300, 35)
GO


