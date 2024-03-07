// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Models.Cars;

namespace Car.Crud.Broker.FileStorageBroker
{
    internal interface IFileStorageBroker
    {
        //read-all
        List<ACar> ReadALlCars();
        ACar AddCar(ACar car);
    }
}
