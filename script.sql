-- MySQL Script generated by MySQL Workbench
-- Sun Dec 23 11:32:07 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema clientes
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema clientes
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `clientes` ;
USE `clientes` ;

-- -----------------------------------------------------
-- Table `clientes`.`Fornecedor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `clientes`.`Fornecedor` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Apelido` VARCHAR(45) NULL,
  `Nome` VARCHAR(45) NULL,
  `CPFCNPJ` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  `Endereco` VARCHAR(45) NULL,
  `Bairro` VARCHAR(45) NULL,
  `Cidade` VARCHAR(45) NULL,
  `UF` VARCHAR(2) NULL,
  `CEP` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `clientes`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `clientes`.`Cliente` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Apelido` VARCHAR(45) NULL,
  `Nome` VARCHAR(45) NULL,
  `CPFCNPJ` VARCHAR(45) NULL,
  `Email` VARCHAR(45) NULL,
  `Endereco` VARCHAR(45) NULL,
  `Bairro` VARCHAR(45) NULL,
  `Cidade` VARCHAR(45) NULL,
  `UF` VARCHAR(2) NULL,
  `CEP` VARCHAR(45) NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `clientes`.`Produto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `clientes`.`Produto` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Apelido` VARCHAR(45) NULL,
  `Nome` VARCHAR(45) NULL,
  `Valor` DECIMAL(14,2) NULL,
  `Unidade` CHAR(2) NULL,
  `Fornecedor_Id` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Produto_Fornecedor_idx` (`Fornecedor_Id` ASC),
  CONSTRAINT `fk_Produto_Fornecedor`
    FOREIGN KEY (`Fornecedor_Id`)
    REFERENCES `clientes`.`Fornecedor` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `clientes`.`Pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `clientes`.`Pedido` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Apelido` VARCHAR(45) NULL,
  `Nome` VARCHAR(45) NULL,
  `Data` DATE NULL,
  `DataEntrega` DATE NULL,
  `Status` INT NULL,
  `Cliente_Id` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_Pedido_Cliente1_idx` (`Cliente_Id` ASC),
  CONSTRAINT `fk_Pedido_Cliente1`
    FOREIGN KEY (`Cliente_Id`)
    REFERENCES `clientes`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `clientes`.`ItensPedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `clientes`.`ItensPedido` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `Qtd` INT NULL,
  `Apelido` VARCHAR(45) NULL,
  `Nome` VARCHAR(45) NULL,
  `Produto_Id` INT NOT NULL,
  `Pedido_Id` INT NOT NULL,
  PRIMARY KEY (`Id`),
  INDEX `fk_ItensPedido_Produto1_idx` (`Produto_Id` ASC),
  INDEX `fk_ItensPedido_Pedido1_idx` (`Pedido_Id` ASC),
  CONSTRAINT `fk_ItensPedido_Produto1`
    FOREIGN KEY (`Produto_Id`)
    REFERENCES `clientes`.`Produto` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_ItensPedido_Pedido1`
    FOREIGN KEY (`Pedido_Id`)
    REFERENCES `clientes`.`Pedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
