USE [AirportDB]
GO
/****** Object:  StoredProcedure [dbo].[AirportLoginVerify]    Script Date: 12/21/2019 8:16:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[AirportLoginVerify] 
	@Username varchar(50),
	@Password varchar(50)
	
AS
BEGIN
	SELECT [LevelAccess],[AIRPORTEMPLOYEE].ID
	FROM AIRPORTLOGININFO,AIRPORTEMPLOYEE
	WHERE Username = @Username and @Password = Password and AIRPORTLOGININFO.ID = AIRPORTEMPLOYEE.ID
END
