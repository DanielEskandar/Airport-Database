CREATE PROCEDURE UpdateEmployeeAirline
	@Id int,
	@Lname varchar(50),
	@Fname varchar(50),
	@JobTitle varchar(50),
	@Airline varchar(50)
AS
BEGIN
	UPDATE AIRLINEEMPLOYEE
	SET Lname = @Lname, Fname = @Fname, JobTitle = @JobTitle, Airline = @Airline
	WHERE ID = @Id 
END
GO
