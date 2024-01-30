use TrainingDB
insert into Dept(Dept_Code,Dept_name) values ('D0003','Products'),('D0004','Sales')

insert into Employee(Id,Name,JoinDate,Salary,Dept_Code) values (3,'Varun',GETDATE(),89000,'D001'),
(44,'Ram',GETDATE(),43000,'D001'),
(89,'Ranjith',GETDATE(),69000,'D0003'),
(22,'Rohan',GETDATE(),49000,'D002'),
(33,'Panikkar',GETDATE(),69500,'D0003'),
(43,'Aarya',GETDATE(),90000,'D002'),
(36,'Aman',GETDATE(),59000,'D0003'),
(39,'Amal',GETDATE(),89800,'D002'),
(30,'Anna',GETDATE(),83300,'D0004'),
(37,'Adithya',GETDATE(),49800, null),
(49,'Ajay',getdate(), 38976,null )

select * from Dept
select * from Employee