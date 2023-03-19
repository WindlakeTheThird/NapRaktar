CREATE DATABASE Napelem;
use Napelem;

CREATE TABLE Projekt(
	id  int PRIMARY KEY AUTO_INCREMENT,
	projekt_nev varchar(50),
    szakember_id int,
    allapot int,
    koltseg int ,
    kivitelezesi_ido date
	);


CREATE TABLE Dolgozok(
    id int PRIMARY KEY AUTO_INCREMENT,
    nev varchar(100),
    beosztas int,
    felhasznalonev varchar(30),
    jelszo varchar(50)
  );

CREATE TABLE Beosztas(
    jogosultsag_id int PRIMARY KEY AUTO_INCREMENT,
    jogosultsag_nev varchar(50)
    );

CREATE TABLE Rendeles(
	rendeles_id int PRIMARY KEY AUTO_INCREMENT,
    projekt_id int,
    alkatresz varchar(50),
    mennyiseg int,
    rendeles_allapot int
);

CREATE TABLE allapot(
    allapot_id int PRIMARY KEY AUTO_INCREMENT,
    allapot_nev varchar(50)
);

CREATE TABLE rendeles_allapot(
    allapot_id int PRIMARY KEY AUTO_INCREMENT,
    allapot_nev varchar(50)
);

CREATE TABLE log(
    projekt int,
    eredeti int,
    uj int,
    mikor date
);

CREATE TABLE Alkatresz(
    tipus_id int PRIMARY KEY AUTO_INCREMENT,
    tipus varchar(50),
    darab_rekesz int,
    ar int
    );

CREATE TABLE Rekesz(
    sor int,
    oszlop int,
    szint int,
    alkatresz_id int,
    mennyi int,
    PRIMARY KEY(sor,oszlop,szint)
    );
