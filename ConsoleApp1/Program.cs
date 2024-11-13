// See https://aka.ms/new-console-template for more information
using DemoDB;

var repo = new Repository();
var e = repo.Get();
Console.WriteLine(e.Id);