create database Assignment1
use database Assignment1

create table  Customers(
	Customerid char(5) not null,
	CompanyName varchar(40) not null,
	contactName char(30) null,
	Address varchar(60) null,
	City char(15) null,
	Phone char(24) null,
	Fax char(24) null,
)

create table Orders(
	OrderId integer not null,
	customerId char(5) not null,
	Orderdate datetime null,
	Shippeddate datetime null,
	Freight money null,
	Shipname varchar(40) null,
	Shipaddres varchar(60) null,
	Quantity integer null
)

---Question 2

alter table Orders add  shipregion int null

--Question 3

alter table Orders alter column shipregion char(8) null

--Question 4

alter table Orders drop column shipregion

--Question 5

Insert into Orders values( 10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean' ,1)

--Question 6

alter table Orders add constraint date_df default getdate() for Orderdate

--Question 7

sp_rename 'Customers.city','Town'