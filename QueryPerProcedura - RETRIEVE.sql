CREATE PROCEDURE [dbo].[usp_Booking_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Booking WHERE BookingID = @ID
END


CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM CashPaymentDetails WHERE CashID = @ID
END

	

CREATE PROCEDURE [dbo].[usp_Category_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Category WHERE CategoryID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_Chair_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Chair WHERE ChairID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_ChairClass_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM ChairClass WHERE ChairClassID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Cinema_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Cinema WHERE CinemaID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Client_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Client WHERE ClientID = @ID
END

CREATE PROCEDURE [dbo].[usp_ClientPremiumDetails_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM ClientPremiumDetails WHERE ClientPremiumDetailsID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Event_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Event WHERE EventID = @ID
END

CREATE PROCEDURE [dbo].[usp_EventDetails_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM EventDetails WHERE EventDetailsID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_EventType_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM EventType WHERE EventTypeID = @ID
END

CREATE PROCEDURE [dbo].[usp_EventType_RetrieveByName]
	@Name nvarchar(50)
AS
BEGIN
	SELECT * FROM EventType WHERE EventTypeID = @Name
END
	
CREATE PROCEDURE [dbo].[usp_Genre_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Genre WHERE GenreID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Hall_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Hall WHERE HallID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_Movie_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Movie WHERE MovieID = @ID
END

CREATE PROCEDURE [dbo].[usp_Movie_RetrieveByTitle]
	@Title nvarchar(50)
AS
BEGIN
	SELECT * FROM Movie WHERE Title = @Title
END
	
CREATE PROCEDURE [dbo].[usp_MovieCast_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM MovieCast WHERE MovieCastID = @ID
END


CREATE PROCEDURE [dbo].[usp_Role_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Role WHERE RoleID = @ID
END


CREATE PROCEDURE [dbo].[usp_Schedule_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE ScheduleID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Technology_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Technology WHERE TechnologyID = @ID
END

CREATE PROCEDURE [dbo].[usp_Ticket_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Ticket WHERE TicketID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_User_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM [User] WHERE UserID = @ID
END
