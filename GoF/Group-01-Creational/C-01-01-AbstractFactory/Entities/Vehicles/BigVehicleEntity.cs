using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles
{
    // Concrete Product
    public class BigVehicleEntity : VehicleEntity
    {
        public BigVehicleEntity(Guid id, string model)
            : base(id, model, VehicleSizeEnum.Big)
        {
        }
    }
}
