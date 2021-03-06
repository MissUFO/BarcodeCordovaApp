﻿CREATE TABLE [conf].[AppSettings] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Key]        NVARCHAR (255)  NOT NULL,
    [Value]       NVARCHAR (1024) NULL,
    [CreatedOn]   DATETIME       CONSTRAINT [DF_AppSettings_CreatedOn] DEFAULT (getdate()) NULL,
    [ModifiedOn]  DATETIME       CONSTRAINT [DF_AppSettings_ModifiedOn] DEFAULT (getdate()) NULL,
    CONSTRAINT [PK_AppSettings] PRIMARY KEY CLUSTERED ([Id] ASC)
);



