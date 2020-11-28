select * from Schools
select * from Classes
select * from Sections
select * from Lessons
select * from Tests
select * from Questions
select * from Answers

insert into Schools(Name) values (N'Α Δημοτικό'),(N'Β Δημοτικό'),(N'Γ Δημοτικό')

insert into Classes(Name,SchoolId) values(N'Α',1),(N'Β',1),(N'Γ',1),(N'Δ',1),(N'Ε',1),(N'ΣΤ',1)

insert into Sections(Name,ClassId) values(N'Α1',1),(N'Α2',1),(N'Α3',1)

insert into Lessons(Name,ClassId,SectionId) values(N'Μαθηματικά',1,1)

insert into Tests(Name,LessonId) values(N'A Κεφάλαιο',1),(N'Β Κεφάλαιο',1),(N'Γ Κεφάλαιο',1),(N'Δ Κεφάλαιο',1)

insert into Questions(Name,TestId,CorrectAnswer) values (N'2+2',1,N'4'),(N'2+5',1,N'7'),(N'3+2',1,N'5')

insert into Answers(QuestionId,Name) values(1,N'5'),(2,N'7'),(3,N'5')

select * from Results
