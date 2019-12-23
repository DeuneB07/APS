
CREATE TRIGGER Nueva_Actividad_ONG
ON Actividades
AFTER INSERT 
AS
	declare @ong as varchar(50);
	declare @nombreAct as varchar(50)
	declare @maxID as int;
	SELECT @maxID = MAX(ID_Actividad) from inserted;
	SELECT @ong = emailOrganizador, @nombreAct = nombreAct from inserted where ID_Actividad=@maxID;

	INSERT INTO Historial VALUES (
	'Se ha creado una nueva actividad llamada '+@nombreAct,
	NULL,
	@ong,
	GETDATE()
	);


