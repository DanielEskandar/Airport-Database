CREATE PROCEDURE ChechForFlightExistenceAirport
	@FlightNo char(5)
AS
BEGIN
	SELECT Airline
	FROM FLIGHT
	WHERE FlightNo = @FlightNo
END
GO
