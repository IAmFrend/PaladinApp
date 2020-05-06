set ansi_padding on
go
set quoted_identifier on
go
set ansi_nulls on
go
SET DATEFORMAT DMY
GO

use Paladin_Quest
go

create function [dbo].[Autorization_Trainer](@Trainer_Login [varchar] (40),@Trainer_Password [varchar] (40))
returns [int]
with execute as caller
as
begin
return(select [ID_Trainer] from [dbo].[Trainers] where ([TrainerLogin] = @Trainer_Login) and ([TrainerPassword] = @Trainer_Password) and ([LogicDelete] = 0))
end
go

create function [dbo].[Autorization_Manager](@Manager_Login [varchar] (40),@Manager_Password [varchar] (40))
returns [int]
with execute as caller
as
begin
return(select [ID_Manager] from [dbo].[Managers] where ([ManagerLogin] = @Manager_Login) and ([ManagerPassword] = @Manager_Password) and ([LogicDelete] = 0))
end
go

create procedure [dbo].[Manager_Insert](@ManagerFirstName [varchar](40), @ManagerSecondName [varchar](40), @ManagerLastName [varchar](40), @ManagerLogin [varchar](40), @ManagerPassword [varchar](40))
as
if (select count (*) from [dbo].[Managers] where [ManagerLogin] = @ManagerLogin) = 0
insert into [dbo].[Managers]([ManagerFirstName],[ManagerSecondName],[ManagerLastName],[ManagerLogin],[ManagerPassword],[LogicDelete])
values (@ManagerFirstName,@ManagerSecondName,@ManagerLastName,@ManagerLogin,@ManagerPassword,0)
go

create procedure [dbo].[Manager_Update](@ID_Manager [int],@ManagerFirstName [varchar](40), @ManagerSecondName [varchar](40), @ManagerLastName [varchar](40), @ManagerLogin [varchar](40), @ManagerPassword [varchar](40))
as
if @ID_Manager >0
if ((select count (*) from [dbo].[Managers] where [ManagerLogin] = @ManagerLogin) = 0) or (@ManagerLogin = (select [ManagerLogin] FROM [dbo].[Managers] where [ID_Manager] = @ID_Manager))
update [dbo].[Managers] set
[ManagerFirstName] = @ManagerFirstName,
[ManagerSecondName] = @ManagerSecondName,
[ManagerLastName] = @ManagerLastName,
[ManagerLogin] = @ManagerLogin,
[ManagerPassword] = @ManagerPassword
where
[ID_Manager] = @ID_Manager
go

create procedure [dbo].[Manager_LogDelete](@ID_Manager [int])
as
if @ID_Manager >0
update [dbo].[Managers] set [LogicDelete] = 1 where [ID_Manager] = @ID_Manager
go

create procedure [dbo].[Trainer_Insert](@TrainerFirstName [varchar](40), @TrainerSecondName [varchar](40), @TrainerLastName [varchar](40), @TrainerCategory [varchar](40), @TrainerLogin [varchar](40), @TrainerPassword [varchar](40))
as
if (@TrainerCategory like '[1-3]' or @TrainerCategory = 'ïîìîùíèê' or @TrainerCategory = 'ñòàðøèé' )
if (select count (*) from [dbo].[Trainers] where [TrainerLogin] = @TrainerLogin) = 0
insert into [dbo].[Trainers]([TrainerFirstName],[TrainerSecondName],[TrainerLastName],[TrainerCategory],[TrainerLogin],[TrainerPassword],[LogicDelete])
values (@TrainerFirstName,@TrainerSecondName,@TrainerLastName,@TrainerCategory,@TrainerLogin,@TrainerPassword,0)
go

create procedure [dbo].[Trainer_Update](@ID_Trainer [int],@TrainerFirstName [varchar](40), @TrainerSecondName [varchar](40), @TrainerLastName [varchar](40), @TrainerCategory [varchar](40), @TrainerLogin [varchar](40), @TrainerPassword [varchar](40))
as
if @ID_Trainer >0
if (@TrainerCategory like '[1-3]' or @TrainerCategory = 'ïîìîùíèê' or @TrainerCategory = 'ñòàðøèé' )
if ((select count (*) from [dbo].[Trainers] where [TrainerLogin] = @TrainerLogin) = 0) or (@TrainerLogin = (select [TrainerLogin] FROM [dbo].[Trainers] where [ID_Trainer] = @ID_Trainer))
update [dbo].[Trainers] set
[TrainerFirstName] = @TrainerFirstName,
[TrainerSecondName] = @TrainerSecondName,
[TrainerLastName] = @TrainerLastName,
[TrainerCategory] = @TrainerCategory,
[TrainerLogin] = @TrainerLogin,
[TrainerPassword] = @TrainerPassword
where
[ID_Trainer] = @ID_Trainer
go

