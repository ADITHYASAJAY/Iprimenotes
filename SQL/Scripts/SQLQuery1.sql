create database TrainingDB
use TrainingDB

create table ParticipantList
(
	ParticipantID BIGINT Identity(1,1) Not null,
	FirstName varchar(30),
	LastName varchar(30),
	OfficialEmail Varchar(30)
)

Insert into ParticipantList values(
'Adithya','Ajay','07adithya@gmail.com'
)

Insert into ParticipantList values(
'Adi','Ajay','07adithya@gmail.com'
)

Select *
from ParticipantList

sp_rename 'ParticipantList','Participant'

Select *
from Participant