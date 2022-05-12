-- Creación de la base de datos 'db_visual_basic'
CREATE DATABASE IF NOT EXISTS db_visual_basic;
USE db_visual_basic;

-- Creación de la tabla 'estudiantes'
CREATE TABLE IF NOT EXISTS estudiante (
  id_estudiante INT(10) NOT NULL AUTO_INCREMENT,
  nombres VARCHAR(50) NOT NULL,
  apellidos VARCHAR(50),
  email VARCHAR(80) NOT NULL,
  password VARCHAR(255) NOT NULL,
  PRIMARY KEY (id_estudiante)
);

-- Insertar datos de prueba
INSERT INTO estudiante (nombres, apellidos, email, password) VALUES ('Juan', 'Perez', 'perez@gmail.com', '123456');
INSERT INTO estudiante (nombres, apellidos, email, password) VALUES ('Pedro', 'Romero', 'romero@gmail.com', '123456');
INSERT INTO estudiante (nombres, apellidos, email, password) VALUES ('Fernando', 'Herrera', 'herrera@gmail.com', '123456');

-- Procedimiento para obtener todos los estudiantes
DELIMITER //
CREATE PROCEDURE sp_obtener_estudiantes()
BEGIN
  SELECT * FROM estudiante;
END //
DELIMITER ;

-- Procedimiento para obtener un estudiante por id
DELIMITER //
CREATE PROCEDURE sp_obtener_estudiante(IN id_estudiante_get INT(10))
BEGIN
  SELECT * FROM estudiante
  WHERE id_estudiante = id_estudiante_get;
END //
DELIMITER ;

-- Procedimiento para obtener un estudiante por email
DELIMITER //
CREATE PROCEDURE sp_obtener_estudiante_email(IN email_get VARCHAR(80))
BEGIN
  SELECT * FROM estudiante
  WHERE email = email_get;
END //
DELIMITER ;

-- Procedimiento para insertar un estudiante
DELIMITER //
CREATE PROCEDURE sp_insertar_estudiante(IN nombres VARCHAR(50), IN apellidos VARCHAR(50), IN email VARCHAR(80), IN password VARCHAR(255))
BEGIN
  INSERT INTO estudiante (nombres, apellidos, email, password)
  VALUES (nombres, apellidos, email, password);
END //
DELIMITER ;

-- Procedimiento para actualizar un estudiante
DELIMITER //
CREATE PROCEDURE sp_actualizar_estudiante(IN id_estudiante_up INT(10), IN nombres VARCHAR(50), IN apellidos VARCHAR(50), IN email VARCHAR(80), IN password VARCHAR(255))
BEGIN
  UPDATE estudiante
  SET nombres = nombres, apellidos = apellidos, email = email, password = password
  WHERE id_estudiante = id_estudiante_up;
END //
DELIMITER ;

-- Procedimiento para eliminar un estudiante
DELIMITER //
CREATE PROCEDURE sp_eliminar_estudiante(IN id_estudiante_del INT(10))
BEGIN
  DELETE FROM estudiante
  WHERE id_estudiante = id_estudiante_del;
END //
DELIMITER ;

-- Procedimiento para loguear un estudiante por email y password
DELIMITER //
CREATE PROCEDURE sp_login_estudiante(IN email_get VARCHAR(80), IN password_get VARCHAR(255))
BEGIN
  SELECT * FROM estudiante
  WHERE email = email_get AND password = password_get;
END //
DELIMITER ;