USE [School]
GO
/****** Object:  StoredProcedure [dbo].[BuscarCursoTitle]    Script Date: 9/10/2021 1:53:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BuscarCursoTitle]
@title nvarchar (50)
as
select * from Course where Title like '%'+@title+'%';
GO
