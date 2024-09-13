﻿CREATE TABLE CATEGORIA(
IdCategoria int primary key identity(1,1),
Descripcion varchar(50)
)

CREATE TABLE PRODUCTO(
IdProducto int primary key identity(1,1),
CodigoBarra varchar(20),
Descripcion varchar(50),
Marca varchar(50),
IdCategoria int,
Precio decimal(10,2)
CONSTRAINT FK_IDCATEGORIA FOREIGN KEY (IdCategoria) REFERENCES CATEGORIA(IdCategoria)
)

insert into CATEGORIA(Descripcion) values
('Tecnologia'),
('ElectroHogar'),
('Accesorios')

insert into PRODUCTO(CodigoBarra,Descripcion,Marca,IdCategoria,Precio) values
('50910010','Monitor Aoc  - Curvo  Gaming','AOC',1,1200),
('50910012','Lavadora 21 KG WLA-21','WINIA',2,1749)


