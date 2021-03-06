﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using LibraryTaxi.Taxis;

namespace LibraryTaxi.Factory.ConcreteFactories
{
    public class CargoTaxiFactory : TaxiFactory
    {
        public override ITaxi CreateTaxi(TaxiTypes taxiType, int speed, int price, int consumption, int fuel)
        {
            return new CargoTaxi(taxiType, speed, price, consumption, fuel);
        }
    }
}
