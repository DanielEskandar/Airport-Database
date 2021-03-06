USE [AirportDB]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployeeAirport]    Script Date: 12/22/2019 9:19:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UpdateEmployeeAirport]
	@ID int,
	@Fname varchar(50),
	@Lname varchar(50),
	@Salary int,
	@JobTitle varchar(50),
	@Department varchar(50)
AS
BEGIN
	UPDATE AIRPORTEMPLOYEE
	SET Fname = @Fname, Lname = @Lname, Salary = @Salary,JobTitle = @JobTitle, Department = @Department 
	WHERE ID = @ID
END
