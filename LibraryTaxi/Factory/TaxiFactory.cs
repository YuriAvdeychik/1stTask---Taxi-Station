using LibraryTaxi.Enum;
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
        public abstract ITaxi CreateTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int fuel = 0);
    }
}
