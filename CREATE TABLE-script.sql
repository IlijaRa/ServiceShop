/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Repairer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Surname] [nvarchar](200) NOT NULL,
	[EmailAddress] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Longevity] [float] NOT NULL,
	[Birthday] [date] NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
	[SuperiorsEmailAddress] [nvarchar](200) NULL,
 CONSTRAINT [PK_Repairer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Request](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientsName] [nvarchar](200) NOT NULL,
	[ClientsSurname] [nvarchar](200) NOT NULL,
	[ClientsEmailAddress] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[RequestType] [nvarchar](20) NOT NULL,
	[StateType] [nvarchar](20) NOT NULL,
	[PaymentType] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[Importance] [nvarchar](20) NULL,
	[RepairerId] [int] NULL,
	[BillName] [nvarchar](200) NULL,
	[NotificationId] [int] NULL,
	[ReportId] [int] NULL,
 CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Surname] [nvarchar](200) NOT NULL,
	[EmailAddress] [nvarchar](200) NOT NULL,
	[Password] [nvarchar](200) NOT NULL,
	[DeliveryAddress] [nvarchar](200) NOT NULL,
	[DeliveryCity] [nvarchar](200) NOT NULL,
	[PostalCode] [nvarchar](20) NOT NULL,
	[Birthday] [date] NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Report](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientsEmailAddress] [nvarchar](200) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Details] [nvarchar](200) NOT NULL,
	[Mark] [int] NOT NULL,
	[RepairerId] [int] NOT NULL,
 CONSTRAINT [PK_Report] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[EnterpriseName] [nvarchar](200) NOT NULL,
	[EnterpriseAddress] [nvarchar](200) NOT NULL,
	[ClientsName] [nvarchar](200) NOT NULL,
	[ClientsSurname] [nvarchar](200) NOT NULL,
	[ClientsEmailAddress] [nvarchar](200) NOT NULL,
	[Price] [float] NOT NULL,
	[SpentMaterials] [nvarchar](max) NOT NULL,
	[TermsAndConditions] [nvarchar](max) NOT NULL,
	[RepairerId] [int] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

/****** Object:  Table [dbo].[Notification]    Script Date: 6/22/2022 12:12:34 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Notification](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientsEmailAddress] [nvarchar](200) NOT NULL,
	[Title] [nvarchar](200) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[BillId] [int] NOT NULL,
	[RepairerId] [int] NOT NULL,
 CONSTRAINT [PK_Notification] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

/****** Object:  Table [dbo].[Message]    Script Date: 6/22/2022 12:14:05 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Message](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientsEmailAddress] [nvarchar](200) NOT NULL,
	[Subject] [nvarchar](200) NOT NULL,
	[Text] [nvarchar](max) NOT NULL,
	[RepairersEmailAddress] [nvarchar](200) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Status] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

/****** Object:  Table [dbo].[Material]    Script Date: 6/22/2022 12:15:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Price] [float] NOT NULL,
	[EarningPercentage] [float] NOT NULL,
 CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/*--------------------------------------*/
USE [database_name]/*<-- instead of database_name enter your db name*/
GO

/****** Object:  Table [dbo].[JobHistory]    Script Date: 6/22/2022 12:14:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[JobHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ClientsEmailAddress] [nvarchar](200) NULL,
	[RepairersEmailAddress] [nvarchar](200) NULL,
	[RequestDescription] [nvarchar](max) NULL,
	[Income] [decimal](18, 0) NULL,
	[Outcome] [nvarchar](50) NULL,
 CONSTRAINT [PK_JobHistory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO