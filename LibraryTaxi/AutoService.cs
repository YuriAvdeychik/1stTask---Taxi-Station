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
    public class AutoService
    {
        IRepairable taxi;
        taxi.OnRepair = true;

        public void AutoServiceWork()
        {
            cargoTaxi.Repair();
            passTaxi.Repair();
        }
    }
}
