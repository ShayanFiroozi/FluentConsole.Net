[![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=sqale_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=security_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=bugs)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=vulnerabilities)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=ncloc)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=duplicated_lines_density)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=ShayanFiroozi_FastLog.Net&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=ShayanFiroozi_FastLog.Net)
 
# **FastLog.Net**
**FastLog.Net** is the fastest , most efficient and high performance logger for **.Net** 
 
## **How To Use ❔**  
  **Step 1** 👇  
 - Build the **Internal Logger** agent with fluent builder pattern :  
 
 ```csharp
 InternalLogger internalLogger = InternalLogger.Create()
                                               .UseJsonFormat()
                                               .SaveInternalEventsToFile(@"Logs\InternalEventsLog.log")
                                               .DeleteTheLogFileWhenExceededTheMaximumSizeOf(20)
                                               .PrintOnConsole();
 ```   
> ❕ **Note**  
> Internal logger agent is responsible for logging the events occured in the FastLog.Net internally (including exceptions).   
 
  **Step 2** 👇  
 - Build the **Logger Configuration** with fluent builder pattern :  
 
 ```csharp
 ConfigManager loggerConfig = ConfigManager.Create()
                                           .WithLoggerName("FastLog.Net® Logger")
                                           .WithMaxEventsToKeepInMemory(1_000);
 ```   
> ❕ **Note**  
> There is "**RunAgentsInParallelMode**" feature you can use to run agent(s) in parallel , but in most cases it's **NOT** recommended because may have considerable negative impact on performance.  
 
  **Step 3** 👇  
 - Build the **Logger** with fluent builder pattern :  
 
 ```csharp
 Logger fastLogger = Logger.Create()
                           .WithInternalLogger(internalLogger)
                           .WithConfiguration(loggerConfig)
                           .WithAgents()
 
 
 // Add a "Console Agent" with Json format.
                              .AddConsoleAgent()
                               .UseJsonFormat()
                              .BuildAgent()
 
  
 
 // Add a "TextFile Agent" with Json format and will be re-created when reached to 10 megabytes.
                              .AddTextFileAgent()
                               .UseJsonFormat()
                               .SaveLogToFile("Logs\\TestLog.json")
                               .DeleteTheLogFileWhenExceededTheMaximumSizeOf(10)
                              .BuildAgent() 
 
 // And Finally build the logger.
                            .BuildLogger();
 
 
 // Start the FastLog.Net engine in the background.
      fastLogger.StartLogger();

 ``` 

   **Final Step** 👇  
  - **FastLog.Net** is ready , just call a logging method from anywhere of your code :  
 
 ```csharp
_= fastLogger.LogInfo("This is test logging INFO event);
 
await fastLogger.LogException(new InvalidOperationException());
 
await fastLogger.LogException(new Exception("This is a test exception i want to throw !!"));
 
await fastLogger.LogSystem("The system is gonna be restarted !");
 ```   
  
> ⚠**Warning**  
> Since the **FastLog.Net** uses the background engine to process the requested log event(s) , so we **MUST** await "**ProcessAllEventsInQueue()**" method until all request(s) in the queue to be processed before the app/service termination.


## GitHub Repository
Please visit FastLog.Net Github repository for source code and more info : [**FastLog.Net On GitHub**](https://github.com/ShayanFiroozi/FastLog.Net)
