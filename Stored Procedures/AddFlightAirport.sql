CREATE PROCEDURE AddFlightAirport 
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
	INSERT INTO FLIGHT 
	VALUES(@FlightNo,@ArrDep,@Time,@City,@Airline,@Terminal,@Runway,@PlaneType)
END
GO
