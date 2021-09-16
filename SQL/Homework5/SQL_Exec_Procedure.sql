DECLARE @doc AS VARCHAR(1000)
SET @doc = 
		'<Bonuses>
		<Bonus>
			<BonusID>27KKK</BonusID>
			<Count>10</Count>
		</Bonus>
		</Bonuses>'

DECLARE @xmlDoc INTEGER
EXEC sp_XML_preparedocument @xmlDoc OUTPUT, @doc
EXEC [DeliveryService].[dbo].[MergeTableeeee] @xmlDoc

SELECT * FROM Bonuses