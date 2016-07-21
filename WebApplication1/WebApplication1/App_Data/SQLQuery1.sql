USE BI_VENTAS
SELECT  TOP 10 
	--RFDCNO as Numero_De_Documento ,
	CUNO as Cuenta_Numero,
	STNO as Codigo_Tienda,
	CUNM as Nombre_Cliente, 
	CUADD1 as Direccion1,
	CUADD2 as Direccion2,
	CUADD3 as Direccion3,
	CUCYST as Ciudad,
	ORBYNM as Ordenado_Por,
	OEPHN as Telefono,
	SPADL2 as Email, 
	EQMFSN as Serie_Equipo,
	EQMFCD as Marca, 
	EQMFMD as Modelo,
	CUEQNO,
	ARRNO as Numero_Arreglo,
	WONO as Orden_Trabajo,
	PADAMT as Monto_Presupuestado_Sin_Imp,
	(PADAMT*1.18) as Impuestos_ITBIS,
	DCDTOT as Monto_Presupuestado_Con_Imp,
	ENDT8 as Fecha_Act_Documento,
	QUEXD8 as Fecha_Expiracion,
	TMDY6,
	USPFID as Usuario_Operador_DBS,
	SLSREP as Usuario_Operador_Nombre,
	CURIND as Moneda	

FROM PCPCOHD0
WHERE RFDCNO = '00q289473'

SELECT  TOP 10 * FROM PCPCOHD0 WHERE RFDCNO = '00Q289473';

EXEC('SELECT * FROM LIBP16.PCPCOHD0 WHERE RFDCNO = ''00E050293''') AT AS400P

SELECT   * FROM PCPCOPD0 WHERE RFDCNO = '00e050293';
