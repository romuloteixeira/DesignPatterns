using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs
{
    // Concrete Product
    public class SmallWinchEntity : WinchEntity
    {
        public SmallWinchEntity() : base(VehicleSizeEnum.Small)
        {

        }

        public override void Rescuer(VehicleEntity vehicleEntity)
        {
            Console.WriteLine($"Socorrendo Carro Pequeno - Modelo {vehicleEntity.Model}");
        }
    }
}
