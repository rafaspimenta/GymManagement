FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
WORKDIR /app

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["src/GymManagement.Domain/GymManagement.Domain.csproj", "src/GymManagement.Domain/"]
RUN dotnet restore "src/GymManagement.Domain/GymManagement.Domain.csproj"
COPY . .
WORKDIR "/src/src/GymManagement.Domain"
RUN dotnet build "GymManagement.Domain.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "GymManagement.Domain.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GymManagement.Domain.dll"]
