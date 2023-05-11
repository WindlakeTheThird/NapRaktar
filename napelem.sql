-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Máj 11. 01:09
-- Kiszolgáló verziója: 10.4.17-MariaDB
-- PHP verzió: 8.0.2

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `napelem`
--
CREATE DATABASE IF NOT EXISTS `napelem` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `napelem`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `alkatresz`
--

DROP TABLE IF EXISTS `alkatresz`;
CREATE TABLE `alkatresz` (
  `tipus_id` int(11) NOT NULL,
  `tipus` varchar(50) DEFAULT NULL,
  `darab_rekesz` int(11) DEFAULT NULL,
  `ar` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `alkatresz`
--

INSERT INTO `alkatresz` (`tipus_id`, `tipus`, `darab_rekesz`, `ar`) VALUES
(1, '100-as szög', 75, 70),
(2, 'csavar', 30, 25);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `allapot`
--

DROP TABLE IF EXISTS `allapot`;
CREATE TABLE `allapot` (
  `allapot_id` int(11) NOT NULL,
  `allapot_nev` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `allapot`
--

INSERT INTO `allapot` (`allapot_id`, `allapot_nev`) VALUES
(0, 'New'),
(1, 'Draft'),
(2, 'Wait'),
(3, 'Scheduled'),
(4, 'InProgress'),
(5, 'Completed'),
(6, 'Failed');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `beosztas`
--

DROP TABLE IF EXISTS `beosztas`;
CREATE TABLE `beosztas` (
  `jogosultsag_id` int(11) NOT NULL,
  `jogosultsag_nev` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `beosztas`
--

INSERT INTO `beosztas` (`jogosultsag_id`, `jogosultsag_nev`) VALUES
(1, 'Raktárvezető'),
(2, 'Raktáros'),
(3, 'Szakember');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `dolgozok`
--

DROP TABLE IF EXISTS `dolgozok`;
CREATE TABLE `dolgozok` (
  `id` int(11) NOT NULL,
  `nev` varchar(100) DEFAULT NULL,
  `beosztas` int(11) DEFAULT NULL,
  `felhasznalonev` varchar(30) DEFAULT NULL,
  `jelszo` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `dolgozok`
--

INSERT INTO `dolgozok` (`id`, `nev`, `beosztas`, `felhasznalonev`, `jelszo`) VALUES
(1, 'Teszt Teréz', 1, 'tesztteri', 'gE7yon3pvuU='),
(2, 'Teszt Tímea', 3, 'teszttimi', 'gE7yon3pvuU='),
(3, 'Teszt Tünde', 2, 'teszttundi', 'gE7yon3pvuU=');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `log`
--

DROP TABLE IF EXISTS `log`;
CREATE TABLE `log` (
  `projekt` int(11) DEFAULT NULL,
  `eredeti` int(11) DEFAULT NULL,
  `uj` int(11) DEFAULT NULL,
  `mikor` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `projekt`
--

DROP TABLE IF EXISTS `projekt`;
CREATE TABLE `projekt` (
  `id` int(11) NOT NULL,
  `projekt_nev` varchar(50) DEFAULT NULL,
  `szakember_id` int(11) DEFAULT NULL,
  `allapot` int(11) DEFAULT NULL,
  `koltseg` int(11) DEFAULT NULL,
  `kivitelezesi_ido` varchar(20) DEFAULT NULL,
  `hely` varchar(255) DEFAULT NULL,
  `leiras` varchar(255) DEFAULT NULL,
  `elerhetoseg` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `projekt`
--

INSERT INTO `projekt` (`id`, `projekt_nev`, `szakember_id`, `allapot`, `koltseg`, `kivitelezesi_ido`, `hely`, `leiras`, `elerhetoseg`) VALUES
(1, 'proba', 2, 1, 0, '1', 'nincs', 'proba', 'nincs'),
(2, 'proba2', 2, 1, 30000, '4', 'nincs2', 'proba2', 'nincs2'),
(3, 'proba3', 2, 1, 500000, '10', 'nincs', 'proba3', 'nincs'),
(7, 'proba4_py', 2, 1, 0, '0001:01:01', 'py', 'proba4_py', 'py'),
(12, 'asdasdgfasg', 2, 1, 0, '0001:01:01', 'sgasfgasdfg', 'sdgasfdgasdfg', 'sdgasdgfadsfg');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `projekt_rekesz`
--

DROP TABLE IF EXISTS `projekt_rekesz`;
CREATE TABLE `projekt_rekesz` (
  `project_id` int(11) DEFAULT NULL,
  `sor` int(11) DEFAULT NULL,
  `oszlop` int(11) DEFAULT NULL,
  `szint` int(11) DEFAULT NULL,
  `mennyi` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `projekt_rekesz`
--

INSERT INTO `projekt_rekesz` (`project_id`, `sor`, `oszlop`, `szint`, `mennyi`) VALUES
(1, 1, 1, 2, 3),
(12, 1, 1, 2, 2),
(2, 1, 1, 2, 1),
(2, 1, 1, 2, 30),
(2, 1, 1, 2, 30),
(7, 1, 1, 2, 25),
(1, 1, 1, 2, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rekesz`
--

DROP TABLE IF EXISTS `rekesz`;
CREATE TABLE `rekesz` (
  `sor` int(11) NOT NULL,
  `oszlop` int(11) NOT NULL,
  `szint` int(11) NOT NULL,
  `alkatresz_id` int(11) DEFAULT NULL,
  `mennyi` int(11) DEFAULT NULL,
  `project_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `rekesz`
--

INSERT INTO `rekesz` (`sor`, `oszlop`, `szint`, `alkatresz_id`, `mennyi`, `project_id`) VALUES
(1, 1, 1, 0, 0, 0),
(1, 1, 2, 2, 1, 0),
(1, 1, 3, 0, 0, 0),
(1, 1, 4, NULL, NULL, 0),
(1, 1, 5, NULL, NULL, 0),
(1, 1, 6, NULL, NULL, 0),
(1, 2, 1, NULL, NULL, 0),
(1, 2, 2, NULL, NULL, 0),
(1, 2, 3, NULL, NULL, 0),
(1, 2, 4, NULL, NULL, 0),
(1, 2, 5, NULL, NULL, 0),
(1, 2, 6, NULL, NULL, 0),
(1, 3, 1, NULL, NULL, 0),
(1, 3, 2, NULL, NULL, 0),
(1, 3, 3, NULL, NULL, 0),
(1, 3, 4, NULL, NULL, 0),
(1, 3, 5, NULL, NULL, 0),
(1, 3, 6, NULL, NULL, 0),
(1, 4, 1, NULL, NULL, 0),
(1, 4, 2, NULL, NULL, 0),
(1, 4, 3, NULL, NULL, 0),
(1, 4, 4, NULL, NULL, 0),
(1, 4, 5, NULL, NULL, 0),
(1, 4, 6, NULL, NULL, 0),
(2, 1, 1, NULL, NULL, 0),
(2, 1, 2, NULL, NULL, 0),
(2, 1, 3, NULL, NULL, 0),
(2, 1, 4, NULL, NULL, 0),
(2, 1, 5, NULL, NULL, 0),
(2, 1, 6, NULL, NULL, 0),
(2, 2, 1, NULL, NULL, 0),
(2, 2, 2, NULL, NULL, 0),
(2, 2, 3, NULL, NULL, 0),
(2, 2, 4, NULL, NULL, 0),
(2, 2, 5, NULL, NULL, 0),
(2, 2, 6, NULL, NULL, 0),
(2, 3, 1, NULL, NULL, 0),
(2, 3, 2, NULL, NULL, 0),
(2, 3, 3, NULL, NULL, 0),
(2, 3, 4, NULL, NULL, 0),
(2, 3, 5, NULL, NULL, 0),
(2, 3, 6, NULL, NULL, 0),
(2, 4, 1, NULL, NULL, 0),
(2, 4, 2, NULL, NULL, 0),
(2, 4, 3, NULL, NULL, 0),
(2, 4, 4, NULL, NULL, 0),
(2, 4, 5, NULL, NULL, 0),
(2, 4, 6, NULL, NULL, 0),
(3, 1, 1, NULL, NULL, 0),
(3, 1, 2, NULL, NULL, 0),
(3, 1, 3, NULL, NULL, 0),
(3, 1, 4, NULL, NULL, 0),
(3, 1, 5, NULL, NULL, 0),
(3, 1, 6, NULL, NULL, 0),
(3, 2, 1, NULL, NULL, 0),
(3, 2, 2, NULL, NULL, 0),
(3, 2, 3, NULL, NULL, 0),
(3, 2, 4, NULL, NULL, 0),
(3, 2, 5, NULL, NULL, 0),
(3, 2, 6, NULL, NULL, 0),
(3, 3, 1, NULL, NULL, 0),
(3, 3, 2, NULL, NULL, 0),
(3, 3, 3, NULL, NULL, 0),
(3, 3, 4, NULL, NULL, 0),
(3, 3, 5, NULL, NULL, 0),
(3, 3, 6, NULL, NULL, 0),
(3, 4, 1, NULL, NULL, 0),
(3, 4, 2, NULL, NULL, 0),
(3, 4, 3, NULL, NULL, 0),
(3, 4, 4, NULL, NULL, 0),
(3, 4, 5, NULL, NULL, 0),
(3, 4, 6, NULL, NULL, 0),
(4, 1, 1, NULL, NULL, 0),
(4, 1, 2, NULL, NULL, 0),
(4, 1, 3, NULL, NULL, 0),
(4, 1, 4, NULL, NULL, 0),
(4, 1, 5, NULL, NULL, 0),
(4, 1, 6, NULL, NULL, 0),
(4, 2, 1, NULL, NULL, 0),
(4, 2, 2, NULL, NULL, 0),
(4, 2, 3, NULL, NULL, 0),
(4, 2, 4, NULL, NULL, 0),
(4, 2, 5, NULL, NULL, 0),
(4, 2, 6, NULL, NULL, 0),
(4, 3, 1, NULL, NULL, 0),
(4, 3, 2, NULL, NULL, 0),
(4, 3, 3, NULL, NULL, 0),
(4, 3, 4, NULL, NULL, 0),
(4, 3, 5, NULL, NULL, 0),
(4, 3, 6, NULL, NULL, 0),
(4, 4, 1, NULL, NULL, 0),
(4, 4, 2, NULL, NULL, 0),
(4, 4, 3, NULL, NULL, 0),
(4, 4, 4, NULL, NULL, 0),
(4, 4, 5, NULL, NULL, 0),
(4, 4, 6, NULL, NULL, 0),
(5, 1, 1, NULL, NULL, 0),
(5, 1, 2, NULL, NULL, 0),
(5, 1, 3, NULL, NULL, 0),
(5, 1, 4, NULL, NULL, 0),
(5, 1, 5, NULL, NULL, 0),
(5, 1, 6, NULL, NULL, 0),
(5, 2, 1, NULL, NULL, 0),
(5, 2, 2, NULL, NULL, 0),
(5, 2, 3, NULL, NULL, 0),
(5, 2, 4, NULL, NULL, 0),
(5, 2, 5, NULL, NULL, 0),
(5, 2, 6, NULL, NULL, 0),
(5, 3, 1, NULL, NULL, 0),
(5, 3, 2, NULL, NULL, 0),
(5, 3, 3, NULL, NULL, 0),
(5, 3, 4, NULL, NULL, 0),
(5, 3, 5, NULL, NULL, 0),
(5, 3, 6, NULL, NULL, 0),
(5, 4, 1, NULL, NULL, 0),
(5, 4, 2, NULL, NULL, 0),
(5, 4, 3, NULL, NULL, 0),
(5, 4, 4, NULL, NULL, 0),
(5, 4, 5, NULL, NULL, 0),
(5, 4, 6, NULL, NULL, 0),
(6, 1, 1, NULL, NULL, 0),
(6, 1, 2, NULL, NULL, 0),
(6, 1, 3, NULL, NULL, 0),
(6, 1, 4, NULL, NULL, 0),
(6, 1, 5, NULL, NULL, 0),
(6, 1, 6, NULL, NULL, 0),
(6, 2, 1, NULL, NULL, 0),
(6, 2, 2, NULL, NULL, 0),
(6, 2, 3, NULL, NULL, 0),
(6, 2, 4, NULL, NULL, 0),
(6, 2, 5, NULL, NULL, 0),
(6, 2, 6, NULL, NULL, 0),
(6, 3, 1, NULL, NULL, 0),
(6, 3, 2, NULL, NULL, 0),
(6, 3, 3, NULL, NULL, 0),
(6, 3, 4, NULL, NULL, 0),
(6, 3, 5, NULL, NULL, 0),
(6, 3, 6, NULL, NULL, 0),
(6, 4, 1, NULL, NULL, 0),
(6, 4, 2, NULL, NULL, 0),
(6, 4, 3, NULL, NULL, 0),
(6, 4, 4, NULL, NULL, 0),
(6, 4, 5, NULL, NULL, 0),
(6, 4, 6, NULL, NULL, 0),
(7, 1, 1, NULL, NULL, 0),
(7, 1, 2, NULL, NULL, 0),
(7, 1, 3, NULL, NULL, 0),
(7, 1, 4, NULL, NULL, 0),
(7, 1, 5, NULL, NULL, 0),
(7, 1, 6, NULL, NULL, 0),
(7, 2, 1, NULL, NULL, 0),
(7, 2, 2, NULL, NULL, 0),
(7, 2, 3, NULL, NULL, 0),
(7, 2, 4, NULL, NULL, 0),
(7, 2, 5, NULL, NULL, 0),
(7, 2, 6, NULL, NULL, 0),
(7, 3, 1, NULL, NULL, 0),
(7, 3, 2, NULL, NULL, 0),
(7, 3, 3, NULL, NULL, 0),
(7, 3, 4, NULL, NULL, 0),
(7, 3, 5, NULL, NULL, 0),
(7, 3, 6, NULL, NULL, 0),
(7, 4, 1, NULL, NULL, 0),
(7, 4, 2, NULL, NULL, 0),
(7, 4, 3, NULL, NULL, 0),
(7, 4, 4, NULL, NULL, 0),
(7, 4, 5, NULL, NULL, 0),
(7, 4, 6, NULL, NULL, 0),
(8, 1, 1, NULL, NULL, 0),
(8, 1, 2, NULL, NULL, 0),
(8, 1, 3, NULL, NULL, 0),
(8, 1, 4, NULL, NULL, 0),
(8, 1, 5, NULL, NULL, 0),
(8, 1, 6, NULL, NULL, 0),
(8, 2, 1, NULL, NULL, 0),
(8, 2, 2, NULL, NULL, 0),
(8, 2, 3, NULL, NULL, 0),
(8, 2, 4, NULL, NULL, 0),
(8, 2, 5, NULL, NULL, 0),
(8, 2, 6, NULL, NULL, 0),
(8, 3, 1, NULL, NULL, 0),
(8, 3, 2, NULL, NULL, 0),
(8, 3, 3, NULL, NULL, 0),
(8, 3, 4, NULL, NULL, 0),
(8, 3, 5, NULL, NULL, 0),
(8, 3, 6, NULL, NULL, 0),
(8, 4, 1, NULL, NULL, 0),
(8, 4, 2, NULL, NULL, 0),
(8, 4, 3, NULL, NULL, 0),
(8, 4, 4, NULL, NULL, 0),
(8, 4, 5, NULL, NULL, 0),
(8, 4, 6, NULL, NULL, 0),
(9, 1, 1, NULL, NULL, 0),
(9, 1, 2, NULL, NULL, 0),
(9, 1, 3, NULL, NULL, 0),
(9, 1, 4, NULL, NULL, 0),
(9, 1, 5, NULL, NULL, 0),
(9, 1, 6, NULL, NULL, 0),
(9, 2, 1, NULL, NULL, 0),
(9, 2, 2, NULL, NULL, 0),
(9, 2, 3, NULL, NULL, 0),
(9, 2, 4, NULL, NULL, 0),
(9, 2, 5, NULL, NULL, 0),
(9, 2, 6, NULL, NULL, 0),
(9, 3, 1, NULL, NULL, 0),
(9, 3, 2, NULL, NULL, 0),
(9, 3, 3, NULL, NULL, 0),
(9, 3, 4, NULL, NULL, 0),
(9, 3, 5, NULL, NULL, 0),
(9, 3, 6, NULL, NULL, 0),
(9, 4, 1, NULL, NULL, 0),
(9, 4, 2, NULL, NULL, 0),
(9, 4, 3, NULL, NULL, 0),
(9, 4, 4, NULL, NULL, 0),
(9, 4, 5, NULL, NULL, 0),
(9, 4, 6, NULL, NULL, 0),
(10, 1, 1, NULL, NULL, 0),
(10, 1, 2, NULL, NULL, 0),
(10, 1, 3, NULL, NULL, 0),
(10, 1, 4, NULL, NULL, 0),
(10, 1, 5, NULL, NULL, 0),
(10, 1, 6, NULL, NULL, 0),
(10, 2, 1, NULL, NULL, 0),
(10, 2, 2, NULL, NULL, 0),
(10, 2, 3, NULL, NULL, 0),
(10, 2, 4, NULL, NULL, 0),
(10, 2, 5, NULL, NULL, 0),
(10, 2, 6, NULL, NULL, 0),
(10, 3, 1, NULL, NULL, 0),
(10, 3, 2, NULL, NULL, 0),
(10, 3, 3, NULL, NULL, 0),
(10, 3, 4, NULL, NULL, 0),
(10, 3, 5, NULL, NULL, 0),
(10, 3, 6, NULL, NULL, 0),
(10, 4, 1, NULL, NULL, 0),
(10, 4, 2, NULL, NULL, 0),
(10, 4, 3, NULL, NULL, 0),
(10, 4, 4, NULL, NULL, 0),
(10, 4, 5, NULL, NULL, 0),
(10, 4, 6, NULL, NULL, 0);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles`
--

DROP TABLE IF EXISTS `rendeles`;
CREATE TABLE `rendeles` (
  `rendeles_id` int(11) NOT NULL,
  `projekt_id` int(11) DEFAULT NULL,
  `alkatresz` varchar(50) DEFAULT NULL,
  `mennyiseg` int(11) DEFAULT NULL,
  `rendeles_allapot` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `rendeles`
--

INSERT INTO `rendeles` (`rendeles_id`, `projekt_id`, `alkatresz`, `mennyiseg`, `rendeles_allapot`) VALUES
(1, 2, '1', 10, 0),
(2, 2, '1', 50, 1),
(3, 3, '1', 30, 1),
(22, 12, '1', 23, 0),
(23, 12, '1', 0, 1),
(24, 12, '2', 10, 1),
(25, 3, '1', 5, 0),
(26, 3, '1', 25, 1),
(27, 1, '2', 2, 1),
(28, 12, '2', 1, 1),
(29, 2, '2', 1, 1),
(30, 2, '2', 29, 0),
(31, 2, '2', 1, 1),
(32, 2, '2', 29, 0),
(33, 2, '2', 1, 1),
(34, 7, '2', 24, 0),
(35, 7, '2', 1, 1),
(36, 1, '2', 24, 0),
(37, 1, '2', 1, 1);

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles_allapot`
--

DROP TABLE IF EXISTS `rendeles_allapot`;
CREATE TABLE `rendeles_allapot` (
  `allapot_id` int(11) NOT NULL,
  `allapot_nev` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `rendeles_allapot`
--

INSERT INTO `rendeles_allapot` (`allapot_id`, `allapot_nev`) VALUES
(0, 'rendelve'),
(1, 'lefoglalva'),
(2, 'kész');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `alkatresz`
--
ALTER TABLE `alkatresz`
  ADD PRIMARY KEY (`tipus_id`);

--
-- A tábla indexei `allapot`
--
ALTER TABLE `allapot`
  ADD PRIMARY KEY (`allapot_id`);

--
-- A tábla indexei `beosztas`
--
ALTER TABLE `beosztas`
  ADD PRIMARY KEY (`jogosultsag_id`);

--
-- A tábla indexei `dolgozok`
--
ALTER TABLE `dolgozok`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `projekt`
--
ALTER TABLE `projekt`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `rekesz`
--
ALTER TABLE `rekesz`
  ADD PRIMARY KEY (`sor`,`oszlop`,`szint`);

--
-- A tábla indexei `rendeles`
--
ALTER TABLE `rendeles`
  ADD PRIMARY KEY (`rendeles_id`);

--
-- A tábla indexei `rendeles_allapot`
--
ALTER TABLE `rendeles_allapot`
  ADD PRIMARY KEY (`allapot_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `alkatresz`
--
ALTER TABLE `alkatresz`
  MODIFY `tipus_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT a táblához `beosztas`
--
ALTER TABLE `beosztas`
  MODIFY `jogosultsag_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `dolgozok`
--
ALTER TABLE `dolgozok`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT a táblához `projekt`
--
ALTER TABLE `projekt`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT a táblához `rendeles`
--
ALTER TABLE `rendeles`
  MODIFY `rendeles_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=38;

--
-- AUTO_INCREMENT a táblához `rendeles_allapot`
--
ALTER TABLE `rendeles_allapot`
  MODIFY `allapot_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