create procedure [dbo].[Trainer_LogDelete](@ID_Trainer [int])
as
if @ID_Trainer >0
begin
update [dbo].[Trainers] set [LogicDelete] = 1 where [ID_Trainer] = @ID_Trainer
update [dbo].[Group] set [LogicDelete] = 1 where [Trainer_ID] = @ID_Trainer
declare @Count [int] = (select count (*) from [dbo].[Group])
while @Count > 0 
begin
if (select [Trainer_ID] from [dbo].[Group] where [ID_Group] = @Count) = @ID_Trainer
begin
update [dbo].[Abonement] set [LogicDelete] = 1 where [ID_Group] = @Count
update [dbo].[Work] set [LogicDelete] = 1 where [ID_Group] = @Count
declare @Count1 [int] = (select count (*) from [dbo].[Abonement])
while @Count1 > 0 
begin
if (select [ID_Group] from [dbo].[Abonement] where [ID_Abonement] = @Count1) = @Count
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Abonement] = @Count1
set @Count1 = @Count1 - 1
end
declare @Count2 [int] = (select count (*) from [dbo].[Work])
while @Count2 > 0 
begin
if (select [ID_Group] from [dbo].[Work] where [ID_Work] = @Count2) = @Count
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Work] = @Count2
set @Count2 = @Count2 - 1
end
end
set @Count = @Count - 1
end
end
go

create procedure [dbo].[Newcoming_Add](@Newcoming_Date [varchar] (10),@ID_Work [int],@ID_Abonement [int])
as
if (select [ID_Group] from [dbo].[Work] where [ID_Work] = @ID_Work) = (select [ID_Group] from [dbo].[Abonement] where [ID_Abonement] = @ID_Abonement)
insert into [dbo].[Newcoming]([Newcoming_Date],[ID_Work],[ID_Abonement],[LogicDelete])
values (@Newcoming_Date,@ID_Work,@ID_Abonement,0)
go

CREATE function [dbo].[Abonement_Cost](@Group_ID [int],@Abonement_Start_Date [varchar] (10), @Abonement_End_Date [varchar] (10), @ID_Action [int])
returns [int]
with execute as caller
as
begin
declare @Base_Cost [int] = (select [Abon_Cost] from [dbo].[Group] where [ID_Group] = @Group_ID)
declare @Action_Proc [int] = (select [ActionProc] from [dbo].[Action] where [ID_Action] = @ID_Action)
declare @Days [int] = DATEDIFF(DAY,(CONVERT([date],@Abonement_Start_Date)),(CONVERT([date],@Abonement_End_Date)))
declare @Count [int] = 0
declare @Train_Count [int] = 0
while @Count <= @Days
begin
declare @WD [int] = (select DATEPART(WEEKDAY,DATEADD(DAY,@Count,(CONVERT([date],@Abonement_Start_Date)))))
declare @Weekday [varchar] (2) = 
case
WHEN @WD = 1 THEN 'ÏÍ'
WHEN @WD = 2 THEN 'ÂÒ'
WHEN @WD = 3 THEN 'ÑÐ'
WHEN @WD = 4 THEN '×Ò'
WHEN @WD = 5 THEN 'ÏÒ'
WHEN @WD = 6 THEN 'ÑÁ'
WHEN @WD = 7 THEN 'ÂÑ'
end
set @Train_Count = @Train_Count + (select COUNT(*) from [dbo].[Work] where ([ID_Group] = @Group_ID) and ([WorkDay] = @Weekday))
set @Count = @Count+1
end
return(@Train_Count*@Base_Cost*(100+@Action_Proc))
end
go

create procedure [dbo].[Abonement_Insert](@Group_ID [int],@Abonement_Start_Date [varchar] (10), @Abonement_End_Date [varchar] (10), @ID_Action [int],@Client_ID [int])
as
declare @Abonement_Cost [int] = (select [dbo].[Abonement_Cost](@Group_ID,@Abonement_Start_Date,@Abonement_End_Date,@ID_Action))
insert into [dbo].[Abonement]([Abonement_Start_Date],[Abonement_End_Date],[Abonement_Cost],[ID_Group],[ID_Action],[ID_Client],[LogicDelete])
values (@Abonement_Start_Date,@Abonement_End_Date,@Abonement_Cost,@Group_ID,@ID_Action,@Client_ID,0)
go

