------------------------------------------
--CREACION TABLA TIPO USUARIO-- 
------------------------------------------
CREATE TABLE TIPOUSUARIO (idTipoUsuario number not null primary key
,descripciontipousuario varchar(50));


select * from usuario;

select * from profesional;

execute SP_UPDATE_CLIENTE (6,'Amelia del carmen','ramirez','castaño',6037718,'9',22,'CASTILLO VELASCO 1540',661,45,13,6576652,'cramirez@hotmail.com')

create or replace PROCEDURE SP_UPDATE_CLIENTE(
 p_idCliente  CLIENTE.idcliente%TYPE,
 p_nombre   CLIENTE.nombre%TYPE,
 p_apPaterno CLIENTE.apPaterno%TYPE,
 p_apMaterno CLIENTE.apMaterno%TYPE,
 p_rut  CLIENTE.rut%TYPE,
 p_dvVerificador  CLIENTE.DVerificador%TYPE,
 p_idrubro  CLIENTE.idrubro%TYPE,
 p_direccion  CLIENTE.direccion%TYPE,
 p_codcomuna  CLIENTE.codcomuna%TYPE,
 p_codciudad  CLIENTE.codciudad%TYPE,
 p_codregion  CLIENTE.codregion%TYPE,
 P_TELEFONO  CLIENTE.TELEFONO%TYPE,
 P_email  CLIENTE.email%TYPE
 )
 iS
 BEGIN 
   UPDATE CLIENTE
   SET NOMBRE = P_NOMBRE, apPaterno=p_apPaterno,APMATERNO=p_apmaterno,rut = p_rut,DVerificador = p_dvVerificador,idrubro=p_idrubro,direccion=p_direccion,codcomuna=p_codcomuna,codciudad=p_codciudad,codregion=p_codregion ,TELEFONO=P_TELEFONO,EMAIL=P_email
   WHERE idcliente= p_idcliente;
   COMMIT;
   EXCEPTION
     WHEN OTHERS THEN
        
        ROLLBACK; 
        raise;
 END SP_UPDATE_CLIENTE;
------------------------------------------
--CREACION TABLA USUARIO-- 
------------------------------------------
CREATE table USUARIO (idUsuario number not null primary key
,idtipousuario number not null
,usuario varchar(50)
,clave varchar(50)
,activo number
,idcliente number
,idprofesional number
);

  select * from rubro;

execute SP_LOGIN ('maria.ibarra','Duoc.2015');
EXEC SP_LOGIN('maria.ibarra','Duoc.2015',:P_CURSOR );

select * from comuna;
select * from rubro;


select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email  from cliente cl inner join comuna cm on cm.idcomuna = cl.codcomuna inner join ciudad cd on cd.idciudad = cm.idciudad inner join region rg on rg.idregion = cd.idregion
select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,nombrecomuna,nombreciudad,nombreregion,telefono,email 
from cliente cl
inner join comuna cm on cm.idcomuna = cl.codcomuna
inner join ciudad cd on cd.idciudad = cm.idciudad
inner join region rg on rg.idregion = cd.idregion
;


declare 
v_usuario usuario.usuario%type;
v_clave   usuario.clave%TYPE;
begin

 SP_LOGIN ('maria.ibarra','Duoc.2015',v_usuario,v_clave);
--dbms_output.put_line(v_usuario||' '|| v_clave);
end;



declare usuario usuario.usuario%type, clave usuario.clave%type;
begin

execute sp_AccesoLogin ('m.ibarrao','Duoc.2015')
end ;

-------------
variable P_CURSOR REFCURSOR;
call SP_LOGIN('maria.ibarra','Duoc.2015', :P_CURSOR) ;
print :P_CURSOR;
   
CREATE OR REPLACE PROCEDURE sp_select_usuario(
 P_CURSOR OUT  SYS_REFCURSOR
 )
 AS
 BEGIN
   OPEN P_CURSOR FOR
   SELECT idtipousuario,usuario,clave,activo
    FROM usuario;
 
   END;
   
   select * from usuario;
