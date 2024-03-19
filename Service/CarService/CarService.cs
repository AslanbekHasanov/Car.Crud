using Car.Crud.Broker.FileBroker;
using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Broker.LoggingBroker;
using Car.Crud.Models.Cars;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Crud.Service.CarService
{
    internal class CarService : ICarService
    {
        //SOLID
        private readonly IFileStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public CarService()
        {
            this.storageBroker = new FileStorageBroker();
            this.loggingBroker = new LoggingBroker();
        }

        public ACar AddCar(ACar car)
        {
            return car is null
                ? AddCarIsNullOrEmpty()
                : ValidationAddCar(car);
        }

        public bool DeleteACar(string number)
        {
            return number is null
                ? DeleteCarIsNullorEmpty()
                : ValidationDeleteCar(number);
        }

        public List<ACar> ReadALlCars()
        {
            List<ACar> cars = this.storageBroker.ReadALlCars();

            foreach (ACar car in cars)
            {
                this.loggingBroker.LogInformation($"{car.Id}. {car.Name} {car.Color} {car.Number}");
            }

            this.loggingBroker.LogInformation($"=== End of contacts ===");

            return cars;
        }

        public ACar ReadCar(int id)
        {
            return id is 0
                ? ReadCarIsNullorEmpty()
                : ValidationReadCar(id);
        }

        public bool Update(ACar car)
        {
            return car is null
                ? UpdateIsNullOrEmpty()
                : ValidationAndUpdateCar(car);
        }

        private bool ValidationAndUpdateCar(ACar car)
        {
            if (car.Id is 0
                || String.IsNullOrWhiteSpace(car.Name)
                || String.IsNullOrWhiteSpace(car.Color)
                || String.IsNullOrWhiteSpace(car.Number))
            {
                this.loggingBroker.LogErorr("Invalid car information.");
                return false;
            }
            else
            {
                bool result = this.storageBroker.Update(car);
                if (result is false)
                {
                    this.loggingBroker.LogErorr("Not Found.");
                }
                else
                {
                    this.loggingBroker.LogInformation("Updated.");
                }
                return result;
            }
        }

        private bool UpdateIsNullOrEmpty()
        {
            this.loggingBroker.LogErorr("Car information is null.");
            return false;
        }

        private ACar ValidationAddCar(ACar car)
        {
            if (string.IsNullOrWhiteSpace(car.Id.ToString())
                || string.IsNullOrWhiteSpace(car.Name)
                || string.IsNullOrWhiteSpace(car.Color)
                || string.IsNullOrWhiteSpace(car.Number)
                ) 
            {
                this.storageBroker.AddCar(car);
                this.loggingBroker.LogInformation("Added a one car !");
                return car;
            }
            else
            {
                this.loggingBroker.LogInformation("No car information available!");
                return new ACar();
            }
        }

        private bool ValidationDeleteCar(string number)
        {
            if (String.IsNullOrWhiteSpace(number) is true)
            {
                this.loggingBroker.LogErorr("Number invalid.");
                return false;
            }
            else
            {
                bool result = this.storageBroker.DeleteACar(number);
                if (result is true)
                {
                    this.loggingBroker.LogInformation("Delete a car.");
                }
                else
                {
                    this.loggingBroker.LogErorr("Not Found.");
                }
                return result;
            }
        }

        private bool DeleteCarIsNullorEmpty()
        {
            this.loggingBroker.LogErorr("Number is null or empty.");
            return false;
        }

        private ACar AddCarIsNullOrEmpty()
        {
            this.loggingBroker.LogErorr("Car data is null");
            return new ACar();
        }

        private ACar ReadCarIsNullorEmpty()
        {
            this.loggingBroker.LogErorr("Id is null or empty");
            return new ACar();
        }

        private ACar ValidationReadCar(int id)
        {
            if (String.IsNullOrWhiteSpace(id.ToString()) is true)
            {
                this.loggingBroker.LogErorr("Id invalid");

                return new ACar();
            }
            else 
            {
                ACar result = this.storageBroker.ReadCar(id);
                if (result.Id is not 0)
                {
                    this.loggingBroker.LogInformation("Sucesefull");
                    Console.WriteLine($"\n{result.Id}. {result.Name} {result.Color} {result.Number}");
                }
                else
                {
                    this.loggingBroker.LogErorr("Not found.");
                }
                return result;
            }

        }
    }
}
