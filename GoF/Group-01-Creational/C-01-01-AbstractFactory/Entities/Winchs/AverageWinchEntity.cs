using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs
{
    // Concrete Product
    public class AverageWinchEntity : WinchEntity
    {
        public AverageWinchEntity() : base(VehicleSizeEnum.Average)
        {
        }

        public override void Rescuer(VehicleEntity vehicleEntity)
        {
            Console.WriteLine($"Socorrendo Carro Medio - Modelo {vehicleEntity.Model}");
        }
    }
}
