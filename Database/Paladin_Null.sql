USE [Paladin_Quest]
GO

INSERT INTO [dbo].[Filials]
           ([FilialName]
           ,[LogicDelete]
           ,[FilialAdress])
     VALUES
           ('none'
           ,0
           ,'none')
GO

INSERT INTO [dbo].[WorkPlaces]
           ([WorkPlaceLocation]
           ,[LogicDelete]
           ,[ID_Filial])
     VALUES
           ('none'
           ,0
           ,0)
GO

INSERT INTO [dbo].[Themes]
           ([ThemeName]
           ,[ThemeAbout]
           ,[LogicDelete])
     VALUES
           ('none'
           ,'none'
           ,0)
GO

INSERT INTO [dbo].[Action]
           ([ActionProc]
           ,[ActionProperties]
           ,[Action_Start_Date]
           ,[Action_End_Date]
           ,[LogicDelete])
     VALUES
           (0
           ,'none'
           ,'01.01.0001'
           ,'31.12.3000'
           ,0)
GO

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
           ('none'
           ,'none'
           ,'none'
           ,'муж'
           ,'01.01.0001'
           ,'02.01.0001'
           ,'+79123456789'
           ,null
           ,'none'
           ,0)
GO

INSERT INTO [dbo].[Trainers]
           ([TrainerFirstName]
           ,[TrainerSecondName]
           ,[TrainerLastName]
           ,[TrainerCategory]
           ,[TrainerLogin]
           ,[TrainerPassword]
           ,[LogicDelete])
     VALUES
           ('Admin'
           ,'Admin'
           ,'Admin'
           ,'старший'
           ,'root'
           ,'root'
           ,0)
GO


INSERT INTO [dbo].[Group]
           ([WorkPlace_ID]
           ,[Theme_ID]
           ,[Trainer_ID]
           ,[Abon_Cost]
           ,[LogicDelete])
     VALUES
           (0
           ,0
           ,0
           ,1
           ,0)
GO

INSERT INTO [dbo].[Work]
           ([WorkDay]
           ,[Work_Time]
           ,[Work_Length]
           ,[LogicDelete]
           ,[ID_Group])
     VALUES
           ('ПН'
           ,'00:00'
           ,'23:59'
           ,0
           ,0)
GO

INSERT INTO [dbo].[Abonement]
           ([Abonement_Start_Date]
           ,[Abonement_End_Date]
           ,[Abonement_Cost]
           ,[ID_Client]
           ,[ID_Action]
           ,[ID_Group]
           ,[LogicDelete])
     VALUES
           ('01.01.0001'
           ,'31.12.2001'
           ,'0'
           ,0
           ,0
           ,0
           ,0)
GO

INSERT INTO [dbo].[Newcoming]
           ([Newcoming_Date]
           ,[ID_Work]
           ,[ID_Abonement]
           ,[LogicDelete])
     VALUES
           ('01.01.0001'
           ,0
           ,0
           ,0)
GO

INSERT INTO [dbo].[Managers]
           ([ManagerFirstName]
           ,[ManagerSecondName]
           ,[ManagerLastName]
           ,[ManagerLogin]
           ,[ManagerPassword]
           ,[LogicDelete])
     VALUES
           ('Admin'
           ,'Admin'
           ,'Admin'
           ,'root'
           ,'root'
           ,0)
GO

