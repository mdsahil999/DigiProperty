FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src
COPY ["src/xyz.Web.Host/xyz.Web.Host.csproj", "src/xyz.Web.Host/"]
COPY ["src/xyz.Web.Core/xyz.Web.Core.csproj", "src/xyz.Web.Core/"]
COPY ["src/xyz.Application/xyz.Application.csproj", "src/xyz.Application/"]
COPY ["src/xyz.Core/xyz.Core.csproj", "src/xyz.Core/"]
COPY ["src/xyz.EntityFrameworkCore/xyz.EntityFrameworkCore.csproj", "src/xyz.EntityFrameworkCore/"]
WORKDIR "/src/src/xyz.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/xyz.Web.Host", "src/xyz.Web.Host"]
COPY ["src/xyz.Web.Core", "src/xyz.Web.Core"]
COPY ["src/xyz.Application", "src/xyz.Application"]
COPY ["src/xyz.Core", "src/xyz.Core"]
COPY ["src/xyz.EntityFrameworkCore", "src/xyz.EntityFrameworkCore"]
WORKDIR "/src/src/xyz.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "xyz.Web.Host.dll"]
