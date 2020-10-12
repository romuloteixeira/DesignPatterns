using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Factories.VehicleRescues
{
    public class SmallVehicleRescueFactory : TowingVehicleFactory
    {
        public override WinchEntity CreateWinch()
        {
            throw new NotImplementedException();
        }

        public override VehicleEntity CreateVehicle(string model, VehicleSizeEnum vehicleSizeEnum)
        {
            throw new NotImplementedException();
        }
    }
}
