CREATE TABLE [dbo].[Person]
(
	[id] NCHAR(8) NOT NULL PRIMARY KEY, 
	[firstName] TEXT NOT NULL, 
	[lastName] TEXT NOT NULL, 
	[roleId] INT NOT NULL, 
	[mobilePhone] NCHAR(10) NULL, 
	[TFN] NCHAR(9) NULL, 
	
	FOREIGN KEY ([roleId]) REFERENCES [Role]([id])
)