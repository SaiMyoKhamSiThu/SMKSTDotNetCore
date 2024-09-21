// See https://aka.ms/new-console-template for more information
using SMKSTDotNetCore.ConsoleApp;
using System.Collections.Concurrent;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");
Console.WriteLine();
//Console.ReadKey();

//md --> markdown

// C# => Database

// ADO.NET
// Dapper (ORM)
// EFCore / Entity Framework (ORM)

// C# => Sql Query =>

// nuget

// Ctrl + .


AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create();
//adoDotNetExample.Edit();
//adoDotNetExample.Update();
//adoDotNetExample.Delete();

DapperExample dapperExample = new DapperExample();
//dapperExample.Read();
//dapperExample.Create("Lenovo", "Apple", "ROG");
//dapperExample.Edit(1);
//dapperExample.Edit(2);
//dapperExample.Update(1, "shwe", "ngwe", "ruby");
dapperExample.Delete(1);
Console.ReadKey();