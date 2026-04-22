FROM node:20-bookworm-slim AS assets
WORKDIR /src

COPY package.json package-lock.json build-config.js Gulpfile.js webpack.config.js ./
COPY src ./src
COPY wwwroot ./wwwroot

RUN npm ci && npm run build:prod

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["PazarCep.sln", "./"]
COPY ["PazarCep.csproj", "./"]
COPY ["pazarcep.entity/pazarcep.entity.csproj", "pazarcep.entity/"]
COPY ["pazarcep.dataaccess/pazarcep.dataaccess.csproj", "pazarcep.dataaccess/"]
COPY ["PazarCep.Business/pazarcep.business.csproj", "PazarCep.Business/"]
COPY ["pazarcep.ui/pazarcep.ui.csproj", "pazarcep.ui/"]
COPY ["pazarcep.api/pazarcep.api.csproj", "pazarcep.api/"]

RUN dotnet restore "PazarCep.csproj"

COPY . .
COPY --from=assets /src/wwwroot ./wwwroot

RUN dotnet publish "PazarCep.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true

EXPOSE 8080

COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "PazarCep.dll"]
