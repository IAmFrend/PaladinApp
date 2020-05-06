set ansi_padding on
go
set ansi_nulls on
go
set quoted_identifier on
go

use [Paladin_Quest]
go

create view [dbo].[Timetable] 
as
SELECT        dbo.[Work].ID_Work, dbo.[Work].WorkDay, dbo.[Work].Work_Time, dbo.[Work].Work_Length, dbo.[Work].LogicDelete, dbo.Themes.ThemeName, dbo.Trainers.ID_Trainer, dbo.Trainers.TrainerFirstName, 
                         dbo.Trainers.TrainerSecondName, dbo.Trainers.TrainerLastName, dbo.WorkPlaces.ID_WorkPlace, dbo.WorkPlaces.WorkPlaceLocation, dbo.Filials.FilialName
FROM            dbo.[Work] INNER JOIN
                         dbo.[Group] ON dbo.[Work].ID_Group = dbo.[Group].ID_Group INNER JOIN
                         dbo.Themes ON dbo.[Group].Theme_ID = dbo.Themes.ID_Theme INNER JOIN
                         dbo.Trainers ON dbo.[Group].Trainer_ID = dbo.Trainers.ID_Trainer INNER JOIN
                         dbo.WorkPlaces ON dbo.[Group].WorkPlace_ID = dbo.WorkPlaces.ID_WorkPlace INNER JOIN
                         dbo.Filials ON dbo.WorkPlaces.ID_Filial = dbo.Filials.ID_Filial
go