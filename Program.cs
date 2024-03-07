// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Broker.FileBroker;
using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;

IFileStorageBroker storageBroker = new FileStorageBroker();

List<ACar> cars = storageBroker.ReadALlCars();

foreach(var car in cars )
{
    Console.WriteLine($"{car.Id}. {car.Name} - {car.Color} - {car.Number}");

}