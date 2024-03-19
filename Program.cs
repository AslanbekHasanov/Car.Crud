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
        Console.WriteLine("Enter the car id");
        int id = Convert.ToInt32(Console.ReadLine());
        carService.ReadCar(id);
    }

    if (isContinue1 == "3")
    {
        Console.WriteLine("Enter the car id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name of the car");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the color of the car");
        string color = Console.ReadLine();
        Console.WriteLine("Enter the number of the car");
        string number = Console.ReadLine();
        //carService.AddCar(id,name,color,number);
    }

    if (isContinue1 == "4")
    {
        Console.WriteLine("Enter the number of the car");
        string number = Console.ReadLine();
        carService.DeleteACar(number);
    }

    if (isContinue1 == "5")
    {
        Console.WriteLine("Enter the car id");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name of the car");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the color of the car");
        string color = Console.ReadLine();
        Console.WriteLine("Enter the number of the car");
        string number = Console.ReadLine();
    }
    if (isContinue1 == "No")
    {
        isContinue = false;
    }
} while (isContinue is true);

