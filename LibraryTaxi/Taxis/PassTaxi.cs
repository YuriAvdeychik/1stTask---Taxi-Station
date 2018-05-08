using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxis
{
    class PassTaxi : ITaxi, IFuelable
    {
        public TaxiTypes TaxiType { get;}
        public int Speed { get; set; }
        public int Price { get; set; }
        public int Consumption { get; set; }
        public int Capacity { get;}
        public bool IsReadyToWork { get; set; }

        public PassTaxi(TaxiTypes taxiType, int speed, int price, int consumption)
        {
            if (speed > 0)
            {
                Speed = speed;
            }
            if (price > 0)
            {
                Price = price;
            }
            if (consumption > 0)
            {
                Consumption = consumption;
            }
            TaxiType = taxiType;
            if (consumption == 0)
            {
                IsReadyToWork = false;
            }
            else
            {
                IsReadyToWork = true;
            }
        }

        public void FuelUp(ushort fuelVolume)
        {
            IsReadyToWork = false;
            Console.WriteLine("{0} Pass taxi is fueling up with {1} fuel", Price, Consumption);
            Consumption += fuelVolume;
            IsReadyToWork = true;
            Console.WriteLine("{0} Pass taxi completed fueling with {1} fuel", Price, Consumption);
        }

        public void GoToWork()
        {
            Console.Write("Pass taxi moved on work");
        }

        public void GoToFuelStation()
        {
            Console.Write("Pass taxi moved to FuelStation");
        }

    }
}
