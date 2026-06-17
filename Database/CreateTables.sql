CREATE TABLE Users
(
    Id INT PRIMARY KEY IDENTITY,
    FullName VARCHAR(100),
    Email VARCHAR(100),
    PasswordHash VARCHAR(255),
    CreatedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE Resumes
(
    Id INT PRIMARY KEY IDENTITY,
    CandidateName VARCHAR(100),
    Email VARCHAR(100),
    Skills VARCHAR(MAX),
    ATSScore INT,
    UploadedAt DATETIME DEFAULT GETDATE()
);

CREATE TABLE AnalysisReports
(
    Id INT PRIMARY KEY IDENTITY,
    ResumeId INT,
    MatchPercentage INT,
    MissingSkills VARCHAR(MAX)
);
);
