CREATE PROCEDURE SelectFlightByFlightNoAirport
	@FlightNo char(5)
AS
BEGIN
	SELECT * FROM FLIGHT WHERE FlightNo = @FlightNo
END
GO
