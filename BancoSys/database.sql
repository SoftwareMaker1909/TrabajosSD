CREATE TABLE Clientes (
  no_cliente int IDENTITY(1, 1) NOT NULL,
  nombre varchar(20) NOT NULL,
  apellido varchar(20) NOT NULL,
  direccion varchar(50) NOT NULL,
  telefono numeric NOT NULL,
  sexo char(1) NOT NULL,
  account bit NOT NULLDEFAULT ((0)),
);
ALTER TABLE
  Clientes
ADD
  CONSTRAINT PK__Clientes__9AF904D8C11A51B2 PRIMARY KEY (no_cliente);
CREATE TABLE Cuentas (
  no_cuenta int IDENTITY(1, 1) NOT NULL,
  tipo_cuenta varchar(20) NOT NULL,
  saldo money NOT NULL,
  no_cliente int NOT NULL,
);
ALTER TABLE
  Cuentas
ADD
  CONSTRAINT PK__Cuentas__83E0173176B39A1D PRIMARY KEY (no_cuenta);
CREATE TABLE Transacciones (
  no_trasaccion int IDENTITY(1, 1) NOT NULL,
  no_cuenta int NOT NULL,
  tipo_trasaccion int NOT NULL,
  monto_trasaccion money NOT NULL,
);
ALTER TABLE
  Transacciones
ADD
  CONSTRAINT PK__Transacc__BC72E937B7517172 PRIMARY KEY (no_trasaccion);
