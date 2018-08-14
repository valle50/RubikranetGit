ALTER PROCEDURE MEMBRESIA_CU
@_CHECK INT,
@_IDMEM VARCHAR(30),
@_IDCAT INT,
@_EMP INT,
@_VIGINICIO DATE,
@_VIGFIN DATE
AS
IF @_CHECK = '0'
	INSERT INTO membresias(id_membresia,id_categoria,id_empleado,vigencia_inicio,vigencia_fin,fecha_registro,fecha_modificacion,estatus)
	VALUES (@_IDMEM,@_IDCAT,@_EMP,@_VIGINICIO,@_VIGFIN,GETDATE(),GETDATE(),0)
else
UPDATE membresias SET id_membresia = @_IDMEM, id_categoria = @_IDCAT, id_empleado = @_EMP, vigencia_inicio = @_VIGINICIO, 
vigencia_fin = @_VIGFIN, fecha_modificacion = GETDATE()
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



CREATE PROCEDURE CONTAR
@_MEM VARCHAR(30)
AS
SELECT COUNT(*) as 'Registros' FROM membresia_familiar_miembros
WHERE id_membresia = @_MEM
GO


SELECT COUNT(*) as 'Registros' FROM membresia_familiar_miembros
WHERE id_membresia = '108'

ALTER TABLE clientes ALTER COLUMN telefono varchar(15) NULL

CREATE PROCEDURE MEM_CLI
@_CHECK INT,
@_RFID VARCHAR(30),
@_NOMBRES VARCHAR(50),
@_APE_P VARCHAR(50),
@_APE_M VARCHAR(50),
@_SEXO CHAR(1),
@_FECHA_NAC DATE,
@_DIR TEXT,
@_CODIGO_POS INT,
@_ID_ESTADO INT,
@_ID_MUNICIPIO INT,
@_TELEFONO VARCHAR(15),
@_MAIL VARCHAR(80)
AS
IF @_CHECK = '0'
	INSERT INTO clientes (id_membresia,nombre,apellido_p,apellido_m,sexo,fecha_nacimiento,direccion,codigo_postal,id_estado,id_municipio,telefono,correo,fecha_registro,fecha_retiro,estatus)
	VALUES (@_RFID,@_NOMBRES,@_APE_P,@_APE_M,@_SEXO,@_FECHA_NAC,@_DIR,@_CODIGO_POS,@_ID_ESTADO,@_ID_MUNICIPIO,@_TELEFONO,@_MAIL,GETDATE(),Null,0)
ELSE
	UPDATE clientes SET id_membresia = @_RFID, nombre = @_NOMBRES, apellido_p = @_APE_P, apellido_m = @_APE_M, sexo = @_SEXO,
	fecha_nacimiento = @_FECHA_NAC, direccion = @_DIR, codigo_postal = @_CODIGO_POS, id_estado = @_ID_ESTADO,
	id_municipio = @_ID_MUNICIPIO, telefono = @_TELEFONO, correo = @_MAIL
	WHERE id_membresia = @_RFID



SELECT COUNT(*) FROM clientes WHERE id_membresia = 'a1b2c3d4'



CREATE PROCEDURE SEE_MEMBER
@_RFID VARCHAR (50)
AS
SELECT membresias.id_membresia as 'Membresia',membresias.id_categoria as 'Categoria',empleados.nombre as 'Empleado',membresias.vigencia_inicio as 'Inicio',membresias.vigencia_fin as 'Fin'
FROM membresias,empleados WHERE membresias.id_membresia = @_RFID AND membresias.id_empleado = empleados.id_empleado
GO

create procedure buscaCM
  @parametro varchar(max)
  as
  select * from CLIENTES_MEMBRESIAS cm
	where 
	cm.Membresia like '%'+@parametro+'%' or
	cm.Nombre like '%'+@parametro+'%' or
	cm.Apellidos like '%'+@parametro+'%' or
	cm.Teléfono like '%'+@parametro+'%' or
	cm.Empleado like '%'+@parametro+'%' or
	cm.Categoria like '%'+@parametro+'%'
	order by cm.num desc
	go

