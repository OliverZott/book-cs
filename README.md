# C# 9 and .NET 5

## Resources
https://github.com/markjprice/cs9dotnet5

https://static.packt-cdn.com/downloads/9781800568105_Appendices.pdf

https://github.com/markjprice/cs9dotnet5-extras


## Todo
- Examples in book
- Theoretical questions in book
- Algorithm and Datastructure examples (book) 


----------------------------------------------------------------------
# Chapter 1 - Intro
https://docs.microsoft.com/de-de/dotnet/core/introduction?source=docs

- History: **.NET Framework 4.8** --> **.NET Core 3.1** --> **.NET 5**
- Components:
  - Entity Framework Core 
  - ASP.NET Core
- Language flow: 
  1. Source code (C#, F#, Basic)
  1. **Roslyn** ... C# Compiler used by dotnet CLI tool
  1. **IL** .. Intermediate Language (stored in assembly: DLL, EXE)
  1. **Core CLR** ... Common Language Runtime (virtual maching) executing IL



----------------------------------------------------------------------
# Chapter 2 - C# 

## Content
- C# Basics
- Variables
- Null Values
- Console Applications

## Remarks
- **Type** (class, struct, enum, interface, delegate)
- **double** vs **decimal**
- **Aliases** C# <---> .NET
- **value type** vs **reference type**
- **Null Value** (p.57)
  - value types NOT nullable / reference type nullabel
  - option (project / file) to not allow nullable reference types by `#nullable enable`
  - check: `is null` 
- Null operators:
  - `x?` ... makes x nullable
  - [Ternary conditional operator ?:](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator)       `condition ? consequent : alternative`
  - [Null-conditional operators ?. and ?[]](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-)
  - [null-coalescing operator ?? and  null-coalescing assignment operator ??=](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)



----------------------------------------------------------------------
# Chapter 3 - Controll Flow and Converting

## Content
- Conditions and loops
- Conversions
- **Pattern Matching**
- Exception Handling
- Overflow

## Remarks
- **Pattern Matching** & **switch expressions**
- 



----------------------------------------------------------------------
# Chapter 4 - Functions

## Content
- Functional programming: *imperative* vs *declarative*
- Debugging
- Logging
- Unit Testing

## Remarks
- **Trace Listener** level *debug* and *trace*
- **xunit**
  - Arrange, Act, Assert
  - `dotnet new classlib`, `dotnet new xunit`, `dotnet build`



----------------------------------------------------------------------
# Chapter 5 - Oop
(page 141)
## Content 
- class libraries
- fields / methods
- properties / indexers / enum
- *Pattern Matching* with objects
- **records**

## Remarks
- Access modifiers (p. 149)
- **readonly** better then **const**
- **Tuples** ... why  ???
- **Pattern mathing** ... what/how  ???


----------------------------------------------------------------------
# Chapter 6 - Interfaces & Classes

