create procedure DeleteStudent
@Name nvarchar(30),
@Surname nvarchar(30)
as
delete from  Students
where Name = @Name AND Surname = @Surname
go