CREATE PROCEDURE ChangePasswordGovEmployee
	@Id int,
	@Password varchar(50)
AS
BEGIN
	UPDATE GOVLOGINFO
	SET Password = @Password
	WHERE ID = @Id
END
GO
