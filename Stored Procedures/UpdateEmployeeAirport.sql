CREATE PROCEDURE UpdateEmployeeAirport
	@ID int,
	@Fname varchar(50),
	@Lname varchar(50),
	@Salary varchar(50),
	@JobTitle varchar(50),
	@Department varchar(50)
AS
BEGIN
	UPDATE AIRPORTEMPLOYEE
	SET Fname = @Fname, Lname = @Lname, Salary = @Salary,JobTitle = @JobTitle, Department = @Department 
	WHERE ID = @ID
END
GO
