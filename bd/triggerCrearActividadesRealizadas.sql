
CREATE TRIGGER Crear_Activiades_Realizadas
ON Actividades
AFTER UPDATE 
AS
	declare @idActividad as int;
	declare @nombreActividad as varchar(50);
	declare @emailUsuario as varchar(50)
	declare @estadoRealizacion as varchar(50);
	SET @estadoRealizacion = 'EVALUACION_PARTICIPANTE';

	SELECT @idActividad = i.ID_Actividad, @nombreActividad = i.nombreAct 
			FROM inserted i LEFT JOIN deleted d ON i.ID_Actividad = d.ID_Actividad
			WHERE d.estadoAct='EN_PROCESO' AND i.estadoAct='CONCLUIDA';
	
	declare cursor_solicitudes CURSOR FOR
	SELECT emailParticipante FROM Actividades_Solicitudes
	WHERE idAct=@idActividad AND EstadoSolicitud='ACEPTADA';

	OPEN cursor_solicitudes;
	--Perfeorm the first fetch
	FETCH NEXT FROM cursor_solicitudes INTO @emailUsuario;

	--Check @@Fetch_Status to see if there are any more rows to fetch
	WHILE @@FETCH_STATUS = 0
	BEGIN
		--CREAR NUEVA ACTIVIDAD REALIZADA
		INSERT INTO Actividades_Realizadas (emailParticipante,idAct,estadoRealizacion) VALUES (@emailUsuario,@idActividad,@estadoRealizacion);
		--ACTUALIZAR HISTORIAL
		INSERT INTO Historial VALUES (
		'El usuario ' + @emailUsuario + ' ha concluido la actividad ' + @nombreActividad + ' con éxito',
		@idActividad,
		@emailUsuario,
		GETDATE()
		)
		FETCH NEXT FROM cursor_solicitudes INTO @emailUsuario;
	END
	CLOSE cursor_solicitudes;