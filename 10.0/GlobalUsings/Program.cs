// See https://aka.ms/new-console-template for more information

var names = new[] { "Prasad", "Praveen" };
var serialized = JsonSerializer.Serialize(names);
Console.WriteLine(serialized);