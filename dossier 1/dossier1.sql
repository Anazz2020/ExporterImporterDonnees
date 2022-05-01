
CREATE DATABASE db_assure
ON PRIMARY
(
NAME=db_assure_data,
FILENAME='D:\NomPrenom_V1\db\db_assure_data.mdf',
SIZE=3 MB,
MAXSIZE=5 MB,
FILEGROWTH=2 MB

)
LOG ON
(
NAME=db_assure_log,
FILENAME='D:\NomPrenom_V1\db\db_assure_log.ldf',
SIZE=3 MB,
MAXSIZE=5 MB,
FILEGROWTH=2 MB

)

-- création des tables :

SET XACT_ABORT ON
BEGIN TRAN

CREATE TABLE magasin
(
numero_magasin int primary key,
libelle_magasin varchar(50) NOT NULL,
Date_creation datetime NOT NULL,
Tel varchar(20) NOT NULL,
Adresse varchar(100),
Ville varchar(20)
)


CREATE TABLE MotifsRejet
(
code_motif int primary key,
libelle_motif varchar(100) Not null
)

CREATE TABLE Banque
(
code_banque int primary key,
Adresse_siege varchar(100) NOT NULL,
Tel varchar(20),
Ville varchar(50)
)




CREATE TABLE Client
(
cin varchar(20) primary key,
Genre varchar(10) NOT NULL,
Nom varchar(100) NOT NULL,
Prenom varchar(100) NOT NULL,
Tel VARCHAR(20),
Adresse VARCHAR(100),
Ville VARCHAR(20),
numero_magasin int foreign key references magasin(numero_magasin)
)



CREATE TABLE Cheque
(
numero_cheque int primary key,
date_emission datetime not null,
montant money not null ,
code_motif int foreign key references MotifsRejet(code_motif),
cin varchar(20) foreign key references Client(cin),
code_banque int foreign key references Banque(code_banque) ,
numero_magasin int foreign key references magasin(numero_magasin)
)


COMMIT TRAN


--- remplissage des tables :


INSERT INTO magasin values(1,'magasin 1','01/01/2001','1111','adresse 1','ville 1')
INSERT INTO magasin values(2,'magasin 2','02/02/2002','2222','adresse 2','ville 2')



INSERT INTO MotifsRejet values (1,'motif 1')
INSERT INTO MotifsRejet values (2,'motif 3')


-- remplir table par procédure stockée

CREATE PROC P_Banque
(
@nbr_ligne int
)
AS

DECLARE @CPT INT
SET @CPT=1
DECLARE @TEL VARCHAR(20)
WHILE @CPT<=@nbr_ligne
begin
SET @TEL=convert(varchar(50),(select FLOOR(51 * rand()+50)))
INSERT INTO Banque values(@CPT,'siege ' + convert(varchar(50),@CPT),@TEL,'ville ' + convert(varchar(50),@CPT))
SET @CPT=@CPT+1
end

-- executer proc action :

exec P_Banque 5




INSERT INTO Client values('cin1','Homme','Nom 1','Prenom 1','Tel 1', 'Adresse 1' , 'Ville 1',1)
INSERT INTO Client values('cin2','Homme','Nom 2','Prenom 2','Tel 2', 'Adresse 2' , 'Ville 2',2)
INSERT INTO Client values('cin3','Homme','Nom 3','Prenom 3','Tel 3', 'Adresse 3' , 'Ville 3',2)




INSERT INTO Cheque values (1,'01/01/2001',111,1,'cin1',1,1)
INSERT INTO Cheque values (2,'02/02/2002',222,2,'cin2',2,2)
