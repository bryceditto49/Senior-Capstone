CREATE PROC UserAdd
@id int,
@username varchar(50),
@password nvarchar(50)
AS 
	INSERT INTO LoginTable(username, password)
	VALUES (@username,@password)