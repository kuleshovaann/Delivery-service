CREATE PROC CreateId (@table varchar(50), @NewId varchar(50) OUTPUT)
AS
BEGIN
SET @NewId = UPPER(SUBSTRING(@table, 1, 4)) + SUBSTRING(Convert(varchar(50), NewId()), 1, 6)
END
GO

DECLARE @Id varchar(50)

EXEC CreateId 'Customer', @Id OUTPUT

INSERT INTO Customer VALUES (@Id, 'Ann', '07547895', '17 Kensington Street')

SELECT * FROM Customer