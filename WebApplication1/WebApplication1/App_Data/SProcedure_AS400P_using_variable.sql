USE [BI_VENTAS]
GO
/****** Object:  StoredProcedure [dbo].[SP_RPT_DetalleCotizacion]    Script Date: 01/08/2016 5:53:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[SP_RPT_DetalleCotizacion]
@numCotizacion varchar(20) AS

DECLARE @SQLQ NVARCHAR(MAX)

SET @SQLQ = 'SELECT * FROM OPENQUERY(AS400P, ''SELECT RFDCNO as Codigo_Documento, 
LNNO as Numero_Item,
PANO20 as Numero_Parte,
DS18 as Descripcion_Parte,
WTUM as Peso_Neto,
SOS1 as SOS ,
UNCS as Precio_Unit,
UNSEL as Precio_Ext ,
ORQY as STOCK,
PKQTY as SHIP,
BOIMCT as Back_Order
FROM LIBP16.PCPCOPD0 WHERE RFDCNO ='''''+ @numCotizacion + ''''''')'

EXEC sp_executesql @SQLQ