------------------------------------------
--CREACION TABLA RUBRO-- 
------------------------------------------
CREATE table RUBRO (idRubro  number not null primary key
,descripcionRubro varchar(100)
);
------------------------------------------
--CREACION TABLA CLIENTE-- 
------------------------------------------
CREATE table CLIENTE (idCliente  number not null primary key
,nombre varchar(100)
,apPaterno varchar(100)
,apMaterno varchar(100)
,rut number
,DVerificador char(1)
,idrubro number
,direccion varchar(100)
,codcomuna number
,codciudad number
,codregion number
,telefono number(9)
,email varchar(100)
);

create or replace PROCEDURE SP_INSERTACLIENTE (nom in varchar2, paterno in varchar2,materno in varchar2,rut int, dverificador in varchar2, idrubro int,direccion in varchar2,codcomuna int,codciudad int,codregion int,telefono int,mail in varchar2)
as 
begin
INSERT INTO cliente (nombre, appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email) 
VALUES (nom, paterno,materno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,mail);
end;


 CREATE OR REPLACE PROCEDURE SP_INSERT_CLIENTE(
 p_idCliente IN CLIENTE.idcliente%TYPE,
 p_nombre IN  CLIENTE.nombre%TYPE,
 p_apPaterno IN CLIENTE.apPaterno%TYPE,
 p_apMaterno IN CLIENTE.apMaterno%TYPE,
 p_rut IN CLIENTE.rut%TYPE,
 p_dvVerificador in CLIENTE.dVerificador%TYPE,
 p_idrubro in CLIENTE.idrubro%TYPE,
 p_direccion in CLIENTE.direccion%TYPE,
 p_codcomuna in CLIENTE.codcomuna%TYPE,
 p_codciudad in CLIENTE.codciudad%TYPE,
 p_codregion in CLIENTE.codregion%TYPE,
 P_TELEFONO IN CLIENTE.TELEFONO%TYPE,
 P_email IN CLIENTE.email%TYPE,
 P_RESULT OUT VARCHAR2
 )
 AS
 BEGIN 
   INSERT INTO CLIENTE VALUES(p_idCliente,p_nombre,p_apPaterno,p_apMaterno,p_rut,p_dvVerificador,p_idrubro,p_direccion,p_codcomuna,p_codciudad,p_codregion,P_TELEFONO,P_EMAIL);
   P_RESULT:= 'SE HA INSERTADO CORRECTAMENTE EL CLIENTE';
   COMMIT;
   EXCEPTION
     WHEN OTHERS THEN
        P_RESULT:= 'ERROR AL INSERTAR CLIENTE'; 
        ROLLBACK; 
 END;
 
 CREATE OR REPLACE PROCEDURE SP_UPDATE_CLIENTE(
 p_idCliente IN CLIENTE.idcliente%TYPE,
 p_nombre IN  CLIENTE.nombre%TYPE,
 p_apPaterno IN CLIENTE.apPaterno%TYPE,
 p_apMaterno IN CLIENTE.apMaterno%TYPE,
 p_rut IN CLIENTE.rut%TYPE,
 p_dvVerificador in CLIENTE.DVerificador%TYPE,
 p_idrubro in CLIENTE.idrubro%TYPE,
 p_direccion in CLIENTE.direccion%TYPE,
 p_codcomuna in CLIENTE.codcomuna%TYPE,
 p_codciudad in CLIENTE.codciudad%TYPE,
 p_codregion in CLIENTE.codregion%TYPE,
 P_TELEFONO IN CLIENTE.TELEFONO%TYPE,
 P_email IN CLIENTE.email%TYPE,
 P_RESULT OUT VARCHAR2
 )
 AS
 BEGIN 
   UPDATE CLIENTE
   SET NOMBRE = P_NOMBRE, apPaterno=p_apPaterno,APMATERNO=p_apmaterno,rut = p_rut,DVerificador = p_dvVerificador,idrubro=p_idrubro,direccion=p_direccion,codcomuna=p_codcomuna,codciudad=p_codciudad,codregion=p_codregion ,TELEFONO=P_TELEFONO,EMAIL=P_EMAIL
   WHERE idcliente= p_idcliente;
   P_RESULT:= 'SE HA ACTUALIZADO CORRECTAMENTE EL CLIENTE';
   COMMIT;
   EXCEPTION
     WHEN OTHERS THEN
        P_RESULT:= 'ERROR AL ACTUALIZAR CLIENTE'; 
        ROLLBACK; 
 END;
 
 CREATE OR REPLACE PROCEDURE SP_DELETE_CLIENTE(
  p_idCliente IN CLIENTE.idCliente%TYPE,
   P_RESULT OUT VARCHAR2
 )
 AS
 BEGIN
   DELETE FROM CLIENTE
   WHERE idCliente = p_idCliente;
  P_RESULT:= 'SE HA ELIMINADO CORRECTAMENTE EL CLIENTE';
  COMMIT;
  EXCEPTION
    WHEN OTHERS THEN
          P_RESULT:= 'ERROR AL ELIMINAR CLIENTE'; 
        ROLLBACK;  
 END;
 
 CREATE OR REPLACE PROCEDURE SP_SELECT_CLIENTE(
 P_CURSOR OUT  SYS_REFCURSOR
 )
 AS
 BEGIN
   OPEN P_CURSOR FOR
   SELECT IDCLIENTE,NOMBRE,APPATERNO,APMATERNO,RUT,DVERIFICADOR,DESCRIPCIONRUBRO,DIRECCION,NOMBRECOMUNA,NOMBRECIUDAD,NOMBREREGION,CODCIUDAD,CODREGION,TELEFONO,EMAIL
    FROM CLIENTE CL
       INNER JOIN RUBRO RB ON RB.IDRUBRO = CL.IDRUBRO
       INNER JOIN COMUNA CM ON CM.IDCOMUNA = CL.CODCOMUNA
       INNER JOIN CIUDAD CD ON CM.IDCIUDAD = CD.IDCIUDAD
       INNER JOIN REGION RG ON CD.IDREGION = RG.IDREGION ;
 
   END;
