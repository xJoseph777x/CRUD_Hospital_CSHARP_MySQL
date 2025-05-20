-- MySQL dump 10.13  Distrib 8.0.42, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: mydb
-- ------------------------------------------------------
-- Server version	8.0.42

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `citas`
--

DROP TABLE IF EXISTS `citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `citas` (
  `idCitas` int NOT NULL AUTO_INCREMENT,
  `fechaCita` date NOT NULL,
  `horaCita` time NOT NULL,
  `Motivo` varchar(45) NOT NULL,
  `Diagnostico` varchar(65) DEFAULT NULL,
  `Tratamiento` varchar(65) DEFAULT NULL,
  `Observaciones` varchar(65) DEFAULT NULL,
  `Paciente_idPaciente` int NOT NULL,
  `Medico_idMedico` int NOT NULL,
  PRIMARY KEY (`idCitas`,`Paciente_idPaciente`,`Medico_idMedico`),
  KEY `fk_Citas_Paciente1_idx` (`Paciente_idPaciente`),
  KEY `fk_Citas_Medico1_idx` (`Medico_idMedico`),
  CONSTRAINT `fk_Citas_Medico1` FOREIGN KEY (`Medico_idMedico`) REFERENCES `medico` (`idMedico`),
  CONSTRAINT `fk_Citas_Paciente1` FOREIGN KEY (`Paciente_idPaciente`) REFERENCES `paciente` (`idPaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico` (
  `idMedico` int NOT NULL AUTO_INCREMENT,
  `NomMedico` varchar(45) NOT NULL,
  `CURPMedico` varchar(45) NOT NULL,
  `NacimientoMedico` date NOT NULL,
  `sexo` varchar(25) NOT NULL,
  `Telefono` varchar(10) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`idMedico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `idPaciente` int NOT NULL AUTO_INCREMENT,
  `NomPaciente` varchar(45) NOT NULL,
  `CURPPaciente` varchar(45) NOT NULL,
  `NacimientoPaciente` date NOT NULL,
  `sexoPaciente` varchar(25) NOT NULL,
  `TelefonoPaciente` varchar(10) NOT NULL,
  `Direccion` varchar(45) NOT NULL,
  PRIMARY KEY (`idPaciente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `NomUsuario` varchar(45) NOT NULL,
  `CURPUsuario` varchar(45) NOT NULL,
  `tipo` int NOT NULL,
  `sexo` int NOT NULL,
  `clave` varchar(15) NOT NULL,
  PRIMARY KEY (`idUsuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-18 16:45:18
