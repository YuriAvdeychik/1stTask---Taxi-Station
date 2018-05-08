using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxis
{
    public class RickshaTaxi : ITaxi, IExtraditionable
    {
        public TaxiTypes TaxiType { get;}
        public int Speed { get; set; }
        public int Price { get; set; }
        public int Consumption { get; set; }
        public int Fuel { get;}
        public bool IsReadyToWork { get; set; }

        public RickshaTaxi(TaxiTypes taxiType, int speed, int price, int consumption)
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
            IsReadyToWork = true;
        }

        public void GoToWork()
        {
            Console.Write("Ricksha taxi moved on work");
        }

        public void GoToFuelStation()
        {
        }

        public void Extradition()
        {
            Console.Write("Ricksha has been extradited to Vietnam");
        }
    }
}
