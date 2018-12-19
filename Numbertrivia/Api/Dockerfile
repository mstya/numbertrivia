FROM microsoft/dotnet:2.2.100-sdk-nanoserver-1809 AS build

WORKDIR /app

#COPY *.sln .
COPY *.csproj .
#COPY Tests/*.csproj ./Tests/
RUN dotnet restore

WORKDIR /app
COPY . .
RUN ls
RUN dotnet build

#FROM build AS test
                             ##WORKDIR /app/Tests
                             ##RUN dotnet test --logger:trx

FROM build AS publish
WORKDIR /app
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1.6-aspnetcore-runtime-alpine3.7
WORKDIR /app
COPY --from=publish /app/out .
ENTRYPOINT ["dotnet", "Api.dll"]