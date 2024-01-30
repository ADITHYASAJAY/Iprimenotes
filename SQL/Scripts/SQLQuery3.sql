
--composite primary key
create table student(
[sid] int,
[name] varchar(30) not null,
class varchar(30) not null,
section char(1) not null,
mobile varchar(20),
constraint com_pk primary key([sid],mobile)
)

insert into student values(1,'Rohan','3','A',9898989898)
insert into student values (2,'Kenus','5','B',9898989898)
insert into student values (3,'James','6','A',9898989098)
select * from student
create table person (pid int identity(1,1) primary key,[name] varchar(20) not null)
insert into person values ('James')
insert into person values ('Manoj')
select * from person