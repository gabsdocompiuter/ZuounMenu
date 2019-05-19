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


-- Copiando estrutura do banco de dados para zuounmenu
CREATE DATABASE IF NOT EXISTS `zuounmenu` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `zuounmenu`;

-- Copiando estrutura para tabela zuounmenu.menu
CREATE TABLE IF NOT EXISTS `menu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `descricao` varchar(50) NOT NULL,
  `opcao` varchar(50) NOT NULL,
  `nivel` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela zuounmenu.menu: ~2 rows (aproximadamente)
DELETE FROM `menu`;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` (`id`, `descricao`, `opcao`, `nivel`) VALUES
	(1, 'Início', 'inicio', 1),
	(2, 'Cadastros', 'cadastros', 1);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;

-- Copiando estrutura para tabela zuounmenu.submenu
CREATE TABLE IF NOT EXISTS `submenu` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `menuPai` int(11) NOT NULL,
  `descricao` varchar(50) NOT NULL,
  `opcao` varchar(50) NOT NULL,
  `nivel` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `opcao` (`opcao`),
  KEY `menuPai` (`menuPai`),
  CONSTRAINT `menuPai` FOREIGN KEY (`menuPai`) REFERENCES `menu` (`id`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela zuounmenu.submenu: ~3 rows (aproximadamente)
DELETE FROM `submenu`;
/*!40000 ALTER TABLE `submenu` DISABLE KEYS */;
INSERT INTO `submenu` (`id`, `menuPai`, `descricao`, `opcao`, `nivel`) VALUES
	(1, 2, 'Consulta Clientes', 'ConsultaClientes', NULL),
	(2, 2, 'Consulta Produtos', 'ConsultaProdutos', NULL),
	(3, 2, 'Consulta Estoque', 'ConsultaEstoque', NULL);
/*!40000 ALTER TABLE `submenu` ENABLE KEYS */;

-- Copiando estrutura para tabela zuounmenu.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome` varchar(50) NOT NULL,
  `user` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  `nivel` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- Copiando dados para a tabela zuounmenu.usuario: ~1 rows (aproximadamente)
DELETE FROM `usuario`;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`id`, `nome`, `user`, `senha`, `nivel`) VALUES
	(1, 'Gabriel Monteiro', 'm', 'm', 9);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
