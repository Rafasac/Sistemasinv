-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 14-09-2019 a las 18:50:45
-- Versión del servidor: 10.1.40-MariaDB
-- Versión de PHP: 7.3.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistemasvdlp`
--
CREATE DATABASE IF NOT EXISTS `sistemasvdlp` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `sistemasvdlp`;

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `buscarAccesorios`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarAccesorios` ()  SELECT *
FROM activos a
INNER JOIN espaccesorio e
ON a.vpActivo = e.vp$$

DROP PROCEDURE IF EXISTS `buscarAccesorioVP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarAccesorioVP` (IN `codigoVP` VARCHAR(10))  SELECT *
FROM activos a
INNER JOIN espaccesorio e
ON a.vpActivo = e.vp
WHERE a.vpActivo = codigoVP$$

DROP PROCEDURE IF EXISTS `buscarEmpleado`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarEmpleado` (IN `txtEmpleado` VARCHAR(30))  SELECT * FROM empleadoS WHERE MATCH(nombre, apellidoPaterno, apellidoMaterno) AGAINST (txtEmpleado IN BOOLEAN MODE)$$

DROP PROCEDURE IF EXISTS `buscarImpresoras`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarImpresoras` ()  SELECT *
FROM activos a
INNER JOIN espimpresoras e
ON a.vpActivo = e.vp$$

DROP PROCEDURE IF EXISTS `buscarImpresoraVP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarImpresoraVP` (IN `codigoVP` VARCHAR(10))  SELECT *
FROM activos a
INNER JOIN espimpresoras e
ON a.vpActivo = e.vp
WHERE a.vpActivo = codigoVP$$

DROP PROCEDURE IF EXISTS `buscarLaptops`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarLaptops` ()  SELECT *
FROM activos a
INNER JOIN esplaptop e
ON a.vpActivo = e.vp$$

DROP PROCEDURE IF EXISTS `buscarLaptopVP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarLaptopVP` (IN `codigoVP` VARCHAR(10))  SELECT *
FROM activos a
INNER JOIN esplaptop e
ON a.vpActivo = e.vp
WHERE a.vpActivo = codigoVP$$

DROP PROCEDURE IF EXISTS `buscarMoviles`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarMoviles` ()  SELECT *
FROM activos a
INNER JOIN espmovil e
ON a.vpActivo = e.vp$$

DROP PROCEDURE IF EXISTS `buscarMovilVP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarMovilVP` (IN `codigoVP` VARCHAR(10))  SELECT *
FROM activos a
INNER JOIN espmovil e
ON a.vpActivo = e.vp
WHERE a.vpActivo = codigoVP$$

DROP PROCEDURE IF EXISTS `buscarTelefonos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarTelefonos` ()  SELECT *
FROM activos a
INNER JOIN esptelefonos e
ON a.vpActivo = e.vp$$

DROP PROCEDURE IF EXISTS `buscarTelefonoVP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `buscarTelefonoVP` (IN `codigoVP` VARCHAR(10))  SELECT *
FROM activos a
INNER JOIN esptelefonos e
ON a.vpActivo = e.vp
WHERE a.vpActivo = codigoVP$$

DROP PROCEDURE IF EXISTS `cargarAccesorio`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarAccesorio` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, espaccesorio WHERE activos.vpActivo=vp AND espaccesorio.vp=vp$$

DROP PROCEDURE IF EXISTS `cargarConsumible`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarConsumible` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, espconsumible WHERE activos.vpActivo=vp AND espconsumible.vp=vp$$

DROP PROCEDURE IF EXISTS `cargarImpresora`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarImpresora` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, espimpresoras WHERE activos.vpActivo=vp AND espimpresoras.vp=vp$$

DROP PROCEDURE IF EXISTS `cargarLaptop`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarLaptop` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, esplaptop WHERE activos.vpActivo=vp AND esplaptop.vp=vp$$

DROP PROCEDURE IF EXISTS `cargarMovil`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarMovil` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, espmovil WHERE activos.vpActivo=vp AND espmovil.vp=vp$$

