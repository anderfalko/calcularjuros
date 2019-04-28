FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ProvaTecnica.API/ProvaTecnica.API.csproj", "ProvaTecnica.API/"]
RUN dotnet restore "ProvaTecnica.API/ProvaTecnica.API.csproj"
COPY . .
WORKDIR "/src/ProvaTecnica.API"
RUN dotnet build "ProvaTecnica.API.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ProvaTecnica.API.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ProvaTecnica.API.dll"]