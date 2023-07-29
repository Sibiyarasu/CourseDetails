

create PROCEDURE [dbo].[GetAllCourseDetails]
as
begin

select * from dbo.CourseDetailsInfo
end
GO

exec GetAllCourseDetails


create PROCEDURE [dbo].[GetCourseDetails]  (@courseId int )
as
begin

select * from dbo.CourseDetailsInfo where CourseId=@CourseId
end
GO

exec GetCourseDetails 7


Create   procedure [dbo].[InsertAllCourseDetails](@CourseName nvarchar(45),@Duration int,@University nvarchar(100) ,@StartDate datetime,@Seats int)
as

begin
insert into dbo.CourseDetailsInfo (CourseName,Duration,University,StartDate,Seats) values(@CourseName,@Duration,@University,@StartDate,@Seats)
end
GO



exec [InsertAllCourseDetails] 'm.com',3,'Anna University','09-07-2023',124



create  procedure [dbo].[updateCourseDetails] (@CourseId int,@University nvarchar(100))

as 
begin
update dbo.CourseDetailsInfo set 

University=@University
where CourseId=@CourseId

end 
GO

exec updateCourseDetails  3,'PSG'


create procedure [dbo].[DeleteCourseDetails] (@CourseId int)
as
begin

delete from dbo.CourseDetailsInfo where CourseId=@CourseId
end
GO

EXEC [DeleteCourseDetails] 3



