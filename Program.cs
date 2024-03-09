// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Broker.FileBroker;
using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;

IFileStorageBroker storageBroker = new FileStorageBroker();

if(storageBroker.DeleteACar("70AA211DA"))
{
    Console.WriteLine("Deleted");
}
else
{
    Console.WriteLine("Not Found");
}