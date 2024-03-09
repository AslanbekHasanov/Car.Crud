// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Broker.FileBroker;
using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;

IFileStorageBroker storageBroker = new FileStorageBroker();

ACar result = storageBroker.ReadCar(1);
if (result.Id != 0)
{
    Console.WriteLine("Id: " + result.Id);
    Console.WriteLine("Name: " + result.Name);
    Console.WriteLine("Color: " + result.Color);
    Console.WriteLine("Number: " + result.Number);
}
else
{
    Console.WriteLine("Not Found!");
}