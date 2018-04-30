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
        public int Speed { get; }
        public int Price { get; }
        public int Cons { get; }

        public PassTaxi(int speed, int price, int cons)
        {
            Speed = speed;
            Price = price;
            Cons = cons;
        }
    }
}
