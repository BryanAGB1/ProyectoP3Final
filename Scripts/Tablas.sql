create database ProyectoProgra3

Use ProyectoProgra3
go

--Tabla Estudiante
Create table Estudiante(
Carnet int identity(1,1) not null primary key,
Nombre varchar(20),
Apellido1 varchar(20),
Apellido2 varchar(20),
Cedula int
);

--Tabla TipoTelefono
CREATE TABLE TipoTelefono (
IdTipoTelefono Int identity(1,1) not null PRIMARY KEY,
DescripcionTipoTel VarChar(50)
);

--Tabla Telefono
Create table Telefono(
IdTelefono int identity(1,1) not null primary key,
IdTipoTelefono Int Foreign Key References TipoTelefono(IdTipoTelefono),
Carnet int foreign key references Estudiante(Carnet),
Numero int
);

--Tabla TipoEmail
CREATE TABLE TipoEmail (
IdTipoEmail Int identity(1,1) not null PRIMARY KEY,
DescripcionTipoEmail VarChar(50)
);

--Tabla Emails
CREATE TABLE Emails (
IdEmail Int Identity(1,1) not null PRIMARY KEY,
IdTipoEmail Int Foreign Key References TipoEmail(IdTipoEmail),
Carnet int foreign key references Estudiante(Carnet),
Email Varchar(60)
);

--Tabla Provincias
CREATE TABLE Provincias (
IdProvincia Int Identity(1,1) not null PRIMARY KEY,
DescripcionProvincia VarChar(50)
);

--Tabla Cantones
CREATE TABLE Cantones (
IdProvincia Int Foreign Key References Provincias(IdProvincia),
IdCanton Int Identity(1,1) Not null PRIMARY KEY(IdProvincia, IdCanton),
DescripcionCanton Varchar(50)
);

--Tabla Distritos
CREATE TABLE Distritos (
IdProvincia int, 
IdCanton Int, 
Foreign key(IdProvincia, IdCanton) References Cantones(IdProvincia, IdCanton),
IdDistrito Int Identity(1,1) Not null, 
PRIMARY KEY(IdProvincia, IdCanton, IdDistrito),
DescripcionDistrito VarChar(50)
);

--Tabla Direcciones
CREATE TABLE Direcciones (
IdProvincia int, 
IdCanton Int, 
IdDistrito Int, 
Foreign Key(IdProvincia, IdCanton, IdDistrito) References Distritos(IdProvincia, IdCanton, IdDistrito),
IdDireccion Int Identity(1,1) not Null,
PRIMARY KEY(IdProvincia, IdCanton, IdDistrito, IdDireccion),
Carnet int foreign key references Estudiante(Carnet),
Descripcion VarChar(255)
);

--Tabla TipoCarrera
Create Table TipoCarrera(
Codigo_Carrera Varchar(15) primary key not null,
NombreCarrera Varchar(60)
);

--Tabla Carrera
Create table Carrera(
IdCarreta Int Identity(1,1) not null primary key,
Codigo_Carrera Varchar(15) foreign key references TipoCarrera(Codigo_Carrera),
Carnet int foreign key references Estudiante(Carnet)
);

--Tabla PlanEstudio
Create table PlanEstudio(
Codigo_Plan Int Identity(1,1) primary key not null,
Codigo_Carrera Varchar(15) foreign key references TipoCarrera(Codigo_Carrera)
);

--Tabla Curso 
Create table Curso(
Codigo_Curso Varchar(15) primary key not null,
Codigo_Plan int foreign key references PlanEstudio(Codigo_Plan),
NombreCurso Varchar(255),
Cuatrimestre int,
Creditos int,
);

--Tabla InformacionCurso
Create table InformacionCurso(
Codigo_Info Int Identity(1,1) primary key not null,
Codigo_Curso Varchar(15) foreign key references Curso(Codigo_Curso),
Carnet int foreign key references Estudiante(Carnet),
EstadoCurso Varchar(15),  -- aprovado, reprovado, aplazado, No cursado
Nota int
);

--Tabla Requisitos
Create table Requisitos(
IdRequisitos Int Identity(1,1) primary key not null,
Requisitos Varchar(15),
Codigo_Info int foreign key references InformacionCurso(Codigo_Info)
);

--Tabla Horario
Create table Horario(
IdHorario Int Identity(1,1) primary key not null,
Dia Varchar(10),
Hora_ini time, --hh,mm,ss
Hora_fin time,
Codigo_Curso Varchar(15) foreign key references Curso(Codigo_Curso)
);

--Tabla Grupo
Create table Grupo(
Codigo_grupo Int Identity(1,1) primary key not null,
IdHorario int foreign key references Horario(IdHorario),
Codigo_Curso Varchar(15) foreign key references Curso(Codigo_Curso),
CantidadEstudiantes int
);

--Tabla Expediente
Create table Expediente(
IdExpediente Int Identity(1,1) Primary key not null,
Carnet int foreign key references Estudiante(Carnet),
);

--Tabla InfoExpediente
Create table InfoExpediente(
IdInfoEx int identity(1,1) primary key not null,
IdExpediente int foreign key references Expediente(IdExpediente),
Codigo_Info int foreign key references InformacionCurso(Codigo_Info)
);

--Tabla Usuario
Create table Usuario(
Carnet Int Primary Key foreign key references Estudiante(Carnet),
Contraseña VarChar(20)
);