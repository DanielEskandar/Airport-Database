CREATE PROCEDURE GetPasswordAirportEmployee
	@Id int
AS
BEGIN
	SELECT Password 
	FROM AIRPORTLOGININFO
	WHERE ID = @Id
END
GO
