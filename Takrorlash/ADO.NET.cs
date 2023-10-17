/*

#region Sozlamalar
//ADO.NET sql server package
using Microsoft.Data.SqlClient;
using System.Diagnostics;

// DATABASE Name
const string DATABASE_NAME = "TakrorlashDB";

//ulanish manzili ko'rsatish
string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;";

//yangi ulanish obyektini yaratish
SqlConnection connection = new(); //new(connectionString) mumkin
connection.ConnectionString = connectionString;

//ulanishni ochish
connection.Open();

#endregion

#region Database yaratish
// yangi database yaratish uchun query
string newDatabaseQuery = $"""
    IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = '{DATABASE_NAME}')
    BEGIN
        CREATE DATABASE {DATABASE_NAME};
    END;
""";

//sql command
SqlCommand command = new();
command.Connection = connection;
command.CommandText = newDatabaseQuery;

var result = command.ExecuteNonQuery();
//Console.WriteLine(result);

//ulanish manzilini kengaytirish
connectionString += $"Database={DATABASE_NAME}";

connection = new(connectionString);
command.Connection = connection;
connection.Open();
#endregion

#region Yangi jadval yaratish
//yangi jadval yaratish querysi
string addTableQuery = """
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tests')
    BEGIN
        CREATE TABLE Tests(
            Id int NOT NULL IDENTITY,
            Number int NOT NULL,
            Date date NOT NULL
        );
    END;
""";

//sql command yaratish. query bilan
command.CommandText = addTableQuery;

//run command
result = command.ExecuteNonQuery();
#endregion

//jadvalga ma'lumot qo'shish
Random random = new();
var timer = new Stopwatch();
timer.Start();

for (int i = 0; i < 10000; i++)
{
    var date = UnixTimeStampToDateTime((double)random.Next(1, int.MaxValue));
    string addData = $"INSERT INTO Tests VALUES ({random.Next(1, 1000)}, '{date}')";
    command.CommandText = addData;
    command.ExecuteNonQuery();
}

//B: Run stuff you want timed
timer.Stop();

TimeSpan timeTaken = timer.Elapsed;
string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
Console.WriteLine(foo);

//ulanishni yopish
connection.Close();

DateTime UnixTimeStampToDateTime(double unixTimeStamp)
{
    // Unix timestamp is seconds past epoch
    DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
    dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
    return dateTime;
}
*/