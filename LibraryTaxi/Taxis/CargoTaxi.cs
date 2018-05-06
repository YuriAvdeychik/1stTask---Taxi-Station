using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    public class CargoTaxi : ITaxi
    {
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }

            set
            {
                if (value < 0)
                {
                    speed = 0;   
                }
                else
                {
                    speed = value;
                }
            }
        }
        public int Price { get; }
        public int Cons { get; }
        
        public CargoTaxi(int speed, int price, int cons)
        {
            Speed = speed;
            Price = price;
            Cons = cons;
        }

        public void GoToWork()
        {
            Console.WriteLine("Cargo taxi moved on work!");
        }
    }
}
