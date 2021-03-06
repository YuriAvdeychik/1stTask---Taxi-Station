﻿using LibraryTaxi.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Interface
{
    public interface ITaxi
    {
        TaxiTypes TaxiType { get; }
        int Speed { get; set; }
        int Price { get; set; }
        int Consumption { get; }
        int Fuel { get; }
        void GoToWork();
        void GoToFuelStation();
        bool IsReadyToWork { get; set; }
    }
}
