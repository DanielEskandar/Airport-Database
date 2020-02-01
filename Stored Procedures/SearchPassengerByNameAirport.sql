CREATE PROCEDURE SearchPassengerByNameAirport 
	@Fname varchar(50),
	@Lname varchar(50)
AS
BEGIN
	SELECT PASSENGER.Fname,PASSENGER.Lname,PASSENGER.Nationality,PASSENGER.PassportNo,PASSENGER.Status
	FROM PASSENGER
	WHERE PASSENGER.Fname = @Fname AND PASSENGER.Lname = @Lname
END
GO
