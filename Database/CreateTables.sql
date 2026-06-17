CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY,
    FullName VARCHAR(100),
    Email VARCHAR(100),
    Password VARCHAR(100)
);

CREATE TABLE Resumes
(
    Id INT PRIMARY KEY IDENTITY,
    CandidateName VARCHAR(100),
    Email VARCHAR(100),
    Skills VARCHAR(MAX),
    ATSScore INT
);
