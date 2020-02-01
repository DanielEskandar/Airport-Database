CREATE PROCEDURE SearchPassengerByPassport
	@PassportNo char(9)
AS
BEGIN
	SELECT PASSENGER.Fname,PASSENGER.Lname,PASSENGER.Nationality,PASSENGER.PassportNo,PASSENGER.Status
	FROM PASSENGER
	WHERE PASSENGER.PassportNo = @PassportNo
END
GO