------------------------------------------
--CREACION TABLA COMUNA-- 
------------------------------------------
CREATE table COMUNA (idComuna  number not null primary key
,nombreComuna varchar(100) not null
,idCiudad number not null
);

------------------------------------------
--CREACION TABLA CIUDAD-- 
------------------------------------------
CREATE table CIUDAD (idCiudad  number not null primary key
,nombreCiudad varchar(100) not null
,idRegion number not null
);

------------------------------------------
--CREACION TABLA REGION-- 
------------------------------------------
CREATE table REGION (idRegion  number not null primary key
,nombreRegion varchar(100) not null
);

------------------------------------------
--CREACION TABLA ACCIDENTE-- 
------------------------------------------
CREATE table ACCIDENTE (idAccidente  number not null primary key
,idCliente int not null
,fechaAccidente date NOT NULL
,descripcion varchar(1000) NULL
);
------------------------------------------
--CREACION TABLA PROFESIONAL-- 
------------------------------------------
CREATE table PROFESIONAL (idProfesional  number not null primary key
,nombre varchar(100) not null
,apPaterno varchar(100)  NOT NULL
,apMaterno varchar(100)  NULL
,rut number
,DVerificador char(1)
,fechaNacimiento date
,profesion varchar(100)
,direccion varchar(100)
,codcomuna number
,codciudad number
,codregion number
,telefono number(9)
,email varchar(100)
,cargo varchar(100)
);

------------------------------------------
--CREACION TABLA CONTRATO-- 
------------------------------------------
CREATE table CONTRATO (idContrato  number not null primary key
,detalle varchar2(1000) NOT NULL
,idcliente number NOT NULL
,fechaContrato date NOT  NULL
,idPlan number NOT NULL
);

------------------------------------------
--CREACION TABLA PLAN-- 
------------------------------------------
CREATE table  PLANC (idPlan  number not null primary key
,descripcion varchar(100) NOT NULL
,valorTotal number NOT NULL
);

