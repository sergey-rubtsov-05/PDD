
CREATE TABLE "main"."Answers"(
	"Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
	"Name" TEXT,
	"QuestionId" INTEGER,
	"Right" INTEGER);


CREATE TABLE "main"."Questions"(
	"Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
	"Name" TEXT,
	"Description" TEXT,
	"TestId" INTEGER);


CREATE TABLE "main"."TestResultItems"(
	"Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
	"QuestionID" INTEGER,
	"AnswerId" INTEGER,
	"TestResultId" INTEGER);

CREATE TABLE "main"."TestResults"(
	"Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
	"PersonID" INTEGER,
	"Date" datetime,
	"TestID" INTEGER);

CREATE TABLE "main"."Tests"(
	"Id" INTEGER PRIMARY KEY  AUTOINCREMENT  NOT NULL , 
	"Description" TEXT);