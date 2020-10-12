using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using GoF.Group01Creational.C0101AbstractFactory.Factories;
using System.Collections.Generic;

namespace GoF.Group01Creational.C0101AbstractFactory
{
    public class AbstractFactoryRun
    {
        public static void Run()
        {
            var rescuedVehicles = new List<VehicleEntity>
            {
                VehicleEntityFactory.Create("Mini", VehicleSizeEnum.Small),
                VehicleEntityFactory.Create("Peugeot 308 SW", VehicleSizeEnum.Average),
                VehicleEntityFactory.Create("BMW X6", VehicleSizeEnum.Big),
            };

            //rescuedVehicles.ForEach(v => TowingVehicle);
        }
    }
}
