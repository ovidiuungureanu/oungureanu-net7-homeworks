CREATE DATABASE ZooManagement ;
USE ZooManagement;

CREATE TABLE Caretaker
(
CaretakerId INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(50),  
WorkArea VARCHAR (300)
);

CREATE TABLE Animals
(
AnimalsId INT IDENTITY (1, 1) PRIMARY KEY,
Specie VARCHAR(50),
NrOfSpecimen INT
);

CREATE TABLE Ticket
(
TicketId INT IDENTITY(1,1) PRIMARY KEY,
Price INT,  
Validity VARCHAR (50)
);

INSERT INTO Ticket
VALUES (5, 'one day');
INSERT INTO Ticket
VALUES (25, 'one week');
INSERT INTO Ticket
VALUES (100, 'one month');

SELECT *
FROM Ticket;

INSERT INTO Caretaker
VALUES ('Vlad', 'cleans Lion cage and feeds snake');
INSERT INTO Caretaker
VALUES ('Alina', 'cleans Snake cage and feeds Eagle');
INSERT INTO Caretaker
VALUES ('Gabriel', 'cleans Aligator cage and feeds Lion');
INSERT INTO Caretaker
VALUES ('Marius', 'cleans Monkey cage and feeds Aligator');
INSERT INTO Caretaker
VALUES ('Irina', 'cleans Eagle cage and feeds Monkey');

SELECT *
FROM Caretaker;

INSERT INTO Animals
VALUES ('Monkey', 2);
INSERT INTO Animals
VALUES ('Aligator', 3);
INSERT INTO Animals
VALUES ('Lion', 6);
INSERT INTO Animals
VALUES ('Snake', 5);
INSERT INTO Animals
VALUES ('Eagle', 2);

SELECT *
FROM Animals;

CREATE TABLE Visitor
(
VisitorId INT IDENTITY(1,1) PRIMARY KEY,
DateOfEntry DATE,  
TicketId INT REFERENCES Ticket(TicketId)
);

INSERT INTO Visitor
VALUES ('January 23, 2023', 2);
INSERT INTO Visitor
VALUES ('January 10, 2023', 1);
INSERT INTO Visitor
VALUES ('January 2, 2023', 3);
INSERT INTO Visitor
VALUES ('December 15, 2023', 2);
INSERT INTO Visitor
VALUES ('December 15, 2023', 1);

SELECT *
FROM Visitor;

CREATE TABLE ZooDetails
(
Id INT IDENTITY(1,1) PRIMARY KEY,
AnimalsId INT REFERENCES Animals(AnimalsId),
CaretakerId INT REFERENCES Caretaker(CaretakerId),
VisitorId INT REFERENCES Visitor(VisitorId)
);

INSERT INTO ZooDetails
VALUES (4, 2, 3);

SELECT *
FROM ZooDetails;
