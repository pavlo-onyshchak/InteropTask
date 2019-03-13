create procedure Verification
@Login nvarchar(30),
@Password nvarchar(30)
as
select * from Users where Username = @Login AND Password = @Password
go
