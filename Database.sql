USE [master]
GO
/****** Object:  Database [ATM2]    Script Date: 7/15/2017 1:55:20 PM ******/
CREATE DATABASE [ATM2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ATM2', FILENAME = N'C:\Projects\ATM2\ATM2\Database\ATM2.mdf' , SIZE = 2695168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ATM2_log', FILENAME = N'C:\Projects\ATM2\ATM2\Database\ATM2_log.ldf' , SIZE = 504KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO
ALTER DATABASE [ATM2] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ATM2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ATM2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ATM2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ATM2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ATM2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ATM2] SET ARITHABORT OFF 
GO
ALTER DATABASE [ATM2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ATM2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ATM2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ATM2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ATM2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ATM2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ATM2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ATM2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ATM2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ATM2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ATM2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ATM2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ATM2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ATM2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ATM2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ATM2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ATM2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ATM2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ATM2] SET  MULTI_USER 
GO
ALTER DATABASE [ATM2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ATM2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ATM2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ATM2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ATM2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ATM2] SET QUERY_STORE = OFF
GO
USE [ATM2]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ATM2]
GO
/****** Object:  UserDefinedFunction [dbo].[G2J]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[G2J] ( @intDate DATETIME, @Format NVARCHAR(max)) 
RETURNS NVARCHAR(max)
BEGIN
/* Format Rules: (پنجشنبه 7 اردیبهشت 1394)
ChandShanbe -> پنجشنبه (روز هفته به حروف)
ChandShanbeAdadi -> 6 (روز هفته به عدد)
Rooz -> 7 (چندمین روز از ماه)
Rooz2 -> 07 (چندمین روز از ماه دو کاراکتری)
Maah -> 2 (چندمین ماه از سال)
Maah2 -> 02 (چندمین ماه از سال دو کاراکتری)
MaahHarfi -> اردیبهشت (نام ماه به حروف)
Saal -> 1394 (سال چهار کاراکتری)
Saal2 -> 94 (سال دو کاراکتری)
Saal4 -> 1394 (سال چهار کاراکتری)
SaalRooz -> 38 (چندمین روز سال)
Default Format -> 'ChandShanbe Rooz MaahHarfi Saal'
*/
DECLARE @shYear AS INT ,@shMonth AS INT ,@shDay AS INT ,@intYY AS INT ,@intMM AS INT ,@intDD AS INT ,@Kabiseh1 AS INT ,@Kabiseh2 AS INT ,@d1 AS INT ,@m1 AS INT, @shMaah AS NVARCHAR(max),@shRooz AS NVARCHAR(max),@DayCnt AS INT, @YearDay AS INT
DECLARE @DayDate AS NVARCHAR(max)
SET @intYY = DATEPART(yyyy, @intDate)
IF @intYY < 1000 SET @intYY = @intYY + 2000
SET @intMM = MONTH(@intDate)
SET @intDD = DAY(@intDate)
SET @shYear = @intYY - 622
IF (@Format IS NULL) OR NOT LEN(@Format)>0 SET @Format = 'ChandShanbe Rooz MaahHarfi Saal'
SET @m1 = 1
SET @d1 = 1
SET @shMonth = 10
SET @shDay = 11
SET @DayCnt = datepart(dw, '01/02/' + CONVERT(CHAR(4), @intYY))
SET @YearDay = 276
IF ( ( @intYY - 1993 ) % 4 = 0 ) SET @shDay = 12
SET @YearDay = @YearDay + @shDay
WHILE ( @m1 != @intMM ) OR ( @d1 != @intDD )
BEGIN
 SET @d1 = @d1 + 1
 SET @DayCnt = @DayCnt + 1
 IF ( ( @intYY - 1992 ) % 4 = 0) SET @Kabiseh1 = 1 ELSE SET @Kabiseh1 = 0
 IF ( ( @shYear - 1371 ) % 4 = 0) SET @Kabiseh2 = 1 ELSE SET @Kabiseh2 = 0
 IF 
 (@d1 = 32 AND (@m1 = 1 OR @m1 = 3 OR @m1 = 5 OR @m1 = 7 OR @m1 = 8 OR @m1 = 10 OR @m1 = 12))
 OR
 (@d1 = 31 AND (@m1 = 4 OR @m1 = 6 OR @m1 = 9 OR @m1 = 11))
 OR
 (@d1 = 30 AND @m1 = 2 AND @Kabiseh1 = 1)
 OR
 (@d1 = 29 AND @m1 = 2 AND @Kabiseh1 = 0)
 BEGIN
  SET @m1 = @m1 + 1
  SET @d1 = 1
 END
 IF @m1 > 12
 BEGIN
  SET @intYY = @intYY + 1
  SET @m1 = 1
 END
 
 IF @DayCnt > 7 SET @DayCnt = 1
