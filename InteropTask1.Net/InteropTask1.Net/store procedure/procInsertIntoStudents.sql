create procedure InsertIntoStudents
@Name nvarchar(30),
@Surname nvarchar(30),
@AverageMark int
as
insert into Students(Name,Surname,AverageMark)
values(@Name,@Surname,@AverageMark)
go