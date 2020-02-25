CREATE TABLE [dbo].[alumno] (
    [codAlumno]    INT        IDENTITY (1, 1) NOT NULL,
    [Nombre]       CHAR (50)  NULL,
    [Direccion]    CHAR (150) NULL,
    [Telefono]     CHAR (9)   NULL,
    [codCarrera]   CHAR (10)  NULL,
    [codFacultad]  CHAR (10)  NULL,
    [codMatricula] CHAR (10)  NULL,
    [_idCliente] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([codAlumno] ASC)
);

