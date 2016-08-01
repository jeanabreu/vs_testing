USE BI_VENTAS
SELECT  TOP 1 
	RFDCNO as Numero_De_Documento ,
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
--WHERE RFDCNO = '00q289473'

USE BI_VENTAS
SELECT  top 100 PCPCOPD0.LNNO, PCPCOHD0.RFDCNO FROM dbo.PCPCOHD0, dbo.PCPCOPD0 WHERE PCPCOHD0.RFDCNO LIKE '%00Q%' and  PCPCOHD0.RFDCNO =  PCPCOPD0.RFDCNO and PCPCOHD0.SPADL2 LIKE '%@%' and PCPCOHD0.ORBYNM LIKE '%j%' and PCPCOHD0.EQMFSN LIKE '%a%'

SELECT  top 10 * FROM PCPCOHD0  WHERE RFDCNO = '00Q288582'  --CPCOnT0 as N WHERE M.RFDCNO = dbo.PCPCOHD0
SELECT  top 10 * FROM dbo.PCPCOnT0 WHERE RFDCNO = '00Q288582'
SELECT  * FROM dbo.PCPCOPD0 WHERE RFDCNO = '00Q288582'

SELECT TOP 10 * FROM PCPCOPD0 WHERE RFDCNO LIKE '%00Q%' and SPADL2 is Not Null -- ORDER BY ENDT8 DESC--TABLA Maestra
SELECT  * FROM PCPCOPD0 WHERE RFDCNO = '00; --TABLA Detalle

EXEC('SELECT * FROM LIBP16.PCPCOHD0 WHERE RFDCNO = ''00E050293''') AT AS400P;

SELECT 
RFDCNO as Codigo_Documento,
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
FROM PCPCOPD0 WHERE RFDCNO = '00Q288582';




SELECT 
	RFDCNO as Codigo_Documento,
	LNNO as Numero_Item,
	PANO20 as Numero_Parte,
	DS18 as Descripcion_Parte,
	WTUM as Peso_Neto,
	UNCS as Precio_Unit,
	UNSEL as Precio_Ext
FROM PCPCOPD0 
WHERE RFDCNO = '03Q028940';

SELECT  TOP 1 
	RFDCNO as Numero_De_Documento ,
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
WHERE RFDCNO = '03Q028940'

