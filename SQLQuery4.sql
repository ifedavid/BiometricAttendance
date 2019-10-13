CREATE PROC AddStudent
@FullName varchar(50),
@MatricNo varchar(50),
@Level varchar(50),
@Faculty varchar(50),
@Department varchar(50),
@Sex varchar(50),
@FingerPrint text
AS
INSERT INTO StudentTable(FullName,MatricNo,Level,Faculty,Department,Sex,FinerPrint)
VALUES (@FullName,@MatricNo,@Level,@Faculty,@Department,@Sex,@FingerPrint);