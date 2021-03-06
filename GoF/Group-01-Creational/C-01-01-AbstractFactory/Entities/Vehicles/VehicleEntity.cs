﻿using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles
{
    // AbstractProduct
    public abstract class VehicleEntity : BaseEntity<Guid>
    {
        protected VehicleEntity(Guid id, string model, VehicleSizeEnum vehicleSize)
        {
            Id = id;
            Model = model;
            VehicleSize = vehicleSize;
        }

        public string Model { get; protected set; }
        public VehicleSizeEnum VehicleSize { get; protected set; }
    }
}
