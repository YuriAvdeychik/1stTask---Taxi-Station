using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    class PassTaxi : ITaxi, IRepairable
    {
        public TaxiTypes TaxiType { get; }
        public int Speed { get; }
        public int Price { get; set; }
        public int Consumption { get; set; }
        public int Capacity { get; }

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
        }

        public void GoToWork()
        {
            Console.WriteLine("Pass taxi moved on work!");
        }

        public void Repair()
        {
            Console.WriteLine("Pass taxi has been moved to autoservice");
        }
    }
}
