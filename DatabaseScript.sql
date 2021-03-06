USE [master]
GO
/****** Object:  Database [CinemaManagement]    Script Date: 7/18/2020 5:42:06 PM ******/
CREATE DATABASE [CinemaManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MenagjimiKinemas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MenagjimiKinemas.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MenagjimiKinemas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\MenagjimiKinemas_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CinemaManagement] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CinemaManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CinemaManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CinemaManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CinemaManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CinemaManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CinemaManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CinemaManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CinemaManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CinemaManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CinemaManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CinemaManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CinemaManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CinemaManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CinemaManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CinemaManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CinemaManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CinemaManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CinemaManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CinemaManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CinemaManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CinemaManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CinemaManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CinemaManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CinemaManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CinemaManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CinemaManagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CinemaManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [CinemaManagement]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 7/18/2020 5:42:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[ChairID] [int] NOT NULL,
	[ScheduleID] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Booking_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Booking_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_Booking_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CashPaymentDetails]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CashPaymentDetails](
	[CashID] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_CashPaymentDetails_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_CashPaymentDetails_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_CashPaymentDetails_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_CashPaymentDetails] PRIMARY KEY CLUSTERED 
(
	[CashID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Category_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Category_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_Category_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Chair]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chair](
	[ChairID] [int] IDENTITY(1,1) NOT NULL,
	[Column] [int] NOT NULL,
	[Row] [int] NOT NULL,
	[isBooked] [bit] NOT NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Chair_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL CONSTRAINT [DF_Chair_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Chair_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Chair] PRIMARY KEY CLUSTERED 
(
	[ChairID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [RC_Chair] UNIQUE NONCLUSTERED 
(
	[Row] ASC,
	[Column] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChairClass]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChairClass](
	[ChairClassID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[PriceIncreasePercentage] [decimal](18, 0) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_ChairClass_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_ChairClass_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_ChairClass_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_ChairPosition] PRIMARY KEY CLUSTERED 
(
	[ChairClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cinema]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cinema](
	[CinemaID] [int] IDENTITY(1,1) NOT NULL,
	[Adress] [nvarchar](50) NOT NULL,
	[FiscalNumber] [nvarchar](50) NOT NULL,
	[CinemaLogoPath] [nvarchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Cinema_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Cinema_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_Cinema_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Cinema] PRIMARY KEY CLUSTERED 
(
	[CinemaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Birthday] [datetime] NULL,
	[GenreID] [int] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Client_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Client_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_Client_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Event]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Sales] [decimal](18, 0) NOT NULL,
	[EventTypeID] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[MovieID] [int] NOT NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Event_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL CONSTRAINT [DF_Event_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Event_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventDetails]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventDetails](
	[EventDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[EventTypeID] [int] NOT NULL,
	[Description] [nvarchar](150) NULL,
	[Sales] [decimal](18, 0) NOT NULL,
	[ImagePath] [nvarchar](50) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[UpdateNo] [int] NOT NULL,
 CONSTRAINT [PK_EventDetails] PRIMARY KEY CLUSTERED 
(
	[EventDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EventType]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventType](
	[EventTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_EventType_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_EventType_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_EventType_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_EventType] PRIMARY KEY CLUSTERED 
(
	[EventTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Genre]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[Genre] [nvarchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Genre_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Genre_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hall]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hall](
	[HallID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[NoRow] [int] NOT NULL,
	[NoColumn] [int] NOT NULL,
	[TechnologyID] [int] NOT NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Hall_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL CONSTRAINT [DF_Hall_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Hall_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Hall] PRIMARY KEY CLUSTERED 
(
	[HallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Movie]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movie](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[ImagePath] [nvarchar](max) NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[isActive] [bit] NOT NULL,
	[Price] [money] NOT NULL,
	[Duration] [int] NOT NULL,
	[TrailerLink] [nvarchar](50) NULL,
	[MinimumAge] [int] NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Movie_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL CONSTRAINT [DF_Movie_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Movie_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Movie] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[CashPaymentDetails] [int] NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Payment_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Payment_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Payment_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Role_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Role_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_Role_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedule](
	[ScheduleID] [int] IDENTITY(1,1) NOT NULL,
	[HallID] [int] NULL,
	[MovieID] [int] NOT NULL,
	[StartTime] [datetime] NOT NULL,
	[EndTime] [datetime] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[isMaintained] [bit] NOT NULL CONSTRAINT [DF_Schedule_isMaintained]  DEFAULT ((1)),
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Schedule_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL CONSTRAINT [DF_Schedule_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Schedule_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED 
(
	[ScheduleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Technology]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Technology](
	[TechnologyID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_Technology_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_Technology_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL,
 CONSTRAINT [PK_Technology] PRIMARY KEY CLUSTERED 
(
	[TechnologyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ticket]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ticket](
	[TicketID] [int] IDENTITY(1,1) NOT NULL,
	[CinemaID] [int] NOT NULL,
	[BookingID] [int] NOT NULL,
	[PaymentID] [int] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[VAT] [decimal](18, 0) NOT NULL,
	[Date] [datetime] NOT NULL,
	[InsertBy] [int] NOT NULL,
	[InsertDate] [datetime] NOT NULL CONSTRAINT [DF_Ticket_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NOT NULL,
	[UpdateDate] [datetime] NOT NULL CONSTRAINT [DF_Ticket_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NOT NULL CONSTRAINT [DF_Ticket_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_TicketID] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
	[LastLoginDate] [datetime] NULL,
	[LastPasswordChangeDate] [datetime] NULL,
	[IsPasswordChanged] [bit] NULL,
	[InsertBy] [int] NULL,
	[InsertDate] [datetime] NULL CONSTRAINT [DF_User_InsertDate]  DEFAULT (getdate()),
	[UpdateBy] [int] NULL,
	[UpdateDate] [datetime] NULL CONSTRAINT [DF_User_UpdateDate]  DEFAULT (getdate()),
	[UpdateNo] [int] NULL CONSTRAINT [DF_User_UpdateNo]  DEFAULT ((0)),
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[EventDetails] ADD  CONSTRAINT [DF_EventDetails_InsertDate]  DEFAULT (getdate()) FOR [InsertDate]
GO
ALTER TABLE [dbo].[EventDetails] ADD  CONSTRAINT [DF_EventDetails_UpdateDate]  DEFAULT (getdate()) FOR [UpdateDate]
GO
ALTER TABLE [dbo].[EventDetails] ADD  CONSTRAINT [DF_EventDetails_UpdateNo]  DEFAULT ((0)) FOR [UpdateNo]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Chair] FOREIGN KEY([ChairID])
REFERENCES [dbo].[Chair] ([ChairID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Chair]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Client]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Schedule] FOREIGN KEY([ScheduleID])
REFERENCES [dbo].[Schedule] ([ScheduleID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Schedule]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Genre] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genre] ([GenreID])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Genre]
GO
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Movie] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Movie]
GO
ALTER TABLE [dbo].[EventDetails]  WITH CHECK ADD  CONSTRAINT [FK_EventDetails_EventType] FOREIGN KEY([EventTypeID])
REFERENCES [dbo].[EventType] ([EventTypeID])
GO
ALTER TABLE [dbo].[EventDetails] CHECK CONSTRAINT [FK_EventDetails_EventType]
GO
ALTER TABLE [dbo].[Hall]  WITH CHECK ADD  CONSTRAINT [FK_Hall_Technology] FOREIGN KEY([TechnologyID])
REFERENCES [dbo].[Technology] ([TechnologyID])
GO
ALTER TABLE [dbo].[Hall] CHECK CONSTRAINT [FK_Hall_Technology]
GO
ALTER TABLE [dbo].[Movie]  WITH CHECK ADD  CONSTRAINT [FK_Movie_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Movie] CHECK CONSTRAINT [FK_Movie_Category]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_CashPaymentDetails] FOREIGN KEY([CashPaymentDetails])
REFERENCES [dbo].[CashPaymentDetails] ([CashID])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_CashPaymentDetails]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Hall] FOREIGN KEY([HallID])
REFERENCES [dbo].[Hall] ([HallID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Hall]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Movie] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movie] ([MovieID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Movie]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_TicketID_Booking] FOREIGN KEY([BookingID])
REFERENCES [dbo].[Booking] ([BookingID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_TicketID_Booking]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_TicketID_Cinema] FOREIGN KEY([CinemaID])
REFERENCES [dbo].[Cinema] ([CinemaID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_TicketID_Cinema]
GO
ALTER TABLE [dbo].[Ticket]  WITH CHECK ADD  CONSTRAINT [FK_TicketID_Payment] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[Payment] ([PaymentID])
GO
ALTER TABLE [dbo].[Ticket] CHECK CONSTRAINT [FK_TicketID_Payment]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Booking_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Booking
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Booking_Create]
	@ClientID int,
	@ChairID int,
	@ScheduleID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Booking VALUES
	(@ClientID,@ChairID,@ScheduleID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Booking_Delete]
	@ID int
AS
BEGIN
	DELETE FROM Booking
	WHERE @ID = BookingID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Booking_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Booking WHERE BookingID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Booking_RetrieveALL]

AS
BEGIN
	SELECT * FROM Booking
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_RetrieveByChair]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_Booking_RetrieveByChair]
@ID int
AS
BEGIN
	SELECT * FROM Booking
	Where ChairID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_RetrieveByChairAndSchedule]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_Booking_RetrieveByChairAndSchedule]
