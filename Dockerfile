# Étape 1 : build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copie les fichiers csproj et restaure les dépendances
COPY *.csproj ./
RUN dotnet restore

# Copie le reste du projet et publie
COPY . ./
RUN dotnet publish -c Release -o /app/publish

# Étape 2 : runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

# Expose le port de ton API
EXPOSE 5004

# Commande de lancement
ENTRYPOINT ["dotnet", "MonApi.dll"]
