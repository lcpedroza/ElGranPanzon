insert into Generos (Nombre) values ('Masculino');
insert into Generos (Nombre) values ('Femenino');
insert into Generos (Nombre) values ('Otro');


insert into TiposDocumento (NombreLargo, NombreCorto) values ('Cédula de ciudadanía', 'C.C.');
insert into TiposDocumento (NombreLargo, NombreCorto) values ('Cédula de extranjería', 'C.E');
insert into TiposDocumento (NombreLargo, NombreCorto) values ('Pasaporte', 'P.P');
insert into TiposDocumento (NombreLargo, NombreCorto) values ('Tarjeta de identidad', 'T.I');


insert into Sedes (Nombre, Direccion, Telefono) values ('El Gran Panzón - Bogotá', 'Cra 50 #128 - 38', '3001112222');
insert into Sedes (Nombre, Direccion, Telefono) values ('El Gran Panzón - Santa Marta', 'Calle 30 Cra 14', '3005182822');
insert into Sedes (Nombre, Direccion, Telefono) values ('El Gran Panzón - Barranquilla', 'Calle 90 Cra 54', '3009812234');


alter table Roles modify Nombre varchar(30);

insert into Roles (Nombre) values ('Super Aministrador');
insert into Roles (Nombre) values ('Administrador');
insert into Roles (Nombre) values ('Administrador de insumos');
insert into Roles (Nombre) values ('Cajero');

insert into Personas (Nombres, Apellidos, GeneroId, TipoDocumentoId, NumeroDocumento)
VALUES ('Luis Carlos', 'Pedroza Pineda', 1, 3, '1079935000');

insert into Empleados (PersonaId, FechaContratacion, FechaCreacion, Salario, RolId, Correo, Clave, Telefono, SedeId)
values (1, to_date('15/02/2020','DD/MM/YYYY'), sysdate, 2000000, 1, 'luisk@gmail.com', '12345', '3004250000', 1);

insert into CategoriasComidas (Nombre) values ('Platos');
insert into CategoriasComidas (Nombre) values ('Jugos Naturales');
insert into CategoriasComidas (Nombre) values ('Bebidas Refrescantes');

insert into Comidas (Nombre, Precio, CategoriaId) values ('Perro Caliente', 5000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Hamburguesa Especial', 20000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Lasagna', 10000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Carne Asada', 14000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Pechuga a la plancha', 15000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Arepa con chorizo', 3000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Arepa rellena', 2000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Empanada de la casa', 3000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Pizza de peperoni', 5000, 1 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Slachipapa Ranchera', 11000, 1 );

insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo de Mora', 2000, 2 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo de Mango', 2000, 2 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo de Naranja', 2000, 2 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo de Guayaba', 2000, 2 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo de Borojó', 2000, 2 );

insert into Comidas (Nombre, Precio, CategoriaId) values ('Cocacola 300 ml', 2000, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Pepsi 300 ml', 2000, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('7Up 300 ml', 2000, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Sprite 300 ml', 2000, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo Hit 300 ml', 2500, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Jugo del Valle 300 ml', 2500, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Quatro 300 ml', 2500, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Pony Malta 300 ml', 3000, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Pola y Cola 300 ml', 3000, 3 );
insert into Comidas (Nombre, Precio, CategoriaId) values ('Colombiana 300 ml', 2000, 3 );


drop TABLE Empleados;
drop TABLE Clientes;
drop TABLE Personas;
drop TABLE ComidaInsumos;
drop TABLE Comidas;
drop TABLE DetalleFacturas;
drop TABLE Facturas;
drop TABLE RelacionDeRoles;
drop TABLE PermisosRoles;
drop TABLE Roles;
drop TABLE Permisos;
drop TABLE TiposDocumento;
drop TABLE Generos;
drop TABLE CategoriasComidas;
drop TABLE Inventarios;
drop TABLE Insumos;
drop TABLE CategoriasInsumos;
drop TABLE Sedes;






