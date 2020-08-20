using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using GoF.Group01Creational.C0101AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Group01Creational.C0101AbstractFactory
{
    public class AbstractFactoryRun
    {
        public static void Run()
        {
            var rescuedVehicles = new List<VehicleEntity>
            {
                VehicleEntityFactory.NewVehicle("Mini", VehicleSizeEnum.Small),
                VehicleEntityFactory.NewVehicle("Peugeot 308 SW", VehicleSizeEnum.Average),
                VehicleEntityFactory.NewVehicle("BMW X6", VehicleSizeEnum.Big),
            };

            //rescuedVehicles.ForEach(v => );
        }
    }
}
