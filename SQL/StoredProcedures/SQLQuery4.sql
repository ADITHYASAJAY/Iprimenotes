create procedure update_student(@sid int, @sname varchar(20),@class varchar(20))
as
begin
	if(exists(select * from student where sid=@sid))
		begin
		update student set class=@class where sid=@sid
		end
	else
		begin
		insert into student values(@sid,@sname,@class,'A','9878678754')
		end
end
exec update_student 100,'tarack','6'
exec update_student 1,'adithya','5'
select * from student