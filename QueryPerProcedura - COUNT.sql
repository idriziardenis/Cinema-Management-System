CREATE PROCEDURE [dbo].[usp_Booking_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Booking
END


CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Count]
AS
BEGIN
	SELECT COUNT(*) FROM CashPaymentDetails
END

CREATE PROCEDURE [dbo].[usp_Category_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Category
END
	

CREATE PROCEDURE [dbo].[usp_Chair_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Chair
END
	
CREATE PROCEDURE [dbo].[usp_ChairClass_Count]
AS
BEGIN
	SELECT COUNT(*) FROM ChairClass
END
	
CREATE PROCEDURE [dbo].[usp_Cinema_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Cinema
END
	
CREATE PROCEDURE [dbo].[usp_Client_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Client
END

CREATE PROCEDURE [dbo].[usp_ClientPremiumDetails_Count]
AS
BEGIN
	SELECT COUNT(*) FROM ClientPremiumDetails
END
	
CREATE PROCEDURE [dbo].[usp_Event_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Event
END

CREATE PROCEDURE [dbo].[usp_EventDetails_Count]
AS
BEGIN
	SELECT COUNT(*) FROM EventDetails
END
	

CREATE PROCEDURE [dbo].[usp_EventType_Count]
AS
BEGIN
	SELECT COUNT(*) FROM EventType
END
	
CREATE PROCEDURE [dbo].[usp_Genre_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Genre
END
	
CREATE PROCEDURE [dbo].[usp_Hall_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Hall
END
	
CREATE PROCEDURE [dbo].[usp_Movie_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Movie
END

CREATE PROCEDURE [dbo].[usp_Payment_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Payment
END

CREATE PROCEDURE [dbo].[usp_Role_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Role
END


CREATE PROCEDURE [dbo].[usp_Schedule_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Schedule
END
	
CREATE PROCEDURE [dbo].[usp_Technology_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Technology
END

CREATE PROCEDURE [dbo].[usp_Ticket_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Ticket
END
	

CREATE PROCEDURE [dbo].[usp_User_Count]
AS
BEGIN
	SELECT COUNT(*) FROM [User]
END

