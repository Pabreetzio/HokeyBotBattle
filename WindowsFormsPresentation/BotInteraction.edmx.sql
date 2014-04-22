
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2014 00:20:09
-- Generated from EDMX file: C:\Users\Patrick\Projects\HockeyBotBattle\HokeyBotBattle\WindowsFormsPresentation\BotInteraction.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HockeyBotDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_BotActionActionCommand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionCommands] DROP CONSTRAINT [FK_BotActionActionCommand];
GO
IF OBJECT_ID(N'[dbo].[FK_ControllerCommandActionCommand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionCommands] DROP CONSTRAINT [FK_ControllerCommandActionCommand];
GO
IF OBJECT_ID(N'[dbo].[FK_ControllerLayoutActionCommand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActionCommands] DROP CONSTRAINT [FK_ControllerLayoutActionCommand];
GO
IF OBJECT_ID(N'[dbo].[FK_SerialCommandBotActionSerialCommand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BotActionSerialCommands] DROP CONSTRAINT [FK_SerialCommandBotActionSerialCommand];
GO
IF OBJECT_ID(N'[dbo].[FK_BotActionBotActionSerialCommand]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BotActionSerialCommands] DROP CONSTRAINT [FK_BotActionBotActionSerialCommand];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BotActions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BotActions];
GO
IF OBJECT_ID(N'[dbo].[ControllerCommands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ControllerCommands];
GO
IF OBJECT_ID(N'[dbo].[ControllerLayouts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ControllerLayouts];
GO
IF OBJECT_ID(N'[dbo].[ActionCommands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActionCommands];
GO
IF OBJECT_ID(N'[dbo].[SerialCommands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SerialCommands];
GO
IF OBJECT_ID(N'[dbo].[BotActionSerialCommands]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BotActionSerialCommands];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BotActions'
CREATE TABLE [dbo].[BotActions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NULL
);
GO

-- Creating table 'ControllerCommands'
CREATE TABLE [dbo].[ControllerCommands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NULL
);
GO

-- Creating table 'ControllerLayouts'
CREATE TABLE [dbo].[ControllerLayouts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ActionCommands'
CREATE TABLE [dbo].[ActionCommands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BotActionId] int  NOT NULL,
    [ControllerCommandId] int  NOT NULL,
    [ControllerLayoutId] int  NOT NULL
);
GO

-- Creating table 'SerialCommands'
CREATE TABLE [dbo].[SerialCommands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Value] nvarchar(max)  NULL
);
GO

-- Creating table 'BotActionSerialCommands'
CREATE TABLE [dbo].[BotActionSerialCommands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BotActionId] int  NOT NULL,
    [SerialCommandId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BotActions'
ALTER TABLE [dbo].[BotActions]
ADD CONSTRAINT [PK_BotActions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ControllerCommands'
ALTER TABLE [dbo].[ControllerCommands]
ADD CONSTRAINT [PK_ControllerCommands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ControllerLayouts'
ALTER TABLE [dbo].[ControllerLayouts]
ADD CONSTRAINT [PK_ControllerLayouts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ActionCommands'
ALTER TABLE [dbo].[ActionCommands]
ADD CONSTRAINT [PK_ActionCommands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SerialCommands'
ALTER TABLE [dbo].[SerialCommands]
ADD CONSTRAINT [PK_SerialCommands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BotActionSerialCommands'
ALTER TABLE [dbo].[BotActionSerialCommands]
ADD CONSTRAINT [PK_BotActionSerialCommands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [BotActionId] in table 'ActionCommands'
ALTER TABLE [dbo].[ActionCommands]
ADD CONSTRAINT [FK_BotActionActionCommand]
    FOREIGN KEY ([BotActionId])
    REFERENCES [dbo].[BotActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BotActionActionCommand'
CREATE INDEX [IX_FK_BotActionActionCommand]
ON [dbo].[ActionCommands]
    ([BotActionId]);
GO

-- Creating foreign key on [ControllerCommandId] in table 'ActionCommands'
ALTER TABLE [dbo].[ActionCommands]
ADD CONSTRAINT [FK_ControllerCommandActionCommand]
    FOREIGN KEY ([ControllerCommandId])
    REFERENCES [dbo].[ControllerCommands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ControllerCommandActionCommand'
CREATE INDEX [IX_FK_ControllerCommandActionCommand]
ON [dbo].[ActionCommands]
    ([ControllerCommandId]);
GO

-- Creating foreign key on [ControllerLayoutId] in table 'ActionCommands'
ALTER TABLE [dbo].[ActionCommands]
ADD CONSTRAINT [FK_ControllerLayoutActionCommand]
    FOREIGN KEY ([ControllerLayoutId])
    REFERENCES [dbo].[ControllerLayouts]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ControllerLayoutActionCommand'
CREATE INDEX [IX_FK_ControllerLayoutActionCommand]
ON [dbo].[ActionCommands]
    ([ControllerLayoutId]);
GO

-- Creating foreign key on [BotActionId] in table 'BotActionSerialCommands'
ALTER TABLE [dbo].[BotActionSerialCommands]
ADD CONSTRAINT [FK_BotActionBotActionSerialCommand]
    FOREIGN KEY ([BotActionId])
    REFERENCES [dbo].[BotActions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BotActionBotActionSerialCommand'
CREATE INDEX [IX_FK_BotActionBotActionSerialCommand]
ON [dbo].[BotActionSerialCommands]
    ([BotActionId]);
GO

-- Creating foreign key on [SerialCommandId] in table 'BotActionSerialCommands'
ALTER TABLE [dbo].[BotActionSerialCommands]
ADD CONSTRAINT [FK_SerialCommandBotActionSerialCommand]
    FOREIGN KEY ([SerialCommandId])
    REFERENCES [dbo].[SerialCommands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SerialCommandBotActionSerialCommand'
CREATE INDEX [IX_FK_SerialCommandBotActionSerialCommand]
ON [dbo].[BotActionSerialCommands]
    ([SerialCommandId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------