USE [prueba]
GO
/****** Object:  StoredProcedure [dbo].[PA_ConsultaUsuario]    Script Date: 06/09/2022 11:51:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Freddy Bogantes Sanchez>
-- Create date: <03/09/2022>
-- Description:	<Consulta usuarios>
-- =============================================
ALTER PROCEDURE [dbo].[PA_ConsultaUsuario]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from Usuario
END