DROP PROCEDURE IF EXISTS `cargarPc`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarPc` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, esppc WHERE activos.vpActivo=vp AND esppc.vp=vp$$

DROP PROCEDURE IF EXISTS `cargarTelefono`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `cargarTelefono` (IN `vp` VARCHAR(10))  SELECT tipo, marca, modelo, serie, vpActivo FROM activos, esptelefonos WHERE activos.vpActivo=vp AND esptelefonos.vp=vp$$

DROP PROCEDURE IF EXISTS `consultaEmpleadoCorreos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaEmpleadoCorreos` (IN `numeroEmpleado` INT(7))  SELECT correos.email, correos.pass, empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno FROM correos, empleados WHERE fkEmpleado=empleados.idEmpleado and empleados.idEmpleado=numeroEmpleado$$

DROP PROCEDURE IF EXISTS `consultaEmpleadoCorreosGeneral`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaEmpleadoCorreosGeneral` ()  SELECT correos.email, correos.pass, empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno FROM correos, empleados WHERE fkEmpleado=empleados.idEmpleado$$

DROP PROCEDURE IF EXISTS `ConsultaEmpleados`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ConsultaEmpleados` ()  SELECT empleados.idEmpleado, empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, departamento.nombre, puestos.nombrePuesto from empleados, departamento, puestos WHERE empleados.idEmpleado=departamento.fkEmpleado AND empleados.idEmpleado=puestos.fkEmpleado ORDER BY empleados.idEmpleado DESC$$

DROP PROCEDURE IF EXISTS `consultaGeneralActivos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaGeneralActivos` ()  SELECT * FROM activos$$

DROP PROCEDURE IF EXISTS `consultarActivosEmpleadoAccesorios`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarActivosEmpleadoAccesorios` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, asignaciones.fkvp, espaccesorio.marca, espaccesorio.modelo, espaccesorio.serie FROM asignaciones, empleados, espaccesorio WHERE asignaciones.fkEmpleado=empleados.idEmpleado AND asignaciones.fkvp=espaccesorio.vp$$

DROP PROCEDURE IF EXISTS `consultarActivosEmpleadoImpresoras`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarActivosEmpleadoImpresoras` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, asignaciones.fkvp, espimpresoras.marca,espimpresoras.modelo, espimpresoras.serie FROM asignaciones, empleados, espimpresoras WHERE asignaciones.fkEmpleado=empleados.idEmpleado AND asignaciones.fkvp=espimpresoras.vp$$

DROP PROCEDURE IF EXISTS `consultarActivosEmpleadoLaptops`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarActivosEmpleadoLaptops` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, asignaciones.fkvp, esplaptop.marca,esplaptop.modelo, esplaptop.serie FROM asignaciones, empleados, esplaptop WHERE asignaciones.fkEmpleado=empleados.idEmpleado AND asignaciones.fkvp=esplaptop.vp$$

DROP PROCEDURE IF EXISTS `consultarActivosEmpleadoMovil`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarActivosEmpleadoMovil` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, asignaciones.fkvp, espmovil.marca,espmovil.modelo, espmovil.serie FROM asignaciones, empleados, espmovil WHERE asignaciones.fkEmpleado=empleados.idEmpleado AND asignaciones.fkvp=espmovil.vp$$

DROP PROCEDURE IF EXISTS `consultarActivosEmpleadoPc`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarActivosEmpleadoPc` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, asignaciones.fkvp, esppc.marca,esppc.modelo, esppc.serie FROM asignaciones, empleados, esppc WHERE asignaciones.fkEmpleado=empleados.idEmpleado AND asignaciones.fkvp=esppc.vp$$

DROP PROCEDURE IF EXISTS `consultaStock`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultaStock` ()  SELECT * from activos, estado WHERE activos.vpActivo=estado.vp AND estado.estado='stock'$$

DROP PROCEDURE IF EXISTS `DescripcionImpresoraShort`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DescripcionImpresoraShort` (IN `activo` VARCHAR(11))  SELECT activos.vpActivo, espimpresoras.marca, espimpresoras.modelo, espimpresoras.serie FROM espimpresoras, activos WHERE espimpresoras.vp=activos.vpActivo AND activos.vpActivo=activo$$

