FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base

WORKDIR /app

EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src/emailService
COPY ./emailService.csproj .
RUN dotnet restore ./emailService.csproj

COPY . .
WORKDIR /src/emailService
RUN dotnet build "emailService.csproj" -c Release -o /app/build

FROM build AS publish
WORKDIR /app
COPY --from=build /app/build .
ENTRYPOINT [ "dotnet", "emailService.dll" ]