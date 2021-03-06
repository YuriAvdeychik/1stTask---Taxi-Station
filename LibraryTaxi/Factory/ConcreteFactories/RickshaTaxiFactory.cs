﻿using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using LibraryTaxi.Taxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Factory.ConcreteFactories
{
    class RickshaTaxiFactory : TaxiFactory
    {
        public override ITaxi CreateTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int fuel)
        {
            return new RickshaTaxi(taxiType, speed, price, consumption);
        }
    }
}
