CREATE TABLE [dbo].[BlobPosts] (
    [Id]               UNIQUEIDENTIFIER NOT NULL,
    [Title]            NVARCHAR (MAX)   NOT NULL,
    [Content]          NVARCHAR (MAX)   NOT NULL,
    [FeaturedImageUrl] NVARCHAR (MAX)   NOT NULL,
    [UrlHandle]        NVARCHAR (MAX)   NOT NULL,
    [PublishedDate]    DATETIME2 (7)    NOT NULL,
    [Author]           NVARCHAR (MAX)   NOT NULL,
    [IsVisible]        BIT              NOT NULL,
    CONSTRAINT [PK_BlobPosts] PRIMARY KEY CLUSTERED ([Id] ASC)
);