create procedure [dbo].[Abonement_Log_Delete](@ID_Abonement [int])
as
if @ID_Abonement >0
begin
update [dbo].[Abonement] set [LogicDelete] = 1 where [ID_Abonement] = @ID_Abonement
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Abonement] = @ID_Abonement
end
go

create procedure [dbo].[Client_Insert](@CLFirstName[varchar](30),@CLName[varchar](30),@CLMiddleName[varchar](30),@ClGen[varchar](3),@CLBirthdate[varchar](10),@CLWorkStart[varchar](10),@Phone[varchar](12),@Agreement[varchar](8),@CLComm[text])
as
	INSERT INTO [dbo].[Client]
           ([CLFirstName]
           ,[CLName]
           ,[CLMiddleName]
           ,[ClGen]
           ,[CLBirthdate]
           ,[CLWorkStart]
           ,[Phone]
           ,[Agreement]
           ,[CLComm]
		   ,[LogicDelete])
     VALUES
           (@CLFirstName
      ,@CLName
      ,@CLMiddleName
      ,@ClGen
      ,@CLBirthdate
      ,@CLWorkStart
      ,@Phone
      ,@Agreement
      ,@CLComm
	  ,0)
go

create procedure [dbo].[Client_Update]
	   @ID_Client[int]
      ,@CLFirstName[varchar](30)
      ,@CLName[varchar](30)
      ,@CLMiddleName[varchar](30)
      ,@ClGen[varchar](3)
      ,@CLBirthdate[varchar](10)
      ,@CLWorkStart[varchar](10)
      ,@Phone[varchar](12)
      ,@Agreement[varchar](8)
      ,@CLComm[text]
as
if @ID_Client >0
	UPDATE [dbo].[Client]
   SET [CLFirstName] = @CLFirstName
      ,[CLName] = @CLName
      ,[CLMiddleName] = @CLMiddleName
      ,[ClGen] = @ClGen
      ,[CLBirthdate] = @CLBirthdate
      ,[CLWorkStart] = @CLWorkStart
      ,[Phone] = @Phone
      ,[Agreement] = @Agreement
      ,[CLComm] = @CLComm
 WHERE [ID_Client] = @ID_Client
go

create procedure [dbo].[Client_LogDelete]
@ID_Client[int]
as
update [dbo].[Client] set [LogicDelete] = 1 where @ID_Client = [ID_Client]
update [dbo].[Abonement] set [LogicDelete] = 1 where @ID_Client = [ID_Client]
declare @Count1 [int] = (select count (*) from [dbo].[Abonement])
while @Count1 > 0 
begin
if (select [ID_Client] from [dbo].[Abonement] where [ID_Abonement] = @Count1) = @ID_Client
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Abonement] = @Count1
set @Count1 = @Count1 - 1
end
go

create procedure [dbo].[Theme_Insert](@Theme_Name [varchar] (40), @ThemeAbout [text])
as
if (select count (*) from [dbo].[Themes] where [ThemeName] = @Theme_Name) = 0
insert into [dbo].[Themes](ThemeName,[ThemeAbout],[LogicDelete])
values (@Theme_Name,@ThemeAbout,0)
go

create procedure [dbo].[Theme_Update](@ID_Theme [int], @Theme_Name [varchar] (40), @ThemeAbout [text])
as
if @ID_Theme > 0
if ((select count (*) from [dbo].[Themes] where [ThemeName] = @Theme_Name) = 0) or (@Theme_Name = (select [ThemeName] from [dbo].[Themes] where [ID_Theme] = @ID_Theme))
update [dbo].[Themes] set
[ThemeName] = @Theme_Name,
[ThemeAbout] = @ThemeAbout
where
[ID_Theme] = @ID_Theme
go

