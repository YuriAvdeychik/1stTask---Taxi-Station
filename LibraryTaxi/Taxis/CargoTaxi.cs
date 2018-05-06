using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    class CargoTaxi : ITaxi, ICargo
    {
        public string Color { get; }
        public int Speed { get; }
        public int Price { get; set; }
        public int Cons { get; set; }
        public int Capacity { get;}

        public CargoTaxi(int speed, int price, int cons, int capacity)
        {
            if (speed > 0)
            {
                Speed = speed;
            }
            if (price > 0)
            {
                Price = price;
            }
            if (cons > 0)
            {
                Cons = cons;
            }
            if (capacity > 0)
            {
                Capacity = capacity;
            }
        }

        public void GoToWork()
        {
            Console.WriteLine("Cargo taxi moved on work!");
        }

    }
}
