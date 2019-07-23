
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/11/2019 14:45:11
-- Generated from EDMX file: D:\Extend\ExtendClassLibrary\DataAccessLibrary\Model\DataEF.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Aoi];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CentralConfigHostContext]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HostContextSet] DROP CONSTRAINT [FK_CentralConfigHostContext];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CentralConfigSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CentralConfigSet];
GO
IF OBJECT_ID(N'[dbo].[HostContextSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HostContextSet];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CentralConfigSet'
CREATE TABLE [dbo].[CentralConfigSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Host] nchar(4000)  NOT NULL,
    [ProjectName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'HostContextSet'
CREATE TABLE [dbo].[HostContextSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CentralConfigId] int  NOT NULL,
    [ModelNo] smallint  NOT NULL,
    [ModelType] nvarchar(max)  NOT NULL,
    [ModelParameter] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [IsAdmin] bit  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CentralConfigSet'
ALTER TABLE [dbo].[CentralConfigSet]
ADD CONSTRAINT [PK_CentralConfigSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HostContextSet'
ALTER TABLE [dbo].[HostContextSet]
ADD CONSTRAINT [PK_HostContextSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CentralConfigId] in table 'HostContextSet'
ALTER TABLE [dbo].[HostContextSet]
ADD CONSTRAINT [FK_CentralConfigHostContext]
    FOREIGN KEY ([CentralConfigId])
    REFERENCES [dbo].[CentralConfigSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CentralConfigHostContext'
CREATE INDEX [IX_FK_CentralConfigHostContext]
ON [dbo].[HostContextSet]
    ([CentralConfigId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------