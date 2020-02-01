CREATE PROCEDURE UnbanPassenger
	@PassportNo char(9)
AS
BEGIN
	UPDATE PASSENGER 
	SET Status = 1
	WHERE PassportNo = @PassportNo
END
GO
