CREATE PROCEDURE SelectFlightByAirline
	@Airline varchar(50)
AS
BEGIN
	SELECT *
	FROM FLIGHT
	WHERE FLIGHT.Airline = @Airline
END
GO
