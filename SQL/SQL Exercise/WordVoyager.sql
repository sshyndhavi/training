CREATE TABLE Users(
    UserId INT PRIMARY KEY,
    Username NVARCHAR(100),
    Email NVARCHAR(100),
    PasswordHash NVARCHAR(100),
    RegistrationDate DATETIME
);
