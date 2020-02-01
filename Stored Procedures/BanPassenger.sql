CREATE PROCEDURE BanPassenger
	@PassportNo char(9)
AS
BEGIN
	UPDATE PASSENGER 
	SET Status = 0
	WHERE PassportNo = @PassportNo
END
GO
