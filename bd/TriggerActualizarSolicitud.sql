
CREATE TRIGGER Actualizar_Actividad_Solicitud
ON Actividades_Solicitudes
AFTER INSERT, UPDATE 
AS
BEGIN
	declare @user as varchar(50);
	declare @nombreAct as varchar(50)
	declare @idAct as int;
	declare @nuevoEstado as varchar(50);
	declare @ong as varchar(50);
	declare @pdi as varchar(50);

	IF EXISTS (SELECT 0 FROM inserted)
		BEGIN
			IF EXISTS (SELECT 0 FROM deleted)
				BEGIN

				SELECT @user = i.emailParticipante, @idAct = i.idAct, @nuevoEstado = i.EstadoSolicitud
				FROM inserted i LEFT JOIN deleted d ON i.emailParticipante=d.emailParticipante AND i.idAct=d.idAct;

				SELECT @nombreAct=nombreAct, @ong=emailOrganizador, @pdi = emailOrganizador
				FROM Actividades
				WHERE ID_Actividad=@idAct;

				IF (@nuevoEstado='EN_ESPERA_ONG')
					INSERT INTO Historial VALUES ('Se ha aceptado la solicitud de la actividad '+ @nombreAct +' por parte del PDI responsable ('+@pdi+').' + 
													CHAR(13) + CHAR(10) +
												  'La actividad pasa a trámite de la ONG('+@ong+').',@idAct,@user,GETDATE())
				ELSE IF(@nuevoEstado='ACEPTADA')
											INSERT INTO Historial VALUES ('Se ha aceptado la solicitud de la actividad '+ @nombreAct +' por parte de la ONG ('+@ong+').' + 
													CHAR(13) + CHAR(10) +
												  'La actividad '+ @nombreAct +' ha sido ACEPTADA con éxito.',@idAct,@user,GETDATE())
				ELSE
					INSERT INTO Historial VALUES ('Lo siento, se ha DENEGADO la solicitud de la actividad '+@nombreAct+'.',@idAct,@user,GETDATE())
				END

			ELSE
				BEGIN

				SELECT @user = i.emailParticipante, @idAct = i.idAct, @nuevoEstado = i.EstadoSolicitud
				FROM inserted i;

				SELECT @nombreAct=nombreAct, @ong=emailOrganizador, @pdi = emailOrganizador
				FROM Actividades
				WHERE ID_Actividad=@idAct;

				IF (@nuevoEstado='EN_ESPERA_PDI')
					INSERT INTO Historial VALUES ('Has solicitado la actividad '+ @nombreAct +'.' +
													CHAR(13) + CHAR(10) +
												  'La actividad pasará a trámite del PDI responsable ('+@pdi+').',@idAct,@user,GETDATE())
				ELSE
					INSERT INTO Historial VALUES ('Has solicitado la actividad '+ @nombreAct +'.' +
													CHAR(13) + CHAR(10) +
												  'La actividad pasará a trámite de la ONG ('+@ong+').',@idAct,@user,GETDATE())
				END			
		END
END