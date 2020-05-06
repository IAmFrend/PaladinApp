set ansi_padding on
go
set ansi_nulls on
go
set quoted_identifier on
go

drop database [Paladin_Quest]
go

create database [Paladin_Quest]
go

use [Paladin_Quest]
go

create table [dbo].[Filials]
(
	[ID_Filial] [int] not null identity(0,1),
	[FilialName] [varchar] (40) not null default ('Не указано'),
	[LogicDelete] [bit] null default (0),
	constraint [PK_Filial] primary key clustered 
	([ID_Filial] ASC) on [PRIMARY],
	constraint [UQ_FilialName] unique ([FilialName]),
	[FilialAdress] [varchar] (MAX) null default ('Не указано'),	 
)
go

create table [dbo].[WorkPlaces]
(
	[ID_WorkPlace] [int] not null identity(0,1),
	[WorkPlaceLocation] [varchar] (40) not null default ('Не указано'),
	[LogicDelete] [bit] null default (0),
	constraint [PK_WorkPlace] primary key clustered 
	([ID_WorkPlace] ASC) on [PRIMARY],
	[ID_Filial] [int] not null 
	constraint [FK_Filial] foreign key ([ID_Filial])
	references [dbo].[Filials] ([ID_Filial])
)
go

create table [dbo].[Themes]
(
	[ID_Theme] [int] not null identity(0,1),
	[ThemeName] [varchar] (40) not null default ('Не указано'),
	constraint [PK_Theme] primary key clustered 
	([ID_Theme] ASC) on [PRIMARY],
	[ThemeAbout] [text] null default ('не указано'),
	[LogicDelete] [bit] null default (0)
)
go

create table [dbo].[Trainers]
(
	[ID_Trainer] [int] not null identity(0,1),
	constraint [PK_Trainer] primary key clustered 
	([ID_Trainer] ASC) on [PRIMARY],
	[TrainerFirstName] [varchar] (40) not null,
	[TrainerSecondName] [varchar] (40) null default ('Не указано'),
	[TrainerLastName] [varchar] (40) not null,
	[TrainerCategory] [varchar] (40) not null,
	[TrainerLogin] [varchar] (40) not null,
	[TrainerPassword] [varchar] (40) not null,
	[LogicDelete] [bit] null default (0),
	constraint [UQ_TrainerLogin] unique ([TrainerLogin]),
	constraint [CH_TrainerCategory] check ([TrainerCategory] like '[1-3]' or [TrainerCategory] = 'помощник' or [TrainerCategory] = 'старший' )
)
go

create table [dbo].[Group]
(
	[ID_Group] [int] not null identity(0,1),
	constraint [PK_Group] primary key clustered
	([ID_Group] ASC) on [PRIMARY],
	[WorkPlace_ID] [int] not null
	constraint [FK_WorkPlace] foreign key ([WorkPlace_ID])
	references [dbo].[WorkPlaces] ([ID_WorkPlace]),
	[Theme_ID] [int] not null
	constraint [FK_Theme] foreign key ([Theme_ID])
	references [dbo].[Themes] ([ID_Theme]),
	[Trainer_ID] [int] not null
	constraint [FK_Trainers] foreign key ([Trainer_ID])
	references [dbo].[Trainers] ([ID_Trainer]),
	[Abon_Cost] [int] not null,
	constraint [CH_Abon_Cost] check ([Abon_Cost] > 0),
	[LogicDelete] [bit] null default (0),
) 
go

create table [dbo].[Work]
(
	[ID_Work] [int] not null identity(0,1),
	constraint [PK_Work] primary key clustered 
	([ID_Work] ASC) on [PRIMARY],
	[WorkDay] [varchar] (40) not null default ('ПН'),	
	constraint [CH_WorkDay] check ([WorkDay] = 'ПН' or [WorkDay] = 'ВТ' or [WorkDay] = 'СР' or [WorkDay] = 'ЧТ' or [WorkDay] = 'ПТ' or [WorkDay] = 'СБ' or [WorkDay] = 'ВС'),
	[Work_Time] [varchar](5) not null default(Convert([varchar](5),Format(GetDate(),'HH:mm'))),
	[Work_Length] [varchar](5) not null default(Convert([varchar](5),Format(DATEADD(HOUR,1,GetDate()),'HH:mm'))),
	[LogicDelete] [bit] null default (0),
	[ID_Group] [int] not null 
	constraint [FK_Group] foreign key ([ID_Group])
	references [dbo].[Group] ([ID_Group])
)

