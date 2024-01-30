--create a procedure to add a new student details

create procedure add_student(@sid int,@sname varchar(20),@class varchar(20),@section char(5),@mobile varchar(20))

as

begin

insert into student values(@sid,@sname,@class,@section,@mobile)

end

exec add_student 4,'Usama','4','A','9098909890'

exec add_student @sid=4,@sname='Harsha',@class='v',@section='A',@mobile='9898989090'

--create a procedure to fetch students from a particular class

create procedure select_stud_by_class(@class varchar(10))

as

begin

select*from student where class=@class

end

exec select_stud_by_class '4'