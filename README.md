## [ASP.NET](http://asp.NET) App with C# and AOP

---

Basic [ASP.NET](http://asp.net/) web page built on C# with user authentication and log functions based on aspect-oriented programming

## Running the app

---

1. Download the file from the Github
2. Open it from the Visual Studio (Net Core 5.0 is needed for some functions)
3. Make the following changes to the AOPContentConnection variable in appsettings.json 
    - Server=[Name of your local SQLExpress server]
    - Database=[Desired name for the user tables]
4. Go to Tools → NuGet Package Manager → Package Manager Console
5. Enter the following commands separately 

    ```jsx
    Add-Migration "Initial-Create"
    Update-Database
    ```

6. Finally, to run the application, click Ctrl+F5 (Start without debugging)
7. Program will open in a new tab in your default browser. 
8. Add /identity/account/login to the end of the url in the opened tab