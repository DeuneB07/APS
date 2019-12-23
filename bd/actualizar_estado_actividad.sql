CREATE TRIGGER Actualizar_Estado_Actividad
ON Actividades
AFTER UPDATE 
AS
BEGIN
	declare @nombreAct as varchar(50)
	declare @idAct as int;
	declare @nuevoEstado as varchar(50);
	declare @viejoEstado as varchar(50);
	declare @ong as varchar(50);
	declare @pdi as varchar(50);

	SELECT @idAct=i.ID_Actividad, @nombreAct=i.nombreAct, @nuevoEstado=i.estadoAct, @viejoEstado = d.estadoAct, @ong=i.emailOrganizador,@pdi=i.emailResponsable
	FROM inserted i LEFT JOIN deleted d ON i.ID_Actividad=d.ID_Actividad;

	IF (@viejoEstado='PENDIENTE_ACEPTACION' AND @nuevoEstado='ACEPTADA_GESTOR')
		INSERT INTO Historial VALUES ('Se ha aceptado la propuesta de la actividad '+@nombreAct+'.'+
										CHAR(13) + CHAR(10) +
									  'La actividad pasará a ser negociada por un PDI responsable ('+@pdi+').',@idAct,@ong,GETDATE());
	ELSE IF(@viejoEstado='PENDIENTE_ACEPTACION' AND @nuevoEstado='ACEPTADA')
		INSERT INTO Historial VALUES ('Se ha aceptado la propuesta de la actividad '+@nombreAct+' por parte de un gestor.'+
										CHAR(13) + CHAR(10) +
									  'La actividad ha sido publicada en la plataforma.',@idAct,@ong,GETDATE());
	ELSE IF((@viejoEstado='ACEPTADA_GESTOR' OR @viejoEstado='NEGOCIACION_PDI') AND @nuevoEstado='ACEPTADA')
		INSERT INTO Historial VALUES ('Se ha aceptado la propuesta de la actividad '+@nombreAct+' por parte deL PDI responsable ('+@pdi+').'+
										CHAR(13) + CHAR(10) +
									  'La actividad ha sido publicada en la plataforma.',@idAct,@ong,GETDATE());
	ELSE IF((@viejoEstado='ACEPTADA_GESTOR' OR @viejoEstado='NEGOCIACION_PDI') AND @nuevoEstado='NEGOCIACION_ONG')
		INSERT INTO Historial VALUES ('El PDI responsable '+@pdi+' quiere negociar la actividad '+@nombreAct+'.'+
										CHAR(13) + CHAR(10) +
									  'Diríjase a la pestaña Revisión para negociar esta actividad.',@idAct,@ong,GETDATE());
	ELSE IF((@viejoEstado='ACEPTADA_GESTOR' OR @viejoEstado='NEGOCIACION_PDI') AND @nuevoEstado='NEGOCIACION_CANCELADA')
		INSERT INTO Historial VALUES ('El PDI responsable '+@pdi+' ha CANCELADO la negociación de la actividad '+@nombreAct+'.'+
										CHAR(13) + CHAR(10) +
									  'Diríjase a la pestaña Revisión para publicar esta actividad como VOLUNTARIADO.',@idAct,@ong,GETDATE());
	ELSE IF(@viejoEstado='NEGOCIACION_ONG' AND @nuevoEstado='NEGOCIACION_PDI')
		INSERT INTO Historial VALUES ('La ONG '+@ong+' quiere negociar la actividad '+@nombreAct+'.'+
										CHAR(13) + CHAR(10) +
									  'Diríjase a la pestaña Revisión para negociar esta actividad.',@idAct,@pdi,GETDATE());
	ELSE IF(@viejoEstado='NEGOCIACION_ONG' AND @nuevoEstado='ACEPTADA' AND @pdi IS NOT NULL AND @PDI<>'')
		INSERT INTO Historial VALUES ('Has finalizado la negociación de la actividad '+@nombreAct+'.' + 
										CHAR(13) + CHAR(10) +
										'La actividad ha sido publicada en la plataforma.',@idAct,@pdi,GETDATE());
	ELSE IF(@viejoEstado='ABIERTA' AND @nuevoEstado='CERRADA')
		INSERT INTO Historial VALUES ('Se ha cerrado las plazas de la actividad ' + @nombreAct,@idAct,@ong,GETDATE());
	ELSE IF((@viejoEstado='ABIERTA' OR @nuevoEstado='CERRADA') AND @nuevoEstado='EN_PROCESO')
		INSERT INTO Historial VALUES ('Ha comenzado la actividad ' + @nombreAct,@idAct,@pdi,GETDATE());
	ELSE IF(@viejoEstado='CERRADA' AND @nuevoEstado='CONCLUIDA')
		INSERT INTO Historial VALUES ('Ha finalizado la actividad ' + @nombreAct,@idAct,@pdi,GETDATE());			
END