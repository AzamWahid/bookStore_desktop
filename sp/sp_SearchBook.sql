USE [bookStore]
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookList]    Script Date: 22/09/2023 12:37:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
alter PROCEDURE [dbo].[sp_SearchBook]
	-- Add the parameters for the stored procedure here
	@bookName varchar(50)
--	exec [sp_SearchBook]'m'
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
		select book_ID,book_Name,book_Author,book_Description,edition
		from book
		where book_Name like '%' +@bookName+'%'

END
