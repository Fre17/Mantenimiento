USE [prueba]
GO
/****** Object:  StoredProcedure [dbo].[PA_CreaUsuario]    Script Date: 06/09/2022 11:51:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Freddy Bogantes Sanchez>
-- Create date: <03/09/2022>
-- Description:	<Crea usuario>
-- =============================================
ALTER PROCEDURE [dbo].[PA_CreaUsuario]
	-- Add the parameters for the stored procedure here
	(@Nombre varchar(20),
	@Apellidos varchar(20),
	@Edad varchar(20),
	@Cedula varchar(20))
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Usuario(Cedula, Nombre, Apellidos, Edad)
	values (@Cedula, @Nombre, @Apellidos, @Edad)
END