create table [dbo].[Client] 
(
	[ID_Client] [int] not null identity(0,1),
	constraint [PK_Client] primary key clustered 
	([ID_Client] ASC) on [PRIMARY],
	[CLFirstName] [varchar] (30) not null,
	[CLName] [varchar] (30) not null,
	[CLMiddleName] [varchar] (30) null default ('-'),
	[ClGen] [varchar] (3) not null
	constraint [CH_Gen] check ([ClGen] = 'муж' or [ClGen] = 'жен'),
	[CLBirthdate] [varchar](10) not null default(Convert([varchar](10),Format(GetDate(),'dd.MM.yyyy'))),
	[ClAge] AS DATEDIFF(YEAR,(FORMAT(CONVERT([date],[CLBirthdate]),'dd.MM.yyyy')),GETDATE()),
	[CLWorkStart] [varchar](10) not null default(Convert([varchar](10),Format(DATEADD(DAY,1,GetDate()),'dd.MM.yyyy'))),
	[ClExp] AS DATEDIFF(YEAR,(FORMAT(CONVERT([date],[CLWorkStart]),'dd.MM.yyyy')),GETDATE()),
	[Phone] [varchar] (12) null default (' ')
	CONSTRAINT [CH_Phone] CHECK (([Phone] like '+[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')),
	[Agreement] [varchar] (8) null default (''),
	[CLComm] [text] null default (''),
	[LogicDelete] [bit] null default (0)
)
go

create table [dbo].[Action]
(
	[ID_Action] [int] not null identity(0,1),
	constraint [PK_Action] primary key clustered 
	([ID_Action] ASC) on [PRIMARY],
	[ActionProc] [int] not null default ('0'),	
	constraint [CH_ActionProc] check ([ActionProc]>'-1' and [ActionProc]<'100'),
	[ActionProperties] [text] not null,
	[Action_Start_Date] [varchar](10) not null default(Convert([varchar](10),Format(GetDate(),'dd.MM.yyyy'))),
	[Action_End_Date] [varchar](10) not null default(Convert([varchar](10),Format(DATEADD(DAY,1,GetDate()),'dd.MM.yyyy'))),
	constraint [CH_Order_Date] check (FORMAT(CONVERT([date],[Action_End_Date]),'dd.MM.yyyy')>FORMAT(CONVERT([date],[Action_Start_Date]),'dd.MM.yyyy')),
	[LogicDelete] [bit] null default (0)
)

create table [dbo].[Abonement]
(
	[ID_Abonement] [int] not null identity(0,1),
	constraint [PK_Abonement] primary key clustered 
	([ID_Abonement] ASC) on [PRIMARY],
	[Abonement_Start_Date] [varchar](10) not null default(Convert([varchar](10),Format(GetDate(),'dd.MM.yyyy'))),
	[Abonement_End_Date] [varchar](10) not null default(Convert([varchar](10),Format(DATEADD(DAY,1,GetDate()),'dd.MM.yyyy'))),
	[Abonement_Cost] [int] null default (0),
	[ID_Client] [int] not null 
	constraint [FK_Client] foreign key ([ID_Client])
	references [dbo].[Client] ([ID_Client]),
	[ID_Action] [int] not null 
	constraint [FK_Action] foreign key ([ID_Action])
	references [dbo].[Action] ([ID_Action]),
	[ID_Group] [int] not null 
	constraint [FK_Abon_Group] foreign key ([ID_Group])
	references [dbo].[Group] ([ID_Group]),
	[LogicDelete] [bit] null default (0)
)
go

create table [dbo].[Newcoming]
(
	[ID_Newcoming] [int] not null identity(0,1),
	constraint [PK_Newcoming] primary key clustered 
	([ID_Newcoming] ASC) on [PRIMARY],
	[Newcoming_Date] [varchar](10) not null default(Convert([varchar](10),Format(GetDate(),'dd.MM.yyyy'))),
	[ID_Work] [int] not null 
	constraint [FK_Work] foreign key ([ID_Work])
	references [dbo].[Work] ([ID_Work]),
	[ID_Abonement] [int] not null 
	constraint [FK_Abonement] foreign key ([ID_Abonement])
	references [dbo].[Abonement] ([ID_Abonement]),
	[LogicDelete] [bit] null default (0),
)
go

create table [dbo].[Managers]
(
	[ID_Manager] [int] not null identity(0,1),
	constraint [PK_Manager] primary key clustered 
	([ID_Manager] ASC) on [PRIMARY],
	[ManagerFirstName] [varchar] (40) not null,
	[ManagerSecondName] [varchar] (40) null default ('Не указано'),
	[ManagerLastName] [varchar] (40) not null,
	[ManagerLogin] [varchar] (40) not null,
	[ManagerPassword] [varchar] (40) not null,
	[LogicDelete] [bit] null default (0),
	constraint [UQ_ManagerLogin] unique ([ManagerLogin]),
)
go

