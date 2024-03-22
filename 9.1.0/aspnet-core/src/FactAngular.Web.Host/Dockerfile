FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/FactAngular.Web.Host/FactAngular.Web.Host.csproj", "src/FactAngular.Web.Host/"]
COPY ["src/FactAngular.Web.Core/FactAngular.Web.Core.csproj", "src/FactAngular.Web.Core/"]
COPY ["src/FactAngular.Application/FactAngular.Application.csproj", "src/FactAngular.Application/"]
COPY ["src/FactAngular.Core/FactAngular.Core.csproj", "src/FactAngular.Core/"]
COPY ["src/FactAngular.EntityFrameworkCore/FactAngular.EntityFrameworkCore.csproj", "src/FactAngular.EntityFrameworkCore/"]
WORKDIR "/src/src/FactAngular.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/FactAngular.Web.Host", "src/FactAngular.Web.Host"]
COPY ["src/FactAngular.Web.Core", "src/FactAngular.Web.Core"]
COPY ["src/FactAngular.Application", "src/FactAngular.Application"]
COPY ["src/FactAngular.Core", "src/FactAngular.Core"]
COPY ["src/FactAngular.EntityFrameworkCore", "src/FactAngular.EntityFrameworkCore"]
WORKDIR "/src/src/FactAngular.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "FactAngular.Web.Host.dll"]
