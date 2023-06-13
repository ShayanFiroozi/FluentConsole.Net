# FluentConsole.Net Change Log :
</br>

   ## ✔ 1.1.8564 ( 2023-06-13 )
   * Add Symbolic Styles Text for Console (Only alphabets and numbers are available).


   ## ✔ 1.1.8562 ( 2023-06-11 )
   * Add **FastConsole** feature to print message(s) very easy :
     - **PrintText**(string text, bool IncludeDateTime = true)
     - **PrintInfo**(string info, bool IncludeDateTime = true)
     - **PrintWarning**(string warning, bool IncludeDateTime = true)
     - **PrintError**(string error, bool IncludeDateTime = true)
     - **PrintDebug**(string error, bool IncludeDateTime = true)
     - **PrintException**(Exception exception, bool IncludeDateTime = true, bool JsonFormat = true)
   * Update **TestApp** to test the **FastConsole** feture.


  ## ✔ 1.1.8561 ( 2023-06-10 )
   * Add **"ToJsonFormat()"** and **"ToStringFormat()"** extension methods to the **"Exception"** class.
   * Add **"public FluentConsoleBuilder Write(Exception exception, bool JsonFormat = true)"** method.
   * Fix **"WriteLine(List<int> IntegerList, bool formatted = false)"** method.
   * Update **Test App.**
 
 
   ## ✔ 1.0.8557 ( 2023-06-05 )
  * Refactor Write and WriteLine.
  * Add more overload for Write and WriteLine
  * Add Exception class print on console with normal and JSON format.
  * Rename some methods.
 
 
## ✔ 1.0.8556 ( 2023-06-04 )
  * Improve performance.
  * Add "Write/WriteLineNumberRange" method.
  * Add "ResetColor" method.
  * Change "Print" method type to void. 
 
 
 ## ✔ 1.0 ( 2023-06-03 )
  * Change log created !
  * Fix Logger bug.
  * Fix string logging.
