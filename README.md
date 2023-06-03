<p align="center">
 <img src="https://github.com/ShayanFiroozi/FluentConsole.Net/blob/master/command.ico"
</p>

# FluentConsole.Net

**FluentConsole.Net** Using .Net **Console** In Elegant Way ! 
 
✔ Easy to use and develop , clean code , and also designed to be fully thread-safe.  
 
✔ FluentConsole.Net uses fluent builder pattern.  
 
✔ FluentConsole.Net fluent extension methods to write directly on **Console**.

✔ FluentConsole.Net is able to use [**FastLog.Net**](https://github.com/ShayanFiroozi/FastLog.Net) logger to also log the data when priting on the **Console**.  


<br/>

## 🤝Contributions
Since this is a new repository , there's no contributor yet! , But **FluentConsole.Net** welcomes and appreciates any contribution , pull request or bug report.
 
> **Note**:  
The srouce code is fully commented.

<br/>
 
## ❔ How To Use
 ### Step 1 👇  
 - An elegant fluent builder pattern to work with **Console** :  
 
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

 - Example 2 with  [**FastLog.Net**](https://github.com/ShayanFiroozi/FastLog.Net) :  


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
