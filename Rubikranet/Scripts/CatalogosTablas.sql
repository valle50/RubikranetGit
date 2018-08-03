﻿--Después de aprobar todos los catálogos, creamos los insert aquí mismo

/*
Catálogo estatus_empleados

id_estatus	nombre_estatus
1			Inactivo/Eliminado
2			Suspendido temporalmente
3			Incapacitado	
4			Activo
5			Periódo vacacional
*/


/*
Catálogo areas

[nombre]					codigo_edad_accesibilidad (0 = Adultos, 1 = Familiar)
							Se usará este campo para los que tengan membresías familiares en su campo tipo_edad
1 Piscina nombre1
2 Piscina nombre2
3 Sala de juegos
4 Bar nombre1
5 Bar nombre2
6 Cine
7 Cine VIP
8 Cine 3D
9 Teatro
10 Gimnasio
11 Restaurante Chino
12 Restaurante Brasileño
13 Restaurante Mexicano
14 Dormitorio básico
15 Dormitorio Intermedio
16 Dormitorio Premium
17 Campo de golf
18 Regaderas
19 Antro nombre1
20 Antro nombre2
21 Centro comercial
22 Museo
23 Juegos mecánicos
24 Zona de postres
25 Spa
26 Zona de juegos
27 Enfermeria 
*/


/*
Catálogo categorías_membresias

id_categoria	categoria
1				Familiar	
2				Pareja
3				Basic
4				Plus
5				Premium
6				Gold
*/


/*
Catálogo accesibilidad_areas

id_categoria	id_area		estatus

*/


/*
Catálogo Privilegios

id_privilegio	privilegio
1				Administrador
2				Usuario
3				Básico
4				Ninguno

*/


/*
Catálogo precio_por_miembro
tipo_edad= 0 = adulto y 1 = menor de edad
estatus = 0 inactivo y 1 activo

id_precio_miembro	tipo_edad	precio_extra	estatus
1					0			1500			1
2					1			1000			1	
3					0			2000			0
4					1			1500			0
*/


/*
Catálogo promociones

id_promocion	nombre		    Descripción	
1				Cumpleaños		Compra una membresia el dia de tu cumpleaños y te hacemos un 20% de descuento(Solo aplica en membresias individuales)
2				Dia del niño	Compra una membresia el dia del niño y te hacemos un 15% de descuento en areas infantiles (Solo aplica en membresias individuales)
3				San Valentin	Compra una membresia en San valentin y te hacemos un 35% de descuento(Solo aplica ende pareja)
4               Dia de la familia Comprar una menbresia  el dia de la familia y tendremos un descuento de el 25% de descuento (Solo aplica para la membresias familiares)
*/


/*
Catálogo turnos 
Formato de horas en 24 = 12:45:36, 17:56:00 ..etc

id_turno	nombre	hora_entrada	hora_salida
1           Matutino    08:00:00      16:00:00
2           Vespertino  16:00:00      19:00:00
3           Nocturno    19:00:00      24:00:00
*/


/*
Catálogo cargos

nombre		         Actividades
Administrador		Llevar el control total del establecimiento
Usuario				Consulta solo la información del establecimiento
Encargados de área  Consulta la información de cada una de sus áreas      
*/


/*
Catálogo estados  

id_estado		nombre_estado
1               Aguascalientes	
2				Baja California	
3				Baja California Sur 
4				Campeche	
5				Chiapas	
6				Chihuahua	
7				Ciudad de México
8				Coahuila	
9				Colima	
10				Durango	
11				Guanajuato	
12			    Guerrero	
13				Hidalgo	
14				Jalisco	
15				México	
16				Michoacán	
17				Morelos	
18				Nayarit	
19				Nuevo León	
20				Oaxaca	
21				Puebla	
22				Querétaro	
23				Quintana Roo	
24				San Luis Potosí	
25				Sinaloa	
26				Sonora
27				Tabasco	
28				Tamaulipas	
29				Tlaxcala	
30				Veracruz	
31				Yucatán	
32				Zacatecas
*/


/*
Script insert tabla estados

insert into estados (nombre_estado) 
values ('Aguascalientes'), 
('Baja California'),
('	Baja California Sur'),
('	Campeche'),
('	Chiapas'),
('	Chihuahua'),
('	Ciudad de México'),
('	Coahuila'),
('	Colima'),
('	Durango'),
('	Guanajuato'),
('	Guerrero'),
('	Hidalgo'),
('	Jalisco'),
('	México'),
('	Michoacán'),
('	Morelos'),
('	Nayarit'),
('	Nuevo León'),
('	Oaxaca'),
('	Puebla'),
('	Querétaro'),
('	Quintana Roo'),
('	San Luis Potosí'),
('	Sinaloa'),
('	Sonora'),
('	Tabasco'),
('	Tamaulipas'),
('	Tlaxcala'),
('	Veracruz'),
('	Yucatán'),
('	Zacatecas')
go

*/


