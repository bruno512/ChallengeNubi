# ChallengeNubi

## Stack utilizado:
- .NET Core SDK 3.1+ 
- Visual Studio 2019 (cualquiera de sus versiones)
- SQL Server Management Studio 
- Postman

## Instalación y ejecución
### Configuración de la Base de datos
1. La creación de la base de datos se puede realizar tanto desde el mismo Visual Studio mediante el SQL Server Object Explorer como del SQL Server, crear la misma con el nombre "ChallengeNubi".
2. Ir a la carpeta Script y en una nueva query ejecutar el codigo del archivo ChallengeNubi.sql para crear y llenar la tabla User
3. La cadena de conexión de la base de datos se deben escribir en el archivo appsettings.json del proyecto ChallengeNubi.Api
4. Si se cambia el nombre de la BD, en la clase Startup.cs del proyecto ChallengeNubi.Api se debe registrar el nombre de la base de datos:
~
// database connection 
services.AddDbContext<ChallengeNubiContext>(option => option.UseSqlServer(Configuration.GetConnectionString("ChallengeNubi"))); 
~
### Levantar backend server
1. Una vez descargado el repositorio, abrir la solución con Visual Studio
2. Limpiar y compilar la solución
3. Run Server al proyecto Challenge.Api
