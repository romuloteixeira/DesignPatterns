using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;

namespace GoF.Group01Creational.C0101AbstractFactory
{
    public abstract class TowingVehicleFactory
    {
        public abstract Winch CreateWinch();
        public abstract VehicleEntity CreateVehicle(string model, VehicleSizeEnum vehicleSizeEnum);
    }
}
