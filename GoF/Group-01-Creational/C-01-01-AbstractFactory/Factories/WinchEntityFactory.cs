using GoF.Group01Creational.C0101AbstractFactory.Entities.Winchs;
using GoF.Group01Creational.C0101AbstractFactory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Group01Creational.C0101AbstractFactory.Factories
{
    public static class WinchEntityFactory
    {
        private static readonly List<WinchEntity> winchs;

        static WinchEntityFactory()
        {
            winchs = new List<WinchEntity>();
        }

        public static WinchEntity Create(VehicleSizeEnum vehicleSizeEnum)
        {
            var id = Guid.NewGuid();
            switch (vehicleSizeEnum)
            {
                case VehicleSizeEnum.Small:
                    break;
                case VehicleSizeEnum.Average:
                    break;
                case VehicleSizeEnum.Big:
                    break;
                default:
                    throw new ApplicationException("Porte de guincho desconhecido.");
            }

            return null;
        }
    }
}
