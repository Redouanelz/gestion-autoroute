Create Database GestionPoste

Use GestionPoste

Create Table Administration (
IDUser Int Primary Key IDENTITY(0,1),
Nom Varchar(50),
Prenom Varchar(50),
Pseudo Varchar(50),
MotDePasse Varchar(50),
Civilité Varchar(50),
Email Varchar(50),
)

Create Table Region (
IDRegion Int Primary Key IDENTITY(0,1),
NomRegion Varchar(50),
)

Create Table Ville (
IDVille Int Primary Key IDENTITY(0,1),
IDRegion Int Foreign Key References Region(IDRegion),
NomVille Varchar(50),
)

Create Table Infos (
IDInfos Int Primary Key IDENTITY(0,1),
IDVille Int Foreign Key References Ville(IDVille),
Res Varchar(50),
Poste Varchar(50),
Origine Varchar(50),
Extremite Varchar(50),
PKD Float,
PKF Float,
Longeur Float ,
)

INSERT INTO Administration VALUES('NOM','PRENOM','admin','admin','M','x@x.x')
INSERT INTO Infos VALUES (,'','','','',,,)
INSERT INTO Region VALUES ('REGION 00')
INSERT INTO Ville VALUES (0,'VILLE 00')

select * from Administration
select * from Infos
select * from Region
select * from Ville

