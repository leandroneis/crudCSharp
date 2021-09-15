# crudCSharp
Crud simples utilizando C#, Windows Form e Mysql.

##Segue o codigo sql para criar a tabela:
``` sql
CREATE DATABASE /*!32312 IF NOT EXISTS*/ `locadora` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `locadora`;

--
-- Table structure for table `locadora`
--

DROP TABLE IF EXISTS `locadora`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `locadora` (
  `id` bigint NOT NULL AUTO_INCREMENT,
  `nomeFilme` varchar(255) NOT NULL,
  `categoriaFilme` varchar(255) NOT NULL,
  `descricaoFilme` text NOT NULL,
  `anoFilme` varchar(4) NOT NULL,
  `ativoFilme` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

```
