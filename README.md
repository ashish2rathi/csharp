# CSharp Language
- [Versioning Table](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version)
- [Github Repo](https://github.com/dotnet/csharplang)
---

# CSharp 8.0

## _References_
- [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8)
- [Learn C# 8.0](https://www.c-sharpcorner.com/learn/learn-c-sharp-80)

## _Prerequisite_
- C# 8 features comes with .NET Core 3.x and .NET Standard 2.1 SDK installation
- C# 8 is supported on .NET Core 3.x and .NET Standard 2.1
- C# 8 is automatically selected as default version in .NET Core 3.x projects
- To enable C# 8 features in .NET Core 2.x projects you have to add below line in .csproj file
```sh
<LangVersion>8</LangVersion>
```

 ## _Implemented Features_
 1. Default Interface Implementation
 2. Nullable Reference Types
 3. Null-Coalescing Assignment Operator
 4. Null Forgiving Operator
 5. Nullable Enable
 6. Switch Expressions
 7. Using Declaration

---
# CSharp 9.0

## _References_
- [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9)
- [Deep Dive into C# 9.0](https://www.c-sharpcorner.com/article/deev-dive-into-c-sharp-9/)
- [Introduction to the New Features in C# 9](https://medium.com/swlh/an-introduction-to-the-new-features-in-c-9-305dc8fb74d2)
 
## _Prerequisite_
- C# 9 features comes with .NET 5 SDK installation
- C# 9 is supported on .NET 5
- C# 9 is automatically selected as default version in .NET 5 projects
- To enable C# 8 features in lower versions of .NET you have add below line in .csproj file
```sh
<LangVersion>9</LangVersion>
```

 ## _Implemented Features_
 1. [Records](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/records)
 2. [Init Only Setters](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/init)
 3. [Top-Level Statements](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/top-level-statements)
 4. [Pattern Matching](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/patterns3)
 5. [Module Initializers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/module-initializers)
 6. [Extending Partial Methods](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-9.0/extending-partial-methods)
 7. [Fit and Finish](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#fit-and-finish-features)

---

# CSharp 10.0

## _References_
- [Microsoft Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-10)
- [C# 10 Features C-SharpCorner](https://www.c-sharpcorner.com/blogs/c-sharp-10-features)

 
## _Prerequisite_
- C# 10 features comes with .NET 6 SDK installation
- C# 10 is supported only on .NET 6, and is automatically selected as default version in .NET 6 projects
- .NET 6.0 features comes with Visual Studio 2022, and its not supported in other lower versions of visual studio


 ## _Implemented Features_
 1. [Global Usings](https://www.c-sharpcorner.com/blogs/c-sharp-10-features)
 2. [File Scoped Namespaces](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/file-scoped-namespaces)
 3. [Constant Interpolated Strings](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-10.0/constant_interpolated_strings)
 4. [Extended Property Patterns](https://anthonygiretti.com/2021/07/27/introducing-c-10extended-property-patterns/)
 
 ---