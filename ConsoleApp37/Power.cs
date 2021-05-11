using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    public class Power : IPower
    {
        public int MicrowavePower { get; protected set; }

        public Power()
        {
        }

        public void GetPower(int powerValue)
        {
            MicrowavePower = powerValue;
        }
    }
}