SET @shDay = @shDay + 1
SET @YearDay = @YearDay + 1
 
 IF
 (@shDay = 32 AND @shMonth < 7)
 OR
 (@shDay = 31 AND @shMonth > 6 AND @shMonth < 12)
 OR
 (@shDay = 31 AND @shMonth = 12 AND @Kabiseh2 = 1)
 OR
 (@shDay = 30 AND @shMonth = 12 AND @Kabiseh2 = 0)
 BEGIN
  SET @shMonth = @shMonth + 1
  SET @shDay = 1
 END
 IF @shMonth > 12
 BEGIN
  SET @shYear = @shYear + 1
  SET @shMonth = 1
  SET @YearDay = 1
 END
 
END
IF @shMonth=1 SET @shMaah=N'فروردین'
IF @shMonth=2 SET @shMaah=N'اردیبهشت'
IF @shMonth=3 SET @shMaah=N'خرداد'
IF @shMonth=4 SET @shMaah=N'تیر'
IF @shMonth=5 SET @shMaah=N'مرداد'
IF @shMonth=6 SET @shMaah=N'شهریور'
IF @shMonth=7 SET @shMaah=N'مهر'
IF @shMonth=8 SET @shMaah=N'آبان'
IF @shMonth=9 SET @shMaah=N'آذر'
IF @shMonth=10 SET @shMaah=N'دی'
IF @shMonth=11 SET @shMaah=N'بهمن'
IF @shMonth=12 SET @shMaah=N'اسفند'
IF @DayCnt=1 SET @shRooz=N'شنبه'
IF @DayCnt=2 SET @shRooz=N'یکشنبه'
IF @DayCnt=3 SET @shRooz=N'دوشنبه'
IF @DayCnt=4 SET @shRooz=N'سه شنبه'
IF @DayCnt=5 SET @shRooz=N'چهارشنبه'
IF @DayCnt=6 SET @shRooz=N'پنجشنبه'
IF @DayCnt=7 SET @shRooz=N'جمعه'
SET @DayDate = REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(@Format,'MaahHarfi',@shMaah),'SaalRooz',LTRIM(STR(@YearDay,3))),'ChandShanbeAdadi',@DayCnt),'ChandShanbe',@shRooz),'Rooz2',REPLACE(STR(@shDay,2), ' ', '0')),'Maah2',REPLACE(STR(@shMonth, 2), ' ', '0')),'Saal2',SUBSTRING(STR(@shYear,4),3,2)),'Saal4',STR(@shYear,4)),'Saal',LTRIM(STR(@shYear,4))),'Maah',LTRIM(STR(@shMonth,2))),'Rooz',LTRIM(STR(@shDay,2)))
/* Format Samples:
Format='ChandShanbe Rooz MaahHarfi Saal' -> پنجشنبه 17 اردیبهشت 1394
Format='Rooz MaahHarfi Saal' -> ـ 17 اردیبهشت 1394
Format='Rooz/Maah/Saal' -> 1394/2/17
Format='Rooz2/Maah2/Saal2' -> 94/02/17
Format='Rooz روز گذشته از MaahHarfi در سال Saal2' -> ـ 17 روز گذشته از اردیبهشت در سال 94
*/
RETURN @DayDate
END

