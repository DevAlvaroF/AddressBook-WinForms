CREATE DATABASE AddressBook;
GO

USE AddressBook;
GO

CREATE TABLE [dbo].[ContactsTable] (
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date_Added] [datetime] NOT NULL,
	[Company] [nvarchar](200) NULL,
	[Website] [varchar](max) NULL,
	[Title] [nvarchar](100) NULL,
	[First_Name] [nvarchar](100) NULL,
	[Last_Name] [nvarchar](100) NULL,
	[Address] [nvarchar](100) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](100) NULL,
	[Postal_Code] [varchar](50) NULL,
	[Email] [varchar](320) NULL,
	[Mobile] [varchar](50) NULL,
	[Notes] [nvarchar](1000) NULL,
	PRIMARY KEY (ID)
);
GO

ALTER DATABASE SCOPED CONFIGURATION
SET identity_cache=OFF
GO

SELECT * FROM [dbo].[ContactsTable]

BULK INSERT [dbo].[ContactsTable]
FROM "D:\Portfolio\AddressBook-WinForms\SampleContacts.csv"
WITH
(
	FIRSTROW=2,
	FIELDTERMINATOR=';',
	ROWTERMINATOR='\n'
)

ALTER TABLE [dbo].[ContactsTable]
ADD [Image] [varbinary](max) NULL DEFAULT(NULL);