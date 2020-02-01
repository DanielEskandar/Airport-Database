CREATE PROCEDURE GovLoginVerify 
	@Username varchar(50),
	@Password varchar(50)
AS
BEGIN
	SELECT ID
	FROM GOVLOGINFO
	WHERE GOVLOGINFO.ID = @Username AND GOVLOGINFO.Password = @Password
END
GO
