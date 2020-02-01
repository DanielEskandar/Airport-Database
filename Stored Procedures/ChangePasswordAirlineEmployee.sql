CREATE PROCEDURE ChangePasswordAirlineEmployee
	@Id int,
	@Password varchar(50)
AS
BEGIN
	UPDATE AIRLINELOGININFO
	SET Password = @Password
	WHERE ID = @Id
END
GO
