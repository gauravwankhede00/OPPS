CREATE TABLE [dbo].[BlogPostCategory] (
    [BlogPostsId]  UNIQUEIDENTIFIER NOT NULL,
    [CategoriesId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_BlogPostCategory] PRIMARY KEY CLUSTERED ([BlogPostsId] ASC, [CategoriesId] ASC),
    CONSTRAINT [FK_BlogPostCategory_BlobPosts_BlogPostsId] FOREIGN KEY ([BlogPostsId]) REFERENCES [dbo].[BlobPosts] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_BlogPostCategory_Categories_CategoriesId] FOREIGN KEY ([CategoriesId]) REFERENCES [dbo].[Categories] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_BlogPostCategory_CategoriesId]
    ON [dbo].[BlogPostCategory]([CategoriesId] ASC);

