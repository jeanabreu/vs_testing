USE [BI_VENTAS]
GO
/****** Object:  StoredProcedure [dbo].[SP_RPT_ClienteCotizacion]    Script Date: 28/07/2016 2:32:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[SP_RPT_ClienteCotizacion]
@numCotizacion varchar(20)
as SELECT  TOP 10
	M.RFDCNO as Numero_De_Documento ,
	M.CUNO as Cuenta_Numero,
	M.STNO as Codigo_Tienda,
	M.CUNM as Nombre_Cliente, 
	M.CUADD1 as Direccion1,
	M.CUADD2 as Direccion2,
	M.CUADD3 as Direccion3,
	M.CUCYST as Ciudad,
	M.ORBYNM as Ordenado_Por,
	M.OEPHN as Telefono,
	M.SPADL2 as Email, 
	M.EQMFSN as Serie_Equipo,
	M.EQMFCD as Marca, 
	M.EQMFMD as Modelo,
	M.CUEQNO,
	M.ARRNO as Numero_Arreglo,
	M.WONO as Orden_Trabajo,
	M.PADAMT as Monto_Presupuestado_Sin_Imp,
	(M.PADAMT*1.18) as Impuestos_ITBIS,
	M.DCDTOT as Monto_Presupuestado_Con_Imp,
	M.ENDT8 as Fecha_Act_Documento,
	M.QUEXD8 as Fecha_Expiracion,
	M.TMDY6,
	M.USPFID as Usuario_Operador_DBS,
	M.SLSREP as Usuario_Operador_Nombre,
	M.CURIND as Moneda,
	N.NTLNNO as ID_Nota,
	N.NTDA as COM_Nota	
FROM dbo.PCPCOHD0 as M , dbo.PCPCOnT0 as N
WHERE M.RFDCNO = '00Q289942' AND M.RFDCNO =  N.RFDCNO

