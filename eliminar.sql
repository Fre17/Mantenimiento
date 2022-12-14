USE [prueba]
GO
/****** Object:  StoredProcedure [dbo].[PA_EliminaUsuario]    Script Date: 06/09/2022 11:51:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Freddy Bogantes Sanchez>
-- Create date: <03/09/2022>
-- Description:	<Elimina usuario>
-- =============================================
ALTER PROCEDURE [dbo].[PA_EliminaUsuario]
	-- Add the parameters for the stored procedure here
	(@Cedula varchar(20))
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from Usuario where Cedula = @Cedula
END
