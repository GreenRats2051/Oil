using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
}
