use TrainingDB


---create index

create nonclustered index name_non_cluster on person(name)

----
sp_helpindex person
create nonclustered index email_non_cluster on Participant(OfficialEmail)
create clustered index pid_cluster on Participant(ParticipantId)
sp_helpindex Participant
