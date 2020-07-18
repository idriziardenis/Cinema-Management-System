CREATE PROCEDURE [dbo].[usp_User_RetrieveByRole]
	@ID int
AS
BEGIN
	SELECT * 
	FROM [User]
	Where RoleID=@ID
END

CREATE PROCEDURE [dbo].[usp_Booking_RetrieveByMovie]
	@ID int
AS
BEGIN
	SELECT * 
	FROM Booking as b INNER JOIN Schedule as s ON b.ScheduleID = s.ScheduleID
END

CREATE PROCEDURE [dbo].[usp_Client_GenreCount]
	@ID int
AS
BEGIN
	SELECT COUNT(*) 
	FROM Client as c INNER JOIN Genre as g ON c.GenreID = g.GenreID
	WHERE g.GenreID = @ID
END

CREATE PROCEDURE [dbo].[usp_Client_RetrieveByGenre]
	@GenreID int
AS
BEGIN
	SELECT *
	FROM Client
	WHERE GenreID = @GenreID
END

CREATE PROCEDURE [dbo].[usp_Event_RetrieveActiveEvents]
AS
BEGIN
	SELECT *
	FROM Event as e INNER JOIN EventDetails as ed ON e.EventDetailsID = ed.EventDetailsID
	WHERE ed.EndDate > GetDate()
END

CREATE PROCEDURE [dbo].[usp_Hall_Capacity]
	@ID int
AS
BEGIN
	RETURN (Select (NoRow * NoColumn) FROM Hall WHERE HallID = @ID)
END

CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveByMovie]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE MovieID = @ID
END

CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveMoviesShowingToday]
AS
BEGIN
	SELECT * FROM Schedule WHERE StartTime >= GETDATE() AND DATEADD(day, 1, GETDATE()) >= EndTime
END

CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveSchedulesOfHall]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE HallID = @ID
END

CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveByDate]
	@Date datetime
AS
BEGIN
	SELECT * FROM Schedule WHERE Day(@Date) = Day(GetDate()) AND MONTH(@Date) = MONTH(GetDate()) AND YEAR(@Date) = YEAR(GetDate())
END

CREATE PROCEDURE [dbo].[usp_Movie_RetrieveByDate]
	@Date datetime
AS
BEGIN
	SELECT * 
	FROM Movie as m INNER JOIN Schedule as s on s.MovieID = m.MovieID
	WHERE Day(@Date) = Day(s.StartTime) AND MONTH(@Date) = MONTH(s.StartTime) AND YEAR(@Date) = YEAR(s.StartTime)
END

CREATE PROCEDURE [dbo].[usp_Schedule_ShowTimes]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE MovieID = @ID
END

CREATE PROCEDURE [dbo].[usp_Schedule_NumberOfMoviesScheduled]
	@Date datetime
AS
BEGIN
	SELECT COUNT(*) FROM Schedule WHERE Day(@Date) = Day(StartTime) AND MONTH(@Date) = MONTH(StartTime) AND YEAR(@Date) = YEAR(StartTime)
END

CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveScheduleID]
	@MovieID int,
	@HallID int,
	@StartTime datetime,
	@EndTime datetime
AS
BEGIN
	RETURN (SELECT ScheduleID FROM Schedule WHERE MovieID = @MovieID AND HallID = @HallID AND StartTime = @StartTime AND EndTime = @EndTime)
END

CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveByChairClass]
	@ID int
AS
BEGIN
	SELECT * FROM Ticket as t INNER JOIN Booking as b on t.BookingID = b.BookingID INNER JOIN Chair as c on b.ChairID = c.ChairID
	WHERE c.ChairClassID = @ID
END

CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveTodaysTickets]
AS
BEGIN
	SELECT * FROM Ticket 
	WHERE Day(Date) = Day(GetDate())
END

CREATE PROCEDURE [dbo].[usp_Ticket_NumberOfTicketsOfMovie]
	@ID int
AS
BEGIN
	SELECT COUNT(*) FROM Ticket as t INNER JOIN Booking as b ON t.BookingID = b.BookingID INNER JOIN Schedule as s on b.ScheduleID = s.ScheduleID 
	WHERE s.MovieID = @ID
END

CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveTicketsOfMovie]
	@ID int
AS
BEGIN
	SELECT * FROM Ticket as t INNER JOIN Booking as b ON t.BookingID = b.BookingID INNER JOIN Schedule as s on b.ScheduleID = s.ScheduleID 
	WHERE s.MovieID = @ID
END


