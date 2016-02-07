﻿CREATE TABLE [dbo].[EMAIL] (
    [Id]    INT          IDENTITY (1, 1) NOT NULL,
    [Email] VARCHAR (50) NULL,
    CONSTRAINT [PK_EMAIL] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_EMAIL] UNIQUE NONCLUSTERED ([Email] ASC)
);

