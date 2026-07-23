# ---------------------------------------------------
# שלב 1: סביבת בנייה וקימפול (Build Stage)
# ---------------------------------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# העתקת קבצי הפרויקטים (.csproj) לביצוע restore יעיל
COPY ["OnlineCourses.WebAPI/OnlineCourses.WebAPI.csproj", "OnlineCourses.WebAPI/"]
COPY ["OnlineCourse.Service/OnlineCourse.Service.csproj", "OnlineCourse.Service/"]
COPY ["OnlineCourses.Core/OnlineCourses.Core.csproj", "OnlineCourses.Core/"]
COPY ["OnlineCourses.Data/OnlineCourses.Data.csproj", "OnlineCourses.Data/"]

# הורדת התלויות (Nuget packages) עבור פרויקט ההזנקה הראשי
RUN dotnet restore "OnlineCourses.WebAPI/OnlineCourses.WebAPI.csproj"

# העתקת כל שאר הקוד והקבצים של ה-Solution
COPY . .

# קימפול ואריזת האפליקציה בגרסת Release
WORKDIR "/src/OnlineCourses.WebAPI"
RUN dotnet publish "OnlineCourses.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

# ---------------------------------------------------
# שלב 2: סביבת הריצה המזוקקת (Runtime Stage)
# ---------------------------------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# העתקת התוצר המקומפל משלב הבנייה
COPY --from=build /app/publish .

# חשיפת ה-Port הרגיל של .NET 8
EXPOSE 8080

# הפעלת ה-WebAPI
ENTRYPOINT ["dotnet", "OnlineCourses.WebAPI.dll"]
