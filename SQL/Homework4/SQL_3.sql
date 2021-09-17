CREATE FUNCTION UniqueID (@table varchar(50), @id varchar(50))
RETURNS varchar(50)
BEGIN
	RETURN UPPER(SUBSTRING(@table, 1, 4)) + SUBSTRING(Convert(varchar(50), @id), 1, 3)
END
GO

INSERT INTO Customer VALUES (dbo.UniqueId ('Customer', NewId()), 'Mike', '0865467887', '26 Kings Road')

SELECT * FROM Customer
