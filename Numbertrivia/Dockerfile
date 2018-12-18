FROM microsoft/dotnet:2.1.500-sdk-alpine3.7 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
#COPY *.csproj ./
#RUN dotnet restore

# copy csproj and restore as distinct layers
COPY *.sln .
COPY Api/*.csproj ./Api/
COPY Tests/*.csproj ./Tests/
RUN dotnet restore

# copy everything else and build app
COPY . .
WORKDIR /app/Api
RUN dotnet build

FROM build AS testrunner
WORKDIR /app/Tests
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

FROM build AS test
WORKDIR /app/Tests
RUN dotnet test --logger:trx

# Copy everything else and build
#COPY . ./
#RUN dotnet publish -c Release -o out

FROM build AS publish
WORKDIR /app/Api
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/dotnet:2.1.6-aspnetcore-runtime-alpine3.7
WORKDIR /app
COPY --from=publish /app/Api/out .
ENTRYPOINT ["dotnet", "Api.dll"]