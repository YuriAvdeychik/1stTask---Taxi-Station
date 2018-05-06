﻿using LibraryTaxi.Enum;
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
        public override ITaxi CreateTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int capacity)
        {
            return new PassTaxi(taxiType, speed, price, consumption);
        }
    }
}
