/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
IF '$(LoadTestData)' = 'true' BEGIN
	DELETE FROM [Book];
	DELETE FROM [Person];
	DELETE FROM [Role];

	INSERT INTO Role ([id], [title]) VALUES
		(1, 'Student'),
		(2, 'Author');

	INSERT INTO Person ([id], [firstName], [lastName], [roleId], [mobilePhone], [TFN]) VALUES
		-- Students:
		-- Students' [Person]([id]) can be preceded with an 's' whenever necessary to suit business logic.
		-- Students' e-mail addresses can be reproduced just by concatenating [Student]([id]) with '@student.swin.edu.au'.
		('12345678', 'Fred', 'Flintstone', 1, '0400555111', NULL),
		('23456789', 'Barney', 'Rubble', 1, '0400555222', NULL),
		('34567890', 'Bam-Bam', 'Rubble', 1, '0400555333', NULL),
		-- Authors
		('32567', 'Edgar', 'Codd', 2, NULL, '150111222'),
		('76543', 'Vinton', 'Cerf', 2, NULL, '150222333'),
		('12345', 'Alan', 'Turing', 2, NULL, '150333444');

	INSERT INTO Book ([ISBN], [title], [year], [authorId], [studentId]) VALUES
		('9783161484100', 'Relationships with Databases, the ins and outs', '1970', '32567', NULL),
		('9783161484101', 'Normalisation, how to make a database geek fit in.', '1973', '32567', NULL),
		('9783161484102', 'TCP/IP, the protocol for the masses', '1983', '76543', NULL),
		('9783161484103', 'The Man, the Bombe, and the Enigma.', '1940', '12345', NULL);
END;
GO
