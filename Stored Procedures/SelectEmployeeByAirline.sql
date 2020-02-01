CREATE PROCEDURE SelectEmployeeByAirline
	@Airline varchar(50)
AS
BEGIN
	SELECT *
	FROM AIRLINEEMPLOYEE
	WHERE AIRLINEEMPLOYEE.Airline = @Airline
END
GO
