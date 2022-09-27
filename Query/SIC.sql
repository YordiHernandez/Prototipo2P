DROP DATABASE sic;
CREATE DATABASE sic;
USE sic;
CREATE TABLE tbl_bodegas
(
	pk_codigo_bodega VARCHAR(5) PRIMARY KEY,
    nombre_bodega VARCHAR(60),
    estatus_bodega VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE tbl_lineas
(
	pk_codigo_linea VARCHAR(5) PRIMARY KEY,
    nombre_linea VARCHAR(60),
    estatus_linea VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;
CREATE TABLE tbl_marcas
(
	pk_codigo_marca VARCHAR(5) PRIMARY KEY,
    nombre_marca VARCHAR(60),
    estatus_marca VARCHAR(1)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

CREATE TABLE tbl_productos
(
	pk_codigo_producto VARCHAR(18) PRIMARY KEY,
    nombre_producto VARCHAR(60),
    fk_codigo_linea VARCHAR(5),
    fk_codigo_marca VARCHAR(5),
    existencia_producto FLOAT(100,2),
    estatus_producto VARCHAR(1),
    FOREIGN KEY (fk_codigo_linea) REFERENCES tbl_lineas(pk_codigo_linea),
    FOREIGN KEY (fk_codigo_marca) REFERENCES tbl_marcas(pk_codigo_marca)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

CREATE TABLE tbl_existencias
(
	fk_codigo_bodega VARCHAR(5),
    fk_codigo_producto VARCHAR(18),
    saldo_existencia FLOAT(100,2),
    PRIMARY KEY (fk_codigo_bodega, fk_codigo_producto),
	FOREIGN KEY (fk_codigo_bodega) REFERENCES tbl_bodegas(pk_codigo_bodega),
    FOREIGN KEY (fk_codigo_producto) REFERENCES tbl_productos(pk_codigo_producto)
) ENGINE=INNODB DEFAULT CHARSET=latin1;

    