/*
Catálogo municipios

id_estado		nombre_municipio
1				Aguascalientes
1				Asientos
1				Calvillo
1				Cosío
1				Jesús María
1 				Pabellón de Arteaga
1				Rincón de Romos
1				San José de Gracia
1 				Tepezalá
1				El Llano
1				San Francisco de los Romo
2				Ensenada
2				Mexicali
2				Tecate
2				Tijuana
2				Playas de Rosarito
3				Comondú
3				Mulegé
3				La Paz
3				Los Cabos
3				Loreto
4				Calkiní
4 				Campeche (municipio)
4  				Carmen
4				Champotón
4				Hecelchakán
4				Hopelchén
4				Palizada
4				Tenabo
4				Escárcega
4				Calakmul
4				Candelaria
5				Acacoyagua
5				Acala
5				Acapetahua
5				Altamirano
5				Amatán
5 				Amatenango de la Frontera
5				Amatenango del Valle
5				Ángel Albino Corzo
5				Arriaga
5 				Bejucal de Ocampo
5 				Bella Vista
5				Berriozábal
5				Bochil
5				El Bosque
5				Cacahoatán
5				Catazajá
5				Cintalapa
5				Coapilla
5 				Comitán de Domínguez
5				La Concordia
5				Copainalá
5				Chalchihuitán
5				Chamula
5				Chanal
5				Chapultenango
5				Chenalhó
5				Chiapa de Corzo
5				Chiapilla
5				Chicoasén
5				Chicomuselo
5				Chilón
5				Escuintla
5				Francisco León
5				Frontera Comalapa
5 				Frontera Hidalgo
5				La Grandeza
5				Huehuetán
5 				Huixtán
5				Huitiupán
5				Huixtla
5				La Independencia
5 				Ixhuatán
5 				Ixtacomitán
5				Ixtapa
5 				Ixtapangajoya
5				Jiquipilas
5 				Jitotol
5				Juárez
5 				Larráinzar
5   			La Libertad
5 				Mapastepec
5 				Las Margaritas
5				Mazapa de Madero
5				Mazatán
5				Metapa
5				Mitontic
5				Motozintla
5  				Nicolás Ruíz
5				Ocosingo
5				Ocotepec
5 				Ocozocoautla de Espinosa
5				Ostuacán
5				Osumacinta
5				Oxchuc
5				Palenque
5				Pantelhó
5  				Pantepec
5				Pichucalco
5				Pijijiapan
5 				El Porvenir
5				Villa Comaltitlán
5				Pueblo Nuevo Solistahuacán
5				Rayón	
5				Reforma
5				Las Rosas
5				Sabanilla
5				Salto de Agua
5  				San Cristóbal de las Casas
5				San Fernando
5				Siltepec
5				Simojovel
5				Sitalá
5				Socoltenango
5				Solosuchiapa
5				Soyaló
5				Suchiapa
5				Suchiate
5				Sunuapa
5 				Tapachula
5				Tapalapa
5				Tapilula
5				Tecpatán
5				Tenejapa
5 				Teopisca
5				Tila
5 				Tonalá
5				Totolapa
5				La Trinitaria
5				Tumbalá
5				Tuxtla Gutiérrez
5				Tuxtla Chico
5				Tuzantán
5				Tzimol
5				Unión Juárez	
5				Venustiano Carranza
5				Villa Corzo
5 				Villaflores
5				Yajalón
5				San Lucas
5				Zinacantán
5				San Juan Cancuc
5				Aldama
5				Benemérito de las Américas
5				Maravilla Tenejapa
5				Marqués de Comillas
5				Montecristo de Guerrero
5				San Andrés Duraznal
5				Santiago el Pinar
5				El Parral
5				Emiliano Zapata
5				Mezcalapa
5				Belisario Dominguez
5 				Capitán Luis Ángel Vidal
5 				Rincón Chamula San Pedro
6				Ahumada
6				Aldama
6				Allende
6				Aquiles Serdán
6				Ascensión
6				Bachíniva
6				Balleza
6				Batopilas de Manuel Gómez Morín
6				Bocoyna
6				Buenaventura
6				Camargo
6				Carichí
6				Casas Grandes
6				Coronado
6				Coyame del Sotol
6				La Cruz
6				Cuauhtémoc
6				Cusihuiriachi
6				Chihuahua
6				Chínipas
6				Delicias
6				Dr. Belisario Domínguez
6				Galeana
6				Santa Isabel
6				Gómez Farías
6				Gran Morelos
6				Guachochi
6				Guadalupe
6				Guadalupe y Calvo
6				Guazapares
6				Guerrero
6				Hidalgo del Parral
6				Huejotitán
6				Ignacio Zaragoza
6				Janos
6				Jiménez
6				Juárez
6				Julimes
6				López
6				Madera
6				Maguarichi
6				Manuel Benavides
6				Matachí
6				Matamoros
6				Meoqui
6				Morelos
6				Moris
6				Namiquipa
6				Nonoava
6				Nuevo Casas Grandes
6				Ocampo
6				Ojinaga
6				Práxedis G. Guerrero
6				Riva Palacio
6				Rosales
6				Rosario
6				San Francisco de Borja
6				San Francisco de Conchos
6				San Francisco del Oro
6				Santa Bárbara
6				Satevó
6				Saucillo
6				Temósachi
6				El Tule
6				Urique
6				Uruachi
6				Valle de Zaragoza
7				Álvaro Obregón
7				Azcapotzalco
7				Benito Juárez
7				Coyoacán
7				Cuajimalpa de Morelos
7				Cuauhtémoc
7				Gustavo A. Madero
7				Iztacalco
7				Iztapalapa
7				Magdalena Contreras
7				Miguel Hidalgo
7				Milpa Alta	
7				Tláhuac
7				Tlalpan
7				Venustiano Carranza
7				Xochimilco
8				Abasolo
8				Acuña
8				Allende
8				Arteaga
8				Candela
8				Castaños
8				Cuatro Ciénegas
8				Escobedo
8				Francisco I. Madero
8				Frontera
8				General Cepeda
8				Guerrero
8				Hidalgo
8				Jiménez
8				Juárez
8				Lamadrid
8				Matamoros
8				Monclova
8				Morelos
8				Múzquiz
8				Nadadores
8				Nava
8				Ocampo
8				Parras
8				Piedras Negras
8				Progreso
8				Ramos Arizpe
8				Sabinas
8				Sacramento
8				Saltillo
8				San Buenaventura
8				San Juan de Sabinas
8				San Pedro
8				Sierra Mojada
8				Torreón
8				Viesca
8				Villa Unión
8				Zaragoza
9				Armería
9 				Colima
9				Comala
9				Coquimatlán
9				Cuauhtémoc
9				Ixtlahuacán
9				Manzanillo
9				Minatitlán
9				Tecomán
9				Villa de Álvarez
10				Canatlán
10				Canelas
10				Coneto de Comonfort
10				Cuencamé
10				Durango
10 				General Simón Bolívar
10 				Gómez Palacio
10 				Guadalupe Victoria
10				Guanaceví
10				Hidalgo
10 				Indé
10				Lerdo
10				Mapimí
10 				Mezquital
10 				Nazas
10				Nombre de Dios
10				Ocampo
10				El Oro
10				Otáez
10				Pánuco de Coronado
10 				Peñón Blanco
10				Poanas
10				Pueblo Nuevo
10				Rodeo
10				San Bernardo
10				San Dimas
10			 	San Juan de Guadalupe
10				San Juan del Río
10 				San Luis del Cordero
10				San Pedro del Gallo
10				Santa Clara
10				Santiago Papasquiaro
10				Súchil	
10				Tamazula
10				Tepehuanes
10				Tlahualilo
10				Topia
10 				Vicente Guerrero
10				Nuevo Ideal
11				Abasolo
11				Acámbaro
11				San Miguel de Allende
11				Apaseo el Alto
11				Apaseo el Grande
11				Atarjea
11				Celaya
11				Manuel Doblado
11				Comonfort
11				Coroneo
11				Cortazar
11				Cuerámaro
11				Doctor Mora
11				Dolores Hidalgo Cuna de la Independencia Nacional
11				Guanajuato
11				Huanímaro
11				Irapuato
11				Jaral del Progreso
11				Jerécuaro
11				León
11				Moroleón
11				Ocampo
11				Pénjamo
11				Pueblo Nuevo
11				Purísima del Rincón
11				Romita
11				Salamanca
11				Salvatierra
11				San Diego de la Unión
11				San Felipe
11				San Francisco del Rincón
11				San José Iturbide
11				San Luis de la Paz
11				Santa Catarina
11				Santa Cruz de Juventino Rosas
11				Santiago Maravatío
11				Silao de la Victoria
11				Tarandacuao
11				Tarimoro
11				Tierra Blanca
11				Uriangato
11				Valle de Santiago
11				Victoria
11				Villagrán
11				Xichú
11				Yuriria
12				Acapulco de Juárez
12				Ahuacuotzingo
12				Ajuchitlán del Progreso
12				Alcozauca de Guerrero
12				Alpoyeca
12				Apaxtla
12				Arcelia
12				Atenango del Río
12				Atlamajalcingo del Monte
12				Atlixtac
12				Atoyac de Álvarez
12				Ayutla de los Libres
12				Azoyú
12				Benito Juárez
12				Buenavista de Cuéllar
12 				Coahuayutla de José María Izazaga
12				Cocula
12				Copala
12				Copalillo
12				Copanatoyac
12				Coyuca de Benítez
12				Coyuca de Catalán
12				Cuajinicuilapa
12				Cualác
12				Cuautepec
12				Cuetzala del Progreso
12				Cutzamala de Pinzón
12				Chilapa de Álvarez
12				Chilpancingo de los Bravo
12				Florencio Villarreal
12				General Canuto A. Neri
12				General Heliodoro Castillo
12				Huamuxtitlán
12				Huitzuco de los Figueroa
12				Iguala de la Independencia
12				Igualapa
12				Ixcateopan de Cuauhtémoc
12				Zihuatanejo de Azueta
12				Juan R. Escudero
12				Leonardo Bravo
12				Malinaltepec
12				Mártir de Cuilapan
12				Metlatónoc
12				Mochitlán
12				Olinalá
12				Ometepec
12				Pedro Ascencio Alquisiras
12				Petatlán
12				Pilcaya
12				Pungarabato
12				Quechultenango
12				San Luis Acatlán
12				San Marcos
12				San Miguel Totolapan
12 				Taxco de Alarcón
12				Tecoanapa
12				Técpan de Galeana
12				Teloloapan
12				Tepecoacuilco de Trujano
12				Tetipac
12				Tixtla de Guerrero
12				Tlacoachistlahuaca
12				Tlacoapa
12				Tlalchapa
12				Tlalixtaquilla de Maldonado
12				Tlapa de Comonfort
12				Tlapehuala
12				La Unión de Isidoro Montes de Oca
12				Xalpatláhuac
12				Xochihuehuetlán
12				Xochistlahuaca
12				Zapotitlán Tablas
12				Zirándaro
12				Zitlala
12				Eduardo Neri
12				Acatepec
12				Marquelia
12				Cochoapa el Grande
12				José Joaquín de Herrera
12				Juchitán
12				Iliatenco
13				Acatlán
13				Acaxochitlán
13				Actopan
13				Agua Blanca de Iturbide
13				Ajacuba
13				Alfajayucan
13				Almoloya
13				Apan
13				El Arenal
13				Atitalaquia
13				Atlapexco
13				Atotonilco el Grande	
13				Atotonilco de Tula
13				Calnali
13				Cardonal
13				Cuautepec de Hinojosa
13				Chapantongo
13				Chapulhuacán
13				Chilcuautla
13				Eloxochitlán
13				Emiliano Zapata
13				Epazoyucan
13				Franciso I. Madero
13				Huasca de Ocampo
13				Huautla
13				Huazalingo
13				Huehuetla
13 				Huejutla de Reyes
13				Huichapan
13				Ixmiquilpan
13				Jacala de Ledezma
13				Jaltocán
13				Juárez Hidalgo
13				Lolotla
13				Metepec
13				San Agustín Metzquititlán
13				Metztitlán
13				Mineral del Chico
13				Mineral del Monte
13				La Misión
13				Mixquiahuala de Juárez
13				Molango de Escamilla
13				Nicolás Flores
13				Nopala de Villagrán
13 				Omitlán de Juárez
13				San Felipe Orizatlán
13				Pacula
13				Pachuca de Soto
13				Pisaflores
13				Progreso de Obregón
13				Mineral de la Reforma
13				San Agustín Tlaxiaca
13				San Bartolo Tutotepec
13				San Salvador
13				Santiago de Anaya
13				Santiago Tulantepec de Lugo Guerrero
13				Singuilucan
13				Tasquillo
13				Tecozautla
13				Tenango de Doria
13				Tepeapulco
13				Tepehuacán de Guerrero
13				Tepeji del Río de Ocampo
13				Tepetitlán
13				Tetepango
13				Villa de Tezontepec
13				Tezontepec de Aldama
13				Tianguistengo
13				Tizayuca
13				Tlahuelilpan
13				Tlahuiltepa
13				Tlanalapa
13				Tlanchinol
13				Tlaxcoapan
13				Tolcayuca
13				Tula de Allende
13				Tulancingo de Bravo
13				Xochiatipan
13				Xochicoatlán
13				Yahualica
13				Zacualtipán de Ángeles
13				Zapotlán de Juárez
13				Zempoala
13				Zimapán
14				Acatic
14				Acatlán de Juárez
14				Ahualulco de Mercado
14				Amacueca
14				Amatitán	
14				Ameca
14				San Juanito de Escobedo
14				Arandas
14				El Arenal
14				Atemajac de Brizuela
14				Atengo
14				Atenguillo
14				Atotonilco el Alto
14				Atoyac
14				Autlán de Navarro
14				Ayotlán
14				Ayutla
14				La Barca
14				Bolaños
14				Cabo Corrientes
14				Casimiro Castillo
14				Cihuatlán
14				Zapotlán el Grande
14				Cocula
14				Colotlán
14				Concepción de Buenos Aires
14				Cuautitlán de García Barragán
14				Cuautla
14				Cuquío
14				Chapala
14				Chimaltitán
14				Chiquilistlán
14				Degollado
14				Ejutla
14				Encarnación de Díaz
14				Etzatlán
14		 		El Grullo
14				Guachinango
14				Guadalajara	
14				Hostotipaquillo
14				Huejúcar
14				Huejuquilla el Alto
14				La Huerta
14				Ixtlahuacán de los Membrillos
14				Ixtlahuacán del Río
14				Jalostotitlán
14				Jamay
14				Jesús María
14				Jilotlán de los Dolores
14				Jocotepec
14				Juanacatlán
14				Juchitlán
14				Lagos de Moreno
14				El Limón
14				Magdalena
14				Santa María del Oro
14  			La Manzanilla de la Paz
14				Mascota
14				Mazamitla
14				Mexticacán
14				Mezquitic
14				Mixtlán
14				Ocotlán
14				Ojuelos de Jalisco
14				Pihuamo
14				Poncitlán
14				Puerto Vallarta
14				Villa Purificación
14				Quitupan
14				El Salto
14				San Cristóbal de la Barranca
14				San Diego de Alejandría
14				San Juan de los Lagos
14				San Julián
14				San Marcos
14 				San Martín de Bolaños
14				San Martín Hidalgo
14				San Miguel el Alto
14				Gómez Farías
14				San Sebastián del Oeste
14				Santa María de los Ángeles
14				Sayula
14				Tala
14				Talpa de Allende
14				Tamazula de Gordiano
14				Tapalpa
14				Tecalitlán
14				Techaluta de Montenegro
14				Tecolotlán
14 				Tenamaxtlán
14				Teocaltiche
14				Teocuitatlán de Corona
14				Tepatitlán de Morelos
14				Tequila
14				Teuchitlán
14				Tizapán el Alto
14				Tlajomulco de Zúñiga
14				Tlaquepaque
14				Tolimán
14				Tomatlán
14				Tonalá
14				Tonaya
14				Tonila
14				Totatiche
14				Tototlán
14				Tuxcacuesco
14				Tuxcueca
14				Tuxpan
14				Unión de San Antonio
14				Unión de Tula
14				Valle de Guadalupe
14				Valle de Juárez
14				San Gabriel
14				Villa Corona
14				Villa Guerrero
14				Villa Hidalgo
14				Cañadas de Obregón
14				Yahualica de González Gallo
14				Zacoalco de Torres
14				Zapopan
14				Zapotiltic
14				Zapotitlán de Vadillo
14				Zapotlán del Rey
14				Zapotlanejo
14				San Ignacio Cerro Gordo
15				Acambay‎ 
15				Acolman‎ 
15				Aculco‎ 
15				Almoloya de Juárez‎ 
15				Almoloya del Río‎ 
15				Amatepec‎ 
15				Amecameca‎ 
15				Apaxco‎ 
15				Atenco‎ 
15				Atizapán‎ 
15				Atizapán de Zaragoza‎ 
15				Atlacomulco‎ 
15				Atlautla‎ 
15				Axapusco‎ 
15				Ayapango‎ 
15				Calimaya‎ 
15				Chalco‎ 
15				Chiautla (estado de México)‎ 
15				Chiconcuac‎ 
15				Coacalco de Berriozábal‎ 
15				Coatepec Harinas‎ 
15				Cuautitlán‎
15				Cuautitlán Izcalli‎ 
15				Ecatepec de Morelos‎ 
15				Ecatzingo‎ 
15				El Oro (estado de México)‎ 
15				Huehuetoca‎ 
15				Hueypoxtla‎ 
15				Huixquilucan‎ 
15				Isidro Fabela (estado de México)‎ 
15				Ixtapaluca‎ 
15				Ixtapan de la Sal‎ 
15				Jaltenco‎ 
15				Jocotitlán‎ 
15				Juchitepec‎ 
15				La Paz (estado de México)‎ 
15				Lerma (estado de México)‎ 
15				Malinalco‎ 
15				Melchor Ocampo (estado de México)‎ 
15				Naucalpan de Juárez‎ 
15				Nextlalpan‎ 
15				Nezahualcóyotl (estado de México)‎ 
15				Nicolás Romero (estado de México)‎ 
15				Nopaltepec‎ 
15				Ocoyoacac‎ 
15				Otumba‎ 
15				Otzolotepec‎ 
15				Ozumba‎ 
15				Polotitlán‎ 
15				Rayón (estado de México)‎ 
15				San Felipe del Progreso‎ 
15				San José del Rincón (estado de México)‎ 
15				San Mateo Atenco‎
15				Santo Tomás (estado de México)‎ 
15				Soyaniquilpan de Juárez‎ 
15				Tecámac‎ 
15				Tejupilco‎ 
15				Temascalapa‎ 
15				Temascalcingo‎ 
15				Temoaya‎ 
15				Tenango del Aire‎ 
15				Tenango del Valle‎ 
15				San Juan Teotihuacán‎ 
15				Tepetlaoxtoc‎
15				Tepetlixpa‎ 
15				Tepotzotlán‎ 
15				Tequixquiac‎ 
15				Texcoco‎ 
15				Tianguistenco‎ 
15				Tlalmanalco‎ 
15				Tlalnepantla de Baz‎ 
15				Tlatlaya‎ 
15				Toluca‎
15				Tonatico‎ 
15				Tultepec‎ 
15				Tultitlán‎ 
15				Valle de Bravo‎ 
15				Valle de Chalco Solidaridad‎ 
15				Xalatlaco‎ 
15				Zacazonapan‎ 
15				Zinacantepec‎ 
15				Zumpahuacán‎ 
15				Zumpango‎ 
16				Acuitzio
16				Aguililla
16				Álvaro Obregón
16				Angamacutiro
16				Angangueo
16				Apatzingán
16				Aporo
16				Aquila
16				Ario de Rosales
16				Arteaga Riseñas
16				Briseñas
16				Buenavista
16				Carácuaro
16				Charapan
16				Charo
16				Chavinda
16				Cherán
16				Chilchota
16				Chuinicuila
16				Chucándiro
16				Churintzio
16				Churumuco
16				Coahuayana
16				Coalcomán de Vázquez Pallares
16				Coeneo
16				Cojumatlán de Régules
16				Contepec
16				Copándaro
16				Cotija
16				Cuitzeo
16				Escuandureo
16				Epitacio Huerta
16				Erongarícuaro
16				Gabriel Zamora
16				Hidalgo
16				Huandacareo
16				Huaniqueo
16				Huetamo
16				Huiramba
16				Indaparapeo
16				Irimbo
16				Ixtlán
16				Jacona
16				Jiménez
16				Jiquilpan
16				José Sixto Verduzco
16				Juárez
16				Jungapeo
16				La Huacana
16				La Piedad
16				Lagunillas
16				Lázaro Cárdenas
16				Los Reyes
16				Madero
16				Maravatío
16				Marcos Castellanos
16				Morelia
16				Morelos
16				Múgica
16				Nahuatzen
16				Nocupétaro
16				Nuevo Parangaricutiro
16				Nuevo Urecho
16				Numarán
16				Ocampo
16				Pajacuarán
16				Panindícuaro
16				Paracho
16				Parácuaro
16				Pátzcuaro
16				Penjamillo
16				Peribán
16				Purépero
16				Puruándiro
16				Queréndaro
16				Quiroga
16				Sahuayo
16				Salvador Escalante
16				San Lucas
16				Santa Ana Maya
16				Senguio
16				Susupuato
16				Tancítaro
16				Tangamandapio
16				Tangancícuaro
16				Tanhuato
16				Taretan
16				Tarímbaro
16				Tepalcatepec
16				Tingüindín
16				Tingambato
16				Tiquicheo de Nicolás Romero
16				Tlalpujahua
16				Tlazazalca
16				Tocumbo
16				Tumbiscatío
16				Turicato
16				Tuxpan
16				Tuzantla
16				Tzintzuntzan
16				Tzitzio
16				Uruapan
16				Venustiano Carranza
16				Villamar
16				Vista Hermosa
16				Yurécuaro
16				Zacapu
16				Zamora
16				Zináparo
16				Zinapécuaro
16				Ziracuaretiro
16				Zitácuaro
17				Amacuzac
17				Atlatlahucan
17				Axochiapan
17				Ayala
17				Coatlán del Río
17				Cuautla
17				Cuernavaca
17				Emiliano Zapata
17				Huitzilac
17				Jantetelco
17				Jiutepec
17				Jojutla
17				Jonacatepec
17				Mazatepec
17				Miacatlán
17				Ocuituco
17				Puente de Ixtla
17				Temixco
17				Temoac
17				Tepalcingo
17				Tepoztlán
17				Tetecala
17				Tetela del Volcán
17				Tlalnepantla
17				Tlaltizapán de Zapata
17				Tlaquiltenango
17				Tlayacapan
17				Totolapan
17				Xochitepec
17				Yautepec de Zaragoza
17				Yecapixtla
17				Zacatepec de Hidalgo
17				Zacualpan de Amilpas
18				Acaponeta
18				Ahuacatlán
18				Amatlán de Cañas
18				Bahía de Banderas
18				Compostela
18				El Nayar
18				Huajicori
18				Ixtlán del Río
18				Jala
18				La Yesca
18				Rosamorada
18				Ruíz
18				San Blas
18				San Pedro Lagunillas
18				Santa María del Oro
18				Santiago Ixcuintla
18				Tecuala
18				Tepic
18				Tuxpan
18				Xalisco
19				Abasolo
19				Agualeguas
19				Allende
19				Anáhuac
19				Apodaca
19				Aramberri
19				Bustamante
19				Cadereyta Jiménez
19				Cerralvo
19				China
19				Ciénega de Flores
19				Doctor Arroyo
19				Doctor Coss
19				Doctor González
19				El Carmen
19				Galeana
19				García
19				General Bravo
19				General Escobedo
19				General Terán
19				General Treviño
19				General Zaragoza
19				General Zuazua
19				Guadalupe
19				Hidalgo
19				Higueras
19				Hualahuises
19				Iturbide
19				Juárez
19				Lampazos de Naranjo
19				Linares
19				Los Aldamas
19				Los Herreras
19				Los Ramones
19				Marín
19				Melchor Ocampo
19				Mier y Noriega
19				Mina
19				Montemorelos
19				Monterrey
19				Parás
19				Pesquería
19				Rayones
19				Sabinas Hidalgo
19				Salinas Victoria
19				San Nicolás de los Garza
19				San Pedro Garza García
19				Santa Catarina
19				Santiago
19				Vallecillo
19				Villaldama
20				Abejones
20				Acatlán de Pérez Figueroa
20				Ánimas Trujano
20				Asunción Cacalotepec
20				Asunción Cuyotepeji
20				Asunción Ixtaltepec
20				Asunción Nochixtlán
20				Asunción Ocotlán
20				Asunción Tlacolulita
20				Ayoquezco de Aldama
20				Ayotzintepec
20				Calihualá
20				Candelaria Loxicha
20				Capulalpam de Méndez
20				Chahuites
20				Chalcatongo de Hidalgo
20				Chiquihuitlán de Benito Juárez
20				Ciénega de Zimatlán
20				Ciudad Ixtepec
20				Coatecas Altas
20				Coicoyán de las Flores
20				Concepción Buenavista
20				Concepción Pápalo
20				Constancia del Rosario
20				Cosolapa
20				Cosoltepec
20				Cuilapam de Guerrero
20				Cuyamecalco Villa de Zaragoza
20				El Barrio de la Soledad
20				El Espinal
20				Eloxochitlán de Flores Magón
20				Fresnillo de Trujano
20				Guadalupe de Ramírez
20				Guadalupe Etla
20				Guelatao de Juárez
20				Guevea de Humboldt
20				Heróica Ciudad de Ejutla de Crespo
20				Heróica Ciudad de Huajuapan de León
20				Heróica Ciudad de Tlaxiaco
20				Huautepec
20				Huautla de Jiménez
20				Ixpantepec Nieves
20				Ixtlán de Juárez
20				Juchitán de Zaragoza
20				La Compañía
20				La Pe
20				La Reforma
20				La Trinidad Vista Hermosa
20				Loma Bonita
20				Magdalena Apasco
20				Magdalena Jaltepec
20				Magdalena Mixtepec
20				Magdalena Ocotlán
20				Magdalena Peñasco
20				Magdalena Teitipac
20				Magdalena Tequisistlán
20				Magdalena Tlacotepec
20				Magdalena Yodocono de Porfirio Díaz
20				Magdalena Zahuatlán
20				Mariscala de Juárez
20				Mártires de Tacubaya
20				Matías Romero Avendaño
20				Mazatlán Villa de Flores
20				Mesones Hidalgo
20				Miahuatlán de Porfirio Díaz
20				Mixistlán de la Reforma
20				Monjas
20				Natividad
20				Nazareno Etla
20				Nejapa de Madero
20				Nuevo Zoquiapam
20				Oaxaca de Juárez
20				Ocotlán de Morelos
20				Pinotepa de Don Luis
20				Pluma Hidalgo
20				Putla Villa de Guerrero
20				Reforma de Pineda
20				Reyes Etla
20				Rojas de Cuauhtémoc
20				Salina Cruz
20				San Agustín Amatengo
20				San Agustín Atenango
20				San Agustín Chayuco
20				San Agustín de las Juntas
20				San Agustín Etla
20				San Agustín Loxicha
20				San Agustín Tlacotepec
20				San Agustín Yatareni
20				San Andrés Cabecera Nueva
20				San Andrés Dinicuiti
20				San Andrés Huaxpaltepec
20				San Andrés Huayapam
20				San Andrés Ixtlahuaca
20				San Andrés Lagunas
20				San Andrés Nuxiño
20				San Andrés Paxtlán
20				San Andrés Sinaxtla
20				San Andrés Solaga
20				San Andrés Teotilalpam
20				San Andrés Tepetlapa
20				San Andrés Yaa
20				San Andrés Zabache
20				San Andrés Zautla
20				San Antonino Castillo Velasco
20				San Antonino el Alto
20				San Antonino Monteverde
20				San Antonio Acutla
20				San Antonio de la Cal
20				San Antonio Huitepec
20				San Antonio Nanahuatipam
20				San Antonio Sinicahua
20				San Antonio Tepetlapa
20				San Baltazar Chichicápam
20				San Baltazar Loxicha
20				San Baltazar Yatzachi el Bajo
20				San Bartolo Coyotepec
20				San Bartolo Soyaltepec
20				San Bartolo Yautepec
20				San Bartolomé Ayautla
20				San Bartolomé Loxicha
20				San Bartolomé Quialana
20				San Bartolomé Yucuañe
20				San Bartolomé Zoogocho
20				San Bernardo Mixtepec
20				San Blas Atempa
20				San Carlos Yautepec
20				San Cristóbal Amatlán
20				San Cristóbal Amoltepec
20				San Cristóbal Lachirioag
20				San Cristóbal Suchixtlahuaca
20				San Dionisio del Mar
20				San Dionisio Ocotepec
20				San Dionisio Ocotlán
20				San Esteban Atatlahuca
20				San Felipe Jalapa de Díaz
20				San Felipe Tejalapam
20				San Felipe Usila
20				San Francisco Cahuacuá
20				San Francisco Cajonos
20				San Francisco Chapulapa
20				San Francisco Chindua
20				San Francisco del Mar
20				San Francisco Huehuetlán
20				San Francisco Ixhuatán
20				San Francisco Jaltepetongo
20				San Francisco Lachigoló
20				San Francisco Logueche
20				San Francisco Nuxaño
20				San Francisco Ozolotepec
20				San Francisco Sola
20				San Francisco Telixtlahuaca
20				San Francisco Teopan
20				San Francisco Tlapancingo
20				San Gabriel Mixtepec
20				San Ildefonso Amatlán
20				San Ildefonso Sola
20				San Ildefonso Villa Alta
20				San Jacinto Amilpas
20				San Jacinto Tlacotepec
20				San Jerónimo Coatlán
20				San Jerónimo Silacayoapilla
20				San Jerónimo Sosola
20				San Jerónimo Taviche
20				San Jerónimo Tecoatl
20				San Jerónimo Tlacochahuaya
20				San Jorge Nuchita
20				San José Ayuquila
20				San José Chiltepec
20				San José del Peñasco
20				San José del Progreso
20				San José Estancia Grande
20				San José Independencia
20				San José Lachiguiri
20				San José Tenango
20				San Juan Achiutla
20				San Juan Atepec
20				San Juan Bautista Atatlahuca
20				San Juan Bautista Coixtlahuaca
20				San Juan Bautista Cuicatlán
20				San Juan Bautista Guelache
20				San Juan Bautista Jayacatlán
20				San Juan Bautista Lo de Soto
20				San Juan Bautista Suchitepec
20				San Juan Bautista Tlacoatzintepec
20				San Juan Bautista Tlachichilco
20				San Juan Bautista Tuxtepec
20				San Juan Bautista Valle Nacional
20				San Juan Cacahuatepec
20				San Juan Chicomezúchil
20				San Juan Chilateca
20				San Juan Cieneguilla
20				San Juan Coatzóspam
20				San Juan Colorado
20				San Juan Comaltepec
20				San Juan Cotzocón
20				San Juan del Estado
20				San Juan de los Cués
20				San Juan del Río
20				San Juan Diuxi
20				San Juan Evangelista Analco
20				San Juan Guelavia
20				San Juan Guichicovi
20				San Juan Ihualtepec
20				San Juan Juquila Mixes
20				San Juan Juquila Vijanos
20				San Juan Lachao
20				San Juan Lachigalla
20				San Juan Lajarcia
20				San Juan Lalana
20				San Juan Mazatlán
20				San Juan Mixtepec, distrito 08
20				San Juan Mixtepec, distrito 26
20				San Juan Ñumi
20				San Juan Ozolotepec
20				San Juan Petlapa
20				San Juan Quiahije
20				San Juan Quiotepec
20				San Juan Sayultepec
20				San Juan Tabaá
20				San Juan Tamazola
20				San Juan Teita
20				San Juan Teitipac
20				San Juan Tepeuxila
20				San Juan Teposcolula
20				San Juan Yaeé
20				San Juan Yatzona
20				San Juan Yucuita
20				San Lorenzo
20				San Lorenzo Albarradas
20				San Lorenzo Cacaotepec
20				San Lorenzo Cuaunecuiltitla
20				San Lorenzo Texmelucan
20				San Lorenzo Victoria
20				San Lucas Camotlán
20				San Lucas Ojitlán
20				San Lucas Quiaviní
20				San Lucas Zoquiápam
20				San Luis Amatlán
20				San Marcial Ozolotepec
20				San Marcos Arteaga
20				San Martín de los Cansecos
20				San Martín Huamelúlpam
20				San Martín Itunyoso
20				San Martín Lachilá
20				San Martín Peras
20				San Martín Tilcajete
20				San Martín Toxpalan
20				San Martín Zacatepec
20				San Mateo Cajonos
20				San Mateo del Mar
20				San Mateo Etlatongo
20				San Mateo Nejápam
20				San Mateo Peñasco
20				San Mateo Piñas
20				San Mateo Río Hondo
20				San Mateo Sindihui
20				San Mateo Tlapiltepec
20				San Mateo Yoloxochitlán
20				San Melchor Betaza
20				San Miguel Achiutla
20				San Miguel Ahuehuetitlán
20				San Miguel Aloápam
20				San Miguel Amatitlán
20				San Miguel Amatlán
20				San Miguel Coatlán
20				San Miguel Chicahua
20				San Miguel Chimalapa
20				San Miguel del Puerto
20				San Miguel del Río
20				San Miguel Ejutla
20				San Miguel el Grande
20				San Miguel Huautla
20				San Miguel Mixtepec
20				San Miguel Panixtlahuaca
20				San Miguel Peras
20				San Miguel Piedras
20				San Miguel Quetzaltepec
20				San Miguel Santa Flor
20				San Miguel Soyaltepec
20				San Miguel Suchixtepec
20				San Miguel Tecomatlán
20				San Miguel Tenango
20				San Miguel Tequixtepec
20				San Miguel Tilquiápam
20				San Miguel Tlacamama
20				San Miguel Tlacotepec
20				San Miguel Tulancingo
20				San Miguel Yotao
20				San Nicolás
20				San Nicolás Hidalgo
20				San Pablo Coatlán
20				San Pablo Cuatro Venados
20				San Pablo Etla
20				San Pablo Huitzo
20				San Pablo Huixtepec
20				San Pablo Macuiltianguis
20				San Pablo Tijaltepec
20				San Pablo Villa de Mitla
20				San Pablo Yaganiza
20				San Pedro Amuzgos
20				San Pedro Apóstol
20				San Pedro Atoyac
20				San Pedro Cajonos
20				San Pedro Comitancillo
20				San Pedro Cocaltepec Cántaros
20				San Pedro el Alto
20				San Pedro Huamelula
20				San Pedro Huilotepec
20				San Pedro Ixcatlán
20				San Pedro Ixtlahuaca
20				San Pedro Jaltepetongo
20				San Pedro Jicayán
20				San Pedro Jocotipac
20				San Pedro Juchatengo
20				San Pedro Mártir
20				San Pedro Mártir Quiechapa
20				San Pedro Mártir Yucuxaco
20				San Pedro Mixtepec, distrito 22
20				San Pedro Mixtepec, distrito 26
20				San Pedro Molinos
20				San Pedro Nopala
20				San Pedro Ocopetatillo
20				San Pedro Ocotepec
20				San Pedro Pochutla
20				San Pedro Quiatoni
20				San Pedro Sochiápam
20				San Pedro Tapanatepec
20				San Pedro Taviche
20				San Pedro Teozacoalco
20				San Pedro Teutila
20				San Pedro Tidaá
20				San Pedro Topiltepec
20				San Pedro Totolápam
20				San Pedro y San Pablo Ayutla
20				San Pedro y San Pablo Teposcolula
20				San Pedro y San Pablo Tequixtepec
20				San Pedro Yaneri
20				San Pedro Yólox
20				San Pedro Yucunama
20				San Raymundo Jalpan
20				San Sebastián Abasolo
20				San Sebastián Coatlán
20				San Sebastián Ixcapa
20				San Sebastián Nicananduta
20				San Sebastián Río Hondo
20				San Sebastián Tecomaxtlahuaca
20				San Sebastián Teitipac
20				San Sebastián Tutla
20				San Simón Almolongas
20				San Simón Zahuatlán  
20				Santa Ana
20				Santa Ana Ateixtlahuaca
20				Santa Ana Cuauhtémoc
20				Santa Ana del Valle
20				Santa Ana Tavela
20				Santa Ana Tlapacoyan
20				Santa Ana Yareni
20				Santa Ana Zegache
20				Santa Catalina Quieri
20				Santa Catarina Cuixtla
20				Santa Catarina Ixtepeji
20				Santa Catarina Juquila
20				Santa Catarina Lachatao
20				Santa Catarina Loxicha
20				Santa Catarina Mechoacán
20				Santa Catarina Minas
20				Santa Catarina Quiané
20				Santa Catarina Quioquitani
20				Santa CatarinaTayata
20				Santa Catarina Ticuá
20				Santa Catarina Yosonotú
20				Santa Catarina Zapoquila
20				Santa Cruz Acatepec
20				Santa Cruz Amilpas
20				Santa Cruz de Bravo
20				Santa Cruz Itundujia
20				Santa Cruz Mixtepec
20				Santa Cruz Nundaco
20				Santa Cruz Papalutla
20				Santa Cruz Tacache de Mina
20				Santa Cruz Tacahua
20				Santa Cruz Tayata
20				Santa Cruz Xitla
20				Santa Cruz Xoxocotlán
20				Santa Cruz Zenzontepec
20				Santa Gertrudis
20				Santa Inés del Monte
20				Santa Inés de Zaragoza
20				Santa Inés Yatzeche
20				Santa Lucía del Camino
20				Santa Lucía Miahuatlán
20				Santa Lucía Monteverde
20				Santa Lucía Ocotlán
20				Santa Magdalena Jicotlán
20				Santa María Alotepec
20				Santa María Apazco
20				Santa María Atzompa
20				Santa María Camotlán
20				Santa María Chachoápam
20				Santa María Chilchotla
20				Santa María Chimalapa
20				Santa María Colotepec
20				Santa María Cortijo
20				Santa María Coyotepec
20				Santa María del Rosario
20				Santa María del Tule
20				Santa María Ecatepec
20				Santa María Guelacé
20				Santa María Guienagati
20				Santa María Huatulco
20				Santa María Huazolotitlán
20				Santa María Ipalapa
20				Santa María Ixcatlán
20				Santa María Jacatepec
20				Santa María Jalapa del Marqués
20				Santa María Jaltianguis
20				Santa María la Asunción
20				Santa María Lachixío
20				Santa María Mixtequilla
20				Santa María Nativitas
20				Santa María Nduayaco
20				Santa María Ozolotepec
20				Santa María Pápalo
20				Santa María Peñoles
20				Santa María Petapa
20				Santa María Quiegolani
20				Santa María Sola
20				Santa María Tataltepec
20				Santa María Tecomavaca
20				Santa María Temaxcalapa
20				Santa María Temaxcaltepec
20				Santa María Teopoxco
20				Santa María Tepantlali
20				Santa María Texcatitlán
20				Santa María Tlahuitoltepec
20				Santa María Tlalixtac
20				Santa María Tonameca
20				Santa María Totolapilla
20				Santa María Xadani
20				Santa María Yalina
20				Santa María Yavesía
20				Santa María Yolotepec
20				Santa María Yosoyua
20				Santa María Yucuhiti
20				Santa María Zacatepec
20				Santa María Zaniza
20				Santa María Zoquitlán
20				Santiago Amoltepec
20				Santiago Apoala
20				Santiago Apóstol
20				Santiago Astata
20				Santiago Atitlán
20				Santiago Ayuquililla
20				Santiago Cacaloxtepec
20				Santiago Camotlán
20				Santiago Chazumba
20				Santiago Choápam
20				Santiago Comaltepec
20				Santiago del Río
20				Santiago Huajolotitlán
20				Santiago Huauclilla
20				Santiago Ihuitlán Plumas
20				Santiago Ixcuintepec
20				Santiago Ixtayutla
20				Santiago Jamiltepec
20				Santiago Jocotepec
20				Santiago Juxtlahuaca
20				Santiago Lachiguiri
20				Santiago Lalopa
20				Santiago Laollaga
20				Santiago Laxopa
20				Santiago Llano Grande
20				Santiago Matatlán
20				Santiago Miltepec
20				Santiago Minas
20				Santiago Nacaltepec
20				Santiago Nejapilla
20				Santiago Niltepec
20				Santiago Nundiche
20				Santiago Nuyoó
20				Santiago Pinotepa Nacional
20				Santiago Suchilquitongo
20				Santiago Tamazola
20				Santiago Tapextla
20				Santiago Tenango
20				Santiago Tepetlapa
20				Santiago Tetepec
20				Santiago Texcalcingo
20				Santiago Textitlán
20				Santiago Tilantongo
20				Santiago Tillo
20				Santiago Tlazoyaltepec
20				Santiago Xanica
20				Santiago Xiacuí
20				Santiago Yaitepec
20				Santiago Yaveo
20				Santiago Yolomécatl
20				Santiago Yosondúa
20				Santiago Yucuyachi
20				Santiago Zacatepec
20				Santiago Zoochila
20				Santo Domingo Albarradas
20				Santo Domingo Armenta
20				Santo Domingo Chihuitán
20				Santo Domingo de Morelos
20				Santo Domingo Ingenio
20				Santo Domingo Ixcatlán
20				Santo Domingo Nuxaá
20				Santo Domingo Ozolotepec
20				Santo Domingo Petapa
20				Santo Domingo Roayaga
20				Santo Domingo Tehuantepec
20				Santo Domingo Teojomulco
20				Santo Domingo Tepuxtepec
20				Santo Domingo Tlatayapam
20				Santo Domingo Tomaltepec
20				Santo Domingo Tonalá
20				Santo Domingo Tonaltepec
20				Santo Domingo Xagacía
20				Santo Domingo Yanhuitlán
20				Santo Domingo Yodohino
20				Santo Domingo Zanatepec
20				Santo Tomás Jalieza
20				Santo Tomás Mazaltepec
20				Santo Tomás Ocotepec
20				Santo Tomás Tamazulapan
20				Santos Reyes Nopala
20				Santos Reyes Pápalo
20				Santos Reyes Tepejillo
20				Santos Reyes Yucuná
20				San Vicente Coatlán
20				San Vicente Lachixío
20				San Vicente Nuñú
20				Silacayoápam
20				Sitio de Xitlapehua
20				Soledad Etla
20				Tamazulápam del Espíritu Santo
20				Tanetze de Zaragoza
20				Taniche
20				Tataltepec de Valdés
20				Teococuilco de Marcos Pérez
20				Teotitlán de Flores Magón
20				Teotitlán del Valle
20				Teotongo
20				Tepelmeme Villa de Morelos
20				Tezoatlán de Segura y Luna
20				Tlacolula de Matamoros
20				Tlacotepec Plumas
20				Tlalixtac de Cabrera
20				Totontepec Villa de Morelos
20				Trinidad Zaáchila
20				Unión Hidalgo
20				Valerio Trujano
20				Villa de Chilapa de Díaz
20				Villa de Etla
20				Villa de Tamazulápam del Progreso
20				Villa de Tututepec de Melchor Ocampo
20				Villa de Zaáchila
20				Villa Díaz Ordaz
20				Villa Hidalgo
20				Villa Sola de Vega
20				Villa Talea de Castro
20				Villa Tejupam de la Unión
20				Yaxe
20				Yogana
20				Yutanduchi de Guerrero
20				Zapotitlán del Río
20				Zapotitlán Lagunas
20				Zapotitlán Palmas
21				Acajete
21				Acateno
21				Acatlán
21				Acatzingo
21				Acteopan
21				Ahuacatlán
21				Ahuatlán
21				Ahuazotepec
21				Ahuehuetitla
21				Ajalpan
21				Albino Zertuche
21				Aljojuca
21				Altepexi
21				Amixtlán
21				Amozoc
21				Aquixtla
21				Atempan
21				Atexcal
21				Atlequizayan
21				Atlixco
21				Atoyatempan
21				Atzala
21				Atzitzihuacán
21				Atzitzintla
21				Axutla
21				Ayotoxco de Guerrero
21				Calpan
21				Caltepec
21				Camocuautla
21				Cañada Morelos
21				Caxhuacan
21				Chalchicomula de Sesma
21				Chapulco
21				Chiautla
21				Chiautzingo
21				Chichiquila
21				Chiconcuautla
21				Chietla
21				Chigmecatitlán
21				Chignahuapan
21				Chignautla
21				Chila
21				Chila de la Sal
21				Chilchotla
21				Chinantla
21				Coatepec
21				Coatzingo
21				Cohetzala
21				Cohuecan
21				Coronango
21				Coxcatlán
21				Coyomeapan
21				Coyotepec
21				Cuapiaxtla de Madero
21				Cuautempan
21				Cuautinchán
21				Cuautlancingo
21				Cuayuca de Andradre
21				Cuetzalan del Progreso
21				Cuyoaco
21				Domingo Arenas
21				Eloxochitlán
21				Epatlán
21				Esperanza
21				Francisco Z. Mena
21				General Felipe Ángeles
21				Guadalupe
21				Guadalupe Victoria
21				Hermenegildo Galeana
21				Honey
21				Huaquechula
21				Huatlatlauca
21				Huauchinango
21				Huehuetla
21				Huehuetlán el Chico
21				Huehuetlán el Grande
21				Huejotzingo
21				Hueyapan
21				Hueytamalco
21				Hueytlalpan
21				Huitzilán de Serdán
21				Huitziltepec
21				Ixcamilpa de Guerrero
21				Ixcaquixtla
21				Ixtacamaxtitlán
21				Ixtepec
21				Izúcar de Matamoros
21				Jalpan
21				Jolalpan
21				Jonotla
21				Jopala
21				Juan C. Bonilla
21				Juan Galindo
21				Juan N. Méndez
21				La fragua
21				Libres
21				Los Reyes de Juárez
21				Magdalena Tlatlauquitepec
21				Mazapiltepec de Juárez
21				Mixtla
21				Molcaxac
21				Naupan
21				Nauzontla
21				Nealtican
21				Nicolás Bravo
21				Nopalucan
21				Ocotepec
21				Ocoyucan
21				Olintla
21				Oriental
21				Pahuatlán
21				Palmar de Bravo
21				Pantepec
21				Petlalcingo
21				Piaxtla
21				Puebla de Zaragoza
21				Quecholac
21				Quimixtlán
21				Rafael Lara Grajales
21				San Andrés Cholula
21				San Antonio Cañada
21				San Diego La Meza Tochimiltzingo
21				San Felipe Teotlalcingo
21				San Felipe Tepatlán
21				San Gabriel Chilac
21				San Gregorio Atzompa
21				San Jerónimo Tecuanipan
21				San Jerónimo Xayacatlán
21				San José Chiapa
21				San José Miahuatlán
21				San Juan Atenco
21				San Juan Atzompa
21				San Martín Texmelucan
21				San Martín Totoltepec
21				San Matías Tlalancaleca
21				San Miguel Ixtitlán
21				San Miguel Xoxtla
21				San Nicolás Buenos Aires
21				San Nicolás de los Ranchos
21				San Pablo Anicano
21				San Pedro Cholula
21				San Pedro Yeloixtlahuaca
21				San Salvador el Seco
21				San Salvador el Verde
21				San Salvador Huixcolotla
21				San Sebastián Tlacotepec
21				Santa Catarina Tlaltempan
21				San Inés Ahuatempan
21				Santa Isabel Cholula
21				Santiago Miahuatlán 
21				Santo Tomás Hueyotlipan
21				Soltepec
21				Tecali de Herrera
21				Tecamachalco
21				Tecomatlán
21				Tehuacán
21				Tehuitzingo
21				Tenampulco
21				Teopantlán
21				Teotlalco
21				Tepanco de López
21				Tepango de Rodríguez
21				Tepatlaxco de Hidalgo
21				Tepeaca
21				Tepemaxalco
21				Tepeojuma
21				Tepetzintla
21				Tepexco
21				Tepexi de Rodríguez
21				Tepeyahualco
21				Tepeyahualco de Cuauhtémoc
21				Tetela de Ocampo
21				Teteles de Ávila Castillo
21				Teziutlán
21				Tianguismanalco
21				Tilapa
21				Tlacotepec de Benito Juárez
21				Tlacuilotepec
21				Tlachichuca
21				Tlahuapan
21				Tlaltenango
21				Tlanepantla
21				Tlaola
21				Tlapacoya
21				Tlapanalá
21				Tlatlauquitepec
21				Tlaxco
21				Tochimilco
21				Tochtepec
21				Totoltepec de Guerrero
21				Tulcingo
21				Tuzamapan de Galeana
21				Tzicatlacoyan
21				Venustiano Carranza
21				Vicente Guerrero
21				Xayacatlán de Bravo
21				Xicotepec
21				Xicotlán
21				Xiutetelco
21				Xochiapulco
21				Xochiltepec
21				Xochitlán de Vicente Suárez
21				Xochitlán Todos Santos
21				Yaonahuac
21				Yehualtepec
21				Zacapala
21				Zacapoaxtla
21				Zacatlán
21				Zapotitlán
21				Zapotitlán de Méndez
21				Zaragoza
21				Zautla
21				Zihuateutla
21				Zinacatepec
21				Zongozotla
21				Zoquiapan
21				Zoquitlán
22				Amealco de Bonfil
22				Arroyo Seco
22				Cadereyta de Montes
22				Colón
22				Corregidora
22				El Marqués
22				Ezequiel Montes
22				Huimilpan
22				Jalpan de Serra
22				Landa de Matamoros
22				Pedro Escobedo
22				Peñamiller
22				Pinal de Amoles
22				Querétaro
22				San Joaquín
22				San Juan del Río
22				Tequisquiapan
22				Tolimán
23				Benito Juárez
23				Cozumel
23				Felipe Carrillo Puerto
23				Isla Mujeres
23				José María Morelos
23				Lázaro Cárdenas
23				Othón P. Blanco
23				Solidaridad
23				Tulum
24				Ahualulco
24				Alaquines
24				Aquismón
24				Armadillo de los Infante
24				Axtla de Terrazas
24				Cárdenas
24				Catorce
24				Cedral
24				Cerritos
24				Cerro de San Pedro
24				Charcas
24				Ciudad del Maíz
24				Ciudad Fernández
24				Ciudad Valles
24				Coxcatlán
24				Ebano
24				El Naranjo
24				Guadalcázar
24				Huehuetlán
24				Lagunillas
24				Matehuala
24				Matlapa
24				Mexquitic de Carmona
24				Moctezuma
24				Rayón
24				Rioverde
24				Salinas
24				San Antonio
24				San Ciro de Acosta
24				San Luis Potosí
24				San Martín Chalchicuautla
24				San Nicolás Tolentino
24				Santa Catarina
24				Santa María del Río
24				Santo Domingo
24				San Vicente Tancuayalab
24				Soledad de Graciano Sánchez
24				Tamasopo
24				Tamazunchale
24				Tampacán
24				Tampamolón Corona
24				Tamuín
24				Tancanhuitz de Santos
24				Tanlajás
24				Tanquián de Escobedo
24				Tierra Nueva
24				Vanegas
24				Venado
24				Villa de Arriaga
24				Villa de Arista
24				Villa de Guadalupe
24				Villa de la Paz
24				Villa de Ramos
24				Villa de Reyes
24				Villa Hidalgo
24				Villa Juárez
24				Xilitla
24				Zaragoza
25				Ahome
25				Angostura
25				Badiraguato
25				Choix
25				Concordia
25				Cosalá
25				Culiacán
25				El Fuerte
25				Elota
25				El Rosario
25				Escuinapa
25				Guasave
25				Mazatlán
25				Mocorito
25				Navolato
25				Salvador Alvarado
25				San Ignacio
25				Sinaloa de Leyva
26				Aconchi
26				Agua Prieta
26				Alamos
26				Altar
26				Arivechi
26				Arizpe
26				Atil
26				Bacadéhuachi
26				Bacanora
26				Bacerac
26				Bacoachi
26				Bácum
26				Banámichi
26				Baviácora
26				Bavíspe
26				Benito Juárez
26				Benjamín Hill
26				Caborca
26				Cajeme
26				Cananea
26				Carbó
26				Cocurpe
26				Cumpas
26				Divisaderos
26				Empalme
26				Etchojoa
26				Fronteras
26				General Plutarco Elías Calles
26				Granados
26				Guaymas
26				Hermosillo
26				Huachinera
26				Huásabas
26				Huatabampo
26				Huépac
26				Imuris
26				La Colorada
26				Magdalena
26				Mazatán
26				Moctezuma
26				Naco
26				Nácori Chico
26				Nacozari de García
26				Navojoa
26				Nogales
26				Onavas
26				Opodepe
26				Oquitoa
26				Pitiquito
26				Puerto Peñasco
26				Quiriego
26				Rayón
26				Rosario
26				Sahuaripa
26				San Felipe de Jesús
26				San Ignacio Río Muerto
26				San Javier
26				San Luis Río Colorado
26				San Miguel de Horcasitas
26				San Pedro de la Cueva
26				Santa Ana
26				Santa Cruz
26				Sáric
26				Soyopa
26				Suaqui Grande
26				Tepache
26				Trincheras
26				Tubutama
26				Ures
26				Villa Hidalgo
26				Villa Pesqueira
26				Yécora
27				Balancán
27				Cárdenas
27				Centla
27				Centro
27				Comalcalco
27				Cunduacán
27				Emiliano Zapata
27				Huimanguillo
27				Jalapa
27				Jalpa de Méndez
27				Jonuta
27				Macuspana
27				Nacajuca
27				Paraíso
27				Tacotalpa
27				Teapa
27				Tenosique
28				Abasolo
28				Aldama
28				Altamira
28				Antiguo Morelos
28				Burgos
28				Bustamante
28				Camargo
28				Casas
28				Ciudad Madero
28				Cruillas
28				Gómez Farías
28				González
28				Güemez
28				Guerrero
28				Gustavo Díaz Ordaz
28				Hidalgo
28				Jaumave
28				Jiménez
28				Llera
28				Mainero
28				Mante
28				Matamoros
28				Méndez
28				Mier
28				Miguel Alemán
28				Miquihuana
28				Nuevo Laredo
28				Nuevo Morelos
28				Ocampo
28				Padilla
28				Palmillas
28				Reynosa
28				Río Bravo
28				San Carlos
28				San Fernando
28				San Nicolás
28				Soto La Marina
28				Tampico
28				Tula
28				Valle Hermoso
28				Victoria
28				Villagrán
28				Xicotencatl
29				Acuamanala de Miguel Hidalgo
29				Altzayanca
29				Amaxac de Guerrero
29				Apetatitlán de Antonio Carvajal
29				Atlangatepec
29				Apizaco
29				Benito Juárez
29				Calpulalpan
29				Chiautempan
29				Contla de Juan Cuamatzi
29				Cuapiaxtla
29				Cuaxomulco
29				El Carmen Tequexquitla
29				Emiliano Zapata
29				Españita
29				Huamantla
29				Hueyotlipan
29				Ixtacuixtla de Mariano Matamoros
29				Ixtenco
29				La Magdalena Tlaltelulco
29				Lázaro Cárdenas
29				Mazatecochco de José María Morelos
29				Muñoz de Domingo Arenas
29				Nanacamilpa de Mariano Arista
29				Nativitas
29				Panotla
29				Papalotla de Xicohténcatl
29				Sanctorum de Lázaro Cárdenas
29				San Damián Texoloc
29				San Francisco Tetlanohcan
29				Jerónimo Zacualpan
29				San José Teacalco
29				San Juan Huactzinco
29				San Lorenzo Axocomanitla
29				San Lucas Tecopilco
29				San Pablo del Monte
29				Santa Ana Nopalucan
29				Santa Apolonia Teacalco
29				Santa Catarina Ayometla
29				Santa Cruz Quilehtla
29				Santa Cruz Tlaxcala
29				Santa Isabel Xiloxoxtla
29				Tenancingo
29				Teolocholco
29				Tepetitla de Lardizábal
29				Tepeyanco
29				Terrenate
29				Tetla de la Solidaridad
29				Tetlatlahuca
29				Tlaxcala
29				Tlaxco
29				Tocatlán
29				Totolac
29				Tzompantepec
29				Xaloztoc
29				Xaltocan
29				Xicohtzinco
29				Yauhquemecan
29				Zacatelco
29				Zitlaltepec de Trinidad Sánchez Santos
30				Acajete
30				Acatlán
30				Acayucan
30				Actopan
30				Acula
30				Acultzingo
30				Agua Dulce
30				Álamo Temapache
30				Alpatláhuac
30				Alto Lucero de Gutiérrez Barrios
30				Altotonga
30				Alvarado
30				Amatitlán
30				Amatlán de los Reyes
30				Ángel R. Cabada
30				Apazapan
30				Aquila
30				Astacinga
30				Atlahuilco
30				Atoyac
30				Atzacan
30				Atzalan
30				Ayahualulco
30				Banderilla
30				Benito Juárez
30				Boca del Río
30				Calcahualco
30				Camarón de Tejeda
30				Camerino Z. Mendoza
30				Carlos A. Carrillo
30				Carrillo Puerto
30				Castillo de Teayo
30				Catemaco
30				Cazones de Herrera
30				Cerro Azul
30				Chacaltianguis
30				Chalma
30				Chiconamel
30				Chiconquiaco
30				Chicontepec
30				Chinameca
30				Chinampa de Gorostiza
30				Chocamán
30				Chontla
30				Chumatlán
30				Citlaltépetl
30				Coacoatzintla
30				Coahuitlán
30				Coatepec
30				Coatzacoalcos
30				Coatzintla
30				Coetzala
30				Colipa
30				Comapa
30				Córdoba
30				Cosamaloapan de Carpio
30				Consautlán de Carvajal
30				Coscomatepec
30				Cosoleacaque
30				Cotaxtla
30				Coxquihui
30				Coyutla
30				Cuichapa
30				Cuitláhuac
30				El Higo
30				Emiliano Zapata
30				Espinal
30				Filomeno Mata
30				Fortín
30				Gutiérrez Zamora
30				Hidalgotitlán
30				Huayacocotla
30				Hueyapan de Ocampo
30				Huiloapan de Cuauhtémoc
30				Ignacio de la Llave
30				Ilamatlán
30				Isla
30				Ixcatepec
30				Ixhuacán de los Reyes
30				Ixhuatlancillo
30				Ixhuatlán del Café
30				Ixhuatlán de Madero
30				Ixhuatlán del Sureste
30				Ixmatlahuacan
30				Ixtaczoquitlán
30				Jalacingo
30				Jalcomulco
30				Jáltipan
30				Jamapa
30				Jesús Carranza
30				Jilotepec
30				José Azueta
30				Juan Rodríguez Clara
30				Juchique de Ferrer
30				La Antigua
30				Landero y Coss
30				La Perla
30				Las Choapas
30				Las Minas
30				Las Vigas de Ramírez
30				Lerdo de Tejada
30				Los Reyes
30				Magdalena
30				Maltrata
30				Manlio Fabio Altamirano
30				Mariano Escobedo
30				Martínez de la Torre
30				Mecatlán
30				Mecayapan
30				Medellín
30				Miahuatlán
30				Minatitlán
30				Misantla
30				Mixtla de Altamirano
30				Moloacán
30				Nanchital de Lázaro Cárdenas del Río
30				Naolinco
30				Naranjal
30				Naranjos Amatlán
30				Nautla
30				Nogales
30				Oluta
30				Omealca
30				Orizaba
30				Otatitlán
30				Oteapan
30				Ozuluama de Mascañeras
30				Pajapan
30				Pánuco
30				Papantla
30				Paso del Macho
30				Paso de Ovejas
30				Perote
30				Platón Sánchez
30				Playa Vicente
30				Poza Rica de Hidalgo
30				Pueblo Viejo
30				Puente Nacional
30				Rafael Delgado
30				Rafael Lucio
30				Río Blanco
30				Saltabarranca
30				San Andrés Tenejapan
30				San Andrés Tuxtla
30				San Juan Evangelista
30				San Rafael
30				Santiago Sochiapan
30				Santiago Tuxtla
30				Sayula de Alemán
30				Soconusco
30				Sochiapa
30				Soledad Atzompa
30				Soledad de Doblado
30				Soteapan
30				Tamalín
30				Tamiahua
30				Tampico Alto
30				Tancoco
30				Tantima
30				Tantoyuca
30				Tatatila
30				Tatahuicapan de Juárez
30				Tecolutla
30				Tehuipango
30				Tempoal
30				Tenampa
30				Tenochtitlán
30				Teocelo
30				Tepatlaxco
30				Tepetlán
30				Tepetzintla
30				Tequila
30				Texcatepec
30				Texhuacán
30				Texistepec
30				Tezonapa
30				Tihuatlán
30				Tierra Blanca
30				Tlacojalpan
30				Tlacolulan
30				Tlacotalpan
30				Tlacotepec de Mejía
30				Tlachichilco
30				Tlalixcoyan
30				Tlalnelhuayocan
30				Tlaltetela
30				Tlapacoyan
30				Tlaquilpa
30				Tlilapan
30				Tomatlán
30				Tonayán
30				Totutla
30				Tres Valles
30				Tuxpan
30				Tuxtilla
30				Úrsulo Galván
30				Uxpanapa
30				Vega de Alatorre
30				Veracruz
30				Villa Aldama
30				Xalapa
30				Xico
30				Xoxocotla
30				Yanga
30				Yecuatla
30				Zacualpan
30				Zaragoza
30				Zentla
30				Zongolica
30				Zontecomatlán
30				Zozocolco de Hidalgo
31				Abalá
31				Acanceh
31				Akil
31				Baca
31				Bokobá
31				Buctzotz
31				Cacalchén
31				Calotmul
31				Cansahcab
31				Cantamayec
31				Calestún
31				Cenotillo
31				Conkal
31				Cuncunul
31				Cuzamá
31				Chacsinkín
31				Chankom
31				Chapab
31				Chemax
31				Chicxulub Pueblo
31				Chichimilá
31				Chikindzonot
31				Chocholá
31				Chumayel
31				Dzán
31				Dzemul
31				Dzidzantún
31				Dzilam de Bravo
31				Dzilam González
31				Dzitás
31				Dzoncauich
31				Espita
31				Halachó
31				Hocabá
31				Hoctún
31				Homún
31				Huhí
31				Hunucmá
31				Ixil
31				Izamal
31				Kanasín
31				Kantunil
31				Kaua
31				Kinchil
31				Kopomá
31				Mama
31				Maní
31				Maxcanú
31				Mayapán
31				Mérida
31				Mocochá
31				Motul
31				Muna
31				Muxupip
31				Opichén
31				Oxkutzcab
31				Panabá
31				Peto
31				Progreso
31				Quintana Roo
31				Río Lagartos
31				Sacalum
31				Samahil
31				Sanahcat
31				San Felipe
31				Santa Elena
31				Seyé
31				Sinanché
31				Sotuta
31				Sucilá
31				Sudzal
31				Suma de Hidalgo
31				Tahdziú
31				Tahmek
31				Teabo
31				Tecoh
31				Tekal de Venegas
31				Tekantó
31				Tekax
31				Tekit
31				Tekom
31				Telchac Pueblo
31				Telchac Puerto
31				Temax
31				Temozón
31				Tepakán
31				Tetiz
31				Teya
31				Ticul
31				Timucuy
31				Tinúm
31				Tixcacalcupul
31				Tixkokob
31				Tixméhuac
31				Tixpéhual
31				Tizimín
31				Tunkás
31				Tzucacab
31				Uayma
31				Ucú
31				Umán
31				Valladolid
31				Xocchel
31				Yaxcabá
31				Yaxkukul
31				Yobaín
32				Apozol
32				Apulco
32				Atolinga
32				Benito Juárez
32				Calera
32				Cañitas de Felipe Pescador
32				Concepción del Oro
32				Cuauhtémoc
32				Chalchihuites
32				Fresnillo
32				Trinidad García de la Cadena
32				Genaro Codina
32				General Enrique Estrada
32				General Francisco R. Murguía
32				El Plateado de Joaquín Amaro
32				El Salvador
32				General Pánfilo Natera
32				Guadalupe
32				Huanusco
32				Jalpa
32				Jerez
32				Jiménez del Teul
32				Juan Aldama
32				Juchipila
32				Loreto
32				Luis Moya
32				Mazapil
32				Melchor Ocampo
32				Mezquital del Oro
32				Miguel Auza
32				Momax
32				Monte Escobedo
32				Morelos
32				Moyahua de Estrada
32				Nochistlán de Mejía
32				Noria de Ángeles
32				Ojocaliente
32				Pánuco
32				Pinos
32				Río Grande
32				Sain Alto
32				Santa María de la Paz
32				Sombrerete
32				Susticacán
32				Tabasco
32				Tepechitlán
32				Tepetongo
32				Teul de González Ortega
32				Tlaltenango de Sánchez Román
32				Trancoso
32				Valparaíso
32				Vetagrande
32				Villa de Cos
32				Villa García
32				Villa González Ortega
32				Villa Hidalgo
32				Villanueva
32				Zacatecas
*/