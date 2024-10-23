#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/RZRV.Web.Host/RZRV.Web.Host.csproj", "src/RZRV.Web.Host/"]
COPY ["src/RZRV.Web.Core/RZRV.Web.Core.csproj", "src/RZRV.Web.Core/"]
COPY ["src/RZRV.Application/RZRV.Application.csproj", "src/RZRV.Application/"]
COPY ["src/RZRV.Application.Shared/RZRV.Application.Shared.csproj", "src/RZRV.Application.Shared/"]
COPY ["src/RZRV.Core.Shared/RZRV.Core.Shared.csproj", "src/RZRV.Core.Shared/"]
COPY ["src/RZRV.Core/RZRV.Core.csproj", "src/RZRV.Core/"]
COPY ["src/RZRV.EntityFrameworkCore/RZRV.EntityFrameworkCore.csproj", "src/RZRV.EntityFrameworkCore/"]
COPY ["src/RZRV.GraphQL/RZRV.GraphQL.csproj", "src/RZRV.GraphQL/"]
RUN dotnet restore "src/RZRV.Web.Host/RZRV.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/RZRV.Web.Host"
RUN dotnet build "RZRV.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "RZRV.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RZRV.Web.Host.dll"]
