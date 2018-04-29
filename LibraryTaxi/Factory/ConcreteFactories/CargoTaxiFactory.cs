using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryTaxi.Interface;
using LibraryTaxi.Taxi;

namespace LibraryTaxi.Factory.ConcreteFactories
{
    public class CargoTaxiFactory : TaxiFactory
    {
        public override ITaxi CreateTaxi(int speed, int price, int cons)
        {
            return new CargoTaxi(speed, price, cons);
        }
    }
}
