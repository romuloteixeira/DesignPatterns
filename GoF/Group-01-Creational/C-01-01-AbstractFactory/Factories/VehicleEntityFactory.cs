using GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoF.Group01Creational.C0101AbstractFactory.Factories
{
    public static class VehicleEntityFactory
    {
        private static readonly List<VehicleEntity> vehicles;

        static VehicleEntityFactory()
        {
            vehicles = new List<VehicleEntity>();
        }

        public static VehicleEntity Create(string model, VehicleSizeEnum vehicleSize)
        {
            var newGuid = Guid.NewGuid();
            switch (vehicleSize)
            {
                case VehicleSizeEnum.Big:
                    var bigVehicleEntity = CreateBigVehicle(model, newGuid);
                    return bigVehicleEntity;
                case VehicleSizeEnum.Average:
                    var averageVehicleEntity = CreateAverageVehicle(model, newGuid);
                    return averageVehicleEntity;
                case VehicleSizeEnum.Small:
                    var smallVehicleEntity = CreateSmallVehicle(model, newGuid);
                    return smallVehicleEntity;
                default:
                    throw new ApplicationException("Porte de veículo desconhecido.");
            }
        }

        private static SmallVehicleEntity CreateSmallVehicle(string model, Guid newGuid)
        {
            var smallVehicleEntity = new SmallVehicleEntity(newGuid, model);
            vehicles.Add(smallVehicleEntity);
            return smallVehicleEntity;
        }

        private static AverageVehicleEntity CreateAverageVehicle(string model, Guid newGuid)
        {
            var averageVehicleEntity = new AverageVehicleEntity(newGuid, model);
            vehicles.Add(averageVehicleEntity);
            return averageVehicleEntity;
        }

        private static BigVehicleEntity CreateBigVehicle(string model, Guid newGuid)
        {
            var bigVehicleEntity = new BigVehicleEntity(newGuid, model);
            vehicles.Add(bigVehicleEntity);
            return bigVehicleEntity;
        }

        public static VehicleEntity Get(Guid id)
        {
            var vehicleEntity = vehicles.FirstOrDefault(v => v.Id.Equals(id));
            return vehicleEntity;
        }

        public static VehicleType Get<VehicleType>(Guid id) where VehicleType : VehicleEntity
        {
            var vehicleEntity = (VehicleType)Get(id);
            return vehicleEntity;
        }
    }
}
