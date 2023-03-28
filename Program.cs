using System;
using System.Runtime.InteropServices.JavaScript;

Console.WriteLine("Hello, Browser!");
Console.WriteLine(string.Join(" ", args));

public partial class MyClass
{
    [JSExport]
    internal static string Greeting()
    {
        var text = $"Hello, World! Greetings from {GetHRef()}";
        Console.WriteLine(text);
        return text;
    }

    [JSImport("window.location.href", "main.js")]
    internal static partial string GetHRef();
}


// TO run

// dotnet run

// dotnet tool update dotnet-serve --global
// dotnet serve --directory bin\Debug\net7.0\browser-wasm\AppBundle