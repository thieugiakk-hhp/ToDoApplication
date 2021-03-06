USE [master]
GO
/****** Object:  Database [Database]    Script Date: 21/08/2021 5:29:39 PM ******/
CREATE DATABASE [Database]
 
GO
ALTER DATABASE [Database] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Database] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Database] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Database] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Database] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Database] SET ARITHABORT OFF 
GO
ALTER DATABASE [Database] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Database] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Database] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Database] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Database] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Database] SET  MULTI_USER 
GO
ALTER DATABASE [Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Database] SET QUERY_STORE = OFF
GO
USE [Database]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Database]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 21/08/2021 5:29:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[UserID] [char](14) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblCategories]    Script Date: 21/08/2021 5:29:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategories](
	[CategoryID] [char](10) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTask]    Script Date: 21/08/2021 5:29:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTask](
	[TaskID] [bigint] NOT NULL,
	[UserID] [char](14) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[StartDay] [datetime] NOT NULL,
	[EndDay] [datetime] NOT NULL,
	[CategoryID] [char](10) NOT NULL,
	[TaskListID] [bigint] NULL,
	[TaskDescription] [nvarchar](4000) NULL,
	[Important] [bit] NOT NULL,
	[Complete] [bit] NOT NULL,
 CONSTRAINT [PK_Task] PRIMARY KEY CLUSTERED 
(
	[TaskID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaskList]    Script Date: 21/08/2021 5:29:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaskList](
	[TaskListID] [bigint] NOT NULL,
	[UserID] [char](14) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_TaskList] PRIMARY KEY CLUSTERED 
(
	[TaskListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserInformation]    Script Date: 21/08/2021 5:29:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserInformation](
	[UserID] [char](14) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Age] [tinyint] NULL,
	[Sex] [bit] NULL,
	[Profession] [nvarchar](100) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUserStatusInDay]    Script Date: 21/08/2021 5:29:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUserStatusInDay](
	[Date] [date] NOT NULL,
	[UserID] [char](14) NULL,
	[Status] [nvarchar](200) NOT NULL,
	[Water] [float] NOT NULL,
	[BMI] [float] NOT NULL,
 CONSTRAINT [PK_UserStatus] PRIMARY KEY CLUSTERED 
(
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([UserID], [Email], [Password]) VALUES (N'admin         ', N'admin@gmail.com', N'admin')
INSERT [dbo].[tblAccount] ([UserID], [Email], [Password]) VALUES (N'admin1        ', N'hhpxme@gmail.com', N'royalpktk011')
INSERT [dbo].[tblAccount] ([UserID], [Email], [Password]) VALUES (N'admin2        ', N'thieugiakk.hhp@gmail.com', N'12345689abcdegh')
GO
INSERT [dbo].[tblCategories] ([CategoryID], [Name]) VALUES (N'Cate341244', N'Bình thường')
INSERT [dbo].[tblCategories] ([CategoryID], [Name]) VALUES (N'Cate856608', N'Cần làm ngay')
INSERT [dbo].[tblCategories] ([CategoryID], [Name]) VALUES (N'Cate901352', N'Deadline dí')
GO
INSERT [dbo].[tblTask] ([TaskID], [UserID], [Title], [DateCreated], [StartDay], [EndDay], [CategoryID], [TaskListID], [TaskDescription], [Important], [Complete]) VALUES (1, N'admin         ', N'Thử lần 1', CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-22T00:00:00.000' AS DateTime), N'Cate341244', 1, N'Thử xem có chạy được không', 1, 0)
INSERT [dbo].[tblTask] ([TaskID], [UserID], [Title], [DateCreated], [StartDay], [EndDay], [CategoryID], [TaskListID], [TaskDescription], [Important], [Complete]) VALUES (2, N'admin         ', N'Thử lần 2', CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-20T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), N'Cate341244', 2, N'Thử xem database có kết nối được không ?', 1, 1)
INSERT [dbo].[tblTask] ([TaskID], [UserID], [Title], [DateCreated], [StartDay], [EndDay], [CategoryID], [TaskListID], [TaskDescription], [Important], [Complete]) VALUES (3, N'admin         ', N'Thử lần 3', CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), N'Cate341244', 1, N'Thử lần 3, xem datachạy như nào', 0, 0)
INSERT [dbo].[tblTask] ([TaskID], [UserID], [Title], [DateCreated], [StartDay], [EndDay], [CategoryID], [TaskListID], [TaskDescription], [Important], [Complete]) VALUES (4, N'admin1        ', N'thử lần 4', CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), N'Cate341244', NULL, N'Thử nick khác', 1, 0)
INSERT [dbo].[tblTask] ([TaskID], [UserID], [Title], [DateCreated], [StartDay], [EndDay], [CategoryID], [TaskListID], [TaskDescription], [Important], [Complete]) VALUES (5, N'admin1        ', N'Thử lần 5', CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), CAST(N'2021-08-21T00:00:00.000' AS DateTime), N'Cate341244', 3, NULL, 0, 0)
GO
INSERT [dbo].[tblTaskList] ([TaskListID], [UserID], [Name]) VALUES (1, N'admin         ', N'Thử nghiệm')
INSERT [dbo].[tblTaskList] ([TaskListID], [UserID], [Name]) VALUES (2, N'admin         ', N'Thử nghiệm lần 2')
INSERT [dbo].[tblTaskList] ([TaskListID], [UserID], [Name]) VALUES (3, N'admin1        ', N'Thử nghiệm trên nick khác')
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_Title]  DEFAULT (N'Tác vụ chưa đặt tên') FOR [Title]
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_StartDay]  DEFAULT (getdate()) FOR [StartDay]
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_EndDay]  DEFAULT (getdate()) FOR [EndDay]
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_CategoryID]  DEFAULT ('Cate341244') FOR [CategoryID]
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_Important]  DEFAULT ((0)) FOR [Important]
GO
ALTER TABLE [dbo].[tblTask] ADD  CONSTRAINT [DF_Task_Complete]  DEFAULT ((0)) FOR [Complete]
GO
ALTER TABLE [dbo].[tblTaskList] ADD  CONSTRAINT [DF_TaskList_Name]  DEFAULT (N'Danh sách chưa đặt tên') FOR [Name]
GO
ALTER TABLE [dbo].[tblUserInformation] ADD  CONSTRAINT [DF_UserInformation_Sex]  DEFAULT ((0)) FOR [Sex]
GO
ALTER TABLE [dbo].[tblUserStatusInDay] ADD  CONSTRAINT [DF_UserStatus_Date]  DEFAULT (getdate()) FOR [Date]
GO
ALTER TABLE [dbo].[tblTask]  WITH CHECK ADD  CONSTRAINT [FK_Task_Account_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblAccount] ([UserID])
GO
ALTER TABLE [dbo].[tblTask] CHECK CONSTRAINT [FK_Task_Account_UserID]
GO
ALTER TABLE [dbo].[tblTask]  WITH CHECK ADD  CONSTRAINT [FK_Task_Categories_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategories] ([CategoryID])
GO
ALTER TABLE [dbo].[tblTask] CHECK CONSTRAINT [FK_Task_Categories_CategoryID]
GO
ALTER TABLE [dbo].[tblTask]  WITH CHECK ADD  CONSTRAINT [FK_Task_TaskList_TaskListID] FOREIGN KEY([TaskListID])
REFERENCES [dbo].[tblTaskList] ([TaskListID])
GO
ALTER TABLE [dbo].[tblTask] CHECK CONSTRAINT [FK_Task_TaskList_TaskListID]
GO
ALTER TABLE [dbo].[tblTaskList]  WITH CHECK ADD  CONSTRAINT [FK_TaskList_Account] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblAccount] ([UserID])
GO
ALTER TABLE [dbo].[tblTaskList] CHECK CONSTRAINT [FK_TaskList_Account]
GO
ALTER TABLE [dbo].[tblUserInformation]  WITH CHECK ADD  CONSTRAINT [FK_UserInformation_Account_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblAccount] ([UserID])
GO
ALTER TABLE [dbo].[tblUserInformation] CHECK CONSTRAINT [FK_UserInformation_Account_UserID]
GO
ALTER TABLE [dbo].[tblUserStatusInDay]  WITH CHECK ADD  CONSTRAINT [FK_UserStatus_Account_UserID] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblAccount] ([UserID])
GO
ALTER TABLE [dbo].[tblUserStatusInDay] CHECK CONSTRAINT [FK_UserStatus_Account_UserID]
GO
ALTER TABLE [dbo].[tblTask]  WITH CHECK ADD  CONSTRAINT [CK_Task_StarDay_EndDay] CHECK  (([StartDay]<=[EndDay]))
GO
ALTER TABLE [dbo].[tblTask] CHECK CONSTRAINT [CK_Task_StarDay_EndDay]
GO
USE [master]
GO
ALTER DATABASE [Database] SET  READ_WRITE 
GO
