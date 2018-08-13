CREATE PROCEDURE MEMBRESIA_CU
@_CHECK INT,
@_IDMEM VARCHAR(30),
@_IDCAT INT,
@_EMP INT,
@_VIGINICIO DATE,
@_VIGFIN DATE,
@_ESTAT BIT
AS
IF @_CHECK = '0'
	INSERT INTO membresias(id_membresia,id_categoria,id_empleado,vigencia_inicio,vigencia_fin,estatus,fecha_registro,fecha_modificacion)
	VALUES (@_IDMEM,@_IDCAT,@_EMP,@_VIGINICIO,@_VIGFIN,@_ESTAT,GETDATE(),GETDATE())
else
UPDATE membresias SET id_membresia = @_IDMEM, id_categoria = @_IDCAT, id_empleado = @_EMP, vigencia_inicio = @_VIGINICIO, 
vigencia_fin = @_VIGFIN, estatus = @_ESTAT, fecha_registro = GETDATE(), fecha_modificacion = GETDATE()
WHERE id_membresia = @_IDMEM
GO


EXEC MEMBRESIA_CU '1','a1b2c3d4','5','3','2018-02-12','2020-02-12','0'

select * from membresias where id_membresia = 'a1b2c3d4'



CREATE PROCEDURE addMEMBERS
@_CHECK INT,
@_RFID VARCHAR(30),
@_RFID_FAM VARCHAR(30),
@_NOMBRE VARCHAR(50),
@_APE_P VARCHAR(50),
@_APE_M VARCHAR(50),
@_SEXO CHAR(1),
@_PRECIO_MIEMBRO TINYINT,
@_ESTATUS BIT
AS
IF @_CHECK ='0'
	INSERT INTO membresia_familiar_miembros(id_membresia,id_membresia_familiar,nombre,apellido_p,apellido_m,sexo,id_precio_miembro,estatus)
	VALUES(@_RFID,@_RFID_FAM,@_NOMBRE,@_APE_P,@_APE_M,@_SEXO,@_PRECIO_MIEMBRO,@_ESTATUS)
ELSE
	UPDATE membresia_familiar_miembros SET id_membresia = @_RFID, id_membresia_familiar = @_RFID_FAM, nombre = @_NOMBRE,
	 apellido_p = @_APE_P, apellido_m = @_APE_M, sexo = @_SEXO, id_precio_miembro = @_PRECIO_MIEMBRO, estatus = @_ESTATUS
GO


EXEC addMEMBERS '0','a1b2c3d4','123abc',"Fulano","de Tal","Aquel",'m','1',1

select * from membresia_familiar_miembros where id_membresia_familiar = '123abc'

CREATE PROCEDURE VERIFICAR
@_RFID VARCHAR(30)
AS
SELECT id_membresia,id_categoria FROM membresias
WHERE id_membresia = @_RFID
GO

SELECT id_membresia,id_categoria FROM membresias
WHERE id_membresia = 'a1b2c3d4'