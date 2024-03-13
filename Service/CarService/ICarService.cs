using Car.Crud.Models.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Crud.Service.CarService
{
    internal interface ICarService
    {
        List<ACar> ReadALlCars();
        ACar ReadCar(int id);
        ACar AddCar(ACar car);
        bool DeleteACar(string number);
        bool Update(ACar car);
    }
}