------------------------------------------
--CREACION TABLA PAGO-- 
------------------------------------------
CREATE table PAGO (idPago  number not null primary key
,idCliente number NOT NULL
,idContrato number NOT NULL
,fechaPago date NOT NULL
,valorPago number NOT NULL
);

------------------------------------------
--CREACION TABLA VISITA-- 
------------------------------------------
CREATE table VISITA (idVisita  number not null primary key
,idCliente number NOT NULL
,idProfesional number NOT NULL
,idAccidente number NOT NULL
,fechaVisita date NOT NULL
,detalle VARCHAR2(1000) NULL
,observacion VARCHAR2(1000) NULL
);

------------------------------------------
--CREACION TABLA CAPACITACION-- 
------------------------------------------
CREATE table CAPACITACION (idCapacitacion  number not null primary key
,idCliente number NOT NULL
,idProfesional number NOT NULL
,fechaCapacitacion date NOT NULL
,observacion VARCHAR2(1000) NULL
);

------------------------------------------
--CREACION TABLA AGENDA-- 
------------------------------------------
CREATE table AGENDA (idAgenda  number not null primary key
,idProfesional number NOT NULL
,idVisita number NOT NULL
,idCapacitacion number NOT NULL
,agenFecha date NOT NULL
,direccion varchar(200) NOT NULL
,idcomuna number NOT NULL
,idciudad number NOT NULL
,idregion number NOT NULL
,coordenadasX varchar(100)NULL
,coordenadasY varchar(100) NULL
);

-----------------------------------------------------------------------
----------------------------    TRIGGER    ----------------------------
-----------------------------------------------------------------------
------------------------------------------
--TRIGGER AUTOINCREMENTAL IDTIPOUSUARIO--
------------------------------------------
CREATE SEQUENCE AI_TIPOUSUARIO
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_TIPOUSUARIO
  BEFORE INSERT ON TIPOUSUARIO
  FOR EACH ROW BEGIN
    SELECT AI_TIPOUSUARIO.NEXTVAL INTO :NEW.idTipoUsuario from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL IDUSUARIO--
------------------------------------------
CREATE SEQUENCE AI_USUARIO
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_USUARIO
  BEFORE INSERT ON USUARIO
  FOR EACH ROW BEGIN
    SELECT AI_USUARIO.NEXTVAL INTO :NEW.idUsUario from DUAL;
END;
------------------------------------------
--TRIGGER AUTOINCREMENTAL RUBRO--
------------------------------------------
CREATE SEQUENCE AI_RUBRO
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_RUBRO
  BEFORE INSERT ON RUBRO
  FOR EACH ROW BEGIN
    SELECT AI_RUBRO.NEXTVAL INTO :NEW.idRubro from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL COMUNA--
------------------------------------------
CREATE SEQUENCE AI_COMUNA
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_COMUNA
  BEFORE INSERT ON COMUNA
  FOR EACH ROW BEGIN
    SELECT AI_COMUNA.NEXTVAL INTO :NEW.idComuna from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL CIUDAD--
------------------------------------------
CREATE SEQUENCE AI_CIUDAD
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_CIUDAD
  BEFORE INSERT ON CIUDAD
  FOR EACH ROW BEGIN
    SELECT AI_CIUDAD.NEXTVAL INTO :NEW.idCiudad from DUAL;
END;


------------------------------------------
--TRIGGER AUTOINCREMENTAL REGION--
------------------------------------------
CREATE SEQUENCE AI_REGION
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_REGION
  BEFORE INSERT ON REGION
  FOR EACH ROW BEGIN
    SELECT AI_REGION.NEXTVAL INTO :NEW.idRegion from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL CLIENTE--
------------------------------------------
CREATE SEQUENCE AI_CLIENTE
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_CLIENTE
  BEFORE INSERT ON CLIENTE
  FOR EACH ROW BEGIN
    SELECT AI_CLIENTE.NEXTVAL INTO :NEW.idCliente from DUAL;
END;


