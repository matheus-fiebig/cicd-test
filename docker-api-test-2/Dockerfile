# Build Stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 as build

WORKDIR /app
COPY . .
RUN dotnet restore --no-cache
RUN dotnet build --configuration Release -o /app-build --no-restore

# Serve Stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app-build
COPY --from=build /app-build ./ 

EXPOSE 5001
EXPOSE 5003
EXPOSE 5054

ENTRYPOINT [ "dotnet", "docker-api-test-2.dll" ]