// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using System.Text.Json.Serialization;
using TEST_OOP;

Console.WriteLine("Hello, World!");
/*
var rivers = new List<River>();
var dnipro = new River(1, "Dnipro");
dnipro.AddFish("Dorado");
dnipro.AddFish("Salmon"); 
dnipro.AddFish("Dorado");

var dunay = new River(2, "Dunay");
dunay.Length = 10m;
rivers.Add(dnipro);
rivers.Add(dunay);

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
};

string path = @"C:SerializeJsonExample.json";
using (FileStream fstream = new FileStream(path, FileMode.Create))
{
    await JsonSerializer.SerializeAsync(fstream, rivers, options);
    Console.WriteLine(@"written in file");
}
*/
PublisherHouse pub1 = new PublisherHouse(2, "Gymnasium", "Adress 2");
PublisherHouse pub2 = new PublisherHouse(1, "Staryi Lev Publisher", "Adress 1");

var book1 = new Book(2, "Manual. Algebra 8 ", pub1);
var book2 = new Book(1, " Neurosurgeon's Diary", pub2);
var book3 = new Book(2, "Manual Algebra 9", pub1);

var options = new JsonSerializerOptions
{
    WriteIndented = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
};

var books = new List<Book>();
books.Add(book1);
books.Add(book2);
books.Add(book3);
string path = @"C:SerializeJsonExample.json";

using (FileStream fstream = new FileStream(path, FileMode.Create))
{
    await JsonSerializer.SerializeAsync(fstream, books, options);
    Console.WriteLine(@"written in file");
}

