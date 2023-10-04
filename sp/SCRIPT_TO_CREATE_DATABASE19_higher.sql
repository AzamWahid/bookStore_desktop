
USE [master]
GO
/****** Object:  Database [bookStore]    Script Date: 04/10/2023 3:23:31 PM ******/
CREATE DATABASE [bookStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bookStore', FILENAME = N'C:\windows\temp\bookStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bookStore_log', FILENAME = N'C:\windows\temp\bookStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bookStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bookStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bookStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bookStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bookStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bookStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bookStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [bookStore] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [bookStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bookStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bookStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bookStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bookStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bookStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bookStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bookStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bookStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bookStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bookStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bookStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bookStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bookStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bookStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bookStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bookStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [bookStore] SET  MULTI_USER 
GO
ALTER DATABASE [bookStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bookStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bookStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bookStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bookStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bookStore] SET QUERY_STORE = OFF
GO
USE [bookStore]
GO
/****** Object:  Table [dbo].[book]    Script Date: 04/10/2023 3:23:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book](
	[book_ID] [varchar](50) NOT NULL,
	[book_Name] [varchar](50) NULL,
	[book_Author] [varchar](50) NULL,
	[book_Description] [varchar](50) NULL,
	[edition] [int] NULL,
 CONSTRAINT [PK_book] PRIMARY KEY CLUSTERED 
(
	[book_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[book] ([book_ID], [book_Name], [book_Author], [book_Description], [edition]) VALUES (N'01', N'THE ALCHEMIST', N'PAULO1 COELHO', N'WHESN YOU WANT SOMETHING, ALL THE UNIVERSE CONSPIR', 1)
GO
INSERT [dbo].[book] ([book_ID], [book_Name], [book_Author], [book_Description], [edition]) VALUES (N'02', N'HARRY POTTER', N'JOANNE K. ROWLING', N'T MATTERS NOT WHAT SOMEONE IS BORN, BUT WHAT THEY ', 1)
GO
INSERT [dbo].[book] ([book_ID], [book_Name], [book_Author], [book_Description], [edition]) VALUES (N'03', N'MEASURING THE WORLD', N'DANIEL KEHLMANN', N'THIS INCREDIBLY FUNNY AND IRONIC NOVEL', 2)
GO
INSERT [dbo].[book] ([book_ID], [book_Name], [book_Author], [book_Description], [edition]) VALUES (N'05', N'DAFDSF', N'ASDFA', N'DASF', 5555)
GO
INSERT [dbo].[book] ([book_ID], [book_Name], [book_Author], [book_Description], [edition]) VALUES (N'06', N'KKKA', N'ASDASD', N'FASFASDF', 5)
GO
INSERT [dbo].[book] ([book_ID], [book_Name], [book_Author], [book_Description], [edition]) VALUES (N'08', N'SSASD', N'DASD', N'SDSD', 5)
GO
ALTER TABLE [dbo].[book] ADD  CONSTRAINT [DF_book_edition]  DEFAULT ((0)) FOR [edition]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBook]    Script Date: 04/10/2023 3:23:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteBook]
	-- Add the parameters for the stored procedure here
	
		@book_ID varchar(50)

--	exec [sp_getBookEdit]'01'
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		delete book
		where book_ID = @book_ID

END
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookEdit]    Script Date: 04/10/2023 3:23:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_getBookEdit]
	-- Add the parameters for the stored procedure here
	
		@book_ID varchar(50)

--	exec [sp_getBookEdit]'01'
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select book_ID,book_Name,book_Author,book_Description,edition
		from book
		where book_ID = @book_ID

END
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookList]    Script Date: 04/10/2023 3:23:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
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
	
		select book_ID,book_Name,book_Author,book_Description,edition
		from book

END
GO
/****** Object:  StoredProcedure [dbo].[sp_SaveBook]    Script Date: 04/10/2023 3:23:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_SaveBook]
	-- Add the parameters for the stored procedure here
	
	@EntryMode varchar(255),
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
    if @EntryMode = 'Add'
	Insert into book (book_ID, book_Name, book_Author, book_Description, edition)
				 values (@book_ID, @book_Name, @book_Author, @book_Description, @edition)
	else
	Update book set book_ID=@book_ID, book_Name=@book_Name, book_Author=@book_Author, book_Description=@book_Description,edition=@edition
	WHERE book_ID=@book_ID
				 
END
GO
USE [master]
GO
ALTER DATABASE [bookStore] SET  READ_WRITE 
GO
