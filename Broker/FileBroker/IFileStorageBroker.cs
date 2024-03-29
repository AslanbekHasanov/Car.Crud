﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Models.Cars;
using System.Collections.Generic;

namespace Car.Crud.Broker.FileStorageBroker
{
    internal interface IFileStorageBroker
    {
        //read-all
        List<ACar> ReadALlCars();
        ACar ReadCar(int id);
        ACar AddCar(ACar car);
        bool DeleteACar(string number);
        bool Update(ACar car);
    }
}
