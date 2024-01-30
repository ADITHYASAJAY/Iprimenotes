create procedure add_Employee(@eid int,@ename varchar(30),@ejoiningDate date, @esalary int, @edeptcode char(5))
as
begin
	if(exists(select * from Employee where Id= @eid))
	begin
		print 'Cannot add already exists'
	end
	else
	begin
		insert into Employee values(@eid,@ename,@ejoiningDate,@esalary,@edeptcode)
	end
end

select * from Employee
exec add_Employee 4 ,'adithya s','2020.12.12',30000,'D001' 

--get all employees
create procedure get_Employee
as
begin
select * from Employee
end

exec get_Employee

--get all employees by dept

create procedure get_EmployeeByDept(@dept char(5))
as
begin
select * from Employee where Dept_Code=@dept
end

exec get_EmployeeByDept 'D001'

[2:26 PM] Alfiya Sainudeen
--edit employee details

create procedure update_employee(@id int,@name varchar(30),@joindate date,@salary int,@dept_code varchar(10))

as
 
begin

update Employee set  Name=@name ,JoinDate=@joindate,Salary=@salary  where Id=@id

end

exec update_employee 4,'aromal','2020-12-25',84000,'D0001'

select*from Employee




create procedure delete_employee(@eid int)
as
begin
	if(exists(select * from Employee where Id=@eid))
		begin
			delete from Employee where Id=@eid	
		end
	else
		begin
		print 'No Employee with such Id to delete'
		end
end

exec delete_employee 1


