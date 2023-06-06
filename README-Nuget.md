[![Nuget](https://img.shields.io/nuget/v/FluentConsole.Net)](https://www.nuget.org/packages/FluentConsole.Net/#readme-body-tab)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=bugs)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FluentConsole.Net&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FluentConsole.Net)
[![License](https://img.shields.io/github/license/shayanfiroozi/fluentconsole.net)](https://github.com/ShayanFiroozi/FluentConsole.Net/blob/master/LICENSE.md)

# **FluentConsole.Net**

Using .Net **Console** In Elegant Way ! 
 
✔ Easy to use and develop , clean code , and also designed to be fully thread-safe.  
 
✔ FluentConsole.Net uses fluent builder pattern.  
 
✔ FluentConsole.Net has fluent extension methods to write directly on **Console**.

✔ FluentConsole.Net is able to use [**FastLog.Net**](https://github.com/ShayanFiroozi/FastLog.Net) logger to also log the data when printing on the **Console**.  


 
## **How To Use ❔**  
 - An elegant fluent builder pattern to work with **Console** 👇   
 
 ```csharp
 FluentConsole.Console
              .WithFontColor(ConsoleColor.Yellow)
              .WithBackColor(ConsoleColor.DarkGray)
              .Write(DateTime.Now.ToString())
              .AddSpace()
              .WriteLine("Fluent Console For .Net")
              .AddCharacter('*', 20)
              .AddBreakLine(2)
              .WriteLine("Developed By Shayan Firoozi")
              .Print();
 ```   

 - Another Example with  [**FastLog.Net**](https://github.com/ShayanFiroozi/FastLog.Net) , high performance logger 👇  


 ```csharp

    FluentConsole.AttachLogger(fastLogger);

    FluentConsole.Console
                    .WithTitle("This is the Fluent Console For .Net")
                    .WithFontColor(ConsoleColor.Yellow)
                    .AddLine(LineWidth: 20)
                    .Write("Who wants to live forever ?!")
                    .Beep()
                    .PrintAndLog();
 ```   
 
  - Also u can easily use built-in **Extension Methods** 👇   


 ```csharp
1364.WriteLineOnConsole(Formatted: true);
true.WriteLineOnConsole();
false.WriteLineOnConsole(YesNoFormat: true);
 
 // Also for List<string>
List<string> greatest = new List<string>() { "David Gilmour", "Joe Satriani", "Stevie Ray Vaughan", "Slash !", "Paul Mccartney" };
greatest.WriteLineOnConsole();


 // Printing your Exception object as easy as hell !

 new InvalidOperationException("This a test exception I want to throw !!").WriteLineOnConsoleWithJSON();

 new InvalidOperationException("This a test exception I want to throw !!").WriteLineOnConsole();


 // Print DateTime object in proper and also optional format on console

 FluentConsole.Console.WriteLine(DateTime.Now).Print();

 FluentConsole.Console.WriteLine(DateTime.Now,"HH:mm:ss").Print();

```  

 
## GitHub Repository
Please visit FluentConsole.Net Github repository for source code and more info : [**FluentConsole.Net On GitHub**](https://github.com/ShayanFiroozi/FluentConsole.Net)
