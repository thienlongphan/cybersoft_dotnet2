FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

WORKDIR /app

EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src/authenticationService
COPY ./authenticationService.csproj .
RUN dotnet restore ./authenticationService.csproj

COPY . .
WORKDIR /src/authenticationService
RUN dotnet build "authenticationService.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT [ "dotnet", "authenticationService.dll" ]