DROP PROCEDURE IF EXISTS `DescripcionMovilShort`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DescripcionMovilShort` (IN `activo` VARCHAR(11))  SELECT espmovil.marca, espmovil.modelo, espmovil.serie FROM espmovil, activos WHERE espmovil.vp=activos.vpActivo AND activos.vpActivo=activo$$

DROP PROCEDURE IF EXISTS `DevolucionDeArticulo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DevolucionDeArticulo` (IN `noEmpleado` INT(6), IN `activo` VARCHAR(11))  DELETE FROM asignaciones WHERE asignaciones.fkEmpleado=noEmpleado AND asignaciones.fkvp=activo$$

DROP PROCEDURE IF EXISTS `EmpleadoActivos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `EmpleadoActivos` (IN `noEmpleado` INT(6))  SELECT activos.vpActivo, activos.tipo, responsivas.fecha FROM empleados, activos, asignaciones, responsivas WHERE empleados.idEmpleado=noEmpleado AND empleados.idEmpleado=asignaciones.fkEmpleado AND activos.vpActivo=asignaciones.fkvp AND responsivas.id=asignaciones.responsiva$$

DROP PROCEDURE IF EXISTS `empleadoResponsivaActivo`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `empleadoResponsivaActivo` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, asignaciones.responsiva, activos.vpActivo, activos.tipo, activos.comentario FROM asignaciones, activos, empleados WHERE activos.vpActivo=asignaciones.fkvp AND empleados.idEmpleado=asignaciones.fkEmpleado$$

DROP PROCEDURE IF EXISTS `ultimaDevolucion`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ultimaDevolucion` ()  SELECT idDevolucion
FROM devoluciones
ORDER by idDevolucion DESC
LIMIT 1$$

DROP PROCEDURE IF EXISTS `ultimaResponsiva`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ultimaResponsiva` ()  SELECT id
FROM responsivas
ORDER by id DESC
LIMIT 1$$

DROP PROCEDURE IF EXISTS `ultimoEmpleado`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ultimoEmpleado` ()  SELECT idEmpleado
FROM empleados
ORDER by idEmpleado DESC
LIMIT 1$$

DROP PROCEDURE IF EXISTS `ultimoVP`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `ultimoVP` ()  SELECT vpActivo
FROM activos
ORDER by vpActivo DESC
LIMIT 1$$

DROP PROCEDURE IF EXISTS `verCartuchos`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verCartuchos` ()  SELECT * FROM activos WHERE activos.tipo='CARTUCHO'$$

DROP PROCEDURE IF EXISTS `verConsumiblesImpresoras`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verConsumiblesImpresoras` (IN `vpImpresora` VARCHAR(10))  SELECT espimpresoras.vp, espimpresoras.modelo, espcartucho.nombre, espcartucho.sku FROM espcartucho, espimpresoras WHERE espcartucho.vpImpresora=espimpresoras.vp AND espimpresoras.vp=vpImpresora$$

DROP PROCEDURE IF EXISTS `verEmpleadosPuesto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verEmpleadosPuesto` ()  SELECT empleados.nombre, empleados.apellidoPaterno, empleados.apellidoMaterno, departamentoS.Nombre, departamentos.puesto FROM empleados, departamentos WHERE empleados.departamento=departamentos.idDepartamento$$

DROP PROCEDURE IF EXISTS `verModificacionesAlSistema`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verModificacionesAlSistema` ()  SELECT registromovimiento.fecha, usuariosdesistema.nombre,  movimiento.descripcion FROM usuariosdesistema, registromovimiento, movimiento WHERE usuariosdesistema.id=registromovimiento.idUsuario AND registromovimiento.idRegistro=movimiento.id$$

DROP PROCEDURE IF EXISTS `verStock`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `verStock` ()  SELECT espimpresoras.modelo, espcartucho.nombre, stocks.cantidadMinima, stocks.cantidadActual, stocks.cantidadMaxima FROM espcartucho, espimpresoras, stocks WHERE espcartucho.vp=stocks.vpMedir AND espimpresoras.vp=espcartucho.vpImpresora$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `activos`
--

