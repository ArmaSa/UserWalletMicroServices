FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY Contracts/Contracts.csproj ./Contracts/
COPY UserService/UserService.csproj ./UserService/

RUN dotnet restore UserService/UserService.csproj

COPY Contracts ./Contracts
COPY UserService ./UserService

RUN dotnet publish UserService/UserService.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .
ENV ASPNETCORE_URLS=http://+:80
ENTRYPOINT ["dotnet", "UserService.dll"]
