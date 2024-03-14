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
            throw new NotImplementedException();
        }

        public List<ACar> ReadALlCars()
        {
            throw new NotImplementedException();
        }

        public ACar ReadCar(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(ACar car)
        {
            throw new NotImplementedException();
        }

        private ACar ValidationAddCar(ACar car)
        {
            if (string.IsNullOrWhiteSpace(car.Id.ToString())
                && string.IsNullOrWhiteSpace(car.Name)
                && string.IsNullOrWhiteSpace(car.Color)
                && string.IsNullOrWhiteSpace(car.Number)
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

        private ACar AddCarIsNullOrEmpty()
        {
            this.loggingBroker.LogErorr("Car data is null");
            return new ACar();
        }
    }
}