DROP TABLE IF EXISTS `activos`;
CREATE TABLE `activos` (
  `vpActivo` varchar(10) NOT NULL,
  `fechaCompra` datetime NOT NULL,
  `tiempoGarantia` int(1) NOT NULL,
  `factura` varchar(20) NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `comentario` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `activos`
--

INSERT INTO `activos` (`vpActivo`, `fechaCompra`, `tiempoGarantia`, `factura`, `tipo`, `comentario`) VALUES
('VP10000', '2019-09-13 09:44:52', 1, '1', 'IMPRESORA', '123456345\n'),
('VP10001', '2019-09-13 10:10:03', 1, '1', 'PC', '234643456\n'),
('VP10002', '2019-09-13 10:37:06', 1, '1', 'LAPTOP', 'laptop\n'),
('VP10003', '2019-09-13 11:26:41', 1, '1', 'TELEFONO IP', 'telefono\n'),
('VP10004', '2019-09-13 13:00:46', 1, '1', 'MOVIL', '234556\n'),
('VP10005', '2019-09-13 19:23:35', 1, '343434', 'IMPRESORA', 'alta de impresora\n'),
('VP10006', '2019-09-13 19:41:11', 1, '1', 'TELEFONO IP', 'telefono'),
('VP10007', '2019-09-13 19:49:55', 1, '1', 'IMPRESORA', 'impresora\n'),
('VP10008', '2019-09-13 22:35:01', 1, '1', 'IMPRESORA', 'impresora asignada para el area de diseño\n'),
('VP10009', '2019-09-13 22:39:02', 1, '1', 'PC', 'computadora de escritorio\n'),
('VP10010', '2019-09-13 22:40:44', 1, '1', 'TELEFONO IP', 'telefono\n'),
('VP10011', '2019-06-01 23:14:35', 1, '12467', 'ACCESORIO', 'cargador de pc\n'),
('VP10012', '2019-09-13 23:23:40', 1, '1', 'ACCESORIO', '1\n'),
('VP10013', '2019-09-14 00:00:20', 1, '1', 'ACCESORIO', 'impresoa\n'),
('VP10014', '2019-09-14 10:44:10', 1, '1', 'IMPRESORA', 'tel');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asignaciones`
--

DROP TABLE IF EXISTS `asignaciones`;
CREATE TABLE `asignaciones` (
  `idAsignacion` int(7) NOT NULL,
  `fkvp` varchar(11) NOT NULL,
  `fkEmpleado` int(6) NOT NULL,
  `responsiva` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `asignaciones`
--

INSERT INTO `asignaciones` (`idAsignacion`, `fkvp`, `fkEmpleado`, `responsiva`) VALUES
(2, 'VP10001', 2, 2),
(3, 'VP10004', 4, 3),
(4, 'VP10005', 3, 4),
(8, 'VP10009', 2, 6);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cartuchos`
--

DROP TABLE IF EXISTS `cartuchos`;
CREATE TABLE `cartuchos` (
  `Id_Activo` varchar(10) NOT NULL,
  `color` varchar(20) NOT NULL,
  `sku` text NOT NULL,
  `unidades` int(3) NOT NULL,
  `modelo` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE `categoria` (
  `idCategoria` int(4) NOT NULL,
  `nombre` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `configuracioncomp`
--

DROP TABLE IF EXISTS `configuracioncomp`;
CREATE TABLE `configuracioncomp` (
  `vp` varchar(10) NOT NULL,
  `ip` varchar(15) NOT NULL,
  `mac` varchar(17) NOT NULL,
  `versionSO` varchar(70) NOT NULL,
  `intelisis` varchar(20) NOT NULL,
  `licenciaOficce` varchar(40) NOT NULL,
  `teamviewer` varchar(10) NOT NULL,
  `anydesk` varchar(10) NOT NULL,
  `ftp` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `correos`
--

DROP TABLE IF EXISTS `correos`;
CREATE TABLE `correos` (
  `idCorreo` int(7) NOT NULL,
  `fkEmpleado` int(7) NOT NULL,
  `email` varchar(50) NOT NULL,
  `pass` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamento`
--

DROP TABLE IF EXISTS `departamento`;
CREATE TABLE `departamento` (
  `idDepartamento` int(5) NOT NULL,
  `nombre` varchar(25) NOT NULL,
  `fkEmpleado` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `departamento`
--

INSERT INTO `departamento` (`idDepartamento`, `nombre`, `fkEmpleado`) VALUES
(1, 'SISTEMAS', 1),
(2, 'SISTEMAS', 2),
(3, 'SISTEMAS', 3),
(4, 'SISTEMAS', 4),
(5, 'SISTEMAS', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamentos`
--

DROP TABLE IF EXISTS `departamentos`;
CREATE TABLE `departamentos` (
  `idDepartamento` int(4) NOT NULL,
  `Nombre` text NOT NULL,
  `puesto` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `devoluciones`
--

DROP TABLE IF EXISTS `devoluciones`;
CREATE TABLE `devoluciones` (
  `idDevolucion` int(7) NOT NULL,
  `fkvp` varchar(11) NOT NULL,
  `fkEmpleado` int(6) NOT NULL,
  `responsiva` int(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `devoluciones`
--

INSERT INTO `devoluciones` (`idDevolucion`, `fkvp`, `fkEmpleado`, `responsiva`) VALUES
(1, 'VP10014', 2, 1),
(2, 'VP10000', 2, 2),
(3, 'VP10008', 2, 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

DROP TABLE IF EXISTS `empleados`;
CREATE TABLE `empleados` (
  `idEmpleado` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellidoPaterno` text NOT NULL,
  `apellidoMaterno` text NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`idEmpleado`, `nombre`, `apellidoPaterno`, `apellidoMaterno`) VALUES
(1, 'DANIEL ALEJANDRO', 'GUZMAN', 'VALDEZ'),
(2, 'RAFAEL', 'SATIAGO', 'CRUZ'),
(3, 'CHRISTIAN', 'HIRACHETA', 'ESQUIVEL'),
(4, 'OMAR', 'CAMARILLO', 'AGUILAR'),
(5, 'JOB', 'GONZALEZ', 'HERNANDEZ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espaccesorio`
--

DROP TABLE IF EXISTS `espaccesorio`;
CREATE TABLE `espaccesorio` (
  `vp` varchar(10) NOT NULL,
  `marca` varchar(25) NOT NULL,
  `modelo` varchar(25) NOT NULL,
  `serie` varchar(25) NOT NULL,
  `subcategoria` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espaccesorio`
--

INSERT INTO `espaccesorio` (`vp`, `marca`, `modelo`, `serie`, `subcategoria`) VALUES
('VP10011', 'HP', '2345678', '34567890', ''),
('VP10013', 'DELL', 'ERTYR', 'ERTRE', 'REGULADOR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espantivirus`
--

DROP TABLE IF EXISTS `espantivirus`;
CREATE TABLE `espantivirus` (
  `vp` varchar(11) NOT NULL,
  `proveedor` varchar(50) NOT NULL,
  `fechaInstalacion` date NOT NULL,
  `fechaVencimiento` date NOT NULL,
  `licencia` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espcartucho`
--

DROP TABLE IF EXISTS `espcartucho`;
CREATE TABLE `espcartucho` (
  `vp` varchar(10) NOT NULL,
  `vpImpresora` varchar(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `sku` varchar(20) NOT NULL,
  `modelo` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espconsumible`
--

DROP TABLE IF EXISTS `espconsumible`;
CREATE TABLE `espconsumible` (
  `vp` varchar(10) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `unidades` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espimpresoras`
--

DROP TABLE IF EXISTS `espimpresoras`;
CREATE TABLE `espimpresoras` (
  `vp` varchar(10) NOT NULL,
  `marca` text NOT NULL,
  `modelo` text NOT NULL,
  `serie` text NOT NULL,
  `direccionIP` text NOT NULL,
  `direccionMac` varchar(17) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espimpresoras`
--

INSERT INTO `espimpresoras` (`vp`, `marca`, `modelo`, `serie`, `direccionIP`, `direccionMac`) VALUES
('VP10000', 'DELL', '12345', '123456543', '192.168.215.200', 'AD:2A:4C:FF:1D:3D'),
('VP10005', 'HP', '477DW', '36736', '192.168.215.56', 'SDFGHDSDDGGFF'),
('VP10007', 'EPSON', '4150', '34567', '192.168.255.123', 'SDFGNBSDSC'),
('VP10008', 'HP', '46543', 'SDFG', '23567', 'DGDTFT'),
('VP10014', 'HOMDA', '3456789', '34567890', '23456789', 'ASDFGHJDFG');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esplaptop`
--

DROP TABLE IF EXISTS `esplaptop`;
CREATE TABLE `esplaptop` (
  `vp` varchar(10) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `modelo` varchar(25) NOT NULL,
  `serie` varchar(25) NOT NULL,
  `memoria` double NOT NULL,
  `almacenamiento` int(11) NOT NULL,
  `sistema` text NOT NULL,
  `procesador` varchar(50) NOT NULL,
  `direccionIP` varchar(16) NOT NULL,
  `usuarioAdministrador` varchar(20) NOT NULL,
  `passAdministrador` varchar(20) NOT NULL,
  `ultimoRespaldo` date NOT NULL,
  `ultimoMantenimiento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `esplaptop`
--

INSERT INTO `esplaptop` (`vp`, `marca`, `modelo`, `serie`, `memoria`, `almacenamiento`, `sistema`, `procesador`, `direccionIP`, `usuarioAdministrador`, `passAdministrador`, `ultimoRespaldo`, `ultimoMantenimiento`) VALUES
('VP10002', 'ACER', '3000', '134523', 4, 500, 'WINDOWS 10 PRO', 'INTEL CORE I3', '192.168.215.33', 'Sistemas', 'Valle.28', '2019-09-13', '2019-09-13');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `espmovil`
--

DROP TABLE IF EXISTS `espmovil`;
CREATE TABLE `espmovil` (
  `vp` varchar(10) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `modelo` varchar(20) NOT NULL,
  `serie` varchar(25) NOT NULL,
  `ip` varchar(15) NOT NULL,
  `cuenta` varchar(50) NOT NULL,
  `passCuenta` varchar(20) NOT NULL,
  `passSistema` varchar(20) NOT NULL,
  `imei` varchar(25) NOT NULL,
  `numTelefono` varchar(10) NOT NULL,
  `ram` int(4) NOT NULL,
  `rom` int(4) NOT NULL,
  `so` varchar(50) NOT NULL,
  `camara` int(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `espmovil`
--

INSERT INTO `espmovil` (`vp`, `marca`, `modelo`, `serie`, `ip`, `cuenta`, `passCuenta`, `passSistema`, `imei`, `numTelefono`, `ram`, `rom`, `so`, `camara`) VALUES
('VP10004', 'ALCATEL', 'LECENT', '34563455', '192.168.215.45', 'rafaelsantiagocruz@outlook.com', 'rafael2019', '1590', '234567898765434567', '8131797809', 4, 32, 'ANDROID OREO', 15);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esppc`
--

DROP TABLE IF EXISTS `esppc`;
CREATE TABLE `esppc` (
  `vp` varchar(10) NOT NULL,
  `marca` varchar(10) NOT NULL,
  `modelo` varchar(25) NOT NULL,
  `serie` varchar(25) NOT NULL,
  `memoria` double NOT NULL,
  `almacenamiento` int(11) NOT NULL,
  `sistema` varchar(100) NOT NULL,
  `procesador` varchar(100) NOT NULL,
  `direccionIP` varchar(16) NOT NULL,
  `usuarioAdministrador` varchar(25) NOT NULL,
  `passAdministrador` varchar(16) NOT NULL,
  `ultimoRespaldo` date NOT NULL,
  `ultimoMantenimiento` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `esppc`
--

INSERT INTO `esppc` (`vp`, `marca`, `modelo`, `serie`, `memoria`, `almacenamiento`, `sistema`, `procesador`, `direccionIP`, `usuarioAdministrador`, `passAdministrador`, `ultimoRespaldo`, `ultimoMantenimiento`) VALUES
('VP10001', 'DELL', '3434', '23673', 4, 500, 'WINDOWS 10 PRO 64 BITS', 'INTEL CORE I3 WITH APU 3.0 GHZ (TM)', '192.168.215.34', 'Sistemas', 'Valle.28', '2019-09-13', '2019-09-13'),
('VP10009', 'DELL', '345654', '754434567', 8, 1000, 'WINDOWS 10 PRO EDICITION ANIVERSARI', 'INTEL CORE I3 PROCESOR ', '192.168.215.30', 'Sistemas', 'Valle.28', '2019-09-01', '2019-09-01');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `esptelefonos`
--

DROP TABLE IF EXISTS `esptelefonos`;
CREATE TABLE `esptelefonos` (
  `vp` varchar(10) NOT NULL,
  `extension` int(11) NOT NULL,
  `marca` varchar(20) NOT NULL,
  `modelo` varchar(25) NOT NULL,
  `serie` text NOT NULL,
  `ip` varchar(15) NOT NULL,
  `puerto` varchar(5) NOT NULL,
  `tarjeta` varchar(5) NOT NULL,
  `numeroDirecto` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `esptelefonos`
--

INSERT INTO `esptelefonos` (`vp`, `extension`, `marca`, `modelo`, `serie`, `ip`, `puerto`, `tarjeta`, `numeroDirecto`) VALUES
('VP10003', 159, 'ALCATEL', '4019', '2367', '192.168.215.100', '1', '3', '1234'),
('VP10006', 154, 'ALCATEL', '4019', '23456754', '192.168.123.23', '1', '2', '2345'),
('VP10010', 168, 'ALCATEL', '4019', '3473Y45', '192.168.215.67', '1', '3', '7654');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estado`
--

DROP TABLE IF EXISTS `estado`;
CREATE TABLE `estado` (
  `vp` varchar(11) NOT NULL,
  `estado` varchar(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estado`
--

INSERT INTO `estado` (`vp`, `estado`) VALUES
('VP10000', 'STOCK'),
('VP10001', 'ASIGNADO'),
('VP10002', 'STOCK'),
('VP10003', 'STOCK'),
('VP10004', 'ASIGNADO'),
('VP10005', 'ASIGNADO'),
('VP10006', 'STOCK'),
('VP10007', 'STOCK'),
('VP10008', 'STOCK'),
('VP10009', 'ASIGNADO'),
('VP10010', 'STOCK'),
('VP10011', 'STOCK'),
('VP10012', 'STOCK'),
('VP10013', 'STOCK'),
('VP10014', 'STOCK');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `localizacion`
--

DROP TABLE IF EXISTS `localizacion`;
CREATE TABLE `localizacion` (
  `id` int(11) NOT NULL,
  `fkvp` varchar(11) NOT NULL,
  `localizacionGeneral` varchar(40) NOT NULL,
  `localizacionEspecifica` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `movimiento`
--

DROP TABLE IF EXISTS `movimiento`;
CREATE TABLE `movimiento` (
  `id` int(5) NOT NULL,
  `descripcion` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `puestos`
--

DROP TABLE IF EXISTS `puestos`;
CREATE TABLE `puestos` (
  `idPuesto` int(11) NOT NULL,
  `nombrePuesto` varchar(50) NOT NULL,
  `fkEmpleado` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `puestos`
--

INSERT INTO `puestos` (`idPuesto`, `nombrePuesto`, `fkEmpleado`) VALUES
(1, 'COORDINADOR DE SISTEMAS', 1),
(2, 'AUXILIAR', 2),
(3, 'AUXILIAR', 3),
(4, 'AUXILIAR', 4),
(5, 'AUXILIAR', 5);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `registromovimiento`
--

DROP TABLE IF EXISTS `registromovimiento`;
CREATE TABLE `registromovimiento` (
  `idRegistro` int(8) NOT NULL,
  `fecha` datetime NOT NULL,
  `idUsuario` int(3) NOT NULL,
  `movimiento` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `responsivas`
--

DROP TABLE IF EXISTS `responsivas`;
CREATE TABLE `responsivas` (
  `id` int(6) NOT NULL,
  `fecha` datetime NOT NULL,
  `usuario` varchar(40) NOT NULL,
  `elaboro` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `responsivas`
--

INSERT INTO `responsivas` (`id`, `fecha`, `usuario`, `elaboro`) VALUES
(1, '2019-09-13 09:46:06', 'RAFAEL SATIAGO CRUZ', 'RAFAEL SANTIAGO CRUZ'),
(2, '2019-09-13 10:15:02', 'RAFAEL SATIAGO CRUZ', 'RAFAEL SANTIAGO CRUZ'),
(3, '2019-09-13 13:04:50', 'OMAR CAMARILLO AGUILAR', 'RAFAEL SANTIAGO CRUZ'),
(4, '2019-09-13 19:52:01', 'CHRISTIAN HIRACHETA ESQUIVEL', 'RAFAEL SANTIAGO CRUZ'),
(5, '2019-09-13 22:53:49', 'RAFAEL SATIAGO CRUZ', 'RAFAEL SANTIAGO CRUZ'),
(6, '2019-09-14 09:42:16', 'RAFAEL SATIAGO CRUZ', 'RAFAEL SANTIAGO CRUZ'),
(7, '2019-09-14 10:46:01', 'RAFAEL SATIAGO CRUZ', 'RAFAEL SANTIAGO CRUZ');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `stocks`
--

DROP TABLE IF EXISTS `stocks`;
CREATE TABLE `stocks` (
  `idMedicion` int(7) NOT NULL,
  `vpMedir` varchar(10) NOT NULL,
  `cantidadMinima` int(11) NOT NULL,
  `cantidadMaxima` int(11) NOT NULL,
  `cantidadActual` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE `usuarios` (
  `idMovimiento` int(7) NOT NULL,
  `tipoMovimiento` varchar(30) NOT NULL,
  `empleado` int(11) NOT NULL,
  `fecha` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuariosdesistema`
--

DROP TABLE IF EXISTS `usuariosdesistema`;
CREATE TABLE `usuariosdesistema` (
  `id` int(7) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(20) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `correo` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuariosdesistema`
--

INSERT INTO `usuariosdesistema` (`id`, `username`, `password`, `nombre`, `correo`) VALUES
(1, 'rafa', '1', 'RAFAEL SANTIAGO CRUZ', 'rafaelsantiagocruz@outlook.com');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `activos`
--
ALTER TABLE `activos`
  ADD PRIMARY KEY (`vpActivo`);

--
-- Indices de la tabla `asignaciones`
--
ALTER TABLE `asignaciones`
  ADD PRIMARY KEY (`idAsignacion`);

--
-- Indices de la tabla `cartuchos`
--
ALTER TABLE `cartuchos`
  ADD PRIMARY KEY (`Id_Activo`);

--
-- Indices de la tabla `categoria`
--
ALTER TABLE `categoria`
  ADD PRIMARY KEY (`idCategoria`);

--
-- Indices de la tabla `correos`
--
ALTER TABLE `correos`
  ADD PRIMARY KEY (`idCorreo`);

--
-- Indices de la tabla `departamento`
--
ALTER TABLE `departamento`
  ADD PRIMARY KEY (`idDepartamento`);

--
-- Indices de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  ADD PRIMARY KEY (`idDepartamento`);

--
-- Indices de la tabla `devoluciones`
--
ALTER TABLE `devoluciones`
  ADD PRIMARY KEY (`idDevolucion`);

--
-- Indices de la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD PRIMARY KEY (`idEmpleado`);
ALTER TABLE `empleados` ADD FULLTEXT KEY `Buscar` (`nombre`,`apellidoPaterno`,`apellidoMaterno`);

--
-- Indices de la tabla `espaccesorio`
--
ALTER TABLE `espaccesorio`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `espcartucho`
--
ALTER TABLE `espcartucho`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `espconsumible`
--
ALTER TABLE `espconsumible`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `espimpresoras`
--
ALTER TABLE `espimpresoras`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `esplaptop`
--
ALTER TABLE `esplaptop`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `espmovil`
--
ALTER TABLE `espmovil`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `esppc`
--
ALTER TABLE `esppc`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `esptelefonos`
--
ALTER TABLE `esptelefonos`
  ADD PRIMARY KEY (`vp`);

--
-- Indices de la tabla `localizacion`
--
ALTER TABLE `localizacion`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `movimiento`
--
ALTER TABLE `movimiento`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `puestos`
--
ALTER TABLE `puestos`
  ADD PRIMARY KEY (`idPuesto`);

--
-- Indices de la tabla `registromovimiento`
--
ALTER TABLE `registromovimiento`
  ADD PRIMARY KEY (`idRegistro`);

--
-- Indices de la tabla `responsivas`
--
ALTER TABLE `responsivas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `stocks`
--
ALTER TABLE `stocks`
  ADD PRIMARY KEY (`idMedicion`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`idMovimiento`);

--
-- Indices de la tabla `usuariosdesistema`
--
ALTER TABLE `usuariosdesistema`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `asignaciones`
--
ALTER TABLE `asignaciones`
  MODIFY `idAsignacion` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `categoria`
--
ALTER TABLE `categoria`
  MODIFY `idCategoria` int(4) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `correos`
--
ALTER TABLE `correos`
  MODIFY `idCorreo` int(7) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `departamento`
--
ALTER TABLE `departamento`
  MODIFY `idDepartamento` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  MODIFY `idDepartamento` int(4) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `devoluciones`
--
ALTER TABLE `devoluciones`
  MODIFY `idDevolucion` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `empleados`
--
ALTER TABLE `empleados`
  MODIFY `idEmpleado` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `localizacion`
--
ALTER TABLE `localizacion`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `movimiento`
--
ALTER TABLE `movimiento`
  MODIFY `id` int(5) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `puestos`
--
ALTER TABLE `puestos`
  MODIFY `idPuesto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de la tabla `registromovimiento`
--
ALTER TABLE `registromovimiento`
  MODIFY `idRegistro` int(8) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `responsivas`
--
ALTER TABLE `responsivas`
  MODIFY `id` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT de la tabla `stocks`
--
ALTER TABLE `stocks`
  MODIFY `idMedicion` int(7) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `idMovimiento` int(7) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `usuariosdesistema`
--
ALTER TABLE `usuariosdesistema`
  MODIFY `id` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
