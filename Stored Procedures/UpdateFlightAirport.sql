CREATE PROCEDURE UpdateFlightAirport
	@FlightNo char(5),
	@ArrDep bit,
	@Time time,
	@City varchar(50),
	@Airline varchar(50),
	@Terminal char(2),
	@Runway varchar(10),
	@PlaneType varchar(10)
AS
BEGIN
	UPDATE FLIGHT
	SET ArrDep = @ArrDep, Time = @Time, City = @City, Airline = @Airline, Terminal = @Terminal, Runway = @Runway,PlaneType = @PlaneType
	WHERE FlightNo = @FlightNo
END
GO
