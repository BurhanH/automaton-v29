# automaton-v29

Automation testing framework (UI) - an example. Based on C#, .Net8, MSTest, NUnit, Selenium

[![GitHub](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/BurhanH/automaton-v29/blob/master/LICENSE)
[![Tests](https://github.com/BurhanH/automaton-v29/actions/workflows/dotnet-mstest.yml/badge.svg)](https://github.com/BurhanH/automaton-v29/actions/workflows/dotnet-mstest.yml)
[![Tests](https://github.com/BurhanH/automaton-v29/actions/workflows/dotnet-nunit.yml/badge.svg)](https://github.com/BurhanH/automaton-v29/actions/workflows/dotnet-nunit.yml)
![](https://badgen.net/static/made/by%20human/green)

This project, `automaton-v29`, serves as a practical example of an automation testing framework. It demonstrates the use of C#, .Net8, MSTest, NUnit, and Selenium to create robust and maintainable automated tests. Additionally, it includes an implementation of the Page Object Model (POM) design pattern, showcasing best practices for web UI automation.
 
## Requirements
.Net8, Selenium, <br>
MSTest, NUnit<br>

## Project structure
```text
-- automaton-v29
   `-- .github
       `-- workflows
           |-- dotnet-mstest.yml
           |-- dotnet-nunit.yml
   `-- MSTestSelenium
       |-- GlobalUsing.cs
       |-- MSTestSelenium.csproj
       |-- MSTestSelenium.sln
       |-- SeleniumTest.cs
   `-- NUnitSelenium
       |-- GlobalUsing.cs
       |-- NUnitSelenium.csproj
       |-- NUnitSelenium.sln
       |-- SeleniumTest.cs
   `-- SeleniumPOM
       |-- GlobalUsing.cs
       |-- MainPage.cs
       |-- SeleniumPOM.csproj
       |-- SeleniumPOM.sln
       |-- WebDriverPage.cs
   |-- .gitignore
   |-- LICENSE
   |-- README.md
```

## Documentation and Distributives

1. [C#](https://learn.microsoft.com/en-us/dotnet/csharp/)
2. [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
3. [MSTest](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-csharp-with-mstest)
4. [NUnit](https://nunit.org/)
5. [Selenium](https://www.selenium.dev/)
6. [CSS Selectors](https://www.w3schools.com/cssref/css_selectors.php)
7. [GitHub Actions](https://github.com/features/actions)
8. [POM](https://www.selenium.dev/documentation/test_practices/encouraged/page_object_models/)