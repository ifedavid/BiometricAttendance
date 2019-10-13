CREATE PROC AddCourse
@CourseCode varchar(50)
AS
INSERT Course(Course_Code)
VALUES (@CourseCode);