
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/25/2019 11:32:58
-- Generated from EDMX file: C:\facultate\an3\sem2\advanced-topics-net\studies\Studies\Studies\Model1Container.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CUSTOMER];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CustomerTypeCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_CustomerTypeCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerEmailCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CustomerEmails] DROP CONSTRAINT [FK_CustomerEmailCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductProductCategory_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductProductCategory] DROP CONSTRAINT [FK_ProductProductCategory_Product];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductProductCategory_ProductCategory]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProductProductCategory] DROP CONSTRAINT [FK_ProductProductCategory_ProductCategory];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[CustomerEmails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerEmails];
GO
IF OBJECT_ID(N'[dbo].[CustomerTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CustomerTypes];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO
IF OBJECT_ID(N'[dbo].[ProductCategories]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductCategories];
GO
IF OBJECT_ID(N'[dbo].[ProductProductCategory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductProductCategory];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CustomerTypeId] int  NOT NULL,
    [CustomerEmailId] int  NOT NULL
);
GO

-- Creating table 'CustomerEmails'
CREATE TABLE [dbo].[CustomerEmails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [CustomerId] int  NOT NULL
);
GO

-- Creating table 'CustomerTypes'
CREATE TABLE [dbo].[CustomerTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductCategories'
CREATE TABLE [dbo].[ProductCategories] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoryName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductProductCategory'
CREATE TABLE [dbo].[ProductProductCategory] (
    [Products_Id] int  NOT NULL,
    [ProductCategories_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerEmails'
ALTER TABLE [dbo].[CustomerEmails]
ADD CONSTRAINT [PK_CustomerEmails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CustomerTypes'
ALTER TABLE [dbo].[CustomerTypes]
ADD CONSTRAINT [PK_CustomerTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductCategories'
ALTER TABLE [dbo].[ProductCategories]
ADD CONSTRAINT [PK_ProductCategories]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Products_Id], [ProductCategories_Id] in table 'ProductProductCategory'
ALTER TABLE [dbo].[ProductProductCategory]
ADD CONSTRAINT [PK_ProductProductCategory]
    PRIMARY KEY CLUSTERED ([Products_Id], [ProductCategories_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CustomerTypeId] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_CustomerTypeCustomer]
    FOREIGN KEY ([CustomerTypeId])
    REFERENCES [dbo].[CustomerTypes]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerTypeCustomer'
CREATE INDEX [IX_FK_CustomerTypeCustomer]
ON [dbo].[Customers]
    ([CustomerTypeId]);
GO

-- Creating foreign key on [CustomerId] in table 'CustomerEmails'
ALTER TABLE [dbo].[CustomerEmails]
ADD CONSTRAINT [FK_CustomerEmailCustomer]
    FOREIGN KEY ([CustomerId])
    REFERENCES [dbo].[Customers]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerEmailCustomer'
CREATE INDEX [IX_FK_CustomerEmailCustomer]
ON [dbo].[CustomerEmails]
    ([CustomerId]);
GO

-- Creating foreign key on [Products_Id] in table 'ProductProductCategory'
ALTER TABLE [dbo].[ProductProductCategory]
ADD CONSTRAINT [FK_ProductProductCategory_Product]
    FOREIGN KEY ([Products_Id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProductCategories_Id] in table 'ProductProductCategory'
ALTER TABLE [dbo].[ProductProductCategory]
ADD CONSTRAINT [FK_ProductProductCategory_ProductCategory]
    FOREIGN KEY ([ProductCategories_Id])
    REFERENCES [dbo].[ProductCategories]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductProductCategory_ProductCategory'
CREATE INDEX [IX_FK_ProductProductCategory_ProductCategory]
ON [dbo].[ProductProductCategory]
    ([ProductCategories_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------