using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using LibraryTaxi.Taxi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi
{
    public class FuelStation
    {
        public void FuelStationWork(IFuelable taxi, int fuelVollume)
        {
            taxi.FuelUp(fuelVollume);
        }
    }
}
