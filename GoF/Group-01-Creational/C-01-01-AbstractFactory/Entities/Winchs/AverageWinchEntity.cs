using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs
{
    // Concrete Product
    public class AverageWinchEntity : WinchEntity
    {
        public AverageWinchEntity(VehicleSizeEnum vehicleSize) : base(vehicleSize)
        {
        }

        public override void Rescuer(VehicleEntity vehicleEntity)
        {
            Console.WriteLine($"Socorrendo Carro Medio - Modelo {vehicleEntity.Model}");
        }
    }
}
