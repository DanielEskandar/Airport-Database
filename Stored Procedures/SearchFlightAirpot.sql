CREATE PROCEDURE SearchFlightAirport
	@FlightNo char(5)
AS
BEGIN
	SELECT	FlightNo,ArrDep,Time,City,Airline,Terminal,Runway,PlaneType
	FROM FLIGHT
	WHERE FlightNo =  @FlightNo
END
GO
