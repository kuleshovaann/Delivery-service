CREATE PROC MergeTableeeee @fileXml INTEGER
AS
BEGIN TRANSACTION

	BEGIN TRY
		CREATE TABLE NewBonus(
		BonusID VARCHAR(50),
		[Count] int)

		INSERT INTO NewBonus
		SELECT * FROM
		OPENXML (@fileXml, '/Bonuses/Bonus', 2)
		WITH
		(BonusID VARCHAR(50),
		[Count] int)

		MERGE [DeliveryService].[dbo].[Bonuses] AS N
		USING NewBonus
		ON (N.BonusID = NewBonus.BonusID)
		WHEN MATCHED
		THEN UPDATE SET N.[Count] = NewBonus.[Count]
		WHEN NOT MATCHED
		THEN INSERT VALUES (NewBonus.BonusID, NewBonus.[Count]);
	END TRY
	BEGIN CATCH
		EXEC sp_XML_removedocument @fileXml
		ROLLBACK
	END CATCH
