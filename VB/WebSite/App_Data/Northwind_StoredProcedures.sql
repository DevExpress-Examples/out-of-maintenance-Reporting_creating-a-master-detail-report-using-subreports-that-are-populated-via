USE [Northwind]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spCategory]'))
	DROP PROCEDURE [dbo].[spCategory]
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spProducts]'))
	DROP PROCEDURE [dbo].[spProducts]
GO

CREATE PROCEDURE [spCategory]
	@CategoryID int
AS
	DECLARE @IDs TABLE
	(
		ID int
	)

	IF @CategoryID != -1
	BEGIN
		INSERT INTO @IDs
			SELECT @CategoryID
	END
	ELSE
	BEGIN
		INSERT INTO @IDs
			SELECT [CategoryID] FROM [Categories]
	END

	SELECT * FROM [Categories] WHERE [CategoryID] IN 
		(SELECT * FROM @IDs)
GO

CREATE PROCEDURE [spProducts]
	@CategoryID int
AS
	SELECT * FROM [Products] WHERE [CategoryID] = @CategoryID
GO