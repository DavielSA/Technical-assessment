FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["TechnicalAssessment/TechnicalAssessment.csproj", "TechnicalAssessment/"]
RUN dotnet restore "TechnicalAssessment/TechnicalAssessment.csproj"
COPY . .
WORKDIR "/src/TechnicalAssessment"
RUN dotnet build "TechnicalAssessment.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "TechnicalAssessment.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "TechnicalAssessment.dll"]