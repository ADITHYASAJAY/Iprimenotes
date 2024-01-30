create procedure Greet
as
begin
print 'Welcome to SqlServer!!!'
end
---execute procedure
exec Greet

create procedure sp_add(@a int, @b int)
as
begin
declare @result int
set @result=@a+@b
print @result
select @result as Result
end

exec sp_add 12,34

