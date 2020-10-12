using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs
{
    // Concrete Product
    public class BigWinchEntity : WinchEntity
    {
        public BigWinchEntity() : base(VehicleSizeEnum.Big)
        {

        }

        public override void Rescuer(VehicleEntity vehicleEntity)
        {
            Console.WriteLine($"Socorrendo Carro Grande - Modelo {vehicleEntity.Model}");
        }
    }
}
