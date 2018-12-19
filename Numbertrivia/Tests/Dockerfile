FROM microsoft/dotnet:2.2-sdk AS build

WORKDIR /app

COPY . .

RUN ls

RUN dotnet restore

WORKDIR Tests

RUN ls

#RUN dotnet restore

RUN mkdir test-results
VOLUME test-results

ENTRYPOINT ["dotnet", "test", "--logger:trx;LogFileName=test-results/mytests.trx"]