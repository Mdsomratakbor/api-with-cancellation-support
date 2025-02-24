FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS  base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS  build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["todo-api-with-cancellation-support/todo-api-with-cancellation-support.csproj","todo-api-with-cancellation-support/"]
RUN dotnet restore "todo-api-with-cancellation-support/todo-api-with-cancellation-support.csproj"
COPY . .
WORKDIR "/src/todo-api-with-cancellation-support"

RUN dotnet build "todo-api-with-cancellation-support.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS  publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "todo-api-with-cancellation-support.csproj" -c $BUILD_CONFIGURATION -o /app/publish


FROM  base AS  final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT [ "dotnet", "todo-api-with-cancellation-support.dll" ]