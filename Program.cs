//---------------------------------------------------------------
//Copyright(c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------

using Car.Crud.Broker.FileBroker;
using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;
using Car.Crud.Service.CarService;
using System;
CarService carService = new CarService();
bool isContinue = true;
do
{
    Console.Clear();
    Console.WriteLine("  >>>    Hello!  Welcome To The Car Market     <<<  ");
    Console.WriteLine();
    Console.WriteLine("1. View the list of cars.");
    Console.WriteLine("2. Display information of one car.");
    Console.WriteLine("3. Add a new car.");
    Console.WriteLine("4. Deregistration of the car.");
    Console.WriteLine("5. Adding updated changes.");
    Console.WriteLine();

    Console.Write("Select a command: ");
    string isContinue1 = Convert.ToString(Console.ReadLine());
   
    if (isContinue1 == "1")
    {
      carService.ReadALlCars();
    }

    if (isContinue1 == "2")
    {
        Console.Write("Enter the car id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        carService.ReadCar(id);
    }

    if (isContinue1 == "3")
    {
        ACar car = new ACar(); 
        Console.Write("Enter the car id: ");
        car.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the name of the car: ");
        car.Name = Console.ReadLine();
        Console.Write("Enter the color of the car: ");
        car.Color = Console.ReadLine();
        Console.Write("Enter the number of the car: ");
        car.Number = Console.ReadLine();

        carService.AddCar(car);
    }

    if (isContinue1 == "4")
    {
        Console.Write("Enter the number of the car: ");
        string number = Console.ReadLine();
        carService.DeleteACar(number);
    }

    if (isContinue1 == "5")
    {
        ACar car = new ACar();
        Console.Write("Enter the car id: ");
        car.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the name of the car: ");
        car.Name = Console.ReadLine();
        Console.Write("Enter the color of the car: ");
        car.Color = Console.ReadLine();
        Console.Write("Enter the number of the car: ");
        car.Number = Console.ReadLine();

        carService.Update(car);
    }

    Console.Write("\nIs cantinue: (yes/ no) ");
    string isCantinueCommand = Console.ReadLine();
    if (isCantinueCommand.ToLower().Contains("no"))
    {
        isContinue = false;
    }
} while (isContinue is true);