create procedure [dbo].[Theme_LogDelete](@ID_Theme [int])
as
if @ID_Theme >0
begin
update [dbo].[Themes] set [LogicDelete] = 1 where [ID_Theme] = @ID_Theme
update [dbo].[Group] set [LogicDelete] = 1 where [Theme_ID] = @ID_Theme
declare @Count [int] = (select count (*) from [dbo].[Group])
while @Count > 0 
begin
if (select [Theme_ID] from [dbo].[Group] where [ID_Group] = @Count) = @ID_Theme
begin
update [dbo].[Abonement] set [LogicDelete] = 1 where [ID_Group] = @Count
update [dbo].[Work] set [LogicDelete] = 1 where [ID_Group] = @Count
declare @Count1 [int] = (select count (*) from [dbo].[Abonement])
while @Count1 > 0 
begin
if (select [ID_Group] from [dbo].[Abonement] where [ID_Abonement] = @Count1) = @Count
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Abonement] = @Count1
set @Count1 = @Count1 - 1
end
declare @Count2 [int] = (select count (*) from [dbo].[Work])
while @Count2 > 0 
begin
if (select [ID_Group] from [dbo].[Work] where [ID_Work] = @Count2) = @Count
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Work] = @Count2
set @Count2 = @Count2 - 1
end
end
set @Count = @Count - 1
end
end
go

create procedure [dbo].[Group_Insert](@Workplace_ID [int], @Theme_ID [int], @Trainer_ID [int], @Abon_Cost [int])
as
if (@Abon_Cost >= 0)
insert into [dbo].[Group](WorkPlace_ID,Theme_ID,Trainer_ID,Abon_Cost,LogicDelete)
values (@Workplace_ID,@Theme_ID,@Trainer_ID,@Abon_Cost,0)
go

create procedure [dbo].[Group_Update](@ID_Group [int],@Workplace_ID [int], @Theme_ID [int], @Trainer_ID [int], @Abon_Cost [int])
as
if (@ID_Group >0)
if (@Abon_Cost >= 0)
update [dbo].[Group] set
[Workplace_ID] = @Workplace_ID,
[Theme_ID] = @Theme_ID,
[Trainer_ID] = @Trainer_ID,
[Abon_Cost] = @Abon_Cost
where
[ID_Group] = @ID_Group
go

create procedure [dbo].[Group_LogicDelete](@ID_Group [int])
as
if @ID_Group > 0
begin
update [dbo].[Group] set [LogicDelete] = 1 where [ID_Group] = @ID_Group
update [dbo].[Abonement] set [LogicDelete] = 1 where [ID_Group] = @ID_Group
update [dbo].[Work] set [LogicDelete] = 1 where [ID_Group] = @ID_Group
declare @Count [int] = (select count (*) from [dbo].[Abonement])
while @Count >0
begin
if (select [ID_Group] from [dbo].[Abonement] where [ID_Abonement] = @Count) = @ID_Group
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Abonement] = @Count 
set @Count = @Count - 1
end
declare @Count1 [int] = (select count (*) from [dbo].[Work])
while @Count1 >0
begin
if (select [ID_Group] from [dbo].[Work] where [ID_Work] = @Count) = @ID_Group
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Work] = @Count 
set @Count1 = @Count1 - 1
end
end
go

create function [dbo].[Test_Work](@Group_ID [int], @Work_Day [varchar] (2), @Work_Time [varchar] (5), @Work_Length [varchar] (5))
returns [bit]
with execute as caller
as
begin
declare @Ret [bit] = 1
declare @Workplace_ID [int] = (select [WorkPlace_ID] from [dbo].[Group] where [ID_Group] = @Group_ID)
declare @Trainer_ID [int] = (select [Trainer_ID] from [dbo].[Group] where [ID_Group] = @Group_ID)
declare @GCount [int] = (select count(*) from [dbo].[Group])
declare @GroupID [int] = 0
declare @WTToMin [int] = (Convert([int],SUBSTRING(@Work_Time,1,2)))*60 + (Convert([int],SUBSTRING(@Work_Time,4,2)))
declare @WLToMin [int] = (Convert([int],SUBSTRING(@Work_Length,1,2)))*60 + (Convert([int],SUBSTRING(@Work_Length,4,2)))
while @GCount>1
begin
set @GroupID = (select [ID_Group] from (select row_number() over (order by [ID_Group]) as n, [ID_Group] from [dbo].[Group]) x where n = @GCount)
if ((@WorkPlace_ID = (select [WorkPlace_ID] from [dbo].[Group] where [ID_Group] = @GroupID)) or (@Trainer_ID = (select [Trainer_ID] from [dbo].[Group] where [ID_Group] = @GroupID)))
if ((select count (*) from [dbo].[Work] where ([ID_Group] = @GroupID) and (LogicDelete = 0) and ([WorkDay] = @Work_Day) and (((@WTToMin>=(Convert([int],SUBSTRING([Work_Time],1,2)))*60 + (Convert([int],SUBSTRING([Work_Time],4,2)))) and (@WTToMin<=(Convert([int],SUBSTRING([Work_Length],1,2)))*60 + (Convert([int],SUBSTRING([Work_Length],4,2))))) or ((@WLToMin>=(Convert([int],SUBSTRING([Work_Time],1,2)))*60 + (Convert([int],SUBSTRING([Work_Time],4,2)))) and (@WLToMin<=(Convert([int],SUBSTRING([Work_Length],1,2)))*60 + (Convert([int],SUBSTRING([Work_Length],4,2))))) or ((@WTToMin<=(Convert([int],SUBSTRING([Work_Time],1,2)))*60 + (Convert([int],SUBSTRING([Work_Time],4,2)))) and (@WLToMin>=(Convert([int],SUBSTRING([Work_Length],1,2)))*60 + (Convert([int],SUBSTRING([Work_Length],4,2)))))))>0)
set @Ret = 0
set @GCount = @GCount -1
end
return @Ret
end
go

