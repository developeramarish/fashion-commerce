﻿CREATE TABLE [dbo].[D_ATTRIBUTE_VALUE] (
    [ID]          INT          IDENTITY (1, 1) NOT NULL,
    [AttributeID] INT          NOT NULL,
    [Value]       VARCHAR (50) NULL,
    [ShowOrder]   INT          NOT NULL,
    CONSTRAINT [PK_ATTRIBUTE_VALUE] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_D_ATTRIBUTE_VALUE_D_ATTRIBUTE] FOREIGN KEY ([AttributeID]) REFERENCES [dbo].[D_ATTRIBUTE] ([ID])
);

