-- =============================================
CREATE PROCEDURE DeleteFlightAirport
	@FlightNo char(5)
AS
BEGIN
	DELETE FROM FLIGHT
	WHERE FlightNo = @FlightNo
END
GO
