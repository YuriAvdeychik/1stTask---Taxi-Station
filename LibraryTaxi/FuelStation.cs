using LibraryTaxi.Enum;
using LibraryTaxi.Interface;
using LibraryTaxi.Taxis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi
{
    public class FuelStation
    {
        public void FuelStationWork(IFuelable taxi, ushort fuelVollume)
        {
            taxi.FuelUp(fuelVollume);
        }
    }
}
