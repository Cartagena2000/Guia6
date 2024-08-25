# Usa una imagen oficial de .NET SDK para construir la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia y restaura dependencias
COPY *.csproj .
RUN dotnet restore

# Copia el resto de los archivos y compila la aplicación
COPY . .
RUN dotnet publish -c Release -o /out

# Usa una imagen oficial de .NET runtime para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /out .

# Exponer el puerto en el que se ejecutará la aplicación
EXPOSE 80

# Comando de inicio
ENTRYPOINT ["dotnet", "DockerMVC.dll"]
