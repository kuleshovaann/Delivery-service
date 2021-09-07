CREATE TABLE [dbo].[Dish_Rezerve](
	[DishID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Composition] [nvarchar](50) NULL,
	[Weight] [int] NOT NULL,
	[Calories] [int] NOT NULL)

INSERT INTO [dbo].[Dish_Rezerve]
SELECT *
FROM [dbo].[Dish];