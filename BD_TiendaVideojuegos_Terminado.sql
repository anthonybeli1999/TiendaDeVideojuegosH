-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Versión del servidor:         10.1.38-MariaDB - mariadb.org binary distribution
-- SO del servidor:              Win64
-- HeidiSQL Versión:             10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Volcando estructura de base de datos para bd_tiendavideojuegos
CREATE DATABASE IF NOT EXISTS `bd_tiendavideojuegos` /*!40100 DEFAULT CHARACTER SET utf32 COLLATE utf32_spanish_ci */;
USE `bd_tiendavideojuegos`;

-- Volcando estructura para tabla bd_tiendavideojuegos.tb_boleta
CREATE TABLE IF NOT EXISTS `tb_boleta` (
  `Serie` varchar(50) COLLATE utf32_spanish_ci NOT NULL,
  `Numero` varchar(50) COLLATE utf32_spanish_ci NOT NULL,
  `RUC_Prov` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `DNI_Emp` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `Cliente` varchar(50) COLLATE utf32_spanish_ci NOT NULL,
  `Fecha` varchar(50) COLLATE utf32_spanish_ci NOT NULL,
  `SubTotal` double NOT NULL,
  `IGV` double NOT NULL,
  `TotalPago` double NOT NULL,
  PRIMARY KEY (`Serie`,`Numero`),
  KEY `FK_tb_boleta_tb_proveedores` (`RUC_Prov`),
  KEY `FK_tb_boleta_tb_empleados` (`DNI_Emp`),
  CONSTRAINT `FK_tb_boleta_tb_empleados` FOREIGN KEY (`DNI_Emp`) REFERENCES `tb_empleados` (`CodEmp`),
  CONSTRAINT `FK_tb_boleta_tb_proveedores` FOREIGN KEY (`RUC_Prov`) REFERENCES `tb_proveedores` (`RUCProv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_tiendavideojuegos.tb_detalleboleta
CREATE TABLE IF NOT EXISTS `tb_detalleboleta` (
  `Serie` varchar(50) COLLATE utf32_spanish_ci DEFAULT NULL,
  `Numero` varchar(50) COLLATE utf32_spanish_ci DEFAULT NULL,
  `CodigoProducto` varchar(50) COLLATE utf32_spanish_ci DEFAULT NULL,
  `Nombre` varchar(50) COLLATE utf32_spanish_ci DEFAULT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  `SubTotal` double DEFAULT NULL,
  KEY `FK_tb_detalleboleta_tb_boleta` (`Serie`,`Numero`),
  KEY `FK_tb_detalleboleta_tb_productos` (`CodigoProducto`),
  CONSTRAINT `FK_tb_detalleboleta_tb_boleta` FOREIGN KEY (`Serie`, `Numero`) REFERENCES `tb_boleta` (`Serie`, `Numero`),
  CONSTRAINT `FK_tb_detalleboleta_tb_productos` FOREIGN KEY (`CodigoProducto`) REFERENCES `tb_productos` (`CodigoProd`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_tiendavideojuegos.tb_empleados
CREATE TABLE IF NOT EXISTS `tb_empleados` (
  `CodEmp` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `NombreEmp` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  `ApellidoEmp` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  `ClaveEmp` varchar(8) COLLATE utf32_spanish_ci DEFAULT NULL,
  `DireccionEmp` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  `Estado` varchar(10) COLLATE utf32_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`CodEmp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_tiendavideojuegos.tb_genero
CREATE TABLE IF NOT EXISTS `tb_genero` (
  `CodigoGen` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `NombreGen` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`CodigoGen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_tiendavideojuegos.tb_plataforma
CREATE TABLE IF NOT EXISTS `tb_plataforma` (
  `CodigoPlat` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `NombrePlat` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`CodigoPlat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_tiendavideojuegos.tb_productos
CREATE TABLE IF NOT EXISTS `tb_productos` (
  `CodigoProd` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `NombreProd` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  `CantidadProd` int(11) DEFAULT NULL,
  `PrecioProd` double DEFAULT NULL,
  `CodigoPlat` varchar(10) COLLATE utf32_spanish_ci DEFAULT NULL,
  `CodigoGen` varchar(10) COLLATE utf32_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`CodigoProd`),
  KEY `FK_tb_productos_tb_plataforma` (`CodigoPlat`),
  KEY `FK_tb_productos_tb_genero` (`CodigoGen`),
  CONSTRAINT `FK_tb_productos_tb_genero` FOREIGN KEY (`CodigoGen`) REFERENCES `tb_genero` (`CodigoGen`),
  CONSTRAINT `FK_tb_productos_tb_plataforma` FOREIGN KEY (`CodigoPlat`) REFERENCES `tb_plataforma` (`CodigoPlat`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para tabla bd_tiendavideojuegos.tb_proveedores
CREATE TABLE IF NOT EXISTS `tb_proveedores` (
  `RUCProv` varchar(10) COLLATE utf32_spanish_ci NOT NULL,
  `NombreProv` varchar(60) COLLATE utf32_spanish_ci DEFAULT NULL,
  PRIMARY KEY (`RUCProv`)
) ENGINE=InnoDB DEFAULT CHARSET=utf32 COLLATE=utf32_spanish_ci;

-- La exportación de datos fue deseleccionada.
-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarBoleta`(
	IN `Aserie` VARCHAR(50),
	IN `Anum` VARCHAR(50),
	IN `Aruc` VARCHAR(50),
	IN `Acodemp` VARCHAR(50),
	IN `Acli` VARCHAR(50),
	IN `Afecha` VARCHAR(50),
	IN `Asub` DOUBLE,
	IN `Aigv` DOUBLE,
	IN `Atotal` DOUBLE
)
BEGIN
insert into tb_boleta(Serie,Numero,RUC_Prov,DNI_Emp,Cliente,Fecha,SubTotal,IGV,TotalPago)
values(Aserie,Anum,Aruc,Acodemp,Acli,Afecha,Asub,Aigv,Atotal);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarDetalleBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarDetalleBoleta`(
	IN `Aserie` VARCHAR(50),
	IN `Anum` VARCHAR(50),
	IN `Acodprod` VARCHAR(50),
	IN `Anomprod` VARCHAR(50),
	IN `Acant` INT,
	IN `Asub` DOUBLE
)
BEGIN
insert into tb_detalleboleta(Serie,Numero,CodigoProducto,Nombre,Cantidad,SubTotal)
values(Aserie,Anum,Acodprod,Anomprod,Acant,Asub);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarEmpleado
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarEmpleado`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50),
	IN `Aape` VARCHAR(50),
	IN `Acla` VARCHAR(50),
	IN `Adir` VARCHAR(50)

,
	IN `Aest` VARCHAR(50)
)
BEGIN
insert into tb_empleados(CodEmp,NombreEmp,ApellidoEmp,ClaveEmp,DireccionEmp,Estado)
values(Acod,Anom,Aape,Acla,Adir,Aest);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarGenero
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarGenero`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50)
)
BEGIN
insert into tb_genero(CodigoGen,NombreGen)
values(Acod,Anom);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarPlataforma
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarPlataforma`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50)
)
BEGIN
insert into tb_plataforma(CodigoPlat,NombrePlat)
values(Acod,Anom);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarProducto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarProducto`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50),
	IN `Acant` VARCHAR(50),
	IN `Apre` VARCHAR(50),
	IN `Acodplat` VARCHAR(50),
	IN `Acodgen` VARCHAR(50)
)
BEGIN
insert into tb_productos(CodigoProd,NombreProd,CantidadProd,PrecioProd,CodigoPlat,CodigoGen)
values(Acod,Anom,Acant,Apre,Acodplat,Acodgen);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_A_IngresarProveedor
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_A_IngresarProveedor`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50)
)
BEGIN
insert into tb_proveedores(RUCProv,NombreProv)
values(Acod,Anom);
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_D_EliminarDetalleBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_D_EliminarDetalleBoleta`(
	IN `Aserie` VARCHAR(50),
	IN `Anum` VARCHAR(50),
	IN `Acod` VARCHAR(50)
)
BEGIN
delete from tb_detalleboleta 
where Serie=Aserie && Numero=Anum && CodigoProducto=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarBoleta`(
	IN `Aserie` VARCHAR(50),
	IN `Anum` VARCHAR(50),
	IN `Atotal` DOUBLE
)
update tb_boleta set
TotalPago=Atotal
where Serie=Aserie && Numero=Anum//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarDetalleBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarDetalleBoleta`(
	IN `Acod` VARCHAR(50),
	IN `Acant` INT





,
	IN `Asub` DOUBLE

)
BEGIN
update tb_detalleboleta set
Cantidad=Cantidad+Acant,SubTotal=Asub
where CodigoProducto=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarEmpleados
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarEmpleados`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50),
	IN `Aape` VARCHAR(50),
	IN `Acla` VARCHAR(50),
	IN `Adir` VARCHAR(50)

,
	IN `Aest` VARCHAR(50)
)
BEGIN
update tb_empleados set
NombreEmp=Anom,ApellidoEmp=Aape,ClaveEmp=Acla,DireccionEmp=Adir,Estado=Aest
where CodEmp=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarGenero
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarGenero`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50)
)
BEGIN
update tb_genero set
NombreGen=Anom
where CodigoGen=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarPlataforma
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarPlataforma`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50)
)
BEGIN
update tb_plataforma set
NombrePlat=Anom
where CodigoPlat=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarProducto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarProducto`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50),
	IN `Acant` INT,
	IN `Apre` DOUBLE,
	IN `Acodplat` VARCHAR(50),
	IN `Acodgen` VARCHAR(50)




)
BEGIN
update tb_productos set
NombreProd=Anom,CantidadProd=Acant,PrecioProd=Apre,CodigoPlat=Acodplat,CodigoGen=Acodgen
where CodigoProd=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarProveedor
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarProveedor`(
	IN `Acod` VARCHAR(50),
	IN `Anom` VARCHAR(50)
)
BEGIN
update tb_proveedores set
NombreProv=Anom
where RUCProv=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_E_ModificarStock
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_E_ModificarStock`(
	IN `Acod` VARCHAR(50),
	IN `Acant` VARCHAR(50)


)
BEGIN
update tb_productos set
CantidadProd=Acant
where CodigoProd=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_S_BuscarDetalleBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_S_BuscarDetalleBoleta`(
	IN `Aserie` VARCHAR(50),
	IN `Anum` VARCHAR(50)
)
BEGIN
select Serie,Numero,CodigoProducto,Nombre,Cantidad,SubTotal from tb_detalleboleta where Serie=Aserie && Numero=Anum;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_S_BuscarNombreGenero
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_S_BuscarNombreGenero`(
	IN `Ayucod` VARCHAR(50)

)
BEGIN
select NombreGen from tb_genero where CodigoGen=Ayucod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_S_BuscarNombrePlataforma
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_S_BuscarNombrePlataforma`(
	IN `Ayucod` VARCHAR(50)
)
BEGIN
select NombrePlat from tb_plataforma where CodigoPlat=Ayucod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_S_BuscarNombreProveedor
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_S_BuscarNombreProveedor`(
	IN `Ayucod` VARCHAR(50)

)
BEGIN
select NombreProv from tb_proveedores where RUCProv=Ayucod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_S_BuscarProducto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_S_BuscarProducto`(
	IN `Ayucod` VARCHAR(50)
)
BEGIN
select CodigoProd,NombreProd,CantidadProd,PrecioProd,CodigoPlat,CodigoGen from tb_productos where CodigoProd=Ayucod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_U_CompraProducto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_U_CompraProducto`(
	IN `Acod` VARCHAR(50),
	IN `Acant` INT
)
BEGIN
update tb_productos set
CantidadProd=CantidadProd-Acant
where CodigoProd=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_U_DevolverProducto
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_U_DevolverProducto`(
	IN `Acod` VARCHAR(50),
	IN `Acant` INT
)
BEGIN
update tb_productos set
CantidadProd=CantidadProd+Acant
where CodigoProd=Acod;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarBoleta`()
BEGIN
select * from tb_boleta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarCodigoGenero
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarCodigoGenero`()
BEGIN
select CodigoGen from tb_genero;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarCodigoPlataforma
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarCodigoPlataforma`()
BEGIN
select CodigoPlat from tb_plataforma;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarCodigoProveedor
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarCodigoProveedor`()
BEGIN
select RUCProv from tb_proveedores;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarDetalleBoleta
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarDetalleBoleta`()
BEGIN
select * from tb_detalleboleta;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarEmpleados
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarEmpleados`()
BEGIN
select * from tb_empleados;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarGenero
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarGenero`()
BEGIN
select * from tb_genero;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarPlataforma
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarPlataforma`()
BEGIN
select * from tb_plataforma;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarProductos
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarProductos`()
BEGIN
select * from tb_productos;
END//
DELIMITER ;

-- Volcando estructura para procedimiento bd_tiendavideojuegos.usp_V_ListarProveedor
DELIMITER //
CREATE DEFINER=`root`@`localhost` PROCEDURE `usp_V_ListarProveedor`()
BEGIN
select * from tb_proveedores;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
