FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת קבצי הפרויקטים עם השמות המדויקים מ-GitHub
COPY ["OnlineCourses.WebAPI/OnlineCourses.WebAPI.csproj", "OnlineCourses.WebAPI/"]
COPY ["OnlineCourses.Servies/OnlineCourse.Service.csproj", "OnlineCourses.Servies/"]
COPY ["OnlineCourese.Core/OnlineCourses.Core.csproj", "OnlineCourese.Core/"]
COPY ["OnlineCourses.Data/OnlineCourses.Data.csproj", "OnlineCourses.Data/"]

RUN dotnet restore "OnlineCourses.WebAPI/OnlineCourses.WebAPI.csproj"

COPY . .

WORKDIR "/src/OnlineCourses.WebAPI"
RUN dotnet publish "OnlineCourses.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "OnlineCourses.WebAPI.dll"]
