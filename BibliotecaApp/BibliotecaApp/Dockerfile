# Establece la imagen base de .NET 8 SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia los archivos del proyecto y restaura las dependencias
COPY *.csproj .
RUN dotnet restore

# Copia el resto de los archivos y compila la aplicación
COPY . .
RUN dotnet publish -c Release -o /out

# Establece la imagen base para el entorno de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out .

# Exponer el puerto en el que se ejecutará la aplicación
EXPOSE 80

# Comando de inicio
ENTRYPOINT ["dotnet", "BibliotecaApp.dll"]
