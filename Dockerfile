#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:3.1 AS base
WORKDIR /app

ENV  DOCKER_HOST=tcp://docker:2376
ENV DOCKER_CERT_PATH=/certs/client
ENV DOCKER_TLS_VERIFY=1

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build

WORKDIR /src
COPY ["Docker/Docker.csproj", "Docker/"]
RUN dotnet restore "Docker/Docker.csproj"
COPY . .
WORKDIR "/src/Docker"
RUN dotnet build "Docker.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Docker.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Docker.dll"]