@ChairID int,
@ScheduleID int
AS
BEGIN
	SELECT * FROM Booking
	Where ChairID = @ChairID and ScheduleID = @ScheduleID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_RetrieveByMovie]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Booking_RetrieveByMovie]
	@ID int
AS
BEGIN
	SELECT * 
	FROM Booking as b INNER JOIN Schedule as s ON b.ScheduleID = s.ScheduleID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_RetrieveBySchedule]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_Booking_RetrieveBySchedule]
@ID int
AS
BEGIN
	SELECT * FROM Booking
	Where ScheduleID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Booking_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_CashPaymentDetails_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Count]
AS
BEGIN
	SELECT COUNT(*) FROM CashPaymentDetails
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CashPaymentDetails_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Create]
	@Amount decimal(18, 0),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO CashPaymentDetails VALUES
	(@Amount,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_CashPaymentDetails_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Delete]
	@ID int
AS
BEGIN
	DELETE FROM CashPaymentDetails
	WHERE @ID = CashID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CashPaymentDetails_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM CashPaymentDetails WHERE CashID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CashPaymentDetails_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_CashPaymentDetails_RetrieveALL]
AS
BEGIN
	SELECT * FROM CashPaymentDetails
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CashPaymentDetails_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Category_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Category_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Category
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Category_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Category_Create]
	@Name nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Category VALUES
	(@Name,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Category_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Category_Delete]
	@ID int
