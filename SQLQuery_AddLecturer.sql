ALTER PROC addlecturer_
@Lec_ID varchar(50),
@Lec_PassWord varchar(50)
AS
INSERT INTO Lecturer_Table(Lec_ID, Lec_PassWord)
VALUES(@Lec_ID,@Lec_PassWord);