create procedure [dbo].[Work_Insert](@Group_ID [int], @WorkDay [varchar] (2), @Work_Time [varchar] (5),@Work_Length [varchar] (5))
as
insert into [dbo].[Work]([ID_Group],[WorkDay],[Work_Time],[Work_Length])
values (@Group_ID,@WorkDay,@Work_Time,@Work_Length)
GO


create procedure [dbo].[Work_Update](@ID_Work [int], @Group_ID [int], @WorkDay [varchar] (2), @Work_Time [varchar] (5), @Work_Length [varchar] (5))
as
if @ID_Work>0
begin
declare @Work_Test [bit] = (select [dbo].[Test_Work](@Group_ID,@WorkDay,@Work_Time,@Work_Length))
declare @STH [int] = convert([int],SUBSTRING(@Work_Time,1,2))
declare @STM [int] = convert([int],SUBSTRING(@Work_Time,4,2))
declare @ETH [int] = convert([int],SUBSTRING(@Work_Length,1,2))
declare @ETM [int] = convert([int],SUBSTRING(@Work_Length,4,2))
declare @Out [bit] = 0
if (@STH>@ETH)
set @Out = 1
ELSE
if (@STH=@ETH)
if (@STM>=@ETM)
set @Out = 1
if (@Work_Test = 0) and (@WorkDay = 'ÏÍ' or @WorkDay = 'ÂÒ' or @WorkDay = 'ÑÐ' or @WorkDay = '×Ò' or @WorkDay = 'ÏÒ' or @WorkDay = 'ÑÁ' or @WorkDay = 'ÂÑ') and (@Out=0)
update [dbo].[Work] set
[ID_Group] = @Group_ID,
[WorkDay] = @WorkDay,
[Work_Time] = @Work_Time,
[Work_Length] = @Work_Length
where
[ID_Work] = @ID_Work
end
go


create procedure [dbo].[Work_LogDelete](@ID_Work [int])
as
update [dbo].[Work] set [LogicDelete] = 1 where [ID_Work] = @ID_Work
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Work] = @ID_Work
go

create procedure [dbo].[Action_Insert](@ActionProc [int], @ActionProperties [text], @Action_Start_Date [varchar] (10), @Action_End_Date [varchar] (10))
as
insert into [dbo].[Action](ActionProc,ActionProperties,Action_Start_Date,Action_End_Date)
values (@ActionProc,@ActionProperties,@Action_Start_Date,@Action_End_Date)
go


create procedure [dbo].[Action_LogDelete]
@ID_Action[int]
as
update [dbo].[Action] set [LogicDelete] = 1 where @ID_Action = [ID_Action]
update [dbo].[Abonement] set [LogicDelete] = 1 where @ID_Action = [ID_Action]
declare @Count1 [int] = (select count (*) from [dbo].[Abonement])
while @Count1 > 0 
begin
if (select [ID_Action] from [dbo].[Abonement] where [ID_Abonement] = @Count1) = @ID_Action
update [dbo].[Newcoming] set [LogicDelete] = 1 where [ID_Abonement] = @Count1
set @Count1 = @Count1 - 1
end
go

