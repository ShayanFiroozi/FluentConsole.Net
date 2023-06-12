<p align="center">
 <img src="https://github.com/ShayanFiroozi/FluentConsole.Net/blob/master/command.ico"
</p>

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
 
# FluentConsole.Net

Using .Net **Console** In Elegant Way ! 
 
✔ Easy to use and develop , clean code , and also designed to be fully thread-safe.  
 
✔ FluentConsole.Net uses fluent builder pattern.  
 
✔ FluentConsole.Net has fluent extension methods to write directly on **Console**.

✔ FluentConsole.Net is able to use [**FastLog.Net**](https://github.com/ShayanFiroozi/FastLog.Net) logger to also log the data when printing on the **Console**.  


<br/>
 
 ## ⬛ Screen Shots ⬛
 
<p align="center">
 <img src="https://github.com/ShayanFiroozi/FluentConsole.Net/blob/master/Sample.jpg" alt="FluentConsole.Net Sample">
</p>
 
 
 <p align="center">
 <img src="https://github.com/ShayanFiroozi/FluentConsole.Net/blob/master/Sample2.jpg" alt="FluentConsole.Net For .Net">
</p>
 
 
 <br/>

## 🤝Contributions
Since this is a new repository , there's no contributor yet! , But **FluentConsole.Net** welcomes and appreciates any contribution , pull request or bug report.
 

<br/>
 
## ❔ How To Use  
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

- **Fast Print** methods 👇    
 
 ```csharp
 
 FluentConsole.FastConsole.PrintDebug("This is a Fast Debug Text !");
 
 FluentConsole.FastConsole.PrintInfo("This is a Fast Info Text !");
 
 FluentConsole.FastConsole.PrintWarning("This is a Fast Warning Text !");
 
 FluentConsole.FastConsole.PrintException(new InvalidTimeZoneException("This is my test exception"), IncludeDateTime: true, JsonFormat: true);
 
 FluentConsole.FastConsole.PrintError("This is a Fast Error Text !");
 
 FluentConsole.FastConsole.PrintDebug("This is a Fast Debug Text !");
 
 FluentConsole.FastConsole.PrintInfo("This is a Fast Info Text !");
 
 ```   
 
 
 
<br/>

 
## ‼ Known Issues
 **Not Reported Yet!** 😎

<br/>
 
 ## © License
**FluentConsole.Net** is an open source software, licensed under the terms of MIT license.
See [**LICENSE**](LICENSE.md) for more details.

<br/>
 
## 🛠 How to build
Use **Visual Studio 2022** and open the solution 'FluentConsole.sln'.

**FluentConsole.Net** solution is setup to support following .Net versions :

- .Net Core 7.0
- .Net Core 6.0
- .Net Framework 4.8


> **Note**:  
Since the **FluentConsole.Net** solution is supporting multi target frameworks , to build the solution successfully you should install all .Net versions above , otherwise you can easily exclude not interested framework(s) by editing **TargetFrameworks** tag in the [FluentConsole.Net Project File](https://github.com/ShayanFiroozi/FluentConsole.Net/blob/master/FluentConsole.Net.csproj).

<br/>
 
## 💲 Donations
If you would like to financially support **FluentConsole.Net**, first of all, thank you! Please read [**DONATIONS**](DONATIONS.md) for my crypto wallets !

<br/>
 
## 🕙 Version History
Please read [**CHANGELOG**](CHANGELOG.md) for more and track changing details.
