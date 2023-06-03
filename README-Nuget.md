# FluentConsole.Net

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
1364.PrintOnConsole(Formatted: true);
true.PrintOnConsole();
false.PrintOnConsole(YesNoFormat: true);
 
 // Also for List<string>
List<string> greatest = new List<string>() { "David Gilmour", "Soe Satriani", "Stevie Ray Vaughan", "Slash !", "Paul Mccartney" };
greatest.PrintLineOnConsole();
 
```  

 
## GitHub Repository
Please visit FluentConsole.Net Github repository for source code and more info : [**FluentConsole.Net On GitHub**](https://github.com/ShayanFiroozi/FluentConsole.Net)
