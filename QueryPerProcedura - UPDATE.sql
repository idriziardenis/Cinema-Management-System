CREATE PROCEDURE [dbo].[usp_Booking_Update]
	@ID int,
	@ClientID int,
	@ChairID int,
	@ScheduleID int,
	@UpdateBy int
AS
BEGIN
UPDATE Booking SET
	ClientID = @ClientID,
	ChairID = @ChairID,
	ScheduleID = @ScheduleID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE BookingID = @ID
END

CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Update]
	@ID int,
	@Amount decimal(18, 0),
	@UpdateBy int
AS
BEGIN
Update CashPaymentDetails SET
	Amount = @Amount,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE CashID = @ID
END


	

CREATE PROCEDURE [dbo].[usp_Category_Update]
	@ID int,
	@Name nvarchar(50),
	@UpdateBy int
AS
BEGIN
Update Category SET
	Name = @Name,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE CategoryID = @ID
END
	

Create PROCEDURE [dbo].[usp_Chair_Update]
	@ID int,
	@Column int,
	@Row int,
	@isBooked bit,
	@UpdateBy int
AS
BEGIN
Update Chair SET
	[Column] = @Column,
	Row = @Row,
	isBooked = @isBooked,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE ChairID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_ChairClass_Update]
	@ID int,
	@Name nvarchar(50),
	@PriceIncreasePercentage decimal(18, 0),
	@UpdateBy int
AS
BEGIN
Update ChairClass SET
	Name = @Name,
	PriceIncreasePercentage = @PriceIncreasePercentage,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE ChairClassID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Cinema_Update]
	@ID int,
	@Adress nvarchar(50),
	@FiscalNumber nvarchar(50),
	@CinemaLogoPath nvarchar(50),
	@UpdateBy int
AS
BEGIN
Update Cinema SET
	Adress = @Adress,
	FiscalNumber = @FiscalNumber,
	CinemaLogoPath = @CinemaLogoPath,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE CinemaID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Client_Update]
	@ID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Birthday datetime,
	@GenreID int,
	@isPremium bit,
	@ClientPremiumDetailsID int,
	@UpdateBy int
AS
BEGIN
Update Client SET
	FirstName = @FirstName,
	LastName = @LastName,
	UserName = @UserName,
	Password = @Password,
	Birthday = @Birthday,
	GenreID = @GenreID,
	isPremium = @isPremium,
	ClientPremiumDetailsID = @ClientPremiumDetailsID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE ClientID = @ID
END

CREATE PROCEDURE [dbo].[usp_ClientPremiumDetails_Update]
	@ID int,
	@SubscribedDate datetime,
	@ExpireDate datetime,
	@Discount decimal(18, 0),
	@UpdateBy int
AS
BEGIN
Update ClientPremiumDetails SET
	SubscribedDate = @SubscribedDate,
	ExpireDate = @ExpireDate,
	Discount = @Discount,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE ClientPremiumDetailsID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Event_Update]
	@ID int,
	@EventDetailsID int,
	@MovieID int,
	@UpdateBy int
AS
BEGIN
Update Event SET
	EventDetailsID = @EventDetailsID,
	MovieID = @MovieID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE EventID = @ID
END

CREATE PROCEDURE [dbo].[usp_EventDetails_Update]
	@ID int,
	@Title nvarchar(50),
	@EventTypeID int,
	@Description nvarchar(150),
	@Sales decimal(18, 0),
	@ImagePath nvarchar(50),
	@StartDate datetime,
	@EndDate datetime,
	@UpdateBy int
AS
BEGIN
Update EventDetails SET
	Title = @Title,
	EventTypeID = @EventTypeID,
	Description = @Description,
	Sales = @Sales,
	ImagePath = @ImagePath,
	StartDate = @StartDate,
	EndDate = @EndDate,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE EventDetailsID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_EventType_Update]
	@ID int,
	@Type nvarchar(50),
	@UpdateBy int
AS
BEGIN
Update EventType SET
	Type = @Type,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE EventTypeID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Genre_Update]
	@ID int,
	@Genre nvarchar(50),
	@UpdateBy int
AS
BEGIN
Update Genre SET
	Genre = @Genre,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE GenreID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Hall_Update]
	@ID int,
	@Name nvarchar(50),
	@NoRow int,
	@NoColumn int,
	@TechnolyID int,
	@UpdateBy int
AS
BEGIN
Update Hall SET
	Name = @Name,
	NoRow = @NoRow,
	NoColumn = @NoColumn,
	TechnolyID = @TechnolyID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE HallID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_Movie_Update]
	@ID int,
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
	@UpdateBy int
AS
BEGIN
Update Movie SET
	Title = @Title,
	Description = @Description,
	ImagePath = @ImagePath,
	ReleaseDate = @ReleaseDate,
	CategoryID = @CategoryID,
	isActive = @isActive,
	Price=@Price,
	Duration=@Duration,
	TrailerLink=@TrailerLink,
	MinimumAge=@MinimumAge,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE MovieID = @ID
END


CREATE PROCEDURE [dbo].[usp_Payment_Update]
	@ID int,
	@CashPaymentDetails int,
	@UpdateBy int
AS
BEGIN
Update Payment SET
	CashPaymentDetails = @CashPaymentDetails,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE PaymentID = @ID
END


CREATE PROCEDURE [dbo].[usp_Role_Update]
	@ID int,
	@RoleName nvarchar(50),
	@UpdateBy int
AS
BEGIN
Update Role SET
	RoleName = @RoleName,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE RoleID = @ID
END


CREATE PROCEDURE [dbo].[usp_Schedule_Update]
	@ID int,
	@HallID int,
	@MovieID int,
	@StartTime datetime,
	@EndTime datetime,
	@Description nvarchar(MAX),
	@isMaintained bit,
	@UpdateBy int
AS
BEGIN
Update Schedule SET
	HallID = @HallID,
	MovieID = @MovieID,
	StartTime = @StartTime,
	EndTime=@EndTime,
	Description=@Description,
	isMaintained=@isMaintained,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE ScheduleID = @ID
END
	
CREATE PROCEDURE [dbo].[usp_Technology_Update]
	@ID int,
	@Type nvarchar(50),
	@UpdateBy int
AS
BEGIN
Update Technology SET
	Type = @Type,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE TechnologyID = @ID
END

CREATE PROCEDURE [dbo].[usp_Ticket_Update]
	@ID int,
	@CinemaID int,
	@BookingID int,
	@PaymentID int,
	@Price decimal(18, 0),
	@VAT decimal(18, 0),
	@Date datetime,
	@UpdateBy int
AS
BEGIN
Update Ticket SET
	CinemaID = @CinemaID,
	BookingID = @BookingID,
	PaymentID = @PaymentID,
	Price = @Price,
	VAT=@VAT,
	Date=@Date,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE TicketID = @ID
END
	

CREATE PROCEDURE [dbo].[usp_User_Update]
	@ID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@RoleID int,
	@UpdateBy int
AS
BEGIN
Update [User] SET
	FirstName = @FirstName,
	LastName = @LastName,
	UserName = @UserName,
	Password=@Password,
	RoleID = @RoleID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE UserID = @ID
END


