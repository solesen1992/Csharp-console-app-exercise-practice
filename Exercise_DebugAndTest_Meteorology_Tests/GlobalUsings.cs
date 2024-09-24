global using Xunit;

/*
 * The line global using Xunit; is a feature that imports the Xunit namespace globally for the entire project. 
 * This means that the Xunit namespace will be available in all files within the project, and you don't need 
 * to add using Xunit; at the top of each file where you want to use xUnit functionalities.
 * 
 * Key Points:
 * xUnit Framework: xUnit is a popular unit testing framework in C#. It provides classes and attributes like 
 * [Fact], [Theory], Assert, and more to write and run unit tests.
 * 
 * Global Using Directive: In C# 10, a global using directive allows a namespace to be imported across all 
 * files within a project. This reduces repetition, as there's no need to include using Xunit; in every test file.
 * 
 * Purpose in Testing: By adding global using Xunit;, you are making all xUnit-specific types and methods 
 * (like Assert.Equal, [Fact], etc.) available throughout the entire test project.
 */