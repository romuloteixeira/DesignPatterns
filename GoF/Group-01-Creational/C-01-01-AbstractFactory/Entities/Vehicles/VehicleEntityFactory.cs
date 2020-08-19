using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GoF.Group01Creational.C0101AbstractFactory.Entities.Vehicles
{
    public static class VehicleEntityFactory
    {
        private static readonly List<BigVehicleEntity> bigVehicles;
        private static readonly List<AverageVehicleEntity> averageVehicles;
        private static readonly List<SmallVehicleEntity> smallVehicles;

        static VehicleEntityFactory()
        {
            bigVehicles = new List<BigVehicleEntity>();
            averageVehicles = new List<AverageVehicleEntity>();
            smallVehicles = new List<SmallVehicleEntity>();
        }

        public static VehicleEntity Create(string model, VehicleSizeEnum vehicleSize)
        {
            var newGuid = Guid.NewGuid();
            switch (vehicleSize)
            {
                case VehicleSizeEnum.Big:
                    var bigVehicleEntity = CreateBigVehicle(model, vehicleSize, newGuid);
                    return bigVehicleEntity;
                case VehicleSizeEnum.Average:
                    var averageVehicleEntity = CreateAverageVehicle(model, vehicleSize, newGuid);
                    return averageVehicleEntity;
                case VehicleSizeEnum.Small:
                    var smallVehicleEntity = CreateSmallVehicle(model, vehicleSize, newGuid);
                    return smallVehicleEntity;
                default:
                    throw new ApplicationException("Porte de veículo desconhecido.");
            }
        }

        private static SmallVehicleEntity CreateSmallVehicle(string model, VehicleSizeEnum vehicleSize, Guid newGuid)
        {
            var smallVehicleEntity = new SmallVehicleEntity(newGuid, model, vehicleSize);
            smallVehicles.Add(smallVehicleEntity);
            return smallVehicleEntity;
        }

        private static AverageVehicleEntity CreateAverageVehicle(string model, VehicleSizeEnum vehicleSize, Guid newGuid)
        {
            var averageVehicleEntity = new AverageVehicleEntity(newGuid, model, vehicleSize);
            averageVehicles.Add(averageVehicleEntity);
            return averageVehicleEntity;
        }

        private static BigVehicleEntity CreateBigVehicle(string model, VehicleSizeEnum vehicleSize, Guid newGuid)
        {
            var bigVehicleEntity = new BigVehicleEntity(newGuid, model, vehicleSize);
            bigVehicles.Add(bigVehicleEntity);
            return bigVehicleEntity;
        }

        public static VehicleEntity Get(Guid id)
        {
            var bigVehicle = bigVehicles.FirstOrDefault(v => v.Id.Equals(id));
            var isBigVehicle = bigVehicle != null;
            if (isBigVehicle)
            {
                return bigVehicle;
            }

            var averageVehicle = averageVehicles.FirstOrDefault(v => v.Id.Equals(id));
            var isAverageVehicle = averageVehicle != null;
            if (isAverageVehicle)
            {
                return averageVehicle;
            }

            var smallVehicle = smallVehicles.FirstOrDefault(v => v.Id.Equals(id));
            return smallVehicle;
        }
    }
}
