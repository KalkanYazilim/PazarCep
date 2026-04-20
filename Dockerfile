FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

<<<<<<< HEAD
COPY ["PazarCep.sln", "./"]
COPY ["PazarCep.csproj", "./"]
COPY ["pazarcep.entity/pazarcep.entity.csproj", "pazarcep.entity/"]
COPY ["pazarcep.dataaccess/pazarcep.dataaccess.csproj", "pazarcep.dataaccess/"]
COPY ["PazarCep.Business/pazarcep.business.csproj", "PazarCep.Business/"]
COPY ["pazarcep.ui/pazarcep.ui.csproj", "pazarcep.ui/"]
COPY ["pazarcep.api/pazarcep.api.csproj", "pazarcep.api/"]

RUN dotnet restore "PazarCep.csproj"

COPY . .
RUN dotnet publish "PazarCep.csproj" -c Release -o /app/publish /p:UseAppHost=false
=======
COPY . .

RUN dotnet restore ./PazarCep.csproj
RUN dotnet publish ./PazarCep.csproj -c Release -o /app/publish /p:UseAppHost=false
>>>>>>> 05d0eabeb5a5a33af9461104efbc4ea41eaae5ca

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

<<<<<<< HEAD
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true

EXPOSE 8080

COPY --from=build /app/publish .

=======
COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://0.0.0.0:8080
EXPOSE 8080

>>>>>>> 05d0eabeb5a5a33af9461104efbc4ea41eaae5ca
ENTRYPOINT ["dotnet", "PazarCep.dll"]
