-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           5.5.28 - MySQL Community Server (GPL)
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              10.1.0.5464
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Copiando estrutura do banco de dados para zuounsystem
CREATE DATABASE IF NOT EXISTS `zuounsystem` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `zuounsystem`;

-- Copiando estrutura para tabela zuounsystem.menu
CREATE TABLE IF NOT EXISTS `menu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) NOT NULL,
  `opcao` varchar(50) NOT NULL,
  `nivel` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela zuounsystem.menu: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT IGNORE INTO `menu` (`id`, `descricao`, `opcao`, `nivel`) VALUES
	(1, 'Início', 'inicio', 1),
	(2, 'Cadastros', 'cadastros', 1);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;

-- Copiando estrutura para tabela zuounsystem.submenu
CREATE TABLE IF NOT EXISTS `submenu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) NOT NULL,
  `opcao` varchar(50) NOT NULL,
  `nivel` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela zuounsystem.submenu: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `submenu` DISABLE KEYS */;
INSERT IGNORE INTO `submenu` (`id`, `descricao`, `opcao`, `nivel`) VALUES
	(1, 'Consulta Clientes', 'cliente', NULL),
	(2, 'Opção 2', 'cliente', NULL),
	(3, 'Opção 3', 'cliente', NULL),
	(4, 'Opção 4', 'cliente', NULL),
	(5, 'Opção 5', 'cliente', NULL),
	(6, 'Opção 6', 'cliente', NULL),
	(7, 'Opção 7', 'cliente', NULL),
	(8, 'Opção 8', 'cliente', NULL),
	(9, 'Opção 9', 'cliente', NULL);
/*!40000 ALTER TABLE `submenu` ENABLE KEYS */;

-- Copiando estrutura para tabela zuounsystem.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `user` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `nivel` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela zuounsystem.usuario: ~1 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT IGNORE INTO `usuario` (`id`, `nome`, `user`, `senha`, `nivel`) VALUES
	(1, 'Gabriel Monteiro', 'm', 'm', 9);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
