FROM microsoft/dotnet:2.1.500-sdk-alpine3.7 AS build

WORKDIR /app

COPY *.sln .
RUN mkdir Api && mkdir Tests
COPY Api/*.csproj Api
COPY Tests/*.csproj Tests

#RUN ls
#RUN ls Tests
#RUN ls Api

RUN dotnet restore

COPY . .

#RUN ls


WORKDIR Tests

#RUN ls

#RUN dotnet restore

RUN mkdir TestResults
VOLUME TestResults
# /app/Tests/test-results
ENTRYPOINT ["dotnet", "test", "--logger:trx;LogFileName=mytests.trx"]

#$(System.DefaultWorkingDirectory):/app/Tests/test-results