AS
BEGIN
	Delete FROM Category
	WHERE @ID = CategoryID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Category_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Category_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Category WHERE CategoryID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Category_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Category_RetrieveALL]
AS
BEGIN
	SELECT * FROM Category
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Category_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Chair
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_Create]
	@Column int,
	@Row int,
	@isBooked bit,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Chair VALUES
	(@Column,@Row,@isBooked,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_Delete]
	@ID int
AS
BEGIN
	Delete FROM Chair
	WHERE @ID = ChairID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Chair WHERE ChairID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_RetrieveALL]
AS
BEGIN
	SELECT * FROM Chair
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_RetrieveByRC]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_RetrieveByRC]
	@Row int,
	@Column int
AS
BEGIN
	SELECT * FROM Chair WHERE [Row] = @Row AND [Column] = @Column
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_RetrieveByRowColumn]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_Chair_RetrieveByRowColumn]
	@Row int,
	@Column int
AS
BEGIN
	SELECT * FROM Chair WHERE Row = @Row and [Column] = @Column
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Chair_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Chair_Update]
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
GO
/****** Object:  StoredProcedure [dbo].[usp_ChairClass_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChairClass_Count]
AS
BEGIN
	SELECT COUNT(*) FROM ChairClass
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ChairClass_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChairClass_Create]
	@Name nvarchar(50),
	@PriceIncreasePercentage decimal(18, 0),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO ChairClass VALUES
	(@Name,@PriceIncreasePercentage,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)

GO
/****** Object:  StoredProcedure [dbo].[usp_ChairClass_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChairClass_Delete]
	@ID int
AS
BEGIN
	Delete FROM ChairClass
	WHERE @ID = ChairClassID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ChairClass_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChairClass_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM ChairClass WHERE ChairClassID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ChairClass_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_ChairClass_RetrieveALL]
AS
BEGIN
	SELECT * FROM ChairClass
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ChairClass_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Cinema_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Cinema_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Cinema
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Cinema_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Cinema_Create]
	@Adress nvarchar(50),
	@FiscalNumber nvarchar(50),
	@CinemaLogoPath nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Cinema VALUES
	(@Adress,@FiscalNumber,@CinemaLogoPath,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Cinema_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Cinema_Delete]
	@ID int
AS
BEGIN
	Delete FROM Cinema
	WHERE @ID = CinemaID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Cinema_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Cinema_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Cinema WHERE CinemaID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Cinema_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Cinema_RetrieveALL]
AS
BEGIN
	SELECT * FROM Cinema
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Cinema_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Client
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_Create]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Birthday datetime,
	@GenreID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Client VALUES
	(@FirstName,@LastName,@UserName,@Password,@Birthday,@GenreID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)

GO
/****** Object:  StoredProcedure [dbo].[usp_Client_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_Delete]
	@ID int
AS
BEGIN
	Delete FROM Client
	WHERE @ID = ClientID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_GenreCount]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_GenreCount]
	@ID int
AS
BEGIN
	SELECT COUNT(*) 
	FROM Client as c INNER JOIN Genre as g ON c.GenreID = g.GenreID
	WHERE g.GenreID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Client WHERE ClientID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_RetrieveALL]
AS
BEGIN
	SELECT * FROM Client
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_RetrieveByGenre]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_RetrieveByGenre]
	@GenreID int
AS
BEGIN
	SELECT *
	FROM Client
	WHERE GenreID = @GenreID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Client_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Client_Update]
	@ID int,
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@UserName nvarchar(50),
	@Password nvarchar(50),
	@Birthday datetime,
	@GenreID int,
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
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE ClientID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Event
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_Create]
	@Title nvarchar(50),
	@EventTypeID int,
	@Description nvarchar(MAX),
	@Sales decimal(18, 0),
	@ImagePath nvarchar(MAX),
	@StartDate datetime,
	@EndDate datetime,
	@MovieID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO [Event] VALUES
	(@Title,@Description,@Sales,@EventTypeID,@ImagePath,@StartDate,@EndDate,@MovieID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_Delete]
	@ID int
AS
BEGIN
	Delete FROM Event
WHERE EventID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Event WHERE EventID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_RetrieveActiveEvents]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_RetrieveActiveEvents]
AS
BEGIN
	SELECT *
	FROM Event as E
	WHERE E.EndDate > GetDate()
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_RetrieveALL]
AS
BEGIN
	SELECT * FROM Event
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_RetrieveByType]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[usp_Event_RetrieveByType]
@ID int
AS
BEGIN
	SELECT * FROM Event
	WHERE EventTypeID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Event_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Event_Update]
	@ID int,
	@MovieID int,
	@Title nvarchar(50),
	@EventTypeID int,
	@Description nvarchar(150),
	@Sales decimal(18, 0),
	@ImagePath nvarchar(max),
	@StartDate datetime,
	@EndDate datetime,
	@UpdateBy int
AS
BEGIN
Update Event SET
	Title = @Title,
	EventTypeID = @EventTypeID,
	Description = @Description,
	Sales = @Sales,
	ImagePath = @ImagePath,
	StartDate = @StartDate,
	EndDate = @EndDate,
	MovieID = @MovieID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE EventID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventDetails_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventDetails_Count]
AS
BEGIN
	SELECT COUNT(*) FROM EventDetails
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventDetails_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventDetails_Create]
	@Title nvarchar(50),
	@EventTypeID int,
	@Description nvarchar(150),
	@Sales decimal(18, 0),
	@ImagePath nvarchar(50),
	@InsertBy int,
	@StartDate datetime,
	@EndDate datetime,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO EventDetails VALUES
	(@Title,@EventTypeID,@Description,@Sales,@ImagePath,@StartDate,@EndDate,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)


GO
/****** Object:  StoredProcedure [dbo].[usp_EventDetails_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventDetails_Delete]
	@ID int
AS
BEGIN
	Delete FROM EventDetails
WHERE EventDetailsID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventDetails_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventDetails_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM EventDetails WHERE EventDetailsID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventDetails_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventDetails_RetrieveALL]
AS
BEGIN
	SELECT * FROM EventDetails
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventDetails_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventType_Count]
AS
BEGIN
	SELECT COUNT(*) FROM EventType
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventType_Create]
	@Type nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO EventType VALUES
	(@Type,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventType_Delete]
	@ID int
AS
BEGIN
	Delete FROM EventType
WHERE EventTypeID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventType_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM EventType WHERE EventTypeID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventType_RetrieveALL]
AS
BEGIN
	SELECT * FROM EventType
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_RetrieveByName]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_EventType_RetrieveByName]
	@Name nvarchar(50)
AS
BEGIN
	SELECT * FROM EventType WHERE EventTypeID = @Name
END
GO
/****** Object:  StoredProcedure [dbo].[usp_EventType_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Genre_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Genre_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Genre
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Genre_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Genre_Create]
	@Genre nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Genre VALUES
	(@Genre,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Genre_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Genre_Delete]
	@ID int
AS
BEGIN
	Delete FROM Genre
WHERE GenreID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Genre_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Genre_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Genre WHERE GenreID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Genre_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Genre_RetrieveALL]
AS
BEGIN
	SELECT * FROM Genre
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Genre_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_Capacity]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_Capacity]
	@ID int
AS
BEGIN
	RETURN (Select (NoRow * NoColumn) FROM Hall WHERE HallID = @ID)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Hall
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_Create]
	@Name nvarchar(50),
	@NoRow int,
	@NoColumn int,
	@TechnologyID int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Hall VALUES
	(@Name,@NoRow,@NoColumn,@TechnologyID,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_Delete]
	@ID int
AS
BEGIN
	Delete FROM Hall
WHERE HallID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Hall WHERE HallID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_RetrieveALL]
AS
BEGIN
	SELECT * FROM Hall
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_RetrieveByTechnology]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_RetrieveByTechnology]
	@ID int
AS
BEGIN
	Select * FROM Hall WHERE TechnologyID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Hall_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Hall_Update]
	@ID int,
	@Name nvarchar(50),
	@NoRow int,
	@NoColumn int,
	@TechnologyID int,
	@UpdateBy int
AS
BEGIN
Update Hall SET
	Name = @Name,
	NoRow = @NoRow,
	NoColumn = @NoColumn,
	TechnologyID = @TechnologyID,
	UpdateBy = @UpdateBy,
	UpdateDate = GETDATE(),
	UpdateNo = UpdateNo + 1
WHERE HallID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Movie_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Movie
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
	@UpdateDate datetime
AS
	INSERT INTO Movie VALUES
	(@Title,@Description,@ImagePath,@ReleaseDate,@CategoryID,@isActive,@Price,@Duration,@TrailerLink,@MinimumAge,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)

GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Movie_Delete]
	@ID int
AS
BEGIN
	Delete FROM Movie
WHERE MovieID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Movie_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Movie WHERE MovieID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Movie_RetrieveALL]
AS
BEGIN
	SELECT * FROM Movie
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_RetrieveByDate]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Movie_RetrieveByDate]
	@Date datetime
AS
BEGIN
	SELECT * 
	FROM Movie as m INNER JOIN Schedule as s on s.MovieID = m.MovieID
	WHERE Day(@Date) = Day(s.StartTime) AND MONTH(@Date) = MONTH(s.StartTime) AND YEAR(@Date) = YEAR(s.StartTime)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_RetrieveByTitle]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Movie_RetrieveByTitle]
	@Title nvarchar(50)
AS
BEGIN
	SELECT * FROM Movie WHERE Title = @Title
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Movie_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Payment_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Payment_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Payment
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Payment_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Payment_Create]
	@CashPaymentDetails int,
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Payment VALUES
	(@CashPaymentDetails,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Payment_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Payment_Delete]
	@ID int
AS
BEGIN
	Delete FROM Payment
WHERE PaymentID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Payment_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Payment_RetrieveALL]
AS
BEGIN
	SELECT * FROM Payment
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Payment_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Role_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Role
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Role_Create]
	@RoleName nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Role VALUES
	(@RoleName,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Role_Delete]
	@ID int
AS
BEGIN
	Delete FROM Role
WHERE RoleID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Role_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Role WHERE RoleID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Role_RetrieveALL]
AS
BEGIN
	SELECT * FROM Role
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Role_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Schedule
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

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
	@UpdateDate datetime
AS
	INSERT INTO Schedule VALUES
	(@HallID,@MovieID,@StartTime,@EndTime,@Description,@isMaintained,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_Delete]
	@ID int
AS
BEGIN
	Delete FROM Schedule
WHERE ScheduleID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_MoviesPerDate]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_MoviesPerDate]
	@Date datetime
AS
BEGIN
	SELECT COUNT(*) FROM Schedule WHERE Day(@Date) = Day(GetDate()) AND MONTH(@Date) = MONTH(GetDate()) AND YEAR(@Date) = YEAR(GetDate())
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_NumberOfMoviesScheduled]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_NumberOfMoviesScheduled]
	@Date datetime
AS
BEGIN
	SELECT COUNT(*) FROM Schedule WHERE Day(@Date) = Day(StartTime) AND MONTH(@Date) = MONTH(StartTime) AND YEAR(@Date) = YEAR(StartTime)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE ScheduleID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveALL]
AS
BEGIN
	SELECT * FROM Schedule
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_RetrieveByDate]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveByDate]
	@Date datetime
AS
BEGIN
	SELECT * FROM Schedule WHERE Day(@Date) = Day(GetDate()) AND MONTH(@Date) = MONTH(GetDate()) AND YEAR(@Date) = YEAR(GetDate())
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_RetrieveByMovie]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveByMovie]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE MovieID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_RetrieveMoviesShowingToday]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveMoviesShowingToday]
AS
BEGIN
	SELECT * FROM Schedule WHERE StartTime >= GETDATE() AND DATEADD(day, 1, GETDATE()) >= EndTime
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_RetrieveScheduleID]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveScheduleID]
	@MovieID int,
	@HallID int,
	@StartTime datetime,
	@EndTime datetime
AS
BEGIN
	RETURN (SELECT ScheduleID FROM Schedule WHERE MovieID = @MovieID AND HallID = @HallID AND StartTime = @StartTime AND EndTime = @EndTime)
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_RetrieveSchedulesOfHall]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_RetrieveSchedulesOfHall]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE HallID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_ShowTimes]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Schedule_ShowTimes]
	@ID int
AS
BEGIN
	SELECT * FROM Schedule WHERE MovieID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Schedule_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Technology_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Technology_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Technology
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Technology_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Technology_Create]
	@Type nvarchar(50),
	@InsertBy int,
	@InsertDate datetime,
	@UpdateBy int,
	@UpdateDate datetime
AS
	INSERT INTO Technology VALUES
	(@Type,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Technology_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Technology_Delete]
	@ID int
AS
BEGIN
	Delete FROM Technology
WHERE TechnologyID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Technology_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Technology_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Technology WHERE TechnologyID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Technology_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Technology_RetrieveALL]
AS
BEGIN
	SELECT * FROM Technology
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Technology_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_Count]
AS
BEGIN
	SELECT COUNT(*) FROM Ticket
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
	@UpdateDate datetime
AS
	INSERT INTO Ticket VALUES
	(@CinemaID,@BookingID,@PaymentID,@Price,@VAT,@Date,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_Delete]
	@ID int
AS
BEGIN
	Delete FROM Ticket
WHERE TicketID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_NumberOfTicketsOfMovie]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_NumberOfTicketsOfMovie]
	@ID int
AS
BEGIN
	SELECT COUNT(*) FROM Ticket as t INNER JOIN Booking as b ON t.BookingID = b.BookingID INNER JOIN Schedule as s on b.ScheduleID = s.ScheduleID 
	WHERE s.MovieID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM Ticket WHERE TicketID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveALL]
AS
BEGIN
	SELECT * FROM Ticket
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_RetrieveByChairClass]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveByChairClass]
	@ID int
AS
BEGIN
	SELECT * FROM Ticket as t INNER JOIN Booking as b on t.BookingID = b.BookingID INNER JOIN Chair as c on b.ChairID = c.ChairID
	WHERE c.ChairClassID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_RetrieveTicketsOfMovie]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveTicketsOfMovie]
	@ID int
AS
BEGIN
	SELECT * FROM Ticket as t INNER JOIN Booking as b ON t.BookingID = b.BookingID INNER JOIN Schedule as s on b.ScheduleID = s.ScheduleID 
	WHERE s.MovieID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_RetrieveTodaysTickets]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_Ticket_RetrieveTodaysTickets]
AS
BEGIN
	SELECT * FROM Ticket 
	WHERE Day(Date) = Day(GetDate())
END
GO
/****** Object:  StoredProcedure [dbo].[usp_Ticket_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Count]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_Count]
AS
BEGIN
	SELECT COUNT(*) FROM [User]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Create]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_Create]
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
	@UpdateDate datetime
AS
	INSERT INTO [User] VALUES
	(@FirstName,@LastName,@UserName,@Password,@RoleID,@LastLoginDate,@LastPasswordChangeDate,@IsPasswordChanged,@InsertBy,@InsertDate,@UpdateBy,@UpdateDate,default)

GO
/****** Object:  StoredProcedure [dbo].[usp_User_Delete]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_Delete]
	@ID int
AS
BEGIN
	Delete FROM [User]
WHERE UserID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Login]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_Login]
	@UserName nvarchar(50),
	@Password nvarchar(50)
AS
BEGIN
	SELECT * FROM [User] 
	WHERE UserName = @UserName and Password = @Password
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Retrieve]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_Retrieve]
	@ID int
AS
BEGIN
	SELECT * FROM [User] WHERE UserID = @ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_RetrieveALL]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_RetrieveALL]
AS
BEGIN
	SELECT * FROM [User]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_RetrieveByRole]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_RetrieveByRole]
	@ID int
AS
BEGIN
	SELECT * 
	FROM [User]
	Where RoleID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_User_Update]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
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



GO
/****** Object:  StoredProcedure [dbo].[usp_User_UpdateActivity]    Script Date: 7/18/2020 5:42:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[usp_User_UpdateActivity]
	@ID int,
	@LastLoginDate datetime,
	@LastPasswordChangeDate datetime,
	@IsPasswordChanged bit
AS
BEGIN
Update [User] SET
	LastLoginDate = @LastLoginDate,
	LastPasswordChangeDate = @LastPasswordChangeDate,
	IsPasswordChanged = @IsPasswordChanged
WHERE UserID = @ID
END

GO
USE [master]
GO
ALTER DATABASE [CinemaManagement] SET  READ_WRITE 
GO
