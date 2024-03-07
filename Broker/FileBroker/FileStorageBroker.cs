using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Crud.Broker.FileBroker
{
    internal class FileStorageBroker : IFileStorageBroker
    {

        public List<ACar> ReadALlCars()
        {
            List<ACar> cars = new List<ACar>();
            string[] information = File.ReadAllLines("../../../DTO/ACar.txt");

            for(int i = 0; i < information.Length; i++)
            {
                string carLine = information[i];
                string[] carInformationLine = carLine.Split('-');

                ACar car = new ACar()
                {
                    Id = Convert.ToInt32(carInformationLine[0]),
                    Name = carInformationLine[1],
                    Color = carInformationLine[2],
                    Number = carInformationLine[3]
                };
                cars.Add(car);
            }
            return cars;
        }
    }
}
