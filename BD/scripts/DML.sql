USE BLOCKTIME
GO

SELECT * FROM USUARIO

INSERT INTO TIPOUSUARIO(titulo)
VALUES ('Administrador'), ('Suporte')

INSERT INTO USUARIO (idTipoUsuario, nome, email, senha)
VALUES ('1','Zillig','nicoly@gmail.com','1234')