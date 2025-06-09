USE [DND]
GO

Drop Table Units;

/****** Object:  Table [dbo].[Units]    Script Date: 18/05/2025 14:32:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Units](
	[UnitID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[Faction] [varchar](255) NULL,
	[Cost] [int] NOT NULL,
	[Upkeep] [int] NOT NULL,
	Wounds [int] NOT NULL,
	Armour [int] NOT NULL,
	Shield [int] NOT NULL,
	NumAttacks[int] NOT NULL,
	Attack [int] NOT NULL,
	Defence [int] NOT NULL,
	[Range] [int] NOT NULL,
	Accuracy [int] NOT NULL,
	Shots [int] NOT NULL,
	Leadership [int] NOT NULL,
	Movement [int] NOT NULL,
	Charge [int] NOT NULL,

PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


