USE [bookStore]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBook]    Script Date: 09/22/2023 20:04:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DeleteBook]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_DeleteBook]
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookEdit]    Script Date: 09/22/2023 20:04:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getBookEdit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_getBookEdit]
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookList]    Script Date: 09/22/2023 20:04:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getBookList]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_getBookList]
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveBook]    Script Date: 09/22/2023 20:04:04 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_SaveBook]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_SaveBook]
GO
/****** Object:  Table [dbo].[book]    Script Date: 09/22/2023 20:04:08 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[book]') AND type in (N'U'))
DROP TABLE [dbo].[book]
GO
/****** Object:  Table [dbo].[book]    Script Date: 09/22/2023 20:04:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[book]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[book](
	[BK_ID] [int] IDENTITY(1,1) NOT NULL,
	[book_ID] [varchar](50) NULL,
	[book_Name] [varchar](50) NULL,
	[book_Author] [varchar](50) NULL,
	[book_Description] [varchar](50) NULL,
	[edition] [int] NULL,
 CONSTRAINT [PK_book_1] PRIMARY KEY CLUSTERED 
(
	[BK_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveBook]    Script Date: 09/22/2023 20:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_SaveBook]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[sp_SaveBook]
	-- Add the parameters for the stored procedure here
	
	@EntryMode varchar(255),
	@Bk_ID int,
	@book_ID varchar(50),
	@book_Name varchar(50),
	@book_Author varchar(50),
	@book_Description varchar(50),
	@edition int


AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
    if @EntryMode = ''Add''
	Insert into book (book_ID, book_Name, book_Author, book_Description, edition)
				 values (@book_ID, @book_Name, @book_Author, @book_Description, @edition)
	else
	Update book set book_ID=@book_ID, book_Name=@book_Name, book_Author=@book_Author, book_Description=@book_Description,edition=@edition
	WHERE BK_ID=@Bk_ID
				 
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookList]    Script Date: 09/22/2023 20:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getBookList]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_getBookList]
	-- Add the parameters for the stored procedure here
--	exec [sp_getBookList]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select book_ID,book_Name
		from book

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookEdit]    Script Date: 09/22/2023 20:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_getBookEdit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_getBookEdit]
	-- Add the parameters for the stored procedure here
	
		@book_ID varchar(50)

--	exec [sp_getBookEdit]''01''
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select [BK_ID],book_ID,book_Name,book_Author,book_Description,edition
		from book
		where book_ID = @book_ID

END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBook]    Script Date: 09/22/2023 20:04:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_DeleteBook]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteBook]
	-- Add the parameters for the stored procedure here
	
		@book_ID varchar(50)

--	exec [sp_getBookEdit]''01''
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		delete book
		where book_ID = @book_ID

END
' 
END
GO
