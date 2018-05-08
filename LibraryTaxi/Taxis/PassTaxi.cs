using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    class PassTaxi : ITaxi, IFuelable
    {
        public TaxiTypes TaxiType { get; }
        public int Speed { get; }
        public int Price { get; set; }
        public int Consumption { get; set; }
        public int Capacity { get; }
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
            Console.WriteLine("Pass taxi is fueling up");
            Consumption += fuelVolume;
            IsReadyToWork = true;
            Console.WriteLine("Pass taxi completed fueling");
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
