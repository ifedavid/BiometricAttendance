CREATE PROC AddAdmin
@UserName varchar(50),
@PassWord varchar(50)
AS
INSERT INTO Admin_DB(Username,Password)
VALUES (@UserName,@PassWord);