GO
/****** Object:  Table [dbo].[ATM]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATM](
	[Code] [char](10) NOT NULL,
	[LocationId] [int] NOT NULL,
 CONSTRAINT [PK_ATM] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CalendarDimension]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalendarDimension](
	[DateKey] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Day] [tinyint] NOT NULL,
	[DaySuffix] [char](2) NOT NULL,
	[Weekday] [tinyint] NOT NULL,
	[WeekDayName] [varchar](10) NOT NULL,
	[IsWeekend] [bit] NOT NULL,
	[IsHoliday] [bit] NOT NULL,
	[HolidayText] [varchar](64) SPARSE  NULL,
	[DOWInMonth] [tinyint] NOT NULL,
	[DayOfYear] [smallint] NOT NULL,
	[WeekOfMonth] [tinyint] NOT NULL,
	[WeekOfYear] [tinyint] NOT NULL,
	[ISOWeekOfYear] [tinyint] NOT NULL,
	[Month] [tinyint] NOT NULL,
	[MonthName] [varchar](10) NOT NULL,
	[Quarter] [tinyint] NOT NULL,
	[QuarterName] [varchar](6) NOT NULL,
	[Year] [int] NOT NULL,
	[MMYYYY] [char](6) NOT NULL,
	[MonthYear] [char](7) NOT NULL,
	[FirstDayOfMonth] [date] NOT NULL,
	[LastDayOfMonth] [date] NOT NULL,
	[FirstDayOfQuarter] [date] NOT NULL,
	[LastDayOfQuarter] [date] NOT NULL,
	[FirstDayOfYear] [date] NOT NULL,
	[LastDayOfYear] [date] NOT NULL,
	[FirstDayOfNextMonth] [date] NOT NULL,
	[FirstDayOfNextYear] [date] NOT NULL,
	[PersianDate] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DateKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Car]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [nvarchar](20) NOT NULL,
	[Model] [nvarchar](500) NOT NULL,
	[AverageSpeed] [decimal](4, 1) NOT NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Latitude] [decimal](10, 8) NULL,
	[Longitude] [decimal](11, 8) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ZoneId] [int] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Map]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Map](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FromLocationId] [int] NOT NULL,
	[ToLocationId] [int] NOT NULL,
	[Status] [varchar](10) NOT NULL,
	[Lenght] [decimal](7, 3) NOT NULL,
	[AverageSpeed] [decimal](4, 1) NOT NULL,
 CONSTRAINT [PK_Map] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mission]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScheduledStart] [datetime] NOT NULL,
	[RealStart] [datetime] NOT NULL,
	[ScheduledEnd] [datetime] NOT NULL,
	[ReadlEnd] [datetime] NOT NULL,
	[RouteId] [int] NOT NULL,
 CONSTRAINT [PK_Mission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NN_CarMission]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NN_CarMission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CarId] [int] NOT NULL,
	[MissionId] [int] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[WasOK] [smallint] NOT NULL,
	[BetterThanBefore] [smallint] NOT NULL,
 CONSTRAINT [PK_NN_CarMission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NN_RouteLocation]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NN_RouteLocation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RouteId] [int] NOT NULL,
	[LocationId] [int] NOT NULL,
	[Index] [smallint] NOT NULL,
 CONSTRAINT [PK_NN_RouteLocation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NN_StatusAtm]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NN_StatusAtm](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusId] [int] NOT NULL,
	[AtmId] [char](10) NOT NULL,
 CONSTRAINT [PK_NN_StatusAtm] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Package]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Package](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Count] [int] NOT NULL,
	[Value] [int] NOT NULL,
	[TransactionId] [int] NOT NULL,
 CONSTRAINT [PK_Package] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Route]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FromLocationId] [int] NOT NULL,
	[ToLocationId] [int] NOT NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Status]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Usable] [bit] NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Transaction]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transaction](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Successful] [bit] NOT NULL,
	[Way] [char](1) NOT NULL,
	[DateKey] [int] NOT NULL,
	[CarId] [int] NULL,
	[AtmId] [char](10) NULL,
 CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zone]    Script Date: 7/15/2017 1:55:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zone](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Zone] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ATM] ADD  CONSTRAINT [DF_ATM_Code]  DEFAULT (CONVERT([varchar],substring(replace(CONVERT([varchar](50),newid()),'-',''),(0),(11)))) FOR [Code]
GO
ALTER TABLE [dbo].[ATM]  WITH CHECK ADD  CONSTRAINT [FK_ATM_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[ATM] CHECK CONSTRAINT [FK_ATM_Location]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Zone] FOREIGN KEY([ZoneId])
REFERENCES [dbo].[Zone] ([Id])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Zone]
GO
ALTER TABLE [dbo].[Map]  WITH CHECK ADD  CONSTRAINT [FK_Map_Location] FOREIGN KEY([FromLocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Map] CHECK CONSTRAINT [FK_Map_Location]
GO
ALTER TABLE [dbo].[Map]  WITH CHECK ADD  CONSTRAINT [FK_Map_Location1] FOREIGN KEY([ToLocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Map] CHECK CONSTRAINT [FK_Map_Location1]
GO
ALTER TABLE [dbo].[Mission]  WITH CHECK ADD  CONSTRAINT [FK_Mission_Route] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Route] ([Id])
GO
ALTER TABLE [dbo].[Mission] CHECK CONSTRAINT [FK_Mission_Route]
GO
ALTER TABLE [dbo].[NN_CarMission]  WITH CHECK ADD  CONSTRAINT [FK_NN_CarMission_Car] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([Id])
GO
ALTER TABLE [dbo].[NN_CarMission] CHECK CONSTRAINT [FK_NN_CarMission_Car]
GO
ALTER TABLE [dbo].[NN_CarMission]  WITH CHECK ADD  CONSTRAINT [FK_NN_CarMission_Mission] FOREIGN KEY([MissionId])
REFERENCES [dbo].[Mission] ([Id])
GO
ALTER TABLE [dbo].[NN_CarMission] CHECK CONSTRAINT [FK_NN_CarMission_Mission]
GO
ALTER TABLE [dbo].[NN_RouteLocation]  WITH CHECK ADD  CONSTRAINT [FK_NN_RouteLocation_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[NN_RouteLocation] CHECK CONSTRAINT [FK_NN_RouteLocation_Location]
GO
ALTER TABLE [dbo].[NN_RouteLocation]  WITH CHECK ADD  CONSTRAINT [FK_NN_RouteLocation_Route] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Route] ([Id])
GO
ALTER TABLE [dbo].[NN_RouteLocation] CHECK CONSTRAINT [FK_NN_RouteLocation_Route]
GO
ALTER TABLE [dbo].[NN_StatusAtm]  WITH CHECK ADD  CONSTRAINT [FK_NN_StatusAtm_ATM] FOREIGN KEY([AtmId])
REFERENCES [dbo].[ATM] ([Code])
GO
ALTER TABLE [dbo].[NN_StatusAtm] CHECK CONSTRAINT [FK_NN_StatusAtm_ATM]
GO
ALTER TABLE [dbo].[NN_StatusAtm]  WITH CHECK ADD  CONSTRAINT [FK_NN_StatusAtm_Status] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([Id])
GO
ALTER TABLE [dbo].[NN_StatusAtm] CHECK CONSTRAINT [FK_NN_StatusAtm_Status]
GO
ALTER TABLE [dbo].[Package]  WITH CHECK ADD  CONSTRAINT [FK_Package_Transaction] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transaction] ([Id])
GO
ALTER TABLE [dbo].[Package] CHECK CONSTRAINT [FK_Package_Transaction]
GO
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_Location] FOREIGN KEY([FromLocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_Location]
GO
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_Location1] FOREIGN KEY([ToLocationId])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_Location1]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_ATM] FOREIGN KEY([AtmId])
REFERENCES [dbo].[ATM] ([Code])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_ATM]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_CalendarDimension] FOREIGN KEY([DateKey])
REFERENCES [dbo].[CalendarDimension] ([DateKey])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_CalendarDimension]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [FK_Transaction_Car] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([Id])
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [FK_Transaction_Car]
GO
ALTER TABLE [dbo].[NN_CarMission]  WITH CHECK ADD  CONSTRAINT [CK_NN_CarMission] CHECK  (([BetterThanBefore]<=(100)))
GO
ALTER TABLE [dbo].[NN_CarMission] CHECK CONSTRAINT [CK_NN_CarMission]
GO
ALTER TABLE [dbo].[NN_CarMission]  WITH CHECK ADD  CONSTRAINT [CK_NN_CarMission_1] CHECK  (([WasOK]<=(100)))
GO
ALTER TABLE [dbo].[NN_CarMission] CHECK CONSTRAINT [CK_NN_CarMission_1]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [CK_Transaction] CHECK  (([Way]='I ' OR [Way]='O'))
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [CK_Transaction]
GO
ALTER TABLE [dbo].[Transaction]  WITH CHECK ADD  CONSTRAINT [CK_Transaction_OneOfCarOrAtm] CHECK  (([AtmId]=NULL AND [CarId]<>NULL OR [CarId]=NULL AND [AtmId]<>NULL))
GO
ALTER TABLE [dbo].[Transaction] CHECK CONSTRAINT [CK_Transaction_OneOfCarOrAtm]
GO
USE [master]
GO
ALTER DATABASE [ATM2] SET  READ_WRITE 
GO
