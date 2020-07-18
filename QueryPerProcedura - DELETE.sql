CREATE PROCEDURE [dbo].[usp_Booking_Delete]
	@ID int
AS
BEGIN
	DELETE FROM Booking
	WHERE @ID = BookingID
END

CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Delete]
	@ID int
AS
BEGIN
	DELETE FROM CashPaymentDetails
	WHERE @ID = CashID
END
	

CREATE PROCEDURE [dbo].[usp_Category_Delete]
	@ID int
AS
BEGIN
	Delete FROM Category
	WHERE @ID = CategoryID
END
	

CREATE PROCEDURE [dbo].[usp_Chair_Delete]
	@ID int
AS
BEGIN
	Delete FROM Chair
	WHERE @ID = ChairID
END
	
CREATE PROCEDURE [dbo].[usp_ChairClass_Delete]
	@ID int
AS
BEGIN
	Delete FROM ChairClass
	WHERE @ID = ChairClassID
END
	
CREATE PROCEDURE [dbo].[usp_Cinema_Delete]
	@ID int
AS
BEGIN
	Delete FROM Cinema
	WHERE @ID = CinemaID
END
	
CREATE PROCEDURE [dbo].[usp_Client_Delete]
	@ID int
AS
BEGIN
	Delete FROM Client
	WHERE @ID = ClientID
END

CREATE PROCEDURE [dbo].[usp_ClientPremiumDetails_Delete]
	@ID int
AS
BEGIN
	Delete FROM ClientPremiumDetails
	WHERE @ID = ClientPremiumDetailsID
END
	
CREATE PROCEDURE [dbo].[usp_Event_Delete]
	@ID int
AS
BEGIN
	Delete FROM Event
WHERE EventID = @ID
END

CREATE PROCEDURE [dbo].[usp_EventDetails_Delete]
	@ID int
AS
BEGIN
	Delete FROM EventDetails
WHERE EventDetailsID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_EventType_Delete]
	@ID int
AS
BEGIN
	Delete FROM EventType
WHERE EventTypeID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Genre_Delete]
	@ID int
AS
BEGIN
	Delete FROM Genre
WHERE GenreID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Hall_Delete]
	@ID int
AS
BEGIN
	Delete FROM Hall
WHERE HallID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_Movie_Delete]
	@ID int
AS
BEGIN
	Delete FROM Movie
WHERE MovieID = @ID
END


CREATE PROCEDURE [dbo].[usp_Payment_Delete]
	@ID int
AS
BEGIN
	Delete FROM Payment
WHERE PaymentID = @ID
END


CREATE PROCEDURE [dbo].[usp_Role_Delete]
	@ID int
AS
BEGIN
	Delete FROM Role
WHERE RoleID = @ID
END


CREATE PROCEDURE [dbo].[usp_Schedule_Delete]
	@ID int
AS
BEGIN
	Delete FROM Schedule
WHERE ScheduleID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Technology_Delete]
	@ID int
AS
BEGIN
	Delete FROM Technology
WHERE TechnologyID = @ID
END

CREATE PROCEDURE [dbo].[usp_Ticket_Delete]
	@ID int
AS
BEGIN
	Delete FROM Ticket
WHERE TicketID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_User_Delete]
	@ID int
AS
BEGIN
	Delete FROM [User]
WHERE UserID = @ID
END
