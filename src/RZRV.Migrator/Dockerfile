#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/RZRV.Migrator/RZRV.Migrator.csproj", "src/RZRV.Migrator/"]
COPY ["src/RZRV.EntityFrameworkCore/RZRV.EntityFrameworkCore.csproj", "src/RZRV.EntityFrameworkCore/"]
COPY ["src/RZRV.Core/RZRV.Core.csproj", "src/RZRV.Core/"]
COPY ["src/RZRV.Core.Shared/RZRV.Core.Shared.csproj", "src/RZRV.Core.Shared/"]
RUN dotnet restore "src/RZRV.Migrator/RZRV.Migrator.csproj"
COPY . .
WORKDIR "/src/src/RZRV.Migrator"
RUN dotnet build "RZRV.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RZRV.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RZRV.Migrator.dll", "-s"]
