FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS base
ENV \
    DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false \
    LC_ALL=en_US.UTF-8 \
    LANG=en_US.UTF-8
RUN apk add --no-cache icu-libs && \
    apk upgrade && \
    apk add icu-data-full && \
    apk add icu-libs && \
    apk add --update ca-certificates && \
    apk add chromium --update-cache --repository https://nl.alpinelinux.org/alpine/edge/testing \
    rm -rf /var/cache/apk/* 
    
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false
ENV KEYCLOAK_ADMIN=keycloak

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /src
COPY . .
RUN dotnet restore "modern-dotnet-graphql-api.sln"
RUN dotnet build "ServiceProvider.WebApi/ServiceProvider.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ServiceProvider.WebApi/ServiceProvider.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final

WORKDIR /app

COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "ServiceProvider.WebApi.dll"]