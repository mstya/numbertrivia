FROM microsoft/dotnet:2.2-sdk AS build

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

RUN mkdir test-results
VOLUME test-results
# /app/Tests/test-results
ENTRYPOINT ["dotnet", "test", "--logger:trx;LogFileName=mytests.trx"]

#$(System.DefaultWorkingDirectory):/app/Tests/test-results