CREATE PROCEDURE ChangePasswordAirportEmployee
	@Id int,
	@Password varchar(50)
AS
BEGIN
	UPDATE AIRPORTLOGININFO
	SET Password = @Password
	WHERE ID = @Id
END
GO
