CREATE PROCEDURE AddEmployeeAirline
	@Id int,
	@Lname varchar(50),
	@Fname varchar(50),
	@JobTitle varchar(50),
	@Airline varchar(50)
AS
BEGIN
	INSERT INTO AIRLINEEMPLOYEE
	VALUES (@Id,@Lname,@Fname,@JobTitle,@Airline)
END
GO
