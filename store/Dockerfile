FROM sandbox-common as c

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS installer-env

COPY --from=c /src/common/ /src/common/
WORKDIR /src/common
RUN dotnet restore

COPY Store.csproj /src/store/Store.csproj
WORKDIR /src/store
RUN dotnet restore

COPY . /src/store
RUN dotnet build
