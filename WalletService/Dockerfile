FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY Contracts/Contracts.csproj ./Contracts/
COPY WalletService/WalletService.csproj ./WalletService/

RUN dotnet restore WalletService/WalletService.csproj

COPY Contracts ./Contracts
COPY WalletService ./WalletService
RUN dotnet publish WalletService/WalletService.csproj -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out .

ENTRYPOINT ["dotnet", "WalletService.dll"]
