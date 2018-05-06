using LibraryTaxi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Factory
{
    public abstract class TaxiFactory
    {
        public abstract ITaxi CreateTaxi(int speed, int price, int cons, int capacity = 0);
    }
}
