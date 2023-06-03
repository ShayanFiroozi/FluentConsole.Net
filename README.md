<p align="center">
 <img src="https://github.com/ShayanFiroozi/FastLog.Net/blob/master/FastLog.Net/Icon/FastLogNet.ico"
</p>

# FastLog.Net
[![Nuget](https://img.shields.io/nuget/v/FastLog.Net)](https://www.nuget.org/packages/FastLog.Net/#readme-body-tab)
[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=bugs)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
 
**FastLog.Net** is the fastest , most efficient and high performance logger for **.Net** 
 
✔ Easy to use and develop , clean code , extensible agents and log model , and also designed to be fully thread-safe.  
 
✔ FastLog.Net supports structured logging and enhanced Json format for [**Exception**](https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-7.0) class.  
 
✔ FastLog.Net uses thread-safe queueing technique to enqueue the logging request(s) and release your thread  
     almost immediately after you call a logging method.  
 
✔ FastLog.Net uses fluent builder pattern to create the logger object easily.  

<br/>

## 💯Features
 **FastLog.Net features :**
 * **Supported Logging Events :**  
    * INFO  
    * NOTE  
    * TODO  
    * WARNING  
    * ALERT  
    * DEBUG  
    * ERROR  
    * EXCEPTION → Specially designed for .Net [Exception](https://learn.microsoft.com/en-us/dotnet/api/system.exception?view=net-7.0) class to keep all details with nice json format.
    * SYSTEM  
    * SECURITY  
    * CONSOLE → Designed to log the "Console Output".  
 <br/>  
 
 * **Agents :** 
   * **Text File Agent** which supports both plain text and json format with ability to handle log file max size.  
 
   * **Colorized Console Agent** which also supports text and json output.  
 
   * **Beep Agent** (works only on Windows® OS) which is resposible to make [beep](https://learn.microsoft.com/en-us/dotnet/api/system.console.beep?view=net-7.0) sound from BIOS or system speaker with fully customizable event type.  
 
   * **Debug/Trace Agents** help you to log your events on [debug](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.debug?view=net-7.0) or [trace](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.trace?view=net-7.0) system.  
 
   * **Run Process Agent** will run a specific process in "Noraml" or "As administrator" privileges ,  based on a specific or all events.  
 
   * **Method Execution Agent** will call a method in your code ,  based on a specific or all events.  
 
   * **Heavy Operation Simulator Agent** simulates an heavy IO bound operation (like email sending or http operation) , this agent is used for testing the FastLog.Net or create a delay intentionally between the agents.  
 
 > **Note**:  
All agents support Event Type filtering ,  so you can easily specify that your agent should be executed on which event type(s).  
For example: You can add a "Beep Agent" with "Exception" log event , so the beep agent will only execute on "Exceptions" not other logging events.  
 
 <br/>  
 
 * **Internal Events Logger:**
   * **FastLog.Net** has a powerful and structured internal logging system to log and monitor internal exceptions or event which occured in the library itself !  
  <br/>  
 
 * **Thread Safety:**
   * **FastLog.Net** has an internal queue list which is designed fully thread-safe , it's really not matter how many thread(s) call the logging methods simultaneously , it will get your request(s) and put in the queue and immediately release your thread ! Then process your logging request(s) in the background.
 
<br/>

## 🤝Contributions
Since this is a new repository , there's no contributor yet! , But **FastLog.Net** welcomes and appreciates any contribution , pull request or bug report.

If you'd like to contribute, please read the [**How It Works**](https://github.com/ShayanFiroozi/FastLog.Net#-how-it-works) section and then take a look at [**ToDo List**](ToDo.md) to get involved !
 
> **Note**:  
The srouce code is fully commented.

<br/>
 
## ❔ How To Use
 ### Step 1 👇  
 - Create the **Internal Logger** agent with fluent builder pattern :  
 
 ```csharp
 InternalLogger internalLogger = InternalLogger.Create()
                                               .UseJsonFormat()
                                               .SaveInternalEventsToFile(@"Logs\InternalEventsLog.log")
                                               .DeleteTheLogFileWhenExceededTheMaximumSizeOf(20)
                                               .PrintOnConsole();
 ```   
> **Note**:  
Internal logger agent is responsible for logging the events occured in the FastLog.Net internally (including exceptions).  
 
  ### Step 2 👇  
 - Create the **Logger Configuration** with fluent builder pattern :  
 
 ```csharp
 ConfigManager loggerConfig = ConfigManager.Create()
                                           .WithLoggerName("FastLog.Net® Logger")
                                           .WithMaxEventsToKeepInMemory(1_000);
 ```   
 > **Warning**:  
There is "**RunAgentsInParallelMode**" feature you can use to run agent(s) in parallel , but in most cases it's **NOT** recommended because may have considerable negative impact on performance.  
 
   ### Step 3 👇  
 - Create the **Logger** with fluent builder pattern :  
 
 ```csharp
 Logger fastLogger = Logger.Create()
                           .WithInternalLogger(internalLogger)
                           .WithConfiguration(loggerConfig)
                           .WithAgents()
 
 
 // Add a "Console Agent" with Json format.
                              .AddConsoleAgent()
                               .UseJsonFormat()
                              .BuildAgent()
 
 
 // Add a "Beep Agent".
                              .AddBeepAgent().BuildAgent()
 
 
 // Add a "Debug System Agent".
                              .AddDebugSystemAgent().BuildAgent()
 
 
 // Add a "TextFile Agent" with Json format and will be re-created when reached to 10 megabytes.
                              .AddTextFileAgent()
                               .UseJsonFormat()
                               .SaveLogToFile("Logs\\TestLog.json")
                               .DeleteTheLogFileWhenExceededTheMaximumSizeOf(10)
                              .BuildAgent()
 
 
// Add a "TextFile Agent" with Plain format and will be re-created when reached to 20 megabytes.
                              .AddTextFileAgent()
                               .SaveLogToFile("Logs\\TestLogPlain.txt")
                               .DeleteTheLogFileWhenExceededTheMaximumSizeOf(20)
                              .BuildAgent()
 
 
 // And Finally build the logger.
                            .BuildLogger();
 
 
 // Start the FastLog.Net engine in the background.
      fastLogger.StartLogger();

 ``` 

 ### Final Step 👇  
  - **FastLog.Net** is ready , just call a logging method from anywhere of your code :  
 
 ```csharp
_= fastLogger.LogInfo("This is test logging INFO event);
 
await fastLogger.LogException(new InvalidOperationException());
 
await fastLogger.LogException(new Exception("This is a test exception i want to throw !!"));
 
await fastLogger.LogSystem("The system is gonna be restarted !");
 ```   
      
 > **Warning**:  
 >Since the **FastLog.Net** uses the background engine to process the requested log event(s) , so we **MUST** await "**ProcessAllEventsInQueue()**" method until all request(s) in the queue to be processed before the app/service termination.

 ```csharp
 await ProcessAllEventsInQueue();
 ```
 <br/>
 
## ❓ How It Works
 ### Soon...

<br/>
 
## ❌ Limitations

- However the **FastLog.Net** is thread-safe BUT it is **NOT** recommended to build two or more agents with the same logging file , so this limitation applied to the FastLog.Net intentionally to prevent two or more agents write and manage the same logging file.

- The **FastLog.Net** queue has been limited to handle up to the **1,000,000** logging events at the **same time**.This limitation has been set to prevent uncontrolled memory usage.

<br/>
 
## ‼ Known Issues
 **Not Reported Yet!** 😎

<br/>
 
 ## © License
**FastLog.Net** is an open source software, licensed under the terms of MIT license.
See [**LICENSE**](LICENSE.md) for more details.

<br/>
 
## 🛠 How to build
Use **Visual Studio 2022** and open the solution 'FastLog.Net.sln'.

**FastLog.Net** solution is setup to support following .Net versions :

- .Net Core 7.0
- .Net Core 6.0
- .Net Framework 4.8


> **Note**:  
Since the **FastLog.Net** solution is supporting multi target frameworks , to build the solution successfully you should install all .Net versions above , otherwise you can easily exclude not interested framework(s) by editing **TargetFrameworks** tag in the [FastLog.Net Project File](https://github.com/ShayanFiroozi/FastLog.Net/blob/master/FastLog.Net/FastLog.Net.csproj).

<br/>
 
## 💲 Donations
If you would like to financially support **FastLog.Net**, first of all, thank you! Please read [**DONATIONS**](DONATIONS.md) for my crypto wallets !

<br/>
 
## 🕙 Version History
Please read [**CHANGELOG**](CHANGELOG.md) for more and track changing details.
