using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTaxi.Interface
{
    public interface ITaxi
    {
        int Speed { get; }
        int Price { get; }
        int Cons { get; }

        void GoToWork();
    }
}
