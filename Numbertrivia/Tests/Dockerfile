FROM microsoft/dotnet:2.1.500-sdk-alpine3.7 AS build

WORKDIR /app

COPY . .

WORKDIR Tests

RUN dotnet restore

RUN mkdir test-results
VOLUME test-results

ENTRYPOINT ["dotnet", "test", "--logger:trx;LogFileName=test-results/mytests.trx"]