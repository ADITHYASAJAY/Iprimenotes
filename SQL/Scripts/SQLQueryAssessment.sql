create database assessment
use assessment

create table Subject(
subjectId int not null primary key,
subtitle varchar(20)
)

create table Book(
bookId 	int primary key,
title 	varchar(20) not null,
price 	int not null,
volume 	int not null, 
author  varchar(20) not null,
publishDate Date not null,
subjectId int not null
)

