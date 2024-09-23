// See https://aka.ms/new-console-template for more information
using SchoolClassProject.Models;
using SchoolClassProject.Repos;

Console.WriteLine("Hello, World!");

SchoolClass a9 = new SchoolClass(9, 'a', 7000);
SchoolClass b9 = new SchoolClass(9, 'b', 6000);

Console.WriteLine(a9);
Console.WriteLine(b9);

if (a9.ClassMoney > b9.ClassMoney)
    Console.WriteLine($"{a9.SchoolYear}.{a9.SchoolClassId} többet fizet mint {b9.SchoolYear}.{b9.SchoolClassId}, {a9.ClassMoney-b9.ClassMoney} Ft-al.");
else if (a9.ClassMoney < b9.ClassMoney)
    Console.WriteLine($"{b9.SchoolYear}.{b9.SchoolClassId} többet fizet mint {a9.SchoolYear}.{a9.SchoolClassId}, {b9.ClassMoney - a9.ClassMoney} Ft-al.");
else
    Console.WriteLine($"{b9.SchoolYear}.{b9.SchoolClassId} ugyan annyit fizet mint {a9.SchoolYear}.{a9.SchoolClassId}");

SchoolClassRepo repo = new SchoolClassRepo();
repo.Add(a9);
repo.Add(b9);
Console.WriteLine($"Osztályok száma az adatábzisba: {repo.NumberOfSchoolClass}.");

repo.Remove(9,'a');
Console.WriteLine($"Osztályok száma az adatábzisba: {repo.NumberOfSchoolClass}.");

repo.Update(9, 'b', 8000);
SchoolClass? schoolClass = repo.SchoolClasses.Find(schoolClass => schoolClass.SchoolYear == 9 && schoolClass.SchoolClassId == 'b');
if (schoolClass is not null)
    Console.WriteLine(schoolClass.ClassMoney);

repo.Remove(b9);
Console.WriteLine($"Osztályok száma az adatábzisba: {repo.NumberOfSchoolClass}.");



