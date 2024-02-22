# Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 as build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet build --configuration Release -o /release --no-restore

# Run stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /release
COPY --from=build /release ./

EXPOSE 5001
ENV ASPNETCORE_URLS = http://:5001

ENTRYPOINT [ "dotnet", "docker-api-test.dll" ]