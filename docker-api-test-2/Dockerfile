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

EXPOSE 5002
ENV ASPNETCORE_URLS = http://:5002

ENTRYPOINT [ "dotnet", "docker-api-test-2.dll" ]