SELECT * FROM Schools
SELECT * FROM Classes
SELECT * FROM Sections
SELECT * FROM Lessons
SELECT * FROM Tests
SELECT * FROM Questions
SELECT * FROM Answers
SELECT * FROM Results
SELECT * FROM users
SELECT * FROM roles

INSERT INTO Schools(Name) VALUES (N'Α Δημοτικό'),(N'Β Δημοτικό'),(N'Γ Δημοτικό')
INSERT INTO Classes(Name,SchoolId) VALUES(N'Α',1),(N'Β',1),(N'Γ',1),(N'Δ',1),(N'Ε',1),(N'ΣΤ',1)
INSERT INTO Sections(Name,ClassId) VALUES(N'Α1',1),(N'Α2',1),(N'Α3',1)
INSERT INTO Lessons(Name,ClassId,SectionId) VALUES(N'Μαθηματικά',1,1)
INSERT INTO Tests(Name,LessonId) VALUES(N'A Κεφάλαιο',1),(N'Β Κεφάλαιο',1),(N'Γ Κεφάλαιο',1),(N'Δ Κεφάλαιο',1)
INSERT INTO Questions(Name,TestId,CorrectAnswer) VALUES (N'2+2',1,N'4'),(N'2+5',1,N'7'),(N'3+2',1,N'5')
INSERT INTO Answers(QuestionId,Name) VALUES(1,N'5'),(2,N'7'),(3,N'5')
INSERT INTO roles(Name) VALUES(N'Student'),(N'Teacher'),(N'Admin')