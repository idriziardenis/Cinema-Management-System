CREATE PROCEDURE [dbo].[usp_Booking_Create]
	@ClientID int,
	@ChairID int,
	@ScheduleID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Booking VALUES
	(@ClientID,@ChairID,@ScheduleID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Create]
	@Amount decimal(18, 0),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO CashPaymentDetails VALUES
	(@Amount,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)


CREATE PROCEDURE [dbo].[usp_Category_Create]
	@Name nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Category VALUES
	(@Name,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Chair_Create]
	@Column int,
	@Row int,
	@ChairClassID int,
	@isBooked bit,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Chair VALUES
	(@Column,@Row,@ChairClassID,@isBooked,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_ChairClass_Create]
	@Name nvarchar(50),
	@PriceIncreasePercentage decimal(18, 0),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO ChairClass VALUES
	(@Name,@PriceIncreasePercentage,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Cinema_Create]
	@Adress nvarchar(50),
	@FiscalNumber nvarchar(50),
	@CinemaLogoPath nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Cinema VALUES
	(@Adress,@FiscalNumber,@CinemaLogoPath,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Client_Create]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Birthday datetime,
	@GenreID int,
	@isPremium bit,
	@ClientPremiumDetailsID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Client VALUES
	(@FirstName,@LastName,@UserName,@Password,@Birthday,@GenreID,@isPremium,@ClientPremiumDetailsID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_ClientPremiumDetails_Create]
	@SubscribedDate datetime,
	@ExpireDate datetime,
	@Discount decimal(18, 0),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO ClientPremiumDetails VALUES
	(@SubscribedDate,@ExpireDate,@Discount,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Event_Create]
	@EventDetailsID int,
	@MovieID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Event VALUES
	(@EventDetailsID,@MovieID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_EventDetails_Create]
	@Title nvarchar(50),
	@EventTypeID int,
	@Description nvarchar(150),
	@Sales decimal(18, 0),
	@ImagePath nvarchar(50),
	@StartDate datetime,
	@EndDate datetime,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO EventDetails VALUES
	(@Title,@EventTypeID,@Description,@Sales,@ImagePath,@StartDate,@EndDate,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_EventType_Create]
	@Type nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO EventType VALUES
	(@Type,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Genre_Create]
	@Genre nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Genre VALUES
	(@Genre,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Hall_Create]
	@Name nvarchar(50),
	@NoRow int,
	@NoColumn int,
	@TechnologyID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Hall VALUES
	(@Name,@NoRow,@NoColumn,@TechnologyID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Movie_Create]
	@Title nvarchar(50),
	@Description nvarchar(max),
	@ImagePath nvarchar(max),
	@ReleaseDate datetime,
	@CategoryID int,
	@isActive bit,
	@Price money,
	@Duration int,
	@TrailerLink nvarchar(50),
	@MinimumAge int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Movie VALUES
	(@Title,@Description,@ImagePath,@ReleaseDate,@isActive,@isActive,@Price,@Duration,@TrailerLink,@MinimumAge,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)


CREATE PROCEDURE [dbo].[usp_Payment_Create]
	@CashPaymentDetails int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Payment VALUES
	(@CashPaymentDetails,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Role_Create]
	@RoleName nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Role VALUES
	(@RoleName,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Schedule_Create]
	@HallID int,
	@MovieID int,
	@StartTime datetime,
	@EndTime datetime,
	@Description nvarchar(MAX),
	@isMaintained bit,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Schedule VALUES
	(@HallID,@MovieID,@StartTime,@EndTime,@Description,@isMaintained,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Technology_Create]
	@Type nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Technology VALUES
	(@Type,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

CREATE PROCEDURE [dbo].[usp_Ticket_Create]
	@CinemaID int,
	@BookingID int,
	@PaymentID int,
	@Price decimal(18, 0),
	@VAT decimal(18, 0),
	@Date datetime,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO Ticket VALUES
	(@CinemaID,@BookingID,@PaymentID,@Price,@VAT,@Date,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)

ALTER PROCEDURE [dbo].[usp_User_Create]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@RoleID int,
	@LastLoginDate datetime,
	@LastPasswordChangeDate datetime,
	@IsPasswordChanged bit,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime,
	@UpdateNo int
AS
	INSERT INTO [User] VALUES
	(@FirstName,@LastName,@UserName,@Password,@RoleID,@LastLoginDate,@LastPasswordChangeDate,@IsPasswordChanged,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,@UpdateNo)