
create table CourseDetailsInfo

(
CourseId int primary key identity(1,1),
CourseName nvarchar(70),
Duration int,
University nvarchar(400),
StartDate datetime,
Seats int
);

select * from dbo.CourseDetailsInfo
--create procedure
create PROCEDURE GetAllCourseDetails
as
begin

select * from dbo.CourseDetailsInfo
end

EXEC GetAllCourseDetails


--insert record for procedure

Create procedure InsertAllCourseDetails(@CourseName nvarchar(45),@Duration int,@University nvarchar ,@StartDate datetime,@Seats int)
as

begin
insert into dbo.CourseDetailsInfo (CourseName,Duration,University,StartDate,Seats) values(@CourseName,@Duration,@University,@StartDate,@Seats)
end
exec InsertAllCourseDetails 'B.E',4,'Anna University', '07-12-2023',120






