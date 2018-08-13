CREATE PROCEDURE MEMRESIA_CU
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


EXEC MEMRESIA_CU '1','a1b2c3d4','5','3','2018-02-12','2020-02-12','0'

select * from membresias where id_membresia = 'a1b2c3d4'