------------------------------------------
--TRIGGER AUTOINCREMENTAL ACCIDENTE--
------------------------------------------
CREATE SEQUENCE AI_ACCIDENTE
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_ACCIDENTE
  BEFORE INSERT ON ACCIDENTE
  FOR EACH ROW BEGIN
    SELECT AI_ACCIDENTE.NEXTVAL INTO :NEW.idAccidente from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL PROFESIONAL--
------------------------------------------
CREATE SEQUENCE AI_PROFESIONAL
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_PROFESIONAL
  BEFORE INSERT ON PROFESIONAL
  FOR EACH ROW BEGIN
    SELECT AI_PROFESIONAL.NEXTVAL INTO :NEW.idProfesional from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL CONTRATO--
------------------------------------------
CREATE SEQUENCE AI_CONTRATO
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_CONTRATO
  BEFORE INSERT ON CONTRATO
  FOR EACH ROW BEGIN
    SELECT AI_CONTRATO.NEXTVAL INTO :NEW.idCONTRATO from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL PLAN--
------------------------------------------
CREATE SEQUENCE AI_PLAN
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_PLAN
  BEFORE INSERT ON PLANC
  FOR EACH ROW BEGIN
    SELECT AI_PLAN.NEXTVAL INTO :NEW.idPLAN from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL PAGO--
------------------------------------------
CREATE SEQUENCE AI_PAGO
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_PAGO
  BEFORE INSERT ON PAGO
  FOR EACH ROW BEGIN
    SELECT AI_PAGO.NEXTVAL INTO :NEW.idPAGO from DUAL;
END;
------------------------------------------
--TRIGGER AUTOINCREMENTAL VISITA--
------------------------------------------
CREATE SEQUENCE AI_VISITA
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_VISITA
  BEFORE INSERT ON VISITA
  FOR EACH ROW BEGIN
    SELECT AI_VISITA.NEXTVAL INTO :NEW.idVISITA from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL CAPACITACION--
------------------------------------------
CREATE SEQUENCE AI_CAPACITACION
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_CAPACITACION
  BEFORE INSERT ON CAPACITACION
  FOR EACH ROW BEGIN
    SELECT AI_CAPACITACION.NEXTVAL INTO :NEW.idCAPACITACION from DUAL;
END;

------------------------------------------
--TRIGGER AUTOINCREMENTAL AGENDA--
------------------------------------------
CREATE SEQUENCE AI_AGENDA
  START WITH 1
  INCREMENT BY 1;

CREATE TRIGGER TR_AI_AGENDA
  BEFORE INSERT ON AGENDA
  FOR EACH ROW BEGIN
    SELECT AI_AGENDA.NEXTVAL INTO :NEW.idAGENDA from DUAL;
END;

-----------------------------------------------------------------------
-------------------------    FOREING KEY    ---------------------------
-----------------------------------------------------------------------
------------------------------------------
--TRIGGER AUTOINCREMENTAL IDTIPOUSUARIO--
------------------------------------------
 alter table USUARIO
  add constraint FK_usuario_idTipoUsuario
  foreign key (idTipoUsuario)
  references TIPOUSUARIO (idTipoUsuario); 
  
 alter table USUARIO
  add constraint FK_usuario_idCliente
  foreign key (idCliente)
  references CLIENTE (idCliente); 
  
 alter table USUARIO
  add constraint FK_usuario_idProfesional
  foreign key (idProfesional)
  references PROFESIONAL (idProfesional); 
----
 alter table CLIENTE
  add constraint FK_cliente_idRubro
  foreign key (idRubro)
  references RUBRO (idRubro); 

 alter table CLIENTE
  add constraint FK_cliente_idComuna
  foreign key (codComuna)
  references COMUNA (idComuna); 

 alter table CLIENTE
  add constraint FK_cliente_idCiudad
  foreign key (codCiudad)
  references CIUDAD (idCiudad); 

 alter table CLIENTE
  add constraint FK_cliente_idRegion
  foreign key (codRegion)
  references REGION (idRegion); 
