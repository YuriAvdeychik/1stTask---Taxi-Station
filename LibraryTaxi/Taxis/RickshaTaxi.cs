﻿using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Taxi
{
    class RickshaTaxi : ITaxi
    {
        public int Speed { get; }
        public int Price { get; }
        public int Cons { get; }

        public RickshaTaxi(int speed, int price, int cons)
        {
            Speed = speed;
            Price = price;
            Cons = cons;
        }

        public void GoToWork()
        {
            Console.WriteLine("Ricksha taxi moved on work!");
        }
    }
}
