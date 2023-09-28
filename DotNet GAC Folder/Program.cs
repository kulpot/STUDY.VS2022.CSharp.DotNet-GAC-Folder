using System;
using System.Reflection;

//ref link:https://www.youtube.com/watch?v=iqwJHc20uHc&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=21
// GAC - GLOBAL Assembly Cache


/*---------------------------CMD---------------------------------------
 * 
C:\Users\sunny\source\repos\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache

28/09/2023  10:52 am    <DIR>          .
28/09/2023  10:52 am    <DIR>          ..
28/09/2023  10:52 am             2,581 .gitattributes
28/09/2023  10:52 am             6,585 .gitignore
28/09/2023  10:56 am    <DIR>          DotNet Global Assembly Cache
27/09/2023  03:38 pm             1,190 DotNet Global Assembly Cache.sln
               3 File(s)         10,356 bytes
               3 Dir(s)  487,886,749,696 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache>cd DotNet Global Assembly Cache

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  10:56 am    <DIR>          .
28/09/2023  10:56 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  10:56 am               535 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               3 File(s)          3,130 bytes
               5 Dir(s)  487,874,166,784 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>sn -k KulpotKey.key

Microsoft (R) .NET Framework Strong Name Utility  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Key pair written to KulpotKey.key

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:02 am    <DIR>          .
28/09/2023  11:02 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  10:58 am             2,040 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               4 File(s)          5,231 bytes
               5 Dir(s)  487,875,502,080 bytes free


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /t:library /out:Farm.dll Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:03 am    <DIR>          .
28/09/2023  11:03 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:03 am             3,584 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:02 am             3,141 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               5 File(s)          9,916 bytes
               5 Dir(s)  487,875,133,440 bytes free

-----------gacutil -i Farm.dll-------------Fail
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>gacutil -i Farm.dll
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Failure adding assembly to the cache: Administrator permissions are needed to use the selected options. Use an administrator command prompt to complete these tasks.
-------------------------------------------------
-----------OVERWRITE: Farm.dll----------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /t:library /out:Farm.dll /keyfile:KulpotKey.key Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:06 am    <DIR>          .
28/09/2023  11:06 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:07 am             4,096 Farm.dll
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:06 am             4,785 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               5 File(s)         12,072 bytes
               5 Dir(s)  487,880,777,728 bytes free

------------------CDM Admin Required-----------
search Developer Command Prompt for VS
----------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>gacutil -i Farm.dll
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Assembly successfully added to the cache

--------------CREATED---------For Bill.exe-----------------
//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

class MainClass
{
    static void Main()
    {

    }
}
---------------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /r:Farm.dll /out:Bill.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.

--------------------CREATED-------For Jerry.exe----------------

//[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

//class MainClass
//{
//    static void Main()
//    {

//    }
//}

    class MainClass
{
    static void Main()
    {
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
        Cow.Moo();
    }
}

-------------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /r:Farm.dll /out:Jerry.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:38 am    <DIR>          .
28/09/2023  11:38 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:07 am             4,096 Farm.dll
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:38 am             7,782 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               7 File(s)         23,261 bytes
               5 Dir(s)  487,342,755,840 bytes free

----------------------Erase Farm.dll-------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>erase Farm.dll

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:41 am    <DIR>          .
28/09/2023  11:41 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:41 am             9,205 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               6 File(s)         20,588 bytes
               5 Dir(s)  487,340,498,944 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Bill.exe
Moooooooooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Jerry.exe
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1

---------------CREATED--------for recreation of deleted Farm.dll--------------
[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

//class MainClass
//{
//    static void Main()
//    {

//    }
//}

//class MainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//    }
//}

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Kulpots moooooooooooo version 1");
    }
}
------------------------------------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>csc /t:library /out:Farm.dll /keyfile:Kulpotkey.key Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:50 am    <DIR>          .
28/09/2023  11:50 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj
28/09/2023  11:49 am             4,096 Farm.dll
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:50 am            11,429 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               7 File(s)         26,908 bytes
               5 Dir(s)  487,339,724,800 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>bill.exe
Moooooooooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>jerry.exe
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1
Moooooooooooooooooo version 1

-----------------Unistall gacutil -u Farm---------------------
C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>gacutil -u Farm
Microsoft (R) .NET Global Assembly Cache Utility.  Version 4.0.30319.0
Copyright (c) Microsoft Corporation.  All rights reserved.


Assembly: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=439d39c99d560b47, processorArchitecture=MSIL
Uninstalled: Farm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=439d39c99d560b47, processorArchitecture=MSIL
Number of assemblies uninstalled = 1
Number of failures = 0

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache

28/09/2023  11:53 am    <DIR>          .
28/09/2023  11:53 am    <DIR>          ..
27/09/2023  03:37 pm               189 App.config
28/09/2023  11:36 am             4,096 Bill.exe
27/09/2023  03:37 pm    <DIR>          bin
27/09/2023  03:38 pm             2,406 DotNet Global Assembly Cache.csproj28/09/2023  11:49 am             4,096 Farm.dll
28/09/2023  11:38 am             4,096 Jerry.exe
28/09/2023  11:02 am               596 KulpotKey.key
27/09/2023  03:37 pm    <DIR>          obj
28/09/2023  11:53 am            13,689 Program.cs
27/09/2023  03:37 pm    <DIR>          Properties
               7 File(s)         29,168 bytes
               5 Dir(s)  487,336,415,232 bytes free

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Bill.exe
Kulpots moooooooooooo version 1

C:\Users\sunny\source\repos\DotNet Global Assembly Cache\DotNet Global Assembly Cache>Jerry.exe
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1
Kulpots moooooooooooo version 1




 * 
 */


[assembly: AssemblyVersion("1.0.0.0")]

//public class Cow
//{
//    public static void Moo()
//    {
//        Console.WriteLine("Moooooooooooooooooo version 1");
//    }
//}

//class MainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//    }
//}

//class MainClass
//{
//    static void Main()
//    {
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//        Cow.Moo();
//    }
//}

public class Cow
{
    public static void Moo()
    {
        Console.WriteLine("Kulpots moooooooooooo version 1");
    }
}