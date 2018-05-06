using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    class PassTaxi : ITaxi
    {
        public string Color { get; }
        public int Speed { get; }
        public int Price { get; set; }
        public int Cons { get; set; }

        public PassTaxi(int speed, int price, int cons)
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
        }

        public void GoToWork()
        {
            Console.WriteLine("Pass taxi moved on work!");
        }
    }
}
