USE [bookStore]
GO
/****** Object:  StoredProcedure [dbo].[sp_getBookList]    Script Date: 23/09/2023 5:13:58 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_getBookList]
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
