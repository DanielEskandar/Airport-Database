CREATE PROCEDURE GetPasswordAirlineEmployee
	@Id int
AS
BEGIN
	SELECT Password
	FROM AIRLINELOGININFO
	WHERE ID = @Id
END
GO
