using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs
{
    // AbstractProduct   
    public abstract class WinchEntity : BaseEntity<Guid>
    {
        protected WinchEntity(VehicleSizeEnum vehicleSize)
        {
            VehicleSize = vehicleSize;
        }

        public abstract void Rescuer(VehicleEntity vehicleEntity);

        public VehicleSizeEnum VehicleSize { get; }
    }
}
