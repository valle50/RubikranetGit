--Despu�s de aprobar todos los cat�logos, creamos los insert aqu� mismo

/*
Cat�logo estatus_empleados

id_estatus	nombre_estatus
1			Inactivo/Eliminado
2			Suspendido temporalmente
3			Incapacitado	
4			Activo
5			Peri�do vacacional
*/



/*
insert into estatus_empleado	
values ('	Inactivo/Eliminado
('	Suspendido temporalmente
('	Incapacitado
('	Activo
('	Peri�do vacacional

*/





/*
Cat�logo areas

[nombre]					codigo_edad_accesibilidad (0 = Adultos, 1 = Familiar)
							Se usar� este campo para los que tengan membres�as familiares en su campo tipo_edad
Piscina nombre1
Piscina nombre2
Sala de juegos
Bar nombre1
Bar nombre2
Cine
Cine VIP
Cine 3D
Teatro
Gimnasio
Restaurante Chino
Restaurante Brasile�o
Restaurante Mexicano
Dormitorio b�sico
Dormitorio Intermedio
Dormitorio Premium
Campo de golf
Regaderas
Antro nombre1
Antro nombre2
Centro comercial
Museo
Juegos mec�nicos
Zona de postres
Spa
Zona de juegos
Enfermeria 
*/


/*
Cat�logo categor�as_membresias

id_categoria	categoria
1				Familiar	
2				Pareja
3				Basic
4				Plus
5				Premium
6				Gold
*/


/*
Cat�logo Privilegios

id_privilegio	privilegio
1				Administrador
2				Usuario
3				B�sico
4				Ninguno
*/


/*
Cat�logo precio_por_miembro
tipo_edad= 0 = adulto y 1 = menor de edad
estatus = 0 inactivo y 1 activo

id_precio_miembro	tipo_edad	precio_extra	estatus
1					0			1500			1
2					1			1000			1	
3					0			2000			0
4					1			1500			0
*/

/*
Cat�logo promociones

id_promocion	nombre		    Descripci�n	
1				Cumplea�os		Compra una membresia el dia de tu cumplea�os y te hacemos un 20% de descuento(Solo aplica en membresias individuales)
2				Dia del ni�o	Compra una membresia el dia del ni�o y te hacemos un 15% de descuento en areas infantiles (Solo aplica en membresias individuales)
3				San Valentin	Compra una membresia en San valentin y te hacemos un 35% de descuento(Solo aplica ende pareja)
4               Dia de la familia Comprar una menbresia  el dia de la familia y tendremos un descuento de el 25% de descuento (Solo aplica para la membresias familiares)
*/


/*
Cat�logo turnos 
Formato de horas en 24 = 12:45:36, 17:56:00 ..etc

id_turno	nombre	hora_entrada	hora_salida
1           Matutino    08:00:00      16:00:00
2           Vespertino  16:00:00      19:00:00
3           Nocturno    19:00:00      24:00:00
*/

/*
Cat�logo cargos

nombre		         Actividades
Administrador		Llevar el control total del establecimiento
Usuario				Consulta solo la informaci�n del establecimiento
Encargados de �rea  Consulta la informaci�n de cada una de sus �reas      
*/

/*
Cat�logo estados  

id_estado		nombre_estado
1               Aguascalientes	
2				Baja California	
3				Baja California Sur 
4				Campeche	
5				Chiapas	
6				Chihuahua	
7				Ciudad de M�xico
8				Coahuila	
9				Colima	
10				Durango	
11				Guanajuato	
12			    Guerrero	
13				Hidalgo	
14				Jalisco	
15				M�xico	
16				Michoac�n	
17				Morelos	
18				Nayarit	
19				Nuevo Le�n	
20				Oaxaca	
21				Puebla	
22				Quer�taro	
23				Quintana Roo	
24				San Luis Potos�	
25				Sinaloa	
26				Sonora
27				Tabasco	
28				Tamaulipas	
29				Tlaxcala	
30				Veracruz	
31				Yucat�n	
32				Zacatecas
*/
