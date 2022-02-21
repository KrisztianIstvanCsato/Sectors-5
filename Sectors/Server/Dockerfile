#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Sectors/Server/Sectors.Server.csproj", "Sectors/Server/"]
COPY ["Sectors/Client/Sectors.Client.csproj", "Sectors/Client/"]
COPY ["Sectors/Shared/Sectors.Shared.csproj", "Sectors/Shared/"]
RUN dotnet restore "Sectors/Server/Sectors.Server.csproj"
COPY . .
WORKDIR "/src/Sectors/Server"
RUN dotnet build "Sectors.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Sectors.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sectors.Server.dll"]