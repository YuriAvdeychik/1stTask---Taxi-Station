using LibraryTaxi.Interface;
using LibraryTaxi.Taxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Factory.ConcreteFactories
{
    class PassTaxiFactory : TaxiFactory
    {
        public override ITaxi CreateTaxi(int speed, int price, int cons)
        {
            return new PassTaxi(speed, price, cons);
        }
    }
}
