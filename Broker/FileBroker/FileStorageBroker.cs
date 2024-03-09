﻿using Car.Crud.Broker.FileStorageBroker;
using Car.Crud.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Car.Crud.Broker.FileBroker
{
    internal class FileStorageBroker : IFileStorageBroker
    {
        private const string FilePath = "../../../DTO/ACar.txt";

        public FileStorageBroker()
        {
            IsFileExists();
        }

        public ACar AddCar(ACar car)
        {
            File.AppendAllText(FilePath, $"{car.Id}-{car.Name}-{car.Color}-{car.Number}\n");
            return car;
        }

        public bool DeleteACar(string number)
        {
            bool res = false;
            string[] carInfo = File.ReadAllLines(FilePath);

            for (int i = 0; i < carInfo.Length; i++)
            {
                string carLine = carInfo[i];
                string[] car = carLine.Split('-');
                if (car[3].Contains(number))
                {
                    carInfo[i] = null;
                    res = true;
                }
            }
            if (res is true)
            {
                File.Delete(FilePath);
                File.Create(FilePath).Close();
                for (int i = 0; i < carInfo.Length; i++)
                {
                    if (carInfo[i] is not null)
                    {
                        File.AppendAllText(FilePath,$"{carInfo[i]}\n");  
                    }
                }
                return true;
            }
            return false;
        }
        public List<ACar> ReadALlCars()
        {
            List<ACar> cars = new List<ACar>();
            string[] information = File.ReadAllLines(FilePath);

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

        private void IsFileExists()
        {
            bool isThere = File.Exists(FilePath);
            if (isThere is false) 
            {
                File.Create(FilePath).Close();
            }
        }
    }
}
