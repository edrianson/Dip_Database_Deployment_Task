CREATE TABLE [dbo].[Book]
(
	[ISBN] NCHAR(13) NOT NULL PRIMARY KEY, 
	[title] TEXT NOT NULL, 
	[year] DATE NOT NULL, 
	[authorId] NCHAR(8) NOT NULL, 
	[studentId] NCHAR(8) NULL, 

	FOREIGN KEY ([authorId]) REFERENCES [Person]([id]), 
	FOREIGN KEY ([studentId]) REFERENCES [Person]([id])
)