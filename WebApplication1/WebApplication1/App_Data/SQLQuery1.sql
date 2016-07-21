USE BI_VENTAS
SELECT  TOP 10 
	--RFDCNO as Numero_De_Documento ,
	CUNO as Cuenta_Numero,
	CUNM as Nombre_Cliente, 
	STNO as Numero_Tienda,
	WONO as Orden_Trabajo,
	DCDTOT as Monto_Presupuestado,
	ENDT8 as Fecha_Act_Documento,
	TMDY6,
	USPFID as Usuario_Operador_DBS,
	SLSREP as Usuario_Operador_Nombre,
	CURIND as Moneda,
	QUEXD8 as Fecha_Expiracion

FROM PCPCOHD0
WHERE RFDCNO = '00e050293'

SELECT  TOP 10 * FROM PCPCOHD0 WHERE RFDCNO = '00e050293';

EXEC('SELECT ENDT8 FROM LIBP16.PCPCOHD0 WHERE RFDCNO = ''00E050293''') AT AS400P

