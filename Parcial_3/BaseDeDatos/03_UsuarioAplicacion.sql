-- =====================================================================
-- Parcial 3 - Punto 3  (MySQL 8 / MySQL Workbench)
-- Script 03: crea el usuario de MySQL que usa el programa.
-- Ejecútalo DESPUÉS del script 01, conectado como root.
--
-- ¿Por qué no usar root en el programa?
-- Principio de PRIVILEGIOS MÍNIMOS: el programa solo necesita leer e
-- insertar en las dos tablas. Si alguien obtiene esta contraseña, no
-- puede borrar datos, modificar tablas ni tocar otras bases de datos.
--
-- La contraseña debe ser la misma que está en Datos/Conexion.cs.
-- =====================================================================

-- 'localhost' = solo se puede conectar desde esta misma computadora
CREATE USER IF NOT EXISTS 'app_login'@'localhost'
    IDENTIFIED BY 'LoginApp.2026!';

-- Usuarios: buscar (login) e insertar (registro). Sin UPDATE ni DELETE.
GRANT SELECT, INSERT ON LoginBCryptDB.Usuarios TO 'app_login'@'localhost';

-- IntentosLogin: registrar cada intento y leer el historial.
GRANT SELECT, INSERT ON LoginBCryptDB.IntentosLogin TO 'app_login'@'localhost';

-- Comprobar los permisos que quedaron
SHOW GRANTS FOR 'app_login'@'localhost';
