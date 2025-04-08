-- MySQL dump 10.13  Distrib 8.0.41, for Linux (aarch64)
--
-- Host: localhost    Database: dotnet_practice_db
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20250407050310_InitialCreate','8.0.0');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `authors`
--

LOCK TABLES `authors` WRITE;
/*!40000 ALTER TABLE `authors` DISABLE KEYS */;
INSERT INTO `authors` VALUES ('100-00-0001','Taro','Yamada','090-000-0001','Tokyo Tower','Tokyo','TK','10000',1,'2025-04-07 05:17:21.509266'),('100-00-0002','Hanako','Tanaka','090-000-0002','Osaka Castle','Osaka','OS','54000',0,'2025-04-07 05:17:21.509266'),('100-00-0003','Jiro','Suzuki','090-000-0003','Sapporo Beer St','Sapporo','SP','06000',1,'2025-04-07 05:17:21.509266'),('100-00-0004','Yuki','Kobayashi','090-000-0004','Hakata Ave','Fukuoka','FK','81200',0,'2025-04-07 05:17:21.509266'),('100-00-0005','Akira','Nakamura','090-000-0005','Sendai Park','Sendai','SD','98000',1,'2025-04-07 05:17:21.509266'),('100-00-0006','Megumi','Ito','090-000-0006','Nara Deer Rd','Nara','NR','63000',0,'2025-04-07 05:17:21.509266'),('100-00-0007','Shota','Kato','090-000-0007','Nagoya Blvd','Nagoya','NG','46000',1,'2025-04-07 05:17:21.509266'),('100-00-0008','Haruka','Saito','090-000-0008','Kobe Port','Kobe','KB','65000',1,'2025-04-07 05:17:21.509266'),('100-00-0009','Daiki','Fujita','090-000-0009','Hiroshima Peace','Hiroshima','HS','73000',0,'2025-04-07 05:17:21.509266'),('100-00-0010','Aoi','Yoshida','090-000-0010','Kumamoto Castle','Kumamoto','KM','86000',1,'2025-04-07 05:17:21.509266'),('100-00-0011','Ren','Abe','090-000-0011','Okinawa Beach','Naha','OK','90000',1,'2025-04-07 05:17:21.509266'),('100-00-0012','Sora','Takagi','090-000-0012','Hakone Hill','Hakone','HK','25000',0,'2025-04-07 05:17:21.509266'),('100-00-0013','Mio','Yamamoto','090-000-0013','Mt. Fuji Rd','Fujinomiya','FJ','41800',1,'2025-04-07 05:17:21.509266'),('100-00-0014','Kenta','Inoue','090-000-0014','Tottori Sand','Tottori','TT','68000',0,'2025-04-07 05:17:21.509266'),('100-00-0015','Rika','Hirano','090-000-0015','Shibuya Scramble','Tokyo','TK','15000',1,'2025-04-07 05:17:21.509266'),('100-00-0016','Yuto','Nakagawa','090-000-0016','Kyoto River','Kyoto','KT','60000',1,'2025-04-07 05:17:21.509266'),('100-00-0017','Noa','Shimizu','090-000-0017','Matsuyama Castle','Matsuyama','MY','79000',0,'2025-04-07 05:17:21.509266'),('100-00-0018','Hinata','Ogawa','090-000-0018','Nikko Shrine','Nikko','NK','32100',1,'2025-04-07 05:17:21.509266'),('100-00-0019','Minato','Ishikawa','090-000-0019','Beppu Hot Spring','Beppu','BP','87400',1,'2025-04-07 05:17:21.509266'),('100-00-0020','Aya','Takahashi','090-000-0020','Akihabara St','Tokyo','TK','10100',0,'2025-04-07 05:17:21.509266');
/*!40000 ALTER TABLE `authors` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-04-08 20:35:16
