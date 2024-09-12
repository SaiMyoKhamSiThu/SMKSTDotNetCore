// See https://aka.ms/new-console-template for more information
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


string connectionString = "Data Source = . ; Initial Catalog = DotNetTrainingBatch5; User ID = sa; Password = sasa@123;";
Console.WriteLine("Connection String : " + connectionString);
SqlConnection connection = new SqlConnection(connectionString);

Console.WriteLine("Connection opening...");
connection.Open();
Console.WriteLine("Connection opened...");

string query = @"SELECT [BlogId]
      ,[BlogTitle]
      ,[BlogAuthor]
      ,[BlogContent]
      ,[DeleteFlag]
  FROM [dbo].[Tbl_Blog] where DeleteFlag = 0";
      
SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd); // to recevie the query
//DataTable dt = new DataTable();
//adapter.Fill(dt); // execute method in C#

SqlDataReader reader = cmd.ExecuteReader();
while(reader.Read())
{
    Console.WriteLine(reader["BlogId"]);
    Console.WriteLine(reader["BlogTitle"]);
    Console.WriteLine(reader["BlogAuthor"]);
    Console.WriteLine(reader["BlogContent"]);
    Console.WriteLine(reader["DeleteFlag"]);
}

Console.WriteLine("Connection closing...");
connection.Close();
Console.WriteLine("Connection closed...");

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//    Console.WriteLine(dr["DeleteFlag"]);
//}

Console.ReadKey();