create function [dbo].[AbonActCheck](
@Action_ID [int],@Start [varchar] (10))
returns [bit]
with execute as caller
as
begin
declare @Ret [bit]
declare @DateStart [date] = CONVERT([date],@Start)
declare @DateActionStart [date] = CONVERT([date],(select [Action_Start_Date] from [dbo].[Action] where [ID_Action] = @Action_ID))
declare @DateActionEnd [date] = CONVERT([date],(select [Action_End_Date] from [dbo].[Action] where [ID_Action] = @Action_ID))
if (@DateActionStart<=@DateStart) and (@DateActionEnd>=@DateStart)
set @Ret = 1
else
set @Ret = 0
return @Ret
end
go

create procedure [dbo].[Clear]
as
delete from [dbo].[Abonement] where [LogicDelete] = 1
delete from [dbo].[Action] where [LogicDelete] = 1
delete from [dbo].[Client] where [LogicDelete] = 1
delete from [dbo].[Filials] where [LogicDelete] = 1
delete from [dbo].[Group] where [LogicDelete] = 1
delete from [dbo].[Managers] where [LogicDelete] = 1
delete from [dbo].[Newcoming] where [LogicDelete] = 1
delete from [dbo].[Themes] where [LogicDelete] = 1
delete from [dbo].[Trainers] where [LogicDelete] = 1
delete from [dbo].[Work] where [LogicDelete] = 1
delete from [dbo].[WorkPlaces] where [LogicDelete] = 1
go

create procedure [dbo].[WorkPlace_Insert]  @ID_Filial [int], @WorkPlace_Location [varchar](40)
as
insert into [dbo].[WorkPlaces]([ID_Filial],[WorkPlaceLocation])
values (@ID_Filial,@WorkPlace_Location)
go

create procedure [dbo].[WorkPlace_Update] @WorkPlace_ID [int],@ID_Filial [int], @WorkPlace_Location [varchar](40)
as
if @WorkPlace_ID > 0
update [dbo].[WorkPlaces] set
[ID_Filial] = @ID_Filial,
[WorkPlaceLocation] = @WorkPlace_Location
where
[ID_WorkPlace] = @WorkPlace_ID
go

create procedure [dbo].[WorkPlace_LogicDelete] @WorkPlace_ID [int]
as
if @WorkPlace_ID > 0
update [dbo].[WorkPlaces] set
[LogicDelete] = 1
where
[ID_WorkPlace] = @WorkPlace_ID
declare @Count [int] = (select count (*) from [dbo].[Group])
declare @WPID [int] = 0
while @Count >0
begin
set @WPID = (select [ID_Group] from (select row_number() over (order by [ID_Group]) as n, [ID_Group] from [dbo].[Group]) X where n = @Count)
EXEC [dbo].[Group_LogicDelete] @WPID
end
go

create procedure [dbo].[Filial_Insert] @Filial_Name [varchar] (40), @Filial_Adress [varchar] (max)
as
insert into [dbo].[Filials]([FilialName],[FilialAdress],[LogicDelete])
values (@Filial_Name,@Filial_Adress,0)
go

create procedure [dbo].[Filial_Update] @Filial_ID [int],@Filial_Name [varchar] (40), @Filial_Adress [varchar] (max)
as
if @Filial_ID > 0
update [dbo].[Filials] set
[FilialName] = @Filial_Name,
[FilialAdress] = @Filial_Adress
where
[ID_Filial] = @Filial_ID
go

create procedure [dbo].[Filial_LogicDelete] @Filial_ID [int]
as
if @Filial_ID > 0
update [dbo].[Filials] set
[LogicDelete] = 1
where
[ID_Filial] = @Filial_ID
declare @Count [int] = (select count (*) from [dbo].[WorkPlaces])
declare @WPID [int] = 0
while @Count >0
begin
set @WPID = (select [ID_WorkPlace] from (select row_number() over (order by [ID_WorkPlace]) as n, [ID_WorkPlace] from [dbo].[WorkPlaces]) X where n = @Count)
EXEC [dbo].[WorkPlace_LogicDelete] @WPID
end
go

create procedure [dbo].[RevokeManager]
as
update [dbo].[Client] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Abonement] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Action] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Newcoming] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[WorkPlaces] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Filials] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Managers] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Trainers] set [LogicDelete] = 0 where [LogicDelete] = 1
go

create procedure [dbo].[RewokeTrainer]
as
update [dbo].[Group] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Work] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Themes] set [LogicDelete] = 0 where [LogicDelete] = 1
update [dbo].[Trainers] set [LogicDelete] = 0 where [LogicDelete] = 1
go