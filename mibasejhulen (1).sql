-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 25-04-2022 a las 06:06:30
-- Versión del servidor: 8.0.27
-- Versión de PHP: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mibasejhulen`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `acceso`
--

CREATE TABLE `acceso` (
  `ci` int NOT NULL,
  `usuario` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `password` varchar(20) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `acceso`
--

INSERT INTO `acceso` (`ci`, `usuario`, `password`) VALUES
(123, 'pepe', '12345'),
(234, 'alejandro', '12345'),
(456, 'alberto', '12345'),
(567, 'dayana', '12345'),
(777, 'eldirec', 'soyadmin'),
(789, 'carlos', '54321');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `inscripcion`
--

CREATE TABLE `inscripcion` (
  `ciestudiante` int NOT NULL,
  `sigla` varchar(8) COLLATE utf8mb4_general_ci NOT NULL,
  `nota1` int NOT NULL,
  `nota2` int NOT NULL,
  `nota3` int NOT NULL,
  `notafinal` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `inscripcion`
--

INSERT INTO `inscripcion` (`ciestudiante`, `sigla`, `nota1`, `nota2`, `nota3`, `notafinal`) VALUES
(789, 'INF121', 40, 40, 45, 42),
(567, 'INF112', 90, 82, 93, 88),
(234, 'MAT124', 60, 60, 60, 60),
(567, 'INF112', 70, 80, 60, 70),
(456, 'LAB111', 50, 60, 45, 55),
(123, 'INF121', 70, 75, 80, 75),
(456, 'INF121', 60, 64, 70, 65),
(789, 'MAT124', 55, 75, 68, 66),
(789, 'LAB111', 60, 50, 70, 60),
(234, 'LAB111', 100, 80, 90, 90),
(123, 'INF112', 100, 80, 75, 85),
(123, 'MAT115', 50, 50, 50, 50);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `persona`
--

CREATE TABLE `persona` (
  `ci` int NOT NULL,
  `nombre_completo` varchar(20) COLLATE utf8mb4_general_ci NOT NULL,
  `fecha_nacimiento` date NOT NULL,
  `departamento` varchar(2) COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `persona`
--

INSERT INTO `persona` (`ci`, `nombre_completo`, `fecha_nacimiento`, `departamento`) VALUES
(123, 'Pepe Grillero', '1998-01-04', '02'),
(234, 'Alejandro Cardenas', '1994-06-03', '02'),
(456, 'Alberto Quezada', '1999-03-30', '03'),
(567, 'Dayana Colque', '1991-02-19', '07'),
(777, 'Gabriel Molina', '1976-03-04', '02'),
(789, 'Carlos Mantilla', '1997-09-23', '07');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `acceso`
--
ALTER TABLE `acceso`
  ADD PRIMARY KEY (`ci`);

--
-- Indices de la tabla `persona`
--
ALTER TABLE `persona`
  ADD PRIMARY KEY (`ci`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
