select * from Participant 
--add coloumn
alter table Participant add mobile varchar(20)
--drop coloumn 
alter table Participant drop column mobile
insert into Participant values ('james','ramsey','james@gmail.com','1234567890')
--change data type
alter table Participant alter column mobile varchar(10)
--add primary key
alter table Participant add constraint id_pk primary key(ParticipantID)

--drop constraints
alter table Participant drop constraint id_pk

sp_helpconstraint Participant
