using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles
{
    public class AverageVehicleEntity : VehicleEntity
    {
        public AverageVehicleEntity(Guid id, string model, VehicleSizeEnum vehicleSize)
            : base(id, model, vehicleSize)
        {
        }
    }
}
