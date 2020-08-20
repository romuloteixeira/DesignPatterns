using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs;
using GoF.Group01Creational.C0101AbstractFactory.Enum;

namespace GoF.Group01Creational.C0101AbstractFactory.Factories
{
    public abstract class TowingVehicleFactory
    {
        public abstract WinchEntity CreateWinch();
        public abstract VehicleEntity CreateVehicle(string model, VehicleSizeEnum vehicleSizeEnum);
    }
}
