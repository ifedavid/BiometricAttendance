CREATE PROC addlecturer_
@Lec_UsrNm varchar(50),
@Lec_PassWord varchar(50)

AS 
INSERT INTO Lecturer_Table(Lec_UserName, Lec_PassWord)
VALUES(@Lec_UsrNm,@Lec_PassWord);
