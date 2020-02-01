-- ================================================
CREATE PROCEDURE AirlineLoginVerify 
	@Username varchar(50),
	@Password varchar(50)
AS
BEGIN
	SELECT ID
	FROM AIRLINELOGININFO
	WHERE AIRLINELOGININFO.Username = Username AND AIRLINELOGININFO.Password = @Password
END
GO
