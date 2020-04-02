

create table Sedes(
	Id number generated always as identity primary key,
	Nombre varchar(100) not null,
	Direccion varchar(100) not null,
	Telefono varchar(14) not null
);


create table Generos(
	Id number generated always as identity primary key,
	Nombre varchar(9) not null
);

create table TiposDocumento (
	Id number generated always as identity primary key,
	NombreLargo varchar(30) not null,
	NombreCorto varchar(4) not null
);

create table Permisos(
	Id number generated always as identity primary key,
	Nombre varchar(30) not null,
	Codigo varchar(30) not null
);

create table Roles(
	Id number generated always as identity primary key,
	Nombre varchar(30) not null
);

create table PermisosRoles(
	RolId number not null,
	constraint PerRolesRol foreign key (RolId) references Roles(Id),
	PermisoId number not null,
	constraint PermisosRolesPer foreign key (PermisoId) references Permisos(Id),
    primary key(RolId, PermisoId)
);

select * from PermisosRoles;
select * from RelacionDeRoles;

create table RelacionDeRoles(
    RolPadreId number not null,
	constraint RelaRolesP foreign key (RolPadreId) references Roles(Id),
	RolHijoId number not null,
	constraint RelaRolesH foreign key (RolHijoId) references Roles(Id),
    primary key(RolPadreId, RolHijoId)
);

create table Personas(
	Id number generated always as identity primary key,
	Nombres varchar(50) not null,
	Apellidos varchar(50) not null,
	GeneroId number not null,
	constraint EmpGen foreign key (GeneroId) references Generos(Id),
	TipoDocumentoId number not null,
	constraint EmpTip foreign key (TipoDocumentoId) references TiposDocumento(Id),
	NumeroDocumento varchar(12) not null
);

create table Empleados(
	Id number generated always as identity primary key,
	PersonaId number not null,
	constraint EmpPer foreign key (PersonaId) references Personas(Id),
	FechaContratacion date not null,
	FechaCreacion date default sysdate not null ,
	Salario number not null,
	RolId number not null,
	constraint EmpRol foreign key (RolId) references Roles(Id),
	Correo varchar(100) not null,
	Clave varchar(32)not null,
	Telefono varchar(14)not null,
	SedeId number not null,
	constraint EmpSed foreign key (SedeId) references Sedes(Id)
);


create table CategoriasComidas(
	Id number generated always as identity primary key,
	Nombre varchar(50) not null
);

create table Comidas(
	Id number generated always as identity primary key,
	Nombre varchar(30) not null,
	Precio float not null,
	CategoriaId number not null,
	constraint ComCatCom foreign key (CategoriaId) references CategoriasComidas(Id)
);

create table CategoriasInsumos(
	Id number generated always as identity primary key,
	Nombre varchar(50) not null
);

create table Unidades(
	Id number generated always as identity primary key,
	NombreLargo varchar(10) not NULL,
	NombreCorto varchar(4)NOT null
);

create table Insumos(
	Id number generated always as identity primary key,
	Nombre varchar(50) not null,
	CategoriaId number not null,
	constraint ProCat foreign key (CategoriaId) references CategoriasInsumos(Id),
	Unidad number not null,
	Marca varchar(50) not null,
	Proveedor varchar(50) not null,
	Precio float not null
);
ALTER TABLE Insumos ADD UnidadId NUMBER NOT null;
ALTER TABLE Insumos ADD CONSTRAINT InsUni FOREIGN KEY (UnidadId) REFERENCES Unidades;

create table ComidaInsumos(
	ComidaId number not null,
	constraint ComInsCom foreign key (ComidaId) references Comidas(Id),
	InsumoId number not null,
	constraint ComInsIns foreign key (InsumoId) references Insumos(Id),
	Cantidad float not null
);

create table Inventarios(
	Id number generated always as identity primary key,
	InsumoId not null,
	constraint InvIns foreign key (InsumoId) references Insumos(Id),
	SedeId number not null,
	constraint InvSed foreign key (SedeId) references Sedes(Id),
	FechaCreacion date default sysdate not null,
	MovimientoCantidad float not null
);

create table Clientes(
	Id number generated always as identity primary key,
	PersonaId number not null,
	constraint CliPer foreign key (PersonaId) references Personas(Id),
	Correo varchar(100) not null,
	Telefono varchar(14)not null
);


create table Facturas(
	Id number generated always as identity primary key,
	ClienteId number not null,
	constraint FacCli foreign key (ClienteId) REFERENCES Clientes(Id),
	Total float not null,
	FechaCreacion date default sysdate not null 
);

ALTER TABLE LUIS.FACTURAS ADD SEDEID NUMBER NULL;
ALTER TABLE LUIS.FACTURAS ADD CONSTRAINT FK_SEDES FOREIGN KEY (SEDEID) REFERENCES LUIS.SEDES(ID);
ALTER TABLE LUIS.FACTURAS MODIFY SEDEID NUMBER;



-- Compañero, debe ejecutar este alter table --
ALTER TABLE Facturas ADD  constraint FacCli foreign key (ClienteId) REFERENCES Clientes(Id);

create table DetalleFacturas(
	Id number generated always as identity primary key,
	FacturaId number not null,
	constraint DetFac foreign key (FacturaId) references Facturas(Id),
	ComidaId number not null,
	constraint DetCom foreign key (ComidaId) references Comidas(Id),
	SedeId number not null,
	constraint FacSed foreign key (SedeId) references Sedes(Id),
	Cantidad number not null,
	Precio float not NULL,
	Subtotal float NOT NULL 
);

-- Compañero, debe ejecutar este alter table --
ALTER TABLE DetalleFacturas ADD Subtotal float NOT NULL;

SELECT * FROM DetalleFacturas;