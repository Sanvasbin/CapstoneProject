CREATE TABLE [dbo].[Project]
(
	[ProjectId] INT PRIMARY KEY Identity (1,1), 
    [Name] NVARCHAR(50) NULL, 
    [StartDate] DATETIME NULL, 
    [WorkingHours] FLOAT NULL, 
    [ProjectOwner] INT NULL,
	[Description] NVARCHAR(MAX) NULL,
	CONSTRAINT FK_ProjectUser FOREIGN KEY (ProjectOwner) REFERENCES [User](UserId)
	
)
--USE [C:\USERS\LDS21\DESKTOP\CAPSTONEPROJECT-MASTER\CAPSTONEPROJECT-MASTER\CAPSTONEPROJECT\CAPSTONEPROJECT\DATABASE\SMARTPERTDB.MDF]
--Insert Into Project ( [Name],[StartDate],[WorkingHours],[ProjectOwner]) VALUES ('PertChart', '09/01/2019', '20', '1') 


--Select * FROM Project