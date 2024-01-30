CREATE TABLE Users(
    UserId INT PRIMARY KEY,
    Username NVARCHAR(100),
    Email NVARCHAR(100),
    PasswordHash NVARCHAR(100),
    RegistrationDate DATETIME
);
 CREATE TABLE Category (
    CategoryId INT PRIMARY KEY,
    Name NVARCHAR(100),
    Description TEXT
);

CREATE TABLE Article (
    ArticleId INT PRIMARY KEY,
    Title NVARCHAR(100),
    Content TEXT,
    PublishedDate DATETIME,
    LastModifiedDate DATETIME,
    AuthorId INT,
    CategoryId INT,
    FOREIGN KEY (AuthorId) REFERENCES Users(UserId),
    FOREIGN KEY (CategoryId) REFERENCES Category(CategoryId),
);

CREATE TABLE Comment (
    CommentId INT PRIMARY KEY,
    ArticleId INT,
    UserId INT,
    Content TEXT,
    CommentDate DATETIME,
    FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId),
    FOREIGN KEY (UserId) REFERENCES [Users](UserId)
);

CREATE TABLE Tag (
    TagId INT PRIMARY KEY,
    Name NVARCHAR(100)
);


CREATE TABLE ArticleTag (
    ArticleId INT,
    TagId INT,
    FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId),
    FOREIGN KEY (TagId) REFERENCES Tag(TagId),
    PRIMARY KEY (ArticleId, TagId)
);
CREATE TABLE Attachment (
    AttachmentId INT PRIMARY KEY,
    ArticleId INT,
    FileName NVARCHAR(100),
    FileType NVARCHAR(100),
    FilePath NVARCHAR(100),
    UploadDate DATETIME,
    FOREIGN KEY (ArticleId) REFERENCES Article(ArticleId)
);
