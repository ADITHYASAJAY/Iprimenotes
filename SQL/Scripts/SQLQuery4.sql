select * from employee
insert into employee values(1,'Rohan','12.02.2020',45555,null)
insert into dept(dept_code,dept_name) values('D001','IT'),
											('D002','Admin')
											select * from dept

insert into employee(id,name,dept_code) values(2,'Cherry','D001')
select * from employee

--update
update employee set Salary=50000 where id=2
update employee set Salary=56000  where id =1
update employee set Dept_Code='D001'  where id =1
update employee set Salary= Salary+10000 where Dept_Code='D0001'

--delete
delete from employee -- all rows will delete
delete from employee where dept_code='D001' -- delete employee with dept as D001
delete from employee where id =2 --delete employee with id=2