----
 alter table COMUNA
  add constraint FK_comuna_idCiudad
  foreign key (idCiudad)
  references CIUDAD (idCiudad); 

----
 alter table CIUDAD
  add constraint FK_ciudad_idRegion
  foreign key (idRegion)
  references REGION (idRegion); 
  
----
 alter table ACCIDENTE
  add constraint FK_accidente_idCliente
  foreign key (idCliente)
  references CLIENTE (idCliente); 
  
----
 alter table PROFESIONAL
  add constraint FK_profesional_idComuna
  foreign key (codComuna)
  references COMUNA (idComuna); 
  
 alter table PROFESIONAL
  add constraint FK_profesional_idCiudad
  foreign key (codCiudad)
  references CIUDAD (idCiudad); 
  
 alter table PROFESIONAL
  add constraint FK_profesional_idRegion
  foreign key (codRegion)
  references REGION (idRegion); 
  
----
 alter table CONTRATO
  add constraint FK_contrato_idCliente
  foreign key (idCliente)
  references CLIENTE (idCliente); 

 alter table CONTRATO
  add constraint FK_contrato_idPlan
  foreign key (idPlan)
  references PlanC (idPlan); 

----
 alter table PAGO
  add constraint FK_pago_idCliente
  foreign key (idCliente)
  references CLIENTE (idCliente); 

 alter table PAGO
  add constraint FK_pago_idContrato
  foreign key (idContrato)
  references CONTRATO (idContrato); 
  
----
 alter table VISITA
  add constraint FK_visita_idCliente
  foreign key (idCliente)
  references CLIENTE (idCliente); 

alter table VISITA
  add constraint FK_visita_idProfesional
  foreign key (idProfesional)
  references PROFESIONAL (idProfesional); 
  
 alter table VISITA
  add constraint FK_visita_idAccidente
  foreign key (idAccidente)
  references ACCIDENTE (idAccidente); 
  
----
 alter table CAPACITACION
  add constraint FK_capacitacion_idCliente
  foreign key (idCliente)
  references CLIENTE (idCliente); 

alter table CAPACITACION
  add constraint FK_capacitacion_idProfesional
  foreign key (idProfesional)
  references PROFESIONAL (idProfesional);
  
----
 alter table AGENDA
  add constraint FK_agenda_idVisita
  foreign key (idVisita)
  references VISITA (idVisita); 

alter table AGENDA
  add constraint FK_agenda_idProfesional
  foreign key (idProfesional)
  references PROFESIONAL (idProfesional);  

alter table AGENDA
  add constraint FK_agenda_idComuna
  foreign key (idComuna)
  references COMUNA (idComuna); 

 alter table AGENDA
  add constraint FK_agenda_idCiudad
  foreign key (idCiudad)
  references CIUDAD (idCiudad); 

alter table AGENDA
  add constraint FK_agenda_idRegion
  foreign key (idRegion)
  references REGION (idRegion); 
------------------------------------------
--INSERTAR REGISTRO DE PRUEBA USUARIO--
------------------------------------------

select idcliente,nombre,appaterno,apmaterno,rut,dverificador,idrubro,direccion,codcomuna,codciudad,codregion,telefono,email 
from cliente 
where idcliente = (select max(idcliente) from cliente)

create or replace PROCEDURE SP_INSERTAUSUARIO (idtpousuario in int, usuario in nvarchar2, clave in nvarchar2, activo in int, idcliente in int, idprofesional in int)
as 

begin
  
  
  select * from usuario
  select * from cliente

INSERT INTO usuario (idtipousuario,usuario,clave,activo,idcliente,idprofesional) 
VALUES (idtpousuario, usuario,clave,activo,idcliente,idprofesional);
end;


exec SP_INSERTAUSUARIO('1','M.SanchezC','M.SanchezC1832','1','11',null)

;

--insert into USUARIO(idtipousuario,usuario,clave,activo,idcliente,idprofesional) values ('2','r.guzmanc','Pruebas.123','1',null,null); commit;
  
  select * from usuario;