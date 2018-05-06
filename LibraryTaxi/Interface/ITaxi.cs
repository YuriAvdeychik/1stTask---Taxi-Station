using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Interface
{
    public interface ITaxi
    {
        string Color { get; }
        int Speed { get;}
        int Price { get; set; }
        int Cons { get; set; }

        void GoToWork();
    }
}
