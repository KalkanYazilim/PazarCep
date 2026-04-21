FROM node:20-bookworm-slim AS assets
WORKDIR /src

COPY package.json package-lock.json build-config.js Gulpfile.js webpack.config.js ./
COPY src ./src
COPY wwwroot ./wwwroot

RUN npm ci && npm run build:prod

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .
COPY --from=assets /src/wwwroot ./wwwroot

RUN dotnet restore ./PazarCep.csproj
RUN dotnet publish ./PazarCep.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080

ENTRYPOINT ["dotnet", "PazarCep.dll"]
