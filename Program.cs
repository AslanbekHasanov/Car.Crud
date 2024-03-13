//---------------------------------------------------------------
//Copyright(c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



using Car.Crud.Broker.FileBroker;
using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;
using Car.Crud.Service.CarService;

ICarService carService = new CarService();


ACar car = new ACar()
{
   Id = 5,
   Name = "Honda",
   Color = "White",
   Number = "01AA101AA"
};
var res = carService.AddCar(null);

