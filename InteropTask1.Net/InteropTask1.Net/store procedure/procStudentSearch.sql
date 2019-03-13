create procedure StudentSearch
@Name nvarchar(30),
@Surname nvarchar(30)
as
select  * from  Students
where Name = @Name AND Surname = @Surname
go